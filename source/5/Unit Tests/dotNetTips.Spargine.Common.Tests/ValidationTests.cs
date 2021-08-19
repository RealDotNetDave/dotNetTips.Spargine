// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 11-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 03-30-2021
// ***********************************************************************
// <copyright file="ValidationTests.cs" company="dotNetTips.Spargine.Core.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Extensions;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Spartine.Core.Tests
{
	[ExcludeFromCodeCoverage]
	[TestClass]
	public class ValidationTests
	{
		private const string _badEmail = "BADEMAIL";
		private const string _badUrl = "123://www.amazon.com";
		private const string _goodEmail = "fakeemail@google.com";
		private const string _goodUrl = "http://www.amazon.com";



		[TestMethod]
		public void TryValidateNullTest()
		{
			PersonProper personProper = null;

			_ = Assert.ThrowsException<InvalidValueException<object>>(() => Validate.TryValidateNull(value: personProper, throwException: true));

			try
			{
				personProper = RandomData.GeneratePerson<PersonProper>();
				_ = Validate.TryValidateNull(personProper, throwException: true);
			}
			catch
			{
				Assert.Fail();
			}
		}

		[TestMethod]
		public void TryValidateObjectTest()
		{
			try
			{
				var personProper = RandomData.GeneratePerson<PersonProper>();
				Validate.TryValidateObject<NullReferenceException>(condition: personProper.Id.IsNotEmpty(), "Person is missing Id");
			}
			catch
			{
				Assert.Fail();
			}
		}

		[TestMethod]
		public void TryValidateParamCollectionTest()
		{
			try
			{
				var people = RandomData.GeneratePersonCollection<PersonProper>(10);
				Validate.TryValidateParam(people, nameof(people));
			}
			catch
			{
				Assert.Fail();
			}

			// Test null collection
			List<PersonProper> nullPeople = null;
			_ = Assert.ThrowsException<NullReferenceException>(() => Validate.TryValidateParam(nullPeople, "none"));

		}

		[TestMethod]
		public void TryValidateParamCollectionWithCountTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10);

			try
			{

				Validate.TryValidateParam(people, 10, nameof(people));
			}
			catch
			{
				Assert.Fail();
			}

			// Test null collection
			List<PersonProper> nullPeople = null;
			_ = Assert.ThrowsException<NullReferenceException>(() => Validate.TryValidateParam(nullPeople, nameof(nullPeople)));

			// Test invalid Count
			_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => Validate.TryValidateParam(people, 5, nameof(people)));

		}

		[TestMethod]
		public void TryValidateParamConditionTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10);

			try
			{
				Validate.TryValidateParam<ArgumentOutOfRangeException>(people.Count == 10, "None");
			}
			catch
			{
				Assert.Fail();
			}

			_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => Validate.TryValidateParam<ArgumentOutOfRangeException>(people.Count == 100, "none"));
		}

		[TestMethod]
		public void TryValidateParamDecimalTest()
		{
			Decimal testValue = 10000;

			try
			{
				Validate.TryValidateParam(testValue, 0, decimal.MaxValue, nameof(testValue));
			}
			catch
			{
				Assert.Fail();
			}

			// Test Exception
			_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => Validate.TryValidateParam(testValue, 0, 100, nameof(testValue)));
		}

		[TestMethod]
		public void TryValidateParamDirectoryInfoTest()
		{
			var directoryName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			var directoryInfo = new DirectoryInfo(directoryName);

			try
			{
				Validate.TryValidateParam(directoryInfo, "None");
			}
			catch
			{
				Assert.Fail();
			}

			DirectoryInfo nullDirectoryInfo = null;
			_ = Assert.ThrowsException<NullReferenceException>(() => Validate.TryValidateParam(nullDirectoryInfo, "none"));

			_ = Assert.ThrowsException<Spargine.Core.DirectoryNotFoundException>(() => Validate.TryValidateParam(new DirectoryInfo("fakefile"), "none"));
		}

		[TestMethod]
		public void TryValidateParamDoubleTest()
		{
			double testValue = 1000;

			try
			{
				Validate.TryValidateParam(testValue, 0, double.MaxValue, nameof(testValue));
			}
			catch
			{
				Assert.Fail();
			}

			// Test Exception
			_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => Validate.TryValidateParam(testValue, 0, 100));
		}

		[TestMethod]
		public void TryValidateParamEnumTest()
		{
			var value = BenchMarkStatus.Completed;

			try
			{
				Validate.TryValidateParam(value, "none");
			}
			catch
			{
				Assert.Fail();
			}

			_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => Validate.TryValidateParam((BenchMarkStatus)100, "none"));
		}

		[TestMethod]
		public void TryValidateParamFileInfoTest()
		{
			var fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData, Environment.SpecialFolderOption.DoNotVerify), "tempfileinfotest.dat");

			_ = RandomData.GenerateFile(fileName, 500);

			var fileInfo = new FileInfo(fileName);

			try
			{
				Validate.TryValidateParam(fileInfo, "None");
			}
			catch
			{
				Assert.Fail();
			}

			FileInfo nullFileInfo = null;
			_ = Assert.ThrowsException<NullReferenceException>(() => Validate.TryValidateParam(nullFileInfo, "none"));

			_ = Assert.ThrowsException<FileNotFoundException>(() => Validate.TryValidateParam(new FileInfo("fakefile"), "none"));
		}

		[TestMethod]
		public void TryValidateParamGuidTest()
		{
			var value = Guid.NewGuid();

			try
			{
				Validate.TryValidateParam(value, "none");
			}
			catch
			{
				Assert.Fail();
			}

			_ = Assert.ThrowsException<ArgumentInvalidException>(() => Validate.TryValidateParam(Guid.Empty, "none"));
		}

		[TestMethod]
		public void TryValidateParamIntTest()
		{
			var testValue = 1000;

			try
			{
				Validate.TryValidateParam(testValue, 0, int.MaxValue, nameof(testValue));
			}
			catch
			{
				Assert.Fail();
			}

			// Test Exception
			_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => Validate.TryValidateParam(testValue, 0, 100));
		}

		[TestMethod]
		public void TryValidateParamLongTest()
		{
			long testValue = 1000;

			try
			{
				Validate.TryValidateParam(testValue, 0, long.MaxValue, nameof(testValue));
			}
			catch
			{
				Assert.Fail();
			}

			// Test Exception
			_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => Validate.TryValidateParam(testValue, 0, 100));
		}

		[TestMethod]
		public void TryValidateParamReadOnlySpanTest01()
		{
			try
			{
				ReadOnlySpan<PersonProper> people = RandomData.GeneratePersonCollection<PersonProper>(10).ToArray();

				Validate.TryValidateParam(people, "TEST");

				Assert.IsTrue(true);
			}
			catch
			{
				Assert.Fail();
			}
		}

		[TestMethod]
		public void TryValidateParamReadOnlySpanTest02()
		{
			try
			{
				var people = new ReadOnlySpan<PersonProper>();

				Validate.TryValidateParam(people, "TEST");

				Assert.Fail();
			}
			catch
			{
				Assert.IsTrue(true);
			}
		}

		[TestMethod]
		public void TryValidateParamSpanTest01()
		{
			try
			{
				Span<PersonProper> people = RandomData.GeneratePersonCollection<PersonProper>(10).ToArray();

				Validate.TryValidateParam(people, "TEST");

				Assert.IsTrue(true);
			}
			catch
			{
				Assert.Fail();
			}
		}

		[TestMethod]
		public void TryValidateParamSpanTest02()
		{
			try
			{
				var people = new Span<PersonProper>();

				Validate.TryValidateParam(people, "TEST");

				Assert.Fail();
			}
			catch
			{
				Assert.IsTrue(true);
			}
		}

		[TestMethod]
		public void TryValidateParamStringEmailTest()
		{
			try
			{
				Validate.TryValidateParam(_goodEmail, StringType.Email, 1, 100, nameof(_goodEmail));
			}
			catch
			{
				Assert.Fail();
			}

			_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => Validate.TryValidateParam(_goodEmail, StringType.Email, 100, 200, nameof(_goodEmail)));

			_ = Assert.ThrowsException<ArgumentInvalidException>(() => Validate.TryValidateParam(_badEmail, StringType.Email, 1, 100, nameof(_badEmail)));

		}

		[TestMethod]
		public void TryValidateParamStringLengthTest()
		{
			var testString = RandomData.GenerateWord(100);
			try
			{
				Validate.TryValidateParam(testString, 1, 110, nameof(testString));
			}
			catch
			{
				Assert.Fail();
			}

			_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => Validate.TryValidateParam(testString, 1, 5, nameof(testString)));
		}

		[TestMethod]
		public void TryValidateParamStringNotSetTest()
		{
			var testString = RandomData.GenerateWord(100);

			try
			{
				Validate.TryValidateParam(testString, StringType.NotSet, 0, 100, nameof(testString));
			}
			catch
			{
				Assert.Fail();
			}


			_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => Validate.TryValidateParam(testString, StringType.NotSet, 0, 5, "none"));

		}

		[TestMethod]
		public void TryValidateParamStringRegExTest()
		{
			var expression = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");

			try
			{
				Validate.TryValidateParam(_goodEmail, expression, nameof(_goodEmail));
			}
			catch
			{
				Assert.Fail();
			}

			_ = Assert.ThrowsException<ArgumentInvalidException>(() => Validate.TryValidateParam(_badEmail, expression, nameof(_badEmail)));

		}

		[TestMethod]
		public void TryValidateParamStringTest()
		{
			var testString = RandomData.GenerateWord(100);
			try
			{
				Validate.TryValidateParam(testString, "none");
			}
			catch
			{
				Assert.Fail();
			}

			_ = Assert.ThrowsException<ArgumentNullException>(() => Validate.TryValidateParam(string.Empty, "none"));
		}

		[TestMethod]
		public void TryValidateParamStringUrlTest()
		{
			try
			{
				Validate.TryValidateParam(_goodUrl, StringType.Url, 0, 100, nameof(_goodUrl));
			}
			catch
			{
				Assert.Fail();
			}


			_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => Validate.TryValidateParam(_goodUrl, StringType.Url, 50, 100, "none"));

			_ = Assert.ThrowsException<ArgumentInvalidException>(() => Validate.TryValidateParam(_badUrl, StringType.Url, 0, 100, "none"));
		}


		[TestMethod]
		public void TryValidateParamTypeTest()
		{
			var personProper = RandomData.GeneratePerson<PersonProper>();
			var personRecord = RandomData.GeneratePersonCollection(1).First();

			try
			{
				Validate.TryValidateParam(personProper.GetType(), personProper.GetType(), nameof(personProper));
			}
			catch
			{
				Assert.Fail();
			}

			_ = Assert.ThrowsException<ArgumentInvalidException>(() => Validate.TryValidateParam(personProper.GetType(), personRecord.GetType(), nameof(personProper)));
		}

		[TestMethod]
		public void TryValidateParamUriTest()
		{
			var url = @"http://dotnettips.com";
			var uri = new Uri(url);

			try
			{
				Validate.TryValidateParam(uri, "None");
			}
			catch
			{
				Assert.Fail();
			}

			Uri nullUri = null;
			_ = Assert.ThrowsException<ArgumentInvalidException>(() => Validate.TryValidateParam(nullUri, "none"));
		}
	}
}
