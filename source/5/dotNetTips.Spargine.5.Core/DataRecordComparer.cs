// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Core
// Author           : David McCarter
// Created          : 02-01-2021
//
// Last Modified By : David McCarter
// Last Modified On : 12-15-2021
// ***********************************************************************
// <copyright file="DataRecordComparer.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections;
using System.Diagnostics.CodeAnalysis;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png; https://www.spargine.net )
namespace dotNetTips.Spargine.Core
{
	/// <summary>
	/// Class DataRecordComparer.
	/// Implements the <see cref="IEqualityComparer" />
	/// </summary>
	/// <seealso cref="IEqualityComparer" />
	public sealed class DataRecordComparer : IEqualityComparer<IDataRecord>
	{
		/// <summary>
		/// Determines whether the specified objects are equal.
		/// </summary>
		/// <param name="x">The first object of type <paramref name="x" /> to compare.</param>
		/// <param name="y">The second object of type <paramref name="y" /> to compare.</param>
		/// <returns><see langword="true" /> if the specified objects are equal; otherwise, <see langword="false" />.</returns>
		public bool Equals([AllowNull] IDataRecord x, [AllowNull] IDataRecord y)
		{
			return string.Equals(x?.Id, y?.Id, StringComparison.Ordinal);
		}

		/// <summary>
		/// Returns a hash code for this instance.
		/// </summary>
		/// <param name="obj">The <see cref="T:System.Object" /> for which a hash code is to be returned.</param>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
		public int GetHashCode([DisallowNull] IDataRecord obj)
		{
			return string.GetHashCode(obj.Id, StringComparison.Ordinal);
		}
	}
}
