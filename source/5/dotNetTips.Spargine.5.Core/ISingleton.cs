// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Core
// Author           : David McCarter
// Created          : 11-11-2020
//
// Last Modified By : David McCarter
// Last Modified On : 01-20-2021
// ***********************************************************************
// <copyright file="ISingleton.cs" company="dotNetTips.Spargine.5.Core">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Core
{
	/// <summary>
	/// Interface ISingleton
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface ISingleton<T>
		where T : class
	{
		/// <summary>
		/// Returns instance for the object.
		/// </summary>
		/// <returns>T.</returns>
		T Instance();
	}
}
