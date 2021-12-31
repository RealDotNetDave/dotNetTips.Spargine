// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Tester
// Author           : david
// Created          : 10-25-2021
//
// Last Modified By : david
// Last Modified On : 11-27-2021
// ***********************************************************************
// <copyright file="Person.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Globalization;
using dotNetTips.Spargine.Tester.Models.RefTypes;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )

namespace dotNetTips.Spargine.Tester.Models.ValueTypes
{
	/// <summary>
	/// Struct Person
	/// Implements the <see cref="IPerson" />
	/// </summary>
	/// <seealso cref="IPerson" />
	/// <seealso cref="IEquatable{Person}" />
	public struct Person : IPerson, IEquatable<Person>
	{

		/// <summary>
		/// Implements the != operator.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>The result of the operator.</returns>
		public static bool operator !=(Person left, Person right)
		{
			return !( left == right );
		}

		/// <summary>
		/// Implements the == operator.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>The result of the operator.</returns>
		public static bool operator ==(Person left, Person right)
		{
			return left.Equals(right);
		}

		/// <summary>
		/// Determines whether the specified <see cref="object" /> is equal to this instance.
		/// </summary>
		/// <param name="obj">The object to compare with the current instance.</param>
		/// <returns><c>true</c> if the specified <see cref="object" /> is equal to this instance; otherwise, <c>false</c>.</returns>
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		/// <summary>
		/// Indicates whether the current object is equal to another object of the same type.
		/// </summary>
		/// <param name="other">An object to compare with this object.</param>
		/// <returns><see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.</returns>
		public bool Equals(Person other)
		{
			return base.Equals(other);
		}

		/// <summary>
		/// Returns a hash code for this instance.
		/// </summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>
		/// Returns a <see cref="string" /> that represents this instance.
		/// </summary>
		/// <returns>A <see cref="string" /> that represents this instance.</returns>
		public override string ToString()
		{
			return base.ToString();
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
		public string Country { get; set; } = RegionInfo.CurrentRegion.ThreeLetterISORegionName;

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
	}
}
