// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core
// Author           : David McCarter
// Created          : 05-26-2020
//
// Last Modified By : David McCarter
// Last Modified On : 11-27-2021
// ***********************************************************************
// <copyright file="StringType.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>String type for validating parameters/ values.</summary>
// ***********************************************************************

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core
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
