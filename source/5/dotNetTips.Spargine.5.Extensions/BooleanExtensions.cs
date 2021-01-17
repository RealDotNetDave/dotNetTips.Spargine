// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions
// Author           : David McCarter
// Created          : 07-15-2020
//
// Last Modified By : David McCarter
// Last Modified On : 12-17-2020
// ***********************************************************************
// <copyright file="BooleanExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extensions for the boolean type.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Extensions.Properties;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Extensions for the boolean type.
	/// </summary>
	[Information(nameof(BooleanExtensions), author: "David McCarter", createdOn: "7/15/2020")]
	public static class BooleanExtensions
	{
		/// <summary>
		/// Converts to boolean value to lowercase.
		/// </summary>
		/// <param name="value">if set to <c>true</c> [value].</param>
		/// <returns>System.String.</returns>
		[ExcludeFromCodeCoverage]
		[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "11/17/2020", Status = Status.Available, BenchMarkStatus = BenchMarkStatus.NotRequired)]
		public static string ToLowerCase(this bool value) => value ? Resources.TrueLowerCase : Resources.FalseLowerCase;
	}
}
