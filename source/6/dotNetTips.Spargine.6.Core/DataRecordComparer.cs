// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Core
// Author           : David McCarter
// Created          : 02-01-2021
//
// Last Modified By : David McCarter
// Last Modified On : 03-13-2023
// ***********************************************************************
// <copyright file="DataRecordComparer.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections;
using System.Diagnostics.CodeAnalysis;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core;

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
	/// <param name="obj">The <see cref="object" /> for which a hash code is to be returned.</param>
	/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
	public int GetHashCode([DisallowNull] IDataRecord obj)
	{
		return string.GetHashCode(obj.ArgumentNotNull().Id, StringComparison.Ordinal);
	}

}
