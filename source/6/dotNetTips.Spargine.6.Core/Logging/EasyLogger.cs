// ***********************************************************************
// Assembly         : dotNetTips.Spargine.6.Core
// Author           : David McCarter
// Created          : 05-01-2022
//
// Last Modified By : David McCarter
// Last Modified On : 09-05-2023
// ***********************************************************************
// <copyright file="EasyLogger.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// This class logs to any ILogger object in the fasest way possible.
// Logs Critical, Debug, Error, Exception, Information, Trace and
// Warning messages.
// </summary>
// ***********************************************************************
using Microsoft.Extensions.Logging;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.Logging;

/// <summary>
/// Class Logger.
/// </summary>
public static partial class EasyLogger
{

	/// <summary>
	/// Logs critical storedProcedure.
	/// <param name="logger">The logger.</param>
	/// <param name="message">The storedProcedure.</param>
	/// <param name="exception">The exception.</param>
	/// </summary>
	[LoggerMessage(EventId = 911, Level = LogLevel.Critical, EventName = "CRITICAL", Message = "{message}")]
	public static partial void LogCritical(ILogger logger, string message, Exception exception);

	/// <summary>
	/// Logs debug storedProcedure.
	/// </summary>
	/// <param name="logger">The logger.</param>
	/// <param name="message">The storedProcedure.</param>
	[LoggerMessage(EventId = 200, Level = LogLevel.Debug, EventName = "DEBUG", Message = "{message}")]
	public static partial void LogDebug(ILogger logger, string message);

	/// <summary>
	/// Logs error storedProcedure.
	/// </summary>
	/// <param name="logger">The logger.</param>
	/// <param name="message">The storedProcedure.</param>
	[LoggerMessage(EventId = 300, Level = LogLevel.Error, EventName = "ERROR", Message = "{message}")]
	public static partial void LogError(ILogger logger, string message);

	/// <summary>
	/// Logs <see cref="Exception"/> along with error storedProcedure.
	/// </summary>
	/// <param name="logger">The logger.</param>
	/// <param name="message">The storedProcedure.</param>
	/// <param name="exception">The exception.</param>
	[LoggerMessage(EventId = 500, Level = LogLevel.Error, EventName = "EXCEPTION", Message = "{message}")]
	public static partial void LogException(ILogger logger, string message, Exception exception);

	/// <summary>
	/// Logs information storedProcedure.
	/// </summary>
	/// <param name="logger">The logger.</param>
	/// <param name="message">The storedProcedure.</param>
	[LoggerMessage(EventId = 400, Level = LogLevel.Information, EventName = "INFORMATION", Message = "{message}")]
	public static partial void LogInformation(ILogger logger, string message);

	/// <summary>
	/// Logs trace storedProcedure.
	/// </summary>
	/// <param name="logger">The logger.</param>
	/// <param name="message">The storedProcedure.</param>
	[LoggerMessage(EventId = 100, Level = LogLevel.Trace, EventName = "TRACE", Message = "{message}")]
	public static partial void LogTrace(ILogger logger, string message);

	/// <summary>
	/// Logs warning storedProcedure.
	/// </summary>
	/// <param name="logger">The logger.</param>
	/// <param name="message">The storedProcedure.</param>
	[LoggerMessage(EventId = 600, Level = LogLevel.Warning, EventName = "WARNING", Message = "{message}")]
	public static partial void LogWarning(ILogger logger, string message);

}
