// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Core
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 08-02-2023
// ***********************************************************************
// <copyright file="ComputerInfo.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Type used to return computer information.</summary>
// ***********************************************************************
using System.Globalization;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Computer Information.
/// </summary>
[Information(nameof(ComputerInfo), "David McCarter", "10/15/2018 ", Status = Status.Available)]
[DataContract(Namespace = "dotNetTips.com/Info")]
public sealed class ComputerInfo
{
	/// <summary>
	/// Gets the computer culture.
	/// </summary>
	/// <value>The computer culture.</value>
	[DataMember]
	[Information(UnitTestCoverage = 100, Status = Status.Available)]
	public string ComputerCulture { get; private set; } = CultureInfo.CurrentCulture.ThreeLetterISOLanguageName;

	/// <summary>
	/// Gets the computer UI culture.
	/// </summary>
	/// <value>The computer UI culture.</value>
	[DataMember]
	[Information(UnitTestCoverage = 100, Status = Status.Available)]
	public string ComputerUICulture { get; private set; } = CultureInfo.CurrentUICulture.ThreeLetterISOLanguageName;

	/// <summary>
	/// Gets the current managed tread identifier.
	/// </summary>
	/// <value>The current managed tread identifier.</value>
	[DataMember]
	[Information(UnitTestCoverage = 100, Status = Status.Available)]
	public int CurrentManagedTreadId { get; private set; } = Environment.CurrentManagedThreadId;

	/// <summary>
	/// Gets the current stack trace information.
	/// </summary>
	/// <value>The current stack trace.</value>
	[DataMember]
	[Information(UnitTestCoverage = 100, Status = Status.Available)]
	public string CurrentStackTrace { get; private set; } = Environment.StackTrace;

	/// <summary>
	/// Gets the current system tick count.
	/// </summary>
	/// <value>The current system tick count.</value>
	[DataMember]
	[Information(UnitTestCoverage = 100, Status = Status.Available)]
	public int CurrentSystemTickCount { get; private set; } = Environment.TickCount;

	/// <summary>
	/// Gets the current working directory.
	/// </summary>
	/// <value>The current directory.</value>
	[DataMember]
	[Information(UnitTestCoverage = 100, Status = Status.Available)]
	public string CurrentWorkingDirectory { get; private set; } = Environment.CurrentDirectory;

	/// <summary>
	/// Gets the framework description.
	/// </summary>
	/// <value>The framework description.</value>
	[DataMember]
	[Information(UnitTestCoverage = 100, Status = Status.Available)]
	public string FrameworkDescription { get; private set; } = RuntimeInformation.FrameworkDescription;

	/// <summary>
	/// Gets the framework version.
	/// </summary>
	/// <value>The framework version.</value>
	[DataMember]
	[Information(UnitTestCoverage = 100, Status = Status.Available)]
	public Version FrameworkVersion { get; private set; } = Environment.Version;

	/// <summary>
	/// Gets a value indicating whether this instance has shutdown started.
	/// </summary>
	/// <value><c>true</c> if this instance has shutdown started; otherwise, <c>false</c>.</value>
	[DataMember]
	[Information(UnitTestCoverage = 100, Status = Status.Available)]
	public bool HasShutdownStarted { get; private set; } = Environment.HasShutdownStarted;

	/// <summary>
	/// Gets the ip addresses.
	/// </summary>
	/// <value>The ip address.</value>
	[DataMember]
	[Information(UnitTestCoverage = 100, Status = Status.Available)]
	public string IPAddress { get; private set; } = Dns.GetHostAddresses(Dns.GetHostName()).Where(p => p.AddressFamily == AddressFamily.InterNetwork).ToDelimitedString(char.Parse(","));

	/// <summary>
	/// Gets a value indicating whether [is64 bit operating system].
	/// </summary>
	/// <value><c>true</c> if [is64 bit operating system]; otherwise, <c>false</c>.</value>
	[DataMember]
	[Information(UnitTestCoverage = 100, Status = Status.Available)]
	public bool Is64BitOperatingSystem { get; private set; } = Environment.Is64BitOperatingSystem;

	/// <summary>
	/// Gets a value indicating whether [is64 bit process].
	/// </summary>
	/// <value><c>true</c> if [is64 bit process]; otherwise, <c>false</c>.</value>
	[DataMember]
	[Information(UnitTestCoverage = 100, Status = Status.Available)]
	public bool Is64BitProcess { get; private set; } = Environment.Is64BitProcess;

