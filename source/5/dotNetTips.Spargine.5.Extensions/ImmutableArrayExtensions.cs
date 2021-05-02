// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 01-21-2021
// ***********************************************************************
// <copyright file="ImmutableArrayExtensions.cs" company="dotNetTips.Spargine.5.Extensions">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Immutable;
using System.Linq;
using dotNetTips.Spargine.Core;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Class ImmutableArrayExtensions.
	/// </summary>
	public static class ImmutableArrayExtensions
	{
		/// <summary>
		/// The global random
		/// </summary>
		private static readonly Random _globalRandom = new((int)DateTime.Now.Ticks);

		/// <summary>
		/// The random
		/// </summary>
		[ThreadStatic]
		private static Random _random;

		/// <summary>
		/// Gets the random.
		/// </summary>
		/// <value>The random.</value>
		private static Random Random
		{
			get
			{
				if (_random is null)
				{
					int seed;

					lock (_globalRandom)
					{
						seed = _globalRandom.Next();
					}

					_random = new Random(seed);
				}

				return _random;
			}
		}

		/// <summary>
		/// Shuffles the specified items.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The items.</param>
		/// <returns>IEnumerable&lt;T&gt;.</returns>
		/// <exception cref="ArgumentNullException">list</exception>
		[Information(nameof(Shuffle), "David McCarter", "8/27/2020", "1/21/2020", BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, UnitTestCoverage = 0)]
		public static ImmutableArray<T> Shuffle<T>(this ImmutableArray<T> list)
		{
			if (list.DoesNotHaveItems())
			{
				return list;
			}
			
			return list.OrderBy(i => _random.Next()).ToImmutableArray();
		}
	}
}
