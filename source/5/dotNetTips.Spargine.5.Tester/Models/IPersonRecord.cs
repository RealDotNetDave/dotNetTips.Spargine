// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Tester
// Author           : David McCarter
// Created          : 07-10-2019
//
// Last Modified By : David McCarter
// Last Modified On : 02-01-2021
// ***********************************************************************
// <copyright file="IPersonRecord.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using dotNetTips.Spargine.Core;


//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Tester.Models
{
	/// <summary>
	/// The interface for IPerson
	/// </summary>
	public interface IPersonRecord : IDataRecord<PersonRecord, string>
	{
		/// <summary>
		/// Gets or sets the addresses.
		/// </summary>
		/// <value>The addresses.</value>
		List<AddressRecord> Addresses { get; init; }

		/// <summary>
		/// Gets or sets the born on date, time and local.
		/// </summary>
		/// <value>The born on date.</value>
		DateTimeOffset BornOn { get; init; }

		/// <summary>
		/// Gets or sets the cell phone number.
		/// </summary>
		/// <value>The cell phone number.</value>
		string CellPhone { get; init; }

		/// <summary>
		/// Gets or sets the email address.
		/// </summary>
		/// <value>The email address.</value>
		string Email { get; init; }

		/// <summary>
		/// Gets or sets the person's first name.
		/// </summary>
		/// <value>The first name.</value>
		string FirstName { get; init; }

		/// <summary>
		/// Gets or sets the home phone number.
		/// </summary>
		/// <value>The home phone number.</value>
		string HomePhone { get; init; }

		/// <summary>
		/// Gets or sets the person's last name.
		/// </summary>
		/// <value>The last name.</value>
		string LastName { get; init; }

		/// <summary>
		/// Calculates the age.
		/// </summary>
		/// <returns>System.TimeSpan.</returns>
		public TimeSpan Age() => DateTimeOffset.UtcNow.Subtract(this.BornOn);
	}
}
