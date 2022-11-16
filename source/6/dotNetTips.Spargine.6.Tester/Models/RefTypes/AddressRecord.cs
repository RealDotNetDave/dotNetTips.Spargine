// ***********************************************************************
// Assembly         : dotNetTips.Spargine.6.Tester
// Author           : David McCarter
// Created          : 01-03-2021
//
// Last Modified By : David McCarter
// Last Modified On : 09-14-2022
// ***********************************************************************
// <copyright file="AddressRecord.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Globalization;
using DotNetTips.Spargine.Core;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Tester.Models.RefTypes;

/// <summary>
/// Class Person with proper encapsulation and validation.
/// Implements the <see cref="object" />
/// </summary>
[Information(Status = Status.Available, Documentation = "https://bit.ly/UnitTestRandomData7")]
public record AddressRecord : IDataRecord
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
	/// <exception cref="ArgumentOutOfRangeException">Address1 - Address must be between 10 - 256 characters.</exception>
	/// <exception cref="ArgumentNullException">Address1 - Address must be between 10 - 256 characters.</exception>
	public string Address1
	{
		get => this._address1;
		init
		{
			if (string.IsNullOrEmpty(value))
			{
				ExceptionThrower.ThrowArgumentNullException("Value for address cannot be null or empty.", nameof(this.Address1));
			}

			this._address1 = value.Length is < 10 or > 256 ? throw new ArgumentOutOfRangeException(nameof(this.Address1), "Address must be between 10 - 256 characters.") : value;
		}
	}

	/// <summary>
	/// Gets or sets the Address2.
	/// </summary>
	/// <value>The Address2.</value>
	/// <exception cref="ArgumentNullException">Address2 - Value for address cannot be null.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Address2 - Address cannot be more than 256 characters.</exception>
	public string Address2
	{
		get => this._address2;
		init
		{
			if (value is null)
			{
				ExceptionThrower.ThrowArgumentNullException(nameof(this.Address2), "Value for address cannot be null.");
			}

			this._address2 = value.Length > 256 ? throw new ArgumentOutOfRangeException(nameof(this.Address2), "Address cannot be more than 256 characters.") : value;
		}
	}

	/// <summary>
	/// Gets or sets the city.
	/// </summary>
	/// <value>The city name.</value>
	/// <exception cref="ArgumentNullException">City - Value for City cannot be null or empty.</exception>
	/// <exception cref="ArgumentOutOfRangeException">City - City length is limited to 100 characters.</exception>
	public string City
	{
		get => this._city;
		init
		{
			if (string.IsNullOrEmpty(value))
			{
				ExceptionThrower.ThrowArgumentNullException(nameof(this.City), "Value for City cannot be null or empty.");
			}

			this._city = value.Length > 100 ? throw new ArgumentOutOfRangeException(nameof(this.City), "City length is limited to 100 characters.") : value;
		}
	}

	/// <summary>
	/// Gets or sets the country.
	/// </summary>
	/// <value>The country name.</value>
	/// <exception cref="ArgumentNullException">Country - Value for Country cannot be null or empty.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Country - Country length is limited to 50 characters.</exception>
	public string Country
	{
		get => this._country;
		init
		{
			if (string.IsNullOrEmpty(value))
			{
				ExceptionThrower.ThrowArgumentNullException(nameof(this.Country), "Value for Country cannot be null or empty.");
			}

			this._country = value.Length > 50 ? throw new ArgumentOutOfRangeException(nameof(this.Country), "Country length is limited to 50 characters.") : value;
		}
	}

	/// <summary>
	/// Gets or sets the county province.
	/// </summary>
	/// <value>The county province.</value>
	/// <exception cref="ArgumentNullException">CountyProvince - Value for County/ Province cannot be null or empty.</exception>
	/// <exception cref="ArgumentOutOfRangeException">CountyProvince - County/ Province length is limited to 50 characters.</exception>
	public string CountyProvince
	{
		get => this._countyProvince;
		init
		{
			if (string.IsNullOrEmpty(value))
			{
				ExceptionThrower.ThrowArgumentNullException(nameof(this.CountyProvince), "Value for County/ Province cannot be null or empty.");
			}

			this._countyProvince = value.Length > 50 ? throw new ArgumentOutOfRangeException(nameof(this.CountyProvince), "County/ Province length is limited to 50 characters.") : value;
		}
	}

	/// <summary>
	/// Gets or sets the identifier.
	/// </summary>
	/// <value>The identifier.</value>
	public string Id { get; init; }

	/// <summary>
	/// Gets or sets the phone.
	/// </summary>
	/// <value>The phone.</value>
	/// <exception cref="ArgumentNullException">Phone - Value for phone number cannot be null or empty.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Phone - Home phone length is limited to 50 characters.</exception>
	public string Phone
	{
		get => this._phone;
		init
		{
			if (string.IsNullOrEmpty(value))
			{
				ExceptionThrower.ThrowArgumentNullException(nameof(this.Phone), "Value for phone number cannot be null or empty.");
			}

			this._phone = value.Length > 50 ? throw new ArgumentOutOfRangeException(nameof(this.Phone), "Home phone length is limited to 50 characters.") : value;
		}
	}


	/// <summary>
	/// Gets or sets the postal code.
	/// </summary>
	/// <value>The postal code.</value>
	/// <exception cref="ArgumentNullException">PostalCode - Value for postal code cannot be null or empty.</exception>
	/// <exception cref="ArgumentOutOfRangeException">PostalCode - Postal code length is limited to 20 characters.</exception>
	public string PostalCode
	{
		get => this._postalCode;
		init
		{
			if (string.IsNullOrEmpty(value))
			{
				ExceptionThrower.ThrowArgumentNullException(nameof(this.PostalCode), "Value for postal code cannot be null or empty.");
			}

			this._postalCode = value.Length > 20 ? throw new ArgumentOutOfRangeException(nameof(this.PostalCode), "Postal code length is limited to 20 characters.") : value;
		}
	}

	/// <summary>
	/// Gets or sets the state.
	/// </summary>
	/// <value>The state.</value>
	/// <exception cref="ArgumentNullException">State - Value for State cannot be null or empty.</exception>
	/// <exception cref="ArgumentOutOfRangeException">State - State  length is limited to 50 characters.</exception>
	public string State
	{
		get => this._state;
		init
		{
			if (string.IsNullOrEmpty(value))
			{
				ExceptionThrower.ThrowArgumentNullException(nameof(this.State), "Value for State cannot be null or empty.");
			}

			this._state = value.Length > 50 ? throw new ArgumentOutOfRangeException(nameof(this.State), "State  length is limited to 50 characters.") : value;
		}
	}
}
