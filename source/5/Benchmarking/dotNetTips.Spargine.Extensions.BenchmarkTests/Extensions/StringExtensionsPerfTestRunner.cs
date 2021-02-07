// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-02-2021
// ***********************************************************************
// <copyright file="StringExtensionsPerfTestRunner.cs" company="dotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using BenchmarkDotNet.Attributes;
using dotNetTips.Spargine.Benchmarking;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Tester;

namespace dotNetTips.Spargine.Extensions.BenchmarkTests
{
	[BenchmarkCategory(nameof(StringExtensions))]
	public class StringExtensionsPerfTestRunner : PerfTestRunner
	{

		private string _commaDelimitedString;
		private string _stringToTrim;

		[Benchmark(Description = nameof(StringExtensions.ComputeSHA256Hash))]
		public void ComputeMD5Hash()
		{
			var result = this.LongTestString.ComputeSha256Hash();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.Concat))]
		public void Concat()
		{
			var result = this.LongTestString.Concat(",", Tristate.True, "TEST1", "TEST2");

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.ContainsAny))]
		public void ContainsAny()
		{
			var result = this.LongTestString.ContainsAny("A", "Z");

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.DefaultIfNull))]
		public void DefaultIfNull()
		{
			var result = this.LongTestString.DefaultIfNull();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.DefaultIfNullOrEmpty))]
		public void DefaultIfNullOrEmpty()
		{
			var result = this.LongTestString.DefaultIfNullOrEmpty("David");

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.DelimitedStringToArray))]
		public void DelimitedStringToArray()
		{
			var result = this._commaDelimitedString.DelimitedStringToArray();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.EqualsIgnoreCase))]
		public void EqualsIgnoreCase()
		{
			var result = RandomData.GenerateWord(10).EqualsIgnoreCase(RandomData.GenerateWord(5));

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.EqualsOrBothNullOrEmpty))]
		public void EqualsOrBothNullOrEmpty()
		{
			var result = RandomData.GenerateWord(10).EqualsOrBothNullOrEmpty(RandomData.GenerateWord(5));

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.FromBase64) + ":" + nameof(StringExtensions.ToBase64))]
		public void FromBase64()
		{
			var base64 = RandomData.GenerateWord(100).ToBase64();

			var result = base64.FromBase64();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.HasValue))]
		public void HasValue()
		{
			var result = this.LongTestString.HasValue();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.Indent))]
		public void Indent()
		{
			var result = this.LongTestString.Indent(10, '>');

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.IsAsciiLetter))]
		public void IsAsciiLetter()
		{
			var result = RandomData.GenerateCharacter().IsAsciiLetter();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.IsAsciiLetterOrDigit))]
		public void IsAsciiLetterOrDigit()
		{
			var result = RandomData.GenerateCharacter().IsAsciiLetterOrDigit();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.IsWhitespace) + ":Char")]
		public void IsWhitespaceChar()
		{
			var result = RandomData.GenerateCharacter().IsWhitespace();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.IsWhitespace) + ":String")]
		public void IsWhitespaceString()
		{
			var result = this._stringToTrim.IsWhitespace();

			base.Consumer.Consume(result);
		}

		public override void Setup()
		{
			base.Setup();
			this._commaDelimitedString = RandomData.GenerateWords(10, 5, 10).ToDelimitedString();
			this._stringToTrim = "         " + this.LongTestString + "                   ";
		}

		[Benchmark(Description = nameof(StringExtensions.Split) + ":Char Separator")]
		public void SplitCharSeparator()
		{
			var result = this._commaDelimitedString.Split(ControlChars.Comma, StringSplitOptions.None);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.Split) + ":Char Separator-Count")]
		public void SplitCharSeparatorCount()
		{
			var result = this._commaDelimitedString.Split(ControlChars.Comma, 2, StringSplitOptions.None);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.Split) + ":Char Separator-RemoveEmptyEntries")]
		public void SplitCharSeparatorRemoveEmptyEntries()
		{
			var result = this._commaDelimitedString.Split(ControlChars.Comma, StringSplitOptions.RemoveEmptyEntries);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.Split) + ":Char Separator-Count-RemoveEmptyEntries")]
		public void SplitCharSeparatorRemoveEmptyEntriesCount()
		{
			var result = this._commaDelimitedString.Split(ControlChars.Comma, 2, StringSplitOptions.RemoveEmptyEntries);

			base.Consumer.Consume(result);
		}

		///new
		[Benchmark(Description = nameof(StringExtensions.Split) + ":String Separator")]
		public void SplitStringSeparator()
		{
			var result = this._commaDelimitedString.Split(",", StringSplitOptions.None);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.Split) + ":String Separator-Count")]
		public void SplitStringSeparatorCount()
		{
			var result = this._commaDelimitedString.Split(",", 2, StringSplitOptions.None);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.Split) + ":String Separator-RemoveEmptyEntries")]
		public void SplitStringSeparatorRemoveEmptyEntries()
		{
			var result = this._commaDelimitedString.Split(",", StringSplitOptions.RemoveEmptyEntries);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.Split) + ":String Separator-Count-RemoveEmptyEntries")]
		public void SplitStringSeparatorRemoveEmptyEntriesCount()
		{
			var result = this._commaDelimitedString.Split(",", 2, StringSplitOptions.RemoveEmptyEntries);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.StartsWithOrdinal))]
		public void StartsWithOrdinal()
		{
			var result = RandomData.GenerateWord(10).StartsWithOrdinal(RandomData.GenerateWord(5));

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.StartsWithOrdinalIgnoreCase))]
		public void StartsWithOrdinalIgnoreCase()
		{
			var result = RandomData.GenerateWord(10).StartsWithOrdinalIgnoreCase(RandomData.GenerateWord(5));

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.SubstringTrim))]
		public void SubstringTrim()
		{
			var result = RandomData.GenerateWord(100).SubstringTrim(25, 25);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.ToTitleCase))]
		public void ToTitleCase()
		{
			var words = RandomData.GenerateWords(10, 10, 10)
				.ToDelimitedString(ControlChars.Space);

			base.Consumer.Consume(words.ToTitleCase());
		}

		[Benchmark(Description = nameof(StringExtensions.ToTrimmed))]
		public void ToTrimmedString()
		{
			var result = this._stringToTrim.ToTrimmed();

			base.Consumer.Consume(result);
		}

	}
}
