// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Tester
// Author           : David McCarter
// Created          : 01-03-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-01-2021
// ***********************************************************************
// <copyright file="AddressRecord.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics;
using dotNetTips.Spargine.Core;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Tester.Models
{
	/// <summary>
	/// Class Person with proper encapsulation and validation.
	/// Implements the <see cref="object" />
	/// </summary>
	[DebuggerDisplay("{Id}")]
	public record AddressRecord : IDataRecord<AddressRecord, string>
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
		private string _country = "United States";

		/// <summary>
		/// The county province
		/// </summary>
		private string _countyProvince;

		/// <summary>
		/// The identifier
		/// </summary>
		private string _id;

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
		/// Initializes a new instance of the <see cref="AddressRecord" /> class.
		/// </summary>
		/// <param name="id">The identifier.</param>
		public AddressRecord(string id)
		{
			this.Id = id;
		}

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
		/// Prevents a default instance of the <see cref="PersonRecord" /> class from being created.
		/// </summary>
		private AddressRecord()
		{ }

		/// <summary>
		/// Gets or sets the Address1.
		/// </summary>
		/// <value>The Address1.</value>
		/// <exception cref="ArgumentNullException">nameof(this.Address1), Value for address cannot be null or empty.</exception>
		public string Address1
		{
			get
			{
				return this._address1;
			}
			init
			{
				if (string.IsNullOrEmpty(value))
				{
					ExceptionThrower.ThrowArgumentNullException("Value for address cannot be null or empty.", nameof(this.Address1));
				}

				this._address1 = ( value.Length < 10 || value.Length > 256 ) ? throw new ArgumentOutOfRangeException(nameof(this.Address1), "Address must be between 10 - 256 characters.") : value;
			}
		}

		/// <summary>
		/// Gets or sets the Address2.
		/// </summary>
		/// <value>The Address2.</value>
		/// <exception cref="ArgumentNullException">nameof(this.Address2), Value for address cannot be null.</exception>
		public string Address2
		{
			get
			{
				return this._address2;
			}
			init
			{
				if (value == null)
				{
					throw new ArgumentNullException(nameof(this.Address2), "Value for address cannot be null.");
				}

				this._address2 = ( value.Length > 256 ) ? throw new ArgumentOutOfRangeException(nameof(this.Address1), "Address cannot be more than 256 characters.") : value;
			}
		}

		/// <summary>
		/// Gets or sets the city.
		/// </summary>
		/// <value>The city name.</value>
		/// <exception cref="ArgumentNullException">nameof(this.City), Value for City cannot be null or empty.</exception>
		public string City
		{
			get
			{
				return this._city;
			}
			init
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentNullException(nameof(this.City), "Value for City cannot be null or empty.");
				}

				this._city = value.Length > 100 ? throw new ArgumentOutOfRangeException(nameof(this.City), "City length is limited to 100 characters.") : value;
			}
		}

		/// <summary>
		/// Gets or sets the country.
		/// </summary>
		/// <value>The country name.</value>
		/// <exception cref="ArgumentNullException">nameof(this.Country), Value for Country cannot be null or empty.</exception>
		public string Country
		{
			get
			{
				return this._country;
			}
			init
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentNullException(nameof(this.Country), "Value for Country cannot be null or empty.");
				}

				this._country = value.Length > 50 ? throw new ArgumentOutOfRangeException(nameof(this.Country), "Country length is limited to 50 characters.") : value;
			}
		}

		/// <summary>
		/// Gets or sets the county province.
		/// </summary>
		/// <value>The county province.</value>
		/// <exception cref="ArgumentNullException">nameof(this.CountyProvince), Value for County/ Province cannot be null or empty.</exception>
		public string CountyProvince
		{
			get
			{
				return this._countyProvince;
			}
			init
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentNullException(nameof(this.CountyProvince), "Value for County/ Province cannot be null or empty.");
				}

				this._countyProvince = value.Length > 50 ? throw new ArgumentOutOfRangeException(nameof(this.CountyProvince), "County/ Province length is limited to 50 characters.") : value;
			}
		}

		/// <summary>
		/// Gets or sets the unique identifier.
		/// </summary>
		/// <value>The unique identifier.</value>
		/// <exception cref="ArgumentNullException">nameof(this.Id), Value for Id cannot be null or empty.</exception>
		public string Id
		{
			get
			{
				return this._id;
			}
			init
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentNullException(nameof(this.Id), "Value for Id cannot be null or empty.");
				}

				this._id = value.Length > 256 ? throw new ArgumentOutOfRangeException(nameof(this.Id), "Id length is limited to 256 characters.") : value;
			}
		}

		/// <summary>
		/// Gets or sets the phone.
		/// </summary>
		/// <value>The phone.</value>
		/// <exception cref="ArgumentNullException">nameof(this.Phone), Value for phone number cannot be null or empty.</exception>
		public string Phone
		{
			get
			{
				return this._phone;
			}
			init
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentNullException(nameof(this.Phone), "Value for phone number cannot be null or empty.");
				}

				this._phone = value.Length > 50 ? throw new ArgumentOutOfRangeException(nameof(this.Phone), "Home phone length is limited to 50 characters.") : value;
			}
		}


		/// <summary>
		/// Gets or sets the postal code.
		/// </summary>
		/// <value>The postal code.</value>
		/// <exception cref="ArgumentNullException">PostalCode cannot be null or empty.</exception>
		public string PostalCode
		{
			get
			{
				return this._postalCode;
			}
			init
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentNullException(nameof(this.PostalCode), "Value for postal code cannot be null or empty.");
				}

				this._postalCode = value.Length > 20 ? throw new ArgumentOutOfRangeException(nameof(this.PostalCode), "Postal code length is limited to 20 characters.") : value;
			}
		}

		/// <summary>
		/// Gets or sets the state.
		/// </summary>
		/// <value>The state.</value>
		/// <exception cref="ArgumentNullException">nameof(this.State), Value for State cannot be null or empty.</exception>
		public string State
		{
			get
			{
				return this._state;
			}
			init
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentNullException(nameof(this.State), "Value for State cannot be null or empty.");
				}

				this._state = value.Length > 50 ? throw new ArgumentOutOfRangeException(nameof(this.State), "State  length is limited to 50 characters.") : value;
			}
		}
	}
}
