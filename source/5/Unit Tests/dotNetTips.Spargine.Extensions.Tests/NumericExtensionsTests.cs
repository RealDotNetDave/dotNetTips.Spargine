using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using dotNetTips.Spargine.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Spargine.Extensions.Tests
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class NumericExtensionsTests
    {

        [TestMethod]
        public void DoubleToFormattedStringTest()
        {
            var testValue = double.MaxValue / 2;

            var result = testValue.ToFormattedString(NumericFormat.Currency);
            this.PrintResult(result, nameof(NumericFormat.Currency));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.RoundTrip);
            this.PrintResult(result, nameof(NumericFormat.RoundTrip));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Exponential);
            this.PrintResult(result, nameof(NumericFormat.Exponential));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.FixedPoint);
            this.PrintResult(result, nameof(NumericFormat.FixedPoint));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.General);
            this.PrintResult(result, nameof(NumericFormat.General));
            Assert.IsTrue(result.Length > 4);

            result = testValue.ToFormattedString(NumericFormat.Number);
            this.PrintResult(result, nameof(NumericFormat.Number));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Percent);
            this.PrintResult(result, nameof(NumericFormat.Percent));
            Assert.IsTrue(result.Length > 5);

            Assert.ThrowsException<ArgumentInvalidException>(() => testValue.ToFormattedString(NumericFormat.Decimal));
            Assert.ThrowsException<ArgumentInvalidException>(() => testValue.ToFormattedString(NumericFormat.Hexadecimal));

        }
        [TestMethod]
        public void IntToFormattedStringTest()
        {
            var testValue = int.MaxValue;

            var result = testValue.ToFormattedString(NumericFormat.Currency);
            this.PrintResult(result, nameof(NumericFormat.Currency));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Decimal);
            this.PrintResult(result, nameof(NumericFormat.Decimal));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Exponential);
            this.PrintResult(result, nameof(NumericFormat.Exponential));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.FixedPoint);
            this.PrintResult(result, nameof(NumericFormat.FixedPoint));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.General);
            this.PrintResult(result, nameof(NumericFormat.General));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Hexadecimal);
            this.PrintResult(result, nameof(NumericFormat.Hexadecimal));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Number);
            this.PrintResult(result, nameof(NumericFormat.Number));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Percent);
            this.PrintResult(result, nameof(NumericFormat.Percent));
            Assert.IsTrue(result.Length > 5);

            Assert.ThrowsException<ArgumentInvalidException>(() => testValue.ToFormattedString(NumericFormat.RoundTrip));

        }

        [TestMethod]
        public void LongToFormattedStringTest()
        {
            var testValue = long.MaxValue / 2;

            var result = testValue.ToFormattedString(NumericFormat.Currency);
            this.PrintResult(result, nameof(NumericFormat.Currency));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Decimal);
            this.PrintResult(result, nameof(NumericFormat.Decimal));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Exponential);
            this.PrintResult(result, nameof(NumericFormat.Exponential));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.FixedPoint);
            this.PrintResult(result, nameof(NumericFormat.FixedPoint));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.General);
            this.PrintResult(result, nameof(NumericFormat.General));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Hexadecimal);
            this.PrintResult(result, nameof(NumericFormat.Hexadecimal));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Number);
            this.PrintResult(result, nameof(NumericFormat.Number));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Percent);
            this.PrintResult(result, nameof(NumericFormat.Percent));
            Assert.IsTrue(result.Length > 5);

            Assert.ThrowsException<ArgumentInvalidException>(() => testValue.ToFormattedString(NumericFormat.RoundTrip));

        }

        [TestMethod]
        public void ShortToFormattedStringTest()
        {
            var testValue = short.MaxValue;

            var result = testValue.ToFormattedString(NumericFormat.Currency);
            this.PrintResult(result, nameof(NumericFormat.Currency));
            Assert.IsTrue(result.Length > 4);

            result = testValue.ToFormattedString(NumericFormat.Decimal);
            this.PrintResult(result, nameof(NumericFormat.Decimal));
            Assert.IsTrue(result.Length > 4);

            result = testValue.ToFormattedString(NumericFormat.Exponential);
            this.PrintResult(result, nameof(NumericFormat.Exponential));
            Assert.IsTrue(result.Length > 4);

            result = testValue.ToFormattedString(NumericFormat.FixedPoint);
            this.PrintResult(result, nameof(NumericFormat.FixedPoint));
            Assert.IsTrue(result.Length > 4);

            result = testValue.ToFormattedString(NumericFormat.General);
            this.PrintResult(result, nameof(NumericFormat.General));
            Assert.IsTrue(result.Length > 4);

            result = testValue.ToFormattedString(NumericFormat.Hexadecimal);
            this.PrintResult(result, nameof(NumericFormat.Hexadecimal));
            Assert.IsTrue(result.Length > 3);

            result = testValue.ToFormattedString(NumericFormat.Number);
            this.PrintResult(result, nameof(NumericFormat.Number));
            Assert.IsTrue(result.Length > 4);

            result = testValue.ToFormattedString(NumericFormat.Percent);
            this.PrintResult(result, nameof(NumericFormat.Percent));
            Assert.IsTrue(result.Length > 4);

            Assert.ThrowsException<ArgumentInvalidException>(() => testValue.ToFormattedString(NumericFormat.RoundTrip));
        }

        [TestMethod]
        public void UIntToFormattedStringTest()
        {
            var testValue = uint.MaxValue / 2;

            var result = testValue.ToFormattedString(NumericFormat.Currency);
            this.PrintResult(result, nameof(NumericFormat.Currency));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Decimal);
            this.PrintResult(result, nameof(NumericFormat.Decimal));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Exponential);
            this.PrintResult(result, nameof(NumericFormat.Exponential));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.FixedPoint);
            this.PrintResult(result, nameof(NumericFormat.FixedPoint));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.General);
            this.PrintResult(result, nameof(NumericFormat.General));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Hexadecimal);
            this.PrintResult(result, nameof(NumericFormat.Hexadecimal));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Number);
            this.PrintResult(result, nameof(NumericFormat.Number));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Percent);
            this.PrintResult(result, nameof(NumericFormat.Percent));
            Assert.IsTrue(result.Length > 5);

            Assert.ThrowsException<ArgumentInvalidException>(() => testValue.ToFormattedString(NumericFormat.RoundTrip));

        }

        [TestMethod]
        public void ULongToFormattedStringTest()
        {
            var testValue = ulong.MaxValue / 2;

            var result = testValue.ToFormattedString(NumericFormat.Currency);
            this.PrintResult(result, nameof(NumericFormat.Currency));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Decimal);
            this.PrintResult(result, nameof(NumericFormat.Decimal));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Exponential);
            this.PrintResult(result, nameof(NumericFormat.Exponential));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.FixedPoint);
            this.PrintResult(result, nameof(NumericFormat.FixedPoint));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.General);
            this.PrintResult(result, nameof(NumericFormat.General));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Hexadecimal);
            this.PrintResult(result, nameof(NumericFormat.Hexadecimal));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Number);
            this.PrintResult(result, nameof(NumericFormat.Number));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Percent);
            this.PrintResult(result, nameof(NumericFormat.Percent));
            Assert.IsTrue(result.Length > 5);

            Assert.ThrowsException<ArgumentInvalidException>(() => testValue.ToFormattedString(NumericFormat.RoundTrip));

        }

        [TestMethod]
        public void UShortToFormattedStringTest()
        {
            var testValue = ushort.MaxValue;

            var result = testValue.ToFormattedString(NumericFormat.Currency);
            this.PrintResult(result, nameof(NumericFormat.Currency));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Decimal);
            this.PrintResult(result, nameof(NumericFormat.Decimal));
            Assert.IsTrue(result.Length > 4);

            result = testValue.ToFormattedString(NumericFormat.Exponential);
            this.PrintResult(result, nameof(NumericFormat.Exponential));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.FixedPoint);
            this.PrintResult(result, nameof(NumericFormat.FixedPoint));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.General);
            this.PrintResult(result, nameof(NumericFormat.General));
            Assert.IsTrue(result.Length > 4);

            result = testValue.ToFormattedString(NumericFormat.Hexadecimal);
            this.PrintResult(result, nameof(NumericFormat.Hexadecimal));
            Assert.IsTrue(result.Length > 3);

            result = testValue.ToFormattedString(NumericFormat.Number);
            this.PrintResult(result, nameof(NumericFormat.Number));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Percent);
            this.PrintResult(result, nameof(NumericFormat.Percent));
            Assert.IsTrue(result.Length > 5);

            Assert.ThrowsException<ArgumentInvalidException>(() => testValue.ToFormattedString(NumericFormat.RoundTrip));

        }

        private void PrintResult<T>(T input, string methodName)
        {
            var message = $"{methodName}: {input}";

            Debug.WriteLine(message);
        }
    }
}
