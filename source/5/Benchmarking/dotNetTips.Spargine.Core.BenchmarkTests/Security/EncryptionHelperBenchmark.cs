// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 07-19-2021
//
// Last Modified By : David McCarter
// Last Modified On : 11-10-2021
// ***********************************************************************
// <copyright file="EncryptionHelperBenchmark.cs" company="dotNetTips.Spargine.Core.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using dotNetTips.Spargine.Benchmarking;
using dotNetTips.Spargine.Core.Security;

namespace dotNetTips.Spargine.Core.BenchmarkTests.Security
{
	[BenchmarkCategory(Categories.Encryption)]
	public class EncryptionHelperBenchmark : Benchmark
	{
		private const string Key = "!&@^@%@$@#!!!";
		private const string Password = "C;)jegY2h@U?[Tzj";

		private string _aesCypherText;
		private string _hashedPasswordPBKDF2;
		private string _hashedPasswordSHA256;
		private byte[] _aesIv;
		private byte[] _aesKey;
		private string _cypherText = string.Empty;

		[Benchmark(Description = nameof(EncryptionHelper.AesDecrypt))]
		[BenchmarkCategory(Categories.Encryption)]
		public void AesDecrypt()
		{
			var result = EncryptionHelper.AesEncrypt(this._aesCypherText, this._aesKey, this._aesIv);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EncryptionHelper.AesEncrypt))]
		[BenchmarkCategory(Categories.Encryption)]
		public void AesEncrypt()
		{
			var result = EncryptionHelper.AesEncrypt(LongTestString, this._aesKey, this._aesIv);

			base.Consumer.Consume(result);
		}

		public override void Setup()
		{
			base.Setup();

			this._cypherText = EncryptionHelper.SimpleSHA256Encrypt(LongTestString, Key);
			this._aesKey = EncryptionHelper.GenerateAesKey();
			this._aesIv = EncryptionHelper.GenerateAesIV();
			this._aesCypherText = EncryptionHelper.AesEncrypt(LongTestString, this._aesKey, this._aesIv);
			this._hashedPasswordPBKDF2 = EncryptionHelper.HashPasswordWithPBKDF2(Password);
			this._hashedPasswordSHA256 = EncryptionHelper.HashPasswordWithSHA256(Password);
		}

		[Benchmark(Description = nameof(EncryptionHelper.SimpleSHA256Decrypt))]
		[BenchmarkCategory(Categories.Encryption)]
		public void SimpleSHA256Decrypt()
		{
			var result = EncryptionHelper.SimpleSHA256Decrypt(this._cypherText, Key);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EncryptionHelper.SimpleSHA256Encrypt))]
		[BenchmarkCategory(Categories.Encryption)]
		public void SimpleEncrypt()
		{
			var result = EncryptionHelper.SimpleSHA256Encrypt(LongTestString, Key);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EncryptionHelper.HashPasswordWithPBKDF2))]
		[BenchmarkCategory(Categories.Encryption)]
		public void HashPasswordWithPBKDF2()
		{
			var result = EncryptionHelper.HashPasswordWithPBKDF2(Password);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EncryptionHelper.HashPasswordWithSHA256))]
		[BenchmarkCategory(Categories.Encryption)]
		public void HashPasswordWithSHA256()
		{
			var result = EncryptionHelper.HashPasswordWithSHA256(Password);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EncryptionHelper.VerifyPBKDF2HashedPassword))]
		[BenchmarkCategory(Categories.Encryption)]
		public void VerifyPBKDF2HashedPassword()
		{
			var result = EncryptionHelper.VerifyPBKDF2HashedPassword(this._hashedPasswordPBKDF2, Password);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EncryptionHelper.VerifySHA256HashedPassword))]
		[BenchmarkCategory(Categories.Encryption)]
		public void VerifySHA256HashedPassword()
		{
			var result = EncryptionHelper.VerifySHA256HashedPassword(this._hashedPasswordPBKDF2, Password);

			base.Consumer.Consume(result);
		}
	}
}
