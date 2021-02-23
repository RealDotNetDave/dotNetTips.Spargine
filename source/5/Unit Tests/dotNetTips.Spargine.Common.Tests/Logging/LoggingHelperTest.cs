// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 01-06-2021
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

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
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
