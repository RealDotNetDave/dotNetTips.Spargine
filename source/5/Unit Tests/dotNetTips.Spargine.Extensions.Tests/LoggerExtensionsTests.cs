// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 03-23-2022
//
// Last Modified By : David McCarter
// Last Modified On : 03-23-2022
// ***********************************************************************
// <copyright file="LoggerExtensionsTests.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using dotNetTips.Spargine.Tester;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Extensions.Tests
{
	[ExcludeFromCodeCoverage]
	[TestClass]
	public class LoggerExtensionsTests : TestClass
	{
		private readonly ILogger<LoggerExtensionsTests> _logger = new LoggerFactory().CreateLogger<LoggerExtensionsTests>();

		[TestMethod]
		public void FastLoggerTest()
		{
			var testException = new ArgumentNullException("TEST EX1.", new ArithmeticException("TEST EX2"));

			_logger.FastLogger(LogLevel.Debug, "Test Message 1", testException);

			_logger.FastLogger(LogLevel.Critical, "Test Message 2", testException);

			_logger.FastLogger(LogLevel.Error, "Test Message 3", testException);

			_logger.FastLogger(LogLevel.Information, "Test Message 4", testException);

			_logger.FastLogger(LogLevel.Trace, "Test Message 5", testException);

			_logger.FastLogger(LogLevel.Warning, "Test Message 6", null);
		}
	}
}
