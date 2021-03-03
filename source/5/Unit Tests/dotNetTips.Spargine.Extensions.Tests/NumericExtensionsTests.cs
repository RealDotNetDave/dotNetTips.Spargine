// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 12-25-2020
// ***********************************************************************
// <copyright file="NumericExtensionsTests.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Extensions.Tests
{
	[ExcludeFromCodeCoverage]
	[TestClass]
	public class NumericExtensionsTests : TestClass
	{

		[TestMethod]
		public void DoubleToFormattedStringTest()
		{
			var testValue = double.MaxValue / 2;

			var result = testValue.ToFormattedString(NumericFormat.Currency);
			PrintResult(result, nameof(NumericFormat.Currency));
			Assert.IsTrue(result.Length > 5);

			result = testValue.ToFormattedString(NumericFormat.RoundTrip);
			PrintResult(result, nameof(NumericFormat.RoundTrip));
			Assert.IsTrue(result.Length > 5);

			result = testValue.ToFormattedString(NumericFormat.Exponential);
			PrintResult(result, nameof(NumericFormat.Exponential));
			Assert.IsTrue(result.Length > 5);

			result = testValue.ToFormattedString(NumericFormat.FixedPoint);
			PrintResult(result, nameof(NumericFormat.FixedPoint));
			Assert.IsTrue(result.Length > 5);

			result = testValue.ToFormattedString(NumericFormat.General);
			PrintResult(result, nameof(NumericFormat.General));
			Assert.IsTrue(result.Length > 4);

			result = testValue.ToFormattedString(NumericFormat.Number);
			PrintResult(result, nameof(NumericFormat.Number));
			Assert.IsTrue(result.Length > 5);

			result = testValue.ToFormattedString(NumericFormat.Percent);
			PrintResult(result, nameof(NumericFormat.Percent));
			Assert.IsTrue(result.Length > 5);

			Assert.ThrowsException<ArgumentInvalidException>(() => testValue.ToFormattedString(NumericFormat.Decimal));
			Assert.ThrowsException<ArgumentInvalidException>(() => testValue.ToFormattedString(NumericFormat.Hexadecimal));

		}
		[TestMethod]
		public void IntToFormattedStringTest()
		{
			var testValue = int.MaxValue;

			var result = testValue.ToFormattedString(NumericFormat.Currency);
			PrintResult(result, nameof(NumericFormat.Currency));
			Assert.IsTrue(result.Length > 5);

			result = testValue.ToFormattedString(NumericFormat.Decimal);
			PrintResult(result, nameof(NumericFormat.Decimal));
			Assert.IsTrue(result.Length > 5);

			result = testValue.ToFormattedString(NumericFormat.Exponential);
			PrintResult(result, nameof(NumericFormat.Exponential));
			Assert.IsTrue(result.Length > 5);

			result = testValue.ToFormattedString(NumericFormat.FixedPoint);
			PrintResult(result, nameof(NumericFormat.FixedPoint));
			Assert.IsTrue(result.Length > 5);

			result = testValue.ToFormattedString(NumericFormat.General);
			PrintResult(result, nameof(NumericFormat.General));
			Assert.IsTrue(result.Length > 5);

			result = testValue.ToFormattedString(NumericFormat.Hexadecimal);
			PrintResult(result, nameof(NumericFormat.Hexadecimal));
			Assert.IsTrue(result.Length > 5);

			result = testValue.ToFormattedString(NumericFormat.Number);
			PrintResult(result, nameof(NumericFormat.Number));
			Assert.IsTrue(result.Length > 5);

			result = testValue.ToFormattedString(NumericFormat.Percent);
			PrintResult(result, nameof(NumericFormat.Percent));
			Assert.IsTrue(result.Length > 5);

			Assert.ThrowsException<ArgumentInvalidException>(() => testValue.ToFormattedString(NumericFormat.RoundTrip));

		}

		[TestMethod]
		public void LongToFormattedStringTest()
		{
			var testValue = long.MaxValue / 2;

			var result = testValue.ToFormattedString(NumericFormat.Currency);
			PrintResult(result, nameof(NumericFormat.Currency));
			Assert.IsTrue(result.Length > 5);

			result = testValue.ToFormattedString(NumericFormat.Decimal);
			PrintResult(result, nameof(NumericFormat.Decimal));
			Assert.IsTrue(result.Length > 5);

			result = testValue.ToFormattedString(NumericFormat.Exponential);
			PrintResult(result, nameof(NumericFormat.Exponential));
			Assert.IsTrue(result.Length > 5);

			result = testValue.ToFormattedString(NumericFormat.FixedPoint);
			PrintResult(result, nameof(NumericFormat.FixedPoint));
			Assert.IsTrue(result.Length > 5);

			result = testValue.ToFormattedString(NumericFormat.General);
			PrintResult(result, nameof(NumericFormat.General));
			Assert.IsTrue(result.Length > 5);

			result = testValue.ToFormattedString(NumericFormat.Hexadecimal);
			PrintResult(result, nameof(NumericFormat.Hexadecimal));
			Assert.IsTrue(result.Length > 5);

			result = testValue.ToFormattedString(NumericFormat.Number);
			PrintResult(result, nameof(NumericFormat.Number));
			Assert.IsTrue(result.Length > 5);

			result = testValue.ToFormattedString(NumericFormat.Percent);
			PrintResult(result, nameof(NumericFormat.Percent));
			Assert.IsTrue(result.Length > 5);

			Assert.ThrowsException<ArgumentInvalidException>(() => testValue.ToFormattedString(NumericFormat.RoundTrip));

		}

		[TestMethod]
		public void ShortToFormattedStringTest()
		{
			var testValue = short.MaxValue;

			var result = testValue.ToFormattedString(NumericFormat.Currency);
			PrintResult(result, nameof(NumericFormat.Currency));
			Assert.IsTrue(result.Length > 4);

			result = testValue.ToFormattedString(NumericFormat.Decimal);
			PrintResult(result, nameof(NumericFormat.Decimal));
			Assert.IsTrue(result.Length > 4);

			result = testValue.ToFormattedString(NumericFormat.Exponential);
			PrintResult(result, nameof(NumericFormat.Exponential));
			Assert.IsTrue(result.Length > 4);

			result = testValue.ToFormattedString(NumericFormat.FixedPoint);
			PrintResult(result, nameof(NumericFormat.FixedPoint));
			Assert.IsTrue(result.Length > 4);

			result = testValue.ToFormattedString(NumericFormat.General);
			PrintResult(result, nameof(NumericFormat.General));
			Assert.IsTrue(result.Length > 4);

			result = testValue.ToFormattedString(NumericFormat.Hexadecimal);
			PrintResult(result, nameof(NumericFormat.Hexadecimal));
			Assert.IsTrue(result.Length > 3);

			result = testValue.ToFormattedString(NumericFormat.Number);
			PrintResult(result, nameof(NumericFormat.Number));
			Assert.IsTrue(result.Length > 4);

			result = testValue.ToFormattedString(NumericFormat.Percent);
			PrintResult(result, nameof(NumericFormat.Percent));
			Assert.IsTrue(result.Length > 4);

			Assert.ThrowsException<ArgumentInvalidException>(() => testValue.ToFormattedString(NumericFormat.RoundTrip));
		}

		[TestMethod]
		public void UIntToFormattedStringTest()
		{
			var testValue = uint.MaxValue / 2;

			var result = testValue.ToFormattedString(NumericFormat.Currency);
			PrintResult(result, nameof(NumericFormat.Currency));
			Assert.IsTrue(result.Length > 5);

			result = testValue.ToFormattedString(NumericFormat.Decimal);
			PrintResult(result, nameof(NumericFormat.Decimal));
			Assert.IsTrue(result.Length > 5);

			result = testValue.ToFormattedString(NumericFormat.Exponential);
			PrintResult(result, nameof(NumericFormat.Exponential));
			Assert.IsTrue(result.Length > 5);

			result = testValue.ToFormattedString(NumericFormat.FixedPoint);
			PrintResult(result, nameof(NumericFormat.FixedPoint));
			Assert.IsTrue(result.Length > 5);

			result = testValue.ToFormattedString(NumericFormat.General);
			PrintResult(result, nameof(NumericFormat.General));
			Assert.IsTrue(result.Length > 5);

			result = testValue.ToFormattedString(NumericFormat.Hexadecimal);
			PrintResult(result, nameof(NumericFormat.Hexadecimal));
			Assert.IsTrue(result.Length > 5);

			result = testValue.ToFormattedString(NumericFormat.Number);
			PrintResult(result, nameof(NumericFormat.Number));
			Assert.IsTrue(result.Length > 5);

			result = testValue.ToFormattedString(NumericFormat.Percent);
			PrintResult(result, nameof(NumericFormat.Percent));
			Assert.IsTrue(result.Length > 5);

			Assert.ThrowsException<ArgumentInvalidException>(() => testValue.ToFormattedString(NumericFormat.RoundTrip));

		}

		[TestMethod]
		public void ULongToFormattedStringTest()
		{
			var testValue = ulong.MaxValue / 2;

			var result = testValue.ToFormattedString(NumericFormat.Currency);
			PrintResult(result, nameof(NumericFormat.Currency));
			Assert.IsTrue(result.Length > 5);

			result = testValue.ToFormattedString(NumericFormat.Decimal);
			PrintResult(result, nameof(NumericFormat.Decimal));
			Assert.IsTrue(result.Length > 5);

			result = testValue.ToFormattedString(NumericFormat.Exponential);
			PrintResult(result, nameof(NumericFormat.Exponential));
			Assert.IsTrue(result.Length > 5);

			result = testValue.ToFormattedString(NumericFormat.FixedPoint);
			PrintResult(result, nameof(NumericFormat.FixedPoint));
			Assert.IsTrue(result.Length > 5);

			result = testValue.ToFormattedString(NumericFormat.General);
			PrintResult(result, nameof(NumericFormat.General));
			Assert.IsTrue(result.Length > 5);

			result = testValue.ToFormattedString(NumericFormat.Hexadecimal);
			PrintResult(result, nameof(NumericFormat.Hexadecimal));
			Assert.IsTrue(result.Length > 5);

			result = testValue.ToFormattedString(NumericFormat.Number);
			PrintResult(result, nameof(NumericFormat.Number));
			Assert.IsTrue(result.Length > 5);

			result = testValue.ToFormattedString(NumericFormat.Percent);
			PrintResult(result, nameof(NumericFormat.Percent));
			Assert.IsTrue(result.Length > 5);

			Assert.ThrowsException<ArgumentInvalidException>(() => testValue.ToFormattedString(NumericFormat.RoundTrip));

		}

		[TestMethod]
		public void UShortToFormattedStringTest()
		{
			var testValue = ushort.MaxValue;

			var result = testValue.ToFormattedString(NumericFormat.Currency);
			PrintResult(result, nameof(NumericFormat.Currency));
			Assert.IsTrue(result.Length > 5);

			result = testValue.ToFormattedString(NumericFormat.Decimal);
			PrintResult(result, nameof(NumericFormat.Decimal));
			Assert.IsTrue(result.Length > 4);

			result = testValue.ToFormattedString(NumericFormat.Exponential);
			PrintResult(result, nameof(NumericFormat.Exponential));
			Assert.IsTrue(result.Length > 5);

			result = testValue.ToFormattedString(NumericFormat.FixedPoint);
			PrintResult(result, nameof(NumericFormat.FixedPoint));
			Assert.IsTrue(result.Length > 5);

			result = testValue.ToFormattedString(NumericFormat.General);
			PrintResult(result, nameof(NumericFormat.General));
			Assert.IsTrue(result.Length > 4);

			result = testValue.ToFormattedString(NumericFormat.Hexadecimal);
			PrintResult(result, nameof(NumericFormat.Hexadecimal));
			Assert.IsTrue(result.Length > 3);

			result = testValue.ToFormattedString(NumericFormat.Number);
			PrintResult(result, nameof(NumericFormat.Number));
			Assert.IsTrue(result.Length > 5);

			result = testValue.ToFormattedString(NumericFormat.Percent);
			PrintResult(result, nameof(NumericFormat.Percent));
			Assert.IsTrue(result.Length > 5);

			Assert.ThrowsException<ArgumentInvalidException>(() => testValue.ToFormattedString(NumericFormat.RoundTrip));

		}
	}
}
