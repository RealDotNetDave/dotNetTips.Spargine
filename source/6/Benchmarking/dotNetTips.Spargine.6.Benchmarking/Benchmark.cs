﻿// ***********************************************************************
// Assembly         : DotNetTips.Spargine.5.Benchmarking
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 05-04-2022
// ***********************************************************************
// <copyright file="Benchmark.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Order;
using DotNetTips.Spargine.Benchmarking.Properties;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Models.ValueTypes;
using Perfolizer.Mathematics.SignificanceTesting;
using static BenchmarkDotNet.Attributes.MarkdownExporterAttribute;
using static BenchmarkDotNet.Attributes.XmlExporterAttribute;

namespace DotNetTips.Spargine.Benchmarking
{
	/// <summary>
	/// PerfTestRunner base class.
	/// Implements the <see cref="object" />
	/// </summary>
	/// <seealso cref="object" />
	[AllStatisticsColumn]
	[AsciiDocExporter]
	[Atlassian]
	[BaselineColumn]
	[CategoriesColumn]
	[ConfidenceIntervalErrorColumn]
	[CsvExporter]
	[CsvMeasurementsExporter]
	[Default]
	[DisassemblyDiagnoser(printSource: true, exportGithubMarkdown: true, exportCombinedDisassemblyReport: true, exportDiff: true)]
	[EvaluateOverhead]
	[Full]
	[GcServer(true)]
	[GitHub]
	[HtmlExporter]
	[IterationsColumn]
	[JsonExporter(indentJson: true)]
	[KurtosisColumn]
	[LogicalGroupColumn]
	[MarkdownExporter]
	[MaxColumn]
	[MemoryDiagnoser]
	[MinColumn]
	[MValueColumn]
	[NamespaceColumn]
	[Orderer(SummaryOrderPolicy.Method)]
	[PlainExporter]
	[RankColumn]
	[RPlotExporter]
	[SkewnessColumn]
	[StackOverflow]
	[StatisticalTestColumn(StatisticalTestKind.Welch, showPValues: true)]
	public abstract class Benchmark
	{
		/// <summary>
		/// The long test string
		/// </summary>
		protected const string LongTestString = "Parsing and formatting are the lifeblood of any modern web app or service: take data off the wire, parse it, manipulate it, format it back out. As such, in .NET Core 2.1 along with bringing up Span<T>, we invested in the formatting and parsing of primitives, from Int32 to DateTime. Many of those changes can be read about in my previous blog posts, but one of the key factors in enabling those performance improvements was in moving a lot of native code to managed. That may be counter-intuitive, in that it’s “common knowledge” that C code is faster than C# code. However, in addition to the gap between them narrowing, having (mostly) safe C# code has made the code base easier to experiment in, so whereas we may have been skittish about tweaking the native implementations, the community-at-large has dived head first into optimizing these implementations wherever possible. That effort continues in full force in .NET Core 3.0, with some very nice rewards reaped.";

		/// <summary>
		/// The lower case string
		/// </summary>
		protected const string LowerCaseString = "john doe";

		/// <summary>
		/// The proper case string
		/// </summary>
		protected const string ProperCaseString = "John Doe";

		/// <summary>
		/// The success text
		/// </summary>
		protected const string SuccessText = "success";

		/// <summary>
		/// The test email lower case
		/// </summary>
		protected const string TestEmailLowerCase = "fake@fakelive.com";

		/// <summary>
		/// The test email mixed case
		/// </summary>
		protected const string TestEmailMixedCase = "Fake@FakeLive.com";

		/// <summary>
		/// The upper case string
		/// </summary>
		protected const string UpperCaseString = "JOHN DOE";

		/// <summary>
		/// Gets the base64 string.
		/// </summary>
		/// <value>The base64 string.</value>
		protected string Base64String { get; private set; }

		/// <summary>
		/// Gets the consumer.
		/// </summary>
		/// <value>The consumer.</value>
		protected Consumer Consumer { get; } = new();

		/// <summary>
		/// Gets the coordinate01.
		/// </summary>
		/// <value>The coordinate01.</value>
		protected Coordinate Coordinate01 { get; private set; }

		/// <summary>
		/// Gets the coordinate02.
		/// </summary>
		/// <value>The coordinate02.</value>
		protected Coordinate Coordinate02 { get; private set; }

		/// <summary>
		/// Gets the coordinate.
		/// </summary>
		/// <value>The coordinate.</value>
		protected CoordinateProper CoordinateProper01 { get; private set; }

		/// <summary>
		/// Gets the coordinate proper02.
		/// </summary>
		/// <value>The coordinate proper02.</value>
		protected CoordinateProper CoordinateProper02 { get; private set; }

		/// <summary>
		/// Gets the json test data person proper.
		/// </summary>
		/// <value>The json test data person proper.</value>
		protected static string JsonTestDataPersonProper => Resources.JsonTestDataPersonProper;

		/// <summary>
		/// Gets the json test data person record.
		/// </summary>
		/// <value>The json test data person record.</value>
		protected static string JsonTestDataPersonRecord => Resources.JsonTestDataPersonRecord;

		/// <summary>
		/// Gets the person proper01.
		/// </summary>
		/// <value>The person proper01.</value>
		protected PersonProper PersonProper01 { get; private set; }

