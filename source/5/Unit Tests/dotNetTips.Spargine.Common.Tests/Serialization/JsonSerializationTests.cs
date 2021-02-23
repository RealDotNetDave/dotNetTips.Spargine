// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 02-07-2021
//
// Last Modified By : David McCarter
// Last Modified On : 11-03-2020
// ***********************************************************************
// <copyright file="XmlHelperTests.cs" company="dotNetTips.Spargine.Core.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.IO;
using System.Linq;
using dotNetTips.Spargine.Core.Serialization;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spartine.Core.Tests.Serialization
{
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
			JsonSerialization.SerializeToFile(person, @"C:\dotNetTips.com\DebugOutput\PersonProper.json");

			Assert.IsTrue(string.IsNullOrEmpty(json) == false);

			//Deserialize
			var serializedPerson = JsonSerialization.Deserialize<PersonProper>(json);

			Assert.IsNotNull(serializedPerson);
		}

		[TestMethod]
		public void SerializeDeserializeTestPersonRecord()
		{
			var person = RandomData.GeneratePersonCollection(1).First();

			//Serialize
			var json = JsonSerialization.Serialize(person);

			//For debugging
			JsonSerialization.SerializeToFile(person, @"C:\dotNetTips.com\DebugOutput\PersonRecord.json");

			Assert.IsTrue(string.IsNullOrEmpty(json) == false);

			//Deserialize
			var serializedPerson = JsonSerialization.Deserialize<PersonRecord>(json);

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

			Assert.ThrowsException<FileNotFoundException>(() => JsonSerialization.DeserializeFromFile<PersonProper>(FileName));
		}
	}
}
