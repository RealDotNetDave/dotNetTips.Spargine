// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Tester
// Author           : David McCarter
// Created          : 01-03-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-13-2021
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
	public record AddressRecord : IAddressRecord
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
		/// The postal code
		/// </summary>
		private string _postalCode;

		/// <summary>
		/// Prevents a default instance of the <see cref="PersonRecord" /> class from being created.
		/// </summary>
		private AddressRecord()
		{ }

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
					ExceptionThrower.ThrowArgumentNullException(nameof(this.Address1), "Value for address cannot be null or empty.");
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
		/// The city
		/// </summary>
		private string _city;

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
		/// The country
		/// </summary>
		private string _country = "United States";

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
		/// The identifier
		/// </summary>
		private string _id;

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
		/// The county province
		/// </summary>
		private string _countyProvince;

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
		/// The state
		/// </summary>
		private string _state;

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

		/// <summary>
		/// The phone
		/// </summary>
		private string _phone;

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
		/// <exception cref="ArgumentNullException">nameof(this.PostalCode), Value for postal code cannot be null or empty.</exception>
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
		/// Gets the hash code.
		/// </summary>
		/// <returns>int.</returns>
		public override int GetHashCode()
		{
			return HashCode.Combine(this.Id, this.Address1, this.Address2, this.City, this.Phone, this.PostalCode, this.Country, this.Phone);
		}

		/// <summary>
		/// Converts to string.
		/// </summary>
		/// <returns>string.</returns>
		public override string ToString() => $"{this.Address1} {this.Address2}, {this.City} {this.State}, {this.PostalCode}";

		/// <summary>
		/// Compares to.
		/// </summary>
		/// <param name="obj">The object.</param>
		/// <returns>int.</returns>
		/// <exception cref="ArgumentException">nameof(obj) + " is not a " + nameof(AddressRecord)</exception>
		public int CompareTo(object obj)
		{
			if (obj is not AddressRecord)
			{
				throw new ArgumentException(nameof(obj) + " is not a " + nameof(AddressRecord));
			}

			return this.CompareTo((AddressRecord)obj);
		}

		/// <summary>
		/// Compares to.
		/// </summary>
		/// <param name="other">The other.</param>
		/// <returns>int.</returns>
		public int CompareTo(IAddressRecord other)
		{
			if (other == null)
			{
				return 1;
			}

			var result = string.Compare(this._address1, other.Address1, StringComparison.OrdinalIgnoreCase);
			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this._address2, other.Address2, StringComparison.OrdinalIgnoreCase);
			if (result != 0)
			{
				return result;
			}


			result = string.Compare(this._city, other.City, StringComparison.OrdinalIgnoreCase);
			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this._state, other.State, StringComparison.OrdinalIgnoreCase);
			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this._country, other.Country, StringComparison.OrdinalIgnoreCase);
			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this._countyProvince, other.CountyProvince, StringComparison.OrdinalIgnoreCase);
			if (result != 0)
			{
				return result;
			}


			result = string.Compare(this._postalCode, other.PostalCode, StringComparison.OrdinalIgnoreCase);
			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this._phone, other.Phone, StringComparison.OrdinalIgnoreCase);
			if (result != 0)
			{
				return result;
			}

			return result;
		}

		/// <summary>
		/// Equalses the specified other.
		/// </summary>
		/// <param name="other">The other.</param>
		/// <returns>bool.</returns>
		public bool Equals(IAddressRecord other)
		{
			if (other == null)
			{
				return false;
			}

			return ReferenceEquals(this, other);
		}

		/// <summary>
		/// Implements the op_LessThan operator.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>The result of the operator.</returns>
		public static bool operator <(AddressRecord left, IAddressRecord right)
		{
			return left.CompareTo(right) < 0;
		}

		/// <summary>
		/// Implements the op_LessThanOrEqual operator.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>The result of the operator.</returns>
		public static bool operator <=(AddressRecord left, IAddressRecord right)
		{
			return left.CompareTo(right) <= 0;
		}

		/// <summary>
		/// Implements the op_GreaterThan operator.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>The result of the operator.</returns>
		public static bool operator >(AddressRecord left, IAddressRecord right)
		{
			return left.CompareTo(right) > 0;
		}

		/// <summary>
		/// Implements the op_GreaterThanOrEqual operator.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>The result of the operator.</returns>
		public static bool operator >=(AddressRecord left, IAddressRecord right)
		{
			return left.CompareTo(right) >= 0;
		}
	}
}
