using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Text;

namespace dotNetTips.Spargine.Common
{
    [StructLayout(LayoutKind.Auto)]
    [Serializable]
    public readonly partial struct Date : IComparable, IFormattable, IConvertible, IComparable<Date>, IEquatable<Date>, ISerializable
    {
        // Number of 100ns ticks per time unit
        private const long TicksPerMillisecond = 10000;
        private const long TicksPerSecond = TicksPerMillisecond * 1000;
        private const long TicksPerMinute = TicksPerSecond * 60;
        private const long TicksPerHour = TicksPerMinute * 60;
        private const long TicksPerDay = TicksPerHour * 24;

        // Number of milliseconds per time unit
        private const int MillisPerSecond = 1000;
        private const int MillisPerMinute = MillisPerSecond * 60;
        private const int MillisPerHour = MillisPerMinute * 60;
        private const int MillisPerDay = MillisPerHour * 24;

        // Number of days in a non-leap year
        private const int DaysPerYear = 365;
        // Number of days in 4 years
        private const int DaysPer4Years = DaysPerYear * 4 + 1;       // 1461
        // Number of days in 100 years
        private const int DaysPer100Years = DaysPer4Years * 25 - 1;  // 36524
        // Number of days in 400 years
        private const int DaysPer400Years = DaysPer100Years * 4 + 1; // 146097

        // Number of days from 1/1/0001 to 12/31/1600
        private const int DaysTo1601 = DaysPer400Years * 4;          // 584388
        // Number of days from 1/1/0001 to 12/30/1899
        private const int DaysTo1899 = DaysPer400Years * 4 + DaysPer100Years * 3 - 367;
        // Number of days from 1/1/0001 to 12/31/1969
        internal const int DaysTo1970 = DaysPer400Years * 4 + DaysPer100Years * 3 + DaysPer4Years * 17 + DaysPerYear; // 719,162
        // Number of days from 1/1/0001 to 12/31/9999
        private const int DaysTo10000 = DaysPer400Years * 25 - 366;  // 3652059

        internal const long MinTicks = 0;
        internal const long MaxTicks = DaysTo10000 * TicksPerDay - 1;
        private const long MaxMillis = (long)DaysTo10000 * MillisPerDay;

        internal const long UnixEpochTicks = DaysTo1970 * TicksPerDay;
        private const long FileTimeOffset = DaysTo1601 * TicksPerDay;
        private const long DoubleDateOffset = DaysTo1899 * TicksPerDay;
        // The minimum OA date is 0100/01/01 (Note it's year 100).
        // The maximum OA date is 9999/12/31
        private const long OADateMinAsTicks = (DaysPer100Years - DaysPerYear) * TicksPerDay;
        // All OA dates must be greater than (not >=) OADateMinAsDouble
        private const double OADateMinAsDouble = -657435.0;
        // All OA dates must be less than (not <=) OADateMaxAsDouble
        private const double OADateMaxAsDouble = 2958466.0;

        private const int DatePartYear = 0;
        private const int DatePartDayOfYear = 1;
        private const int DatePartMonth = 2;
        private const int DatePartDay = 3;

        private static readonly int[] s_daysToMonth365 = {
            0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 334, 365};
        private static readonly int[] s_daysToMonth366 = {
            0, 31, 60, 91, 121, 152, 182, 213, 244, 274, 305, 335, 366};

        public static readonly DateTime MinValue = new DateTime(MinTicks, DateTimeKind.Unspecified);
        public static readonly DateTime MaxValue = new DateTime(MaxTicks, DateTimeKind.Unspecified);
        public static readonly DateTime UnixEpoch = new DateTime(UnixEpochTicks, DateTimeKind.Utc);

        private const ulong TicksMask = 0x3FFFFFFFFFFFFFFF;
        private const ulong FlagsMask = 0xC000000000000000;
        private const ulong LocalMask = 0x8000000000000000;
        private const long TicksCeiling = 0x4000000000000000;
        private const ulong KindUnspecified = 0x0000000000000000;
        private const ulong KindUtc = 0x4000000000000000;
        private const ulong KindLocal = 0x8000000000000000;
        private const ulong KindLocalAmbiguousDst = 0xC000000000000000;
        private const int KindShift = 62;

        private const string TicksField = "ticks"; // Do not rename (binary serialization)
        private const string DateDataField = "dateData"; // Do not rename (binary serialization)

        // The data is stored as an unsigned 64-bit integer
        //   Bits 01-62: The value of 100-nanosecond ticks where 0 represents 1/1/0001 12:00am, up until the value
        //               12/31/9999 23:59:59.9999999
        //   Bits 63-64: A four-state value that describes the DateTimeKind value of the date time, with a 2nd
        //               value for the rare case where the date time is local, but is in an overlapped daylight
        //               savings time hour and it is in daylight savings time. This allows distinction of these
        //               otherwise ambiguous local times and prevents data loss when round tripping from Local to
        //               UTC time.
        private readonly ulong _dateData;

        public Date(long ticks)
        {
            if (ticks < MinTicks || ticks > MaxTicks)
            {
                throw new ArgumentOutOfRangeException(nameof(ticks));
            }

            _dateData = (ulong)ticks;
        }

        private Date(ulong dateData)
        {
            this._dateData = dateData;
        }

        public Date(long ticks, DateTimeKind kind)
        {
            if (ticks < MinTicks || ticks > MaxTicks)
            {
                throw new ArgumentOutOfRangeException(nameof(ticks));
            }
            if (kind < DateTimeKind.Unspecified || kind > DateTimeKind.Local)
            {
                throw new ArgumentException("Invalid input.", nameof(kind));
            }
            _dateData = ((ulong)ticks | ((ulong)kind << KindShift));
        }

        internal Date(long ticks, DateTimeKind kind, bool isAmbiguousDst)
        {
            if (ticks < MinTicks || ticks > MaxTicks)
            {
                ExceptionThrower.ThrowArgumentOutOfRangeException(nameof(ticks));
            }

            Debug.Assert(kind == DateTimeKind.Local, "Internal Constructor is for local times only");
            _dateData = ((ulong)ticks | (isAmbiguousDst ? KindLocalAmbiguousDst : KindLocal));
        }

        // Constructs a DateTime from a given year, month, and day. The
        // time-of-day of the resulting DateTime is always midnight.
        //
        public Date(int year, int month, int day)
        {
            _dateData = (ulong)DateToTicks(year, month, day);
        }

        private DateTime(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
            {
                throw new ArgumentNullException(nameof(info));
            }

            bool foundTicks = false;
            bool foundDateData = false;
            long serializedTicks = 0;
            ulong serializedDateData = 0;


            // Get the data
            SerializationInfoEnumerator enumerator = info.GetEnumerator();
            while (enumerator.MoveNext())
            {
                switch (enumerator.Name)
                {
                    case TicksField:
                        serializedTicks = Convert.ToInt64(enumerator.Value, CultureInfo.InvariantCulture);
                        foundTicks = true;
                        break;
                    case DateDataField:
                        serializedDateData = Convert.ToUInt64(enumerator.Value, CultureInfo.InvariantCulture);
                        foundDateData = true;
                        break;
                    default:
                        // Ignore other fields for forward compatibility.
                        break;
                }
            }
            if (foundDateData)
            {
                _dateData = serializedDateData;
            }
            else if (foundTicks)
            {
                _dateData = (ulong)serializedTicks;
            }
            else
            {
                throw new SerializationException(SR.Serialization_MissingDateTimeData);
            }
            long ticks = InternalTicks;
            if (ticks < MinTicks || ticks > MaxTicks)
            {
                throw new SerializationException(SR.Serialization_DateTimeTicksOutOfRange);
            }
        }

        internal long InternalTicks
        {
            get
            {
                return (long)(_dateData & TicksMask);
            }
        }

        private ulong InternalKind
        {
            get
            {
                return (_dateData & FlagsMask);
            }
        }

        public Date Add(TimeSpan value)
        {
            return AddTicks(value.Ticks);
        }

        private Date Add(double value, int scale)
        {
            double millis_double = value * (double)scale + (value >= 0 ? 0.5 : -0.5);

            if (millis_double <= (double)-MaxMillis || millis_double >= (double)MaxMillis)
            {
                ExceptionThrower.ThrowArgumentOutOfRangeException(nameof(value));
            }

            return AddTicks((long)millis_double * TicksPerMillisecond);
        }

        public Date AddDays(double value)
        {
            return Add(value, MillisPerDay);
        }

        public Date AddHours(double value)
        {
            return Add(value, MillisPerHour);
        }

        public Date AddMilliseconds(double value)
        {
            return Add(value, 1);
        }

        public Date AddMinutes(double value)
        {
            return Add(value, MillisPerMinute);
        }

        public Date AddMonths(int months)
        {
            if (months < -120000 || months > 120000)
            {
                ExceptionThrower.ThrowArgumentOutOfRangeException(nameof(months));
            }

            GetDatePart(out int y, out int m, out int d);
            int i = m - 1 + months;
            if (i >= 0)
            {
                m = i % 12 + 1;
                y = y + i / 12;
            }
            else
            {
                m = 12 + (i + 1) % 12;
                y = y + (i - 11) / 12;
            }
            if (y < 1 || y > 9999)
            {
                ExceptionThrower.ThrowArgumentOutOfRangeException(nameof(months));
            }
            int days = DaysInMonth(y, m);

            if (d > days)
            {
                d = days;
            }

            return new Date((ulong)(DateToTicks(y, m, d) + InternalTicks % TicksPerDay) | InternalKind);
        }

        public Date AddSeconds(double value)
        {
            return Add(value, MillisPerSecond);
        }

        public Date AddTicks(long value)
        {
            long ticks = InternalTicks;

            if (value > MaxTicks - ticks || value < MinTicks - ticks)
            {
                ExceptionThrower.ThrowArgumentOutOfRangeException(nameof(value));
            }

            return new Date((ulong)(ticks + value) | InternalKind);
        }

        // TryAddTicks is exact as AddTicks except it doesn't throw
        internal bool TryAddTicks(long value, out Date result)
        {
            long ticks = InternalTicks;
            if (value > MaxTicks - ticks || value < MinTicks - ticks)
            {
                result = default(Date);
                return false;
            }
            result = new Date((ulong)(ticks + value) | InternalKind);
            return true;
        }


        public Date AddYears(int value)
        {
            if (value < -10000 || value > 10000)
            {
                // DateTimeOffset.AddYears(int years) is implemented on top of DateTime.AddYears(int value). Use the more appropriate
                // parameter name out of the two for the exception.
                ExceptionThrower.ThrowArgumentOutOfRangeException("years");
            }
            return AddMonths(value * 12);
        }

        // Compares two DateTime values, returning an integer that indicates
        // their relationship.
        //
        public static int Compare(Date t1, Date t2)
        {
            long ticks1 = t1.InternalTicks;
            long ticks2 = t2.InternalTicks;

            if (ticks1 > ticks2)
            {
                return 1;
            }

            if (ticks1 < ticks2)
            {
                return -1;
            }

            return 0;
        }

        //TODO: CHANGE TO NULLABLE IN C#8
        public int CompareTo(object value)
        {
            if (value == null)
            {
                return 1;
            }

            if (!(value is Date))
            {
                ExceptionThrower.ThrowArgumentException("Must be a date.", nameof(value));
            }

            return Compare(this, (Date)value);
        }

        public int CompareTo(Date value)
        {
            return Compare(this, value);
        }

        // Returns the tick count corresponding to the given year, month, and day.
        // Will check the if the parameters are valid.
        private static long DateToTicks(int year, int month, int day)
        {
            if (year >= 1 && year <= 9999 && month >= 1 && month <= 12)
            {
                int[] days = IsLeapYear(year) ? s_daysToMonth366 : s_daysToMonth365;
                if (day >= 1 && day <= days[month] - days[month - 1])
                {
                    int y = year - 1;
                    int n = y * 365 + y / 4 - y / 100 + y / 400 + days[month - 1] + day - 1;
                    return n * TicksPerDay;
                }
            }

            throw new ArgumentOutOfRangeException(null, "Invalid year, month or day.");
        }

        public static int DaysInMonth(int year, int month)
        {
            if (month < 1 || month > 12)
            {
                ExceptionThrower.ThrowArgumentOutOfRangeException(nameof(month));
            }

            // IsLeapYear checks the year argument
            int[] days = IsLeapYear(year) ? s_daysToMonth366 : s_daysToMonth365;

            return days[month] - days[month - 1];
        }

        // Converts an OLE Date to a tick count.
        // This function is duplicated in COMDateTime.cpp
        internal static long DoubleDateToTicks(double value)
        {
            // The check done this way will take care of NaN
            if (!(value < OADateMaxAsDouble) || !(value > OADateMinAsDouble))
            {
                ExceptionThrower.ThrowArgumentException("OLE Date is invalid.", nameof(value));
            }

            // Conversion to long will not cause an overflow here, as at this point the "value" is in between OADateMinAsDouble and OADateMaxAsDouble
            long millis = (long)(value * MillisPerDay + (value >= 0 ? 0.5 : -0.5));
            // The interesting thing here is when you have a value like 12.5 it all positive 12 days and 12 hours from 01/01/1899
            // However if you a value of -12.25 it is minus 12 days but still positive 6 hours, almost as though you meant -11.75 all negative
            // This line below fixes up the millis in the negative case
            if (millis < 0)
            {
                millis -= (millis % MillisPerDay) * 2;
            }

            millis += DoubleDateOffset / TicksPerMillisecond;

            if (millis < 0 || millis >= MaxMillis)
            {
                ExceptionThrower.ThrowArgumentException("OLE Date scale is invalid.", nameof(value));
            }

            return millis * TicksPerMillisecond;
        }

        //TODO: CHANGE TO NULLABLE IN C#8
        public override bool Equals(object value)
        {
            if (value is DateTime)
            {
                return InternalTicks == ((Date)value).InternalTicks;
            }
            return false;
        }

        public bool Equals(Date value)
        {
            return InternalTicks == value.InternalTicks;
        }

        public static bool Equals(Date d1, Date d2)
        {
            return d1.InternalTicks == d2.InternalTicks;
        }

        // A version of ToBinary that uses the real representation and does not adjust local times. This is needed for
        // scenarios where the serialized data must maintain compatibility
        internal static Date FromBinaryRaw(long dateData)
        {
            long ticks = dateData & (long)TicksMask;
            if (ticks < MinTicks || ticks > MaxTicks)
            {
                ExceptionThrower.ThrowArgumentException("Bad binary data.", nameof(dateData));
            }

            return new Date((ulong)dateData);
        }


        public static Date FromOADate(double d)
        {
            return new Date(DoubleDateToTicks(d), DateTimeKind.Unspecified);
        }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
            {
                throw new ArgumentNullException(nameof(info));
            }

            // Serialize both the old and the new format
            info.AddValue(TicksField, InternalTicks);
            info.AddValue(DateDataField, _dateData);
        }



