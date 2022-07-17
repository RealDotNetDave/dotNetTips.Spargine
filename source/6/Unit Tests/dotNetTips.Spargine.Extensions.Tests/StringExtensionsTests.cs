// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-05-2022
// ***********************************************************************
// <copyright file="StringExtensionsTests.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO.Compression;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions.Tests.Properties;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.Tests
{
	/// <summary>
	/// Defines test class StringExtensionsTests.
	/// </summary>
	[ExcludeFromCodeCoverage]
	[TestClass]
	public class StringExtensionsTests
	{

		/// <summary>
		/// Defines the test method ComputeHashTest.
		/// </summary>
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
		public void SplitLinesTest()
		{
			var text = Resources.TestMutipleLinesOfText;
			try
			{
				foreach (ReadOnlySpan<char> line in text.SplitLines())
				{
					Console.WriteLine(line.ToString());
				}
			}
			catch
			{
				Assert.Fail();
			}
		}

		/// <summary>
		/// Defines the test method ComputeSha256HashTest.
		/// </summary>
		[TestMethod]
		public void ComputeSha256HashTest()
		{
			var testValue = RandomData.GenerateWord(10);

			Assert.IsTrue(string.IsNullOrEmpty(testValue.ComputeSHA256Hash()) is false);
		}

		/// <summary>
		/// Defines the test method ConcatTest.
		/// </summary>
		[TestMethod]
		public void ConcatTest()
		{
			var testValue1 = RandomData.GenerateWord(10);
			var testValue2 = RandomData.GenerateWord(15);

			Assert.IsTrue(string.IsNullOrEmpty(testValue1.Concat("-", Tristate.False, testValue2)) is false);

			Assert.IsTrue(string.IsNullOrEmpty(testValue1.Concat("-", Tristate.True, testValue2)) is false);

			Assert.IsTrue(testValue1.Concat("-", Tristate.False, testValue2).Length == 26);
		}

		/// <summary>
		/// Defines the test method ContainsAnyTest.
		/// </summary>
		[TestMethod]
		public void ContainsAnyTest()
		{
			var testValue = "dotNetTips.com";

			Assert.IsTrue(testValue.ContainsAny(StringComparison.InvariantCultureIgnoreCase, "d", "T"));

			Assert.ThrowsException<ArgumentNullException>(() => string.Empty.ContainsAny(StringComparison.InvariantCultureIgnoreCase, "Z", "W"));
		}

		/// <summary>
		/// Defines the test method DefaultIfNullOrEmptyTest.
		/// </summary>
		[TestMethod]
		public void DefaultIfNullOrEmptyTest()
		{
			string testValue = null;

			Assert.IsTrue(testValue.DefaultIfNullOrEmpty(RandomData.GenerateWord(5)).Length == 5);
		}

		/// <summary>
		/// Defines the test method IsCurrencyCode.
		/// </summary>
		[TestMethod]
		public void IsCurrencyCode()
		{
			var goodCode = "USD";
			var badCode = RandomData.GenerateWord(5);

			Assert.IsTrue(goodCode.IsCurrencyCode());

			Assert.IsFalse(badCode.IsCurrencyCode());
		}

		/// <summary>
		/// Defines the test method IsOneToSevenAlphaTest.
		/// </summary>
		[TestMethod]
		public void IsOneToSevenAlphaTest()
		{
			var goodCode = RandomData.GenerateWord(7);
			var badCode = RandomData.GenerateWord(10);

			Assert.IsTrue(goodCode.IsOneToSevenAlpha());

			Assert.IsFalse(badCode.IsOneToSevenAlpha());
		}

		/// <summary>
		/// Defines the test method DefaultIfNullTest.
		/// </summary>
		[TestMethod]
		public void DefaultIfNullTest()
		{
			string testValue = null;

			Assert.IsTrue(testValue.DefaultIfNull().Length == 0);

			Assert.IsTrue(testValue.DefaultIfNull(RandomData.GenerateWord(5)).Length == 5);
		}

		/// <summary>
		/// Defines the test method DelimitedStringToArrayTest.
		/// </summary>
		[TestMethod]
		public void DelimitedStringToArrayTest()
		{
			var inputString = "Microsoft .NET, Visual Studio, Azure";

			var result = inputString.DelimitedStringToArray();

			Assert.IsTrue(result.FastCount() == 3);

			Assert.IsTrue(result.FastCount() == 3);
		}

		/// <summary>
		/// Defines the test method EqualsIgnoreCaseTest.
		/// </summary>
		[TestMethod]
		public void EqualsIgnoreCaseTest()
		{
			var testValue = RandomData.GenerateWord(10);

			Assert.IsTrue(testValue.EqualsIgnoreCase(testValue));
		}

		/// <summary>
		/// Defines the test method EqualsOrBothNullOrEmptyTest.
		/// </summary>
		[TestMethod]
		public void EqualsOrBothNullOrEmptyTest()
		{
			var testValue = RandomData.GenerateWord(10);

			Assert.IsTrue(testValue.EqualsOrBothNullOrEmpty(testValue));

			Assert.IsTrue(string.Empty.EqualsOrBothNullOrEmpty(null));
		}

		/// <summary>
		/// Defines the test method ExtractTest.
		/// </summary>
		[TestMethod]
		public void ExtractTest()
		{
			var inputString = "Microsoft .NET, Visual Studio, Azure";

			var result = inputString.Extract("Micro", "V");

			Assert.IsTrue(result.HasValue());
		}

		/// <summary>
		/// Defines the test method FromBase64Test.
		/// </summary>
		[TestMethod]
		public void FromBase64Test()
		{
			var testValue = RandomData.GenerateWord(25);

			Assert.IsTrue(testValue.ToBase64().FromBase64().IsNotEmpty());

			Assert.ThrowsException<ArgumentNullException>(() => string.Empty.ToBase64().FromBase64().IsEmpty());
		}

		/// <summary>
		/// Defines the test method HasValueTest.
		/// </summary>
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

		/// <summary>
		/// Defines the test method HasWhiteSpaceTest.
		/// </summary>
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

		/// <summary>
		/// Defines the test method IndentTest.
		/// </summary>
		[TestMethod]
		public void IndentTest()
		{
			var testValue = RandomData.GenerateWord(100);

			var result = testValue.Indent(2, '>');

			Assert.IsTrue(result.Length > 90);

			result = testValue.Indent(0, '>');

			Assert.IsTrue(result.Length > 90);
		}

		/// <summary>
		/// Defines the test method IsAsciiLetterOrDigitTest.
		/// </summary>
		[TestMethod]
		public void IsAsciiLetterOrDigitTest()
		{
			Assert.IsTrue('A'.IsAsciiLetterOrDigit());

			Assert.IsTrue('1'.IsAsciiLetterOrDigit());
		}

		/// <summary>
		/// Defines the test method IsAsciiLetterTest.
		/// </summary>
		[TestMethod]
		public void IsAsciiLetterTest()
		{
			Assert.IsTrue('A'.IsAsciiLetter());
		}


		/// <summary>
		/// Defines the test method IsCreditCardTest.
		/// </summary>
		[TestMethod]
		public void IsCreditCardTest()
		{
			Assert.IsFalse("123".IsCreditCardNumber());
		}

		/// <summary>
		/// Defines the test method IsDigitTest.
		/// </summary>
		[TestMethod]
		public void IsDigitTest()
		{
			Assert.IsTrue('1'.IsAsciiDigit());

			Assert.IsFalse('A'.IsAsciiDigit());
		}

		/// <summary>
		/// Defines the test method IsDomainAddressTest.
		/// </summary>
		[TestMethod]
		public void IsDomainAddressTest()
		{
			Assert.IsTrue("dotnettips.com".IsDomainAddress());
		}

		/// <summary>
		/// Defines the test method IsEmailAddressTest.
		/// </summary>
		[TestMethod]
		public void IsEmailAddressTest()
		{
			Assert.IsTrue("dotnetdave@live.com".IsEmailAddress());
		}

		/// <summary>
		/// Defines the test method IsEmptyTest.
		/// </summary>
		[TestMethod]
		public void IsEmptyTest()
		{
			Assert.IsFalse(RandomData.GenerateWord(10).IsEmpty());

			Assert.IsTrue(string.Empty.IsEmpty());
		}

		/// <summary>
		/// Defines the test method IsFirstLastNameTest.
		/// </summary>
		[TestMethod]
		public void IsFirstLastNameTest()
		{
			Assert.IsTrue("David McCarter".IsFirstLastName());
		}

		/// <summary>
		/// Defines the test method IsISBNTest.
		/// </summary>
		[TestMethod]
		public void IsISBNTest()
		{
			Assert.IsTrue("1257561035".IsISBN());
		}

		/// <summary>
		/// Defines the test method IsNotEmptyTest.
		/// </summary>
		[TestMethod]
		public void IsNotEmptyTest()
		{
			Assert.IsTrue(RandomData.GenerateWord(10).IsNotEmpty());

			Assert.IsFalse(string.Empty.IsNotEmpty());
		}

		/// <summary>
		/// Defines the test method IsScientificTest.
		/// </summary>
		[TestMethod]
		public void IsScientificTest()
		{
			Assert.IsFalse("6.5 ✕ 10^8".IsScientific());
		}

		/// <summary>
		/// Defines the test method IsStringTest.
		/// </summary>
		[TestMethod]
		public void IsStringTest()
		{
			Assert.IsTrue("979-8589711707".IsString());
		}

		/// <summary>
		/// Defines the test method IsUrlTest.
		/// </summary>
		[TestMethod]
		public void IsUrlTest()
		{
			Assert.IsTrue("http://dotnettips.com".IsUrl());
		}

		/// <summary>
		/// Defines the test method IsWhiteSpaceTest.
		/// </summary>
		[TestMethod]
		public void IsWhiteSpaceTest()
		{
			Assert.IsTrue("      ".HasWhitespace());

			Assert.IsTrue(ControlChars.Space.IsAsciiWhitespace());

			Assert.IsFalse("David".HasWhitespace());
		}

		/// <summary>
		/// Defines the test method RemoveCRLFTest.
		/// </summary>
		[TestMethod]
		public void RemoveCRLFTest()
		{
			var testValue1 = $"{RandomData.GenerateWord(10)}{ControlChars.NewLine}{RandomData.GenerateWord(15)}{ControlChars.CRLF}{RandomData.GenerateWord(15)}";

			var testValue2 = $"{RandomData.GenerateWord(15)}{RandomData.GenerateWord(25)}";

			var result1 = testValue1.RemoveCRLF(replacement: ".");
			var result2 = testValue2.RemoveCRLF();

			Assert.IsTrue(result1.Contains(ControlChars.NewLine) is false);
			Assert.IsTrue(result1.Contains(ControlChars.CRLF) is false);
			Assert.IsTrue(result1.Contains(ControlChars.CR) is false);

			Assert.IsTrue(result2.Contains(ControlChars.NewLine) is false);
			Assert.IsTrue(result2.Contains(ControlChars.CRLF) is false);
			Assert.IsTrue(result2.Contains(ControlChars.CR) is false);

			Assert.ThrowsException<ArgumentNullException>(() => string.IsNullOrEmpty(string.Empty.RemoveCRLF()));
		}

		/// <summary>
		/// Defines the test method ReplaceEllipsisWithPeriodTest.
		/// </summary>
		[TestMethod]
		public void ReplaceEllipsisWithPeriodTest()
		{
			var testValue = $"{RandomData.GenerateWord(25)}...";

			var result = testValue.ReplaceEllipsisWithPeriod();

			Assert.IsTrue(result.EndsWith("...") is false);

			Assert.ThrowsException<ArgumentNullException>(() => string.IsNullOrEmpty(string.Empty.ReplaceEllipsisWithPeriod()));
		}

		/// <summary>
		/// Defines the test method SplitRemoveEmptyTest.
		/// </summary>
		[TestMethod]
		public void SplitRemoveEmptyTest()
		{
			var testValue = $"{RandomData.GenerateWord(25)},{RandomData.GenerateWord(25)}";

			Assert.IsTrue(testValue.SplitRemoveEmpty().FastCount() > 1);
		}

		/// <summary>
		/// Defines the test method SplitTest.
		/// </summary>
		[TestMethod]
		public void SplitTest()
		{
			var testValue = $"{RandomData.GenerateWord(25)},{RandomData.GenerateWord(25)}";

			Assert.IsTrue(testValue.Split(',', options: StringSplitOptions.RemoveEmptyEntries).FastCount() == 2);

			Assert.IsTrue(testValue.Split(',', count: 2, options: StringSplitOptions.RemoveEmptyEntries).FastCount() == 2);
		}

		/// <summary>
		/// Defines the test method SplitWithCharAndCountTest.
		/// </summary>
		[TestMethod]
		public void SplitWithCharAndCountTest()
		{
			var testValue = $"coding, programming, microsoft";

			var result = testValue.Split(',', 2, StringSplitOptions.RemoveEmptyEntries);

			Assert.IsTrue(result.FastCount() == 2);

			result = testValue.Split(',', 1, StringSplitOptions.None);

			Assert.IsTrue(result.FastCount() == 1);
		}

		/// <summary>
		/// Defines the test method SplitWithCharTest.
		/// </summary>
		[TestMethod]
		public void SplitWithCharTest()
		{
			var testValue = $"coding, programming, microsoft";

			var result = testValue.Split(',', StringSplitOptions.RemoveEmptyEntries);

			Assert.IsTrue(result.FastCount() == 3);

			result = testValue.Split(',', StringSplitOptions.None);

			Assert.IsTrue(result.FastCount() == 3);
		}

		/// <summary>
		/// Defines the test method SplitWithStringAndCountTest.
		/// </summary>
		[TestMethod]
		public void SplitWithStringAndCountTest()
		{
			var testValue = $"coding, programming, microsoft";

			var result = testValue.Split(",", 2, StringSplitOptions.RemoveEmptyEntries);

			Assert.IsTrue(result.FastCount() == 2);

			result = testValue.Split(",", 1, StringSplitOptions.None);

			Assert.IsTrue(result.FastCount() == 1);
		}

		/// <summary>
		/// Defines the test method SplitWithStringTest.
		/// </summary>
		[TestMethod]
		public void SplitWithStringTest()
		{
			var testValue = $"coding, programming, microsoft";

			var result = testValue.Split(",", StringSplitOptions.RemoveEmptyEntries);

			Assert.IsTrue(result.FastCount() == 3);

			result = testValue.Split(",", StringSplitOptions.None);

			Assert.IsTrue(result.FastCount() == 3);
		}

		/// <summary>
		/// Defines the test method StartsWithOrdinalIgnoreCaseTest.
		/// </summary>
		[TestMethod]
		public void StartsWithOrdinalIgnoreCaseTest()
		{
			var testValue = RandomData.GenerateWord(10);

			Assert.IsTrue(testValue.StartsWithOrdinalIgnoreCase(testValue));

			Assert.ThrowsException<ArgumentNullException>(() => string.Empty.StartsWithOrdinalIgnoreCase("David"));
		}

		/// <summary>
		/// Defines the test method StartsWithOrdinalTest.
		/// </summary>
		[TestMethod]
		public void StartsWithOrdinalTest()
		{
			var testValue = RandomData.GenerateWord(10);

			Assert.IsTrue(testValue.StartsWithOrdinal(testValue));
		}

		/// <summary>
		/// Defines the test method SubstringTrimTest.
		/// </summary>
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

		/// <summary>
		/// Defines the test method ToBase64Test.
		/// </summary>
		[TestMethod]
		public void ToBase64Test()
		{
			var testValue = RandomData.GenerateWord(25);

			Assert.IsTrue(testValue.ToBase64().IsNotEmpty());
		}

		/// <summary>
		/// Defines the test method GzipStringCompressionAsyncTest.
		/// </summary>
		[TestMethod]
		public async Task GzipStringCompressionAsyncTest()
		{
			var testValue = RandomData.GenerateWord(25);

			var r1 = await testValue.ToGZipAsync(); // Fastest is default
			var r2 = await testValue.ToGZipAsync(CompressionLevel.NoCompression);
			var r3 = await testValue.ToGZipAsync(CompressionLevel.Optimal);

			Assert.IsFalse(string.IsNullOrEmpty(r1));
			Assert.IsFalse(string.IsNullOrEmpty(r2));
			Assert.IsFalse(string.IsNullOrEmpty(r3));

			//var test = await r1.FromGZipAsync();

			Assert.IsFalse(string.IsNullOrEmpty(await r1.FromGZipAsync()));
			Assert.IsFalse(string.IsNullOrEmpty(await r2.FromGZipAsync()));
			Assert.IsFalse(string.IsNullOrEmpty(await r3.FromGZipAsync()));
		}

		/// <summary>
		/// Defines the test method BrotliStringCompressionAsyncTest.
		/// </summary>
		[TestMethod]
		public async Task BrotliStringCompressionAsyncTest()
		{
			var testValue = RandomData.GenerateWord(25);

			var r1 = await testValue.ToBrotliAsync();  //Fastest is default
			var r2 = await testValue.ToBrotliAsync(CompressionLevel.NoCompression);
			var r3 = await testValue.ToBrotliAsync(CompressionLevel.Optimal);

			Assert.IsFalse(string.IsNullOrEmpty(r1));
			Assert.IsFalse(string.IsNullOrEmpty(r2));
			Assert.IsFalse(string.IsNullOrEmpty(r3));

			Assert.IsFalse(string.IsNullOrEmpty(await r1.FromBrotliAsync()));
			Assert.IsFalse(string.IsNullOrEmpty(await r2.FromBrotliAsync()));
			Assert.IsFalse(string.IsNullOrEmpty(await r3.FromBrotliAsync()));
		}

		/// <summary>
		/// Defines the test method ToTitleCaseTest.
		/// </summary>
		[TestMethod]
		public void ToTitleCaseTest()
		{
			var words = RandomData.GenerateWords(10, 10, 20).ToDelimitedString(ControlChars.Space);

			var testValue = words.ToTitleCase();

			Assert.IsTrue(testValue.IsNotEmpty());
		}

		/// <summary>
		/// Defines the test method TrimTest.
		/// </summary>
		[TestMethod]
		public void TrimTest()
		{
			var testValue = $"{RandomData.GenerateWord(25)}   ";

			Assert.IsTrue(testValue.ToTrimmed().Length == 25);
		}

	}
}
