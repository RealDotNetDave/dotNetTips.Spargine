// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 03-29-2023
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

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class ExceptionExtensionsTests
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
