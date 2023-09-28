// ***********************************************************************
// Assembly         : dotNetTips.Spargine.6.Tester
// Author           : david
// Created          : 10-25-2021
//
// Last Modified By : david
// Last Modified On : 09-28-2023
// ***********************************************************************
// <copyright file="Person.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Properties;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Tester.Models.ValueTypes;

/// <summary>
/// Person structure that implements interfaces and validates data. Implements the <see cref="IPerson" /> Implements the
/// <see cref="IComparable" />
/// </summary>
/// <seealso cref="IPerson" />
/// <seealso cref="IComparable" />
[DebuggerDisplay("{Email}")]
[Serializable]
[XmlRoot(ElementName = "Person", Namespace = "http://dotNetTips.Spargine.Tester.Models")]
[DataContract(Name = "person", Namespace = "http://dotNetTips.Spargine.Tester.Models")]
[Information(Status = Status.Available, Documentation = "https://bit.ly/UnitTestRandomData7")]
public struct Person : IDataModel<Person, string>, IPerson
{

	/// <summary>
	/// Address 1.
	/// </summary>
	[NonSerialized]
	private string _address1 = default;

	/// <summary>
	/// Address 2.
	/// </summary>
	[NonSerialized]
	private string _address2 = default;

	/// <summary>
	/// The born on date and time.
	/// </summary>
	[NonSerialized]
	private DateTimeOffset _bornOn = default;

	/// <summary>
	/// The cell phone number.
	/// </summary>
	[NonSerialized]
	private string _cellPhone = default;

	/// <summary>
	/// The city name.
	/// </summary>
	[NonSerialized]
	private string _city = default;

	/// <summary>
	/// The country name.
	/// </summary>
	[NonSerialized]
	private string _country = RegionInfo.CurrentRegion.ThreeLetterISORegionName;

	/// <summary>
	/// The email address.
	/// </summary>
	[NonSerialized]
	private string _email = default;

	/// <summary>
	/// The first name.
	/// </summary>
	[NonSerialized]
	private string _firstName = default;

	/// <summary>
	/// The home phone number.
	/// </summary>
	[NonSerialized]
	private string _homePhone = default;

	/// <summary>
	/// The unique identifier.
	/// </summary>
	[NonSerialized]
	private string _id = default;

	/// <summary>
	/// The last name.
	/// </summary>
	[NonSerialized]
	private string _lastName = default;

	/// <summary>
	/// The postal code.
	/// </summary>
	[NonSerialized]
	private string _postalCode = default;

	/// <summary>
	/// The state
	/// </summary>
	[NonSerialized]
	private string _state = default;

	/// <summary>
	/// Initializes a new instance of the <see cref="Person" /> struct.
	/// </summary>
	/// <param name="id">The identifier.</param>
	/// <param name="email">The email.</param>
	public Person(string id, string email) : this()
	{
		this.Id = id;
		this.Email = email;
	}

	/// <summary>
	/// Implements the != operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	public static bool operator !=(Person left, Person right) => !(left == right);

	/// <summary>
	/// Implements the == operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	public static bool operator ==(Person left, Person right) => left.Equals(right);

	/// <summary>
	/// Calculates the person's current age.
	/// </summary>
	/// <returns>TimeSpan.</returns>
	private readonly TimeSpan CalculateAge() => DateTimeOffset.UtcNow.Subtract(this.BornOn);

	/// <summary>
	/// Compares to.
	/// </summary>
	/// <param name="other">The other.</param>
	/// <returns>System.Int32.</returns>
	public readonly int CompareTo([NotNull] Person other)
	{
		var result = this._bornOn.CompareTo(other._bornOn);

		if (result != 0)
		{
			return result;
		}

		result = string.Compare(this._cellPhone, other._cellPhone, StringComparison.OrdinalIgnoreCase);
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

		return -1;
	}

	/// <summary>
	/// Determines whether the specified <see cref="object" /> is equal to this instance.
	/// </summary>
	/// <param name="obj">The object to compare with the current instance.</param>
	/// <returns><c>true</c> if the specified <see cref="object" /> is equal to this instance; otherwise, <c>false</c>.</returns>
	public override readonly bool Equals([NotNull] object obj) => base.Equals(obj);

	/// <summary>
	/// Indicates whether the current object is equal to another object of the same type.
	/// </summary>
	/// <param name="other">An object to compare with this object.</param>
	/// <returns><see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.</returns>
	public readonly bool Equals([NotNull] Person other) => base.Equals(other);

