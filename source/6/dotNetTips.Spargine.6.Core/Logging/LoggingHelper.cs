// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core
// Author           : David McCarter
// Created          : 09-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 08-06-2022
// ***********************************************************************
// <copyright file="LoggingHelper.cs" company="dotNetTips.Spargine.Core">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary>Helper methods for use in logging.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Runtime.ExceptionServices;
using Microsoft.Extensions.Logging;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.Logging
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

		///// <summary>
		///// The logger message critical
		///// </summary>
		//private static readonly Action<ILogger, string, Exception> _loggerMessageCritical = LoggerMessage.Define<string>(LogLevel.Critical, new EventId(100, "CRITICAL"), "{Message}");

		///// <summary>
		///// The logger message debug
		///// </summary>
		//private static readonly Action<ILogger, string, Exception> _loggerMessageDebug = LoggerMessage.Define<string>(LogLevel.Debug, new EventId(200, "DEBUG"), "{Message}");

		///// <summary>
		///// The logger message error
		///// </summary>
		//private static readonly Action<ILogger, string, Exception> _loggerMessageError = LoggerMessage.Define<string>(LogLevel.Error, new EventId(300, "ERROR"), "{Message}");

		///// <summary>
		///// The logger message information
		///// </summary>
		//private static readonly Action<ILogger, string, Exception> _loggerMessageInformation = LoggerMessage.Define<string>(LogLevel.Information, new EventId(400, "INFORMATION"), "{Message}");

		///// <summary>
		///// The logger message trace
		///// </summary>
		//private static readonly Action<ILogger, string, Exception> _loggerMessageTrace = LoggerMessage.Define<string>(LogLevel.Trace, new EventId(500, "TRACE"), "{Message}");

		///// <summary>
		///// The logger message warning
		///// </summary>
		//private static readonly Action<ILogger, string, Exception> _loggerMessageWarning = LoggerMessage.Define<string>(LogLevel.Warning, new EventId(600, "WARNING"), "{Message}");

		/// <summary>
		/// Handles the FirstChanceException event of the CurrentDomain control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="FirstChanceExceptionEventArgs" /> instance containing the event data.</param>
		private static void CurrentDomain_FirstChanceException(object sender, FirstChanceExceptionEventArgs e)
		{
			EasyLogger.LogError(_appDomainExceptionLogger, e.Exception.GetAllMessages(), e.Exception);
		}

		///// <summary>
		///// Fasts the logger.
		///// </summary>
		///// <param name="logger">The logger.</param>
		///// <param name="logLevel">The log level.</param>
		///// <param name="message">The message.</param>
		///// <param name="ex">The Exception.</param>
		///// <exception cref="ArgumentNullException">logger</exception>
		///// <exception cref="ArgumentException">'{nameof(message)}' cannot be null or empty. - message</exception>
		//[MethodImpl(MethodImplOptions.AggressiveInlining)]
		//[Information(nameof(FastLogger), author: "David McCarter", createdOn: "3/21/2022", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "ADD URL")]
		//public static void FastLogger([NotNull] ILogger logger, LogLevel logLevel, string message, [AllowNull] Exception ex)
		//{
		//	logger = logger.ArgumentNotNull();
		//	message = message.ArgumentNotNullOrEmpty(true);

		//	switch (logLevel)
		//	{
		//		case LogLevel.Critical:
		//			{
		//				_loggerMessageCritical(logger, message, ex);
		//				break;
		//			}

		//		case LogLevel.Debug:
		//			{
		//				_loggerMessageDebug(logger, message, ex);
		//				break;
		//			}

		//		case LogLevel.Error:
		//			{
		//				_loggerMessageError(logger, message, ex);
		//				break;
		//			}

		//		case LogLevel.Trace:
		//			{
		//				_loggerMessageTrace(logger, message, ex);
		//				break;
		//			}

		//		case LogLevel.Warning:
		//			{
		//				_loggerMessageWarning(logger, message, ex);
		//				break;
		//			}

		//		default:
		//			{
		//				_loggerMessageInformation(logger, message, ex);
		//				break;
		//			}
		//	}
		//}

		/// <summary>
		/// Logs the application domain exceptions.
		/// </summary>
		/// <param name="logger">The logger.</param>
		/// <remarks>Logger can only be set once. If this is called twice or more, it will be ignored.</remarks>
		[Information(nameof(LogAppDomainExceptions), author: "David McCarter", createdOn: "10/19/2021", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
		public static void LogAppDomainExceptions([NotNull] ILogger logger)
		{
			logger = logger.ArgumentNotNull();

			if (_appDomainExceptionLogger is null)
			{
				_appDomainExceptionLogger = logger;
				AppDomain.CurrentDomain.FirstChanceException += CurrentDomain_FirstChanceException;

				EasyLogger.LogInformation(logger, $"Starting to capture all exceptions on {DateTime.UtcNow} UTC");
			}
		}
		/// <summary>
		/// Logs default application information as key/ value pairs to <see cref="ILogger" />.
		/// </summary>
		/// <param name="logger">The ILogger.</param>
		/// <exception cref="ArgumentNullException">Logger cannot be null.</exception>
		/// <example>
		///   <b>Output:</b>
		/// AppInfo:Company - Microsoft Corporation
		/// AppInfo:Version - 16.8.0
		/// AppInfo:Copyright - © Microsoft Corporation.All rights reserved.
		/// AppInfo:Product - dotNetTips.Spargine
		/// AppInfo:FileVersion - 15.0.0
		/// AppInfo:Title - dotNetTips.Spargine
		/// </example>
		[Information(nameof(LogApplicationInformation), author: "David McCarter", createdOn: "11/03/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "http://bit.ly/SpargineFeb2021")]
		public static void LogApplicationInformation([NotNull] ILogger logger)
		{
			logger = logger.ArgumentNotNull();

			AppInfo appInfo = App.AppInfo;

			System.Collections.Immutable.ImmutableDictionary<string, string> values = TypeHelper.GetPropertyValues(appInfo);

			if (values?.FastCount() > 0)
			{
				foreach (KeyValuePair<string, string> item in values.OrderBy(p => p.Key))
				{
					EasyLogger.LogInformation(logger, $"{nameof(AppInfo)}:{item.Key} - {item.Value}");
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
		[Information(nameof(LogComputerInformation), author: "David McCarter", createdOn: "11/04/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "http://bit.ly/SpargineFeb2021")]
		public static void LogComputerInformation([NotNull] ILogger logger)
		{
			logger = logger.ArgumentNotNull();

			var computerInfo = new ComputerInfo();

			System.Collections.Immutable.ImmutableDictionary<string, string> values = TypeHelper.GetPropertyValues(computerInfo);

			if (values?.FastCount() > 0)
			{
				foreach (KeyValuePair<string, string> item in values.OrderBy(p => p.Key))
				{
					EasyLogger.LogDebug(logger, $"{nameof(ComputerInfo)}:{item.Key} - {item.Value}");
				}
			}
		}

		/// <summary>
		/// Retrieves all exception messages.
		/// </summary>
		/// <param name="exception">The ex.</param>
		/// <returns>IEnumerable&lt;System.String&gt;.</returns>
		/// <exception cref="ArgumentNullException">Exception cannot be null.</exception>
		[Information(nameof(RetrieveAllExceptionMessages), UnitTestCoverage = 100, Status = Status.Available)]
		public static string[] RetrieveAllExceptionMessages([NotNull] Exception exception)
		{
			exception = exception.ArgumentNotNull();

			Exception[] exceptions = RetrieveAllExceptions(exception);

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
		/// <param name="exception">The ex.</param>
		/// <returns>IEnumerable&lt;Exception&gt;.</returns>
		/// <exception cref="ArgumentNullException">Exception cannot be null.</exception>
		[Information(nameof(RetrieveAllExceptions), UnitTestCoverage = 100, Status = Status.Available)]
		public static Exception[] RetrieveAllExceptions([NotNull] Exception exception)
		{
			exception = exception.ArgumentNotNull();

			var collection = new List<Exception> { exception };

			if (exception.InnerException is not null)
			{
				collection.AddRange(RetrieveAllExceptions(exception.InnerException));
			}

			return collection.ToArray();
		}

	}
}
