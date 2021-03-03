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

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spartine.Core.Tests.Serialization
{
	[TestClass]
	public class XmlSerializationTests
	{

		[TestMethod]
		public void SerializeDeserializeTestPersonProper()
		{
			var person = RandomData.GeneratePerson<PersonProper>();

			//Serialize
			var xml = XmlSerialization.Serialize(person);

			//For debugging
			File.WriteAllText(@"C:\dotNetTips.com\DebugOutput\PersonProper.xml", xml);

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

			//For debugging
			File.WriteAllText(@"C:\dotNetTips.com\DebugOutput\PersonRecord.xml", xml);

			Assert.IsTrue(string.IsNullOrEmpty(xml) == false);

			//Deserialize
			var serializedPerson = XmlSerialization.Deserialize<PersonRecord>(xml);

			Assert.IsNotNull(serializedPerson);
		}

		[TestMethod]
		public void SerializeDeserializeToFileTest()
		{
			var person = RandomData.GeneratePerson<PersonProper>();
			const string FileName = @"C:\temp\testxml.xml";

			try
			{
				//Serialize
				XmlSerialization.SerializeToFile(person, FileName);

				//Deserialize
				XmlSerialization.DeserializeFromFile<PersonProper>(FileName);
			}
			catch (Exception ex)
			{
				Assert.Fail(ex.Message);
			}

			Assert.ThrowsException<FileNotFoundException>(() => XmlSerialization.DeserializeFromFile<PersonProper>("XXX"));
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
