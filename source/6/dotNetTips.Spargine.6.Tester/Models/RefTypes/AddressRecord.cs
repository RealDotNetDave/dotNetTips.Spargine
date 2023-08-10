// ***********************************************************************
// Assembly         : dotNetTips.Spargine.6.Tester
// Author           : David McCarter
// Created          : 01-03-2021
//
// Last Modified By : David McCarter
// Last Modified On : 08-04-2023
// ***********************************************************************
// <copyright file="AddressRecord.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics;
using System.Globalization;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Properties;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Tester.Models.RefTypes;

/// <summary>
/// Class Person with proper encapsulation and validation.
/// Implements the <see cref="object" />
/// </summary>
[DebuggerDisplay("{Id}")]
[Serializable]
[XmlRoot(ElementName = "AddressRecord", Namespace = "http://dotNetTips.Spargine.Tester.Models.Ref")]
[DataContract(Name = "addressRecord", Namespace = "http://dotNetTips.Spargine.Tester.Models.Ref")]
[Information(Status = Status.Available, Documentation = "https://bit.ly/UnitTestRandomData7")]
public sealed record AddressRecord : IDataRecord
{

	/// <summary>
	/// The address1
	/// </summary>
	private string _address1;

	/// <summary>
	/// The address2
	/// </summary>
	private string _address2;

	/// <summary>
	/// The city
	/// </summary>
	private string _city;

	/// <summary>
	/// The country
	/// </summary>
	private string _country = RegionInfo.CurrentRegion.ThreeLetterISORegionName;

	/// <summary>
	/// The county province
	/// </summary>
	private string _countyProvince;

	/// <summary>
	/// The phone
	/// </summary>
	private string _phone;

	/// <summary>
	/// The postal code
	/// </summary>
	private string _postalCode;

	/// <summary>
	/// The state
	/// </summary>
	private string _state;

	/// <summary>
	/// Prevents a default instance of the <see cref="PersonRecord" /> class from being created.
	/// </summary>
	public AddressRecord()
	{ }

	/// <summary>
	/// Initializes a new instance of the <see cref="AddressRecord" /> class.
	/// </summary>
	/// <param name="id">The identifier.</param>
	public AddressRecord(string id) => this.Id = id;

	/// <summary>
	/// Initializes a new instance of the <see cref="AddressRecord" /> class.
	/// </summary>
	/// <param name="id">The identifier.</param>
	/// <param name="address1">The address1.</param>
	/// <param name="address2">The address2.</param>
	/// <param name="city">The city.</param>
	/// <param name="state">The state.</param>
	/// <param name="countyProvince">The county province.</param>
	/// <param name="country">The country.</param>
	/// <param name="postalCode">The postal code.</param>
	/// <param name="phone">The phone.</param>
	public AddressRecord(string id, string address1, string address2, string city, string state, string countyProvince, string country, string postalCode, string phone) : this(id)
	{
		this.Address1 = address1;
		this.Address2 = address2;
		this.City = city;
		this.Country = country;
		this.CountyProvince = countyProvince;
		this.Id = id;
		this.Phone = phone;
		this.PostalCode = postalCode;
		this.State = state;
	}

	/// <summary>
	/// Gets or sets the Address1.
	/// </summary>
	/// <value>The Address1.</value>
	/// <exception cref="ArgumentOutOfRangeException">Address1</exception>
	/// <exception cref="ArgumentNullException">Address1</exception>
	[DataMember(Name = "address1")]
	[XmlElement]
	public string Address1
	{
		get => this._address1;
		init
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
	/// Gets or sets the Address2.
	/// </summary>
	/// <value>The Address2.</value>
	/// <exception cref="ArgumentOutOfRangeException">Address2</exception>
	/// <exception cref="ArgumentNullException">Address2</exception>
	[DataMember(Name = "address2")]
	[XmlElement]
	public string Address2
	{
		get => this._address2;
		init
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
	/// Gets or sets the city.
	/// </summary>
	/// <value>The city name.</value>
	/// <exception cref="ArgumentOutOfRangeException">City</exception>
	/// <exception cref="ArgumentNullException">City</exception>
	[DataMember(Name = "city")]
	[XmlElement]
	public string City
	{
		get => this._city;
		init
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
	/// <value>The country name.</value>
	/// <exception cref="ArgumentOutOfRangeException">Country</exception>
	/// <exception cref="ArgumentNullException">Country</exception>
	[DataMember(Name = "country")]
	[XmlElement]
	public string Country
	{
		get => this._country;
		init
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
	/// Gets or sets the county province.
	/// </summary>
	/// <value>The county province.</value>
	/// <exception cref="ArgumentOutOfRangeException">CountyProvince</exception>
	/// <exception cref="ArgumentNullException">CountyProvince - County/ Province length is limited to 50 characters.</exception>
	[DataMember(Name = "countryProvince")]
	[XmlElement]
	public string CountyProvince
	{
		get => this._countyProvince;
		init
		{
			if (string.Equals(this._countyProvince, value, StringComparison.Ordinal))
			{
				return;
			}

			this._countyProvince = value?.Length > 50 ? throw new ArgumentOutOfRangeException(nameof(this.CountyProvince), Resources.CountyProvinceLengthIsLimitedTo50Character) : value;
		}
	}

	/// <summary>
	/// Gets or sets the identifier.
	/// </summary>
	/// <value>The identifier.</value>
	[DataMember(Name = "id")]
	[XmlElement]
	public string Id { get; init; }

	/// <summary>
	/// Gets or sets the phone.
	/// </summary>
	/// <value>The phone.</value>
	/// <exception cref="ArgumentOutOfRangeException">Phone</exception>
	/// <exception cref="ArgumentNullException">Phone</exception>
	[DataMember(Name = "phone")]
	[XmlElement]
	public string Phone
	{
		get => this._phone;
		init
		{
			if (string.Equals(this._phone, value, StringComparison.Ordinal))
			{
				return;
			}

			this._phone = value.HasValue(0, 50) is false
				? throw new ArgumentOutOfRangeException(
					nameof(this.Phone),
					Resources.PhoneNumberIsLimitedTo50Characters)
				: value;
		}
	}

	/// <summary>
	/// Gets or sets the postal code.
	/// </summary>
	/// <value>The postal code.</value>
	/// <exception cref="ArgumentOutOfRangeException">PostalCode</exception>
	/// <exception cref="ArgumentNullException">PostalCode</exception>
	[DataMember(Name = "postalCode")]
	[XmlElement]
	public string PostalCode
	{
		get => this._postalCode;
		init
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
	/// Gets or sets the state.
	/// </summary>
	/// <value>The state.</value>
	/// <exception cref="ArgumentOutOfRangeException">State</exception>
	/// <exception cref="ArgumentNullException">State</exception>
	[DataMember(Name = "state")]
	[XmlElement]
	public string State
	{
		get => this._state;
		init
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
