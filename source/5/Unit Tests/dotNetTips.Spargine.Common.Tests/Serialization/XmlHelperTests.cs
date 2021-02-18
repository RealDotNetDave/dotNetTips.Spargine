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
using dotNetTips.Spargine.Core.Xml;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Spartine.Core.Tests.Serialization
{
	[TestClass]
	public class XmlHelperTests
	{

		[TestMethod]
		public void SerializeDeserializeTest()
		{
			var person = RandomData.GeneratePerson<PersonProper>();

			//Serialize
			var xml = XmlHelper.Serialize(person);

			Assert.IsTrue(string.IsNullOrEmpty(xml) == false);

			//Deserialize
			var serializedPerson = XmlHelper.Deserialize<PersonProper>(xml);

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
				XmlHelper.SerializeToXmlFile(person, FileName);

				//Deserialize
				XmlHelper.DeserializeFromXmlFile<PersonProper>(FileName);
			}
			catch (Exception ex)
			{
				Assert.Fail(ex.Message);
			}

			Assert.ThrowsException<FileNotFoundException>(() => XmlHelper.DeserializeFromXmlFile<PersonProper>("XXX"));
		}

		[TestMethod]
		public void StringToXDocumentTest()
		{
			var person = RandomData.GeneratePerson<PersonProper>();

			//Serialize
			var xml = XmlHelper.Serialize(person);

			var result = XmlHelper.StringToXDocument(xml);

			Assert.IsNotNull(result);
		}
	}
}
