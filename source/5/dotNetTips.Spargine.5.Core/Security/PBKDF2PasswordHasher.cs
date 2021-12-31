// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Core
// Author           : David McCarter
// Created          : 10-12-2021
//
// Last Modified By : David McCarter
// Last Modified On : 12-31-2021
// ***********************************************************************
// <copyright file="PBKDF2PasswordHasher.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Original code from: https:www.meziantou.net/how-to-store-a-password-in-a-web-application.htm</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Core.Security
{
	/// <summary>
	/// Class PBKDF2PasswordHasher. This class cannot be inherited.
	/// </summary>
	public static class PBKDF2PasswordHasher
	{
		// In .NET Core 2.1, you can use CryptographicOperations.FixedTimeEquals
		// https://github.com/dotnet/runtime/blob/419e949d258ecee4c40a460fb09c66d974229623/src/libraries/System.Security.Cryptography.Primitives/src/System/Security/Cryptography/CryptographicOperations.cs#L32
		/// <summary>
		/// Fixes the time equals.
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

			var returnValue = 0;

			for (var byteCount = 0; byteCount < left.Length; byteCount++)
			{
				returnValue |= left[byteCount] - right[byteCount];
			}

			return returnValue == 0;
		}

		/// <summary>
		/// Hashes a password.
		/// </summary>
		/// <param name="password">The password.</param>
		/// <returns>System.String.</returns>
		[Information(nameof(HashPassword), "David McCarter", "10/12/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "ADD JAN URL")]
		public static string HashPassword([NotNull] string password)
		{
			byte[] salt;
			byte[] bytes;

			using (var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, SaltSize, Pbkdf2IterCount, HashAlgorithmName))
			{
				salt = rfc2898DeriveBytes.Salt;
				bytes = rfc2898DeriveBytes.GetBytes(Pbkdf2SubkeyLength);
			}

			var passwordHash = new byte[1 + SaltSize + Pbkdf2SubkeyLength];
			passwordHash[0] = Version;

			Buffer.BlockCopy(salt, 0, passwordHash, 1, SaltSize);
			Buffer.BlockCopy(bytes, 0, passwordHash, 1 + SaltSize, Pbkdf2SubkeyLength);

			return Convert.ToBase64String(passwordHash);
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

			var passwordBytes = Convert.FromBase64String(hashedPassword);

			if (passwordBytes.Length < 1)
			{
				return PasswordVerificationResult.Failed;
			}

			var version = passwordBytes[0];

			if (version > Version)
			{
				return PasswordVerificationResult.Failed;
			}

			var salt = new byte[SaltSize];

			Buffer.BlockCopy(passwordBytes, 1, salt, 0, SaltSize);
			var subKey = new byte[Pbkdf2SubkeyLength];

			Buffer.BlockCopy(passwordBytes, 1 + SaltSize, subKey, 0, Pbkdf2SubkeyLength);

			byte[] bytes;

			using (var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, salt, Pbkdf2IterCount, HashAlgorithmName))
			{
				bytes = rfc2898DeriveBytes.GetBytes(Pbkdf2SubkeyLength);
			}

			return FixedTimeEquals(subKey, bytes) ? PasswordVerificationResult.Success : PasswordVerificationResult.Failed;
		}

		/// <summary>
		/// Gets the name of the hash algorithm.
		/// </summary>
		/// <value>The name of the hash algorithm.</value>
		public static HashAlgorithmName HashAlgorithmName { get; } = HashAlgorithmName.SHA256;

		/// <summary>
		/// Gets the PBKDF2 Iter count.
		/// </summary>
		/// <value>The PBKDF2 iter count.</value>
		public static int Pbkdf2IterCount { get; } = 50000;

		/// <summary>
		/// Gets the length of the PBKDF2 subkey.
		/// </summary>
		/// <value>The length of the PBKDF2 subkey.</value>
		public static int Pbkdf2SubkeyLength { get; } = 256 / 8; // 256 bits

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
