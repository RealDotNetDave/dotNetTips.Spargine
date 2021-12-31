// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions
// Author           : David McCarter
// Created          : 10-08-2020
//
// Last Modified By : David McCarter
// Last Modified On : 08-19-2021
// ***********************************************************************
// <copyright file="DataContextExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extension methods for the DataContext type.</summary>
// ***********************************************************************
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using dotNetTips.Spargine.Core;
using LinqToDB;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png; https://www.spargine.net )
namespace dotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Extension methods for the DataContext type.
	/// </summary>
	public static class DataContextExtensions
	{
		/// <summary>
		/// Gets the tracked objects.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="context">The context.</param>
		/// <returns>IList&lt;Tuple&lt;T, T&gt;&gt;.</returns>
		/// <exception cref="ArgumentNullException">context</exception>
		[Information(nameof(GetTrackedObjects), author: "David McCarter", createdOn: "10/8/2020", modifiedOn: "10/8/2020", UnitTestCoverage = 0, Status = Status.Available)]
		public static IList<Tuple<T, T>> GetTrackedObjects<T>([NotNull] this DataContext context)
		{
			var result = new List<Tuple<T, T>>();
			var dcType = typeof(DataContext);

			// Use reflection to get to the underlying items being tracked in the DataContext
			const BindingFlags bindings = BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.GetField;

			var services = dcType.GetField("services", bindings).GetValue(context);
			var tracker = services.GetType().GetField("tracker", bindings).GetValue(services);
			var trackerItems = (IDictionary)tracker.GetType().GetField("items", bindings).GetValue(tracker);

			// iterate through each update in context, adding only those that are of type T to the method's result variable
			foreach (DictionaryEntry entry in trackerItems)
			{
				dynamic original = entry.Value.GetType().GetField(nameof(original), bindings).GetValue(entry.Value);

				if (entry.Key is T t && original is T)
				{
					result.Add(new Tuple<T, T>(original, t));
				}
			}

			return result;
		}

	}
}