        // Returns a given date part of this DateTime. This method is used
        // to compute the year, day-of-year, month, or day part.
        private int GetDatePart(int part)
        {
            long ticks = InternalTicks;
            // n = number of days since 1/1/0001
            int n = (int)(ticks / TicksPerDay);
            // y400 = number of whole 400-year periods since 1/1/0001
            int y400 = n / DaysPer400Years;
            // n = day number within 400-year period
            n -= y400 * DaysPer400Years;
            // y100 = number of whole 100-year periods within 400-year period
            int y100 = n / DaysPer100Years;
            // Last 100-year period has an extra day, so decrement result if 4
            if (y100 == 4)
            {
                y100 = 3;
            }
            // n = day number within 100-year period
            n -= y100 * DaysPer100Years;
            // y4 = number of whole 4-year periods within 100-year period
            int y4 = n / DaysPer4Years;
            // n = day number within 4-year period
            n -= y4 * DaysPer4Years;
            // y1 = number of whole years within 4-year period
            int y1 = n / DaysPerYear;
            // Last year has an extra day, so decrement result if 4
            if (y1 == 4)
            {
                y1 = 3;
            }
            // If year was requested, compute and return it
            if (part == DatePartYear)
            {
                return y400 * 400 + y100 * 100 + y4 * 4 + y1 + 1;
            }
            // n = day number within year
            n -= y1 * DaysPerYear;
            // If day-of-year was requested, return it
            if (part == DatePartDayOfYear)
            {
                return n + 1;
            }
            // Leap year calculation looks different from IsLeapYear since y1, y4,
            // and y100 are relative to year 1, not year 0
            bool leapYear = y1 == 3 && (y4 != 24 || y100 == 3);
            int[] days = leapYear ? s_daysToMonth366 : s_daysToMonth365;
            // All months have less than 32 days, so n >> 5 is a good conservative
            // estimate for the month
            int m = (n >> 5) + 1;
            // m = 1-based month number
            while (n >= days[m])
            {
                m++;
            }
            // If month was requested, return it
            if (part == DatePartMonth)
            {
                return m;
            }
            // Return 1-based day-of-month
            return n - days[m - 1] + 1;
        }

