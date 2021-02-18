// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Core
// Author           : David McCarter
// Created          : 11-12-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-01-2021
// ***********************************************************************
// <copyright file="Collection.cs" company="dotNetTips.Spargine.5.Core">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Common class for collections.</summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Core.Collections
{
	/// <summary>
	/// Collection with added features.
	/// Implements the <see cref="System.Collections.Generic.List{T}" />
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <seealso cref="System.Collections.Generic.List{T}" />
	[Information("Collection<T>.", "David McCarter", "11/12/2020")]
	public class Collection<T> : List<T>
	{
		/// <summary>
		/// Prevents a default instance of the <see cref="Collection{T}" /> class from being created.
		/// </summary>
		[Information(nameof(Create), "David McCarter", "11/12/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.New)]
		private Collection()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Collection{T}" /> class.
		/// </summary>
		/// <param name="capacity">The number of elements that the new list can initially store.</param>
		[Information(nameof(Create), "David McCarter", "11/12/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.New)]
		private Collection(int capacity) : base(capacity)
		{
		}

		/// <summary>
		/// Creates this instance.
		/// </summary>
		/// <returns>Collection&lt;T&gt;.</returns>
		[Information(nameof(Create), "David McCarter", "11/12/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.New)]
		public static Collection<T> Create()
		{
			return new Collection<T>();
		}

		/// <summary>
		/// Creates collection with the specified capacity.
		/// </summary>
		/// <param name="capacity">The capacity.</param>
		/// <returns>Collection&lt;T&gt;.</returns>
		[Information(nameof(Create), "David McCarter", "11/12/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.New)]
		public static Collection<T> Create(int capacity)
		{
			Validate.TryValidateParam<ArgumentOutOfRangeException>(capacity >= 0, nameof(capacity));

			return new Collection<T>(capacity);
		}

		/// <summary>
		/// Creates the specified items.
		/// </summary>
		/// <param name="items">The items.</param>
		/// <returns>Collection&lt;T&gt;.</returns>
		[Information(nameof(Create), "David McCarter", "11/12/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.New)]
		public static Collection<T> Create(IEnumerable<T> items)
		{
			return Create(items, Tristate.False);
		}

		/// <summary>
		/// Creates the collection with the specified items.
		/// </summary>
		/// <param name="items">The items.</param>
		/// <param name="ensureUnique">if set to <c>true</c> [ensure unique].</param>
		/// <returns>Collection&lt;T&gt;.</returns>
		/// <exception cref="ArgumentNullException">Items 
		/// or has no items.</exception>
		[Information(nameof(Create), "David McCarter", "11/12/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.New, Documentation = "ADD LINK")]
		public static Collection<T> Create(IEnumerable<T> items, Tristate ensureUnique)
		{
			Validate.TryValidateParam(items, nameof(items));

			var newItems = new Collection<T>();

			foreach (var item in items.Where(p => p != null))
			{
				if (ensureUnique == Tristate.True || ensureUnique == Tristate.UseDefault)
				{
					newItems.AddIfNotExists(item);
				}
				else
				{
					newItems.Add(item);
				}
			}

			return newItems;
		}

		/// <summary>
		/// Adds the first.
		/// </summary>
		/// <param name="item">The item.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		[Information(nameof(Create), "David McCarter", "11/12/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.New)]
		public bool AddFirst(T item)
		{
			Validate.TryValidateNullParam(item, nameof(item));

			return Extensions.AddFirst(this, item);
		}

		/// <summary>
		/// Adds if not exists.
		/// </summary>
		/// <param name="item">The item.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		[Information(nameof(Create), "David McCarter", "11/12/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.New)]
		public bool AddIfNotExists(T item)
		{
			Validate.TryValidateParam<ArgumentNullException>(item != null, nameof(item));

			return Extensions.AddIfNotExists(this, item);
		}

		/// <summary>
		/// Adds the last.
		/// </summary>
		/// <param name="item">The item.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		[Information(nameof(Create), "David McCarter", "11/12/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.New)]
		public bool AddLast(T item)
		{
			Validate.TryValidateParam<ArgumentNullException>(item != null, nameof(item));

			return Extensions.AddLast(this, item);
		}
	}
}
