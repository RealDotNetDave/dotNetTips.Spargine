// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Core
// Author           : David McCarter
// Created          : 11-11-2020
//
// Last Modified By : David McCarter
// Last Modified On : 10-12-2023
// ***********************************************************************
// <copyright file="App.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>
// Application Information and Helper Methods: Process
// Management, Environment Variables, Processor Information,
// and More.
// </summary>
// ***********************************************************************
using System.Collections;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Principal;
using static DotNetTips.Spargine.Core.SourceGenerators;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Application information and helper methods.
/// </summary>
public static class App
{

	/// <summary>
	/// The temporary ASP files location.
	/// </summary>
	private const string TempAspFiles = "\\Temporary ASP.NET Files\\";

	/// <summary>
	/// The application information.
	/// </summary>
	private static readonly Lazy<AppInfo> _appInfo = new(InitAppInfo());

	/// <summary>
	/// The culture names
	/// </summary>
	private static ReadOnlyCollection<string> _cultureNames;

	/// <summary>
	/// Initializes the application information.
	/// </summary>
	/// <returns>AppInfo.</returns>
	private static AppInfo InitAppInfo()
	{
		var assembly = Assembly.GetEntryAssembly();

		return new AppInfo
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
	}

	/// <summary>
	/// Kills the process.
	/// </summary>
	/// <param name="processName">Name of the process.</param>
	/// <exception cref="ArgumentNullException">Process name is nothing or empty.</exception>
	private static void KillProcess(string processName)
	{
		processName = processName.ArgumentNotNullOrEmpty();

		var app = Process.GetProcessesByName(processName).FirstOrDefault();

		if (app is not null)
		{
			app.Kill();

			_ = app.WaitForExit(milliseconds: 6000);
		}
	}

