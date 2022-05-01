// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions
// Author           : David McCarter
// Created          : 10-08-2020
//
// Last Modified By : David McCarter
// Last Modified On : 04-27-2022
// ***********************************************************************
// <copyright file="DataContextExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extension methods for the DataContext type.</summary>
// ***********************************************************************
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using DotNetTips.Spargine.Core;
using LinqToDB;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Extension methods for the DataContext type.
	/// </summary>
	public static class DataContextExtensions
	{
		/// <summary>
		/// Gets the tracked objects from a <see cref="DataContext" />.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="context">The context.</param>
		/// <returns>IList&lt;Tuple&lt;T, T&gt;&gt;.</returns>
		/// <exception cref="ArgumentNullException">context</exception>
		[Information(nameof(GetTrackedObjects), author: "David McCarter", createdOn: "10/8/2020", UnitTestCoverage = 0, Status = Status.Available)]
		public static IList<Tuple<T, T>> GetTrackedObjects<T>([NotNull] this DataContext context)
		{
			context = context.ArgumentNotNull();

			var result = new List<Tuple<T, T>>();
			var dcType = typeof(DataContext);

			// Use reflection to get to the underlying items being tracked in the DataContext
			const BindingFlags Bindings = BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.GetField;

			var services = dcType.GetField("services", Bindings).GetValue(context);
			var tracker = services.GetType().GetField("tracker", Bindings).GetValue(services);
			var trackerItems = (IDictionary)tracker.GetType().GetField("items", Bindings).GetValue(tracker);

			// iterate through each update in context, adding only those that are of type T to the method's result variable
			foreach (DictionaryEntry entry in trackerItems)
			{
				dynamic original = entry.Value.GetType().GetField(nameof(original), Bindings).GetValue(entry.Value);

				if (entry.Key is T t && original is T)
				{
					result.Add(new Tuple<T, T>(original, t));
				}
			}

			return result;
		}

	}
}
