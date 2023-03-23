// ***********************************************************************
// Assembly         : dotNetTips.Spargine.6.Tester
// Author           : David McCarter
// Created          : 07-10-2019
//
// Last Modified By : David McCarter
// Last Modified On : 03-13-2023
// ***********************************************************************
// <copyright file="IPerson.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

using DotNetTips.Spargine.Core;

namespace DotNetTips.Spargine.Tester.Models.RefTypes;

/// <summary>
/// The interface for IPerson
/// </summary>
[Information(Status = Status.Available, Documentation = "https://bit.ly/UnitTestRandomData7")]
public interface IPerson
{
	/// <summary>
	/// Gets or sets address 1.
	/// </summary>
	/// <value>The address1.</value>
	string Address1 { get; set; }

	/// <summary>
	/// Gets or sets address2 .
	/// </summary>
	/// <value>The address2.</value>
	string Address2 { get; set; }

	/// <summary>
	/// Gets or sets the born on date, time and local.
	/// </summary>
	/// <value>The born on date.</value>
	DateTimeOffset BornOn { get; set; }

	/// <summary>
	/// Gets or sets the cell phone number.
	/// </summary>
	/// <value>The cell phone number.</value>
	string CellPhone { get; set; }

	/// <summary>
	/// Gets or sets the city location.
	/// </summary>
	/// <value>The city location.</value>
	string City { get; set; }

	/// <summary>
	/// Gets or sets the country for the address.
	/// </summary>
	/// <value>The country.</value>
	string Country { get; set; }

	/// <summary>
	/// Gets or sets the email address.
	/// </summary>
	/// <value>The email address.</value>
	string Email { get; set; }

	/// <summary>
	/// Gets or sets the person's first name.
	/// </summary>
	/// <value>The first name.</value>
	string FirstName { get; set; }

	/// <summary>
	/// Gets or sets the home phone number.
	/// </summary>
	/// <value>The home phone number.</value>
	string HomePhone { get; set; }

	/// <summary>
	/// Gets or sets the person's identifier.
	/// </summary>
	/// <value>The identifier.</value>
	string Id { get; set; }

	/// <summary>
	/// Gets or sets the person's last name.
	/// </summary>
	/// <value>The last name.</value>
	string LastName { get; set; }

	/// <summary>
	/// Gets or sets the postal code for the address.
	/// </summary>
	/// <value>The postal code for the address.</value>
	string PostalCode { get; set; }

	/// <summary>
	/// Gets or sets the state.
	/// </summary>
	/// <value>The state.</value>
	string State { get; set; }
}
