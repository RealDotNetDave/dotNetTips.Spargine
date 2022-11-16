// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Core
// Author           : David McCarter
// Created          : 07-19-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-06-2023
// ***********************************************************************
// <copyright file="EncryptionHelper.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.Security;

/// <summary>
/// Class EncryptionHelper.
/// </summary>
public static class EncryptionHelper
{
	/// <summary>
	/// Gets the hash keys.
	/// </summary>
	/// <param name="key">The key.</param>
	/// <returns>System.ValueTuple&lt;System.Byte[], System.Byte[]&gt;.</returns>
	private static (byte[] key, byte[] iv) GetSHA256HashKeys([NotNull] string key)
	{
		var encoding = Encoding.ASCII;

		var hashKey = SHA256.HashData(encoding.GetBytes(key));
		var hashIV = SHA256.HashData(encoding.GetBytes(key));

		Array.Resize(ref hashIV, newSize: 16);

		return (hashKey, hashIV);
	}

	/// <summary>
	/// Decrypts array to string using AES security.
	/// </summary>
	/// <param name="cipherText">The cipher text.</param>
	/// <param name="key">The secret key.</param>
	/// <param name="iv">The initialization vector.</param>
	/// <returns>System.String.</returns>
	/// <remarks>Original code by: Mahesh Chand.</remarks>
	[Information(nameof(AesDecrypt), "David McCarter", "7/19/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineSep2021")]
	public static string AesDecrypt([NotNull] string cipherText, [NotNull] byte[] key, [NotNull] byte[] iv)
	{
		cipherText = cipherText.ArgumentNotNull();
		key = key.ArgumentNotNull();
		iv = iv.ArgumentNotNull();

		// Create AesManaged.
		using (var aes = Aes.Create())
		{
			// Create a decryptor.
			using (var decryptor = aes.CreateDecryptor(key, iv))
			{
				// Create the streams used for decryption.
				using (var ms = new MemoryStream(Convert.FromBase64String(cipherText)))
				{
					// Create crypto stream.
					using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
					{
						// Read crypto stream.
						using (var reader = new StreamReader(cs))
						{
							return reader.ReadToEnd();
						}
					}
				}
			}
		}
	}

	/// <summary>
	/// Encrypts a string using Aes security.
	/// </summary>
	/// <param name="plainText">The input.</param>
	/// <param name="key">The secret key.</param>
	/// <param name="iv">The initialization vector.</param>
	/// <returns>System.Byte[].</returns>
	/// <remarks>Original code by: Mahesh Chand.</remarks>
	[Information(nameof(AesDecrypt), "David McCarter", "7/19/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineSep2021")]
	public static string AesEncrypt([NotNull] string plainText, [NotNull] byte[] key, [NotNull] byte[] iv)
	{
		plainText = plainText.ArgumentNotNullOrEmpty(true);
		key = key.ArgumentNotNull();
		iv = iv.ArgumentNotNull();

		// Create a new AesManaged.
		using (var aes = Aes.Create())
		{
			aes.Key = key;
			aes.IV = iv;

			// Create encryptor
			using (var encryptor = aes.CreateEncryptor())
			{
				// Create MemoryStream
				using (var ms = new MemoryStream())
				{
					// Create crypto stream using the CryptoStream class. This class is the key to encryption
					// and encrypts and decrypts data from any given stream. In this case, we will pass a memory stream
					// to encrypt
					using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
					{
						// Create StreamWriter and write data to a stream
						using (var sw = new StreamWriter(cs))
						{
							sw.Write(plainText);
						}
					}

					return Convert.ToBase64String(ms.ToArray());
				}
			}
		}
	}

	/// <summary>
	/// Generates the AES IV.
	/// </summary>
	/// <returns>System.Byte[].</returns>
	[Information(nameof(GenerateAesIV), "David McCarter", "7/19/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
	public static byte[] GenerateAesIV()
	{
		using (var aes = Aes.Create())
		{
			aes.GenerateIV();

			return aes.IV;
		}
	}

	/// <summary>
	/// Generates the AES key.
	/// </summary>
	/// <returns>System.Byte[].</returns>
	[Information(nameof(GenerateAesKey), "David McCarter", "7/19/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
	public static byte[] GenerateAesKey()
	{
		using (var aes = Aes.Create())
		{
			aes.GenerateKey();

			return aes.Key;
		}
	}

	/// <summary>
	/// Creates a random key from a GUID.
	/// </summary>
	/// <returns>System.String.</returns>
	/// <example><b>Output:</b> f7f0af78003d4ab194b5a4024d02112a</example>
	[Information(nameof(GenerateRandomKey), "David McCarter", "5/30/2021", UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static string GenerateRandomKey() => Guid.NewGuid().ToString("N", CultureInfo.InvariantCulture);

	/// <summary>
	/// Simple the SHA256 decrypt.
	/// </summary>
	/// <param name="cipherText">The encrypted text.</param>
	/// <param name="key">The key.</param>
	/// <returns>System.String.</returns>
	[Information(nameof(SimpleSHA256Decrypt), "David McCarter", "7/19/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineSep2021")]
	public static string SimpleSHA256Decrypt([NotNull] string cipherText, [NotNull] string key)
	{
		cipherText = cipherText.ArgumentNotNullOrEmpty(true);
		key = key.ArgumentNotNullOrEmpty();

		var keys = GetSHA256HashKeys(key);

		return AesDecrypt(cipherText, keys.key, keys.iv);
	}

	/// <summary>
	/// Encrypts text using a key. Uses AesManaged.
	/// </summary>
	/// <param name="plainText">The plain text.</param>
	/// <param name="key">The key.</param>
	/// <returns>System.String.</returns>
	/// <example>
	/// Original: cUjmkES]gbgSneP
	/// Encrypted: fdfc6PjkJp/3m5hONEMGMQ==
	/// </example>
	[Information(nameof(SimpleSHA256Encrypt), "David McCarter", "7/19/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineSep2021")]
	public static string SimpleSHA256Encrypt([NotNull] string plainText, [NotNull] string key)
	{
		plainText = plainText.ArgumentNotNullOrEmpty(true);
		key = key.ArgumentNotNullOrEmpty();

		var keys = GetSHA256HashKeys(key);

		return AesEncrypt(plainText, keys.key, keys.iv);
	}

	/// <summary>
	/// Verifies a hashed password with sha256.
	/// </summary>
	/// <param name="hashedPassword">The hashed password.</param>
	/// <param name="password">The password.</param>
	/// <returns>PasswordVerificationResult.</returns>
	[Information(nameof(VerifySHA256HashedPassword), "David McCarter", "10/13/2021", UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022", BenchMarkStatus = BenchMarkStatus.Completed)]
	public static PasswordVerificationResult VerifySHA256HashedPassword(string hashedPassword, [NotNull] string password)
	{
		return SHA256PasswordHasher.VerifyHashedPassword(hashedPassword, password.ArgumentNotNullOrEmpty());
	}
}
