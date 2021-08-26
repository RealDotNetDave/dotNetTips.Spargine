﻿// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 08-24-2021
// ***********************************************************************
// <copyright file="StringExtensionsCounterBenchmark.cs" company="dotNetTips.Spargine.Extensions.BenchmarkTests">
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
	/// <summary>
	/// StringExtensions CounterPerfTestRunner.
	/// Implements the <see cref="CounterBenchmark" />
	/// </summary>
	/// <seealso cref="CounterBenchmark" />
	[BenchmarkCategory(Categories.Strings)]
	public class StringExtensionsCounterBenchmark : CounterBenchmark
	{

		private readonly char _testCharacter = RandomData.GenerateCharacter();

		private string _crlfString;

		[Benchmark(Description = nameof(StringExtensions.ComputeSHA256Hash))]
		public void ComputeMD5Hash()
		{
			var result = this.StringToTrim.ComputeSha256Hash();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.Concat))]
		public void Concat01()
		{
			var result = this.StringToTrim.Concat(",", Tristate.True, this.StringArray);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.ContainsAny))]
		public void ContainsAny()
		{
			var result = this.StringToTrim.ContainsAny("A", "Z");

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.DefaultIfNull))]
		public void DefaultIfNull()
		{
			var result = this.StringToTrim.DefaultIfNull();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.DefaultIfNullOrEmpty))]
		public void DefaultIfNullOrEmpty()
		{
			var result = this.StringToTrim.DefaultIfNullOrEmpty("David");

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.DelimitedStringToArray))]
		public void DelimitedStringToArray()
		{
			var result = this.CommaDelimitedString.DelimitedStringToArray();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.EqualsIgnoreCase))]
		public void EqualsIgnoreCase()
		{
			var result = this.String10Characters01.EqualsIgnoreCase(this.String15Characters01);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.EqualsOrBothNullOrEmpty))]
		public void EqualsOrBothNullOrEmpty()
		{
			var result = this.String10Characters01.EqualsOrBothNullOrEmpty(this.String15Characters01);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.FromBase64) + ":" + nameof(StringExtensions.ToBase64))]
		public void FromBase64()
		{
			var result = this.Base64String.FromBase64();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.HasValue))]
		public void HasValue()
		{
			var result = this.StringToTrim.HasValue();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.Indent))]
		public void Indent()
		{
			var result = this.StringToTrim.Indent(10, '>');

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.IsAsciiDigit))]
		[BenchmarkCategory(Categories.New)]
		public void IsAsciiDigit()
		{
			var result = this._testCharacter.IsAsciiDigit();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.IsAsciiLetter))]
		public void IsAsciiLetter()
		{
			var result = this._testCharacter.IsAsciiLetter();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.IsAsciiLetterOrDigit))]
		public void IsAsciiLetterOrDigit()
		{
			var result = this._testCharacter.IsAsciiLetterOrDigit();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.IsAsciiWhitespace))]
		[BenchmarkCategory(Categories.New)]
		public void IsAsciiWhitespace()
		{
			var result = this._testCharacter.IsAsciiDigit();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.IsGuid))]
		public void IsGuid01()
		{
			var guid = Guid.NewGuid().ToString();
			var result = guid.IsGuid();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.IsMacAddress))]
		public void IsMacAddress()
		{
			var macAddress = "00:1A:C2:7B:00:47";
			var result = macAddress.IsGuid();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.RemoveCRLF))]
		public void RemoveCRLF01()
		{
			var result = this._crlfString.RemoveCRLF();

			base.Consumer.Consume(result);
		}

		public override void Setup()
		{
			this._crlfString = RandomData.GenerateWord(10) + ControlChars.CRLF + RandomData.GenerateWord(10) + ControlChars.CRLF + RandomData.GenerateWord(10) + ControlChars.CRLF;

			base.Setup();
		}

		[Benchmark(Description = nameof(StringExtensions.Split) + ":Char Separator:01*")]
		public void SplitCharSeparator01()
		{
			var result = this.CommaDelimitedString.Split(StringSplitOptions.None);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringBuilderHelper.ConcatToString) + ":01**")]
		public void SplitCharSeparator02()
		{
			var result = StringBuilderHelper.ConcatToString(this.CommaDelimitedString, Tristate.True, this.StringArray);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.Split) + ":Char Separator-Count")]
		public void SplitCharSeparatorCount01()
		{
			var result = this.CommaDelimitedString.Split(ControlChars.Comma, 2, StringSplitOptions.None);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.Split) + ":Char Separator-RemoveEmptyEntries")]
		public void SplitCharSeparatorRemoveEmptyEntries()
		{
			var result = this.CommaDelimitedString.Split(ControlChars.Comma, StringSplitOptions.RemoveEmptyEntries);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.Split) + ":Char Separator-Count-RemoveEmptyEntries")]
		public void SplitCharSeparatorRemoveEmptyEntriesCount()
		{
			var result = this.CommaDelimitedString.Split(ControlChars.Comma, 2, StringSplitOptions.RemoveEmptyEntries);

			base.Consumer.Consume(result);
		}

		///new
		[Benchmark(Description = nameof(StringExtensions.Split) + ":String Separator")]
		public void SplitStringSeparator()
		{
			var result = this.CommaDelimitedString.Split(",", StringSplitOptions.None);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.Split) + ":String Separator-Count")]
		public void SplitStringSeparatorCount()
		{
			var result = this.CommaDelimitedString.Split(",", 2, StringSplitOptions.None);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.Split) + ":String Separator-RemoveEmptyEntries")]
		public void SplitStringSeparatorRemoveEmptyEntries()
		{
			var result = this.CommaDelimitedString.Split(",", StringSplitOptions.RemoveEmptyEntries);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.Split) + ":String Separator-Count-RemoveEmptyEntries")]
		public void SplitStringSeparatorRemoveEmptyEntriesCount()
		{
			var result = this.CommaDelimitedString.Split(",", 2, StringSplitOptions.RemoveEmptyEntries);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.StartsWithOrdinal))]
		public void StartsWithOrdinal()
		{
			var result = this.String10Characters01.StartsWithOrdinal(this.String15Characters01);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.StartsWithOrdinalIgnoreCase))]
		public void StartsWithOrdinalIgnoreCase()
		{
			var result = this.String10Characters01.StartsWithOrdinalIgnoreCase(this.String15Characters01);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.SubstringTrim))]
		public void SubstringTrim()
		{
			var result = this.StringToTrim.SubstringTrim(25, 25);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringExtensions.ToTitleCase))]
		public void ToTitleCase()
		{
			var words = this.StringArray.ToDelimitedString(ControlChars.Space);

			base.Consumer.Consume(words.ToTitleCase());
		}

		[Benchmark(Description = nameof(StringExtensions.ToTrimmed))]
		public void ToTrimmedString()
		{
			var result = this.StringToTrim.ToTrimmed();

			base.Consumer.Consume(result);
		}

	}
}
