// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Core
// Author           : David McCarter
// Created          : 02-27-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-27-2021
// ***********************************************************************
// <copyright file="Status.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Core
{

	/// <summary>
	/// Availability Status
	/// </summary>
	[Information(description: "For use in InformationAttribute.", author: "David McCarter", createdOn: "7/29/2020", BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
	public enum Status
	{
		/// <summary>
		/// Status not set.
		/// </summary>
		NotSet,

		/// <summary>
		/// New method or class.
		/// </summary>
		New,

		/// <summary>
		/// Method or class is available.
		/// </summary>
		Available,

		/// <summary>
		/// Method or class is not used
		/// </summary>
		NotUsed,

		/// <summary>
		/// Method or class has been updated
		/// </summary>
		Updated,
	}
}
