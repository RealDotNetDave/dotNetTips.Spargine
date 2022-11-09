// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6
// Author           : David McCarter
// Created          : 03-15-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-21-2022
// ***********************************************************************
// <copyright file="ServiceAction.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine;

/// <summary>
/// Class ServiceAction.
/// </summary>
public sealed class ServiceAction
{
	/// <summary>
	/// Gets or sets the service action request.
	/// </summary>
	/// <value>The service action request.</value>
	public ServiceActionRequest ServiceActionRequest
	{
		get; internal set;
	}

	/// <summary>
	/// Gets or sets the service action result.
	/// </summary>
	/// <value>The service action result.</value>
	public ServiceActionResult ServiceActionResult
	{
		get; internal set;
	}

	/// <summary>
	/// Gets or sets the name of the service.
	/// </summary>
	/// <value>The name of the service.</value>
	public string ServiceName
	{
		get; internal set;
	}
}
