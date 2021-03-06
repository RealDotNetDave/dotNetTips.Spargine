﻿// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-01-2021
// ***********************************************************************
// <copyright file="SortedDictionaryExtensions.cs" company="dotNetTips.Spargine.5.Extensions">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using System.Collections.Immutable;
using dotNetTips.Spargine.Core;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Class SortedDictionaryExtensions.
	/// </summary>
	public static class SortedDictionaryExtensions
	{
		/// <summary>
		/// Converts to immutable Dictionary.
		/// </summary>
		/// <typeparam name="TKey">The type of the t key.</typeparam>
		/// <typeparam name="TValue">The type of the t value.</typeparam>
		/// <param name="list">The values.</param>
		/// <returns>ImmutableSortedDictionary&lt;TKey, TValue&gt;.</returns>
		[Information(nameof(ToImmutable), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 100, Status = Status.Available)]
		public static ImmutableSortedDictionary<TKey, TValue> ToImmutable<TKey, TValue>(this SortedDictionary<TKey, TValue> list)
		{
			Validate.TryValidateParam(list, nameof(list));

			return ImmutableSortedDictionary.CreateRange<TKey, TValue>(list);
		}
	}
}
