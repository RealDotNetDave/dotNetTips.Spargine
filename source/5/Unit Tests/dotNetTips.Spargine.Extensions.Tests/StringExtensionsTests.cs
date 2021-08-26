// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 05-31-2021
// ***********************************************************************
// <copyright file="StringExtensionsTests.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Extensions.Tests
{
	[ExcludeFromCodeCoverage]
	[TestClass]
	public class StringExtensionsTests
	{

		[TestMethod]
		public void ComputeHashTest()
		{
			var word = RandomData.GenerateWord(100);

			foreach (var item in Enum.GetValues(typeof(HashType)))
			{
				var result = word.ComputeHash((HashType)item);

				Assert.IsTrue(result.IsNotEmpty());
			}
		}

		[TestMethod]
		public void ComputeSha256HashTest()
		{
			var testValue = RandomData.GenerateWord(10);

			Assert.IsTrue(string.IsNullOrEmpty(testValue.ComputeSHA256Hash()) == false);
		}

		[TestMethod]
		public void ConcatTest()
		{
			var testValue1 = RandomData.GenerateWord(10);
			var testValue2 = RandomData.GenerateWord(15);

			Assert.IsTrue(string.IsNullOrEmpty(testValue1.Concat("-", Tristate.False, testValue2)) == false);

			Assert.IsTrue(string.IsNullOrEmpty(testValue1.Concat("-", Tristate.True, testValue2)) == false);

			Assert.IsTrue(testValue1.Concat("-", Tristate.False, testValue2).Length == 26);
		}

		[TestMethod]
		public void ContainsAnyTest()
		{
			var testValue = "dotNetTips.com";

			Assert.IsTrue(testValue.ContainsAny("d", "T"));

			Assert.IsFalse(testValue.ContainsAny());

			Assert.IsFalse(string.Empty.ContainsAny("M", "D"));
		}

		[TestMethod]
		public void DefaultIfNullOrEmptyTest()
		{
			string testValue = null;

			Assert.IsTrue(testValue.DefaultIfNullOrEmpty(RandomData.GenerateWord(5)).Length == 5);
		}

		[TestMethod]
		public void DefaultIfNullTest()
		{
			string testValue = null;

			Assert.IsTrue(testValue.DefaultIfNull().Length == 0);

			Assert.IsTrue(testValue.DefaultIfNull(RandomData.GenerateWord(5)).Length == 5);
		}

		[TestMethod]
		public void DelimitedStringToArrayTest()
		{
			var inputString = "Microsoft .NET, Visual Studio, Azure";

			var result = inputString.DelimitedStringToArray();

			Assert.IsTrue(result.Count() == 3);

			Assert.IsTrue(result.Count() == 3);
		}

		[TestMethod]
		public void EqualsIgnoreCaseTest()
		{
			var testValue = RandomData.GenerateWord(10);

			Assert.IsTrue(testValue.EqualsIgnoreCase(testValue));
		}

		[TestMethod]
		public void EqualsOrBothNullOrEmptyTest()
		{
			var testValue = RandomData.GenerateWord(10);

			Assert.IsTrue(testValue.EqualsOrBothNullOrEmpty(testValue));

			Assert.IsTrue(string.Empty.EqualsOrBothNullOrEmpty(null));
		}

		[TestMethod]
		public void ExtractTest()
		{
			var inputString = "Microsoft .NET, Visual Studio, Azure";

			var result = inputString.Extract("Micro", "V");

			Assert.IsTrue(result.HasValue());
		}

		[TestMethod]
		public void FromBase64Test()
		{
			var testValue = RandomData.GenerateWord(25);

			Assert.IsTrue(testValue.ToBase64().FromBase64().IsNotEmpty());

			Assert.IsTrue(string.Empty.ToBase64().FromBase64().IsEmpty());
		}

		[TestMethod]
		public void HasValueTest()
		{
			var testValue = RandomData.GenerateWord(10);

			Assert.IsTrue(testValue.HasValue());

			Assert.IsTrue(testValue.HasValue(10));

			_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => testValue.HasValue(-100));

			Assert.IsTrue(testValue.HasValue(1, 10));

			_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => testValue.HasValue(-10, 500));

			_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => testValue.HasValue(12, -10));

			Assert.IsFalse(testValue.HasValue("XXXXX"));

			//Test Regex
			var email = "dotnetdave@live.com";
			Assert.IsTrue(email.HasValue(@"([a-zA-Z0-9+._-]+@[a-zA-Z0-9._-]+\.[a-zA-Z0-9_-]+)", RegexOptions.IgnoreCase));

			Assert.IsFalse("David".HasValue(string.Empty, RegexOptions.IgnoreCase));
		}

		[TestMethod]
		public void HasWhiteSpaceTest()
		{
			var testWithText = RandomData.GenerateWord(10);
			var testWithWhitespace = "      ";

			Assert.IsFalse(testWithText.HasWhitespace());
			Assert.IsTrue(testWithWhitespace.HasWhitespace());
			Assert.IsTrue(' '.IsAsciiWhitespace());
			Assert.IsFalse('d'.IsAsciiWhitespace());
		}

		[TestMethod]
		public void IndentTest()
		{
			var testValue = RandomData.GenerateWord(100);

			var result = testValue.Indent(2, '>');

			Assert.IsTrue(result.Length > 90);

			result = testValue.Indent(0, '>');

			Assert.IsTrue(result.Length > 90);
		}

		[TestMethod]
		public void IsAsciiLetterOrDigitTest()
		{
			Assert.IsTrue('A'.IsAsciiLetterOrDigit());

			Assert.IsTrue('1'.IsAsciiLetterOrDigit());
		}

		[TestMethod]
		public void IsAsciiLetterTest()
		{
			Assert.IsTrue('A'.IsAsciiLetter());
		}


		[TestMethod]
		public void IsCreditCardTest()
		{
			Assert.IsFalse("123".IsCreditCard());
		}

		[TestMethod]
		public void IsDigitTest()
		{
			Assert.IsTrue('1'.IsAsciiDigit());

			Assert.IsFalse('A'.IsAsciiDigit());
		}

		[TestMethod]
		public void IsDomainAddressTest()
		{
			Assert.IsTrue("dotnettips.com".IsDomainAddress());
		}

		[TestMethod]
		public void IsEmailAddressTest()
		{
			Assert.IsTrue("dotnetdave@live.com".IsEmailAddress());
		}

		[TestMethod]
		public void IsEmptyTest()
		{
			Assert.IsFalse(RandomData.GenerateWord(10).IsEmpty());

			Assert.IsTrue(string.Empty.IsEmpty());
		}

		[TestMethod]
		public void IsFirstLastNameTest()
		{
			Assert.IsTrue("David McCarter".IsFirstLastName());
		}

		[TestMethod]
		public void IsISBNTest()
		{
			Assert.IsTrue("1257561035".IsISBN());
		}

		[TestMethod]
		public void IsNotEmptyTest()
		{
			Assert.IsTrue(RandomData.GenerateWord(10).IsNotEmpty());

			Assert.IsFalse(string.Empty.IsNotEmpty());
		}

		[TestMethod]
		public void IsScientificTest()
		{
			Assert.IsFalse("6.5 ✕ 10^8".IsScientific());
		}

		[TestMethod]
		public void IsStringSHA1Hash()
		{
			var hash = RandomData.GenerateWord(100).ComputeHash(HashType.SHA1);

			Assert.IsFalse(string.Empty.IsStringSHA1Hash());

			Assert.IsTrue(hash.IsStringSHA1Hash());

		}

		[TestMethod]
		public void IsStringTest()
		{
			Assert.IsTrue("979-8589711707".IsString());
		}

		[TestMethod]
		public void IsUrlTest()
		{
			Assert.IsTrue("http://dotnettips.com".IsUrl());
		}

		[TestMethod]
		public void IsWhiteSpaceTest()
		{
			Assert.IsTrue("      ".HasWhitespace());

			Assert.IsTrue(ControlChars.Space.IsAsciiWhitespace());

			Assert.IsFalse("David".HasWhitespace());
		}

		[TestMethod]
		public void RemoveCRLFTest()
		{
			var testValue1 = $"{RandomData.GenerateWord(10)}{ControlChars.NewLine}{RandomData.GenerateWord(15)}{ControlChars.CRLF}{RandomData.GenerateWord(15)}";

			var testValue2 = $"{RandomData.GenerateWord(15)}{RandomData.GenerateWord(25)}";

			var result1 = testValue1.RemoveCRLF(replacement: ".");
			var result2 = testValue2.RemoveCRLF();

			Assert.IsTrue(result1.Contains(ControlChars.NewLine) == false);
			Assert.IsTrue(result1.Contains(ControlChars.CRLF) == false);
			Assert.IsTrue(result1.Contains(ControlChars.CR) == false);

			Assert.IsTrue(result2.Contains(ControlChars.NewLine) == false);
			Assert.IsTrue(result2.Contains(ControlChars.CRLF) == false);
			Assert.IsTrue(result2.Contains(ControlChars.CR) == false);

			Assert.IsTrue(string.IsNullOrEmpty(string.Empty.RemoveCRLF()));
		}

		[TestMethod]
		public void ReplaceEllipsisWithPeriodTest()
		{
			var testValue = $"{RandomData.GenerateWord(25)}...";

			var result = testValue.ReplaceEllipsisWithPeriod();

			Assert.IsTrue(result.EndsWith("...") == false);

			Assert.IsTrue(string.IsNullOrEmpty(string.Empty.ReplaceEllipsisWithPeriod()));
		}

		[TestMethod]
		public void SplitRemoveEmptyTest()
		{
			var testValue = $"{RandomData.GenerateWord(25)},{RandomData.GenerateWord(25)}";

			Assert.IsTrue(testValue.SplitRemoveEmpty().Count() > 1);
		}

		[TestMethod]
		public void SplitTest()
		{
			var testValue = $"{RandomData.GenerateWord(25)},{RandomData.GenerateWord(25)}";

			Assert.IsTrue(testValue.Split(',', options: StringSplitOptions.RemoveEmptyEntries).Count() == 2);

			Assert.IsTrue(testValue.Split(',', count: 2, options: StringSplitOptions.RemoveEmptyEntries).Count() == 2);
		}

		[TestMethod]
		public void SplitWithCharAndCountTest()
		{
			var testValue = $"coding, programming, microsoft";

			var result = testValue.Split(',', 2, StringSplitOptions.RemoveEmptyEntries);

			Assert.IsTrue(result.Count() == 2);

			result = testValue.Split(',', 1, StringSplitOptions.None);

			Assert.IsTrue(result.Count() == 1);
		}

		[TestMethod]
		public void SplitWithCharTest()
		{
			var testValue = $"coding, programming, microsoft";

			var result = testValue.Split(',', StringSplitOptions.RemoveEmptyEntries);

			Assert.IsTrue(result.Count() == 3);

			result = testValue.Split(',', StringSplitOptions.None);

			Assert.IsTrue(result.Count() == 3);
		}

		[TestMethod]
		public void SplitWithStringAndCountTest()
		{
			var testValue = $"coding, programming, microsoft";

			var result = testValue.Split(",", 2, StringSplitOptions.RemoveEmptyEntries);

			Assert.IsTrue(result.Count() == 2);

			result = testValue.Split(",", 1, StringSplitOptions.None);

			Assert.IsTrue(result.Count() == 1);
		}

		[TestMethod]
		public void SplitWithStringTest()
		{
			var testValue = $"coding, programming, microsoft";

			var result = testValue.Split(",", StringSplitOptions.RemoveEmptyEntries);

			Assert.IsTrue(result.Count() == 3);

			result = testValue.Split(",", StringSplitOptions.None);

			Assert.IsTrue(result.Count() == 3);
		}

		[TestMethod]
		public void StartsWithOrdinalIgnoreCaseTest()
		{
			var testValue = RandomData.GenerateWord(10);

			Assert.IsTrue(testValue.StartsWithOrdinalIgnoreCase(testValue));

			Assert.IsFalse(string.Empty.StartsWithOrdinalIgnoreCase("David"));
		}

		[TestMethod]
		public void StartsWithOrdinalTest()
		{
			var testValue = RandomData.GenerateWord(10);

			Assert.IsTrue(testValue.StartsWithOrdinal(testValue));
		}

		[TestMethod]
		public void SubstringTrimTest()
		{
			var testValue = RandomData.GenerateWord(50);

			//Test parameters
			_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => testValue.SubstringTrim(-100, 10));
			_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => testValue.SubstringTrim(1, -10));
			_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => testValue.SubstringTrim(1, 100));

			//Test
			Assert.IsTrue(testValue.SubstringTrim(1, 10).HasValue());
		}

		[TestMethod]
		public void ToBase64Test()
		{
			var testValue = RandomData.GenerateWord(25);

			Assert.IsTrue(testValue.ToBase64().IsNotEmpty());
		}

		[TestMethod]
		public void ToTitleCaseTest()
		{
			var words = RandomData.GenerateWords(10, 10, 10)
				.ToDelimitedString(ControlChars.Space);

			var testValue = words.ToTitleCase();

			Assert.IsTrue(testValue.IsNotEmpty());
		}

		[TestMethod]
		public void TrimTest()
		{
			var testValue = $"{RandomData.GenerateWord(25)}   ";

			Assert.IsTrue(testValue.ToTrimmed().Length == 25);
		}

	}
}
