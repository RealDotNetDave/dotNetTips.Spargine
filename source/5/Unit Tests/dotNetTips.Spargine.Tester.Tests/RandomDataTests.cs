// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Tester.Tests
// Author           : David McCarter
// Created          : 01-05-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-01-2021
// ***********************************************************************
// <copyright file="RandomDataTests.cs" company="dotNetTips.Spargine.Tester.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Extensions;
using dotNetTips.Spargine.Tester.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Spargine.Tester.Tests
{
	[ExcludeFromCodeCoverage]
	[TestClass]
	public class RandomDataTests
	{
		private const int Count = 100;
		private const string FileExtension = "dotnettips.com";
		private const int FileLength = 500;

		[TestMethod]
		public void AddToPersonCollectionTest()
		{
			try
			{
				var people = RandomData.GeneratePersonCollection<PersonProper>(Count);

				var newPeople = new List<PersonProper>();

				foreach (var person in people)
				{
					newPeople.AddIfNotExists(person);
				}

				Assert.IsTrue(newPeople.Count == Count);
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
				Assert.Fail();
			}

		}


		[TestMethod]
		public void ClonePersonProperTest()
		{
			var person = RandomData.GeneratePerson<PersonProper>();

			try
			{
				var personClone = person.Clone<PersonProper>();

				Assert.IsNotNull(personClone);
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
				Assert.Fail();
			}
		}


		[TestMethod]
		public void GenerateByteArrayTest()
		{
			var byteArray = RandomData.GenerateByteArray(.01);

			Assert.IsTrue(byteArray.Length > 0);
		}

		[TestMethod]
		public void GenerateCharacterTest()
		{
			var character = RandomData.GenerateCharacter();

			Assert.IsNotNull(character);
		}

		[TestMethod]
		public void GenerateCharacterTestWithMinMaxCharTest()
		{
			var character = RandomData.GenerateCharacter('A', 'A');

			Assert.IsNotNull(character);

			Assert.IsTrue(character == 'A');
		}

		[TestMethod]
		public void GenerateCoordinateCollectionTest()
		{
			var coordinates = RandomData.GenerateCoordinateCollection<CoordinateProper>(Count);

			Assert.IsNotNull(coordinates);

			Assert.IsTrue(coordinates.Count() == Count);

		}

		[TestMethod]
		public void GenerateCoordinateFixedTest()
		{
			var coordinate = RandomData.GenerateCoordinate<CoordinateProper>();

			Assert.IsNotNull(coordinate);

			Assert.IsNotNull(coordinate.ToString());

		}

		[TestMethod]
		public void GenerateCoordinateTest()
		{
			var coordinate = RandomData.GenerateCoordinate<Coordinate>();

			Assert.IsNotNull(coordinate);

			Assert.IsNotNull(coordinate.ToString());

		}

		[TestMethod]
		public void GenerateDecimalTest()
		{
			var decimalValue = RandomData.GenerateDecimal(0, 100, 2);

			Assert.IsTrue(decimalValue >= 0);
			Assert.IsTrue(decimalValue <= 100);
		}

		[TestMethod]
		public void GenerateDomainExtensionTest()
		{
			var stringValue = RandomData.GenerateDomainExtension();

			Assert.IsNotNull(stringValue);
		}

		[TestMethod]
		public void GenerateEmailAddressTest()
		{
			var stringValue = RandomData.GenerateEmailAddress();

			Assert.IsNotNull(stringValue);
		}

		[TestMethod]
		public void GenerateFilesTest()
		{
			var files = RandomData.GenerateFiles(Count, FileLength);

			Assert.IsNotNull(files);

			Assert.IsNotNull(files.Path);

			Assert.IsTrue(files.Files.Count() == Count);

			this.DeleteFiles(files.Files);
		}

		[TestMethod]
		public void GenerateFilesWithExtTest()
		{
			var files = RandomData.GenerateFiles(Count, FileLength, "test");

			Assert.IsNotNull(files);

			Assert.IsNotNull(files.Path);

			Assert.IsTrue(files.Files.Count() == Count);

			this.DeleteFiles(files.Files);
		}

		[TestMethod]
		public void GenerateFilesWithPathTest()
		{
			var files = RandomData.GenerateFiles(@"c:\temp", Count, FileLength);

			Assert.IsNotNull(files);

			Assert.IsTrue(files.Count() == Count);

			this.DeleteFiles(files);
		}

		[TestMethod]
		public void GenerateFileTest()
		{
			var fileName = RandomData.GenerateFile(@"c:\temp\UnitTest.test", fileLength: FileLength);

			Assert.IsNotNull(fileName);

			var testFile = new FileInfo(fileName);

			Assert.IsTrue(testFile.Exists);

			Assert.IsTrue(FileLength == testFile.Length);

			testFile.Delete();
		}

		[TestMethod]
		public void GenerateGenerateUrlHostNameTest()
		{
			var stringValue = RandomData.GenerateUrlHostName();

			Assert.IsNotNull(stringValue);
		}

		[TestMethod]
		public void GenerateIntegerTest()
		{
			var intValue = RandomData.GenerateInteger(0, 1000);

			Assert.IsTrue(intValue >= 0);
			Assert.IsTrue(intValue <= 1000);
		}

		[TestMethod]
		public void GenerateKeyTest()
		{
			var stringValue = RandomData.GenerateKey();

			Assert.IsNotNull(stringValue);
		}

		[TestMethod]
		public void GenerateNumberTest()
		{
			var stringValue = RandomData.GenerateNumber(15);

			Assert.IsNotNull(stringValue);

			Assert.IsTrue(stringValue.Length == 15);
		}

		[TestMethod]
		public void GeneratePersonCollectionTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(Count);

			Assert.IsNotNull(people);

			Assert.IsTrue(people.Count == Count);

		}

		[TestMethod]
		public void GeneratePersonFixedTest()
		{
			var person = RandomData.GeneratePerson<PersonFixed>();

			Assert.IsNotNull(person);

			Assert.IsNotNull(person.Address1);

			Assert.IsNotNull(person.Address2);

			Assert.IsTrue(person.BornOn > DateTimeOffset.Parse("1/1/1800"));

			Assert.IsNotNull(person.CellPhone);

			Assert.IsNotNull(person.City);

			Assert.IsNotNull(person.Country);

			Assert.IsNotNull(person.Email);

			Assert.IsNotNull(person.FirstName);

			Assert.IsNotNull(person.HomePhone);

			Assert.IsNotNull(person.Id);

			Assert.IsNotNull(person.LastName);

			Assert.IsNotNull(person.PostalCode);

			Assert.IsTrue(person.Age.TotalMinutes > 0);

			Assert.IsNotNull(person.ToString());
		}


		[TestMethod]
		public void GeneratePersonProperTest()
		{
			var person = RandomData.GeneratePerson<PersonProper>();

			Assert.IsNotNull(person);

			Assert.IsNotNull(person.Address1);

			Assert.IsNotNull(person.Address2);

			Assert.IsTrue(person.BornOn > DateTimeOffset.Parse("1/1/1800"));

			Assert.IsNotNull(person.CellPhone);

			Assert.IsNotNull(person.City);

			Assert.IsNotNull(person.Country);

			Assert.IsNotNull(person.Email);

			Assert.IsNotNull(person.FirstName);

			Assert.IsNotNull(person.HomePhone);

			Assert.IsNotNull(person.Id);

			Assert.IsNotNull(person.LastName);

			Assert.IsNotNull(person.PostalCode);

			Assert.IsTrue(person.Age.TotalMinutes > 0);

			Assert.IsNotNull(person.ToString());
		}

		[TestMethod]
		public void GeneratePersonRecordCollectionTest()
		{
			var people = RandomData.GeneratePersonCollection(Count, addressCount: 3);

			Assert.IsNotNull(people);

			Assert.IsTrue(people.Count == Count);

		}

		[TestMethod]
		public void GeneratePersonTest()
		{
			var person = RandomData.GeneratePerson<Person>();

			Assert.IsNotNull(person);

			Assert.IsNotNull(person.Address1);

			Assert.IsNotNull(person.Address2);

			Assert.IsTrue(person.BornOn > DateTimeOffset.Parse("1/1/1800"));

			Assert.IsNotNull(person.CellPhone);

			Assert.IsNotNull(person.City);

			Assert.IsNotNull(person.Country);

			Assert.IsNotNull(person.Email);

			Assert.IsNotNull(person.FirstName);

			Assert.IsNotNull(person.HomePhone);

			Assert.IsNotNull(person.Id);

			Assert.IsNotNull(person.LastName);

			Assert.IsNotNull(person.PostalCode);

			Assert.IsNotNull(person.ToString());
		}

		[TestMethod]
		public void GeneratePhoneNumberUSATest()
		{
			var stringValue = RandomData.GeneratePhoneNumberUSA();

			Assert.IsNotNull(stringValue);
		}


		[TestMethod]
		public void GenerateRandomFileNameAllParamsTest()
		{
			var stringValue = RandomData.GenerateRandomFileName(@"c:\temp", fileNameLength: 10, extension: FileExtension);

			Assert.IsNotNull(stringValue);

			Assert.IsTrue(new FileInfo(stringValue).Name.Length == 10 + FileExtension.Length + 1);

			Assert.IsTrue(stringValue.EndsWith(FileExtension));
		}

		[TestMethod]
		public void GenerateRandomFileNameTest()
		{
			var stringValue = RandomData.GenerateRandomFileName();

			Assert.IsNotNull(stringValue);
		}

		[TestMethod]
		public void GenerateRandomFileNameWithExtTest()
		{
			var stringValue = RandomData.GenerateRandomFileName(fileNameLength: 10, extension: FileExtension);

			Assert.IsNotNull(stringValue);

			Assert.IsTrue(new FileInfo(stringValue).Name.Length == 10 + FileExtension.Length + 1);

			Assert.IsTrue(stringValue.EndsWith(FileExtension));
		}

		[TestMethod]
		public void GenerateRandomFileNameWithPathTest()
		{
			var stringValue = RandomData.GenerateRandomFileName(@"c:\temp");

			Assert.IsNotNull(stringValue);
		}

		[TestMethod]
		public void GenerateRelativeUrlTest()
		{
			var stringValue = RandomData.GenerateRelativeUrl();

			Assert.IsNotNull(stringValue);
		}

		[TestMethod]
		public void GenerateTempFileTest()
		{
			var stringValue = RandomData.GenerateTempFile(FileLength);

			Assert.IsNotNull(stringValue);

			var tempFile = new FileInfo(stringValue);

			Assert.IsTrue(tempFile.Exists);

			Assert.IsTrue(tempFile.Length == FileLength);

			tempFile.Delete();
		}

		[TestMethod]
		public void GenerateUrlHostNameNoProtocolTest()
		{
			var stringValue = RandomData.GenerateUrlHostNameNoProtocol();

			Assert.IsNotNull(stringValue);
		}

		[TestMethod]
		public void GenerateUrlHostNameNoSubDomainTest()
		{
			var stringValue = RandomData.GenerateUrlHostNameNoSubDomain();

			Assert.IsNotNull(stringValue);
		}

		[TestMethod]
		public void GenerateUrlPartTest()
		{
			var stringValue = RandomData.GenerateUrlPart();

			Assert.IsNotNull(stringValue);
		}

		[TestMethod]
		public void GenerateUrlTest()
		{
			var stringValue = RandomData.GenerateUrl();

			Assert.IsNotNull(stringValue);
		}

		[TestMethod]
		public void GenerateWordLengthWithCharactersTest()
		{
			var stringValue = RandomData.GenerateWord(length: 10, minCharacter: 'A', maxCharacter: 'Z');

			Assert.IsNotNull(stringValue);

			Assert.IsTrue(stringValue.Length == 10);
		}

		[TestMethod]
		public void GenerateWordMinMaxLengthTest()
		{
			var stringValue = RandomData.GenerateWord(minLength: 10, maxLength: 25);

			Assert.IsNotNull(stringValue);

			Assert.IsTrue(stringValue.Length >= 10);

			Assert.IsTrue(stringValue.Length <= 25);
		}

		[TestMethod]
		public void GenerateWordMinMaxLengthWithCharactersTest()
		{
			var stringValue = RandomData.GenerateWord(minLength: 5, maxLength: 25, minCharacter: 'A', maxCharacter: 'Z');

			Assert.IsNotNull(stringValue);

			Assert.IsTrue(stringValue.Length >= 5);

			Assert.IsTrue(stringValue.Length <= 25);
		}

		[TestMethod]
		public void GenerateWordsTest()
		{
			const int WordCount = 10;

			var words = RandomData.GenerateWords(WordCount, 10, 25);

			Assert.IsTrue(words.Count == WordCount);
		}

		[TestMethod]
		public void GenerateWordTest()
		{
			var stringValue = RandomData.GenerateWord(25);

			Assert.IsNotNull(stringValue);

			Assert.IsTrue(stringValue.Length == 25);
		}

		[TestMethod]
		public void UpdatePersonRecordTest()
		{
			var person1 = RandomData.GeneratePersonCollection(count: 1, addressCount: 2).First();

			Assert.IsNotNull(person1);

			// Update Postal code
			var person2 = person1 with { CellPhone = "(858) 123-1234" };

			Assert.IsNotNull(person2);

			Debug.WriteLine(person2.ToString());

			Debug.WriteLine(person2.PropertiesToString());
		}

		private void DeleteFiles(IEnumerable<string> files)
		{
			if (files.HasItems() == false)
			{
				return;
			}

			_ = Parallel.ForEach(source: files, body: (fileName) =>
			{
				try
				{
					File.Delete(fileName);
				}
				catch (Exception ex) when (ex is ArgumentException ||
				  ex is ArgumentNullException ||
				  ex is System.IO.DirectoryNotFoundException ||
				  ex is IOException ||
				  ex is NotSupportedException ||
				  ex is PathTooLongException ||
				  ex is UnauthorizedAccessException)
				{
					Trace.WriteLine(ex.GetAllMessages());
				}
			});

		}
	}
}
