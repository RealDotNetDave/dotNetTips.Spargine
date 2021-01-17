// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Tester
// Author           : David McCarter
// Created          : 06-04-2019
//
// Last Modified By : David McCarter
// Last Modified On : 01-05-2021
// ***********************************************************************
// <copyright file="PersonFixed.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using dotNetTips.Spargine.Core.OOP;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Tester.Models
{
	/// <summary>
	/// Person class that implements interfaces.
	/// Implements the <see cref="dotNetTips.Spargine.Tester.Models.Person" />
	/// Implements the <see cref="System.IComparable" />
	/// </summary>
	/// <seealso cref="dotNetTips.Spargine.Tester.Models.IPerson" />
	/// <seealso cref="dotNetTips.Spargine.Tester.Models.Person" />
	/// <seealso cref="System.IComparable" />
	[DebuggerDisplay("{Email}")]
	public sealed class PersonFixed : IPerson, IDataModel<PersonFixed, string>
	{

		/// <summary>
		/// Initializes a new instance of <see cref="PersonFixed" />.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public PersonFixed()
		{
		}

		/// <summary>
		/// Initializes a new instance of <see cref="PersonFixed" />.
		/// </summary>
		/// <param name="id">The unique identifier.</param>
		/// <param name="email">The email address.</param>
		public PersonFixed(string id, string email)
		{
			this.Id = id;
			this.Email = email;
		}

		/// <summary>
		/// Gets or sets the address1.
		/// </summary>
		/// <value>The address1.</value>
		public string Address1 { get; set; }

		/// <summary>
		/// Gets or sets the address2.
		/// </summary>
		/// <value>The address2.</value>
		public string Address2 { get; set; }

		/// <summary>
		/// Gets the age.
		/// </summary>
		/// <value>The age.</value>
		public TimeSpan Age => this.CalculateAge();

		/// <summary>
		/// Gets or sets the born on.
		/// </summary>
		/// <value>The born on.</value>
		public DateTimeOffset BornOn { get; set; }

		/// <summary>
		/// Gets or sets the cell phone.
		/// </summary>
		/// <value>The cell phone.</value>
		public string CellPhone { get; set; }

		/// <summary>
		/// Gets or sets the city.
		/// </summary>
		/// <value>The city.</value>
		public string City { get; set; }

		/// <summary>
		/// Gets or sets the country.
		/// </summary>
		/// <value>The country.</value>
		public string Country { get; set; } = "USA";

		/// <summary>
		/// Gets the email.
		/// </summary>
		/// <value>The email.</value>
		public string Email { get; set; }

		/// <summary>
		/// Gets or sets the first name.
		/// </summary>
		/// <value>The first name.</value>
		public string FirstName { get; set; }

		/// <summary>
		/// Gets or sets the home phone.
		/// </summary>
		/// <value>The home phone.</value>
		public string HomePhone { get; set; }

		/// <summary>
		/// Gets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
		public string Id { get; set; }

		/// <summary>
		/// Gets or sets the last name.
		/// </summary>
		/// <value>The last name.</value>
		public string LastName { get; set; }

		/// <summary>
		/// Gets or sets the postal code.
		/// </summary>
		/// <value>The postal code.</value>
		public string PostalCode { get; set; }

		/// <summary>
		/// Gets or sets the state.
		/// </summary>
		/// <value>The state.</value>
		public string State { get; set; }

		/// <summary>
		/// Implements the &gt;= operator.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>The result of the operator.</returns>
		public static bool operator >=(PersonFixed left, PersonFixed right) => left is null ? right is null : left.CompareTo(right) >= 0;

		/// <summary>
		/// Implements the &gt; operator.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>The result of the operator.</returns>
		public static bool operator >(PersonFixed left, PersonFixed right) => left is object && left.CompareTo(right) > 0;

		/// <summary>
		/// Implements the == operator.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>The result of the operator.</returns>
		public static bool operator ==(PersonFixed left, PersonFixed right) => left is null ? right is null : left.Equals(right);

		/// <summary>
		/// Implements the &lt;= operator.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>The result of the operator.</returns>
		public static bool operator <=(PersonFixed left, PersonFixed right) => left is null || left.CompareTo(right) <= 0;

		/// <summary>
		/// Implements the &lt; operator.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>The result of the operator.</returns>
		public static bool operator <(PersonFixed left, PersonFixed right) => left is null ? right is object : left.CompareTo(right) < 0;

		/// <summary>
		/// Implements the != operator.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>The result of the operator.</returns>
		public static bool operator !=(PersonFixed left, PersonFixed right) => !( left == right );

		/// <summary>
		/// Compares to.
		/// </summary>
		/// <param name="other">The other.</param>
		/// <returns>System.Int32.</returns>
		public int CompareTo(PersonFixed other)
		{
			if (other is null)
			{
				return 1;
			}

			var result = string.Compare(this.Email, other.Email, StringComparison.CurrentCultureIgnoreCase);
			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this.Id, other.Id, StringComparison.CurrentCultureIgnoreCase);

			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this.Address1, other.Address1, StringComparison.CurrentCultureIgnoreCase);

			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this.Address2, other.Address2, StringComparison.CurrentCultureIgnoreCase);

			if (result != 0)
			{
				return result;
			}

			result = this.BornOn.CompareTo(other.BornOn);
			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this.CellPhone, other.CellPhone, StringComparison.CurrentCultureIgnoreCase);

			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this.City, other.City, StringComparison.CurrentCultureIgnoreCase);
			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this.Country, other.Country, StringComparison.CurrentCultureIgnoreCase);

			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this.FirstName, other.FirstName, StringComparison.CurrentCultureIgnoreCase);

			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this.HomePhone, other.HomePhone, StringComparison.CurrentCultureIgnoreCase);

			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this.LastName, other.LastName, StringComparison.CurrentCultureIgnoreCase);

			if (result != 0)
			{
				return result;
			}

			result = string.Compare(this.PostalCode, other.PostalCode, StringComparison.CurrentCultureIgnoreCase);

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
		/// Determis if this instance is equal to the pased in instance.
		/// </summary>
		/// <param name="other">The other.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		/// <exception cref="NotImplementedException"></exception>
		public bool Equals(PersonFixed other)
		{
			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return false;
		}

		/// <summary>
		/// Returns the hash code for this instance.
		/// </summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
		public override int GetHashCode()
		{
			return HashCode.Combine(this.Email, this.Id);
		}

		/// <summary>
		/// Returns a <see cref="string" /> that returns the person's id.
		/// </summary>
		/// <returns>A <see cref="string" /> that returns the person's id.</returns>
		public override string ToString() => this.Id.ToString(CultureInfo.CurrentCulture);

		/// <summary>
		/// Calculates the person's current age.
		/// </summary>
		/// <returns>TimeSpan.</returns>
		private TimeSpan CalculateAge() => DateTimeOffset.UtcNow.Subtract(this.BornOn);

	}
}
