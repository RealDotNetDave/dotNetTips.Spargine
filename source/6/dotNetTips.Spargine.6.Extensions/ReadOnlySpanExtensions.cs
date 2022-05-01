﻿// ***********************************************************************
// Assembly         : dotNetTips.Spargine.6.Extensions
// Author           : David McCarter
// Created          : 04-27-2022
//
// Last Modified By : David McCarter
// Last Modified On : 04-27-2022
// ***********************************************************************
// <copyright file="ReadOnlySpanExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Security.Cryptography;
using DotNetTips.Spargine.Core;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Class ReadOnlySpanExtensions.
	/// </summary>
	public static class ReadOnlySpanExtensions
	{
		/// <summary>
		/// Picks a random item from a <see cref="ReadOnlySpan{T}" />.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list">The list.</param>
		/// <returns>ReadOnlySpan&lt;T&gt;.</returns>
		[Information(nameof(PickRandom), "David McCarter", "6/28/2021", BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, UnitTestCoverage = 0)]
		public static ReadOnlySpan<T> PickRandom<T>(this ReadOnlySpan<T> list)
		{
			list = list.ArgumentNotEmpty();

			var index = RandomNumberGenerator.GetInt32(0, list.Length - 1);

			return list[index..];
		}
	}
}