	/// <summary>
	/// Returns a hash code for this instance.
	/// </summary>
	/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
	public override readonly int GetHashCode() => base.GetHashCode();

	/// <summary>
	/// Returns a <see cref="string" /> that represents this instance.
	/// </summary>
	/// <returns>A <see cref="string" /> that represents this instance.</returns>
	public override readonly string ToString() => this.Id.ToString(CultureInfo.CurrentCulture);

	/// <summary>
	/// Gets or sets first address.
	/// </summary>
	/// <value>The address1.</value>
	/// <exception cref="ArgumentOutOfRangeException">Address1</exception>
	[DataMember(Name = "address1")]
	[XmlElement]
	public string Address1
	{
		readonly get => this._address1;

		set
		{
			if (string.Equals(this._address1, value, StringComparison.Ordinal))
			{
				return;
			}

			this._address1 = value.HasValue(0, 100) is false
				? throw new ArgumentOutOfRangeException(
					nameof(this.Address1),
					Resources.AddressLengthIsLimitedTo100Characters)
				: value;
		}
	}

	/// <summary>
	/// Gets or sets second address.
	/// </summary>
	/// <value>The address2.</value>
	/// <exception cref="ArgumentOutOfRangeException">Address2</exception>
	[DataMember(Name = "address2")]
	[XmlElement]
	public string Address2
	{
		readonly get => this._address2;

		set
		{
			if (string.Equals(this._address2, value, StringComparison.Ordinal))
			{
				return;
			}

			this._address2 = value.HasValue(0, 100) is false
				? throw new ArgumentOutOfRangeException(
					nameof(this.Address2),
					Resources.AddressLengthIsLimitedTo100Characters)
				: value;
		}
	}

	/// <summary>
	/// Gets the person's current age.
	/// </summary>
	/// <value>The age.</value>
	[IgnoreDataMember]
	[JsonIgnore]
	[XmlIgnore]
	public readonly TimeSpan Age => this.CalculateAge();

	/// <summary>
	/// Gets or sets the born on date and time.
	/// </summary>
	/// <value>The born on.</value>
	/// <exception cref="ArgumentOutOfRangeException">BornOn</exception>
	[DataMember(Name = "bornOn")]
	[XmlElement]
	public DateTimeOffset BornOn
	{
		readonly get => this._bornOn;

		set
		{
			if (this._bornOn == value)
			{
				return;
			}

			this._bornOn = value.ToUniversalTime() > DateTimeOffset.UtcNow
				? throw new ArgumentOutOfRangeException(
					nameof(this.BornOn),
					Resources.PersonBornOnCannotBeInTheFuture)
				: value;
		}
	}

	/// <summary>
	/// Gets or sets the cell phone number.
	/// </summary>
	/// <value>The cell phone.</value>
	/// <exception cref="ArgumentOutOfRangeException">CellPhone</exception>
	[DataMember(Name = "cellPhone")]
	[XmlElement]
	public string CellPhone
	{
		readonly get => this._cellPhone;

		set
		{
			if (string.Equals(this._cellPhone, value, StringComparison.Ordinal))
			{
				return;
			}

			this._cellPhone = value.HasValue(0, 50) is false
				? throw new ArgumentOutOfRangeException(
					nameof(this.CellPhone),
					Resources.PhoneNumberIsLimitedTo50Characters)
				: value;
		}
	}

	/// <summary>
	/// Gets or sets the city name.
	/// </summary>
	/// <value>The city.</value>
	/// <exception cref="ArgumentOutOfRangeException">City</exception>
	[DataMember(Name = "city")]
	[XmlElement]
	public string City
	{
		readonly get => this._city;

		set
		{
			if (string.Equals(this._city, value, StringComparison.Ordinal))
			{
				return;
			}

			this._city = value.HasValue(0, 150) is false
				? throw new ArgumentOutOfRangeException(
					nameof(this.City),
					Resources.CityLengthIsLimitedToCharacters)
				: value;
		}
	}

	/// <summary>
	/// Gets or sets the country.
	/// </summary>
	/// <value>The country.</value>
	/// <exception cref="ArgumentOutOfRangeException">Country</exception>
	[DataMember(Name = "country")]
	[XmlElement]
	public string Country
	{
		readonly get => this._country;

		set
		{
			if (string.Equals(this._country, value, StringComparison.Ordinal))
			{
				return;
			}

			this._country = value.HasValue(0, 50) is false
				? throw new ArgumentOutOfRangeException(
					nameof(this.Country),
					Resources.CountryLengthIsLimitedTo50Characters)
				: value;
		}
	}

