// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Core
// Author           : David McCarter
// Created          : 07-19-2021
//
// Last Modified By : David McCarter
// Last Modified On : 08-23-2021
// ***********************************************************************
// <copyright file="EncryptionHelper.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace dotNetTips.Spargine.Core.Security
{
	/// <summary>
	/// Class EncryptionHelper.
	/// </summary>
	public static class EncryptionHelper
	{
		/// <summary>
		/// Decrypts array to string using AES security.
		/// </summary>
		/// <param name="cipherText">The cipher text.</param>
		/// <param name="key">The secret key.</param>
		/// <param name="iv">The initialization vector.</param>
		/// <returns>System.String.</returns>
		/// <remarks>Original code by: Mahesh Chand.</remarks>
		[Information(nameof(AesDecrypt), "David McCarter", "7/19/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "ADD URL TO SEP ARTICLE")]
		public static string AesDecrypt([NotNull] string cipherText, [NotNull] byte[] key, [NotNull] byte[] iv)
		{
			// Create AesManaged.
			using var aes = new AesManaged();
			// Create a decryptor.
			using var decryptor = aes.CreateDecryptor(key, iv);

			// Create the streams used for decryption.
			using var ms = new MemoryStream(Convert.FromBase64String(cipherText));

			// Create crypto stream.
			using var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read);

			// Read crypto stream.
			using var reader = new StreamReader(cs);
			return reader.ReadToEnd();
		}

		/// <summary>
		/// Encrypts a string using Aes security.
		/// </summary>
		/// <param name="plainText">The input.</param>
		/// <param name="key">The secret key.</param>
		/// <param name="iv">The initialization vector.</param>
		/// <returns>System.Byte[].</returns>
		/// <remarks>Original code by: Mahesh Chand.</remarks>
		[Information(nameof(AesDecrypt), "David McCarter", "7/19/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "ADD URL TO SEP ARTICLE")]
		public static string AesEncrypt([NotNull] string plainText, [NotNull] byte[] key, [NotNull] byte[] iv)
		{
			// Create a new AesManaged.
			using var aes = new AesManaged();

			// Create encryptor
			using var encryptor = aes.CreateEncryptor(key, iv);

			// Create MemoryStream
			using var ms = new MemoryStream();

			// Create crypto stream using the CryptoStream class. This class is the key to encryption
			// and encrypts and decrypts data from any given stream. In this case, we will pass a memory stream
			// to encrypt
			using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
			{

				// Create StreamWriter and write data to a stream
				using var sw = new StreamWriter(cs);

				sw.Write(plainText);
			}

			return Convert.ToBase64String(ms.ToArray());
		}

		/// <summary>
		/// Generates the AES IV.
		/// </summary>
		/// <returns>System.Byte[].</returns>
		[Information(nameof(GenerateAesIV), "David McCarter", "7/19/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static byte[] GenerateAesIV()
		{
			using var aes = new AesManaged();
			aes.GenerateIV();

			return aes.IV;
		}

		/// <summary>
		/// Generates the AES key.
		/// </summary>
		/// <returns>System.Byte[].</returns>
		[Information(nameof(GenerateAesKey), "David McCarter", "7/19/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static byte[] GenerateAesKey()
		{
			using var aes = new AesManaged();
			aes.GenerateKey();

			return aes.Key;
		}

		/// <summary>
		/// Decrypts text using a key. Use AesManaged.
		/// </summary>
		/// <param name="cipherText">The encrypted text.</param>
		/// <param name="key">The key.</param>
		/// <returns>System.String.</returns>
		[Information(nameof(SimpleDecrypt), "David McCarter", "7/19/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "ADD URL TO SEP ARTICLE")]
		public static string SimpleDecrypt([NotNull] string cipherText, [NotNull] string key)
		{
			var keys = GetHashKeys(key);

			return AesDecrypt(cipherText, keys.key, keys.iv);
		}

		/// <summary>
		/// Encrypts text using a key. Uses AesManaged.
		/// </summary>
		/// <param name="plainText">The plain text.</param>
		/// <param name="key">The key.</param>
		/// <returns>System.String.</returns>
		/// <example>Example output: pVGs2TkJkzcHYW3Wiq2QEx8/kyFBJmE2Ji2lbwwAPaA=</example>
		[Information(nameof(SimpleEncrypt), "David McCarter", "7/19/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "ADD URL TO SEP ARTICLE")]
		public static string SimpleEncrypt([NotNull] string plainText, [NotNull] string key)
		{
			var keys = GetHashKeys(key);

			return AesEncrypt(plainText, keys.key, keys.iv);
		}

		/// <summary>
		/// Gets the hash keys.
		/// </summary>
		/// <param name="key">The key.</param>
		/// <returns>System.ValueTuple&lt;System.Byte[], System.Byte[]&gt;.</returns>
		private static (byte[] key, byte[] iv) GetHashKeys([NotNull] string key)
		{
			var encoding = Encoding.ASCII;

			using var sha2 = new SHA256CryptoServiceProvider();

			var rawKey = encoding.GetBytes(key);
			var rawIV = encoding.GetBytes(key);

			var hashKey = sha2.ComputeHash(rawKey);
			var hashIV = sha2.ComputeHash(rawIV);

			Array.Resize(ref hashIV, newSize: 16);

			return (hashKey, hashIV);
		}
	}
}
