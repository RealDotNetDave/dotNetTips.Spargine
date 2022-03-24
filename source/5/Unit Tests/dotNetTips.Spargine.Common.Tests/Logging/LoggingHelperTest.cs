// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 03-23-2022
// ***********************************************************************
// <copyright file="LoggingHelperTest.cs" company="dotNetTips.Spargine.Core.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using dotNetTips.Spargine.Core.Logging;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spartine.Core.Tests.Logging
{
	[ExcludeFromCodeCoverage]
	[TestClass]
	public class LoggingHelperTest
	{
		private readonly ILogger<LoggingHelperTest> _logger = new LoggerFactory().CreateLogger<LoggingHelperTest>();

		[TestMethod]
		public void LogApplicationInformationTest()
		{
			LoggingHelper.LogApplicationInformation(_logger);
		}

		[TestMethod]
		public void LogComputerInformationTest()
		{
			LoggingHelper.LogComputerInformation(_logger);
		}

		[TestMethod]
		public void RetrieveAllExceptionMessagesTest()
		{
			var testException = new ArgumentNullException("TEST EX1.", new ArithmeticException("TEST EX2"));

			var result = LoggingHelper.RetrieveAllExceptionMessages(testException);

			Assert.IsTrue(result.Length == 2);
		}

		[TestMethod]
		public void FastLoggerTest()
		{
			var testException = new ArgumentNullException("TEST EX1.", new ArithmeticException("TEST EX2"));

			LoggingHelper.FastLogger(_logger, LogLevel.Debug, "Test Message 1", testException);

			LoggingHelper.FastLogger(_logger, LogLevel.Critical, "Test Message 2", testException);

			LoggingHelper.FastLogger(_logger, LogLevel.Error, "Test Message 3", testException);

			LoggingHelper.FastLogger(_logger, LogLevel.Information, "Test Message 4", testException);

			LoggingHelper.FastLogger(_logger, LogLevel.Trace, "Test Message 5", testException);

			LoggingHelper.FastLogger(_logger, LogLevel.Warning, "Test Message 6", null);
		}

		[TestMethod]
		public void RetrieveAllExceptionsTest()
		{
			var testException = new ArgumentNullException("TEST EX1.", new ArithmeticException("TEST EX2"));

			var result = LoggingHelper.RetrieveAllExceptions(testException);

			Assert.IsTrue(result.Length == 2);
		}
	}
}
