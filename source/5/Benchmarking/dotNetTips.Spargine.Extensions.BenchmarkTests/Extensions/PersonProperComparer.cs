// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 12-15-2021
// ***********************************************************************
// <copyright file="PersonProperComparer.cs" company="dotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using dotNetTips.Spargine.Tester.Models.RefTypes;

namespace dotNetTips.Spargine.Extensions.BenchmarkTests
{
	/// <summary>
	/// Class PersonProperComparer.
	/// Implements the <see cref="IEqualityComparer" />
	/// </summary>
	/// <seealso cref="IEqualityComparer" />
	public class PersonProperComparer : IEqualityComparer<PersonProper>
	{

		/// <summary>
		/// Determines whether the specified objects are equal.
		/// </summary>
		/// <param name="x">The first object of type <paramref name="T" /> to compare.</param>
		/// <param name="y">The second object of type <paramref name="T" /> to compare.</param>
		/// <returns><see langword="true" /> if the specified objects are equal; otherwise, <see langword="false" />.</returns>
		public bool Equals([AllowNull] PersonProper x, [AllowNull] PersonProper y)
		{
			return x.Id == y.Id;
		}

		/// <summary>
		/// Returns a hash code for this instance.
		/// </summary>
		/// <param name="obj">The <see cref="T:System.Object" /> for which a hash code is to be returned.</param>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
		public int GetHashCode([DisallowNull] PersonProper obj)
		{
			return string.GetHashCode(obj.Id, StringComparison.Ordinal);
		}

	}
}
