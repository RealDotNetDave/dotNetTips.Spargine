// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions
// Author           : David McCarter
// Created          : 10-08-2020
//
// Last Modified By : David McCarter
// Last Modified On : 01-15-2021
// ***********************************************************************
// <copyright file="DataTableExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extension methods for the DataTable type.</summary>
// ***********************************************************************
using System;
using System.Data;
using dotNetTips.Spargine.Core;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Extension methods for the DataTable type.
	/// </summary>
	public static class DataTableExtensions
	{
		/// <summary>
		/// Determines whether the specified table has rows.
		/// </summary>
		/// <param name="table">The table.</param>
		/// <returns><c>true</c> if the specified table has rows; otherwise, <c>false</c>.</returns>
		[Information(nameof(HasRows), author: "David McCarter", createdOn: "10/8/2020", modifiedOn: "10/8/2020", UnitTestCoverage = 0, Status = Status.Available)]
		public static bool HasRows(this DataTable table)
		{
			return ( table != null ) && ( table.Rows != null ) && ( table.Rows.Count > 0 );
		}

		/// <summary>
		/// Determines whether [is database null] [the specified value].
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns><c>true</c> if [is database null] [the specified value]; otherwise, <c>false</c>.</returns>
		[Information(nameof(HasRows), author: "David McCarter", createdOn: "10/8/2020", modifiedOn: "10/8/2020", UnitTestCoverage = 0, Status = Status.Available)]
		public static bool IsDBNull(object value)
		{
			return Convert.IsDBNull(value);
		}

	}
}
