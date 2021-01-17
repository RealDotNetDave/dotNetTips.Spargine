// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 11-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 05-26-2020
// ***********************************************************************
// <copyright file="EncapsulationTests.cs" company="dotNetTips.Spargine.Core.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Core.OOP;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Spartine.Core.Tests.OOP
{
	[ExcludeFromCodeCoverage]
	[TestClass]
	public class EncapsulationTests
	{
		private const string _badEmail = "BADEMAIL";
		private const string _badUrl = "123://www.amazon.com";
		private const string _goodEmail = "fakeemail@google.com";
		private const string _goodUrl = "http://www.amazon.com";

		[TestMethod]
		public void TryValidateNullParamTest()
		{
			PersonProper personProper = null;

			Assert.ThrowsException<ArgumentNullException>(() => Encapsulation.TryValidateNullParam(personProper, nameof(personProper)));

			try
			{
				personProper = RandomData.GeneratePerson<PersonProper>();
				Encapsulation.TryValidateNullParam(personProper, nameof(personProper));
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
				Encapsulation.TryValidateParam(people, nameof(people));
			}
			catch
			{
				Assert.Fail();
			}

			// Test null collection
			List<PersonProper> nullPeople = null;
			Assert.ThrowsException<ArgumentNullException>(() => Encapsulation.TryValidateParam(nullPeople, "none"));

		}

		[TestMethod]
		public void TryValidateParamCollectionWithCountTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10);

			try
			{

				Encapsulation.TryValidateParam(people, 10, nameof(people));
			}
			catch
			{
				Assert.Fail();
			}

			// Test null collection
			List<PersonProper> nullPeople = null;
			Assert.ThrowsException<ArgumentNullException>(() => Encapsulation.TryValidateParam(nullPeople, nameof(nullPeople)));

			// Test invalid Count
			Assert.ThrowsException<ArgumentOutOfRangeException>(() => Encapsulation.TryValidateParam(people, 5, nameof(people)));

		}

		[TestMethod]
		public void TryValidateParamConditionTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10);

			try
			{
				Encapsulation.TryValidateParam<ArgumentOutOfRangeException>(people.Count == 10, "None");
			}
			catch
			{
				Assert.Fail();
			}

			Assert.ThrowsException<ArgumentOutOfRangeException>(() => Encapsulation.TryValidateParam<ArgumentOutOfRangeException>(people.Count == 100, "none"));
		}

		[TestMethod]
		public void TryValidateParamDecimalTest()
		{
			Decimal testValue = 10000;

			try
			{
				Encapsulation.TryValidateParam(testValue, 0, decimal.MaxValue, nameof(testValue));
			}
			catch
			{
				Assert.Fail();
			}

			// Test Exception
			Assert.ThrowsException<ArgumentOutOfRangeException>(() => Encapsulation.TryValidateParam(testValue, 0, 100, nameof(testValue)));
		}

		[TestMethod]
		public void TryValidateParamDirectoryInfoTest()
		{
			var directoryName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			var directoryInfo = new DirectoryInfo(directoryName);

			try
			{
				Encapsulation.TryValidateParam(directoryInfo, "None");
			}
			catch
			{
				Assert.Fail();
			}

			DirectoryInfo nullDirectoryInfo = null;
			Assert.ThrowsException<ArgumentNullException>(() => Encapsulation.TryValidateParam(nullDirectoryInfo, "none"));

			Assert.ThrowsException<Spargine.Core.DirectoryNotFoundException>(() => Encapsulation.TryValidateParam(new DirectoryInfo("fakefile"), "none"));
		}

		[TestMethod]
		public void TryValidateParamDoubleTest()
		{
			double testValue = 1000;

			try
			{
				Encapsulation.TryValidateParam(testValue, 0, double.MaxValue, nameof(testValue));
			}
			catch
			{
				Assert.Fail();
			}

			// Test Exception
			Assert.ThrowsException<ArgumentOutOfRangeException>(() => Encapsulation.TryValidateParam(testValue, 0, 100));
		}

		[TestMethod]
		public void TryValidateParamEnumTest()
		{
			var value = BenchMarkStatus.Completed;

			try
			{
				Encapsulation.TryValidateParam(value, "none");
			}
			catch
			{
				Assert.Fail();
			}

			Assert.ThrowsException<ArgumentOutOfRangeException>(() => Encapsulation.TryValidateParam((BenchMarkStatus)100, "none"));
		}

		[TestMethod]
		public void TryValidateParamFileInfoTest()
		{
			var fileName = @"c:\temp\tempfileinfotest.dat";
			var file = RandomData.GenerateFile(fileName, 100);
			var fileInfo = new FileInfo(fileName);

			try
			{
				Encapsulation.TryValidateParam(fileInfo, "None");
			}
			catch
			{
				Assert.Fail();
			}

			FileInfo nullFileInfo = null;
			Assert.ThrowsException<ArgumentNullException>(() => Encapsulation.TryValidateParam(nullFileInfo, "none"));

			Assert.ThrowsException<FileNotFoundException>(() => Encapsulation.TryValidateParam(new FileInfo("fakefile"), "none"));
		}

		[TestMethod]
		public void TryValidateParamGuidTest()
		{
			var value = Guid.NewGuid();

			try
			{
				Encapsulation.TryValidateParam(value, "none");
			}
			catch
			{
				Assert.Fail();
			}

			Assert.ThrowsException<ArgumentInvalidException>(() => Encapsulation.TryValidateParam(Guid.Empty, "none"));
		}

		[TestMethod]
		public void TryValidateParamIntTest()
		{
			int testValue = 1000;

			try
			{
				Encapsulation.TryValidateParam(testValue, 0, int.MaxValue, nameof(testValue));
			}
			catch
			{
				Assert.Fail();
			}

			// Test Exception
			Assert.ThrowsException<ArgumentOutOfRangeException>(() => Encapsulation.TryValidateParam(testValue, 0, 100));
		}

		[TestMethod]
		public void TryValidateParamLongTest()
		{
			long testValue = 1000;

			try
			{
				Encapsulation.TryValidateParam(testValue, 0, long.MaxValue, nameof(testValue));
			}
			catch
			{
				Assert.Fail();
			}

			// Test Exception
			Assert.ThrowsException<ArgumentOutOfRangeException>(() => Encapsulation.TryValidateParam(testValue, 0, 100));
		}

		[TestMethod]
		public void TryValidateParamStringEmailTest()
		{
			try
			{
				Encapsulation.TryValidateParam(_goodEmail, StringType.Email, 1, 100, nameof(_goodEmail));
			}
			catch
			{
				Assert.Fail();
			}

			Assert.ThrowsException<ArgumentOutOfRangeException>(() => Encapsulation.TryValidateParam(_goodEmail, StringType.Email, 100, 200, nameof(_goodEmail)));

			Assert.ThrowsException<ArgumentInvalidException>(() => Encapsulation.TryValidateParam(_badEmail, StringType.Email, 1, 100, nameof(_badEmail)));

		}

		[TestMethod]
		public void TryValidateParamStringLengthTest()
		{
			var testString = RandomData.GenerateWord(100);
			try
			{
				Encapsulation.TryValidateParam(testString, 1, 110, nameof(testString));
			}
			catch
			{
				Assert.Fail();
			}

			Assert.ThrowsException<ArgumentOutOfRangeException>(() => Encapsulation.TryValidateParam(testString, 1, 5, nameof(testString)));
		}

		[TestMethod]
		public void TryValidateParamStringNotSetTest()
		{
			var testString = RandomData.GenerateWord(100);

			try
			{
				Encapsulation.TryValidateParam(testString, StringType.NotSet, 0, 100, nameof(testString));
			}
			catch
			{
				Assert.Fail();
			}


			Assert.ThrowsException<ArgumentOutOfRangeException>(() => Encapsulation.TryValidateParam(testString, StringType.NotSet, 0, 5, "none"));

		}

		[TestMethod]
		public void TryValidateParamStringRegExTest()
		{
			var expression = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");

			try
			{
				Encapsulation.TryValidateParam(_goodEmail, expression, nameof(_goodEmail));
			}
			catch
			{
				Assert.Fail();
			}

			Assert.ThrowsException<ArgumentInvalidException>(() => Encapsulation.TryValidateParam(_badEmail, expression, nameof(_badEmail)));

		}

		[TestMethod]
		public void TryValidateParamStringTest()
		{
			var testString = RandomData.GenerateWord(100);
			try
			{
				Encapsulation.TryValidateParam(testString, "none");
			}
			catch
			{
				Assert.Fail();
			}

			Assert.ThrowsException<ArgumentNullException>(() => Encapsulation.TryValidateParam(string.Empty, "none"));
		}

		[TestMethod]
		public void TryValidateParamStringUrlTest()
		{
			try
			{
				Encapsulation.TryValidateParam(_goodUrl, StringType.Url, 0, 100, nameof(_goodUrl));
			}
			catch
			{
				Assert.Fail();
			}


			Assert.ThrowsException<ArgumentOutOfRangeException>(() => Encapsulation.TryValidateParam(_goodUrl, StringType.Url, 50, 100, "none"));

			Assert.ThrowsException<ArgumentInvalidException>(() => Encapsulation.TryValidateParam(_badUrl, StringType.Url, 0, 100, "none"));
		}


		[TestMethod]
		public void TryValidateParamTypeTest()
		{
			var personProper = RandomData.GeneratePerson<PersonProper>();
			var personRecord = RandomData.GeneratePersonCollection(1).First();

			try
			{
				Encapsulation.TryValidateParam(personProper.GetType(), personProper.GetType(), nameof(personProper));
			}
			catch
			{
				Assert.Fail();
			}

			Assert.ThrowsException<ArgumentInvalidException>(() => Encapsulation.TryValidateParam(personProper.GetType(), personRecord.GetType(), nameof(personProper)));
		}

		[TestMethod]
		public void TryValidateParamUriTest()
		{
			var url = @"http://dotnettips.com";
			var uri = new Uri(url);

			try
			{
				Encapsulation.TryValidateParam(uri, "None");
			}
			catch
			{
				Assert.Fail();
			}

			Uri nullUri = null;
			Assert.ThrowsException<ArgumentInvalidException>(() => Encapsulation.TryValidateParam(nullUri, "none"));
		}

	}
}
