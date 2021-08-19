﻿// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Tester
// Author           : David McCarter
// Created          : 07-17-2019
//
// Last Modified By : David McCarter
// Last Modified On : 02-08-2021
// ***********************************************************************
// <copyright file="PersonProper.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Extensions;
using dotNetTips.Spargine.Tester.Properties;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Tester.Models
{
	/// <summary>
	/// Person class that implements interfaces and validates data.
	/// Implements the <see cref="IPerson" />
	/// Implements the <see cref="IComparable" />
	/// </summary>
	/// <seealso cref="IPerson" />
	/// <seealso cref="IComparable" />
	[DebuggerDisplay("{Email}")]
	[Serializable]
	[XmlRoot(ElementName = "PersonProper", Namespace = "http://dotNetTips.Spargine.Tester.Models")]
	[DataContract(Name = "personProper", Namespace = "http://dotNetTips.Spargine.Tester.Models")]
#pragma warning disable CS0618 // Type or member is obsolete
	public sealed class PersonProper : IPerson, IDataModel<PersonProper, string>, IPersonPlus
#pragma warning restore CS0618 // Type or member is obsolete
	{

		/// <summary>
		/// Address 1.
		/// </summary>
		[NonSerialized]
		private string _address1;

		/// <summary>
		/// Address 2.
		/// </summary>
		[NonSerialized]
		private string _address2;

		/// <summary>
		/// The born on date and time.
		/// </summary>
		[NonSerialized]
		private DateTimeOffset _bornOn;

		/// <summary>
		/// The cell phone number.
		/// </summary>
		[NonSerialized]
		private string _cellPhone;

		/// <summary>
		/// The city name.
		/// </summary>
		[NonSerialized]
		private string _city;

		/// <summary>
		/// The country name.
		/// </summary>
		[NonSerialized]
		private string _country = RegionInfo.CurrentRegion.ThreeLetterISORegionName;

		/// <summary>
		/// The email address.
		/// </summary>
		[NonSerialized]
		private string _email;

		/// <summary>
		/// The first name.
		/// </summary>
		[NonSerialized]
		private string _firstName;

		/// <summary>
		/// The home phone number.
		/// </summary>
		[NonSerialized]
		private string _homePhone;

		/// <summary>
		/// The unique identifier.
		/// </summary>
		[NonSerialized]
		private string _id;

		/// <summary>
		/// The last name.
		/// </summary>
		[NonSerialized]
		private string _lastName;

		/// <summary>
		/// The postal code.
		/// </summary>
		[NonSerialized]
		private string _postalCode;

		/// <summary>
		/// The state
		/// </summary>
		[NonSerialized]
		private string _state;

		/// <summary>
		/// Initializes a new instance of <see cref="PersonFixed" />.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public PersonProper()
		{
		}

		/// <summary>
		/// Initializes a new instance of <see cref="PersonFixed" />.
		/// </summary>
		/// <param name="id">The unique identifier.</param>
		/// <param name="email">The email address.</param>
		public PersonProper(string id, string email)
		{
			this.Id = id;
			this.Email = email;
		}

		/// <summary>
		/// Gets or sets first address.
		/// </summary>
		/// <value>The address1.</value>
		/// <exception cref="ArgumentOutOfRangeException">Address1</exception>
		/// <exception cref="ArgumentOutOfRangeException">Address1</exception>
		[DataMember(Name = "address1")]
		[XmlElement]
		public string Address1
		{
			get
			{
				return this._address1;
			}

			set
			{
				if (string.Compare(this._address1, value, StringComparison.Ordinal) == 0)
				{
					return;
				}

				this._address1 = value.HasValue(0, 100) == false ? throw new ArgumentOutOfRangeException(nameof(this.Address1), Resources.AddressLengthIsLimitedTo100Characters) : value;
			}
		}

		/// <summary>
		/// Gets or sets second address.
		/// </summary>
		/// <value>The address2.</value>
		/// <exception cref="ArgumentOutOfRangeException">Address2</exception>
		/// <exception cref="ArgumentOutOfRangeException">Address2</exception>
		[DataMember(Name = "address2")]
		[XmlElement]
		public string Address2
		{
			get
			{
				return this._address2;
			}

			set
			{
				if (string.Compare(this._address2, value, StringComparison.Ordinal) == 0)
				{
					return;
				}

				this._address2 = value.HasValue(0, 100) == false ? throw new ArgumentOutOfRangeException(nameof(this.Address2), Resources.AddressLengthIsLimitedTo100Characters) : value;
			}
		}

		/// <summary>
		/// Gets the person's current age.
		/// </summary>
		/// <value>The age.</value>
		[IgnoreDataMember]
		public TimeSpan Age => this.CalculateAge();

		/// <summary>
		/// Gets or sets the born on date and time.
		/// </summary>
		/// <value>The born on.</value>
		/// <exception cref="ArgumentOutOfRangeException">BornOn</exception>
		/// <exception cref="ArgumentOutOfRangeException">BornOn</exception>
		[DataMember(Name = "bornOn")]
		[XmlElement]
		public DateTimeOffset BornOn
		{
			get
			{
				return this._bornOn;
			}

			set
			{
				if (this._bornOn == value)
				{
					return;
				}

				this._bornOn = value.ToUniversalTime() > DateTimeOffset.UtcNow ? throw new ArgumentOutOfRangeException(nameof(this.BornOn), Resources.PersonBornOnCannotBeInTheFuture) : value;
			}
		}

		/// <summary>
		/// Gets or sets the cell phone number.
		/// </summary>
		/// <value>The cell phone.</value>
		/// <exception cref="ArgumentOutOfRangeException">CellPhone</exception>
		/// <exception cref="ArgumentOutOfRangeException">CellPhone</exception>
		[DataMember(Name = "cellPhone")]
		[XmlElement]
		public string CellPhone
		{
			get
			{
				return this._cellPhone;
			}

			set
			{
				if (string.Compare(this._cellPhone, value, StringComparison.Ordinal) == 0)
				{
					return;
				}

				this._cellPhone = value.HasValue(0, 50) == false ? throw new ArgumentOutOfRangeException(nameof(this.CellPhone), Resources.PhoneNumberIsLimitedTo50Characters) : value;
			}
		}

		/// <summary>
		/// Gets or sets the city name.
		/// </summary>
		/// <value>The city.</value>
		/// <exception cref="ArgumentOutOfRangeException">City</exception>
		/// <exception cref="ArgumentOutOfRangeException">City</exception>
		[DataMember(Name = "city")]
		[XmlElement]
		public string City
		{
			get
			{
				return this._city;
			}

			set
			{
				if (string.Compare(this._city, value, StringComparison.Ordinal) == 0)
				{
					return;
				}

				this._city = value.HasValue(0, 100) == false ? throw new ArgumentOutOfRangeException(nameof(this.City), Resources.CityLengthIsLimitedTo100Characters) : value;
			}
		}

		/// <summary>
		/// Gets or sets the country.
		/// </summary>
		/// <value>The country.</value>
		/// <exception cref="ArgumentOutOfRangeException">Country</exception>
		/// <exception cref="ArgumentOutOfRangeException">Country</exception>
		[DataMember(Name = "country")]
		[XmlElement]
		public string Country
		{
			get
			{
				return this._country;
			}

			set
			{
				if (string.Compare(this._country, value, StringComparison.Ordinal) == 0)
				{
					return;
				}

				this._country = value.HasValue(0, 50) == false ? throw new ArgumentOutOfRangeException(nameof(this.Country), Resources.CountryLengthIsLimitedTo50Characters) : value;
			}
		}

		/// <summary>
		/// Gets the email.
		/// </summary>
		/// <value>The email.</value>
		/// <exception cref="ArgumentOutOfRangeException">Email</exception>
		/// <exception cref="ArgumentOutOfRangeException">Email</exception>
		[DataMember(Name = "email", IsRequired = true)]
		[XmlElement(IsNullable = false)]
		public string Email
		{
			get
			{
				return this._email;
			}

			set
			{
				if (string.Compare(this._email, value, StringComparison.Ordinal) == 0)
				{
					return;
				}

				this._email = value.HasValue(0, 75) == false ? throw new ArgumentOutOfRangeException(nameof(this.Email), Resources.EmailLengthIsLimitedTo75Characters) : value;
			}
		}

		/// <summary>
		/// Gets or sets the first name.
		/// </summary>
		/// <value>The first name.</value>
		/// <exception cref="ArgumentOutOfRangeException">FirstName</exception>
		/// <exception cref="ArgumentOutOfRangeException">FirstName</exception>
		[DataMember(Name = "firstName")]
		[XmlElement]
		public string FirstName
		{
			get
			{
				return this._firstName;
			}
			set
			{
				if (string.Compare(this._firstName, value, StringComparison.Ordinal) == 0)
				{
					return;
				}

				this._firstName = value.HasValue(0, 50) == false ? throw new ArgumentOutOfRangeException(nameof(this.FirstName), Resources.FirstNameLengthIsLimitedTo50Characters) : value;
			}
		}

		/// <summary>
		/// Gets or sets the home phone.
		/// </summary>
		/// <value>The home phone.</value>
		/// <exception cref="ArgumentOutOfRangeException">HomePhone</exception>
		/// <exception cref="ArgumentOutOfRangeException">HomePhone</exception>
		[DataMember(Name = "homePhone")]
		[XmlElement]
		public string HomePhone
		{
			get
			{
				return this._homePhone;
			}
			set
			{
				if (string.Compare(this._homePhone, value, StringComparison.Ordinal) == 0)
				{
					return;
				}

				this._homePhone = value.HasValue(0, 50) == false ? throw new ArgumentOutOfRangeException(nameof(this.HomePhone), Resources.PhoneNumberIsLimitedTo50Characters) : value;
			}
		}

		/// <summary>
		/// Gets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
		/// <exception cref="ArgumentOutOfRangeException">Id</exception>
		/// <exception cref="ArgumentOutOfRangeException">Id</exception>
		[DataMember(Name = "id", IsRequired = true)]
		[XmlElement(IsNullable = false)]
		public string Id
		{
			get
			{
				return this._id;
			}
			set
			{
				if (string.Compare(this._id, value, StringComparison.Ordinal) == 0)
				{
					return;
				}

				this._id = value.HasValue(1, 50) == false ? throw new ArgumentOutOfRangeException(nameof(this.Id), Resources.IdLengthIsLimitedTo50Characters) : value;
			}
		}

		/// <summary>
		/// Gets or sets the last name.
		/// </summary>
		/// <value>The last name.</value>
		/// <exception cref="ArgumentOutOfRangeException">LastName</exception>
		[DataMember(Name = "lastName")]
		[XmlElement]
		public string LastName
		{
			get
			{
				return this._lastName;
			}
			set
			{
				if (string.Compare(this._lastName, value, StringComparison.Ordinal) == 0)
				{
					return;
				}

				this._lastName = value.HasValue(0, 50) == false ? throw new ArgumentOutOfRangeException(nameof(this.LastName), Resources.LastNameLengthIsLimitedTo50Characters) : value;
			}
		}

		/// <summary>
		/// Gets or sets the postal code.
		/// </summary>
		/// <value>The postal code.</value>
		/// <exception cref="ArgumentOutOfRangeException">PostalCode</exception>
		/// <exception cref="ArgumentOutOfRangeException">PostalCode</exception>
		[DataMember(Name = "postalCode")]
		[XmlElement]
		public string PostalCode
		{
			get
			{
				return this._postalCode;
			}
			set
			{
				if (string.Compare(this._postalCode, value, StringComparison.Ordinal) == 0)
				{
					return;
				}

				this._postalCode = value.HasValue(0, 15) == false ? throw new ArgumentOutOfRangeException(nameof(this.PostalCode), Resources.PostalCodeLengthIsLimitedTo15Characters) : value;
			}
		}


		/// <summary>
		/// Gets or sets the State.
		/// </summary>
		/// <value>The State.</value>
		/// <exception cref="ArgumentOutOfRangeException">State</exception>
		/// <exception cref="ArgumentOutOfRangeException">State</exception>
		[DataMember(Name = "state")]
		[XmlElement]
		public string State
		{
			get
			{
				return this._state;
			}
			set
			{
				if (string.Compare(this._state, value, StringComparison.Ordinal) == 0)
				{
					return;
				}

				this._state = value.HasValue(0, 25) == false ? throw new ArgumentOutOfRangeException(nameof(this.State), Resources.StateLengthIsLimitedTo25Characters) : value;
			}
		}

		/// <summary>
		/// Implements the &gt;= operator.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>The result of the operator.</returns>
		public static bool operator >=(PersonProper left, PersonProper right) => left is null ? right is null : left.CompareTo(right) >= 0;

		/// <summary>
		/// Implements the &gt; operator.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>The result of the operator.</returns>
		public static bool operator >(PersonProper left, PersonProper right) => left is object && left.CompareTo(right) > 0;

		/// <summary>
		/// Implements the == operator.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>The result of the operator.</returns>
		public static bool operator ==(PersonProper left, PersonProper right)
		{
			if (left is null)
			{
				return right is null;
			}

			return left.Equals(right);
		}

		/// <summary>
		/// Implements the &lt;= operator.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>The result of the operator.</returns>
		public static bool operator <=(PersonProper left, PersonProper right) => left is null || left.CompareTo(right) <= 0;

		/// <summary>
		/// Implements the &lt; operator.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>The result of the operator.</returns>
		public static bool operator <(PersonProper left, PersonProper right) => left is null ? right is object : left.CompareTo(right) < 0;

		/// <summary>
		/// Implements the != operator.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>The result of the operator.</returns>
		public static bool operator !=(PersonProper left, PersonProper right) => !( left == right );

		/// <summary>
		/// Compares to.
		/// </summary>
		/// <param name="other">The other.</param>
		/// <returns>System.Int32.</returns>
		public int CompareTo(PersonProper other)
		{
			if (other is null)
			{
				return 1;
			}

			var result = string.Compare(this._address1, other._address1, StringComparison.OrdinalIgnoreCase);
			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this._address2, other._address2, StringComparison.OrdinalIgnoreCase);
			if (result != 0)
			{
				return result;
			}

			result = this._bornOn.CompareTo(other._bornOn);
			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this._cellPhone, other._cellPhone, StringComparison.OrdinalIgnoreCase);
			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this._city, other._city, StringComparison.OrdinalIgnoreCase);
			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this._country, other._country, StringComparison.OrdinalIgnoreCase);
			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this._email, other._email, StringComparison.OrdinalIgnoreCase);
			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this._firstName, other._firstName, StringComparison.OrdinalIgnoreCase);
			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this._homePhone, other._homePhone, StringComparison.OrdinalIgnoreCase);
			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this._id, other._id, StringComparison.OrdinalIgnoreCase);
			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this._lastName, other._lastName, StringComparison.OrdinalIgnoreCase);
			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this._postalCode, other._postalCode, StringComparison.OrdinalIgnoreCase);
			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this._state, other._state, StringComparison.OrdinalIgnoreCase);
			if (result != 0)
			{
				return result;
			}

			return result;
		}

		/// <summary>
		/// Determines whether the specified <see cref="object" /> is equal to this instance.
		/// </summary>
		/// <param name="obj">The object to compare with the current object.</param>
		/// <returns><c>true</c> if the specified <see cref="object" /> is equal to this instance; otherwise, <c>false</c>.</returns>
		/// <exception cref="NotImplementedException"></exception>
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(this, obj))
			{
				return true;
			}

			return false;
		}

		/// <summary>
		/// Equals the specified other.
		/// </summary>
		/// <param name="other">The other.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		/// <exception cref="NotImplementedException"></exception>
		public bool Equals(PersonProper other)
		{
			if (other is null)
			{
				return false;
			}

			return ReferenceEquals(this, other);
		}


		/// <summary>
		/// Returns the hash code for this instance based on id.
		/// </summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
		public override int GetHashCode() => HashCode.Combine(this.Email, this.Id);

		/// <summary>
		/// Returns a <see cref="string" /> of the users id.
		/// </summary>
		/// <returns>A <see cref="string" /> of the users id.</returns>
		public override string ToString() => this.Id.ToString(CultureInfo.CurrentCulture);

		/// <summary>
		/// Calculates the person's current age.
		/// </summary>
		/// <returns>TimeSpan.</returns>
		private TimeSpan CalculateAge() => DateTimeOffset.UtcNow.Subtract(this.BornOn);

	}
}
