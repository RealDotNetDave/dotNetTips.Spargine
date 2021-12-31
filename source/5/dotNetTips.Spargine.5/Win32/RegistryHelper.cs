// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5
// Author           : David McCarter
// Created          : 03-01-2021
//
// Last Modified By : David McCarter
// Last Modified On : 04-18-2021
// ***********************************************************************
// <copyright file="RegistryHelper.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Runtime.InteropServices;
using dotNetTips.Spargine.Core;
using Microsoft.Win32;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )

namespace dotNetTips.Spargine.Win32
{
	/// <summary>
	/// Class RegistryHelper.
	/// </summary>
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
		[Information(nameof(GetRegistryKey), "David McCarter", "9/10/2020", "9/10/2020", Status = Status.Available, UnitTestCoverage = 90, BenchMarkStatus = 0)]
		public static RegistryKey GetRegistryKey(string keyName, RegistryHive registryKeyType)
		{
			if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows) == false)
			{
				throw new PlatformNotSupportedException();
			}

			Validate.TryValidateParam(keyName, nameof(keyName));

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
}
