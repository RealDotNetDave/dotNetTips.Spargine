﻿// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 07-19-2021
//
// Last Modified By : David McCarter
// Last Modified On : 04-18-2022
// ***********************************************************************
// <copyright file="EncryptionHelperBenchmark.cs" company="DotNetTips.Spargine.Core.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Security;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.BenchmarkTests.Security
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

			this._cypherText = EncryptionHelper.SimpleSHA256Encrypt(LongTestString, Key);
			this._aesKey = EncryptionHelper.GenerateAesKey();
			this._aesIv = EncryptionHelper.GenerateAesIV();
			this._aesCypherText = EncryptionHelper.AesEncrypt(LongTestString, this._aesKey, this._aesIv);
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
	}
}
