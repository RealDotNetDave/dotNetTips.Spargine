// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions
// Author           : David McCarter
// Created          : 03-23-2022
//
// Last Modified By : David McCarter
// Last Modified On : 07-14-2022
// ***********************************************************************
// <copyright file="LoggerExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Class LoggerExtensions.
/// </summary>
public static class LoggerExtensions
{
	///// <summary>
	///// Fast logger.
	///// </summary>
	///// <param name="logger">The logger.</param>
	///// <param name="logLevel">The log level.</param>
	///// <param name="message">The message.</param>
	///// <param name="ex">The ex.</param>
	//[MethodImpl(MethodImplOptions.AggressiveInlining)]
	//[Information(nameof(FastLogger), author: "David McCarter", createdOn: "3/22/2022", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.New, Documentation = "ADD URL")]
	//public static void FastLogger([NotNull] this ILogger logger, LogLevel logLevel, [NotNull] string message, [AllowNull] Exception ex)
	//{
	//	//NO need to validate input. This method will do that.
	//	LoggingHelper.FastLogger(logger.ArgumentNotNull(), logLevel.ArgumentDefined(), message.ArgumentNotNullOrEmpty(), ex);
	//}
}
