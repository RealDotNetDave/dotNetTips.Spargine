// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 02-07-2021
//
// Last Modified By : David McCarter
// Last Modified On : 11-03-2020
// ***********************************************************************
// <copyright file="XmlHelperTests.cs" company="DotNetTips.Spargine.Core.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Serialization;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace dotNetTips.Spargine.Core.Tests.Serialization
{
	[ExcludeFromCodeCoverage]
	[TestClass]
	public class XmlSerializationTests
	{

		[TestMethod]
		public void SerializeDeserializeTestPersonProper()
		{
			var person = RandomData.GenerateRefPerson<PersonProper>();

			//Serialize
			var xml = XmlSerialization.Serialize(person);

			var fileName = Path.Combine(Environment.GetEnvironmentVariable(EnvironmentKey.APPDATA.ToString()), "PersonProper.xml");

			//For debugging
			File.WriteAllText(fileName, xml);

			Assert.IsTrue(string.IsNullOrEmpty(xml) is false);

			//Deserialize
			var serializedPerson = XmlSerialization.Deserialize<PersonProper>(xml);

			Assert.IsNotNull(serializedPerson);

			File.Delete(fileName);
		}

		[TestMethod]
		public void SerializeDeserializeTestPersonRecord()
		{
			var person = RandomData.GeneratePersonRecordCollection(1).First();

			//Serialize
			var xml = XmlSerialization.Serialize(person);

			var fileName = Path.Combine(Environment.GetEnvironmentVariable(EnvironmentKey.APPDATA.ToString()), "PersonRecord.xml");

			//For debugging
			File.WriteAllText(fileName, xml);

			Assert.IsTrue(string.IsNullOrEmpty(xml) is false);

			//Deserialize
			var serializedPerson = XmlSerialization.Deserialize<PersonRecord>(xml);

			Assert.IsNotNull(serializedPerson);

			File.Delete(fileName);
		}

		[TestMethod]
		public void SerializeDeserializeToFileTest()
		{
			var person = RandomData.GenerateRefPerson<PersonProper>();

			var fileName = Path.Combine(Environment.GetEnvironmentVariable(EnvironmentKey.APPDATA.ToString()), "TestXml.xml");

			try
			{
				//Serialize
				XmlSerialization.SerializeToFile(person, fileName);

				//Deserialize
				_ = XmlSerialization.DeserializeFromFile<PersonProper>(fileName);

				File.Delete(fileName);
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
			var person = RandomData.GenerateRefPerson<PersonProper>();

			//Serialize
			var xml = XmlSerialization.Serialize(person);

			var result = XmlSerialization.StringToXDocument(xml);

			Assert.IsNotNull(result);
		}
	}
}
