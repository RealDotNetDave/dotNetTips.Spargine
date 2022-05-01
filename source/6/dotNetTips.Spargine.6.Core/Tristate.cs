// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Core
// Author           : David McCarter
// Created          : 11-11-2020
//
// Last Modified By : David McCarter
// Last Modified On : 01-16-2022
// ***********************************************************************
// <copyright file="Tristate.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core
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
