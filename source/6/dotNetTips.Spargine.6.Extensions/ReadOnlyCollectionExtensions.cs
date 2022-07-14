// ***********************************************************************
// Assembly         : dotNetTips.Spargine.6.Extensions
// Author           : David McCarter
// Created          : 04-27-2022
//
// Last Modified By : David McCarter
// Last Modified On : 07-14-2022
// ***********************************************************************
// <copyright file="ReadOnlyCollectionExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Class ReadOnlyCollectionExtensions.
	/// </summary>
	public static class ReadOnlyCollectionExtensions
	{

		/// <summary>
		/// Checks collection for null and insurese there are items in the collection.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list">The list.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		[Information(nameof(DoesNotHaveItems), author: "David McCarter", createdOn: "6/17/2022", UnitTestCoverage = 1000, BenchMarkStatus = BenchMarkStatus.None, Status = Status.New, Documentation = "ADD URL")]
		public static bool DoesNotHaveItems<T>([AllowNull] this ReadOnlyCollection<T> list)
		{
			if (list is null)
			{
				return true;
			}
			else
			{
				return list.Count() <= 0;
			}
		}

		/// <summary>
		/// Generates hash code for the collection.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The list to use to generate hash code.</param>
		/// <returns>Hash code as System.Int32.</returns>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static int GenerateHashCode<T>([NotNull] this ReadOnlyCollection<T> list)
		{
			list = list.ArgumentNotNull();

			EqualityComparer<T> comparer = EqualityComparer<T>.Default;
			var hash = list.Where(item => item is not null)
				.Aggregate(6551, (accumulator, t) =>
				{
					return accumulator ^= ( accumulator << 5 ) ^ comparer.GetHashCode(t);
				});

			return hash;
		}

		/// <summary>
		/// Determines whether the specified list has items.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list">The list.</param>
		/// <param name="action">The action.</param>
		/// <returns>bool.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(HasItems), author: "David McCarter", createdOn: "6/15/2022", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.New, Documentation = "ADD URL")]
		public static bool HasItems<T>([AllowNull] this ReadOnlyCollection<T> list, [NotNull] Func<T, bool> action)
		{
			if (list is null || action is null)
			{
				return false;
			}
			else
			{
				return list.Any(action);
			}
		}
	}
}
