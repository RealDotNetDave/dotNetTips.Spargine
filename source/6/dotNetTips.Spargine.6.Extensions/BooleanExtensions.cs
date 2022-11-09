// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions
// Author           : David McCarter
// Created          : 07-15-2020
//
// Last Modified By : David McCarter
// Last Modified On : 05-25-2022
// ***********************************************************************
// <copyright file="BooleanExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extensions for the boolean type.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions.Properties;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Extensions for the boolean type.
/// </summary>
[Information(nameof(BooleanExtensions), author: "David McCarter", createdOn: "7/15/2020")]
public static class BooleanExtensions
{
	/// <summary>
	/// Converts to <see cref="bool" /> value to lowercase.
	/// </summary>
	/// <param name="value">if set to <c>true</c> [value].</param>
	/// <returns>System.String.</returns>
	[ExcludeFromCodeCoverage]
	[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", Status = Status.Available, BenchMarkStatus = BenchMarkStatus.NotRequired)]
	public static string ToLowerCase(this bool value)
	{
		return value ? Resources.TrueLowerCase : Resources.FalseLowerCase;
	}
}
