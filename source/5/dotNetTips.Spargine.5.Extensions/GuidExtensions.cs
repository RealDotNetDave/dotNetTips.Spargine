// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions **
// Author           : David McCarter
// Created          : 07-30-2018
//
// Last Modified By : David McCarter
// Last Modified On : 03-03-2019
// ***********************************************************************
// <copyright file="GuidExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Globalization;
using dotNetTips.Spargine.Core;

//![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Class GuidExtensions.
	/// </summary>
	public static class GuidExtensions
	{
		/// <summary>
		/// Returns the Guid without dashes.
		/// </summary>
		/// <param name="value">The Guid value.</param>
		/// <returns>System.String.</returns>
		[Information(nameof(ToDigits), UnitTestCoverage = 0, Status = Status.Available)]
		public static string ToDigits(this Guid value)
		{
			return value.ToString("N", CultureInfo.InvariantCulture);
		}
	}
}
