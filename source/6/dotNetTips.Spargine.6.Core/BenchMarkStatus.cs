// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Core
// Author           : David McCarter
// Created          : 02-27-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-16-2022
// ***********************************************************************
// <copyright file="BenchMarkStatus.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core
{
	/// <summary>
	/// BenchMarkStatus attribute to add more meta data for types.
	/// </summary>
	/// <remarks>For use in InformationAttribute.</remarks>
	[Information(description: "For use in InformationAttribute.", author: "David McCarter", createdOn: "7/29/2020", BenchMarkStatus = NotRequired, Status = Status.Available)]
	public enum BenchMarkStatus
	{
		/// <summary>
		/// No benchmark.
		/// </summary>
		None,

		/// <summary>
		/// Benchmark is not required
		/// </summary>
		NotRequired,

		/// <summary>
		/// Benchmark work is in progress.
		/// </summary>
		WIP,

		/// <summary>
		/// Benchmarks test done.
		/// </summary>
		Completed,

		/// <summary>
		/// Benchmark needs to be updated
		/// </summary>
		NeedsUpdate,
	}
}
