// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 09-28-2023
// ***********************************************************************
// <copyright file="NumericExtensionsTests.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class NumericExtensionsTests : TestClass
{

	private const string OutOfRange = "OUT OF RANGE";

	[TestMethod]
	public void DecrementTest()
	{
		var testValue = 256234;

		var result = testValue.Decrement(lowerBound: 1, step: 5);

		Assert.IsTrue(testValue - result == 5);
	}

	[TestMethod]
	public void DoubleToFormattedStringTest()
	{
		var testValue = double.MaxValue / 2;

		var result = testValue.ToFormattedString(NumericFormat.Currency);
		Assert.IsTrue(result.Length > 5);

		result = testValue.ToFormattedString(NumericFormat.RoundTrip);
		Assert.IsTrue(result.Length > 5);

		result = testValue.ToFormattedString(NumericFormat.Exponential);
		Assert.IsTrue(result.Length > 5);

		result = testValue.ToFormattedString(NumericFormat.FixedPoint);
		Assert.IsTrue(result.Length > 5);

		result = testValue.ToFormattedString(NumericFormat.General);
		Assert.IsTrue(result.Length > 4);

		result = testValue.ToFormattedString(NumericFormat.Number);
		Assert.IsTrue(result.Length > 5);

		result = testValue.ToFormattedString(NumericFormat.Percent);
		Assert.IsTrue(result.Length > 5);

		_ = Assert.ThrowsException<ArgumentInvalidException>(() => testValue.ToFormattedString(NumericFormat.Decimal));
		_ = Assert.ThrowsException<ArgumentInvalidException>(() => testValue.ToFormattedString(NumericFormat.Hexadecimal));

	}

	[TestMethod]
	public void EnsureMinimumTest()
	{
		var testValue = 99;

		var result = testValue.EnsureMinimum(100);

		Assert.IsTrue(result == 100);
	}

	[TestMethod]
	public void FormatSizeDoubleTest()
	{
		var testValue = 256234.98;

		var result = testValue.FormatSize();

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void FormatSizeLongTest()
	{
		long testValue = 256234;

		var result = testValue.FormatSize();

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void IncrementTest()
	{
		var testValue = 256234;

		var result = testValue.Increment(upperBound: 300000, step: 5);

		Assert.IsTrue(result == 256239);
	}

	[TestMethod]
	public void IntToFormattedStringTest()
	{
		var testValue = int.MaxValue;

		var result = testValue.ToFormattedString(NumericFormat.Currency);
		Assert.IsTrue(result.Length > 5);

		result = testValue.ToFormattedString(NumericFormat.Decimal);
		Assert.IsTrue(result.Length > 5);

		result = testValue.ToFormattedString(NumericFormat.Exponential);
		//PrintResult(result, nameof(NumericFormat.Exponential));
		Assert.IsTrue(result.Length > 5);

		result = testValue.ToFormattedString(NumericFormat.FixedPoint);
		Assert.IsTrue(result.Length > 5);

		result = testValue.ToFormattedString(NumericFormat.General);
		Assert.IsTrue(result.Length > 5);

		result = testValue.ToFormattedString(NumericFormat.Hexadecimal);
		Assert.IsTrue(result.Length > 5);

		result = testValue.ToFormattedString(NumericFormat.Number);
		Assert.IsTrue(result.Length > 5);

		result = testValue.ToFormattedString(NumericFormat.Percent);
		Assert.IsTrue(result.Length > 5);

		_ = Assert.ThrowsException<ArgumentInvalidException>(() => testValue.ToFormattedString(NumericFormat.RoundTrip));
	}

	[TestMethod]
	public void IsEvenDecimalTest()
	{
		decimal testValue = 256234;

		Assert.IsTrue(testValue.IsEven());

		testValue++;

		Assert.IsFalse(testValue.IsEven());
	}

	[TestMethod]
	public void IsEvenDoubleTest()
	{
		double testValue = 256234;

		Assert.IsTrue(testValue.IsEven());

		testValue++;

		Assert.IsFalse(testValue.IsEven());
	}

	[TestMethod]
	public void IsEvenFloatTest()
	{
		float testValue = 256234;

		Assert.IsTrue(testValue.IsEven());

		testValue++;

		Assert.IsFalse(testValue.IsEven());
	}

	[TestMethod]
	public void IsEvenIntTest()
	{
		int testValue = 256234;

		Assert.IsTrue(testValue.IsEven());

		testValue++;

		Assert.IsFalse(testValue.IsEven());
	}

	[TestMethod]
	public void IsEvenLongTest()
	{
		long testValue = 256234;

		Assert.IsTrue(testValue.IsEven());

		testValue++;

		Assert.IsFalse(testValue.IsEven());
	}

	[TestMethod]
	public void IsEvenSbyteTest()
	{
		sbyte testValue = 32;

		Assert.IsTrue(testValue.IsEven());

		testValue++;

		Assert.IsFalse(testValue.IsEven());
	}

	[TestMethod]
	public void IsEvenShortTest()
	{
		short testValue = 266;

		Assert.IsTrue(testValue.IsEven());

		testValue++;

		Assert.IsFalse(testValue.IsEven());
	}

	[TestMethod]
	public void IsInRangeTest()
	{
		int testValue1 = 100;
		long testValue2 = 100;
		double testValue3 = 100;
		decimal testValue4 = 100;

		Assert.IsTrue(testValue1.IsInRange(50, 500));

		Assert.IsTrue(testValue2.IsInRange(50, 500));

		Assert.IsTrue(testValue3.IsInRange(50, 500));

		Assert.IsTrue(testValue4.IsInRange(50, 500));
	}

	[TestMethod]
	public void IsInRangeThrowsExceptionTest()
	{
		int testValue1 = 100;
		long testValue2 = 100;
		double testValue3 = 100;
		decimal testValue4 = 100;

		Assert.IsTrue(testValue1.IsInRangeThrowsException(50, 500));

		Assert.IsTrue(testValue2.IsInRangeThrowsException(50, 500));

		Assert.IsTrue(testValue3.IsInRangeThrowsException(50, 500));

		Assert.IsTrue(testValue4.IsInRangeThrowsException(50, 500));

		_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => testValue1.IsInRangeThrowsException(200, 300));

		_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => testValue2.IsInRangeThrowsException(200, 300));

		_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => testValue3.IsInRangeThrowsException(200, 300));

		_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => testValue4.IsInRangeThrowsException(200, 300));
	}

	[TestMethod]
	public void IsIntervalTest()
	{
		var testValue = 400;

		Assert.IsTrue(testValue.IsInterval(100));

		Assert.IsFalse(testValue.IsInterval(99));

		Assert.IsTrue(testValue.IsIntervalThrowsException(100, "test"));

		_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => testValue.IsIntervalThrowsException(99, "test"));
	}

	[TestMethod]
	public void IsNegativeDecimalTest()
	{
		decimal testValue = -100;

		Assert.IsTrue(testValue.IsNegative());

		testValue += 300;

		Assert.IsFalse(testValue.IsNegative());
	}

	[TestMethod]
	public void IsNegativeDoubleTest()
	{
		double testValue = -100;

		Assert.IsTrue(testValue.IsNegative());

		testValue += 300;

		Assert.IsFalse(testValue.IsNegative());
	}

	[TestMethod]
	public void IsNegativeFloatTest()
	{
		float testValue = -100;

		Assert.IsTrue(testValue.IsNegative());

		testValue += 300;

		Assert.IsFalse(testValue.IsNegative());
	}

	[TestMethod]
	public void IsNegativeIntTest()
	{
		int testValue = -100;

		Assert.IsTrue(testValue.IsNegative());

		testValue += 300;

		Assert.IsFalse(testValue.IsNegative());
	}

	[TestMethod]
	public void IsNegativeLongTest()
	{
		long testValue = -100;

		Assert.IsTrue(testValue.IsNegative());

		testValue += 300;

		Assert.IsFalse(testValue.IsNegative());
	}

	[TestMethod]
	public void IsNegativeSbyteTest()
	{
		sbyte testValue = -1;

		Assert.IsTrue(testValue.IsNegative());

		testValue += 20;

		Assert.IsFalse(testValue.IsNegative());
	}

	[TestMethod]
	public void IsNegativeShortTest()
	{
		short testValue = -100;

		Assert.IsTrue(testValue.IsNegative());

		testValue += 300;

		Assert.IsFalse(testValue.IsNegative());
	}

	[TestMethod]
	public void LongToFormattedStringTest()
	{
		var testValue = long.MaxValue / 2;

		var result = testValue.ToFormattedString(NumericFormat.Currency);
		//PrintResult(result, nameof(NumericFormat.Currency));
		Assert.IsTrue(result.Length > 5);

		result = testValue.ToFormattedString(NumericFormat.Decimal);
		//PrintResult(result, nameof(NumericFormat.Decimal));
		Assert.IsTrue(result.Length > 5);

		result = testValue.ToFormattedString(NumericFormat.Exponential);
		//PrintResult(result, nameof(NumericFormat.Exponential));
		Assert.IsTrue(result.Length > 5);

		result = testValue.ToFormattedString(NumericFormat.FixedPoint);
		//PrintResult(result, nameof(NumericFormat.FixedPoint));
		Assert.IsTrue(result.Length > 5);

		result = testValue.ToFormattedString(NumericFormat.General);
		//PrintResult(result, nameof(NumericFormat.General));
		Assert.IsTrue(result.Length > 5);

		result = testValue.ToFormattedString(NumericFormat.Hexadecimal);
		//PrintResult(result, nameof(NumericFormat.Hexadecimal));
		Assert.IsTrue(result.Length > 5);

		result = testValue.ToFormattedString(NumericFormat.Number);
		//PrintResult(result, nameof(NumericFormat.Number));
		Assert.IsTrue(result.Length > 5);

		result = testValue.ToFormattedString(NumericFormat.Percent);
		//PrintResult(result, nameof(NumericFormat.Percent));
		Assert.IsTrue(result.Length > 5);

		_ = Assert.ThrowsException<ArgumentInvalidException>(() => testValue.ToFormattedString(NumericFormat.RoundTrip));

	}

	[TestMethod]
	public void MillisecondsToStringIntTest()
	{
		int time = 99999999;
		var result = time.MillisecondsToString();

		Assert.IsTrue(result == "27:46:39");
	}

	[TestMethod]
	public void MillisecondsToStringLongTest()
	{
		long time = 99999999;
		var result = time.MillisecondsToString();

		Assert.IsTrue(result == "27:46:39");
	}

	[TestMethod]
	public void MillisecondsToStringTimeSpanTest()
	{
		var time = new TimeSpan(1, 12, 55, 33, 2200);
		var result = time.MillisecondsToString();

		Assert.IsTrue(result == "36:55:35");
	}

	[TestMethod]
	public void RoundToPowerOf2Test()
	{
		var testValue = 256234;

		var result = testValue.RoundToPowerOf2();

		Assert.IsTrue(result == 262144);

		//PrintResult(result, nameof(this.RoundToPowerOf2Test));
	}

	[TestMethod]
	public void ShortToFormattedStringTest()
	{
		var testValue = short.MaxValue;

		var result = testValue.ToFormattedString(NumericFormat.Currency);
		//PrintResult(result, nameof(NumericFormat.Currency));
		Assert.IsTrue(result.Length > 4);

		result = testValue.ToFormattedString(NumericFormat.Decimal);
		//PrintResult(result, nameof(NumericFormat.Decimal));
		Assert.IsTrue(result.Length > 4);

		result = testValue.ToFormattedString(NumericFormat.Exponential);
		//PrintResult(result, nameof(NumericFormat.Exponential));
		Assert.IsTrue(result.Length > 4);

		result = testValue.ToFormattedString(NumericFormat.FixedPoint);
		//PrintResult(result, nameof(NumericFormat.FixedPoint));
		Assert.IsTrue(result.Length > 4);

		result = testValue.ToFormattedString(NumericFormat.General);
		//PrintResult(result, nameof(NumericFormat.General));
		Assert.IsTrue(result.Length > 4);

		result = testValue.ToFormattedString(NumericFormat.Hexadecimal);
		//PrintResult(result, nameof(NumericFormat.Hexadecimal));
		Assert.IsTrue(result.Length > 3);

		result = testValue.ToFormattedString(NumericFormat.Number);
		//PrintResult(result, nameof(NumericFormat.Number));
		Assert.IsTrue(result.Length > 4);

		result = testValue.ToFormattedString(NumericFormat.Percent);
		//PrintResult(result, nameof(NumericFormat.Percent));
		Assert.IsTrue(result.Length > 4);

		_ = Assert.ThrowsException<ArgumentInvalidException>(() => testValue.ToFormattedString(NumericFormat.RoundTrip));
	}

	[TestMethod]
	public void ToPositiveValueDecimalTest()
	{
		decimal testValue = -100;

		Assert.IsTrue(testValue.ToPositiveValue() > -1);
	}

	[TestMethod]
	public void ToPositiveValueIntTest()
	{
		int testValue = -100;

		Assert.IsTrue(testValue.ToPositiveValue() > -1);
	}

	[TestMethod]
	public void ToPositiveValueLongTest()
	{
		long testValue = -100;

		Assert.IsTrue(testValue.ToPositiveValue() > -1);
	}

	[TestMethod]
	public void ToRomanNumeralTest()
	{
		var number = 1010;

		Assert.IsNotNull(number.ToRomanNumeral());
	}

	[TestMethod]
	public void ToStringOrEmptyTest()
	{
		var testValue = 1000;

		Assert.IsTrue(testValue.ToStringOrEmpty(lowerLimit: 0, upperLimit: 2000, defaultText: OutOfRange).HasValue());

		Assert.IsTrue(testValue.ToStringOrEmpty(lowerLimit: 0, upperLimit: 200, defaultText: OutOfRange) == OutOfRange);
	}

	[TestMethod]
	public void ToWordsTest()
	{
		var testValue = 54928;

		Assert.IsTrue(testValue.ToWords().HasValue());

		Assert.IsTrue(testValue.ToWords().FastCount() == 49);
	}

	[TestMethod]
	public void UIntToFormattedStringTest()
	{
		var testValue = uint.MaxValue / 2;

		var result = testValue.ToFormattedString(NumericFormat.Currency);
		//PrintResult(result, nameof(NumericFormat.Currency));
		Assert.IsTrue(result.Length > 5);

		result = testValue.ToFormattedString(NumericFormat.Decimal);
		//PrintResult(result, nameof(NumericFormat.Decimal));
		Assert.IsTrue(result.Length > 5);

		result = testValue.ToFormattedString(NumericFormat.Exponential);
		//PrintResult(result, nameof(NumericFormat.Exponential));
		Assert.IsTrue(result.Length > 5);

		result = testValue.ToFormattedString(NumericFormat.FixedPoint);
		//PrintResult(result, nameof(NumericFormat.FixedPoint));
		Assert.IsTrue(result.Length > 5);

		result = testValue.ToFormattedString(NumericFormat.General);
		//PrintResult(result, nameof(NumericFormat.General));
		Assert.IsTrue(result.Length > 5);

		result = testValue.ToFormattedString(NumericFormat.Hexadecimal);
		//PrintResult(result, nameof(NumericFormat.Hexadecimal));
		Assert.IsTrue(result.Length > 5);

		result = testValue.ToFormattedString(NumericFormat.Number);
		//PrintResult(result, nameof(NumericFormat.Number));
		Assert.IsTrue(result.Length > 5);

		result = testValue.ToFormattedString(NumericFormat.Percent);
		//PrintResult(result, nameof(NumericFormat.Percent));
		Assert.IsTrue(result.Length > 5);

		_ = Assert.ThrowsException<ArgumentInvalidException>(() => testValue.ToFormattedString(NumericFormat.RoundTrip));

	}

	[TestMethod]
	public void ULongToFormattedStringTest()
	{
		var testValue = ulong.MaxValue / 2;

		var result = testValue.ToFormattedString(NumericFormat.Currency);
		//PrintResult(result, nameof(NumericFormat.Currency));
		Assert.IsTrue(result.Length > 5);

		result = testValue.ToFormattedString(NumericFormat.Decimal);
		//PrintResult(result, nameof(NumericFormat.Decimal));
		Assert.IsTrue(result.Length > 5);

		result = testValue.ToFormattedString(NumericFormat.Exponential);
		//PrintResult(result, nameof(NumericFormat.Exponential));
		Assert.IsTrue(result.Length > 5);

		result = testValue.ToFormattedString(NumericFormat.FixedPoint);
		//PrintResult(result, nameof(NumericFormat.FixedPoint));
		Assert.IsTrue(result.Length > 5);

		result = testValue.ToFormattedString(NumericFormat.General);
		//PrintResult(result, nameof(NumericFormat.General));
		Assert.IsTrue(result.Length > 5);

		result = testValue.ToFormattedString(NumericFormat.Hexadecimal);
		//PrintResult(result, nameof(NumericFormat.Hexadecimal));
		Assert.IsTrue(result.Length > 5);

		result = testValue.ToFormattedString(NumericFormat.Number);
		//PrintResult(result, nameof(NumericFormat.Number));
		Assert.IsTrue(result.Length > 5);

		result = testValue.ToFormattedString(NumericFormat.Percent);
		//PrintResult(result, nameof(NumericFormat.Percent));
		Assert.IsTrue(result.Length > 5);

		_ = Assert.ThrowsException<ArgumentInvalidException>(() => testValue.ToFormattedString(NumericFormat.RoundTrip));

	}

	[TestMethod]
	public void UShortToFormattedStringTest()
	{
		var testValue = ushort.MaxValue;

		var result = testValue.ToFormattedString(NumericFormat.Currency);
		//PrintResult(result, nameof(NumericFormat.Currency));
		Assert.IsTrue(result.Length > 5);

		result = testValue.ToFormattedString(NumericFormat.Decimal);
		//PrintResult(result, nameof(NumericFormat.Decimal));
		Assert.IsTrue(result.Length > 4);

		result = testValue.ToFormattedString(NumericFormat.Exponential);
		//PrintResult(result, nameof(NumericFormat.Exponential));
		Assert.IsTrue(result.Length > 5);

		result = testValue.ToFormattedString(NumericFormat.FixedPoint);
		//PrintResult(result, nameof(NumericFormat.FixedPoint));
		Assert.IsTrue(result.Length > 5);

		result = testValue.ToFormattedString(NumericFormat.General);
		//PrintResult(result, nameof(NumericFormat.General));
		Assert.IsTrue(result.Length > 4);

		result = testValue.ToFormattedString(NumericFormat.Hexadecimal);
		//PrintResult(result, nameof(NumericFormat.Hexadecimal));
		Assert.IsTrue(result.Length > 3);

		result = testValue.ToFormattedString(NumericFormat.Number);
		//PrintResult(result, nameof(NumericFormat.Number));
		Assert.IsTrue(result.Length > 5);

		result = testValue.ToFormattedString(NumericFormat.Percent);
		//PrintResult(result, nameof(NumericFormat.Percent));
		Assert.IsTrue(result.Length > 5);

		_ = Assert.ThrowsException<ArgumentInvalidException>(() => testValue.ToFormattedString(NumericFormat.RoundTrip));

	}

}
