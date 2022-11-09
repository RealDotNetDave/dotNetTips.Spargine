// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Core
// Author           : David McCarter
// Created          : 06-24-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-16-2022
// ***********************************************************************
// <copyright file="CollectionInfo.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Class CollectionInfo.
/// </summary>
public class CollectionInfo
{
	/// <summary>
	/// Gets a value indicating whether this instance is empty.
	/// </summary>
	/// <value><c>true</c> if this instance is empty; otherwise, <c>false</c>.</value>
	public bool IsEmpty { get; internal set; }
}
