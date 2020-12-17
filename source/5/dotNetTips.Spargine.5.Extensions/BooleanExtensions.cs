// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions
// Author           : David McCarter
// Created          : 07-15-2020
//
// Last Modified By : David McCarter
// Last Modified On : 11-21-2020
// ***********************************************************************
// <copyright file="BooleanExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extensions for the boolean type.</summary>
// ***********************************************************************
using dotNetTips.Spargine.Core;

namespace dotNetTips.Spargine.Extensions
{
    /// <summary>
    /// Extensions for the boolean type.
    /// </summary>
    [Information(nameof(BooleanExtensions), author: "David McCarter", createdOn: "7/15/2020")]
    public static class BooleanExtensions
    {
        /// <summary>
        /// Converts to lowercase.
        /// </summary>
        /// <param name="value">if set to <c>true</c> [value].</param>
        /// <returns>System.String.</returns>
        [Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", Status = Status.Available, BenchMarkStatus = BenchMarkStatus.NotRequired)]
        public static string ToLowerCase(this bool value) => value ? "true" : "false";
    }
}
