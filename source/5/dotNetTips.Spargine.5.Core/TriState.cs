// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Core
// Author           : David McCarter
// Created          : 11-11-2020
//
// Last Modified By : David McCarter
// Last Modified On : 11-04-2020
// ***********************************************************************
// <copyright file="TriState.cs" company="dotNetTips.Spargine.5.Core">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Core
{
	/// <summary>
	/// Enum TriState
	/// </summary>
	public enum Tristate
	{
		/// <summary>
		/// False
		/// </summary>
		False = 0,

		/// <summary>
		/// True
		/// </summary>
		True = -1,

		/// <summary>
		/// Use default
		/// </summary>
		UseDefault = -2,
	}
}
