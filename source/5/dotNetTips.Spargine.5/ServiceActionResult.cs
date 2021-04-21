// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5
// Author           : David McCarter
// Created          : 03-15-2021
//
// Last Modified By : David McCarter
// Last Modified On : 03-15-2021
// ***********************************************************************
// <copyright file="ServiceActionResult.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine
{
	/// <summary>
	/// Enum ServiceActionResult.
	/// </summary>
	public enum ServiceActionResult
	{
		/// <summary>
		/// The not found
		/// </summary>
		NotFound,

		/// <summary>
		/// The running
		/// </summary>
		Running,

		/// <summary>
		/// The stopped
		/// </summary>
		Stopped,

		/// <summary>
		/// The error
		/// </summary>
		Error,
	}
}
