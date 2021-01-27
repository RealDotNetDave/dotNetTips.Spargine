// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Core
// Author           : David McCarter
// Created          : 11-11-2020
//
// Last Modified By : David McCarter
// Last Modified On : 01-20-2021
// ***********************************************************************
// <copyright file="UnhandledExceptionEventInformation.cs" company="dotNetTips.Spargine.5.Core">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Core
{

	/// <summary>
	/// Class UnhandledExceptionEventInformation.
	/// </summary>
	/// <seealso cref="IEventInformation" />
	public sealed class UnhandledExceptionEventInformation : IEventInformation
	{
		/// <summary>
		/// Gets the exception.
		/// </summary>
		/// <value>The exception.</value>
		public LoggableException Exception { get; internal set; }

		/// <summary>
		/// Gets a value indicating whether [network available].
		/// </summary>
		/// <value><c>true</c> if [network available]; otherwise, <c>false</c>.</value>
		public bool IsTerminating { get; internal set; }
	}

}
