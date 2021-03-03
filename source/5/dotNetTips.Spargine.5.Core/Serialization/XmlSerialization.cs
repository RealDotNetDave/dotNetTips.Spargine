// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Core
// Author           : David McCarter
// Created          : 02-07-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-22-2021
// ***********************************************************************
// <copyright file="XmlSerialization.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Core.Serialization
{
	/// <summary>
	/// XML Serialization helper methods.
	/// </summary>
	public static class XmlSerialization
	{
		/// <summary>
		/// Deserialize the specified XML.
		/// </summary>
		/// <typeparam name="TResult">Type.</typeparam>
		/// <param name="xml">The XML.</param>
		/// <returns>T.</returns>
		/// <exception cref="ArgumentNullException">xml.</exception>
		[Information(nameof(Deserialize), BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static TResult Deserialize<TResult>(string xml) where TResult : class
		{
			Validate.TryValidateParam(xml, nameof(xml));

			using var sr = new StringReader(xml);
			var xs = new XmlSerializer(typeof(TResult));

			return (TResult)xs.Deserialize(sr);
		}

		/// <summary>
		/// De-serializes from XML file.
		/// </summary>
		/// <typeparam name="TResult">Type.</typeparam>
		/// <param name="fileName">Name of the file.</param>
		/// <returns>T.</returns>
		/// <exception cref="System.IO.FileNotFoundException">File not found. Cannot deserialize from XML.</exception>
		/// <exception cref="FileNotFoundException">File not found. Cannot deserialize from XML.</exception>
		[Information(nameof(DeserializeFromFile), BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static TResult DeserializeFromFile<TResult>(string fileName) where TResult : class
		{
			Validate.TryValidateParam(fileName, nameof(fileName));

			if (File.Exists(fileName) == false)
			{
				throw new FileNotFoundException("File not found. Cannot deserialize from XML.", fileName);
			}

			return Deserialize<TResult>(File.ReadAllText(fileName));
		}

		/// <summary>
		/// Serializes the specified obj to xml.
		/// </summary>
		/// <param name="obj">The obj.</param>
		/// <returns>System.String.</returns>
		/// <exception cref="ArgumentNullException">obj.</exception>
		[Information(nameof(Serialize), BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static string Serialize(object obj)
		{
			Validate.TryValidateParam<ArgumentNullException>(obj != null, nameof(obj));

			using var writer = new StringWriter();
			using var xmlWriter = XmlWriter.Create(writer);

			var serializer = new XmlSerializer(obj.GetType());
			serializer.Serialize(xmlWriter, obj);

			return writer.ToString();
		}

		/// <summary>
		/// Serializes obj to XML file.
		/// </summary>
		/// <param name="obj">The obj.</param>
		/// <param name="fileName">Name of the file.</param>
		[Information(nameof(SerializeToFile), BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static void SerializeToFile(object obj, string fileName)
		{
			Validate.TryValidateParam<ArgumentNullException>(obj != null, nameof(obj));
			Validate.TryValidateParam(fileName, nameof(fileName));

			if (File.Exists(fileName))
			{
				File.Delete(fileName);
			}

			File.WriteAllText(fileName, Serialize(obj));
		}

		/// <summary>
		/// Securely convert string to XDocument.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <returns>XDocument.</returns>
		[Information(nameof(StringToXDocument), "David McCarter", "9/9/2020", "9/9/2020", Status = Status.Available, UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None)]
		public static XDocument StringToXDocument(string input)
		{
			return StringToXDocument(input, null);
		}

		/// <summary>
		/// Securely convert string to XDocument.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <param name="resolver">The resolver.</param>
		/// <returns>XDocument.</returns>
		/// <remarks>Uses DtdProcessing.Prohibit.</remarks>
		[Information(nameof(StringToXDocument), "David McCarter", "9/9/2020", "9/9/2020", Status = Status.Available, UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None)]
		public static XDocument StringToXDocument(string input, XmlResolver resolver)
		{
			Validate.TryValidateParam(input, nameof(input));

			var options = new XmlReaderSettings { DtdProcessing = DtdProcessing.Prohibit, XmlResolver = resolver };

			using var reader = XmlReader.Create(new StringReader(input), options);

			return XDocument.Load(reader);
		}
	}
}
