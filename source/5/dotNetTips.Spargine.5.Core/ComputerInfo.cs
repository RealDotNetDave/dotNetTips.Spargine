// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 10-15-2018
//
// Last Modified By : David McCarter
// Last Modified On : 12-28-2020
// ***********************************************************************
// <copyright file="ComputerInfo.cs" company="dotNetTips.com - McCarter Consulting">
//     dotNetTips.com - McCarter Consulting. All rights reserved.
// </copyright>
// <summary>Common computer information.</summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

//![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Core
{
	/// <summary>
	/// Computer Information.
	/// </summary>
	[Information(nameof(ComputerInfo), "David McCarter", "10/15/2018 ", Status = Status.Available)]
	[DataContract(Namespace = "dotNetTips.com/Info")]
	public class ComputerInfo
	{

		/// <summary>
		/// Gets the computer culture.
		/// </summary>
		/// <value>The computer culture.</value>
		[DataMember]
		[Information(UnitTestCoverage = 100, Status = Status.Available)]
		public string ComputerCulture { get; internal set; } = CultureInfo.CurrentCulture.ThreeLetterISOLanguageName;

		/// <summary>
		/// Gets the computer UI culture.
		/// </summary>
		/// <value>The computer UI culture.</value>
		[DataMember]
		[Information(UnitTestCoverage = 100, Status = Status.Available)]
		public string ComputerUICulture { get; internal set; } = CultureInfo.CurrentUICulture.ThreeLetterISOLanguageName;

		/// <summary>
		/// Gets the current managed tread identifier.
		/// </summary>
		/// <value>The current managed tread identifier.</value>
		[DataMember]
		[Information(UnitTestCoverage = 100, Status = Status.Available)]
		public int CurrentManagedTreadId { get; internal set; } = Environment.CurrentManagedThreadId;

		/// <summary>
		/// Gets the current stack trace information.
		/// </summary>
		/// <value>The current stack trace.</value>
		[DataMember]
		[Information(UnitTestCoverage = 100, Status = Status.Available)]
		public string CurrentStackTrace { get; internal set; } = Environment.StackTrace;

		/// <summary>
		/// Gets the current system tick count.
		/// </summary>
		/// <value>The current system tick count.</value>
		[DataMember]
		[Information(UnitTestCoverage = 100, Status = Status.Available)]
		public int CurrentSystemTickCount { get; internal set; } = Environment.TickCount;

		/// <summary>
		/// Gets the current working directory.
		/// </summary>
		/// <value>The current directory.</value>
		[DataMember]
		[Information(UnitTestCoverage = 100, Status = Status.Available)]
		public string CurrentWorkingDirectory { get; internal set; } = Environment.CurrentDirectory;

		/// <summary>
		/// Gets the framework description.
		/// </summary>
		/// <value>The framework description.</value>
		[DataMember]
		[Information(UnitTestCoverage = 100, Status = Status.Available)]
		public string FrameworkDescription { get; internal set; } = RuntimeInformation.FrameworkDescription;

		/// <summary>
		/// Gets the framework version.
		/// </summary>
		/// <value>The framework version.</value>
		[DataMember]
		[Information(UnitTestCoverage = 100, Status = Status.Available)]
		public Version FrameworkVersion { get; internal set; } = Environment.Version;

		/// <summary>
		/// Gets a value indicating whether this instance has shutdown started.
		/// </summary>
		/// <value><c>true</c> if this instance has shutdown started; otherwise, <c>false</c>.</value>
		[DataMember]
		[Information(UnitTestCoverage = 100, Status = Status.Available)]
		public bool HasShutdownStarted { get; internal set; } = Environment.HasShutdownStarted;

		/// <summary>
		/// Gets the ip addresses.
		/// </summary>
		/// <value>The ip address.</value>
		[DataMember]
		[Information(UnitTestCoverage = 100, Status = Status.Available)]
		public string IPAddress { get; internal set; } = Dns.GetHostAddresses(Dns.GetHostName()).Where(p => p.AddressFamily == AddressFamily.InterNetwork).ToList().ToDelimitedString(char.Parse(","));

		/// <summary>
		/// Gets a value indicating whether [is64 bit operating system].
		/// </summary>
		/// <value><c>true</c> if [is64 bit operating system]; otherwise, <c>false</c>.</value>
		[DataMember]
		[Information(UnitTestCoverage = 100, Status = Status.Available)]
		public bool Is64BitOperatingSystem { get; internal set; } = Environment.Is64BitOperatingSystem;

		/// <summary>
		/// Gets a value indicating whether [is64 bit process].
		/// </summary>
		/// <value><c>true</c> if [is64 bit process]; otherwise, <c>false</c>.</value>
		[DataMember]
		[Information(UnitTestCoverage = 100, Status = Status.Available)]
		public bool Is64BitProcess { get; internal set; } = Environment.Is64BitProcess;

		/// <summary>
		/// Gets a value indicating whether the user is interactive.
		/// </summary>
		/// <value><c>true</c> if this instance is user interactive; otherwise, <c>false</c>.</value>
		[DataMember]
		[Information(UnitTestCoverage = 100, Status = Status.Available)]
		public bool IsUserInteractive { get; internal set; } = Environment.UserInteractive;

		/// <summary>
		/// Gets the logical drives.
		/// </summary>
		/// <value>The logical drives.</value>
		[DataMember]
		[Information(UnitTestCoverage = 100, Status = Status.Available)]
		public IEnumerable<string> LogicalDrives { get; internal set; } = Environment.GetLogicalDrives().AsEnumerable();

		/// <summary>
		/// Gets the name of the machine.
		/// </summary>
		/// <value>The name of the machine.</value>
		[DataMember]
		[Information(UnitTestCoverage = 100, Status = Status.Available)]
		public string MachineName { get; internal set; } = Environment.MachineName;

		/// <summary>
		/// Gets the os architecture.
		/// </summary>
		/// <value>The os architecture.</value>
		[DataMember]
		[Information(UnitTestCoverage = 100, Status = Status.Available)]
		public Architecture OSArchitecture { get; internal set; } = RuntimeInformation.OSArchitecture;

		/// <summary>
		/// Gets the os version.
		/// </summary>
		/// <value>The os version.</value>
		[DataMember]
		[Information(UnitTestCoverage = 100, Status = Status.Available)]
		public string OSDescription { get; internal set; } = RuntimeInformation.OSDescription;


		/// <summary>
		/// Gets the size of the os memory page.
		/// </summary>
		/// <value>The size of the os memory page.</value>
		[DataMember]
		[Information(UnitTestCoverage = 100, Status = Status.Available)]
		public int OsMemoryPageSize { get; internal set; } = Environment.SystemPageSize;

		/// <summary>
		/// Gets the physical memory in use.
		/// </summary>
		/// <value>The physical memory in use.</value>
		[DataMember]
		[Information(UnitTestCoverage = 100, Status = Status.Available)]
		public long PhysicalMemoryInUse { get; internal set; } = Environment.WorkingSet;

		/// <summary>
		/// Gets the process architecture.
		/// </summary>
		/// <value>The process architecture.</value>
		[DataMember]
		[Information(UnitTestCoverage = 100, Status = Status.Available)]
		public Architecture ProcessArchitecture { get; internal set; } = RuntimeInformation.ProcessArchitecture;

		/// <summary>
		/// Gets the processor count.
		/// </summary>
		/// <value>The processor count.</value>
		[DataMember]
		[Information(UnitTestCoverage = 100, Status = Status.Available)]
		public int ProcessorCount { get; internal set; } = Environment.ProcessorCount;

		/// <summary>
		/// Gets the system directory.
		/// </summary>
		/// <value>The system directory.</value>
		[DataMember]
		[Information(UnitTestCoverage = 100, Status = Status.Available)]
		public string SystemDirectory { get; internal set; } = Environment.SystemDirectory;

		/// <summary>
		/// Gets the name of the user domain.
		/// </summary>
		/// <value>The name of the user domain.</value>
		[DataMember]
		[Information(UnitTestCoverage = 100, Status = Status.Available)]
		public string UserDomainName { get; internal set; } = Environment.UserDomainName;

		/// <summary>
		/// Gets the name of the user.
		/// </summary>
		/// <value>The name of the user.</value>
		[DataMember]
		[Information(UnitTestCoverage = 100, Status = Status.Available)]
		public string UserName { get; internal set; } = Environment.UserName;
	}
}
