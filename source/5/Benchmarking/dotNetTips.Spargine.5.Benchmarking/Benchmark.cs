// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Benchmarking
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 03-01-2021
// ***********************************************************************
// <copyright file="Benchmark.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Order;
using dotNetTips.Spargine.Benchmarking.Properties;
using dotNetTips.Spargine.Extensions;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models;
using Perfolizer.Mathematics.SignificanceTesting;
using static BenchmarkDotNet.Attributes.MarkdownExporterAttribute;
using static BenchmarkDotNet.Attributes.XmlExporterAttribute;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine)
namespace dotNetTips.Spargine.Benchmarking
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
		/// The email1
		/// </summary>
		protected const string Email1 = "dotnetdave@live.com";

		/// <summary>
		/// The email2
		/// </summary>
		protected const string Email2 = TestEmailLowerCase;

		/// <summary>
		/// The failed text
		/// </summary>
		protected const string FailedText = "failed";

		/// <summary>
		/// The lower case string
		/// </summary>
		protected const string LowerCaseString = "david mccarter";

		/// <summary>
		/// The proper case string
		/// </summary>
		protected const string ProperCaseString = "David McCarter";

		/// <summary>
		/// The success text
		/// </summary>
		protected const string SuccessText = "success";

		/// <summary>
		/// The test email lower case
		/// </summary>
		protected const string TestEmailLowerCase = "dotnetdave@live.com";

		/// <summary>
		/// The test email mixed case
		/// </summary>
		protected const string TestEmailMixedCase = "dotNetDave@Live.com";

		/// <summary>
		/// The upper case string
		/// </summary>
		protected const string UpperCaseString = "DAVID MCCARTER";

		/// <summary>
		/// The test date time offset
		/// </summary>
		protected readonly DateTimeOffset TestDateTimeOffset = DateTimeOffset.Now;

		/// <summary>
		/// A long test string
		/// </summary>
		protected string LongTestString = "Parsing and formatting are the lifeblood of any modern web app or service: take data off the wire, parse it, manipulate it, format it back out. As such, in .NET Core 2.1 along with bringing up Span<T>, we invested in the formatting and parsing of primitives, from Int32 to DateTime. Many of those changes can be read about in my previous blog posts, but one of the key factors in enabling those performance improvements was in moving a lot of native code to managed. That may be counter-intuitive, in that it’s “common knowledge” that C code is faster than C# code. However, in addition to the gap between them narrowing, having (mostly) safe C# code has made the code base easier to experiment in, so whereas we may have been skittish about tweaking the native implementations, the community-at-large has dived head first into optimizing these implementations wherever possible. That effort continues in full force in .NET Core 3.0, with some very nice rewards reaped.";

		/// <summary>
		/// The consumer
		/// </summary>
		private readonly Consumer _consumer = new Consumer();

		/// <summary>
		/// Gets or sets a value indicating whether to [launch the debugger].
		/// </summary>
		/// <value><c>true</c> if [launch debugger]; otherwise, <c>false</c>.</value>
		public bool LaunchDebugger { get; set; }

		/// <summary>
		/// Gets the base64 string.
		/// </summary>
		/// <value>The base64 string.</value>
		protected string Base64String { get; private set; }

		/// <summary>
		/// Gets the consumer.
		/// </summary>
		/// <value>The consumer.</value>
		protected Consumer Consumer => this._consumer;

		/// <summary>
		/// Gets the coordinate.
		/// </summary>
		/// <value>The coordinate.</value>
		protected CoordinateProper Coordinate { get; private set; }

		/// <summary>
		/// Gets the json test data person proper.
		/// </summary>
		/// <value>The json test data person proper.</value>
		protected string JsonTestDataPersonProper => Resources.JsonTestDataPersonProper;

		/// <summary>
		/// Gets the json test data person record.
		/// </summary>
		/// <value>The json test data person record.</value>
		protected string JsonTestDataPersonRecord => Resources.JsonTestDataPersonRecord;

		/// <summary>
		/// Gets the person.
		/// </summary>
		/// <value>The person.</value>
		protected virtual PersonProper PersonProper { get; private set; }

		/// <summary>
		/// Gets the person record.
		/// </summary>
		/// <value>The person record.</value>
		protected virtual PersonRecord PersonRecord { get; private set; }


		/// <summary>
		/// Gets the string10 characters.
		/// </summary>
		/// <value>The string10 characters.</value>
		protected string String10Characters { get; private set; }


		/// <summary>
		/// Gets the string15 characters.
		/// </summary>
		/// <value>The string15 characters.</value>
		protected string String15Characters { get; private set; }

		/// <summary>
		/// Gets the string1 empty.
		/// </summary>
		/// <value>The string1 empty.</value>
		protected string StringEmpty { get; private set; } = string.Empty;

		/// <summary>
		/// Gets the string1 null.
		/// </summary>
		/// <value>The string1 null.</value>
		protected string StringNull { get; private set; } = null;

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
			ConsoleLogger.Default.WriteLine(LogKind.Info, $"Cleanup() - {this.GetType().FullName}.");
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
				Debugger.Launch();
			}

			this.Setup();
		}

		/// <summary>
		/// Setups this instance.
		/// </summary>
		public virtual void Setup()
		{
			ConsoleLogger.Default.WriteLine(LogKind.Info, $"Setup() - {this.GetType().FullName}.");

			this.Base64String = this.StringToTrim.ToBase64();

			this.PersonProper = RandomData.GeneratePerson<PersonProper>();

			this.PersonRecord = RandomData.GeneratePersonCollection(1).First();

			this.StringToTrim = "         " + this.LongTestString + "                   ";

			this.String10Characters = RandomData.GenerateWord(10);
			this.String10Characters = RandomData.GenerateWord(15);

			this.Coordinate = RandomData.GenerateCoordinate<CoordinateProper>();
		}
	}
}
