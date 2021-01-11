// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Tester
// Author           : David McCarter
// Created          : 11-22-2020
//
// Last Modified By : David McCarter
// Last Modified On : 01-05-2021
// ***********************************************************************
// <copyright file="PersonPlus.cs" company="David McCarter - dotNetTips.com">
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
using dotNetTips.Spargine.Core.OOP;
using dotNetTips.Spargine.Extensions;
using dotNetTips.Spargine.Tester.Properties;

//![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Tester.Models
{
	/// <summary>
	/// Person class that implements interfaces and validates data.
	/// Implements the <see cref="dotNetTips.Spargine.Tester.Models.IPerson" />
	/// Implements the <see cref="System.IComparable" />
	/// </summary>
	/// <seealso cref="dotNetTips.Spargine.Tester.Models.IPerson" />
	/// <seealso cref="System.IComparable" />
	[DebuggerDisplay("{Email}")]
	[Serializable]
	[DataContract(Name = "personPlus", Namespace = "http://dotNetTips.Spargine.Tester.Models")]
	public sealed class PersonPlus : IPersonPlus, IDataModel<PersonPlus, string>, IComparable<PersonPlus>, IEquatable<PersonPlus>
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
		private string _country = "USA";

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
		public PersonPlus()
		{
		}

		/// <summary>
		/// Initializes a new instance of <see cref="PersonFixed" />.
		/// </summary>
		/// <param name="id">The unique identifier.</param>
		/// <param name="email">The email address.</param>
		[EditorBrowsable(EditorBrowsableState.Always)]
		public PersonPlus(string id, string email)
		{
			this.Id = id;
			this.Email = email;
		}

		/// <summary>
		/// Gets or sets first address.
		/// </summary>
		/// <value>The address1.</value>
		/// <exception cref="ArgumentOutOfRangeException">Address1</exception>
		/// <exception cref="System.ArgumentOutOfRangeException">Address1</exception>
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
				if (this._address1 == value)
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
		/// <exception cref="System.ArgumentOutOfRangeException">Address2</exception>
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
				if (this._address2 == value)
				{
					return;
				}

				this._address2 = value.HasValue(0, 100) == false ? throw new ArgumentOutOfRangeException(nameof(this.Address2), Resources.AddressLengthIsLimitedTo100Characters) : value;
			}
		}

		/// <summary>
		/// Gets or sets the born on date and time.
		/// </summary>
		/// <value>The born on.</value>
		/// <exception cref="ArgumentOutOfRangeException">BornOn</exception>
		/// <exception cref="System.ArgumentOutOfRangeException">BornOn</exception>
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
		/// <exception cref="System.ArgumentOutOfRangeException">CellPhone</exception>
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
				if (this._cellPhone == value)
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
		/// <exception cref="System.ArgumentOutOfRangeException">City</exception>
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
				if (this._city == value)
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
		/// <exception cref="System.ArgumentOutOfRangeException">Country</exception>
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
				if (this._country == value)
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
		/// <exception cref="System.ArgumentOutOfRangeException">Email</exception>
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
				if (this._email == value)
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
		/// <exception cref="System.ArgumentOutOfRangeException">FirstName</exception>
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
				if (this._firstName == value)
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
		/// <exception cref="System.ArgumentOutOfRangeException">HomePhone</exception>
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
				if (this._homePhone == value)
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
		/// <exception cref="System.ArgumentOutOfRangeException">Id</exception>
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
				if (this._id == value)
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
		/// <exception cref="System.ArgumentOutOfRangeException">LastName</exception>
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
				if (this._lastName == value)
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
		/// <exception cref="System.ArgumentOutOfRangeException">PostalCode</exception>
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
				if (this._postalCode == value)
				{
					return;
				}

				this._postalCode = value.HasValue(0, 15) == false ? throw new ArgumentOutOfRangeException(nameof(this.PostalCode), Resources.PostalCodeLengthIsLimitedTo15Characters) : value;
			}
		}

		/// <summary>
		/// Gets or sets the state.
		/// </summary>
		/// <value>The state.</value>
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
				if (this._state == value)
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
		public static bool operator >=(PersonPlus left, PersonPlus right) => left is null ? right is null : left.CompareTo(right) >= 0;

		/// <summary>
		/// Implements the &gt; operator.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>The result of the operator.</returns>
		public static bool operator >(PersonPlus left, PersonPlus right) => left is object && left.CompareTo(right) > 0;

		/// <summary>
		/// Implements the == operator.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>The result of the operator.</returns>
		public static bool operator ==(PersonPlus left, PersonPlus right)
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
		public static bool operator <=(PersonPlus left, PersonPlus right) => left is null || left.CompareTo(right) <= 0;

		/// <summary>
		/// Implements the &lt; operator.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>The result of the operator.</returns>
		public static bool operator <(PersonPlus left, PersonPlus right) => left is null ? right is object : left.CompareTo(right) < 0;

		/// <summary>
		/// Implements the != operator.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>The result of the operator.</returns>
		public static bool operator !=(PersonPlus left, PersonPlus right) => !( left == right );

		/// <summary>
		/// Compares to.
		/// </summary>
		/// <param name="other">The other.</param>
		/// <returns>System.Int32.</returns>
		public int CompareTo(PersonPlus other)
		{
			if (other == null)
			{
				return 1;
			}

			var result = string.Compare(this.Address1, other.Address1, StringComparison.OrdinalIgnoreCase);
			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this.Address2, other.Address2, StringComparison.OrdinalIgnoreCase);
			if (result != 0)
			{
				return result;
			}

			result = this.BornOn.CompareTo(other.BornOn);
			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this.CellPhone, other.CellPhone, StringComparison.OrdinalIgnoreCase);
			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this.City, other.City, StringComparison.OrdinalIgnoreCase);
			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this.Country, other.Country, StringComparison.OrdinalIgnoreCase);
			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this.Email, other.Email, StringComparison.OrdinalIgnoreCase);
			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this.FirstName, other.FirstName, StringComparison.OrdinalIgnoreCase);
			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this.HomePhone, other.HomePhone, StringComparison.OrdinalIgnoreCase);
			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this.Id, other.Id, StringComparison.OrdinalIgnoreCase);
			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this.LastName, other.LastName, StringComparison.OrdinalIgnoreCase);
			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this.PostalCode, other.PostalCode, StringComparison.OrdinalIgnoreCase);
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
		public bool Equals(PersonPlus other)
		{
			if (other == null)
			{
				return false;
			}

			return ReferenceEquals(this, other);
		}


		/// <summary>
		/// Returns the hash code for this instance based on id.
		/// </summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
		public override int GetHashCode()
		{
			return HashCode.Combine(this.Email, this.Id);
		}

		/// <summary>
		/// Returns a <see cref="string" /> of the users id.
		/// </summary>
		/// <returns>A <see cref="string" /> of the users id.</returns>
		public override string ToString() => this.Id.ToString(CultureInfo.CurrentCulture);

	}
}
