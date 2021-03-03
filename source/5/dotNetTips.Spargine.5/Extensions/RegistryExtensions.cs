using System;
using System.Runtime.InteropServices;
using dotNetTips.Spargine.Core;
using Microsoft.Win32;

namespace dotNetTips.Spargine.Extensions
{
	public static class RegistryExtensions
	{
		/// <summary>
		/// Gets the registry key sub key.
		/// </summary>
		/// <param name="key">The key.</param>
		/// <param name="name">The name.</param>
		/// <returns>RegistryKey.</returns>
		/// <exception cref="PlatformNotSupportedException">The exception.</exception>
		[Information(nameof(GetSubKey), author: "David McCarter", createdOn: "3/1/2021", UnitTestCoverage = 0, Status = Status.New)]
		public static RegistryKey GetSubKey(this RegistryKey key, string name)
		{
			Validate.TryValidateNullParam(key, nameof(key));
			Validate.TryValidateParam(name, nameof(name));

			if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
			{
				return key.OpenSubKey(name);
			}
			else
			{
				throw new PlatformNotSupportedException();
			}
		}

		/// <summary>
		/// Gets the registry key value.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="key">The key.</param>
		/// <param name="name">The name.</param>
		/// <returns>T.</returns>
		/// <exception cref="PlatformNotSupportedException">The exception.</exception>
		[Information(nameof(GetValue), author: "David McCarter", createdOn: "3/1/2021", UnitTestCoverage = 0, Status = Status.New)]
		public static T GetValue<T>(this RegistryKey key, string name)
		{
			Validate.TryValidateNullParam(key, nameof(key));
			Validate.TryValidateParam(name, nameof(name));

			var returnValue = default(T);

			if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
			{
				var keyValue = key.GetValue(name);

				if (keyValue != null)
				{
					returnValue = (T)keyValue;
				}

				return returnValue;
			}
			else
			{
				throw new PlatformNotSupportedException();
			}
		}
	}
}
