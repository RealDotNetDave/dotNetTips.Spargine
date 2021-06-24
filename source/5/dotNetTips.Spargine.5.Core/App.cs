﻿// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Core
// Author           : David McCarter
// Created          : 11-11-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-02-2021
// ***********************************************************************
// <copyright file="App.cs" company="dotNetTips.Spargine.5.Core">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Application information and helper methods.</summary>
// ***********************************************************************
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Principal;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Core
{
	/// <summary>
	/// Application information and helper methods.
	/// </summary>
	public static class App
	{
		/// <summary>
		/// The temporary ASP files location.
		/// </summary>
		private const string _tempAspFiles = "\\Temporary ASP.NET Files\\";

		/// <summary>
		/// The application information.
		/// </summary>
		private static readonly Lazy<AppInfo> _appInfo = new(() => InitAppInfo());

		/// <summary>
		/// Gets the assembly information.
		/// </summary>
		/// <value>The assembly information.</value>
		/// <example>Example Output:
		///   Company: "Microsoft Corporation"
		///   Copyright: "© Microsoft Corporation. All rights reserved."
		///   EqualityContract: FullName = "dotNetTips.Spargine.Core.AppInfo", DomainInitialized = Method System.RuntimeType.get_DomainInitialized cannot be called in this context.
		///   FileVersion: "15.0.0"
		///   MemoryAllocated: 1720944
		///   MemoryInfo: { System.GCMemoryInfo}
		///   Product: "dotNetTips.Spargine"
		///   ThreadAllocatedBytes: 745384
		///   Title: "Spargine"
		///   TotalAllocatedBytes: 3169744
		///   Version: "16.9.1"
		/// </example>
		[Information(nameof(AppInfo), UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static AppInfo AppInfo => _appInfo.Value;

		/// <summary>
		/// Gets the culture.
		/// </summary>
		/// <value>The culture.</value>
		[Information(UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static CultureInfo CurrentCulture => CultureInfo.CurrentCulture;

		/// <summary>
		/// Gets the UI culture.
		/// </summary>
		/// <value>The UI culture.</value>
		[Information(UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static CultureInfo CurrentUICulture => CultureInfo.CurrentUICulture;

		/// <summary>
		/// Gets a string that indicates the name of the .NET installation on which an app is running.
		/// </summary>
		/// <value>The framework description.</value>
		/// <example>Example output: ".NET 5.0.6"</example>
		[Information(UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static string FrameworkDescription => RuntimeInformation.FrameworkDescription;

		/// <summary>
		/// Gets the installed UI culture.
		/// </summary>
		/// <value>The installed UI culture.</value>
		[Information(UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static CultureInfo InstalledUICulture => CultureInfo.InstalledUICulture;

		/// <summary>
		/// Gets the platform architecture on which the current app is running.
		/// </summary>
		/// <value>The operating system platform.</value>
		[Information(UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static Architecture OSArchitecture => RuntimeInformation.OSArchitecture;

		/// <summary>
		/// Gets a string that describes the operating system on which the app is running.
		/// </summary>
		/// <value>The operating system description.</value>
		[Information(UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static string OSDescription => RuntimeInformation.OSDescription;

		/// <summary>
		/// Gets the process architecture of the currently running app.
		/// </summary>
		/// <value>The process architecture.</value>
		[Information(UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static Architecture ProcessArchitecture => RuntimeInformation.ProcessArchitecture;

		/// <summary>
		/// Gets the stack trace.
		/// </summary>
		/// <value>The stack trace.</value>
		[Information(UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static string StackTrace => Environment.StackTrace;

		/// <summary>
		/// Gets the working set.
		/// </summary>
		/// <value>The working set.</value>
		[Information(UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static long WorkingSet => Environment.WorkingSet;

		/// <summary>
		/// Changes the culture.
		/// </summary>
		/// <param name="cultureName">Name of the culture.</param>
		[Information(UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static void ChangeCulture(string cultureName)
		{
			Validate.TryValidateParam(cultureName, nameof(cultureName));

			CultureInfo.CurrentCulture = new CultureInfo(cultureName);
		}

		/// <summary>
		/// Changes the UI culture.
		/// </summary>
		/// <param name="cultureName">Name of the culture.</param>
		[Information(UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static void ChangeUICulture(string cultureName)
		{
			Validate.TryValidateParam(cultureName, nameof(cultureName));

			CultureInfo.CurrentUICulture = new CultureInfo(cultureName);
		}

		/// <summary>
		/// Returns the folder path for the entry assembly.
		/// </summary>
		/// <returns>System.String.</returns>
		[Information(nameof(ExecutingFolder), author: "David McCarter", createdOn: "6/26/2017", modifiedOn: "7/31/2020", UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static string ExecutingFolder()
		{
			return new FileInfo(AppContext.BaseDirectory).Directory.ToString();
		}

		/// <summary>
		/// Gets the environment variables.
		/// </summary>
		/// <returns>IImmutableDictionary&lt;System.String, System.String&gt;.</returns>
		[Information(UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static IImmutableDictionary<string, string> GetEnvironmentVariables()
		{
			var variables = Environment.GetEnvironmentVariables();

			var builder = ImmutableDictionary.CreateBuilder<string, string>();

			foreach (DictionaryEntry variable in variables)
			{
				builder.Add(variable.Key.ToString(), variable.Value.ToString());
			}

			return builder.ToImmutable();
		}

		/// <summary>
		/// Check to see if the current app is already running.
		/// </summary>
		/// <returns><c>true</c> if app is not running, <c>false</c> otherwise.</returns>
		[Information(UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static bool IsRunning()
		{
			return Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Count() > 0;
		}

		/// <summary>
		/// Checks to see if the current application is ASP.NET.
		/// </summary>
		/// <returns>True if running ASP.NET.</returns>
		[Information(UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static bool IsRunningFromAspNet()
		{
			return ( !string.IsNullOrEmpty(AppDomain.CurrentDomain.DynamicDirectory) ) && AppDomain.CurrentDomain.DynamicDirectory.Contains(_tempAspFiles);
		}

		/// <summary>
		/// Determines whether user is administrator.
		/// </summary>
		/// <returns><c>true</c> if [is user administrator]; otherwise, <c>false</c>.</returns>
		/// <exception cref="System.PlatformNotSupportedException"></exception>
		/// <exception cref="PlatformNotSupportedException"></exception>
		[Information(UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static bool IsUserAdministrator()
		{
			if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
			{
				throw new PlatformNotSupportedException();
			}
			else
			{
				using var wi = WindowsIdentity.GetCurrent();

				return new WindowsPrincipal(wi).IsInRole(WindowsBuiltInRole.Administrator);
			}
		}

		/// <summary>
		/// Kills the current process.
		/// </summary>
		[Information(UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static void Kill()
		{
			KillProcess(Path.GetFileNameWithoutExtension(AppContext.BaseDirectory));
		}

		/// <summary>
		/// Loads a list of the running assembly referenced assemblies.
		/// </summary>
		/// <returns>IEnumerable(Of System.String).</returns>
		/// <example>Output example:
		///  [0]: "System.Runtime, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
		///  [1]: "System.Resources.ResourceManager, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
		///  [2]: "System.Runtime.InteropServices, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
		///  [3]: "Microsoft.TestPlatform.PlatformAbstractions, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
		///  [4]: "Microsoft.TestPlatform.CommunicationUtilities, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
		///  [5]: "Microsoft.TestPlatform.CoreUtilities, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
		///  [6]: "Microsoft.VisualStudio.TestPlatform.Common, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
		///  [7]: "Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
		///  [8]: "System.Diagnostics.TraceSource, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
		///  [9]: "System.Diagnostics.StackTrace, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
		///  [10]: "System.Runtime.Extensions, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
		///  [11]: "System.Diagnostics.Debug, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
		///  [12]: "Microsoft.TestPlatform.CrossPlatEngine, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
		///  [13]: "System.Net.Primitives, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
		///  [14]: "System.Runtime.InteropServices.RuntimeInformation, Version=4.0.3.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
		///  [15]: "System.Linq, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
		/// </example>
		[Information(UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static ImmutableList<string> ReferencedAssemblies()
		{
			var referencedAssemblies = new List<string>();

			for (var assemblyCount = 0; assemblyCount < Assembly.GetEntryAssembly().GetReferencedAssemblies().Length; assemblyCount++)
			{
				referencedAssemblies.Add(Assembly.GetEntryAssembly().GetReferencedAssemblies()[assemblyCount].ToString());
			}

			return referencedAssemblies.ToImmutableList();
		}

		/// <summary>
		/// Restarts an app as administrator.
		/// </summary>
		[Information(UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static void RunAsAdministrator()
		{
			if (IsUserAdministrator())
			{
				return;
			}

			var processInfo = new ProcessStartInfo(Assembly.GetEntryAssembly().CodeBase)
			{
				UseShellExecute = true,
				Verb = "runas",
			};

			_ = Process.Start(processInfo);

			Process.GetCurrentProcess().Kill();
		}

		/// <summary>
		/// Initializes the application information.
		/// </summary>
		/// <returns>AppInfo.</returns>
		private static AppInfo InitAppInfo()
		{
			var assembly = Assembly.GetEntryAssembly();

			var appInfo = new AppInfo
			{
				Company = assembly.GetCustomAttributes<AssemblyCompanyAttribute>().FirstOrDefault()?.Company,
				Configuration = assembly.GetCustomAttributes<AssemblyConfigurationAttribute>().FirstOrDefault()?.Configuration,
				Copyright = assembly.GetCustomAttributes<AssemblyCopyrightAttribute>().FirstOrDefault()?.Copyright,
				Description = assembly.GetCustomAttributes<AssemblyDescriptionAttribute>().FirstOrDefault()?.Description,
				FileVersion = assembly.GetCustomAttributes<AssemblyFileVersionAttribute>().FirstOrDefault()?.Version,
				MemoryAllocated = GC.GetTotalMemory(forceFullCollection: false),
				MemoryInfo = GC.GetGCMemoryInfo(),
				Product = assembly.GetCustomAttributes<AssemblyProductAttribute>().FirstOrDefault()?.Product,
				ThreadAllocatedBytes = GC.GetAllocatedBytesForCurrentThread(),
				Title = assembly.GetCustomAttributes<AssemblyTitleAttribute>().FirstOrDefault()?.Title,
				TotalAllocatedBytes = GC.GetTotalAllocatedBytes(precise: false),
				Version = assembly.GetCustomAttributes<AssemblyInformationalVersionAttribute>().FirstOrDefault()?.InformationalVersion,
			};

			return appInfo;
		}

		/// <summary>
		/// Kills the process.
		/// </summary>
		/// <param name="processName">Name of the process.</param>
		/// <exception cref="ArgumentNullException">Process name is nothing or empty.</exception>
		private static void KillProcess(string processName)
		{
			Validate.TryValidateParam(processName, nameof(processName));

			var app = Process.GetProcessesByName(processName).FirstOrDefault();

			if (app is not null)
			{
				app.Kill();
				_ = app.WaitForExit(milliseconds: 6000);
			}
		}
	}
}