	/// <summary>
	/// Gets a value indicating whether the user is interactive.
	/// </summary>
	/// <value><c>true</c> if this instance is user interactive; otherwise, <c>false</c>.</value>
	[DataMember]
	[Information(UnitTestCoverage = 100, Status = Status.Available)]
	public bool IsUserInteractive { get; private set; } = Environment.UserInteractive;

	/// <summary>
	/// Gets the logical drives.
	/// </summary>
	/// <value>The logical drives.</value>
	[DataMember]
	[Information(UnitTestCoverage = 100, Status = Status.Available)]
	public IEnumerable<string> LogicalDrives { get; private set; } = Environment.GetLogicalDrives().AsEnumerable();

	/// <summary>
	/// Gets the name of the machine.
	/// </summary>
	/// <value>The name of the machine.</value>
	[DataMember]
	[Information(UnitTestCoverage = 100, Status = Status.Available)]
	public string MachineName { get; private set; } = Environment.MachineName;

	/// <summary>
	/// Gets the os architecture.
	/// </summary>
	/// <value>The os architecture.</value>
	[DataMember]
	[Information(UnitTestCoverage = 100, Status = Status.Available)]
	public Architecture OSArchitecture { get; private set; } = RuntimeInformation.OSArchitecture;

	/// <summary>
	/// Gets the os version.
	/// </summary>
	/// <value>The os version.</value>
	[DataMember]
	[Information(UnitTestCoverage = 100, Status = Status.Available)]
	public string OSDescription { get; private set; } = RuntimeInformation.OSDescription;

	/// <summary>
	/// Gets the size of the os memory page.
	/// </summary>
	/// <value>The size of the os memory page.</value>
	[DataMember]
	[Information(UnitTestCoverage = 100, Status = Status.Available)]
	public int OsMemoryPageSize { get; private set; } = Environment.SystemPageSize;

	/// <summary>
	/// Gets the physical memory in use.
	/// </summary>
	/// <value>The physical memory in use.</value>
	[DataMember]
	[Information(UnitTestCoverage = 100, Status = Status.Available)]
	public long PhysicalMemoryInUse { get; private set; } = Environment.WorkingSet;

	/// <summary>
	/// Gets the process architecture.
	/// </summary>
	/// <value>The process architecture.</value>
	[DataMember]
	[Information(UnitTestCoverage = 100, Status = Status.Available)]
	public Architecture ProcessArchitecture { get; private set; } = RuntimeInformation.ProcessArchitecture;

	/// <summary>
	/// Gets the processor count.
	/// </summary>
	/// <value>The processor count.</value>
	[DataMember]
	[Information(UnitTestCoverage = 100, Status = Status.Available)]
	public int ProcessorCount { get; private set; } = Environment.ProcessorCount;

	/// <summary>
	/// Gets the system directory.
	/// </summary>
	/// <value>The system directory.</value>
	[DataMember]
	[Information(UnitTestCoverage = 100, Status = Status.Available)]
	public string SystemDirectory { get; private set; } = Environment.SystemDirectory;

	/// <summary>
	/// Gets the size of the system page.
	/// </summary>
	/// <value>The size of the system page.</value>
	[DataMember]
	[Information(UnitTestCoverage = 100, Status = Status.Available)]
	public int SystemPageSize { get; private set; } = Environment.SystemPageSize;

	/// <summary>
	/// Gets the tick count.
	/// </summary>
	/// <value>The tick count.</value>
	[DataMember]
	[Information(UnitTestCoverage = 100, Status = Status.Available)]
	public int TickCount { get; private set; } = Environment.TickCount;

	/// <summary>
	/// Gets the tick count as long.
	/// </summary>
	/// <value>The tick count as long.</value>
	[DataMember]
	[Information(UnitTestCoverage = 100, Status = Status.Available)]
	public long TickCount64 { get; private set; } = Environment.TickCount64;

	/// <summary>
	/// Gets the name of the user domain.
	/// </summary>
	/// <value>The name of the user domain.</value>
	[DataMember]
	[Information(UnitTestCoverage = 100, Status = Status.Available)]
	public string UserDomainName { get; private set; } = Environment.UserDomainName;

	/// <summary>
	/// Gets the name of the user.
	/// </summary>
	/// <value>The name of the user.</value>
	[DataMember]
	[Information(UnitTestCoverage = 100, Status = Status.Available)]
	public string UserName { get; private set; } = Environment.UserName;
}
