// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 02-07-2021
//
// Last Modified By : David McCarter
// Last Modified On : 04-04-2021
// ***********************************************************************
// <copyright file="JsonSerializationTests.cs" company="dotNetTips.Spargine.Core.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using dotNetTips.Spargine.Core.Serialization;
using dotNetTips.Spargine.Core.Tests.Properties;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spartine.Core.Tests.Serialization
{
	[ExcludeFromCodeCoverage]
	[TestClass]
	public class JsonSerializationTests
	{

		[TestMethod]
		public void SerializeDeserializeTestPersonProper()
		{
			var person = RandomData.GeneratePerson<PersonProper>();

			//Serialize
			var json = JsonSerialization.Serialize(person);

			//For debugging
			//JsonSerialization.SerializeToFile(person, @"C:\dotNetTips.com\DebugOutput\PersonProper.json");

			Assert.IsTrue(string.IsNullOrEmpty(json) == false);

			//Deserialize
			var serializedPerson = JsonSerialization.Deserialize<PersonProper>(Resources.JsonPersonProper);

			Assert.IsNotNull(serializedPerson);
		}

		[TestMethod]
		public void SerializeDeserializeTestPersonRecord()
		{
			var person = RandomData.GeneratePersonCollection(1).First();

			var fileName = @"C:\dotNetTips.com\DebugOutput\PersonRecord.json";

			//For debugging
			JsonSerialization.SerializeToFile(person, fileName);

			Assert.IsTrue(string.IsNullOrEmpty(File.ReadAllText(fileName)) == false);

			//Deserialize
			var serializedPerson = JsonSerialization.DeserializeFromFile<PersonRecord>(fileName);

			Assert.IsNotNull(serializedPerson);
		}

		[TestMethod]
		public void SerializeDeserializeToFileTestPersonProper()
		{
			var person = RandomData.GeneratePerson<PersonProper>();
			const string FileName = @"C:\temp\testdata.json";

			try
			{
				//Serialize
				JsonSerialization.SerializeToFile(person, FileName);

				//Deserialize
				JsonSerialization.DeserializeFromFile<PersonProper>(FileName);
			}
			catch (Exception ex)
			{
				Assert.Fail(ex.Message);
			}

			Assert.ThrowsException<FileNotFoundException>(() => JsonSerialization.DeserializeFromFile<PersonProper>($"{FileName}.bogus"));
		}
	}
}
