// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Core
// Author           : David McCarter
// Created          : 02-01-2021
//
// Last Modified By : David McCarter
// Last Modified On : 03-04-2021
// ***********************************************************************
// <copyright file="DataRecord.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Base type for data record classes.</summary>
// ***********************************************************************

using System.ComponentModel.DataAnnotations;
using dotNetTips.Spargine.Core.Internal;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Core
{
	/// <summary>
	/// Base type for data record classes.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TKey"></typeparam>
	[Information(nameof(DataRecord<T, TKey>), author: "David McCarter", createdOn: "3/4/2021", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.New)]
	public record DataRecord<T, TKey>
	{
		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
		[Required]
		public TKey Id { get; init; }

		/// <summary>
		/// Alls the properties to string.
		/// </summary>
		/// <returns>string.</returns>
		public string AllPropertiesToString()
		{
			return this.PropertiesToString();
		}

	}
}
