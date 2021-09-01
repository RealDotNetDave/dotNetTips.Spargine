// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 07-19-2021
//
// Last Modified By : David McCarter
// Last Modified On : 08-24-2021
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

		private string _aesCypherText;
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

			this._cypherText = EncryptionHelper.SimpleEncrypt(LongTestString, Key);
			this._aesKey = EncryptionHelper.GenerateAesKey();
			this._aesIv = EncryptionHelper.GenerateAesIV();
			this._aesCypherText = EncryptionHelper.AesEncrypt(LongTestString, this._aesKey, this._aesIv);
		}

		[Benchmark(Description = nameof(EncryptionHelper.SimpleDecrypt))]
		[BenchmarkCategory(Categories.Encryption)]
		public void SimpleDecrypt()
		{
			var result = EncryptionHelper.SimpleDecrypt(this._cypherText, Key);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EncryptionHelper.SimpleEncrypt))]
		[BenchmarkCategory(Categories.Encryption)]
		public void SimpleEncrypt()
		{
			var result = EncryptionHelper.SimpleEncrypt(LongTestString, Key);

			base.Consumer.Consume(result);
		}
	}
}