        // Exactly the same as GetDatePart(int part), except computing all of
        // year/month/day rather than just one of them.  Used when all three
        // are needed rather than redoing the computations for each.
        internal void GetDatePart(out int year, out int month, out int day)
        {
            long ticks = InternalTicks;
            // n = number of days since 1/1/0001
            int n = (int)(ticks / TicksPerDay);
            // y400 = number of whole 400-year periods since 1/1/0001
            int y400 = n / DaysPer400Years;
            // n = day number within 400-year period
            n -= y400 * DaysPer400Years;
            // y100 = number of whole 100-year periods within 400-year period
            int y100 = n / DaysPer100Years;
            // Last 100-year period has an extra day, so decrement result if 4
            if (y100 == 4)
            {
                y100 = 3;
            }
            // n = day number within 100-year period
            n -= y100 * DaysPer100Years;
            // y4 = number of whole 4-year periods within 100-year period
            int y4 = n / DaysPer4Years;
            // n = day number within 4-year period
            n -= y4 * DaysPer4Years;
            // y1 = number of whole years within 4-year period
            int y1 = n / DaysPerYear;
            // Last year has an extra day, so decrement result if 4
            if (y1 == 4)
            {
                y1 = 3;
            }
            // compute year
            year = y400 * 400 + y100 * 100 + y4 * 4 + y1 + 1;
            // n = day number within year
            n -= y1 * DaysPerYear;
            // dayOfYear = n + 1;
            // Leap year calculation looks different from IsLeapYear since y1, y4,
            // and y100 are relative to year 1, not year 0
            bool leapYear = y1 == 3 && (y4 != 24 || y100 == 3);
            int[] days = leapYear ? s_daysToMonth366 : s_daysToMonth365;
            // All months have less than 32 days, so n >> 5 is a good conservative
            // estimate for the month
            int m = (n >> 5) + 1;
            // m = 1-based month number
            while (n >= days[m])
            {
                m++;
            }
            // compute month and day
            month = m;
            day = n - days[m - 1] + 1;
        }

