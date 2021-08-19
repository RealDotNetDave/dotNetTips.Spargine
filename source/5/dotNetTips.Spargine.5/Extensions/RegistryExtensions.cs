// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5
// Author           : David McCarter
// Created          : 03-01-2021
//
// Last Modified By : David McCarter
// Last Modified On : 08-18-2021
// ***********************************************************************
// <copyright file="RegistryExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using dotNetTips.Spargine.Core;
using Microsoft.Win32;

namespace dotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Class RegistryExtensions.
	/// </summary>
	public static class RegistryExtensions
	{
		/// <summary>
		/// Gets the registry key sub key.
		/// </summary>
		/// <param name="key">The key.</param>
		/// <param name="name">The name.</param>
		/// <returns>RegistryKey.</returns>
		/// <exception cref="System.PlatformNotSupportedException"></exception>
		/// <exception cref="PlatformNotSupportedException"></exception>
		[Information(nameof(GetSubKey), author: "David McCarter", createdOn: "3/1/2021", UnitTestCoverage = 100, Status = Status.Available)]
		public static RegistryKey GetSubKey([NotNull] this RegistryKey key, string name)
		{
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
		/// <exception cref="System.PlatformNotSupportedException"></exception>
		/// <exception cref="PlatformNotSupportedException"></exception>
		[Information(nameof(GetValue), author: "David McCarter", createdOn: "3/1/2021", UnitTestCoverage = 100, Status = Status.Available)]
		public static T GetValue<T>([NotNull] this RegistryKey key, string name)
		{
			Validate.TryValidateParam(name, nameof(name));

			var returnValue = default(T);

			if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
			{
				var keyValue = key.GetValue(name);

				if (keyValue is not null)
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
