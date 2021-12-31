// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Core
// Author           : David McCarter
// Created          : 10-12-2021
//
// Last Modified By : David McCarter
// Last Modified On : 11-27-2021
// ***********************************************************************
// <copyright file="PasswordVerificationResult.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Core.Security
{
	/// <summary>
	/// Enum PasswordVerificationResult
	/// </summary>
	public enum PasswordVerificationResult
	{
		/// <summary>
		/// Verification failed.
		/// </summary>
		Failed,

		/// <summary>
		/// Verification succeeded.
		/// </summary>
		Success,

		/// <summary>
		/// Verification succeeded and rehash needed
		/// </summary>
		SuccessRehashNeeded,
	}
}
