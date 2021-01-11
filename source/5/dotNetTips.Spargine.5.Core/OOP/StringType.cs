// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core
// Author           : David McCarter
// Created          : 05-26-2020
//
// Last Modified By : David McCarter
// Last Modified On : 05-26-2020
// ***********************************************************************
// <copyright file="StringType.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
//![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Core.OOP
{
	/// <summary>
	/// Enum for StringType
	/// </summary>

	public enum StringType
	{
		/// <summary>
		/// The not set
		/// </summary>
		NotSet,

		/// <summary>
		/// Validates that string is a email address.
		/// </summary>
		Email,

		/// <summary>
		/// Validates that the string is a Url.
		/// </summary>
		Url
	}
}
