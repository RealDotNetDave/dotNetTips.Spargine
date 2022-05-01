// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Core
// Author           : David McCarter
// Created          : 10-12-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-16-2022
// ***********************************************************************
// <copyright file="PasswordVerificationResult.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.Security
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
