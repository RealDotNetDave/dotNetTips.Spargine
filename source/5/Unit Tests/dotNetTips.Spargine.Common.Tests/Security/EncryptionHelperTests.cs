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
		private const string Key = "9999998888888877777777@#$%";
		private const string TestString = "ThisIsATestStringToEncrypt";

		[TestMethod]
		public void AesEncryptDecryptStringTest()
		{
			try
			{
				// Create Aes that generates a new key and initialization vector (IV).  
				// Same key must be used in encryption and decryption  
				using var aes = new AesManaged();

				// Encrypt string  
				var encrypted = EncryptionHelper.AesEncrypt(TestString, aes.Key, aes.IV);

				// Decrypt the bytes to a string.  
				var decrypted = EncryptionHelper.AesDecrypt(encrypted, aes.Key, aes.IV);

				Assert.AreEqual(TestString, decrypted);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Encryption/ Description test failed. {ex.Message}");
			}
		}

		[TestMethod]
		public void ComputeSha256HashTest()
		{
			var result = TestString.ComputeSHA256Hash();

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
		public void SimpleEncryptDecryptStringTest()
		{
			var cipherText = EncryptionHelper.SimpleEncrypt(TestString, Key);

			Assert.IsTrue(string.IsNullOrEmpty(cipherText) == false);

			var plainText = EncryptionHelper.SimpleDecrypt(cipherText, Key);

			Assert.IsTrue(string.IsNullOrEmpty(plainText) == false);

			Assert.IsTrue(plainText.Equals(TestString));
		}
	}
}
