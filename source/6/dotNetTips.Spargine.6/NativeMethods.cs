// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6
// Author           : David McCarter
// Created          : 04-02-2021
//
// Last Modified By : David McCarter
// Last Modified On : 04-18-2023
// ***********************************************************************
// <copyright file="NativeMethods.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Runtime.InteropServices;
using DotNetTips.Spargine.Core;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine;

/// <summary>
/// Class NativeMethods. This class cannot be inherited.
/// </summary>
internal static class NativeMethods
{

	/// <summary>
	/// Moves the file ex.
	/// </summary>
	/// <param name="lpExistingFileName">Name of the lp existing file.</param>
	/// <param name="lpNewFileName">Name of the lp new file.</param>
	/// <param name="dwFlags">The dw flags.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	[return: MarshalAs(UnmanagedType.Bool)]
	[DllImport(ApiLibraries.Kernel32, CharSet = CharSet.Unicode, SetLastError = true)]
	[DefaultDllImportSearchPaths(DllImportSearchPath.UserDirectories)]
	internal static extern bool MoveFileEx(string lpExistingFileName, string lpNewFileName, int dwFlags);

}
