using BenchmarkDotNet.Attributes;
using dotNetTips.Spargine.Benchmarking;
using dotNetTips.Spargine.Core.Security;

namespace dotNetTips.Spargine.Core.BenchmarkTests.Security
{
	[BenchmarkCategory("EncryptionHelper")]
	public class EncryptionHelperBenchmark : Benchmark
	{
		private const string _key = "!&@^@%@$@#!!!";

		private string _aesCypherText;
		private byte[] _aesIv;
		private byte[] _aesKey;
		private string _cypherText = string.Empty;

		[Benchmark(Description = nameof(EncryptionHelper.AesDecrypt))]
		public void AesDecrypt()
		{
			var result = EncryptionHelper.AesEncrypt(this._aesCypherText, this._aesKey, this._aesIv);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EncryptionHelper.AesEncrypt))]
		public void AesEncrypt()
		{
			var result = EncryptionHelper.AesEncrypt(LongTestString, this._aesKey, this._aesIv);

			base.Consumer.Consume(result);
		}

		public override void Setup()
		{
			base.Setup();

			this._cypherText = EncryptionHelper.SimpleEncrypt(LongTestString, _key);
			this._aesKey = EncryptionHelper.GenerateAesKey();
			this._aesIv = EncryptionHelper.GenerateAesIV();
			this._aesCypherText = EncryptionHelper.AesEncrypt(LongTestString, this._aesKey, this._aesIv);
		}

		[Benchmark(Description = nameof(EncryptionHelper.SimpleDecrypt))]
		public void SimpleDecrypt()
		{
			var result = EncryptionHelper.SimpleDecrypt(this._cypherText, _key);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EncryptionHelper.SimpleEncrypt))]
		public void SimpleEncrypt()
		{
			var result = EncryptionHelper.SimpleEncrypt(LongTestString, _key);

			base.Consumer.Consume(result);
		}
	}
}