		/// <summary>
		/// Gets the person proper02.
		/// </summary>
		/// <value>The person proper02.</value>
		protected PersonProper PersonProper02 { get; private set; }

		/// <summary>
		/// Gets the person record01.
		/// </summary>
		/// <value>The person record01.</value>
		protected PersonRecord PersonRecord01 { get; private set; }

		/// <summary>
		/// Gets the person record02.
		/// </summary>
		/// <value>The person record02.</value>
		protected PersonRecord PersonRecord02 { get; private set; }

		/// <summary>
		/// Gets the string10 characters.
		/// </summary>
		/// <value>The string10 characters.</value>
		protected string String10Characters01 { get; private set; }

		/// <summary>
		/// Gets the string10 characters02.
		/// </summary>
		/// <value>The string10 characters02.</value>
		protected string String10Characters02 { get; private set; }

		/// <summary>
		/// Gets the string15 characters.
		/// </summary>
		/// <value>The string15 characters.</value>
		protected string String15Characters01 { get; private set; }

		/// <summary>
		/// Gets the string15 characters02.
		/// </summary>
		/// <value>The string15 characters02.</value>
		protected string String15Characters02 { get; private set; }

		/// <summary>
		/// Gets the string1 empty.
		/// </summary>
		/// <value>The string1 empty.</value>
		protected string StringEmpty { get; private set; } = string.Empty;

		/// <summary>
		/// Gets the string1 null.
		/// </summary>
		/// <value>The string1 null.</value>
		protected string StringNull { get; private set; }

		/// <summary>
		/// Gets the string to trim.
		/// </summary>
		/// <value>The string to trim.</value>
		protected virtual string StringToTrim { get; private set; }

		/// <summary>
		/// Gets the XML test data.
		/// </summary>
		/// <value>The XML test data.</value>
		protected string XmlTestDataPersonProper => Resources.XmlTestDataPersonProper;

		/// <summary>
		/// Gets the XML test data person record.
		/// </summary>
		/// <value>The XML test data person record.</value>
		protected string XmlTestDataPersonRecord => Resources.XmlTestDataPersonRecord;


		/// <summary>
		/// Cleanups this instance.
		/// </summary>
		public virtual void Cleanup()
		{
			ConsoleLogger.Default.WriteLine(LogKind.Info, $"Cleanup():{this.GetType().FullName}.");
		}

		/// <summary>
		/// Gets the byte array.
		/// </summary>
		/// <param name="sizeInKb">The size in kb.</param>
		/// <returns>System.Byte[].</returns>
		public byte[] GetByteArray(in int sizeInKb)
		{
			return RandomData.GenerateByteArray(sizeInKb);
		}

		/// <summary>
		/// Gets the string array.
		/// </summary>
		/// <param name="count">The count.</param>
		/// <param name="minLength">The minimum string length.</param>
		/// <param name="maxLength">The maximum string length.</param>
		/// <returns>System.String[].</returns>
		public string[] GetStringArray(in int count, in int minLength, in int maxLength)
		{
			return RandomData.GenerateWords(count, minLength, maxLength).ToArray();
		}

		/// <summary>
		/// Globals the cleanup.
		/// </summary>
		[GlobalCleanup]
		public void GlobalCleanup()
		{
			this.Cleanup();
		}

		/// <summary>
		/// Globals the setup.
		/// </summary>
		[GlobalSetup]
		public void GlobalSetup()
		{
			if (this.LaunchDebugger)
			{
				_ = Debugger.Launch();
			}

			this.Setup();
		}

		/// <summary>
		/// Setups this instance.
		/// </summary>
		public virtual void Setup()
		{
			ConsoleLogger.Default.WriteLine(LogKind.Info, $"Setup():{this.GetType().FullName}.");

			this.Base64String = LongTestString.Substring(1, 50).ToBase64();

			this.PersonProper01 = RandomData.GenerateRefPerson<PersonProper>();

			this.PersonProper02 = RandomData.GenerateRefPerson<PersonProper>();

			this.PersonRecord01 = RandomData.GeneratePersonRecordCollection(1).First();

			this.PersonRecord02 = RandomData.GeneratePersonRecordCollection(1).First();

			this.StringToTrim = $"          {LongTestString}          ";

			this.String10Characters01 = RandomData.GenerateWord(10);

			this.String15Characters01 = RandomData.GenerateWord(15);

			this.String10Characters02 = RandomData.GenerateWord(10);

			this.String15Characters02 = RandomData.GenerateWord(15);

			this.CoordinateProper01 = RandomData.GenerateCoordinate<CoordinateProper>();

			this.CoordinateProper02 = RandomData.GenerateCoordinate<CoordinateProper>();

			this.Coordinate01 = RandomData.GenerateCoordinate<Coordinate>();

			this.Coordinate02 = RandomData.GenerateCoordinate<Coordinate>();

			this.TestGuid = Guid.NewGuid();
		}

		/// <summary>
		/// Gets or sets a value indicating whether to [launch the debugger].
		/// </summary>
		/// <value><c>true</c> if [launch debugger]; otherwise, <c>false</c>.</value>
		public bool LaunchDebugger { get; set; }

		/// <summary>
		/// Gets the test unique identifier.
		/// </summary>
		/// <value>The test unique identifier.</value>
		public Guid TestGuid { get; internal set; }
	}
}