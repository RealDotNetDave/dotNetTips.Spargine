﻿// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5
// Author           : David McCarter
// Created          : 03-02-2021
//
// Last Modified By : David McCarter
// Last Modified On : 12-27-2021
// ***********************************************************************
// <copyright file="FileProgressState.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png; https://www.spargine.net )
namespace dotNetTips.Spargine.IO
{
	/// <summary>
	/// Enum FileProgressState
	/// </summary>
	public enum FileProgressState
	{
		/// <summary>
		/// The error
		/// </summary>
		Error = 0,

		/// <summary>
		/// The deleted
		/// </summary>
		Deleted = 1,

		/// <summary>
		/// The moved
		/// </summary>
		Moved = 2,

		/// <summary>
		/// The copied
		/// </summary>
		Copied = 3,
	}
}
