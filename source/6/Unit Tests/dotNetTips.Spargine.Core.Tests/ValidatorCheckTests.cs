// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 04-13-2022
//
// Last Modified By : David McCarter
// Last Modified On : 04-24-2022
// ***********************************************************************
// <copyright file="ValidatorCheckTests.cs" company="dotNetTips.Spargine.Core.Tests">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace dotNetTips.Spargine.Core.Tests
{
	[ExcludeFromCodeCoverage]
	[TestClass]
	public class ValidatorCheckTests
	{
		[TestMethod]
		public void ArgumentIsInRangeDateTimeTest()
		{
			var lowerValue = new DateTime(2021, 3, 3);
			var outOfRangeLower = new DateTime(1900, 3, 3);
			var outOfRangeUpper = new DateTime(1991, 3, 3);
			var testValue = new DateTime(2022, 3, 20);
			var upperValue = new DateTime(2025, 3, 3);

			Assert.IsTrue(testValue.CheckIsInRange(lowerValue, upperValue));

			Assert.IsFalse(testValue.CheckIsInRange(outOfRangeLower, outOfRangeUpper));

			// Test Exception throwing.
			_ = Assert.ThrowsException<InvalidValueException<DateTime>>(() => testValue.CheckIsInRange(outOfRangeLower, outOfRangeUpper, true));
		}

		[TestMethod]
		public void CheckEqualsTest()
		{

			// Good Test
			Assert.IsTrue(typeof(PersonProper).CheckEquals(typeof(PersonProper)));

			Assert.IsFalse(typeof(PersonProper).CheckEquals(typeof(Person)));

			// Test Exception throwing.
			Assert.ThrowsException<InvalidValueException<Type>>(() => typeof(PersonProper).CheckEquals(typeof(Person), true));
		}

		[TestMethod]
		public void CheckIsDefinedEnumTest()
		{
			var value = BenchMarkStatus.Completed;

			// Good test
			Assert.IsTrue(value.CheckIsDefined());

			// Test Exception throwing.
			_ = Assert.ThrowsException<InvalidValueException<Enum>>(() => ( (BenchMarkStatus)100 ).CheckIsDefined(true));
		}

		[TestMethod]
		public void CheckIsInRangeDateOnlyTest()
		{
			var lowerValue = new DateOnly(2021, 3, 3);
			var upperValue = new DateOnly(2025, 3, 3);
			var testValue = new DateOnly(2022, 3, 20);
			var outOfRangeLowerValue = new DateOnly(1900, 3, 3);
			var outOfRangeUpperValue = new DateOnly(1991, 3, 3);

			Assert.IsTrue(testValue.CheckIsInRange(lowerValue, upperValue));

			Assert.IsFalse(testValue.CheckIsInRange(outOfRangeLowerValue, outOfRangeUpperValue));

			// Test Exception
			_ = Assert.ThrowsException<InvalidValueException<DateOnly>>(() => testValue.CheckIsInRange(outOfRangeLowerValue, outOfRangeUpperValue, true));
		}

		[TestMethod]
		public void CheckIsInRangeDateTimeOffsetTest()
		{
			var lowerValue = new DateTimeOffset(new DateTime(2021, 3, 3));
			var upperValue = new DateTimeOffset(new DateTime(2025, 3, 3));
			var testValue = new DateTimeOffset(new DateTime(2022, 3, 20));
			var outOfRangeLowerValue = new DateTimeOffset(new DateTime(1900, 3, 3));
			var outOfRangeUpperValue = new DateTimeOffset(new DateTime(1991, 3, 3));

			Assert.IsTrue(testValue.CheckIsInRange(lowerValue, upperValue));

			Assert.IsFalse(testValue.CheckIsInRange(outOfRangeLowerValue, outOfRangeUpperValue));

			// Test Exception
			_ = Assert.ThrowsException<InvalidValueException<DateTimeOffset>>(() => testValue.CheckIsInRange(outOfRangeLowerValue, outOfRangeUpperValue, true));
		}

		[TestMethod]
		public void CheckIsInRangeDecimalTest()
		{
			var testValue = 10000m;

			Assert.IsTrue(testValue.CheckIsInRange(0, decimal.MaxValue));

			Assert.IsFalse(testValue.CheckIsInRange(0, 100));

			// Test Exception
			_ = Assert.ThrowsException<InvalidValueException<decimal>>(() => testValue.CheckIsInRange(0, 100, true));
		}

		[TestMethod]
		public void CheckIsInRangeDoubleTest()
		{
			double testValue = 1000;

			Assert.IsTrue(testValue.CheckIsInRange(0, double.MaxValue));

			Assert.IsFalse(testValue.CheckIsInRange(0, 100));

			// Test Exception
			_ = Assert.ThrowsException<InvalidValueException<double>>(() => testValue.CheckIsInRange(0, 100, true));
		}

		[TestMethod]
		public void CheckIsInRangeIntTest()
		{
			var testValue = 1000;

			Assert.IsTrue(testValue.CheckIsInRange(0, int.MaxValue));

			Assert.IsFalse(testValue.CheckIsInRange(0, 100));

			// Test Exception
			_ = Assert.ThrowsException<InvalidValueException<int>>(() => testValue.CheckIsInRange(0, 100, true));
		}

		[TestMethod]
		public void CheckIsInRangeLongTest()
		{
			long testValue = 1000;

			Assert.IsTrue(testValue.CheckIsInRange(0, long.MaxValue));

			Assert.IsFalse(testValue.CheckIsInRange(0, 100));

			// Test Exception
			_ = Assert.ThrowsException<InvalidValueException<long>>(() => testValue.CheckIsInRange(0, 100, true));
		}

		[TestMethod]
		public void CheckIsInRangeTimeOnlyTest()
		{
			var lowerValue = new TimeOnly(1, 3, 3);
			var upperValue = new TimeOnly(10, 3, 3);
			var testValue = new TimeOnly(5, 3, 20);
			var outOfRangeLowerValue = new TimeOnly(1, 3, 3);
			var outOfRangeUpperValue = new TimeOnly(2, 3, 3);

			Assert.IsTrue(testValue.CheckIsInRange(lowerValue, upperValue));

			Assert.IsFalse(testValue.CheckIsInRange(outOfRangeLowerValue, outOfRangeUpperValue));

			// Test Exception
			_ = Assert.ThrowsException<InvalidValueException<TimeOnly>>(() => testValue.CheckIsInRange(outOfRangeLowerValue, outOfRangeUpperValue, true));
		}

		[TestMethod]
		public void CheckIsNotEmptyReadOnlySpanTest01()
		{

			ReadOnlySpan<PersonProper> people = RandomData.GeneratePersonRefCollection<PersonProper>(10).ToArray();
			var emptyPeople = ReadOnlySpan<PersonProper>.Empty;

			Assert.IsTrue(people.CheckIsNotEmpty());

			Assert.IsFalse(emptyPeople.CheckIsNotEmpty());

			// Test Exception
			//_ = Assert.ThrowsException < InvalidValueException<ReadOnlySpan<PersonProper>>(() => emptyPeople.CheckIsNotEmpty(true));

		}

		[TestMethod]
		public void CheckIsNotNullObjectTest()
		{
			var testPerson = RandomData.GenerateRefPerson<PersonProper>();
			PersonProper invalidValue = null;

			Assert.IsTrue(testPerson.CheckIsNotNull());

			Assert.IsFalse(invalidValue.CheckIsNotNull());

			// Test Exception
			_ = Assert.ThrowsException<InvalidValueException<PersonProper>>(() => invalidValue.CheckIsNotNull(true));
		}

		[TestMethod]
		public void CheckIsNotNullOrEmptyGuidTest()
		{
			var value = Guid.NewGuid();

			Assert.IsTrue(value.CheckIsNotEmpty());

			Assert.IsFalse(Guid.Empty.CheckIsNotEmpty());

			// Test Exception
			_ = Assert.ThrowsException<InvalidOperationException>(() => Guid.Empty.CheckIsNotEmpty(true));
		}
		[TestMethod]
		public void CheckItemsExistsIEnumerableTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10).AsEnumerable();
			IEnumerable<PersonProper> nullPeople = null;

			Assert.IsTrue(people.CheckItemsExists());

			Assert.IsFalse(nullPeople.CheckItemsExists());
		}

		[TestMethod]
		public void ConditionCheckTest()
		{
			var personProper = RandomData.GenerateRefPerson<PersonProper>();

			Assert.IsTrue(personProper.CheckIsCondition(personProper.Id.IsNotEmpty(), errorMessage: "Should be true."));
			Assert.IsFalse(personProper.CheckIsCondition(personProper.Id.IsEmpty(), errorMessage: "Should be false."));

			PersonProper nullPerson = null;
			Assert.ThrowsException<InvalidValueException<object>>(() => nullPerson.CheckIsCondition(personProper.Id.IsNotEmpty(), true));
		}

		[TestMethod]
		public void ExistsCheckDirectoryInfoTest()
		{
			var directoryName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			var directoryInfo = new DirectoryInfo(directoryName);

			try
			{
				_ = directoryInfo.CheckExists(true);
			}
			catch
			{
				Assert.Fail();
			}

			DirectoryInfo nullDirectoryInfo = null;
			_ = Assert.ThrowsException<NullReferenceException>(() => nullDirectoryInfo.CheckExists(true));

			_ = Assert.ThrowsException<DotNetTips.Spargine.Core.DirectoryNotFoundException>(() => new DirectoryInfo("fakefile").CheckExists(throwException: true));
		}

		[TestMethod]
		public void ExistsCheckFileInfoTest()
		{
			var fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData, Environment.SpecialFolderOption.DoNotVerify), "tempfileinfotest.dat");

			_ = RandomData.GenerateFile(fileName, 500);

			var fileInfo = new FileInfo(fileName);

			try
			{
				fileInfo.CheckExists(true);
			}
			catch
			{
				Assert.Fail();
			}

			FileInfo nullFileInfo = null;
			_ = Assert.ThrowsException<NullReferenceException>(() => nullFileInfo.CheckExists(true));

			_ = Assert.ThrowsException<FileNotFoundException>(() => new FileInfo("fakefile").CheckExists(true));
		}

		[TestMethod]
		public void IsNotNullCheckTest()
		{
			try
			{
				var personProper = RandomData.GenerateRefPerson<PersonProper>();
				personProper.CheckIsNotNull(throwException: true);
			}
			catch
			{
				Assert.Fail();
			}
		}
	}
}
