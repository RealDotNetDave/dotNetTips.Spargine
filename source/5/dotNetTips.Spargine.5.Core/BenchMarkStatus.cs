﻿// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Core
// Author           : David McCarter
// Created          : 02-27-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-27-2021
// ***********************************************************************
// <copyright file="BenchMarkStatus.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Core
{
	/// <summary>
	/// BenchMarkStatus attribute to add more meta data for types.
	/// </summary>
	/// <remarks>For use in InformationAttribute.</remarks>
	[Information(description: "For use in InformationAttribute.", author: "David McCarter", createdOn: "7/29/2020", BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
	public enum BenchMarkStatus
	{
		/// <summary>
		/// No benchmark.
		/// </summary>
		/// <summary>
		/// The none
		/// </summary>
		None,

		/// <summary>
		/// Benchmark is not required
		/// </summary>
		/// <summary>
		/// The not required
		/// </summary>
		NotRequired,
		/// <summary>
		/// Enum BenchMarkStatus
		/// </summary>

		/// <summary>
		/// Benchmark work is in progress.
		/// </summary>
		/// <summary>
		/// The wip
		/// </summary>
		WIP,

		/// <summary>
		/// The none
		/// </summary>
		/// <summary>
		/// Benchmarks done.
		/// </summary>
		/// <summary>
		/// The completed
		/// </summary>
		Completed
	}
}
