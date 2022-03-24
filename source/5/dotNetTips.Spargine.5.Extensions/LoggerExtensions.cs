// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions
// Author           : David McCarter
// Created          : 03-22-2022
//
// Last Modified By : David McCarter
// Last Modified On : 03-23-2022
// ***********************************************************************
// <copyright file="LoggerExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Core.Logging;
using Microsoft.Extensions.Logging;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Class LoggerExtensions.
	/// </summary>
	public static class LoggerExtensions
	{
		/// <summary>
		/// Fasts the logger.
		/// </summary>
		/// <param name="logger">The logger.</param>
		/// <param name="logLevel">The log level.</param>
		/// <param name="message">The message.</param>
		/// <param name="ex">The ex.</param>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Information(nameof(FastLogger), author: "David McCarter", createdOn: "3/22/2022", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.New, Documentation = "ADD URL")]
		public static void FastLogger([NotNull] this ILogger logger, LogLevel logLevel, string message, [AllowNull] Exception ex)
		{
			LoggingHelper.FastLogger(logger, logLevel, message, ex);
		}
	}
}
