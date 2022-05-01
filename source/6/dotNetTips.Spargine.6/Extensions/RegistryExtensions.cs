// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6
// Author           : David McCarter
// Created          : 03-01-2021
//
// Last Modified By : David McCarter
// Last Modified On : 04-12-2022
// ***********************************************************************
// <copyright file="RegistryExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using DotNetTips.Spargine.Core;
using Microsoft.Win32;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions
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
		/// <exception cref="PlatformNotSupportedException"></exception>
		[Information(nameof(GetSubKey), author: "David McCarter", createdOn: "3/1/2021", UnitTestCoverage = 100, Status = Status.Available)]
		public static RegistryKey GetSubKey([NotNull] this RegistryKey key, [NotNull] string name)
		{
			return RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? key.OpenSubKey(name) : throw new PlatformNotSupportedException();
		}

		/// <summary>
		/// Gets the registry key value.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="key">The key.</param>
		/// <param name="name">The name.</param>
		/// <returns>T.</returns>
		/// <exception cref="PlatformNotSupportedException"></exception>
		[Information(nameof(GetValue), author: "David McCarter", createdOn: "3/1/2021", UnitTestCoverage = 100, Status = Status.Available)]
		public static T GetValue<T>([NotNull] this RegistryKey key, string name)
		{
			name = name.ArgumentNotNullOrEmpty();

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
