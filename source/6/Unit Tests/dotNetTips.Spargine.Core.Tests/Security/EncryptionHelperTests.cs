// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 07-19-2021
//
// Last Modified By : David McCarter
// Last Modified On : 03-29-2023
// ***********************************************************************
// <copyright file="EncryptionHelperTests.cs" company="DotNetTips.Spargine.Core.Tests">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core.Security;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.Tests.Security;

[ExcludeFromCodeCoverage]
[TestClass]
public class EncryptionHelperTests
{

	[TestMethod]
	public void ComputeSha256HashTest()
	{
		var testString = RandomData.GenerateWord(15);

		var result = testString.ComputeSHA256Hash();

		Assert.IsTrue(string.IsNullOrEmpty(result) is false);
	}

	[TestMethod]
	public void GenerateAesIVTest()
	{
		var result = EncryptionHelper.GenerateAesIV();

		Assert.IsTrue(result.HasItems());
	}

	[TestMethod]
	public void GenerateAesKeyTest()
	{
		var result = EncryptionHelper.GenerateAesKey();

		Assert.IsTrue(result.HasItems());
	}

	[TestMethod]
	public void SimpleSHA256EncryptDecryptStringTest()
	{
		var testString = RandomData.GenerateWord(15);

		var key = EncryptionHelper.GenerateRandomKey();

		var cipherText = EncryptionHelper.SimpleSHA256Encrypt(testString, key);

		Assert.IsTrue(string.IsNullOrEmpty(cipherText) is false);

		var plainText = EncryptionHelper.SimpleSHA256Decrypt(cipherText, key);

		Assert.IsTrue(string.IsNullOrEmpty(plainText) is false);

		Assert.IsTrue(plainText.Equals(testString));
	}

}
