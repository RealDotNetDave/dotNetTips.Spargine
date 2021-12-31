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
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Core.Serialization;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spartine.Core.Tests.Serialization
{
	[ExcludeFromCodeCoverage]
	[TestClass]
	public class XmlSerializationTests
	{

		[TestMethod]
		public void SerializeDeserializeTestPersonProper()
		{
			var person = RandomData.GeneratePerson<PersonProper>();

			//Serialize
			var xml = XmlSerialization.Serialize(person);

			var fileName = Path.Combine(Environment.GetEnvironmentVariable(EnvironmentKey.APPDATA.ToString()), "PersonProper.xml");

			//For debugging
			File.WriteAllText(fileName, xml);

			Assert.IsTrue(string.IsNullOrEmpty(xml) == false);

			//Deserialize
			var serializedPerson = XmlSerialization.Deserialize<PersonProper>(xml);

			Assert.IsNotNull(serializedPerson);
		}

		[TestMethod]
		public void SerializeDeserializeTestPersonRecord()
		{
			var person = RandomData.GeneratePersonCollection(1).First();

			//Serialize
			var xml = XmlSerialization.Serialize(person);

			var fileName = Path.Combine(Environment.GetEnvironmentVariable(EnvironmentKey.APPDATA.ToString()), "PersonRecord.xml");

			//For debugging
			File.WriteAllText(fileName, xml);

			Assert.IsTrue(string.IsNullOrEmpty(xml) == false);

			//Deserialize
			var serializedPerson = XmlSerialization.Deserialize<PersonRecord>(xml);

			Assert.IsNotNull(serializedPerson);
		}

		[TestMethod]
		public void SerializeDeserializeToFileTest()
		{
			var person = RandomData.GeneratePerson<PersonProper>();

			var fileName = Path.Combine(Environment.GetEnvironmentVariable(EnvironmentKey.APPDATA.ToString()), "TestXml.xml");

			try
			{
				//Serialize
				XmlSerialization.SerializeToFile(person, fileName);

				//Deserialize
				_ = XmlSerialization.DeserializeFromFile<PersonProper>(fileName);
			}
			catch (Exception ex)
			{
				Assert.Fail(ex.Message);
			}

			_ = Assert.ThrowsException<FileNotFoundException>(() => XmlSerialization.DeserializeFromFile<PersonProper>("XXX"));
		}

		[TestMethod]
		public void StringToXDocumentTest()
		{
			var person = RandomData.GeneratePerson<PersonProper>();

			//Serialize
			var xml = XmlSerialization.Serialize(person);

			var result = XmlSerialization.StringToXDocument(xml);

			Assert.IsNotNull(result);
		}
	}
}
