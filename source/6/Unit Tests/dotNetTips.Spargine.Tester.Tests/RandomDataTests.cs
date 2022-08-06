// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : David McCarter
// Created          : 01-05-2021
//
// Last Modified By : David McCarter
// Last Modified On : 04-23-2022
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
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Models.ValueTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Tester.Tests
{
	/// <summary>
	/// Defines test class RandomDataTests.
	/// </summary>
	[ExcludeFromCodeCoverage]
	[TestClass]
	public class RandomDataTests
	{
		/// <summary>
		/// The count
		/// </summary>
		private const int Count = 100;

		/// <summary>
		/// The file extension
		/// </summary>
		private const string FileExtension = "dotnettips.com";

		/// <summary>
		/// The file length
		/// </summary>
		private const int FileLength = 1500;

		/// <summary>
		/// Deletes the files.
		/// </summary>
		/// <param name="files">The files.</param>
		private void DeleteFiles(IEnumerable<string> files)
		{
			if (files.HasItems() is false)
			{
				return;
			}

			_ = Parallel.ForEach(
				source: files,
				body: (fileName) =>
				{
					try
					{
						File.Delete(fileName);
					}
					catch (Exception ex) when (ex is ArgumentException ||
						ex is ArgumentNullException ||
						ex is DirectoryNotFoundException ||
						ex is IOException ||
						ex is NotSupportedException ||
						ex is PathTooLongException ||
						ex is UnauthorizedAccessException)
					{
						Trace.WriteLine(ex.GetAllMessages());
					}
				});
		}

		/// <summary>
		/// Defines the test method AddToPersonCollectionTest.
		/// </summary>
		[TestMethod]
		public void AddToPersonCollectionTest()
		{
			try
			{
				var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count);

				var newPeople = new List<PersonProper>();

				for (var personCount = 0; personCount < people.FastCount(); personCount++)
				{
					_ = newPeople.AddIfNotExists(people[personCount]);
				}

				Assert.IsTrue(newPeople.FastCount() == Count);
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
				Assert.Fail();
			}
		}

		/// <summary>
		/// Defines the test method ClonePersonProperTest.
		/// </summary>
		[TestMethod]
		public void ClonePersonProperTest()
		{
			var person = RandomData.GenerateRefPerson<PersonProper>();

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

		/// <summary>
		/// Defines the test method GenerateByteArrayTest.
		/// </summary>
		[TestMethod]
		public void GenerateByteArrayTest()
		{
			var byteArray = RandomData.GenerateByteArray(.01);

			Assert.IsTrue(byteArray.Length > 0);
		}

		/// <summary>
		/// Defines the test method GenerateCharacterTest.
		/// </summary>
		[TestMethod]
		public void GenerateCharacterTest()
		{
			var character = RandomData.GenerateCharacter();

			Assert.IsNotNull(character);
		}

		/// <summary>
		/// Defines the test method GenerateCharacterTestWithMinMaxCharTest.
		/// </summary>
		[TestMethod]
		public void GenerateCharacterTestWithMinMaxCharTest()
		{
			var character = RandomData.GenerateCharacter('A', 'C');

			Assert.IsNotNull(character);
		}

		/// <summary>
		/// Defines the test method GenerateCoordinateCollectionTest.
		/// </summary>
		[TestMethod]
		public void GenerateCoordinateCollectionTest()
		{
			var coordinates = RandomData.GenerateCoordinateCollection<CoordinateProper>(Count);

			Assert.IsNotNull(coordinates);

			Assert.IsTrue(coordinates.FastCount() == Count);
		}

		/// <summary>
		/// Defines the test method GenerateCoordinateFixedTest.
		/// </summary>
		[TestMethod]
		public void GenerateCoordinateFixedTest()
		{
			var coordinate = RandomData.GenerateCoordinate<CoordinateProper>();

			Assert.IsNotNull(coordinate);

			Assert.IsNotNull(coordinate.ToString());
		}

		/// <summary>
		/// Defines the test method GenerateCoordinateTest.
		/// </summary>
		[TestMethod]
		public void GenerateCoordinateTest()
		{
			var coordinate = RandomData.GenerateCoordinate<Coordinate>();

			Assert.IsNotNull(coordinate);

			Assert.IsNotNull(coordinate.ToString());
		}

		/// <summary>
		/// Defines the test method GenerateDecimalTest.
		/// </summary>
		[TestMethod]
		public void GenerateDecimalTest()
		{
			var decimalValue = RandomData.GenerateDecimal(0, 100, 2);

			Assert.IsTrue(decimalValue >= 0);
			Assert.IsTrue(decimalValue <= 100);
		}

		/// <summary>
		/// Defines the test method GenerateDomainExtensionTest.
		/// </summary>
		[TestMethod]
		public void GenerateDomainExtensionTest()
		{
			var stringValue = RandomData.GenerateDomainExtension();

			Assert.IsNotNull(stringValue);
		}

		/// <summary>
		/// Defines the test method GenerateEmailAddressTest.
		/// </summary>
		[TestMethod]
		public void GenerateEmailAddressTest()
		{
			var stringValue = RandomData.GenerateEmailAddress();

			Assert.IsNotNull(stringValue);
		}

		/// <summary>
		/// Defines the test method GenerateFilesTest.
		/// </summary>
		[TestMethod]
		public void GenerateFilesTest()
		{
			var files = RandomData.GenerateFiles(Count, FileLength);

			Assert.IsNotNull(files);

			Assert.IsNotNull(files.Path);

			Assert.IsTrue(files.Files.FastCount() == Count);

			this.DeleteFiles(files.Files);
		}

		/// <summary>
		/// Defines the test method GenerateFilesWithExtTest.
		/// </summary>
		[TestMethod]
		public void GenerateFilesWithExtTest()
		{
			var files = RandomData.GenerateFiles(Count, FileLength, "test");

			Assert.IsNotNull(files);

			Assert.IsNotNull(files.Path);

			Assert.IsTrue(files.Files.FastCount() == Count);

			this.DeleteFiles(files.Files);
		}

		/// <summary>
		/// Defines the test method GenerateFilesWithPathTest.
		/// </summary>
		[TestMethod]
		public void GenerateFilesWithPathTest()
		{
			var files = RandomData.GenerateFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData, Environment.SpecialFolderOption.DoNotVerify), Count, FileLength);

			Assert.IsNotNull(files);

			Assert.IsTrue(files.FastCount() == Count);

			this.DeleteFiles(files);
		}

		/// <summary>
		/// Defines the test method GenerateFileTest.
		/// </summary>
		[TestMethod]
		public void GenerateFileTest()
		{
			var fileName = RandomData.GenerateFile(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData, Environment.SpecialFolderOption.DoNotVerify), "UnitTest.test"), fileLength: FileLength);

			Assert.IsNotNull(fileName);

			var testFile = new FileInfo(fileName);

			Assert.IsTrue(testFile.Exists);

			Assert.IsTrue(FileLength == testFile.Length);

			testFile.Delete();
		}

		/// <summary>
		/// Defines the test method GenerateGenerateUrlHostNameTest.
		/// </summary>
		[TestMethod]
		public void GenerateGenerateUrlHostNameTest()
		{
			var stringValue = RandomData.GenerateUrlHostName();

			Assert.IsNotNull(stringValue);
		}

		/// <summary>
		/// Defines the test method GenerateIntegerTest.
		/// </summary>
		[TestMethod]
		public void GenerateIntegerTest()
		{
			var intValue = RandomData.GenerateInteger(0, 1000);

			Assert.IsTrue(intValue >= 0);
			Assert.IsTrue(intValue <= 1000);
		}

		/// <summary>
		/// Defines the test method GenerateKeyTest.
		/// </summary>
		[TestMethod]
		public void GenerateKeyTest()
		{
			var stringValue = RandomData.GenerateKey();

			Assert.IsNotNull(stringValue);
		}

		/// <summary>
		/// Defines the test method GenerateNumberTest.
		/// </summary>
		[TestMethod]
		public void GenerateNumberTest()
		{
			var stringValue = RandomData.GenerateNumber(15);

			Assert.IsNotNull(stringValue);

			Assert.IsTrue(stringValue.Length == 15);
		}

		/// <summary>
		/// Defines the test method GeneratePersonCollectionTest.
		/// </summary>
		[TestMethod]
		public void GeneratePersonCollectionTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count);

			Assert.IsNotNull(people);

			Assert.IsTrue(people.FastCount() == Count);
		}

		/// <summary>
		/// Defines the test method GeneratePersonProperTest.
		/// </summary>
		[TestMethod]
		public void GeneratePersonProperTest()
		{
			var person = RandomData.GenerateRefPerson<PersonProper>();

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

		/// <summary>
		/// Defines the test method GeneratePersonRecordCollectionTest.
		/// </summary>
		[TestMethod]
		public void GeneratePersonRecordCollectionTest()
		{
			var people = RandomData.GeneratePersonRecordCollection(Count, addressCount: 3);

			Assert.IsNotNull(people);

			Assert.IsTrue(people.Count == Count);
		}

		/// <summary>
		/// Defines the test method GeneratePersonTest.
		/// </summary>
		[TestMethod]
		public void GeneratePersonTest()
		{
			var person = RandomData.GenerateRefPerson<Models.RefTypes.Person>();

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

		/// <summary>
		/// Defines the test method GeneratePersonValCollectionTest.
		/// </summary>
		[TestMethod]
		public void GeneratePersonValCollectionTest()
		{
			var result = RandomData.GeneratePersonValCollection(1000);

			Assert.IsTrue(result.FastCount() == 1000);

			Assert.IsTrue(result.ToDictionary(item => item.Id).FastCount() == 1000);

		}

		/// <summary>
		/// Defines the test method GeneratePhoneNumberUSATest.
		/// </summary>
		[TestMethod]
		public void GeneratePhoneNumberUSATest()
		{
			var stringValue = RandomData.GeneratePhoneNumberUSA();

			Assert.IsNotNull(stringValue);
		}

		/// <summary>
		/// Defines the test method GenerateRandomFileNameAllParamsTest.
		/// </summary>
		[TestMethod]
		public void GenerateRandomFileNameAllParamsTest()
		{
			var stringValue = RandomData.GenerateRandomFileName(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData, Environment.SpecialFolderOption.DoNotVerify), fileNameLength: 10, extension: FileExtension);

			Assert.IsNotNull(stringValue);

			Assert.IsTrue(new FileInfo(stringValue).Name.Length == 10 + FileExtension.Length + 1);

			Assert.IsTrue(stringValue.EndsWith(FileExtension));
		}

		/// <summary>
		/// Defines the test method GenerateRandomFileNameTest.
		/// </summary>
		[TestMethod]
		public void GenerateRandomFileNameTest()
		{
			var stringValue = RandomData.GenerateRandomFileName();

			Assert.IsNotNull(stringValue);
		}

		/// <summary>
		/// Defines the test method GenerateRandomFileNameWithExtTest.
		/// </summary>
		[TestMethod]
		public void GenerateRandomFileNameWithExtTest()
		{
			var stringValue = RandomData.GenerateRandomFileName(fileNameLength: 10, extension: FileExtension);

			Assert.IsNotNull(stringValue);

			Assert.IsTrue(new FileInfo(stringValue).Name.Length == 10 + FileExtension.Length + 1);

			Assert.IsTrue(stringValue.EndsWith(FileExtension));
		}

		/// <summary>
		/// Defines the test method GenerateRandomFileNameWithPathTest.
		/// </summary>
		[TestMethod]
		public void GenerateRandomFileNameWithPathTest()
		{
			var stringValue = RandomData.GenerateRandomFileName(
				Environment.GetFolderPath(
					Environment.SpecialFolder.ApplicationData,
					Environment.SpecialFolderOption.DoNotVerify));

			Assert.IsNotNull(stringValue);
		}

		/// <summary>
		/// Defines the test method GenerateRelativeUrlTest.
		/// </summary>
		[TestMethod]
		public void GenerateRelativeUrlTest()
		{
			var stringValue = RandomData.GenerateRelativeUrl();

			Assert.IsNotNull(stringValue);
		}

		/// <summary>
		/// Defines the test method GenerateTempFileTest.
		/// </summary>
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

		/// <summary>
		/// Defines the test method GenerateUrlHostNameNoProtocolTest.
		/// </summary>
		[TestMethod]
		public void GenerateUrlHostNameNoProtocolTest()
		{
			var stringValue = RandomData.GenerateUrlHostNameNoProtocol();

			Assert.IsNotNull(stringValue);
		}

		/// <summary>
		/// Defines the test method GenerateUrlHostNameNoSubDomainTest.
		/// </summary>
		[TestMethod]
		public void GenerateUrlHostNameNoSubDomainTest()
		{
			var stringValue = RandomData.GenerateUrlHostNameNoSubDomain();

			Assert.IsNotNull(stringValue);
		}

		/// <summary>
		/// Defines the test method GenerateUrlPartTest.
		/// </summary>
		[TestMethod]
		public void GenerateUrlPartTest()
		{
			var stringValue = RandomData.GenerateUrlPart();

			Assert.IsNotNull(stringValue);
		}

		/// <summary>
		/// Defines the test method GenerateUrlTest.
		/// </summary>
		[TestMethod]
		public void GenerateUrlTest()
		{
			var stringValue = RandomData.GenerateUrl();

			Assert.IsNotNull(stringValue);
		}

		/// <summary>
		/// Defines the test method GenerateWordLengthWithCharactersTest.
		/// </summary>
		[TestMethod]
		public void GenerateWordLengthWithCharactersTest()
		{
			var stringValue = RandomData.GenerateWord(length: 10, minCharacter: 'A', maxCharacter: 'Z');

			Assert.IsNotNull(stringValue);

			Assert.IsTrue(stringValue.Length == 10);
		}

		/// <summary>
		/// Defines the test method GenerateWordMinMaxLengthTest.
		/// </summary>
		[TestMethod]
		public void GenerateWordMinMaxLengthTest()
		{
			var stringValue = RandomData.GenerateWord(minLength: 10, maxLength: 25);

			Assert.IsNotNull(stringValue);

			Assert.IsTrue(stringValue.Length >= 10);

			Assert.IsTrue(stringValue.Length <= 25);
		}

		/// <summary>
		/// Defines the test method GenerateWordMinMaxLengthWithCharactersTest.
		/// </summary>
		[TestMethod]
		public void GenerateWordMinMaxLengthWithCharactersTest()
		{
			var stringValue = RandomData.GenerateWord(minLength: 5, maxLength: 25, minCharacter: 'A', maxCharacter: 'Z');

			Assert.IsNotNull(stringValue);

			Assert.IsTrue(stringValue.Length >= 5);

			Assert.IsTrue(stringValue.Length <= 25);
		}

		/// <summary>
		/// Defines the test method GenerateWordsTest.
		/// </summary>
		[TestMethod]
		public void GenerateWordsTest()
		{
			const int WordCount = 10;

			var words = RandomData.GenerateWords(WordCount, 10, 25);

			Assert.IsTrue(words.FastCount() == WordCount);
		}

		/// <summary>
		/// Defines the test method GenerateWordTest.
		/// </summary>
		[TestMethod]
		public void GenerateWordTest()
		{
			var stringValue = RandomData.GenerateWord(25);

			Assert.IsNotNull(stringValue);

			Assert.IsTrue(stringValue.Length == 25);
		}

		/// <summary>
		/// Defines the test method UpdatePersonRecordTest.
		/// </summary>
		[TestMethod]
		public void UpdatePersonRecordTest()
		{
			var person1 = RandomData.GeneratePersonRecordCollection(count: 1, addressCount: 2).First();

			Assert.IsNotNull(person1);

			// Update Postal code
			var person2 = person1 with { CellPhone = "(858) 123-1234" };

			Assert.IsNotNull(person2);

			Debug.WriteLine(person2.ToString());

			Debug.WriteLine(person2.PropertiesToString());
		}
	}
}
