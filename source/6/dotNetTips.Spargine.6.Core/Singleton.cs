// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Core
// Author           : David McCarter
// Created          : 07-12-2021
//
// Last Modified By : David McCarter
// Last Modified On : 10-31-2022
// ***********************************************************************
// <copyright file="Singleton.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Singleton. This class cannot be inherited.
/// </summary>
/// <typeparam name="T"></typeparam>
/// <remarks>Inspired by the C# Design Patterns: Singleton course on Pluralsight.</remarks>
[Information(nameof(Singleton<T>), author: "David McCarter", createdOn: "7/12/2021", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineSep2022")]
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
