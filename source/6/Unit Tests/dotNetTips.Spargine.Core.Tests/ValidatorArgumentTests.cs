// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 11-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 03-29-2023
// ***********************************************************************
// <copyright file="ValidatorArgumentTests.cs" company="DotNetTips.Spargine.Core.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.IO;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DirectoryNotFoundException = DotNetTips.Spargine.Core.DirectoryNotFoundException;

namespace dotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class ValidatorArgumentTests
{

	private const string BadEmail = "BAD@EMAIL";
	private const string GoodEmail = "fakeemail@google.com";

	[TestMethod]
	public void ArgumentEqualsTest()
	{
		var person = RandomData.GenerateRefPerson<PersonProper>();

		//Good Test
		var result = person.GetType().ArgumentEquals(typeof(PersonProper));

		Assert.IsNotNull(result);

		//Bad test
		_ = Assert.ThrowsException<ArgumentInvalidException>(() => typeof(PersonProper).ArgumentEquals(typeof(Person)));
	}

	[TestMethod]
	public void ArgumentExistsDirectoryInfoTest()
	{
		var directoryInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));

		try
		{
			var result = directoryInfo.ArgumentExists();

			Assert.IsNotNull(result);
		}
		catch
		{
			Assert.Fail();
		}

		//Test Exceptions
		DirectoryInfo nullDirectoryInfo = null;
		_ = Assert.ThrowsException<ArgumentNullException>(() => nullDirectoryInfo.ArgumentExists());

		var fakeDirectory = new DirectoryInfo("fakefile");
		DirectoryHelper.DeleteDirectory(fakeDirectory);

		_ = Assert.ThrowsException<DirectoryNotFoundException>(() => new DirectoryInfo("fakefile").ArgumentExists());
	}

	[TestMethod]
	public void ArgumentExistsDirectoryInfoWithDefaultTest()
	{
		var directoryInfo = new DirectoryInfo("c:\temp\bogus");

		var defaultDirectoryInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));

		try
		{
			var result = directoryInfo.ArgumentExists(defaultDirectoryInfo);

			Assert.AreEqual(result, defaultDirectoryInfo);
		}
		catch
		{
			Assert.Fail();
		}
	}

	[TestMethod]
	public void ArgumentExistsFileInfoTest()
	{
		var fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData, Environment.SpecialFolderOption.DoNotVerify), "tempfileinfotest.dat");

		_ = RandomData.GenerateFile(fileName, 500);

		var tempFile = new FileInfo(fileName);

		try
		{
			_ = tempFile.ArgumentExists();
		}
		catch
		{
			Assert.Fail();
		}

		FileInfo nullFileInfo = null;
		_ = Assert.ThrowsException<NullReferenceException>(() => nullFileInfo.ArgumentExists());

		_ = Assert.ThrowsException<FileNotFoundException>(() => new FileInfo("fakefile").ArgumentExists());

		tempFile.Delete();
	}

	[TestMethod]
	public void ArgumentExistsFileInfoWithDefaultTest()
	{
		var firstFileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData, Environment.SpecialFolderOption.DoNotVerify), "tempfileinfotest.dat1");
		var firstTempFile = new FileInfo(firstFileName);

		var secondFileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData, Environment.SpecialFolderOption.DoNotVerify), "tempfileinfotest.dat2");
		_ = RandomData.GenerateFile(secondFileName, 500);
		var secondTempFile = new FileInfo(secondFileName);

		try
		{
			var result = firstTempFile.ArgumentExists(secondTempFile);

			Assert.AreEqual(result, secondTempFile);
		}
		catch
		{
			Assert.Fail();
		}

		secondTempFile.Delete();
	}

	[TestMethod]
	public void ArgumentInRangeByteTest()
	{
		_ = byte.TryParse("0", out var lowerValue);
		_ = byte.TryParse("100", out var upperValue);
		_ = byte.TryParse("10", out var testValue);

		try
		{
			var result = testValue.ArgumentInRange(lowerValue, upperValue);

			Assert.AreEqual(result, testValue);
		}
		catch
		{
			Assert.Fail();
		}

		//Test Exception
		_ = byte.TryParse("101", out var invalidValue);

		_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => invalidValue.ArgumentInRange(lowerValue, upperValue));
	}

	[TestMethod]
	public void ArgumentInRangeDateOnlyTest()
	{
		var lowerValue = new DateOnly(2021, 3, 3);
		var upperValue = new DateOnly(2025, 3, 3);
		var testValue = new DateOnly(2022, 3, 20);
		var outOfRangeLowerValue = new DateOnly(1900, 3, 3);
		var outOfRangeUpperValue = new DateOnly(1991, 3, 3);

		try
		{
			var result = testValue.ArgumentInRange(lowerValue, upperValue);
		}
		catch
		{
			Assert.Fail();
		}

		// Test Exception
		_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => testValue.ArgumentInRange(outOfRangeLowerValue, outOfRangeUpperValue));
	}

	[TestMethod]
	public void ArgumentInRangeDateOnlyWithDefaultTest()
	{
		var lowerValue = new DateOnly(2000, 3, 3);
		var upperValue = new DateOnly(2001, 3, 3);
		var testValue = new DateOnly(2022, 3, 20);
		var defaultValue = new DateOnly(2022, 5, 5);

		try
		{
			var result = testValue.ArgumentInRange(lowerValue, upperValue, defaultValue);

			Assert.AreEqual(result, defaultValue);
		}
		catch
		{
			Assert.Fail();
		}
	}

	[TestMethod]
	public void ArgumentInRangeDateTimeOffsetTest()
	{
		var lowerValue = new DateTimeOffset(new DateTime(2021, 3, 3));
		var upperValue = new DateTimeOffset(new DateTime(2025, 3, 3));
		var testValue = new DateTimeOffset(new DateTime(2022, 3, 20));
		var outOfRangeLowerValue = new DateTimeOffset(new DateTime(1900, 3, 3));
		var outOfRangeUpperValue = new DateTimeOffset(new DateTime(1991, 3, 3));

		try
		{
			var result = testValue.ArgumentInRange(lowerValue, upperValue);
		}
		catch
		{
			Assert.Fail();
		}

		// Test Exception
		_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => testValue.ArgumentInRange(outOfRangeLowerValue, outOfRangeUpperValue));
	}

	[TestMethod]
	public void ArgumentInRangeDateTimeOffsetWithDefaultTest()
	{
		var lowerValue = new DateTimeOffset(new DateTime(2000, 3, 3));
		var upperValue = new DateTimeOffset(new DateTime(2001, 3, 3));
		var testValue = new DateTimeOffset(new DateTime(2022, 3, 20));
		var defaultValue = new DateTimeOffset(new DateTime(2022, 5, 5));

		try
		{
			var result = testValue.ArgumentInRange(lowerValue, upperValue, defaultValue);

			Assert.AreEqual(result, defaultValue);
		}
		catch
		{
			Assert.Fail();
		}
	}

	[TestMethod]
	public void ArgumentInRangeDateTimeTest()
	{
		var lowerValue = new DateTime(2021, 3, 3);
		var upperValue = new DateTime(2025, 3, 3);
		var testValue = new DateTime(2022, 3, 20);
		var outOfRangeLower = new DateTime(1900, 3, 3);
		var outOfRangeUpper = new DateTime(1991, 3, 3);

		try
		{
			var result = testValue.ArgumentInRange(lowerValue, upperValue);
		}
		catch
		{
			Assert.Fail();
		}

		// Test Exception
		_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => testValue.ArgumentInRange(outOfRangeLower, outOfRangeUpper));
	}

	[TestMethod]
	public void ArgumentInRangeDateTimeWithDefaultTest()
	{
		var lowerValue = new DateTime(2000, 3, 3);
		var upperValue = new DateTime(2001, 3, 3);
		var testValue = new DateTime(2022, 3, 20);
		var defaultValue = new DateTime(2022, 5, 5);

		try
		{
			var result = testValue.ArgumentInRange(lowerValue, upperValue, defaultValue);

			Assert.AreEqual(result, defaultValue);
		}
		catch
		{
			Assert.Fail();
		}
	}

	[TestMethod]
	public void ArgumentInRangeDecimalTest()
	{
		var testValue = 10000m;

		try
		{
			var result = testValue.ArgumentInRange(0, decimal.MaxValue);

			Assert.AreEqual(testValue, result);
		}
		catch
		{
			Assert.Fail();
		}

		// Test Exception
		_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => testValue.ArgumentInRange(0, 100));
	}

	[TestMethod]
	public void ArgumentInRangeDecimalWithDefaultTest()
	{
		var testValue = 10000m;
		var defaultValue = 10000m;

		try
		{
			var result = testValue.ArgumentInRange(0, 100, defaultValue);

			Assert.AreEqual(result, defaultValue);
		}
		catch
		{
			Assert.Fail();
		}
	}

	[TestMethod]
	public void ArgumentInRangeDoubleTest()
	{
		double testValue = 1000;

		try
		{
			var result = testValue.ArgumentInRange(0, double.MaxValue);

			Assert.AreEqual(testValue, result);
		}
		catch
		{
			Assert.Fail();
		}

		// Test Exception
		_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => testValue.ArgumentInRange(0, 100));
	}

	[TestMethod]
	public void ArgumentInRangeDoubleWithDefaultTest()
	{
		double testValue = 1000;
		double defaultValue = 10000;

		try
		{
			var result = testValue.ArgumentInRange(0, 100, defaultValue);

			Assert.AreEqual(result, defaultValue);
		}
		catch
		{
			Assert.Fail();
		}
	}

	[TestMethod]
	public void ArgumentInRangeIntTest()
	{
		var testValue = 1000;

		try
		{
			var result = testValue.ArgumentInRange(0, upper: int.MaxValue);

			Assert.AreEqual(testValue, result);
		}
		catch
		{
			Assert.Fail();
		}

		// Test Exception
		_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => testValue.ArgumentInRange(0, upper: 100));
	}

	[TestMethod]
	public void ArgumentInRangeIntWithDefaultTest()
	{
		var testValue = 1000;
		var defaultValue = 10000;

		try
		{
			var result = testValue.ArgumentInRange(0, upper: 500, defaultValue: defaultValue);

			Assert.AreEqual(result, defaultValue);
		}
		catch
		{
			Assert.Fail();
		}

	}

	[TestMethod]
	public void ArgumentInRangeLongTest()
	{
		long testValue = 1000;

		try
		{
			var result = testValue.ArgumentInRange(0, long.MaxValue);

			Assert.AreEqual(testValue, result);
		}
		catch
		{
			Assert.Fail();
		}

		// Test Exception
		_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => testValue.ArgumentInRange(0, 100));
	}

	[TestMethod]
	public void ArgumentInRangeLongWithDefaultTest()
	{
		long testValue = 1000;
		long defaultValue = 10000;

		try
		{
			var result = testValue.ArgumentInRange(0, 100, defaultValue);

			Assert.AreEqual(result, defaultValue);
		}
		catch
		{
			Assert.Fail();
		}
	}

	[TestMethod]
	public void ArgumentInRangeStringTest()
	{
		var testValue = "dotNetTips.com";

		try
		{
			var result = testValue.ArgumentInRange(0, 50);

			Assert.AreEqual(testValue, result);
		}
		catch
		{
			Assert.Fail();
		}

		// Test Exception
		_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => testValue.ArgumentInRange(0, 2));
	}

	[TestMethod]
	public void ArgumentInRangeStringWithDefaultTest()
	{
		var testValue = "dotNetTips.com";
		var defaultValue = "Spargine";

		try
		{
			var result = testValue.ArgumentInRange(5, 10, defaultValue: defaultValue);

			Assert.AreEqual(result, defaultValue);
		}
		catch
		{
			Assert.Fail();
		}
	}

	[TestMethod]
	public void ArgumentInRangeTimeOnlyTest()
	{
		var lowerValue = new TimeOnly(1, 3, 3);
		var upperValue = new TimeOnly(10, 3, 3);
		var testValue = new TimeOnly(5, 3, 20);
		var outOfRangeLowerValue = new TimeOnly(1, 3, 3);
		var outOfRangeUpperValue = new TimeOnly(2, 3, 3);

		try
		{
			var result = testValue.ArgumentInRange(lowerValue, upperValue);

			Assert.AreEqual(result, testValue);
		}
		catch
		{
			Assert.Fail();
		}

		// Test Exception
		_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => testValue.ArgumentInRange(outOfRangeLowerValue, outOfRangeUpperValue));
	}

	[TestMethod]
	public void ArgumentInRangeTimeOnlyWithDefaultTest()
	{
		var lowerValue = new TimeOnly(1, 3, 3);
		var upperValue = new TimeOnly(2, 3, 3);
		var testValue = new TimeOnly(5, 3, 20);
		var defaultValue = new TimeOnly(2, 3, 3);

		try
		{
			var result = testValue.ArgumentInRange(lowerValue, upperValue, defaultValue);

			Assert.AreEqual(result, defaultValue);
		}
		catch
		{
			Assert.Fail();
		}
	}

	[TestMethod]
	public void ArgumentIsConditionTest()
	{
		var personProper = RandomData.GenerateRefPerson<PersonProper>();

		try
		{
			var result = personProper.ArgumentMeetsCondition(personProper.Id.IsNotEmpty(), errorMessage: "Person is missing Id");

			Assert.IsNotNull(result);
		}
		catch
		{
			Assert.Fail();
		}

		//Test Exception
		_ = Assert.ThrowsException<ArgumentInvalidException>(() => personProper.ArgumentMeetsCondition(personProper.Id == "AA", errorMessage: "Person is missing Id"));
	}

	[TestMethod]
	public void ArgumentIsConditionWithCountTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(10);

		try
		{
			var result = people.ArgumentMeetsCondition(people.Count == 10);

			Assert.IsNotNull(result);
		}
		catch
		{
			Assert.Fail();
		}
	}

	[TestMethod]
	public void ArgumentIsConditionWithDefaultTest()
	{
		try
		{
			var personProper1 = RandomData.GenerateRefPerson<PersonProper>();
			var personProper2 = RandomData.GenerateRefPerson<PersonProper>();

			var result = personProper1.ArgumentMeetsCondition(personProper1.Id == "AA", personProper2, errorMessage: "Person is missing Id");

			Assert.IsTrue(result == personProper2);
		}
		catch
		{
			Assert.Fail();
		}
	}

	[TestMethod]
	public void ArgumentIsDefinedEnumTest()
	{
		var value = BenchMarkStatus.Completed;

		try
		{
			var result = value.ArgumentDefined();

			Assert.AreEqual(value, result);
		}
		catch
		{
			Assert.Fail();
		}

		_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => ((BenchMarkStatus)100).ArgumentDefined());
	}

	[TestMethod]
	public void ArgumentItemsExistsArrayTest()
	{
		try
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10).ToArray();
			var result = people.ArgumentItemsExists(nameof(people));

			Assert.AreEqual(people, result);
		}
		catch
		{
			Assert.Fail();
		}

		// Test null collection
		PersonProper[] nullPeople = null;
		_ = Assert.ThrowsException<ArgumentNullException>(() => nullPeople.ArgumentItemsExists());

	}

	[TestMethod]
	public void ArgumentItemsExistsIEnumerableTest()
	{
		try
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10).AsEnumerable();
			var result = people.ArgumentItemsExists();

			Assert.AreEqual(people, result);
		}
		catch
		{
			Assert.Fail();
		}

		// Test null collection
		IEnumerable<PersonProper> nullPeople = null;
		_ = Assert.ThrowsException<ArgumentNullException>(() => nullPeople.ArgumentItemsExists());

	}

	[TestMethod]
	public void ArgumentItemsExistsListTest()
	{
		try
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10);
			var result = people.ArgumentItemsExists();

			Assert.AreEqual(people, result);
		}
		catch
		{
			Assert.Fail();
		}

		// Test null collection
		List<PersonProper> nullPeople = null;
		_ = Assert.ThrowsException<ArgumentNullException>(() => nullPeople.ArgumentItemsExists());

	}

	[TestMethod]
	public void ArgumentItemsExistsListWithCountTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(10).AsEnumerable();

		try
		{

			var result = people.ArgumentItemsExists(count: 10);
		}
		catch
		{
			Assert.Fail();
		}

		// Test null
		IEnumerable<PersonProper> nullPeople = null;
		_ = Assert.ThrowsException<ArgumentNullException>(() => nullPeople.ArgumentItemsExists(10));

		// Test invalid WordCount
		_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => people.ArgumentItemsExists(5));
	}

	[TestMethod]
	public void ArgumentMatchedTest()
	{
		var expression = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
		var defaultValue = "DefaultValue";
		try
		{
			_ = GoodEmail.ArgumentMatched(expression);
		}
		catch
		{
			Assert.Fail();
		}

		// Test invalid match
		_ = Assert.ThrowsException<ArgumentInvalidException>(() => BadEmail.ArgumentMatched(expression));

		// Test default value
		var result = BadEmail.ArgumentMatched(expression, defaultValue: defaultValue);

		Assert.AreEqual(result, defaultValue);

		// Test null match
		_ = Assert.ThrowsException<ArgumentNullException>(() => GoodEmail.ArgumentMatched(null));

	}

	[TestMethod]
	public void ArgumentNotEmptyParamSpanTest01()
	{
		try
		{
			Span<PersonProper> people = RandomData.GeneratePersonRefCollection<PersonProper>(10).ToArray();

			_ = people.ArgumentNotEmpty();

			Assert.IsTrue(true);
		}
		catch
		{
			Assert.Fail();
		}
	}

	[TestMethod]
	public void ArgumentNotEmptyReadOnlySpanTest01()
	{
		try
		{
			ReadOnlySpan<PersonProper> people = RandomData.GeneratePersonRefCollection<PersonProper>(10).ToArray();

			_ = people.ArgumentNotEmpty();
		}
		catch
		{
			Assert.Fail();
		}
	}

	[TestMethod]
	public void ArgumentNotEmptyReadOnlySpanTest02()
	{
		try
		{
			var people = new ReadOnlySpan<PersonProper>();

			_ = people.ArgumentNotEmpty();

			Assert.Fail();
		}
		catch
		{
			Assert.IsTrue(true);
		}
	}

	[TestMethod]
	public void ArgumentNotEmptySpanTest02()
	{
		try
		{
			var people = new Span<PersonProper>();

			_ = people.ArgumentNotEmpty();

			Assert.Fail();
		}
		catch
		{
			Assert.IsTrue(true);
		}
	}

	[TestMethod]
	public void ArgumentNotNullObjectTest()
	{
		var testPerson = RandomData.GenerateRefPerson<PersonProper>();
		try
		{
			_ = testPerson.ArgumentNotNull();
		}
		catch
		{
			Assert.Fail();
		}

		PersonProper nullPerson = null;
		_ = Assert.ThrowsException<ArgumentNullException>(() => nullPerson.ArgumentNotNull());
	}

	[TestMethod]
	public void ArgumentNotNullObjectWithDefaultTest()
	{
		PersonProper nullPerson = null;
		var defaultPerson = RandomData.GenerateRefPerson<PersonProper>();

		try
		{
			var result = nullPerson.ArgumentNotNull(defaultPerson);

			Assert.AreEqual(result, defaultPerson);
		}
		catch
		{
			Assert.Fail();
		}
	}

	[TestMethod]
	public void ArgumentNotNullOrEmptyGuidTest()
	{
		var value = Guid.NewGuid();
		var defaultValue = Guid.NewGuid();

		try
		{
			_ = value.ArgumentNotNullOrEmpty();
		}
		catch
		{
			Assert.Fail();
		}

		// Test default value
		var result = Guid.Empty.ArgumentNotNullOrEmpty(defaultValue: defaultValue);

		Assert.AreEqual(result, defaultValue);

		// Test Bad value
		_ = Assert.ThrowsException<ArgumentInvalidException>(() => Guid.Empty.ArgumentNotNullOrEmpty());
	}

	[TestMethod]
	public void ArgumentNotNullOrEmptyStringTest()
	{
		var testString = RandomData.GenerateWord(100);
		try
		{
			_ = testString.ArgumentNotNullOrEmpty();
		}
		catch
		{
			Assert.Fail();
		}

		_ = Assert.ThrowsException<ArgumentNullException>(() => string.Empty.ArgumentNotNullOrEmpty());
	}

	[TestMethod]
	public void ArgumentNotNullOrEmptyStringWithDefaultTest()
	{
		var testString = string.Empty;
		var defaultString = RandomData.GenerateWord(20);

		try
		{
			var result = testString.ArgumentNotNullOrEmpty(defaultValue: defaultString);

			Assert.AreEqual(result, defaultString);
		}
		catch
		{
			Assert.Fail();
		}

		_ = Assert.ThrowsException<ArgumentNullException>(() => string.Empty.ArgumentNotNullOrEmpty());
	}

	[TestMethod]
	public void ArgumentNotNullOrEmptyUriTest()
	{
		var uri = new Uri(@"http://dotNetTips.com");

		try
		{
			var result = uri.ArgumentNotNull();
		}
		catch
		{
			Assert.Fail();
		}

		// Test Null Uri
		Uri nullUri = null;
		_ = Assert.ThrowsException<ArgumentNullException>(() => nullUri.ArgumentNotNull());
	}

	[TestMethod]
	public void ArgumentNotNullOrEmptyUriWithDefaultTest()
	{
		Uri uri = null;
		var defaultUri = new Uri(@"http://Spargine.com");

		try
		{
			var result = uri.ArgumentNotNull(defaultUri);

			Assert.AreEqual(result, defaultUri);
		}
		catch
		{
			Assert.Fail();
		}
	}

	[TestMethod]
	public void ArgumentNotNullReadOnlySpanTest()
	{
		var testPeople = new ReadOnlySpan<PersonProper>(RandomData.GeneratePersonRefCollection<PersonProper>(10).ToArray());
		try
		{
			_ = testPeople.ArgumentNotEmpty();
		}
		catch
		{
			Assert.Fail();
		}

		_ = Assert.ThrowsException<ArgumentNullException>(() => ReadOnlySpan<PersonProper>.Empty.ArgumentNotEmpty());
	}

	[TestMethod]
	public void ArgumentNotNullSpanTest()
	{
		var people = new Span<PersonProper>(RandomData.GeneratePersonRefCollection<PersonProper>(10).ToArray());

		try
		{
			var result = people.ArgumentNotEmpty(nameof(people));
		}
		catch
		{
			Assert.Fail();
		}

		_ = Assert.ThrowsException<ArgumentNullException>(() => Span<PersonProper>.Empty.ArgumentNotEmpty());
	}

	[TestMethod]
	public void ArgumentNotReadOnlyListTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(10);

		try
		{
			var result = people.ArgumentNotReadOnly();
		}
		catch
		{
			Assert.Fail();
		}
	}

}
