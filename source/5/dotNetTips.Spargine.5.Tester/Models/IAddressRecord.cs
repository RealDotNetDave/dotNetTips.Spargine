// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Tester
// Author           : David McCarter
// Created          : 07-10-2019
//
// Last Modified By : David McCarter
// Last Modified On : 02-01-2021
// ***********************************************************************
// <copyright file="IAddressRecord.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using dotNetTips.Spargine.Core;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Tester.Models
{
	/// <summary>
	/// Interface IAddressRecord
	/// </summary>
	public interface IAddressRecord : IDataRecord<IAddressRecord, string>
	{
		/// <summary>
		/// Gets or sets address 1.
		/// </summary>
		/// <value>The address1.</value>
		string Address1 { get; init; }

		/// <summary>
		/// Gets or sets address2 .
		/// </summary>
		/// <value>The address2.</value>
		string Address2 { get; init; }

		/// <summary>
		/// Gets or sets the city location.
		/// </summary>
		/// <value>The city location.</value>
		string City { get; init; }

		/// <summary>
		/// Gets or sets the country for the address.
		/// </summary>
		/// <value>The country.</value>
		string Country { get; init; }

		/// <summary>
		/// Gets or sets the county province.
		/// </summary>
		/// <value>The county province.</value>
		string CountyProvince { get; init; }

		/// <summary>
		/// Gets or sets the home phone number.
		/// </summary>
		/// <value>The home phone number.</value>
		string Phone { get; init; }

		/// <summary>
		/// Gets or sets the postal code for the address.
		/// </summary>
		/// <value>The postal code for the address.</value>
		string PostalCode { get; init; }

		/// <summary>
		/// Gets or sets the state.
		/// </summary>
		/// <value>The state.</value>
		string State { get; init; }
	}
}
