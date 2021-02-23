// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 12-23-2020
// ***********************************************************************
// <copyright file="ExceptionExtensionsTests.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.Security;
using System.ServiceModel.Security;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Extensions.Tests
{
	[ExcludeFromCodeCoverage]
	[TestClass]
	public class ExceptionExtensionsTest
	{

		[TestMethod]
		public void GetAllMessagesTest()
		{
			var innerEx = new SecurityException("Message from SecurityException", new DataMisalignedException("Cannot access service!"));

			var ex = new SecurityAccessDeniedException("Message from SecurityAccessDeniedException", innerEx);

			var messages = ex.GetAllMessages();

			Assert.IsTrue(messages.IsNotEmpty());
		}

		[TestMethod]
		public void GetAllMessagesWithStackTraceTest()
		{
			var innerEx = new SecurityException("Message from SecurityException", new DataMisalignedException("Cannot access service!"));

			var ex = new SecurityAccessDeniedException("Message from SecurityAccessDeniedException", innerEx);

			var messages = ex.GetAllMessagesWithStackTrace();

			Assert.IsTrue(messages.HasItems());
		}
		[TestMethod]
		public void IsCriticalTest()
		{
			var exGood = new NullReferenceException();
			var exBad = new ArgumentNullException();

			Assert.IsTrue(exGood.IsCritical());
			Assert.IsFalse(exBad.IsCritical());
		}

		[TestMethod]
		public void IsFatalTest()
		{
			var exGood = new OutOfMemoryException();
			var exBad = new ArgumentNullException();

			Assert.IsTrue(exGood.IsFatal());
			Assert.IsFalse(exBad.IsFatal());
		}

		[TestMethod]
		public void IsSecurityOrCriticalTest()
		{
			var exGood = new SecurityException();
			var exBad = new ArgumentNullException();

			Assert.IsTrue(exGood.IsSecurityOrCritical());
			Assert.IsFalse(exBad.IsSecurityOrCritical());
		}
	}
}
