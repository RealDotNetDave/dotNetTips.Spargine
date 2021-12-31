// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 07-19-2021
//
// Last Modified By : David McCarter
// Last Modified On : 11-23-2021
// ***********************************************************************
// <copyright file="EncryptionHelperTests.cs" company="dotNetTips.Spargine.Core.Tests">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;
using dotNetTips.Spargine.Core.Security;
using dotNetTips.Spargine.Extensions;
using dotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Spargine.Core.Tests.Security
{
	[ExcludeFromCodeCoverage]
	[TestClass]
	public class EncryptionHelperTests
	{
		[TestMethod]
		public void AesEncryptDecryptStringTest()
		{
			var testString = RandomData.GenerateWord(15);

			try
			{
				// Create Aes that generates a new key and initialization vector (IV).  
				// Same key must be used in encryption and decryption  
				using var aes = new AesManaged();

				// Encrypt string  
				var encrypted = EncryptionHelper.AesEncrypt(testString, aes.Key, aes.IV);

				// Decrypt the bytes to a string.  
				var decrypted = EncryptionHelper.AesDecrypt(encrypted, aes.Key, aes.IV);

				Assert.AreEqual(testString, decrypted);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Encryption/ Description test failed. {ex.Message}");
			}
		}

		[TestMethod]
		public void ComputeSha256HashTest()
		{
			var testString = RandomData.GenerateWord(15);

			var result = testString.ComputeSHA256Hash();

			Assert.IsTrue(string.IsNullOrEmpty(result) == false);
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
		public void PBKDF2PasswordHashTest()
		{
			var password = RandomData.GenerateWord(15);

			var hashedPassword = EncryptionHelper.HashPasswordWithPBKDF2(password);

			Assert.IsNotNull(hashedPassword);

			var result = EncryptionHelper.VerifyPBKDF2HashedPassword(hashedPassword, password);

			Assert.IsTrue(result == PasswordVerificationResult.Success);


		}

		[TestMethod]
		public void SHA256PasswordHashTest()
		{
			var password = RandomData.GenerateWord(15);

			var hashedPassword = EncryptionHelper.HashPasswordWithSHA256(password);

			Assert.IsNotNull(hashedPassword);

			var result = EncryptionHelper.VerifySHA256HashedPassword(hashedPassword, password);

			Assert.IsTrue(result == PasswordVerificationResult.Success);
		}

		[TestMethod]
		public void SimpleSHA256EncryptDecryptStringTest()
		{
			var testString = RandomData.GenerateWord(15);

			var key = EncryptionHelper.GenerateRandomKey();

			var cipherText = EncryptionHelper.SimpleSHA256Encrypt(testString, key);

			Assert.IsTrue(string.IsNullOrEmpty(cipherText) == false);

			var plainText = EncryptionHelper.SimpleSHA256Decrypt(cipherText, key);

			Assert.IsTrue(string.IsNullOrEmpty(plainText) == false);

			Assert.IsTrue(plainText.Equals(testString));
		}
	}
}
