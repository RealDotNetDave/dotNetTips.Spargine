// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Core
// Author           : David McCarter
// Created          : 05-30-2021
//
// Last Modified By : David McCarter
// Last Modified On : 12-27-2021
// ***********************************************************************
// <copyright file="KeyGenerator.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png; https://www.spargine.net )
namespace dotNetTips.Spargine.Core
{
	/// <summary>
	/// Class KeyGenerator.
	/// </summary>
	public static class KeyGenerator
	{
		/// <summary>
		/// Creates a random key from a GUID.
		/// </summary>
		/// <returns>System.String.</returns>
		/// <example>f7f0af78003d4ab194b5a4024d02112a</example>
		[Information(nameof(GenerateKey), "David McCarter", "5/30/2021", UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static string GenerateKey() => Guid.NewGuid().ToString("N", CultureInfo.InvariantCulture);

		/// <summary>
		/// Creates a random key from a GUID.
		/// </summary>
		/// <param name="prefix">The prefix.</param>
		/// <returns>System.String.</returns>
		/// <example>DataRecordf7f0af78003d4ab194b5a4024d02112a</example>
		[Information(nameof(GenerateKey), "David McCarter", "5/30/2021", UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static string GenerateKey([NotNull] string prefix)
		{
			return $"{prefix}{Guid.NewGuid().ToString("N", CultureInfo.InvariantCulture)}";

		}
	}
}