	/// <summary>
	/// Gets the email.
	/// </summary>
	/// <value>The email.</value>
	/// <exception cref="ArgumentOutOfRangeException">Email</exception>
	[DataMember(Name = "email", IsRequired = true)]
	[XmlElement(IsNullable = false)]
	[DisallowNull]
	public string Email
	{
		readonly get => this._email;

		set
		{
			if (string.Equals(this._email, value, StringComparison.Ordinal))
			{
				return;
			}

			this._email = value.HasValue(0, 75) is false
				? throw new ArgumentOutOfRangeException(
					nameof(this.Email),
					Resources.EmailLengthIsLimitedTo75Characters)
				: value;
		}
	}

	/// <summary>
	/// Gets or sets the first name.
	/// </summary>
	/// <value>The first name.</value>
	/// <exception cref="ArgumentOutOfRangeException">FirstName</exception>
	[DataMember(Name = "firstName")]
	[XmlElement]
	public string FirstName
	{
		readonly get => this._firstName;
		set
		{
			if (string.Equals(this._firstName, value, StringComparison.Ordinal))
			{
				return;
			}

			this._firstName = value.HasValue(0, 50) is false
				? throw new ArgumentOutOfRangeException(
					nameof(this.FirstName),
					Resources.FirstNameLengthIsLimitedTo50Characters)
				: value;
		}
	}

	/// <summary>
	/// Gets or sets the home phone.
	/// </summary>
	/// <value>The home phone.</value>
	/// <exception cref="ArgumentOutOfRangeException">HomePhone</exception>
	[DataMember(Name = "homePhone")]
	[XmlElement]
	public string HomePhone
	{
		readonly get => this._homePhone;
		set
		{
			if (string.Equals(this._homePhone, value, StringComparison.Ordinal))
			{
				return;
			}

			this._homePhone = value.HasValue(0, 50) is false
				? throw new ArgumentOutOfRangeException(
					nameof(this.HomePhone),
					Resources.PhoneNumberIsLimitedTo50Characters)
				: value;
		}
	}

	/// <summary>
	/// Gets the identifier.
	/// </summary>
	/// <value>The identifier.</value>
	/// <exception cref="ArgumentOutOfRangeException">Id</exception>
	[DataMember(Name = "id", IsRequired = true)]
	[XmlElement(IsNullable = false)]
	[DisallowNull]
	public string Id
	{
		readonly get => this._id;
		set
		{
			if (string.Equals(this._id, value, StringComparison.Ordinal))
			{
				return;
			}

			this._id = value.HasValue(1, 50) is false
				? throw new ArgumentOutOfRangeException(nameof(this.Id), Resources.IdLengthIsLimitedTo50Characters)
				: value;
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
		readonly get => this._lastName;
		set
		{
			if (string.Equals(this._lastName, value, StringComparison.Ordinal))
			{
				return;
			}

			this._lastName = value.HasValue(0, 50) is false
				? throw new ArgumentOutOfRangeException(
					nameof(this.LastName),
					Resources.LastNameLengthIsLimitedTo50Characters)
				: value;
		}
	}

	/// <summary>
	/// Gets or sets the postal code.
	/// </summary>
	/// <value>The postal code.</value>
	/// <exception cref="ArgumentOutOfRangeException">PostalCode</exception>
	[DataMember(Name = "postalCode")]
	[XmlElement]
	public string PostalCode
	{
		readonly get => this._postalCode;
		set
		{
			if (string.Equals(this._postalCode, value, StringComparison.Ordinal))
			{
				return;
			}

			this._postalCode = value.HasValue(0, 40) is false
				? throw new ArgumentOutOfRangeException(
					nameof(this.PostalCode),
					Resources.PostalCodeLengthIsLimitedTo40Characters)
				: value;
		}
	}

	/// <summary>
	/// Gets or sets the State.
	/// </summary>
	/// <value>The State.</value>
	/// <exception cref="ArgumentOutOfRangeException">State</exception>
	[DataMember(Name = "state")]
	[XmlElement]
	public string State
	{
		readonly get => this._state;
		set
		{
			if (string.Equals(this._state, value, StringComparison.Ordinal))
			{
				return;
			}

			this._state = value.HasValue(0, 60) is false
				? throw new ArgumentOutOfRangeException(
					nameof(this.State),
					Resources.StateLengthIsLimitedTo60Characters)
				: value;
		}
	}

}
