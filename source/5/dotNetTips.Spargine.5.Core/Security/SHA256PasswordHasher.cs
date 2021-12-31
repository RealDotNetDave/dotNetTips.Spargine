// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Core
// Author           : David McCarter
// Created          : 10-12-2021
//
// Last Modified By : David McCarter
// Last Modified On : 12-31-2021
// ***********************************************************************
// <copyright file="SHA256PasswordHasher.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Original code from: https:www.meziantou.net/how-to-store-a-password-in-a-web-application.htm</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Core.Security
{
	/// <summary>
	/// Class SHA256PasswordHasher. This class cannot be inherited.
	/// </summary>
	public static class SHA256PasswordHasher
	{
		/// <summary>
		/// Generates the salt.
		/// </summary>
		/// <param name="byteLength">Length of the byte.</param>
		/// <returns>System.Byte[].</returns>
		private static byte[] GenerateSalt(int byteLength)
		{
			using (var cryptoServiceProvider = new RNGCryptoServiceProvider())
			{
				cryptoServiceProvider.GetBytes(new byte[byteLength]);

				return new byte[byteLength];
			}
		}

		/// <summary>
		/// Hashes the password with salt.
		/// </summary>
		/// <param name="password">The password.</param>
		/// <param name="salt">The salt.</param>
		/// <returns>System.Byte[].</returns>
		private static byte[] HashPasswordWithSalt(string password, byte[] salt)
		{
			byte[] hash;

			using (var hashAlgorithm = HashAlgorithm.Create(HashAlgorithmName.Name))
			{
				var input = Encoding.UTF8.GetBytes(password);
				_ = hashAlgorithm.TransformBlock(salt, 0, salt.Length, salt, 0);
				_ = hashAlgorithm.TransformFinalBlock(input, 0, input.Length);
				hash = hashAlgorithm.Hash;
			}

			return hash;
		}

		// In .NET Core 2.1, you can use CryptographicOperations.FixedTimeEquals
		// https://github.com/dotnet/runtime/blob/419e949d258ecee4c40a460fb09c66d974229623/src/libraries/System.Security.Cryptography.Primitives/src/System/Security/Cryptography/CryptographicOperations.cs#L32
		/// <summary>
		/// Fixeds the time equals.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		[Information(nameof(FixedTimeEquals), "David McCarter", "10/12/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public static bool FixedTimeEquals(byte[] left, byte[] right)
		{
			Validate.TryValidateParam(left, nameof(left));
			Validate.TryValidateParam(right, nameof(right));

			// NoOptimization because we want this method to be exactly as non-short-circuiting as written.
			// NoInlining because the NoOptimization would get lost if the method got inlined.
			if (left.Length != right.Length)
			{
				return false;
			}

			var byteCount = 0;

			for (var i = 0; i < left.Length; i++)
			{
				byteCount |= left[i] - right[i];
			}

			return byteCount == 0;
		}

		/// <summary>
		/// Hashes a password.
		/// </summary>
		/// <param name="password">The password.</param>
		/// <returns>System.String.</returns>
		[Information(nameof(HashPassword), "David McCarter", "10/12/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "ADD JAN URL")]
		public static string HashPassword([NotNull] string password)
		{
			// The salt must be unique for each password
			var salt = GenerateSalt(SaltSize);
			var hash = HashPasswordWithSalt(password, salt);

			var passwordBytes = new byte[1 + SaltSize + hash.Length];
			passwordBytes[0] = Version;

			Buffer.BlockCopy(salt, 0, passwordBytes, 1, SaltSize);
			Buffer.BlockCopy(hash, 0, passwordBytes, 1 + SaltSize, hash.Length);

			return Convert.ToBase64String(passwordBytes);
		}

		/// <summary>
		/// Verifies a hashed password.
		/// </summary>
		/// <param name="hashedPassword">The hashed password.</param>
		/// <param name="password">The password.</param>
		/// <returns>PasswordVerificationResult.</returns>
		[Information(nameof(VerifyHashedPassword), "David McCarter", "10/12/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "ADD JAN URL")]
		public static PasswordVerificationResult VerifyHashedPassword(string hashedPassword, [NotNull] string password)
		{
			if (string.IsNullOrEmpty(hashedPassword))
			{
				return PasswordVerificationResult.Failed;
			}

			Span<byte> passwordBytes = Convert.FromBase64String(hashedPassword);

			if (passwordBytes.Length < 1)
			{
				return PasswordVerificationResult.Failed;
			}

			var version = passwordBytes[0];

			if (version > Version)
			{
				return PasswordVerificationResult.Failed;
			}

			var salt = passwordBytes.Slice(1, SaltSize).ToArray();
			var bytes = passwordBytes[( 1 + SaltSize )..].ToArray();

			var hash = HashPasswordWithSalt(password, salt);

			return FixedTimeEquals(hash, bytes) ? PasswordVerificationResult.Success : PasswordVerificationResult.Failed;
		}

		/// <summary>
		/// Gets the name of the hash algorithm.
		/// </summary>
		/// <value>The name of the hash algorithm.</value>
		public static HashAlgorithmName HashAlgorithmName { get; } = HashAlgorithmName.SHA256;

		/// <summary>
		/// Gets the size of the salt.
		/// </summary>
		/// <value>The size of the salt.</value>
		public static int SaltSize { get; } = 128 / 8; // 128 bits

		/// <summary>
		/// Gets the version.
		/// </summary>
		/// <value>The version.</value>
		public static byte Version => 1;
	}
}
