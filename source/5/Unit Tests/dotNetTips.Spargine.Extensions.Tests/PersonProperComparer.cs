// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 04-16-2021
//
// Last Modified By : David McCarter
// Last Modified On : 04-16-2021
// ***********************************************************************
// <copyright file="PersonProperComparer.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using dotNetTips.Spargine.Tester.Models;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Extensions.Tests
{
	/// <summary>
	/// Class PersonProperComparer.
	/// Implements the <see cref="System.Collections.Generic.IEqualityComparer{dotNetTips.Spargine.Tester.Models.PersonProper}" />
	/// </summary>
	/// <seealso cref="System.Collections.Generic.IEqualityComparer{dotNetTips.Spargine.Tester.Models.PersonProper}" />
	public class PersonProperComparer : IEqualityComparer<PersonProper>
	{
		/// <summary>
		/// Determines whether the specified objects are equal.
		/// </summary>
		/// <param name="x">The first object of type <paramref name="T" /> to compare.</param>
		/// <param name="y">The second object of type <paramref name="T" /> to compare.</param>
		/// <returns><see langword="true" /> if the specified objects are equal; otherwise, <see langword="false" />.</returns>
		public bool Equals([AllowNull] PersonProper x, [AllowNull] PersonProper y) { return string.Compare(x.Id, y.Id, StringComparison.Ordinal) == 0; }

		/// <summary>
		/// Returns a hash code for this instance.
		/// </summary>
		/// <param name="obj">The <see cref="T:System.Object" /> for which a hash code is to be returned.</param>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
		public int GetHashCode([DisallowNull] PersonProper obj) { return obj.Id.GetHashCode(); }
	}
}
