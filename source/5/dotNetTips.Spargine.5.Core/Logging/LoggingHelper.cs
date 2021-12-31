// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core
// Author           : David McCarter
// Created          : 09-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 12-27-2021
// ***********************************************************************
// <copyright file="LoggingHelper.cs" company="dotNetTips.Spargine.Core">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary>Helper methods for use in logging.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Runtime.ExceptionServices;
using Microsoft.Extensions.Logging;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Core.Logging
{
	/// <summary>
	/// Logging Helper.
	/// </summary>
	public static class LoggingHelper
	{
		/// <summary>
		/// The application domain exception logger
		/// </summary>
		private static ILogger _appDomainExceptionLogger;

		/// <summary>
		/// Handles the FirstChanceException event of the CurrentDomain control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="FirstChanceExceptionEventArgs" /> instance containing the event data.</param>
		private static void CurrentDomain_FirstChanceException(object sender, FirstChanceExceptionEventArgs e)
		{
			_appDomainExceptionLogger.LogError(e.Exception, e.Exception.GetAllMessages());
		}

		/// <summary>
		/// Logs the application domain exceptions.
		/// </summary>
		/// <param name="logger">The logger.</param>
		/// <remarks>Logger can only be set once. If this is called twice or more, it will be ignored.</remarks>
		[Information(nameof(LogAppDomainExceptions), author: "David McCarter", createdOn: "10/19/2021", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.New, Documentation = "ADD JAN URL")]
		public static void LogAppDomainExceptions([NotNull] ILogger logger)
		{
			if (_appDomainExceptionLogger is null)
			{
				_appDomainExceptionLogger = logger;
				AppDomain.CurrentDomain.FirstChanceException += CurrentDomain_FirstChanceException;

				logger.LogInformation($"Starting to capture all exceptions on {DateTime.UtcNow} UTC");
			}
		}
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
		[Information(nameof(LogApplicationInformation), author: "David McCarter", createdOn: "11/03/2020", modifiedOn: "1/03/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "http://bit.ly/SpargineFeb2021")]
		public static void LogApplicationInformation([NotNull] ILogger logger)
		{
			var appInfo = App.AppInfo;

			var values = TypeHelper.GetPropertyValues(appInfo);

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
		/// AppInfo:CurrentStackTrace - at System.Environment.get_StackTrace()\r\n at
		/// .Standard.ComputerInfo..ctor() in...
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
		[Information(nameof(LogComputerInformation), author: "David McCarter", createdOn: "11/04/2020", modifiedOn: "1/04/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "http://bit.ly/SpargineFeb2021")]
		public static void LogComputerInformation([NotNull] ILogger logger)
		{
			var computerInfo = new ComputerInfo();

			var values = TypeHelper.GetPropertyValues(computerInfo);

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
		[Information(nameof(RetrieveAllExceptionMessages), UnitTestCoverage = 100, Status = Status.Available)]
		public static string[] RetrieveAllExceptionMessages([NotNull] Exception ex)
		{
			var exceptions = RetrieveAllExceptions(ex);

			var messages = new string[exceptions.Length];

			for (var exCount = 0; exCount < exceptions.Length; exCount++)
			{
				messages[exCount] = exceptions[exCount].Message;
			}

			return messages;
		}

		/// <summary>
		/// Retrieves all exceptions (including inner exceptions).
		/// </summary>
		/// <param name="ex">The ex.</param>
		/// <returns>IEnumerable&lt;Exception&gt;.</returns>
		/// <exception cref="ArgumentNullException">Exception cannot be null.</exception>
		[Information(nameof(RetrieveAllExceptions), UnitTestCoverage = 100, Status = Status.Available)]
		public static Exception[] RetrieveAllExceptions([NotNull] Exception ex)
		{
			var collection = new List<Exception> { ex };

			if (( ex.InnerException is null ) == false)
			{
				collection.AddRange(RetrieveAllExceptions(ex.InnerException));
			}

			return collection.ToArray();
		}
	}
}