	/// <summary>
	/// Changes the culture.
	/// </summary>
	/// <param name="cultureName">Name of the culture.</param>
	[Information(UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static void ChangeCulture(string cultureName) => CultureInfo.CurrentCulture = new CultureInfo(cultureName.ArgumentNotNullOrEmpty());

	/// <summary>
	/// Changes the current culture and UI culture.
	/// </summary>
	/// <param name="culture">The culture.</param>
	[Information(UnitTestCoverage = 0, Status = Status.New, Documentation = "ADD URL")]
	public static void ChangeCulture(CultureInfo culture)
	{
		CultureInfo.CurrentCulture = culture.ArgumentNotNull();
		CultureInfo.CurrentUICulture = culture;
	}

	/// <summary>
	/// Changes the UI culture.
	/// </summary>
	/// <param name="cultureName">Name of the culture.</param>
	[Information(UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static void ChangeUICulture(string cultureName) => CultureInfo.CurrentUICulture = new CultureInfo(cultureName.ArgumentNotNullOrEmpty());

	/// <summary>
	/// Returns the folder path for the entry assembly.
	/// </summary>
	/// <returns>System.String.</returns>
	[Information(nameof(ExecutingFolder), author: "David McCarter", createdOn: "6/26/2017", UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static string ExecutingFolder() => Path.GetDirectoryName(Environment.ProcessPath);

	/// <summary>
	/// Gets the culture names.
	/// </summary>
	/// <param name="cultureType">Type of the culture. Defaults to AllCultures.</param>
	/// <returns>ReadOnlyCollection&lt;System.String&gt;.</returns>
	[Information(nameof(AppInfo), UnitTestCoverage = 100, Status = Status.Available, Documentation = "ADD URL")]
	public static ReadOnlyCollection<string> GetCultureNames(CultureTypes cultureType = CultureTypes.AllCultures)
	{
		if (_cultureNames is null)
		{
			var cultures = CultureInfo.GetCultures(cultureType).OrderBy(p => p.Name).Select(c => c.Name);

			_cultureNames = new ReadOnlyCollection<string>(cultures.ToArray());
		}

		return _cultureNames;
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
	/// Gets the current processor information.
	/// </summary>
	/// <returns>ProcessorInformation.</returns>
	/// <example>
	/// Example output:<br />
	/// ActiveProcessorMask: 0x0000000000000fff
	/// AllocationGranularity: 65536
	/// MaximumApplicationAddress: 0x00007ffffffeffff
	/// MinimumApplicationAddress: 0x0000000000010000
	/// NumberOfProcessors: 12
	/// PageSize: 4096
	/// ProcessorArchitecture: X86
	/// ProcessorLevel: 6
	/// ProcessorRevision: 42243
	/// </example>
	[Information(nameof(GetProcessorInformation), "David McCarter", "3/20/2023", Status = Status.Available, UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Documentation = "ADD URL")]
	public static ProcessorInformation GetProcessorInformation()
	{
		var info = new SystemInfo();
		//#if NET7_0_OR_GREATER
		//		SourceGenerators.GetSystemInfoLibraryImport(ref info);
		//#else
		GetSystemInfoDllImport(ref info);
		//#endif
		//Convert data
		return new ProcessorInformation()
		{
			PageSize = (int)info._dwPageSize,
			MinimumApplicationAddress = info._lpMinimumApplicationAddress,
			MaximumApplicationAddress = info._lpMaximumApplicationAddress,
			ActiveProcessorMask = info._dwActiveProcessorMask,
			NumberOfProcessors = (int)info._dwNumberOfProcessors,
			ProcessorArchitecture = ConvertProcessorArchitecture((int)info._dwProcessorType),
			AllocationGranularity = (int)info._dwAllocationGranularity,
			ProcessorLevel = info._wProcessorLevel,
			ProcessorRevision = info._wProcessorRevision
		};
	}

	/// <summary>
	/// Check to see if the current app is already running.
	/// </summary>
	/// <returns><c>true</c> if app is not running, <c>false</c> otherwise.</returns>
	[Information(UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static bool IsRunning() => Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).FastCount() > 0;

	/// <summary>
	/// Checks to see if the current application is ASP.NET.
	/// </summary>
	/// <returns>True if running ASP.NET.</returns>
	[Information(UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static bool IsRunningFromAspNet() => (!string.IsNullOrEmpty(AppDomain.CurrentDomain.DynamicDirectory)) && AppDomain.CurrentDomain.DynamicDirectory.Contains(TempAspFiles, StringComparison.OrdinalIgnoreCase);

	/// <summary>
	/// Determines whether user is administrator.
	/// </summary>
	/// <returns><c>true</c> if [is user administrator]; otherwise, <c>false</c>.</returns>
	/// <exception cref="System.PlatformNotSupportedException"></exception>
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
	public static void Kill() => KillProcess(Path.GetFileNameWithoutExtension(AppContext.BaseDirectory));

	/// <summary>
	/// Calculates the maximum degree of parallelism.
	/// </summary>
	/// <returns>System.Int32.</returns>
	public static int MaxDegreeOfParallelism() => Convert.ToInt32(Math.Ceiling(Environment.ProcessorCount * 0.75 * 2.0));

	/// <summary>
	/// Loads a list of the running assembly referenced assemblies.
	/// </summary>
	/// <returns>IEnumerable(Of System.String).</returns>
	/// <example>Output example:
	/// [0]: "System.Runtime, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
	/// [1]: "System.Resources.ResourceManager, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
	/// [2]: "System.Runtime.InteropServices, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
	/// [3]: "Microsoft.TestPlatform.PlatformAbstractions, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
	/// [4]: "Microsoft.TestPlatform.CommunicationUtilities, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
	/// [5]: "Microsoft.TestPlatform.CoreUtilities, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
	/// [6]: "Microsoft.VisualStudio.TestPlatform.Common, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
	/// [7]: "Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
	/// [8]: "System.Diagnostics.TraceSource, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
	/// [9]: "System.Diagnostics.StackTrace, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
	/// [10]: "System.Runtime.Extensions, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
	/// [11]: "System.Diagnostics.Debug, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
	/// [12]: "Microsoft.TestPlatform.CrossPlatEngine, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
	/// [13]: "System.Net.Primitives, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
	/// [14]: "System.Runtime.InteropServices.RuntimeInformation, Version=4.0.3.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
	/// [15]: "System.Linq, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
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

		using var process = Process.Start(new ProcessStartInfo(AppContext.BaseDirectory)
		{
			UseShellExecute = true,
			Verb = "runas",
		});

		Process.GetCurrentProcess().Kill();
	}

	/// <summary>
	/// Gets the assembly information.
	/// </summary>
	/// <value>The assembly information.</value>
	/// <example>Example Output:
	/// Company: "Microsoft Corporation"
	/// Copyright: "© Microsoft Corporation. All rights reserved."
	/// EqualityContract: FullName = "dotNetTips.Spargine.Core.AppInfo", DomainInitialized = Method System.RuntimeType.get_DomainInitialized cannot be called in this context.
	/// FileVersion: "15.0.0"
	/// MemoryAllocated: 1720944
	/// MemoryInfo: { System.GCMemoryInfo}
	/// Product: "dotNetTips.Spargine"
	/// ThreadAllocatedBytes: 745384
	/// Title: "Spargine"
	/// TotalAllocatedBytes: 3169744
	/// Version: "16.9.1"
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

}
