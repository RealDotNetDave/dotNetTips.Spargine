// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 12-27-2020
// ***********************************************************************
// <copyright file="DateTimeExtensionsTests.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using dotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Extensions.Tests
{
	[ExcludeFromCodeCoverage]
	[TestClass]
	public class DateTimeExtensionsTests : TestClass
	{

		[TestMethod]
		public void DateTimeIntersectsTest()
		{
			var now = DateTime.Now;

			var result = now.Intersects(endDate: now.AddDays(100), intersectingStartDate: now.AddDays(1), intersectingEndDate: now.AddDays(10));

			PrintResult(result, nameof(this.DateTimeIntersectsTest));

			Assert.IsTrue(result);
		}

		[TestMethod]
		public void DateTimeIsInRangeTest()
		{
			var now = DateTime.Now;

			var result = now.IsInRange(beginningTime: now.Subtract(new TimeSpan(1, 0, 0, 0)), endTime: now.AddDays(10));

			PrintResult(result, nameof(this.DateTimeIsInRangeTest));

			Assert.IsTrue(result);
		}


		[TestMethod]
		public void DateTimeLocalTimeFromUtcTest()
		{
			var now = DateTime.Now;

			var result = now.LocalTimeFromUtc(timezoneFromUtc: -5);

			PrintResult(result, nameof(this.DateTimeLocalTimeFromUtcTest));

			Assert.IsTrue(result >= now);
		}

		[TestMethod]
		public void DateTimeMaxTest()
		{
			var now = DateTime.Now;

			var result = now.Max(now.Subtract(new TimeSpan(1, 0, 0, 0)));

			PrintResult(result, nameof(this.DateTimeMaxTest));

			Assert.IsTrue(result == now);
		}

		[TestMethod]
		public void DateTimeNextDayOfTheWeekTest()
		{
			var now = DateTime.Now;

			var result = now.NextDayOfWeek(DayOfWeek.Sunday);

			PrintResult(result, nameof(this.DateTimeNextDayOfTheWeekTest));

			Assert.IsTrue(result >= now);
		}


		[TestMethod]
		public void DateTimeOffsetGetLastDayOfWeekTest()
		{
			var result = DateTimeOffset.Now.GetLastDayOfWeek(DayOfWeek.Monday);

			PrintResult(result, nameof(this.DateTimeOffsetGetLastDayOfWeekTest));

			Assert.IsTrue(result <= DateTime.Now);
		}

		[TestMethod]
		public void DateTimeOffsetGetNextDayOfWeekTest()
		{
			var result = DateTimeOffset.Now.GetNextDayOfWeek(DayOfWeek.Monday);

			PrintResult(result, nameof(this.DateTimeOffsetGetNextDayOfWeekTest));

			Assert.IsTrue(result >= DateTime.Now);
		}

		[TestMethod]
		public void DateTimeOffsetIntersectsTest()
		{
			var now = DateTimeOffset.Now;

			var result = now.Intersects(now.AddDays(100), now.AddDays(1), now.AddDays(10));

			PrintResult(result, nameof(this.DateTimeOffsetIntersectsTest));

			Assert.IsTrue(result);
		}

		[TestMethod]
		public void DateTimeOffsetIsInRangeTest()
		{
			var now = DateTimeOffset.Now;

			var result = now.IsInRange(now.Subtract(new TimeSpan(1, 0, 0, 0)), now.AddDays(10));

			PrintResult(result, nameof(this.DateTimeOffsetIsInRangeTest));

			Assert.IsTrue(result);
		}

		[TestMethod]
		public void DateTimeOffsetMaxTest()
		{
			var now = DateTimeOffset.Now;

			var result = now.Max(now.Subtract(new TimeSpan(1, 0, 0, 0)));

			PrintResult(result, nameof(this.DateTimeOffsetMaxTest));

			Assert.IsTrue(result == now);
		}

		[TestMethod]
		public void DateTimeOffsetNextDayOfTheWeekTest()
		{
			var now = DateTimeOffset.Now;

			var result = now.NextDayOfWeek(DayOfWeek.Sunday);

			PrintResult(result, nameof(this.DateTimeOffsetNextDayOfTheWeekTest));

			Assert.IsTrue(result >= now);
		}

		[TestMethod]
		public void DateTimeOffsetToFriendlyStringTest()
		{
			var result = DateTimeOffset.Now.ToFriendlyDateString();

			PrintResult(result, nameof(this.DateTimeOffsetToFriendlyStringTest));

			Assert.IsTrue(string.IsNullOrEmpty(result) == false);
		}

		[TestMethod]
		public void DateTimeToFormattedStringTest()
		{
			var now = DateTime.Now;

			var result = now.ToFormattedString(DateTimeFormat.FullDateLongTime);

			PrintResult(result, nameof(DateTimeFormat.FullDateLongTime));

			Assert.IsTrue(result.Length > 5);

			result = now.ToFormattedString(DateTimeFormat.FullDateShortTime);

			PrintResult(result, nameof(DateTimeFormat.FullDateShortTime));

			Assert.IsTrue(result.Length > 5);

			result = now.ToFormattedString(DateTimeFormat.FullDateTime);

			PrintResult(result, nameof(DateTimeFormat.FullDateTime));

			Assert.IsTrue(result.Length > 5);

			result = now.ToFormattedString(DateTimeFormat.GeneralDateLongTime);

			PrintResult(result, nameof(DateTimeFormat.GeneralDateLongTime));

			Assert.IsTrue(result.Length > 5);

			result = now.ToFormattedString(DateTimeFormat.GeneralDateShortTime);

			PrintResult(result, nameof(DateTimeFormat.GeneralDateShortTime));

			Assert.IsTrue(result.Length > 5);

			result = now.ToFormattedString(DateTimeFormat.Jan01Comma2020);

			PrintResult(result, nameof(DateTimeFormat.Jan01Comma2020));

			Assert.IsTrue(result.Length > 5);

			result = now.ToFormattedString(DateTimeFormat.Janurary01Comma2020);

			PrintResult(result, nameof(DateTimeFormat.Janurary01Comma2020));

			Assert.IsTrue(result.Length > 5);

			result = now.ToFormattedString(DateTimeFormat.LongDate);

			PrintResult(result, nameof(DateTimeFormat.LongDate));

			Assert.IsTrue(result.Length > 5);

			result = now.ToFormattedString(DateTimeFormat.LongTime);

			PrintResult(result, nameof(DateTimeFormat.LongTime));

			Assert.IsTrue(result.Length > 5);

			result = now.ToFormattedString(DateTimeFormat.MonthDay);

			PrintResult(result, nameof(DateTimeFormat.MonthDay));

			Assert.IsTrue(result.Length > 5);

			result = now.ToFormattedString(DateTimeFormat.RFC1123);

			PrintResult(result, nameof(DateTimeFormat.RFC1123));

			Assert.IsTrue(result.Length > 5);

			result = now.ToFormattedString(DateTimeFormat.RoundTripDateTime);

			PrintResult(result, nameof(DateTimeFormat.RoundTripDateTime));

			Assert.IsTrue(result.Length > 5);

			result = now.ToFormattedString(DateTimeFormat.ShortDate);

			PrintResult(result, nameof(DateTimeFormat.ShortDate));

			Assert.IsTrue(result.Length > 5);

			result = now.ToFormattedString(DateTimeFormat.ShortTime);

			PrintResult(result, nameof(DateTimeFormat.ShortTime));

			Assert.IsTrue(result.Length > 5);

			result = now.ToFormattedString(DateTimeFormat.SortableDateTime);

			PrintResult(result, nameof(DateTimeFormat.SortableDateTime));

			Assert.IsTrue(result.Length > 5);

			result = now.ToFormattedString(DateTimeFormat.UniversalFullDateTime);

			PrintResult(result, nameof(DateTimeFormat.UniversalFullDateTime));

			Assert.IsTrue(result.Length > 5);

			result = now.ToFormattedString(DateTimeFormat.MonthYear);

			PrintResult(result, nameof(DateTimeFormat.MonthYear));

			Assert.IsTrue(result.Length > 5);
		}

		[TestMethod]
		public void DateTimeToFriendlyStringTest()
		{
			var result = DateTime.Now.ToFriendlyDateString();

			PrintResult(result, nameof(this.DateTimeToFriendlyStringTest));

			Assert.IsTrue(string.IsNullOrEmpty(result) == false);
		}
		[TestMethod]
		public void GetLastDayOfWeekTest()
		{
			var dateTime = DateTimeOffset.Parse("1/1/2020");

			var result = dateTime.GetLastDayOfWeek(DayOfWeek.Sunday);

			Assert.IsTrue(result.DayOfWeek == DayOfWeek.Sunday);
		}

		[TestMethod]
		public void GetNextDayOfWeekTest()
		{
			var dateTime = DateTimeOffset.Parse("1/1/2020");

			var result = dateTime.GetLastDayOfWeek(DayOfWeek.Tuesday);

			Assert.IsTrue(result.DayOfWeek == DayOfWeek.Tuesday);
		}

		[TestMethod]
		public void IsInRangeThrowsExceptionTestDateTime()
		{
			var now = DateTime.Now;

			var result1 = now.IsInRangeThrowsException(now.Subtract(new TimeSpan(1, 0, 0, 0)), now.AddDays(1), "TEST");

			Assert.IsTrue(result1);

			Assert.ThrowsException<ArgumentOutOfRangeException>(() => now.IsInRangeThrowsException(now.AddDays(1), now.AddDays(5), "TEST"));
		}

		[TestMethod]
		public void IsInRangeThrowsExceptionTestDateTimeOffset()
		{
			var now = DateTimeOffset.Now;

			var result1 = now.IsInRangeThrowsException(now.Subtract(new TimeSpan(1, 0, 0, 0)), now.AddDays(1), "TEST");

			Assert.IsTrue(result1);

			Assert.ThrowsException<ArgumentOutOfRangeException>(() => now.IsInRangeThrowsException(now.AddDays(1), now.AddDays(5), "TEST"));
		}

		[TestMethod]
		public void IsInRangeThrowsExceptionTestTimeSpan()
		{
			var now = TimeSpan.FromDays(5);

			var result1 = now.IsInRangeThrowsException(now.Subtract(new TimeSpan(1, 0, 0, 0)), now.Add(TimeSpan.FromDays(10)), "TEST");

			Assert.IsTrue(result1);

			Assert.ThrowsException<ArgumentOutOfRangeException>(() => now.IsInRangeThrowsException(now.Add(new TimeSpan(10, 0, 0, 0)), new TimeSpan(20, 0, 0, 0), "TEST"));
		}

		[TestMethod]
		public void TimeSpanIsInRangeTest()
		{
			var now = new TimeSpan(3, 0, 0, 0);

			var result = now.IsInRange(now.Subtract(new TimeSpan(1, 0, 0, 0)), now.Multiply(10));

			PrintResult(result, nameof(this.TimeSpanIsInRangeTest));

			Assert.IsTrue(result);
		}
	}
}
