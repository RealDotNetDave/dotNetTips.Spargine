// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 08-01-2022
// ***********************************************************************
// <copyright file="StringExtensionsCounterBenchmark.cs" company="DotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Globalization;
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

		/// <summary>
		/// The test character
		/// </summary>
		private readonly char _testCharacter = RandomData.GenerateCharacter();

		/// <summary>
		/// The CRLF string
		/// </summary>
		private string _crlfString;

		/// <summary>
		/// Computes the m d5 hash.
		/// </summary>
		[Benchmark(Description = nameof(StringExtensions.ComputeSHA256Hash))]
		public void ComputeMD5Hash()
		{
			var result = this.LongTestString.ComputeSha256Hash();

			Consumer.Consume(result);
		}

		/// <summary>
		/// Concat01s this instance.
		/// </summary>
		[Benchmark(Description = nameof(StringExtensions.Concat))]
		public void Concat()
		{
			var result = this.StringToTrim.Clone<string>().Concat(",", Tristate.True, this.GetStringArray(10, 15, 20));

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.SplitLines))]
		public void SplitLines()
		{
			foreach (LineSplitEntry line in this._crlfString.SplitLines())
			{
				Consumer.Consume(line.Line.ToString());
			}
		}

		/// <summary>
		/// Determines whether this instance contains any.
		/// </summary>
		[Benchmark(Description = nameof(StringExtensions.ContainsAny))]
		public void ContainsAny()
		{
			var result = this.LongTestString.ContainsAny(Convert.ToChar("A", CultureInfo.InvariantCulture), Convert.ToChar("Z", CultureInfo.InvariantCulture));

			Consumer.Consume(result);
		}

		/// <summary>
		/// Defaults if null.
		/// </summary>
		[Benchmark(Description = nameof(StringExtensions.DefaultIfNull))]
		public void DefaultIfNull()
		{
			var result = this.StringToTrim.DefaultIfNull();

			Consumer.Consume(result);
		}

		/// <summary>
		/// Defaults if null or empty.
		/// </summary>
		[Benchmark(Description = nameof(StringExtensions.DefaultIfNullOrEmpty))]
		public void DefaultIfNullOrEmpty()
		{
			var result = this.StringToTrim.DefaultIfNullOrEmpty("David");

			Consumer.Consume(result);
		}

		/// <summary>
		/// Equalses the ignore case.
		/// </summary>
		[Benchmark(Description = nameof(StringExtensions.EqualsIgnoreCase))]
		public void EqualsIgnoreCase()
		{
			var result = this.String10Characters01.EqualsIgnoreCase(this.String15Characters01);

			Consumer.Consume(result);
		}

		/// <summary>
		/// Equalses the or both null or empty.
		/// </summary>
		[Benchmark(Description = nameof(StringExtensions.EqualsOrBothNullOrEmpty))]
		public void EqualsOrBothNullOrEmpty()
		{
			var result = this.String10Characters01.EqualsOrBothNullOrEmpty(this.String15Characters01);

			Consumer.Consume(result);
		}

		/// <summary>
		/// Froms the base64.
		/// </summary>
		[Benchmark(Description = nameof(StringExtensions.FromBase64) + ":" + nameof(StringExtensions.ToBase64))]
		public void FromBase64()
		{
			var result = this.Base64String.FromBase64();

			Consumer.Consume(result);
		}

		/// <summary>
		/// Determines whether this instance has value.
		/// </summary>
		[Benchmark(Description = nameof(StringExtensions.HasValue))]
		public void HasValue()
		{
			var result = this.StringToTrim.HasValue();

			Consumer.Consume(result);
		}

		/// <summary>
		/// Indents this instance.
		/// </summary>
		[Benchmark(Description = nameof(StringExtensions.Indent))]
		public void Indent()
		{
			var result = this.StringToTrim.Indent(10, '>');

			Consumer.Consume(result);
		}

		/// <summary>
		/// Determines whether [is ASCII digit].
		/// </summary>
		[Benchmark(Description = nameof(StringExtensions.IsAsciiDigit))]
		[BenchmarkCategory(Categories.Strings)]
		public void IsAsciiDigit()
		{
			var result = this._testCharacter.IsAsciiDigit();

			Consumer.Consume(result);
		}

		/// <summary>
		/// Determines whether [is ASCII letter].
		/// </summary>
		[Benchmark(Description = nameof(StringExtensions.IsAsciiLetter))]
		public void IsAsciiLetter()
		{
			var result = this._testCharacter.IsAsciiLetter();

			Consumer.Consume(result);
		}

		/// <summary>
		/// Determines whether [is ASCII letter or digit].
		/// </summary>
		[Benchmark(Description = nameof(StringExtensions.IsAsciiLetterOrDigit))]
		public void IsAsciiLetterOrDigit()
		{
			var result = this._testCharacter.IsAsciiLetterOrDigit();

			Consumer.Consume(result);
		}

		/// <summary>
		/// Determines whether [is ASCII whitespace].
		/// </summary>
		[Benchmark(Description = nameof(StringExtensions.IsAsciiWhitespace))]
		[BenchmarkCategory(Categories.Strings)]
		public void IsAsciiWhitespace()
		{
			var result = this._testCharacter.IsAsciiDigit();

			Consumer.Consume(result);
		}

		/// <summary>
		/// Determines whether this instance is guid01.
		/// </summary>
		[Benchmark(Description = nameof(StringExtensions.IsGuid))]
		public void IsGuid01()
		{
			var guid = this.TestGuid.ToString();
			var result = guid.IsGuid();

			Consumer.Consume(result);
		}

		/// <summary>
		/// Determines whether [is mac address].
		/// </summary>
		[Benchmark(Description = nameof(StringExtensions.IsMacAddress))]
		public void IsMacAddress()
		{
			var result = MacAddress.IsMacAddress();

			Consumer.Consume(result);
		}

		private const string MacAddress = "00:1A:C2:7B:00:47";

		/// <summary>
		/// Removes the CRL F01.
		/// </summary>
		[Benchmark(Description = nameof(StringExtensions.RemoveCRLF))]
		public void RemoveCRLF01()
		{
			var result = this._crlfString.RemoveCRLF();

			Consumer.Consume(result);
		}

		/// <summary>
		/// Setups this instance.
		/// </summary>
		public override void Setup()
		{
			base.Setup();

			this._crlfString = RandomData.GenerateWord(10) + ControlChars.CRLF + RandomData.GenerateWord(10) + ControlChars.CRLF + RandomData.GenerateWord(10) + ControlChars.CRLF;
		}

		/// <summary>
		/// Startses the with ordinal.
		/// </summary>
		[Benchmark(Description = nameof(StringExtensions.StartsWithOrdinal))]
		public void StartsWithOrdinal()
		{
			var result = this.String10Characters01.StartsWithOrdinal(this.String15Characters01);

			Consumer.Consume(result);
		}

		/// <summary>
		/// Startses the with ordinal ignore case.
		/// </summary>
		[Benchmark(Description = nameof(StringExtensions.StartsWithOrdinalIgnoreCase))]
		public void StartsWithOrdinalIgnoreCase()
		{
			var result = this.String10Characters01.StartsWithOrdinalIgnoreCase(this.String15Characters01);

			Consumer.Consume(result);
		}

		/// <summary>
		/// Substrings the trim.
		/// </summary>
		[Benchmark(Description = nameof(StringExtensions.SubstringTrim))]
		public void SubstringTrim()
		{
			var result = this.StringToTrim.SubstringTrim(25, 25);

			Consumer.Consume(result);
		}

		/// <summary>
		/// Converts to titlecase.
		/// </summary>
		[Benchmark(Description = nameof(StringExtensions.ToTitleCase))]
		public void ToTitleCase()
		{
			Consumer.Consume(this.LowerCaseString.ToTitleCase());
		}

		/// <summary>
		/// Converts to trimmedstring.
		/// </summary>
		[Benchmark(Description = nameof(StringExtensions.ToTrimmed))]
		public void ToTrimmedString()
		{
			var result = this.StringToTrim.ToTrimmed();

			Consumer.Consume(result);
		}

	}
}
