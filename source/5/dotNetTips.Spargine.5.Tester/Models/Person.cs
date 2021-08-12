// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Tester
// Author           : David McCarter
// Created          : 06-04-2019
//
// Last Modified By : David McCarter
// Last Modified On : 01-15-2021
// ***********************************************************************
// <copyright file="Person.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Globalization;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Tester.Models
{
	/// <summary>
	/// The Person class.
	/// Implements the <see cref="dotNetTips.Spargine.Tester.Models.IPerson" />
	/// </summary>
	/// <seealso cref="dotNetTips.Spargine.Tester.Models.IPerson" />
	/// <seealso cref="System.IComparable" />
	public class Person : IPerson
	{
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
