// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions **
// Author           : David McCarter
// Created          : 07-30-2018
//
// Last Modified By : David McCarter
// Last Modified On : 04-15-2022
// ***********************************************************************
// <copyright file="GuidExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using DotNetTips.Spargine.Core;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Class GuidExtensions.
	/// </summary>
	public static class GuidExtensions
	{
		/// <summary>
		/// Returns the <see cref="Guid"/> without dashes.
		/// </summary>
		/// <param name="input">The Guid value.</param>
		/// <returns>System.String.</returns>
		[Information(nameof(ToDigits), UnitTestCoverage = 0, Status = Status.Available)]
		public static string ToDigits([NotNull] this Guid input)
		{
			return input.ArgumentNotNull().ToString("N", CultureInfo.InvariantCulture);
		}
	}
}