        public int Day
        {
            get
            {
                return GetDatePart(DatePartDay);
            }
        }

        public DayOfWeek DayOfWeek
        {
            get
            {
                return (DayOfWeek)((InternalTicks / TicksPerDay + 1) % 7);
            }
        }

        public int DayOfYear
        {
            get
            {
                return GetDatePart(DatePartDayOfYear);
            }
        }

        public override int GetHashCode()
        {
            long ticks = InternalTicks;
            return unchecked((int)ticks) ^ (int)(ticks >> 32);
        }

        public long Ticks
        {
            get
            {
                return InternalTicks;
            }
        }

        public static Date Today
        {
            get
            {
                return new Date(DateTime.Now.Ticks);
            }
        }

        public int Year
        {
            get
            {
                return GetDatePart(DatePartYear);
            }
        }

        public static bool IsLeapYear(int year)
        {
            if (year < 1 || year > 9999)
            {
                throw new ArgumentOutOfRangeException(nameof(year), "Year is out of range.");
            }

            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }

        public static Date Parse(string input)
        {
            if (input == null)
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(input));
            }
            else if (DateTime.TryParse(input, out var dateTime))
            {
                return new Date(dateTime.Ticks);
            }

            throw new ArgumentOutOfRangeException(nameof(input));
        }

        //TODO: CHANGE PROVIDER TO NULLABLE IN C#8
        public static Date Parse(string input, IFormatProvider provider, DateTimeStyles styles)
        {
            if (input == null)
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(input));
            }
            else if (DateTime.TryParse(input, DateTimeFormatInfo.GetInstance(provider), styles, out var dateTime))
            {
                return new Date(dateTime.Ticks);
            }

            throw new ArgumentOutOfRangeException(nameof(input));
        }

        //TODO: CHANGE PROVIDER TO NULLABLE IN C#8
        public static Date ParseExact(string input, string format, IFormatProvider provider, DateTimeStyles styles)
        {
            if (input == null)
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(input));
            }

            if (format == null)
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(format));
            }

            if (DateTime.TryParseExact(input, format, DateTimeFormatInfo.GetInstance(provider), styles, out var dateTime))
            {
                return new Date(dateTime.Ticks);
            }

            throw new ArgumentOutOfRangeException(nameof(input));
        }

        public TimeSpan Subtract(Date value)
        {
            return new TimeSpan(InternalTicks - value.InternalTicks);
        }

        public Date Subtract(TimeSpan value)
        {
            long ticks = InternalTicks;
            long valueTicks = value.Ticks;

            if (ticks - MinTicks < valueTicks || ticks - MaxTicks > valueTicks)
            {
                ExceptionThrower.ThrowArgumentOutOfRangeException(nameof(value));
            }

            return new Date((ulong)(ticks - valueTicks) | InternalKind);
        }

        // This function is duplicated in COMDateTime.cpp
        private static double TicksToOADate(long value)
        {
            if (value == 0)
            {
                return 0.0;  // Returns OleAut's zero'ed date value.
            }

            if (value < TicksPerDay) // This is a fix for VB. They want the default day to be 1/1/0001 rathar then 12/30/1899.
            {
                value += DoubleDateOffset; // We could have moved this fix down but we would like to keep the bounds check.
            }

            if (value < OADateMinAsTicks)
            {
                throw new OverflowException("OLE date is invalid");
            }
            // Currently, our max date == OA's max date (12/31/9999), so we don't
            // need an overflow check in that direction.
            var millis = (value - DoubleDateOffset) / TicksPerMillisecond;

            if (millis < 0)
            {
                long frac = millis % MillisPerDay;
                if (frac != 0)
                {
                    millis -= (MillisPerDay + frac) * 2;
                }
            }

            return (double)millis / MillisPerDay;
        }

        public double ToOADate()
        {
            return TicksToOADate(InternalTicks);
        }


        public string ToLongDateString()
        {
            return new DateTime(this.Ticks).ToLongDateString();
        }

        public string ToShortDateString()
        {
            return new DateTime(this.Ticks).ToShortDateString();
        }

        public override string ToString()
        {
            return this.ToShortDateString();
        }

        //TODO: CHANGE TO NULLABLE IN C#8
        public string ToString(string format)
        {
            return new DateTime(this.Ticks).Date.ToString(format);
        }

        //TODO: CHANGE TO NULLABLE IN C#8
        public string ToString(IFormatProvider provider)
        {
            return new DateTime(this.Ticks).Date.ToString(provider);
        }

        //TODO: CHANGE TO NULLABLE IN C#8
        public string ToString(string format, IFormatProvider provider)
        {
            return new DateTime(this.Ticks).Date.ToString(format, provider);
        }

        //TODO: CHANGE INPUT TO NULLABLE IN C#8
        public static bool TryParse(string s, out Date result)
        {
            if (s == null)
            {
                result = default;
                return false;
            }
            return DateTimeParse.TryParse(s, DateTimeFormatInfo.CurrentInfo, DateTimeStyles.None, out result);
        }

        //TODO: CHANGE INPUT AND PROVIDER TO NULLABLE IN C#8
        public static bool TryParse(string s, IFormatProvider provider, DateTimeStyles styles, out DateTime result)
        {
            DateTimeFormatInfo.ValidateStyles(styles, nameof(styles));

            if (s == null)
            {
                result = default;
                return false;
            }

            return DateTimeParse.TryParse(s, DateTimeFormatInfo.GetInstance(provider), styles, out result);
        }

        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, DateTimeStyles styles, out DateTime result)
        {
            DateTimeFormatInfo.ValidateStyles(styles, nameof(styles));
            return DateTimeParse.TryParse(s, DateTimeFormatInfo.GetInstance(provider), styles, out result);
        }

        public static bool TryParseExact(string? s, string? format, IFormatProvider? provider, DateTimeStyles style, out DateTime result)
        {
            DateTimeFormatInfo.ValidateStyles(style, nameof(style));

            if (s == null || format == null)
            {
                result = default;
                return false;
            }

            return DateTimeParse.TryParseExact(s, format, DateTimeFormatInfo.GetInstance(provider), style, out result);
        }

        public static bool TryParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, IFormatProvider? provider, DateTimeStyles style, out DateTime result)
        {
            DateTimeFormatInfo.ValidateStyles(style, nameof(style));
            return DateTimeParse.TryParseExact(s, format, DateTimeFormatInfo.GetInstance(provider), style, out result);
        }

        public static bool TryParseExact(string? s, string?[]? formats, IFormatProvider? provider, DateTimeStyles style, out DateTime result)
        {
            DateTimeFormatInfo.ValidateStyles(style, nameof(style));

            if (s == null)
            {
                result = default;
                return false;
            }

            return DateTimeParse.TryParseExactMultiple(s, formats, DateTimeFormatInfo.GetInstance(provider), style, out result);
        }

        public static bool TryParseExact(ReadOnlySpan<char> s, string?[]? formats, IFormatProvider? provider, DateTimeStyles style, out DateTime result)
        {
            DateTimeFormatInfo.ValidateStyles(style, nameof(style));
            return DateTimeParse.TryParseExactMultiple(s, formats, DateTimeFormatInfo.GetInstance(provider), style, out result);
        }

        public static DateTime operator +(DateTime d, TimeSpan t)
        {
            long ticks = d.InternalTicks;
            long valueTicks = t._ticks;
            if (valueTicks > MaxTicks - ticks || valueTicks < MinTicks - ticks)
            {
                throw new ArgumentOutOfRangeException(nameof(t), SR.ArgumentOutOfRange_DateArithmetic);
            }
            return new DateTime((ulong)(ticks + valueTicks) | d.InternalKind);
        }

        public static DateTime operator -(DateTime d, TimeSpan t)
        {
            long ticks = d.InternalTicks;
            long valueTicks = t._ticks;
            if (ticks - MinTicks < valueTicks || ticks - MaxTicks > valueTicks)
            {
                throw new ArgumentOutOfRangeException(nameof(t), SR.ArgumentOutOfRange_DateArithmetic);
            }
            return new DateTime((ulong)(ticks - valueTicks) | d.InternalKind);
        }

        public static TimeSpan operator -(Date d1, Date d2)
        {
            return new TimeSpan(d1.InternalTicks - d2.InternalTicks);
        }

        public static bool operator ==(Date d1, Date d2)
        {
            return d1.InternalTicks == d2.InternalTicks;
        }

        public static bool operator !=(Date d1, Date d2)
        {
            return d1.InternalTicks != d2.InternalTicks;
        }

        public static bool operator <(Date t1, Date t2)
        {
            return t1.InternalTicks < t2.InternalTicks;
        }

        public static bool operator <=(Date t1, Date t2)
        {
            return t1.InternalTicks <= t2.InternalTicks;
        }

        public static bool operator >(Date t1, Date t2)
        {
            return t1.InternalTicks > t2.InternalTicks;
        }

        public static bool operator >=(Date t1, Date t2)
        {
            return t1.InternalTicks >= t2.InternalTicks;
        }


        // Returns a string array containing all of the known date and time options for the
        // current culture.  The strings returned are properly formatted date and
        // time strings for the current instance of DateTime.
        public string[] GetDateTimeFormats()
        {
            return (GetDateTimeFormats(CultureInfo.CurrentCulture));
        }

        // Returns a string array containing all of the known date and time options for the
        // using the information provided by IFormatProvider.  The strings returned are properly formatted date and
        // time strings for the current instance of DateTime.
        public string[] GetDateTimeFormats(IFormatProvider? provider)
        {
            return (DateTimeFormat.GetAllDateTimes(this, DateTimeFormatInfo.GetInstance(provider)));
        }


        // Returns a string array containing all of the date and time options for the
        // given format format and current culture.  The strings returned are properly formatted date and
        // time strings for the current instance of DateTime.
        public string[] GetDateTimeFormats(char format)
        {
            return (GetDateTimeFormats(format, CultureInfo.CurrentCulture));
        }

        // Returns a string array containing all of the date and time options for the
        // given format format and given culture.  The strings returned are properly formatted date and
        // time strings for the current instance of DateTime.
        public string[] GetDateTimeFormats(char format, IFormatProvider? provider)
        {
            return (DateTimeFormat.GetAllDateTimes(this, format, DateTimeFormatInfo.GetInstance(provider)));
        }

        //
        // IConvertible implementation
        //

        public TypeCode GetTypeCode()
        {
            return TypeCode.DateTime;
        }


        bool IConvertible.ToBoolean(IFormatProvider? provider)
        {
            throw new InvalidCastException(SR.Format(SR.InvalidCast_FromTo, "DateTime", "Boolean"));
        }

        char IConvertible.ToChar(IFormatProvider? provider)
        {
            throw new InvalidCastException(SR.Format(SR.InvalidCast_FromTo, "DateTime", "Char"));
        }

        sbyte IConvertible.ToSByte(IFormatProvider? provider)
        {
            throw new InvalidCastException(SR.Format(SR.InvalidCast_FromTo, "DateTime", "SByte"));
        }

        byte IConvertible.ToByte(IFormatProvider? provider)
        {
            throw new InvalidCastException(SR.Format(SR.InvalidCast_FromTo, "DateTime", "Byte"));
        }

        short IConvertible.ToInt16(IFormatProvider? provider)
        {
            throw new InvalidCastException(SR.Format(SR.InvalidCast_FromTo, "DateTime", "Int16"));
        }

        ushort IConvertible.ToUInt16(IFormatProvider? provider)
        {
            throw new InvalidCastException(SR.Format(SR.InvalidCast_FromTo, "DateTime", "UInt16"));
        }

        int IConvertible.ToInt32(IFormatProvider? provider)
        {
            throw new InvalidCastException(SR.Format(SR.InvalidCast_FromTo, "DateTime", "Int32"));
        }

        uint IConvertible.ToUInt32(IFormatProvider? provider)
        {
            throw new InvalidCastException(SR.Format(SR.InvalidCast_FromTo, "DateTime", "UInt32"));
        }

        long IConvertible.ToInt64(IFormatProvider? provider)
        {
            throw new InvalidCastException(SR.Format(SR.InvalidCast_FromTo, "DateTime", "Int64"));
        }

        ulong IConvertible.ToUInt64(IFormatProvider? provider)
        {
            throw new InvalidCastException(SR.Format(SR.InvalidCast_FromTo, "DateTime", "UInt64"));
        }

        float IConvertible.ToSingle(IFormatProvider? provider)
        {
            throw new InvalidCastException(SR.Format(SR.InvalidCast_FromTo, "DateTime", "Single"));
        }

        double IConvertible.ToDouble(IFormatProvider? provider)
        {
            throw new InvalidCastException(SR.Format(SR.InvalidCast_FromTo, "DateTime", "Double"));
        }

        decimal IConvertible.ToDecimal(IFormatProvider? provider)
        {
            throw new InvalidCastException(SR.Format(SR.InvalidCast_FromTo, "DateTime", "Decimal"));
        }

        DateTime IConvertible.ToDateTime(IFormatProvider? provider)
        {
            return this;
        }

        object IConvertible.ToType(Type type, IFormatProvider? provider)
        {
            return Convert.DefaultToType((IConvertible)this, type, provider);
        }

        // Tries to construct a DateTime from a given year, month, day, hour,
        // minute, second and millisecond.
        //
        internal static bool TryCreate(int year, int month, int day, int hour, int minute, int second, int millisecond, out DateTime result)
        {
            result = DateTime.MinValue;
            if (year < 1 || year > 9999 || month < 1 || month > 12)
            {
                return false;
            }
            int[] days = IsLeapYear(year) ? s_daysToMonth366 : s_daysToMonth365;
            if (day < 1 || day > days[month] - days[month - 1])
            {
                return false;
            }
            if (hour < 0 || hour >= 24 || minute < 0 || minute >= 60 || second < 0 || second > 60)
            {
                return false;
            }
            if (millisecond < 0 || millisecond >= MillisPerSecond)
            {
                return false;
            }

            if (second == 60)
            {
                if (s_systemSupportsLeapSeconds && IsValidTimeWithLeapSeconds(year, month, day, hour, minute, second, DateTimeKind.Unspecified))
                {
                    // if we have leap second (second = 60) then we'll need to check if it is valid time.
                    // if it is valid, then we adjust the second to 59 so DateTime will consider this second is last second
                    // of this minute.
                    // if it is not valid time, we'll eventually throw.
                    // although this is unspecified datetime kind, we'll assume the passed time is UTC to check the leap seconds.
                    second = 59;
                }
                else
                {
                    return false;
                }
            }

            long ticks = DateToTicks(year, month, day) + TimeToTicks(hour, minute, second);

            ticks += millisecond * TicksPerMillisecond;
            if (ticks < MinTicks || ticks > MaxTicks)
            {
                return false;
            }
            result = new DateTime(ticks, DateTimeKind.Unspecified);
            return true;
        }
    }

}
