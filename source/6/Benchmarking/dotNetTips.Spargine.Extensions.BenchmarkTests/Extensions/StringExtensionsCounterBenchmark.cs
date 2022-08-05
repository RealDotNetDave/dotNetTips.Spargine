// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 08-04-2022
// ***********************************************************************
// <copyright file="StringExtensionsCounterBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Tester;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.BenchmarkTests
{
	/// <summary>
	/// StringExtensions CounterPerfTestRunner.
	/// Implements the <see cref="CounterBenchmark" />
	/// </summary>
	/// <seealso cref="CounterBenchmark" />
	[BenchmarkCategory(Categories.Strings)]
	public class StringExtensionsCounterBenchmark : SmallCollectionsBenchmark
	{

		private string _base64String;
		private string _brotilString;
		private string _crlfString;
		private string _gzipString;

		[Benchmark(Description = nameof(StringExtensions.ComputeHash))]
		[BenchmarkCategory(Categories.Strings)]
		public void ComputeHash()
		{
			var result = this._crlfString.ComputeHash();

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.ComputeSHA256Hash))]
		[BenchmarkCategory(Categories.Strings)]
		public void ComputeSHA256Hash()
		{
			var result = this._crlfString.ComputeSha256Hash();

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.ContainsAny))]
		[BenchmarkCategory(Categories.Strings)]
		public void ContainsAny()
		{
			var result = this._crlfString.ContainsAny(Convert.ToChar("A", CultureInfo.InvariantCulture), Convert.ToChar("Z", CultureInfo.InvariantCulture));

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.DelimitedStringToArray))]
		[BenchmarkCategory(Categories.Strings, Categories.New)]
		public void DelimitedStringToArray()
		{
			var result = this._crlfString.DelimitedStringToArray(ControlChars.Dot);

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.EqualsIgnoreCase))]
		[BenchmarkCategory(Categories.Strings)]
		public void EqualsIgnoreCase()
		{
			var result = this._crlfString.EqualsIgnoreCase(this._crlfString);

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.EqualsOrBothNullOrEmpty))]
		[BenchmarkCategory(Categories.Strings)]
		public void EqualsOrBothNullOrEmpty()
		{
			var result = this._crlfString.EqualsOrBothNullOrEmpty(this._crlfString);

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.FromBase64))]
		[BenchmarkCategory(Categories.Strings)]
		public void FromBase64()
		{
			var result = this._base64String.FromBase64();

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.FromBrotliAsync))]
		[BenchmarkCategory(Categories.New, Categories.Strings, Categories.Async)]
		public async Task FromBrotliAsync()
		{
			var result = await this._brotilString.FromBrotliAsync().ConfigureAwait(false);

			this.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.FromGZipAsync))]
		[BenchmarkCategory(Categories.New, Categories.Strings, Categories.Async)]
		public async Task FromGZipAsync()
		{
			var result = await this._gzipString.FromGZipAsync().ConfigureAwait(false);

			this.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.GetHashCode))]
		[BenchmarkCategory(Categories.New, Categories.Strings)]
#pragma warning disable CS0114 // Member hides inherited member; missing override keyword
		public void GetHashCode()
#pragma warning restore CS0114 // Member hides inherited member; missing override keyword
		{
			var result = this._crlfString.GetHashCode();

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.RemoveCRLF))]
		[BenchmarkCategory(Categories.Strings)]
		public void RemoveCRLF01()
		{
			var testString = this._crlfString.Clone<string>();

			var result = testString.RemoveCRLF();

			Consumer.Consume(result);
		}

		public override void Setup()
		{
			base.Setup();

			//Create lines of text.
			var sb = new StringBuilder();

			for (var lineCount = 0; lineCount < this.Count; lineCount++)
			{
				sb.AppendLine(
					RandomData.GenerateWord(10) +
						ControlChars.Space +
						RandomData.GenerateWord(10) + ControlChars.Space +
						RandomData.GenerateWord(10) + ControlChars.Space +
						RandomData.GenerateWord(10) + ControlChars.Space +
						RandomData.GenerateWord(10) +
						ControlChars.Dot);
			}

			this._crlfString = sb.ToString();

			this._brotilString = this._crlfString.ToBrotliAsync().Result;

			this._gzipString = this._crlfString.ToGZipAsync().Result;

			this._base64String = this._crlfString.ToBase64();
		}

		[Benchmark(Description = "Split")]
		[BenchmarkCategory(Categories.ForComparison)]
		public void Split()
		{
			foreach (var line in this._crlfString.Split(ControlChars.CRLF))
			{
				Consumer.Consume(line);
			}
		}

		[Benchmark(Description = nameof(StringExtensions.SplitLines))]
		[BenchmarkCategory(Categories.Strings)]
		public void SplitLines()
		{
			foreach (LineSplitEntry line in this._crlfString.SplitLines())
			{
				Consumer.Consume(line.Line.ToString());
			}
		}

		[Benchmark(Description = nameof(StringExtensions.SplitRemoveEmpty))]
		[BenchmarkCategory(Categories.Strings)]
		public void SplitRemoveEmpty()
		{
			foreach (var line in this._crlfString.SplitRemoveEmpty())
			{
				Consumer.Consume(line);
			}
		}

		[Benchmark(Description = nameof(StringExtensions.Split) + ": RemoveEmptyEntries")]
		[BenchmarkCategory(Categories.Strings)]
		public void SplitWithRemoveEmptyEntries()
		{
			foreach (var line in this._crlfString.Split(StringSplitOptions.RemoveEmptyEntries, ControlChars.Dot))
			{
				Consumer.Consume(line);
			}
		}

		[Benchmark(Description = nameof(StringExtensions.Split) + ": TrimEntries")]
		[BenchmarkCategory(Categories.Strings)]
		public void SplitWithTrimEntries()
		{
			foreach (var line in this._crlfString.Split(StringSplitOptions.TrimEntries, ControlChars.Dot))
			{
				Consumer.Consume(line);
			}
		}

		[Benchmark(Description = nameof(StringExtensions.Split) + ": TrimEntries + Count")]
		[BenchmarkCategory(Categories.Strings)]
		public void SplitWithTrimEntriesCount()
		{
			foreach (var line in this._crlfString.Split(StringSplitOptions.TrimEntries, 10, ControlChars.Dot))
			{
				Consumer.Consume(line);
			}
		}

		[Benchmark(Description = nameof(StringExtensions.ToBase64))]
		[BenchmarkCategory(Categories.Strings)]
		public void ToBase64()
		{
			var result = this.LongTestString.ToBase64();

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.ToBrotliAsync))]
		[BenchmarkCategory(Categories.New, Categories.Strings)]
		public async Task ToBrotliAsync()
		{
			var result = await this._crlfString.ToBrotliAsync().ConfigureAwait(false);

			this.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.ToGZipAsync))]
		[BenchmarkCategory(Categories.New, Categories.Strings)]
		public async Task ToGZipAsync()
		{
			var result = await this._crlfString.ToGZipAsync().ConfigureAwait(false);

			this.Consumer.Consume(result);
		}

	}
}
