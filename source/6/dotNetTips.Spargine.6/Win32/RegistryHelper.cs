// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6
// Author           : David McCarter
// Created          : 03-01-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-18-2023
// ***********************************************************************
// <copyright file="RegistryHelper.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using DotNetTips.Spargine.Core;
using Microsoft.Win32;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Win32;

/// <summary>
/// Class RegistryHelper.
/// </summary>
[SupportedOSPlatform("windows")]
public static class RegistryHelper
{
	/// <summary>
	/// User key for Environment.
	/// </summary>
	public const string KeyCurrentUserEnvironment = @"\Environment";

	/// <summary>
	/// User key for Microsoft.
	/// </summary>
	public const string KeyCurrentUserMicrosoft = @"SOFTWARE\Microsoft";

	/// <summary>
	/// User key for OneDrive.
	/// </summary>
	public const string KeyCurrentUserOneDrive = @"Software\Microsoft\OneDrive";

	/// <summary>
	/// Gets the registry key.
	/// </summary>
	/// <param name="keyName">The name.</param>
	/// <param name="registryKeyType">Type of the registry key.</param>
	/// <returns>RegistryKey.</returns>
	/// <exception cref="PlatformNotSupportedException"></exception>
	[Information(nameof(GetRegistryKey), "David McCarter", "9/10/2020", "9/10/2020", Status = Status.Available, UnitTestCoverage = 90, BenchMarkStatus = BenchMarkStatus.None)]
	public static RegistryKey GetRegistryKey(string keyName, [NotNull] RegistryHive registryKeyType)
	{
		if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows) is false)
		{
			throw new PlatformNotSupportedException();
		}
		
		keyName = keyName.ArgumentNotNullOrEmpty();

		return registryKeyType switch
		{
			RegistryHive.ClassesRoot => Registry.ClassesRoot.OpenSubKey(keyName),
			RegistryHive.CurrentConfig => Registry.CurrentConfig.OpenSubKey(keyName),
			RegistryHive.CurrentUser => Registry.CurrentUser.OpenSubKey(keyName),
			RegistryHive.LocalMachine => Registry.LocalMachine.OpenSubKey(keyName),
			RegistryHive.PerformanceData => Registry.PerformanceData.OpenSubKey(keyName),
			RegistryHive.Users => Registry.CurrentUser.OpenSubKey(keyName),
			_ => null,
		};
	}
}
