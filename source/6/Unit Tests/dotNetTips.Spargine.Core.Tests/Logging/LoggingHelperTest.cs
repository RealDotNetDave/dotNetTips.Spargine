// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 01-06-2021
// ***********************************************************************
// <copyright file="LoggingHelperTest.cs" company="DotNetTips.Spargine.Core.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core.Logging;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace dotNetTips.Spartine.Core.Tests.Logging
{
	[ExcludeFromCodeCoverage]
	[TestClass]
	public class LoggingHelperTest
	{

		[TestMethod]
		public void LogApplicationInformationTest()
		{
			var logger = new LoggerFactory().CreateLogger<LoggingHelperTest>();

			LoggingHelper.LogApplicationInformation(logger);
		}

		[TestMethod]
		public void LogComputerInformationTest()
		{
			var logger = new LoggerFactory().CreateLogger<LoggingHelperTest>();

			LoggingHelper.LogComputerInformation(logger);
		}

		[TestMethod]
		public void RetrieveAllExceptionMessagesTest()
		{
			var testException = new ArgumentNullException("TEST EX1.", new ArithmeticException("TEST EX2"));

			var result = LoggingHelper.RetrieveAllExceptionMessages(testException);

			Assert.IsTrue(result.Length == 2);
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
