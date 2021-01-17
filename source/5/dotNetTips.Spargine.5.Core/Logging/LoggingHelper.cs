// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core
// Author           : David McCarter
// Created          : 09-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 01-06-2021
// ***********************************************************************
// <copyright file="LoggingHelper.cs" company="dotNetTips.Spargine.Core">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using dotNetTips.Spargine.Core.OOP;
using Microsoft.Extensions.Logging;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Core.Logging
{
	/// <summary>
	/// Logging Helper.
	/// </summary>
	public static class LoggingHelper
	{

		/// <summary>
		/// Logs application information.
		/// </summary>
		/// <param name="logger">The ILogger.</param>
		/// <exception cref="ArgumentNullException">Logger cannot be null.</exception>
		/// <example>Output:
		/// AppInfo:Company - Microsoft Corporation
		/// AppInfo:Version - 16.8.0
		/// AppInfo:Copyright - © Microsoft Corporation.All rights reserved.
		/// AppInfo:Product - dotNetTips.Spargine
		/// AppInfo:FileVersion - 15.0.0
		/// AppInfo:Title - dotNetTips.Spargine
		/// </example>
		[Information(nameof(LogApplicationInformation), author: "David McCarter", createdOn: "11/03/2020", modifiedOn: "1/03/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.New)]
		public static void LogApplicationInformation(ILogger logger)
		{
			Encapsulation.TryValidateParam<ArgumentNullException>(logger != null, nameof(logger));

			var appInfo = App.AppInfo;

			var values = TypeHelper.GetPropertyValues<AppInfo>(appInfo);

			if (values.Count() > 0)
			{
				foreach (var item in values.OrderBy(p => p.Key))
				{
					logger.LogInformation($"{nameof(AppInfo)}:{item.Key} - {item.Value}");
				}
			}
		}

		/// <summary>
		/// Logs computer information.
		/// </summary>
		/// <param name="logger">The ILogger.</param>
		/// <exception cref="ArgumentNullException">Logger cannot be null.</exception>
		/// <example>OUTPUT:
		/// AppInfo:Is64BitProcess - True
		/// AppInfo:ProcessArchitecture - X64
		/// AppInfo:CurrentStackTrace - at System.Environment.get_StackTrace()\r\n at dotNetTips.Utility.Standard.ComputerInfo..ctor() in...
		/// AppInfo:ComputerCulture - eng
		/// AppInfo:UserName - david
		/// AppInfo:IsUserInteractive - True
		/// AppInfo:OsMemoryPageSize - 4096
		/// AppInfo:FrameworkVersion - 3.1.10
		/// AppInfo:IPAddress - 192.168.0.7
		/// AppInfo:Is64BitOperatingSystem - True
		/// AppInfo:CurrentSystemTickCount - 185990421
		/// AppInfo:ComputerUICulture - eng
		/// AppInfo:ProcessorCount - 4
		/// AppInfo:FrameworkDescription - .NET Core 3.1.10
		/// AppInfo:PhysicalMemoryInUse - 49123328
		/// AppInfo:OSArchitecture - X64
		/// AppInfo:CurrentManagedTreadId - 6
		/// AppInfo:CurrentWorkingDirectory - C:\\src\\GitHub\\dotNetTips.Utility.Core\\src\\Unit Tests\\dotNetTips.Utility.Standard.Tests\\bin\\Debug\\netcoreapp3.1
		/// AppInfo:MachineName - DOTNETTIPS
		/// AppInfo:OSDescription - Microsoft Windows 10.0.19042
		/// AppInfo:UserDomainName - DOTNETTIPS
		/// AppInfo:SystemDirectory - C:\\WINDOWS\\system32
		/// AppInfo:HasShutdownStarted - False
		/// </example>
		[Information(nameof(LogComputerInformation), author: "David McCarter", createdOn: "11/04/2020", modifiedOn: "1/04/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.New)]
		public static void LogComputerInformation(ILogger logger)
		{
			Encapsulation.TryValidateParam<ArgumentNullException>(logger != null, nameof(logger));

			var computerInfo = new ComputerInfo();

			var values = TypeHelper.GetPropertyValues<ComputerInfo>(computerInfo);

			if (values.Count() > 0)
			{
				foreach (var item in values.OrderBy(p => p.Key))
				{
					logger.LogDebug($"{nameof(ComputerInfo)}:{item.Key} - {item.Value}");
				}
			}
		}

		/// <summary>
		/// Retrieves all exception messages.
		/// </summary>
		/// <param name="ex">The ex.</param>
		/// <returns>IEnumerable&lt;System.String&gt;.</returns>
		/// <exception cref="ArgumentNullException">Exception cannot be null.</exception>
		[Information(nameof(RetrieveAllExceptionMessages), UnitTestCoverage = 99, Status = Status.Available)]
		public static string[] RetrieveAllExceptionMessages(Exception ex)
		{
			Encapsulation.TryValidateParam<ArgumentNullException>(ex != null, nameof(ex));

			var exceptions = RetrieveAllExceptions(ex);

			var messages = new string[exceptions.Length];

			for (var i = 0; i < exceptions.Length; i++)
			{
				messages[i] = exceptions[i].Message;
			}

			return messages;
		}

		/// <summary>
		/// Retrieves all exceptions (including inner exceptions).
		/// </summary>
		/// <param name="ex">The ex.</param>
		/// <returns>IEnumerable&lt;Exception&gt;.</returns>
		/// <exception cref="ArgumentNullException">Exception cannot be null.</exception>
		[Information(nameof(RetrieveAllExceptions), UnitTestCoverage = 99, Status = Status.Available)]
		public static Exception[] RetrieveAllExceptions(Exception ex)
		{
			Encapsulation.TryValidateParam<ArgumentNullException>(ex != null, nameof(ex));

			var collection = new List<Exception>();

			collection = new List<Exception> { ex };

			if (( ex.InnerException is null ) == false)
			{
				collection.AddRange(RetrieveAllExceptions(ex.InnerException));
			}

			return collection.ToArray();
		}
	}
}
