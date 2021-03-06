﻿// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-01-2021
// ***********************************************************************
// <copyright file="HashSetExtensions.cs" company="dotNetTips.Spargine.5.Extensions">
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
	/// Class HashSetExtensions.
	/// </summary>
	public static class HashSetExtensions
	{
		/// <summary>
		/// Converts to ImmutableHashSet<typeparamref name="T" />&gt;.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The values.</param>
		/// <returns>ImmutableHashSet<typeparamref name="T" />&gt;.</returns>
		[Information(nameof(ToImmutable), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 0, Status = Status.Available)]
		public static ImmutableHashSet<T> ToImmutable<T>(this HashSet<T> list)
		{
			Validate.TryValidateParam(list, nameof(list));

			return ImmutableHashSet.CreateRange<T>(list);
		}
	}
}
