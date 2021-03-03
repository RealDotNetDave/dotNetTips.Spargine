using System;
using System.Runtime.InteropServices;
using dotNetTips.Spargine.Core;
using Microsoft.Win32;

namespace dotNetTips.Spargine.Win32
{
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
		/// <param name="name">The name.</param>
		/// <returns>RegistryKey.</returns>
		/// <exception cref="PlatformNotSupportedException"></exception>
		public static RegistryKey GetCurrentUserRegistryKey(string name)
		{
			// TODO: Causes bug. Add back when fixed [Obsolete("This method will be removed at the end of 2020. Use GetRegistryKey instead.", false)]

			Validate.TryValidateParam(name, nameof(name));

			return RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
				? Registry.CurrentUser.OpenSubKey(name)
				: throw new PlatformNotSupportedException();
		}

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

			switch (registryKeyType)
			{
				case RegistryHive.ClassesRoot:
					return Registry.ClassesRoot.OpenSubKey(keyName);
				case RegistryHive.CurrentConfig:
					return Registry.CurrentConfig.OpenSubKey(keyName);
				case RegistryHive.CurrentUser:
					return Registry.CurrentUser.OpenSubKey(keyName);
				case RegistryHive.LocalMachine:
					return Registry.LocalMachine.OpenSubKey(keyName);
				case RegistryHive.PerformanceData:
					return Registry.PerformanceData.OpenSubKey(keyName);
				case RegistryHive.Users:
					return Registry.CurrentUser.OpenSubKey(keyName);
			}

			return null;
		}
	}
}
