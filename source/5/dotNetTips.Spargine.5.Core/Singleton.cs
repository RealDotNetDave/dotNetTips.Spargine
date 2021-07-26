
// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Core
// Author           : David McCarter
// Created          : 07-12-2021
//
// Last Modified By : David McCarter
// Last Modified On : 07-25-2021
// ***********************************************************************
// <copyright file="Singleton.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

namespace dotNetTips.Spargine.Core
{
	/// <summary>
	/// Singleton. This class cannot be inherited.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <remarks>Inspired by the C# Design Patterns: Singleton course on Pluralsight.</remarks>
	[Information(nameof(Singleton<T>), author: "David McCarter", createdOn: "7/12/2021", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.New, Documentation = "ADD URL TO SEP ARTICLE")]
	public sealed class Singleton<T> where T : new()
	{
		/// <summary>
		/// The lazy instance.
		/// </summary>
		private static readonly Lazy<T> _lazy = new(() => new T());

		/// <summary>
		/// Initializes static members of the <see cref="Singleton{T}" /> class.
		/// </summary>
		private Singleton()
		{ }

		/// <summary>
		/// Gets the instance of T.
		/// </summary>
		/// <value>The instance.</value>
		public static T Instance => _lazy.Value;
	}
}
