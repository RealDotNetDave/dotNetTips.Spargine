// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Core
// Author           : David McCarter
// Created          : 11-11-2020
//
// Last Modified By : David McCarter
// Last Modified On : 01-16-2022
// ***********************************************************************
// <copyright file="UnhandledExceptionEventInformation.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core;

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
