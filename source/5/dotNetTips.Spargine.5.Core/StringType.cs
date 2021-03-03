// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core
// Author           : David McCarter
// Created          : 05-26-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-02-2021
// ***********************************************************************
// <copyright file="StringType.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>String type for validating parameters/ values.</summary>
// ***********************************************************************

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Core
{
	/// <summary>
	/// Enum for StringType
	/// </summary>
	public enum StringType
	{
		/// <summary>
		/// String type not set.
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
