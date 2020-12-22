using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Spargine.Extensions.Tests
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class DateTimeExtensionsTests
    {

        [TestMethod]
        public void DateTimeIntersectsTest()
        {
            var now = DateTime.Now;

            var result = now.Intersects(endDate: now.AddDays(100), intersectingStartDate: now.AddDays(1), intersectingEndDate: now.AddDays(10));

            this.PrintResult(result, nameof(this.DateTimeIntersectsTest));

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DateTimeIsInRangeTest()
        {
            var now = DateTime.Now;

            var result = now.IsInRange(beginningTime: now.Subtract(new TimeSpan(1, 0, 0, 0)), endTime: now.AddDays(10));

            this.PrintResult(result, nameof(this.DateTimeIsInRangeTest));

            Assert.IsTrue(result);
        }


        [TestMethod]
        public void DateTimeLocalTimeFromUtcTest()
        {
            var now = DateTime.Now;

            var result = now.LocalTimeFromUtc(-5);

            this.PrintResult(result, nameof(this.DateTimeLocalTimeFromUtcTest));

            Assert.IsTrue(result >= now);
        }

        [TestMethod]
        public void DateTimeMaxTest()
        {
            var now = DateTime.Now;

            var result = now.Max(now.Subtract(new TimeSpan(1, 0, 0, 0)));

            this.PrintResult(result, nameof(this.DateTimeMaxTest));

            Assert.IsTrue(result == now);
        }

        [TestMethod]
        public void DateTimeNextDayOfTheWeekTest()
        {
            var now = DateTime.Now;

            var result = now.NextDayOfWeek(DayOfWeek.Sunday);

            this.PrintResult(result, nameof(this.DateTimeNextDayOfTheWeekTest));

            Assert.IsTrue(result >= now);
        }


        [TestMethod]
        public void DateTimeOffsetGetLastDayOfWeekTest()
        {
            var result = DateTimeOffset.Now.GetLastDayOfWeek(DayOfWeek.Monday);

            this.PrintResult(result, nameof(this.DateTimeOffsetGetLastDayOfWeekTest));

            Assert.IsTrue(result <= DateTime.Now);
        }

        [TestMethod]
        public void DateTimeOffsetGetNextDayOfWeekTest()
        {
            var result = DateTimeOffset.Now.GetNextDayOfWeek(DayOfWeek.Monday);

            this.PrintResult(result, nameof(this.DateTimeOffsetGetNextDayOfWeekTest));

            Assert.IsTrue(result >= DateTime.Now);
        }

        [TestMethod]
        public void DateTimeOffsetIntersectsTest()
        {
            var now = DateTimeOffset.Now;

            var result = now.Intersects(now.AddDays(100), now.AddDays(1), now.AddDays(10));

            this.PrintResult(result, nameof(this.DateTimeOffsetIntersectsTest));

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DateTimeOffsetIsInRangeTest()
        {
            var now = DateTimeOffset.Now;

            var result = now.IsInRange(now.Subtract(new TimeSpan(1, 0, 0, 0)), now.AddDays(10));

            this.PrintResult(result, nameof(this.DateTimeOffsetIsInRangeTest));

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DateTimeOffsetMaxTest()
        {
            var now = DateTimeOffset.Now;

            var result = now.Max(now.Subtract(new TimeSpan(1, 0, 0, 0)));

            this.PrintResult(result, nameof(this.DateTimeOffsetMaxTest));

            Assert.IsTrue(result == now);
        }

        [TestMethod]
        public void DateTimeOffsetNextDayOfTheWeekTest()
        {
            var now = DateTimeOffset.Now;

            var result = now.NextDayOfWeek(DayOfWeek.Sunday);

            this.PrintResult(result, nameof(this.DateTimeOffsetNextDayOfTheWeekTest));

            Assert.IsTrue(result >= now);
        }

        [TestMethod]
        public void DateTimeOffsetToFriendlyStringTest()
        {
            var result = DateTimeOffset.Now.ToFriendlyDateString();

            this.PrintResult(result, nameof(this.DateTimeOffsetToFriendlyStringTest));

            Assert.IsTrue(string.IsNullOrEmpty(result) == false);
        }

        [TestMethod]
        public void DateTimeToFormattedStringTest()
        {
            var now = DateTime.Now;

            var result = now.ToFormattedString(DateTimeFormat.FullDateLongTime);

            this.PrintResult(result, nameof(DateTimeFormat.FullDateLongTime));

            Assert.IsTrue(result.Length > 5);

            result = now.ToFormattedString(DateTimeFormat.FullDateShortTime);

            this.PrintResult(result, nameof(DateTimeFormat.FullDateShortTime));

            Assert.IsTrue(result.Length > 5);

            result = now.ToFormattedString(DateTimeFormat.FullDateTime);

            this.PrintResult(result, nameof(DateTimeFormat.FullDateTime));

            Assert.IsTrue(result.Length > 5);

            result = now.ToFormattedString(DateTimeFormat.GeneralDateLongTime);

            this.PrintResult(result, nameof(DateTimeFormat.GeneralDateLongTime));

            Assert.IsTrue(result.Length > 5);

            result = now.ToFormattedString(DateTimeFormat.GeneralDateShortTime);

            this.PrintResult(result, nameof(DateTimeFormat.GeneralDateShortTime));

            Assert.IsTrue(result.Length > 5);

            result = now.ToFormattedString(DateTimeFormat.Jan01Comma2020);

            this.PrintResult(result, nameof(DateTimeFormat.Jan01Comma2020));

            Assert.IsTrue(result.Length > 5);

            result = now.ToFormattedString(DateTimeFormat.Janurary01Comma2020);

            this.PrintResult(result, nameof(DateTimeFormat.Janurary01Comma2020));

            Assert.IsTrue(result.Length > 5);

            result = now.ToFormattedString(DateTimeFormat.LongDate);

            this.PrintResult(result, nameof(DateTimeFormat.LongDate));

            Assert.IsTrue(result.Length > 5);

            result = now.ToFormattedString(DateTimeFormat.LongTime);

            this.PrintResult(result, nameof(DateTimeFormat.LongTime));

            Assert.IsTrue(result.Length > 5);

            result = now.ToFormattedString(DateTimeFormat.MonthDay);

            this.PrintResult(result, nameof(DateTimeFormat.MonthDay));

            Assert.IsTrue(result.Length > 5);

            result = now.ToFormattedString(DateTimeFormat.RFC1123);

            this.PrintResult(result, nameof(DateTimeFormat.RFC1123));

            Assert.IsTrue(result.Length > 5);

            result = now.ToFormattedString(DateTimeFormat.RoundTripDateTime);

            this.PrintResult(result, nameof(DateTimeFormat.RoundTripDateTime));

            Assert.IsTrue(result.Length > 5);

            result = now.ToFormattedString(DateTimeFormat.ShortDate);

            this.PrintResult(result, nameof(DateTimeFormat.ShortDate));

            Assert.IsTrue(result.Length > 5);

            result = now.ToFormattedString(DateTimeFormat.ShortTime);

            this.PrintResult(result, nameof(DateTimeFormat.ShortTime));

            Assert.IsTrue(result.Length > 5);

            result = now.ToFormattedString(DateTimeFormat.SortableDateTime);

            this.PrintResult(result, nameof(DateTimeFormat.SortableDateTime));

            Assert.IsTrue(result.Length > 5);

            result = now.ToFormattedString(DateTimeFormat.UniversalFullDateTime);

            this.PrintResult(result, nameof(DateTimeFormat.UniversalFullDateTime));

            Assert.IsTrue(result.Length > 5);

            result = now.ToFormattedString(DateTimeFormat.MonthYear);

            this.PrintResult(result, nameof(DateTimeFormat.MonthYear));

            Assert.IsTrue(result.Length > 5);
        }
        [TestMethod]
        public void DateTimeToFriendlyStringTest()
        {
            var result = DateTime.Now.ToFriendlyDateString();

            this.PrintResult(result, nameof(this.DateTimeToFriendlyStringTest));

            Assert.IsTrue(string.IsNullOrEmpty(result) == false);
        }
        [TestMethod]
        public void GetLastDayOfWeekTest()
        {
            var dateTime = DateTimeOffset.Parse("1/1/2020");

            var result = dateTime.GetLastDayOfWeek(DayOfWeek.Sunday);

            Assert.IsTrue(result.DayOfWeek == DayOfWeek.Sunday);
        }

        [TestMethod]
        public void GetNextDayOfWeekTest()
        {
            var dateTime = DateTimeOffset.Parse("1/1/2020");

            var result = dateTime.GetLastDayOfWeek(DayOfWeek.Tuesday);

            Assert.IsTrue(result.DayOfWeek == DayOfWeek.Tuesday);
        }

        [TestMethod]
        public void IsInRangeThrowsExceptionTestDateTime()
        {
            var now = DateTime.Now;

            var result1 = now.IsInRangeThrowsException(now.Subtract(new TimeSpan(1, 0, 0, 0)), now.AddDays(1), "TEST");

            Assert.IsTrue(result1);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => now.IsInRangeThrowsException(now.AddDays(1), now.AddDays(5), "TEST"));
        }

        [TestMethod]
        public void IsInRangeThrowsExceptionTestDateTimeOffset()
        {
            var now = DateTimeOffset.Now;

            var result1 = now.IsInRangeThrowsException(now.Subtract(new TimeSpan(1, 0, 0, 0)), now.AddDays(1), "TEST");

            Assert.IsTrue(result1);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => now.IsInRangeThrowsException(now.AddDays(1), now.AddDays(5), "TEST"));
        }

        [TestMethod]
        public void IsInRangeThrowsExceptionTestTimeSpan()
        {
            var now = TimeSpan.FromDays(5);

            var result1 = now.IsInRangeThrowsException(now.Subtract(new TimeSpan(1, 0, 0, 0)), now.Add(TimeSpan.FromDays(10)), "TEST");

            Assert.IsTrue(result1);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => now.IsInRangeThrowsException(now.Add(new TimeSpan(10, 0, 0, 0)), new TimeSpan(20, 0, 0, 0), "TEST"));
        }

        [TestMethod]
        public void TimeSpanIsInRangeTest()
        {
            var now = new TimeSpan(3, 0, 0, 0);

            var result = now.IsInRange(now.Subtract(new TimeSpan(1, 0, 0, 0)), now.Multiply(10));

            this.PrintResult(result, nameof(this.TimeSpanIsInRangeTest));

            Assert.IsTrue(result);
        }

        private void PrintResult<T>(T input, string methodName)
        {
            var message = $"{methodName}: {input}";

            Debug.WriteLine(message);
        }
    }
}
