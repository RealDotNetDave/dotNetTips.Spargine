using System;
using System.Diagnostics.CodeAnalysis;
using dotNetTips.Spargine.Core;
using dotNetTips.Utility.Standard.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

            Assert.ThrowsException<ArgumentNullException>(() => string.Empty.ComputeHash(HashType.MD5));

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
            Assert.IsTrue(testValue1.Concat("-", Tristate.False, testValue2).Length == 26);
        }

        [TestMethod]
        public void ContainsAnyTest()
        {
            var testValue = "dotNetTips.com";

            Assert.IsTrue(testValue.ContainsAny("d", "T"));

            Assert.ThrowsException<ArgumentNullException>(() => string.Empty.ContainsAny("M", "D"));
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

            Assert.ThrowsException<ArgumentNullException>(() => string.Empty.DelimitedStringToArray());
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
        public void FromBase64Test()
        {
            var testValue = RandomData.GenerateWord(25);

            Assert.IsTrue(testValue.ToBase64().FromBase64().IsNotEmpty());
        }

        [TestMethod]
        public void HasValueTest()
        {
            var testValue = RandomData.GenerateWord(10);

            Assert.IsTrue(testValue.HasValue());

            Assert.IsTrue(testValue.HasValue(10));

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => testValue.HasValue(-100));

            Assert.IsTrue(testValue.HasValue(1, 10));

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => testValue.HasValue(-10, 500));

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => testValue.HasValue(12, -10));

            Assert.IsFalse(testValue.HasValue("XXXXX"));
        }

        [TestMethod]
        public void HasWhiteSpaceTest()
        {
            var testWithText = RandomData.GenerateWord(10);
            var testWithWhitespace = "      ";

            Assert.IsFalse(testWithText.IsWhitespace());
            Assert.IsTrue(testWithWhitespace.IsWhitespace());
            Assert.IsTrue(' '.IsWhitespace());
            Assert.IsFalse('d'.IsWhitespace());
        }

        [TestMethod]
        public void IndentTest()
        {
            var testValue = RandomData.GenerateWord(100);

            var result = testValue.Indent(2, '>');

            Assert.IsTrue(result.Length > 100);
        }

        [TestMethod]
        public void IsEmptyTest()
        {
            Assert.IsFalse(RandomData.GenerateWord(10).IsEmpty());

            Assert.IsTrue(string.Empty.IsEmpty());
        }

        [TestMethod]
        public void IsNotEmptyTest()
        {
            Assert.IsTrue(RandomData.GenerateWord(10).IsNotEmpty());

            Assert.IsFalse(string.Empty.IsNotEmpty());
        }

        [TestMethod]
        public void ReplaceEllipsisWithPeriodTest()
        {
            var testValue = RandomData.GenerateWord(25) + "...";

            var result = testValue.ReplaceEllipsisWithPeriod();

            Assert.IsTrue(result.EndsWith("...") == false);
        }

        [TestMethod]
        public void SplitTest()
        {
            var testValue = RandomData.GenerateWord(25) + ',' + RandomData.GenerateWord(25);

            Assert.IsTrue(testValue.Split(',').Count() == 2);
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
            _ = Assert.ThrowsException<ArgumentNullException>(() => string.Empty.SubstringTrim(1, 10));
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
                .ToDelimitedString(Utility.Standard.Common.ControlChars.Space);

            var testValue = words.ToTitleCase();

            Assert.IsTrue(testValue.IsNotEmpty());
        }

        [TestMethod]
        public void TrimTest()
        {
            var testValue = RandomData.GenerateWord(25) + "   ";

            Assert.IsTrue(testValue.ToTrimmed().Length == 25);
        }

    }
}
