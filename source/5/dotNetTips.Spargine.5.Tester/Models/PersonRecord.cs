﻿// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Tester
// Author           : David McCarter
// Created          : 01-03-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-05-2021
// ***********************************************************************
// <copyright file="PersonRecord.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using dotNetTips.Spargine.Tester.Properties;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Tester.Models
{
	/// <summary>
	/// Class Person with proper encapsulation and validation.
	/// Implements the <see cref="object" />
	/// </summary>
	[DebuggerDisplay("{Email}")]
	public record PersonRecord : IPersonRecord
	{
		/// <summary>
		/// The born on
		/// </summary>
		private DateTimeOffset _bornOn;

		/// <summary>
		/// The cell phone number
		/// </summary>
		private string _cellPhone;


		/// <summary>
		/// The email
		/// </summary>
		private string _email;

		/// <summary>
		/// The first name
		/// </summary>
		private string _firstName;

		/// <summary>
		/// The home phone number
		/// </summary>
		private string _homePhone;

		/// <summary>
		/// The unique identifier
		/// </summary>
		private string _id;

		/// <summary>
		/// The last name
		/// </summary>
		private string _lastName;

		/// <summary>
		/// Initializes a new instance of the <see cref="Person" /> class.
		/// </summary>
		/// <param name="email">The email.</param>
		/// <param name="id">The identifier.</param>
		public PersonRecord(string email, string id)
		{
			this.Email = email;
			this.Id = id;
		}

		/// <summary>
		/// Prevents a default instance of the <see cref="PersonRecord" /> class from being created.
		/// </summary>
		private PersonRecord()
		{ }

		/// <summary>
		/// Gets or sets the born on date.
		/// </summary>
		/// <value>The born on date.</value>
		/// <exception cref="ArgumentOutOfRangeException">BornOn - Person cannot be born in the future.</exception>
		public DateTimeOffset BornOn
		{
			get
			{
				return this._bornOn;
			}
			init
			{
				this._bornOn = value.ToUniversalTime() > DateTimeOffset.UtcNow ? throw new ArgumentOutOfRangeException(nameof(this.BornOn), "Person cannot be born in the future.") : value;
			}
		}

		/// <summary>
		/// Gets or sets the cell phone number.
		/// </summary>
		/// <value>The cell phone number.</value>
		/// <exception cref="ArgumentNullException">nameof(this.CellPhone), Value for phone number cannot be null.</exception>
		/// <exception cref="ArgumentOutOfRangeException">nameof(this.CellPhone), Value for phone number cannot be null.</exception>
		public string CellPhone
		{
			get
			{
				return this._cellPhone;
			}
			init
			{
				if (value == null)
				{
					throw new ArgumentNullException(nameof(this.CellPhone), "Value for phone number cannot be null.");
				}

				this._cellPhone = value.Length > 50 ? throw new ArgumentOutOfRangeException(nameof(this.CellPhone), "Phone number is limited to 50 characters.") : value;
			}
		}

		/// <summary>
		/// Gets or sets the email address.
		/// </summary>
		/// <value>The email address.</value>
		/// <exception cref="ArgumentNullException">nameof(this.Email), Value for Email cannot be null or empty.</exception>
		/// <exception cref="ArgumentOutOfRangeException">nameof(this.Email), Value for Email cannot be null or empty.</exception>
		public string Email
		{
			get
			{
				return this._email;
			}
			init
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentNullException(nameof(this.Email), "Value for Email cannot be null or empty.");
				}

				this._email = value.Length > 75 ? throw new ArgumentOutOfRangeException(nameof(this.Email), Resources.EmailLengthIsLimitedTo75Characters) : value;
			}
		}

		/// <summary>
		/// Gets or sets the first name.
		/// </summary>
		/// <value>The first name.</value>
		/// <exception cref="ArgumentNullException">nameof(this.FirstName), Value for name cannot be null or empty.</exception>
		/// <exception cref="ArgumentOutOfRangeException">nameof(this.FirstName), Value for name cannot be null or empty.</exception>
		public string FirstName
		{
			get
			{
				return this._firstName;
			}
			init
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentNullException(nameof(this.FirstName), "Value for name cannot be null or empty.");
				}

				this._firstName = value.Length > 50 ? throw new ArgumentOutOfRangeException(nameof(this.FirstName), "First name length is limited to 50 characters.") : value;
			}
		}

		/// <summary>
		/// Gets or sets the home phone number.
		/// </summary>
		/// <value>The home phone.</value>
		/// <exception cref="ArgumentNullException">nameof(this.HomePhone), Value for phone number cannot be null or empty.</exception>
		/// <exception cref="ArgumentOutOfRangeException">nameof(this.HomePhone), Value for phone number cannot be null or empty.</exception>
		public string HomePhone
		{
			get
			{
				return this._homePhone;
			}
			init
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentNullException(nameof(this.HomePhone), "Value for phone number cannot be null or empty.");
				}

				this._homePhone = value.Length > 50 ? throw new ArgumentOutOfRangeException(nameof(this.HomePhone), "Home phone length is limited to 50 characters.") : value;
			}
		}

		/// <summary>
		/// Gets or sets the unique identifier.
		/// </summary>
		/// <value>The unique identifier.</value>
		/// <exception cref="ArgumentNullException">nameof(this.Id), Value for Id cannot be null or empty.</exception>
		/// <exception cref="ArgumentOutOfRangeException">nameof(this.Id), Value for Id cannot be null or empty.</exception>
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
		/// Gets or sets the last name.
		/// </summary>
		/// <value>The last name.</value>
		/// <exception cref="ArgumentNullException">nameof(this.LastName), Value for name cannot be null or empty.</exception>
		/// <exception cref="ArgumentOutOfRangeException">nameof(this.LastName), Value for name cannot be null or empty.</exception>
		public string LastName
		{
			get
			{
				return this._lastName;
			}
			init
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentNullException(nameof(this.LastName), "Value for name cannot be null or empty.");
				}

				this._lastName = value.Length > 50 ? throw new ArgumentOutOfRangeException(nameof(this.LastName), "Last name length is limited to 50 characters.") : value;
			}
		}

		/// <summary>
		/// The addresses
		/// </summary>
		private List<IAddressRecord> _addresses;

		/// <summary>
		/// Gets or sets the addresses.
		/// </summary>
		/// <value>The addresses.</value>
		public List<IAddressRecord> Addresses
		{
			get
			{
				return this._addresses;
			}
			init
			{
				this._addresses = value;
			}
		}

		/// <summary>
		/// Gets the hash code.
		/// </summary>
		/// <returns>int.</returns>
		public override int GetHashCode()
		{
			return HashCode.Combine(this.Email, this.Id);
		}

		/// <summary>
		/// Converts to string.
		/// </summary>
		/// <returns>string.</returns>
		public override string ToString() => this.Id.ToString(CultureInfo.CurrentCulture);


		/// <summary>
		/// Compares to.
		/// </summary>
		/// <param name="obj">The object.</param>
		/// <returns>int.</returns>
		/// <exception cref="ArgumentException">nameof(obj) + " is not a " + nameof(IPersonRecord)</exception>
		public int CompareTo(object obj)
		{
			if (obj is not IPersonRecord)
			{
				throw new ArgumentException(nameof(obj) + " is not a " + nameof(IPersonRecord));
			}

			return this.CompareTo((IPersonRecord)obj);
		}

		/// <summary>
		/// Compares to.
		/// </summary>
		/// <param name="other">The other.</param>
		/// <returns>int.</returns>
		public int CompareTo(IPersonRecord other)
		{
			if (other is null)
			{
				return 1;
			}

			var result = 0;


			result = this._bornOn.CompareTo(other.BornOn);
			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this._cellPhone, other.CellPhone, StringComparison.OrdinalIgnoreCase);
			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this._email, other.Email, StringComparison.OrdinalIgnoreCase);
			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this._firstName, other.FirstName, StringComparison.OrdinalIgnoreCase);
			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this._homePhone, other.HomePhone, StringComparison.OrdinalIgnoreCase);
			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this._id, other.Id, StringComparison.OrdinalIgnoreCase);
			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this._lastName, other.LastName, StringComparison.OrdinalIgnoreCase);
			if (result != 0)
			{
				return result;
			}

			return result;
		}

		/// <summary>
		/// Equals.
		/// </summary>
		/// <param name="other">The other.</param>
		/// <returns>bool.</returns>
		public bool Equals(IPersonRecord other)
		{
			if (other == null)
			{
				return false;
			}

			return ReferenceEquals(this, other);
		}

		/// <summary>
		/// Implements the &gt;= operator.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>The result of the operator.</returns>
		public static bool operator >=(PersonRecord left, PersonRecord right) => left is null ? right is null : left.CompareTo(right) >= 0;

		/// <summary>
		/// Implements the &gt; operator.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>The result of the operator.</returns>
		public static bool operator >(PersonRecord left, PersonRecord right) => left is object && left.CompareTo(right) > 0;


		/// <summary>
		/// Implements the &lt;= operator.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>The result of the operator.</returns>
		public static bool operator <=(PersonRecord left, PersonRecord right) => left is null || left.CompareTo(right) <= 0;

		/// <summary>
		/// Implements the &lt; operator.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>The result of the operator.</returns>
		public static bool operator <(PersonRecord left, PersonRecord right) => left is null ? right is object : left.CompareTo(right) < 0;
	}
}