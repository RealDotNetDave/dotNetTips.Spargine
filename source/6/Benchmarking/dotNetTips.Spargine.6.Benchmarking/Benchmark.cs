// ***********************************************************************
// Assembly         : DotNetTips.Spargine.5.Benchmarking
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 07-28-2022
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

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Benchmarking
{
	/// <summary>
	/// Base class for benchmark tests.
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
	[MemoryDiagnoser(displayGenColumns: true)]
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
		/// The failed text
		/// </summary>
		protected const string FailedText = "failed";

		/// <summary>
		/// The success text
		/// </summary>
		protected const string SuccessText = "success";

		/// <summary>
		/// The byte array cache
		/// </summary>
		private readonly Dictionary<int, byte[]> _byteArrayCache = new Dictionary<int, byte[]>();

		/// <summary>
		/// The string array cache
		/// </summary>
		private readonly Dictionary<string, string[]> _stringArrayCache = new Dictionary<string, string[]>();

		/// <summary>
		/// Gets the consumer.
		/// </summary>
		/// <value>The consumer.</value>
		protected Consumer Consumer { get; } = new();

		/// <summary>
		/// Cleanups this instance.
		/// </summary>
		public virtual void Cleanup()
		{
			ConsoleLogger.Default.WriteLine(LogKind.Info, $"Cleanup(): {nameof(Benchmark)}.");
		}

		/// <summary>
		/// Gets the byte array.
		/// </summary>
		/// <param name="sizeInKb">The size in kb.</param>
		/// <returns>System.Byte[].</returns>
		public byte[] GetByteArray(int sizeInKb)
		{
			if (this._byteArrayCache.ContainsKey(sizeInKb) is false)
			{
				this._byteArrayCache.Add(sizeInKb, RandomData.GenerateByteArray(sizeInKb));
			}

			return this._byteArrayCache[sizeInKb];
		}

		/// <summary>
		/// Gets the string array.
		/// </summary>
		/// <param name="count">The count.</param>
		/// <param name="wordMinLength">The minimum string length for the generated word.</param>
		/// <param name="wordMaxLength">The maximum string length for the generated word.</param>
		/// <returns>System.String[].</returns>
		public string[] GetStringArray(int count, int wordMinLength = 10, int wordMaxLength = 15)
		{
			//Ensure maxLenth is at least +1 of minLength.
			wordMinLength = wordMinLength.EnsureMinimum(1);
			wordMaxLength = wordMaxLength.EnsureMinimum(wordMinLength + 1);

			var key = $"{count}-{wordMinLength}-{wordMaxLength}";

			if (this._stringArrayCache.ContainsKey(key) is false)
			{
				this._stringArrayCache.Add(key, RandomData.GenerateWords(count, wordMinLength, wordMaxLength).ToArray());
			}

			return this._stringArrayCache[key];
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
				ConsoleLogger.Default.WriteLine(LogKind.Info, $"Launching debugger: {nameof(Benchmark)}.");
				_ = Debugger.Launch();
			}

			this.Setup();
		}

		/// <summary>
		/// Setups this instance.
		/// </summary>
		public virtual void Setup()
		{
			ConsoleLogger.Default.WriteLine(LogKind.Info, $"Setup(): {nameof(Benchmark)}.");

			this.Base64String = this.LongTestString.Substring(1, 50).ToBase64();

			this.PersonProperRef01 = RandomData.GenerateRefPerson<PersonProper>();

			this.PersonProperRef02 = RandomData.GenerateRefPerson<PersonProper>();

			this.PersonVal01 = RandomData.GenerateValPerson();

			this.PersonVal02 = RandomData.GenerateValPerson();

			this.PersonRecord01 = RandomData.GeneratePersonRecordCollection(1).First();

			this.PersonRecord02 = RandomData.GeneratePersonRecordCollection(1).First();

			this.StringToTrim = $"          {this.LongTestString}          ";

			this.String10Characters01 = RandomData.GenerateWord(10);

			this.String15Characters01 = RandomData.GenerateWord(15);

			this.String10Characters02 = RandomData.GenerateWord(10);

			this.String15Characters02 = RandomData.GenerateWord(15);

			this.CoordinateProper01 = RandomData.GenerateCoordinate<CoordinateProper>();

			this.CoordinateProper02 = RandomData.GenerateCoordinate<CoordinateProper>();

			this.Coordinate01 = RandomData.GenerateCoordinate<Coordinate>();

			this.Coordinate02 = RandomData.GenerateCoordinate<Coordinate>();

			this.TestGuid = Guid.NewGuid();

			//Setup byte array
			_ = this.GetByteArray(1);

			//Setup string array
			_ = this.GetStringArray(100, 15, 20);
		}

		/// <summary>
		/// Gets the base64 string.
		/// </summary>
		/// <value>The base64 string.</value>
		public string Base64String { get; internal set; }

		/// <summary>
		/// Gets the coordinate01.
		/// </summary>
		/// <value>The coordinate01.</value>
		public Coordinate Coordinate01 { get; private set; }

		/// <summary>
		/// Gets the coordinate02.
		/// </summary>
		/// <value>The coordinate02.</value>
		public Coordinate Coordinate02 { get; private set; }

		/// <summary>
		/// Gets the coordinate.
		/// </summary>
		/// <value>The coordinate.</value>
		public CoordinateProper CoordinateProper01 { get; private set; }

		/// <summary>
		/// Gets the coordinate proper02.
		/// </summary>
		/// <value>The coordinate proper02.</value>
		public CoordinateProper CoordinateProper02 { get; private set; }

		/// <summary>
		/// Gets the json test data person proper.
		/// </summary>
		/// <value>The json test data person proper.</value>
		public static string JsonTestDataPersonProper
		{
			get
			{
				return Resources.JsonTestDataPersonProper;
			}
		}

		/// <summary>
		/// Gets the json test data person record.
		/// </summary>
		/// <value>The json test data person record.</value>
		public static string JsonTestDataPersonRecord
		{
			get
			{
				return Resources.JsonTestDataPersonRecord;
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether to [launch the debugger].
		/// </summary>
		/// <value><c>true</c> if [launch debugger]; otherwise, <c>false</c>.</value>
		public bool LaunchDebugger { get; set; }

		/// <summary>
		/// The long test string
		/// </summary>
		public string LongTestString { get; } = "Parsing and formatting are the lifeblood of any modern web app or service: take data off the wire, parse it, manipulate it, format it back out. As such, in .NET Core 2.1 along with bringing up Span<T>, we invested in the formatting and parsing of primitives, from Int32 to DateTime. Many of those changes can be read about in my previous blog posts, but one of the key factors in enabling those performance improvements was in moving a lot of native code to managed. That may be counter-intuitive, in that it’s “common knowledge” that C code is faster than C# code. However, in addition to the gap between them narrowing, having (mostly) safe C# code has made the code base easier to experiment in, so whereas we may have been skittish about tweaking the native implementations, the community-at-large has dived head first into optimizing these implementations wherever possible. That effort continues in full force in .NET Core 3.0, with some very nice rewards reaped.";

		/// <summary>
		/// The lower case string
		/// </summary>
		public string LowerCaseString { get; } = "john doe";

		/// <summary>
		/// Gets the person proper01.
		/// </summary>
		/// <value>The person proper01.</value>
		public PersonProper PersonProperRef01 { get; private set; }

		/// <summary>
		/// Gets the person proper02.
		/// </summary>
		/// <value>The person proper02.</value>
		public PersonProper PersonProperRef02 { get; private set; }

		/// <summary>
		/// Gets the person record01.
		/// </summary>
		/// <value>The person record01.</value>
		public PersonRecord PersonRecord01 { get; private set; }

		/// <summary>
		/// Gets the person record02.
		/// </summary>
		/// <value>The person record02.</value>
		public PersonRecord PersonRecord02 { get; private set; }

		/// <summary>
		/// Gets the person value01.
		/// </summary>
		/// <value>The person value01.</value>
		public Tester.Models.ValueTypes.Person PersonVal01 { get; private set; }

		/// <summary>
		/// Gets the person value02.
		/// </summary>
		/// <value>The person value02.</value>
		public Tester.Models.ValueTypes.Person PersonVal02 { get; private set; }

		/// <summary>
		/// The proper case string
		/// </summary>
		public string ProperCaseString { get; } = "John Doe";

		/// <summary>
		/// Gets the string10 characters.
		/// </summary>
		/// <value>The string10 characters.</value>
		public string String10Characters01 { get; private set; }

		/// <summary>
		/// Gets the string10 characters02.
		/// </summary>
		/// <value>The string10 characters02.</value>
		public string String10Characters02 { get; private set; }

		/// <summary>
		/// Gets the string15 characters.
		/// </summary>
		/// <value>The string15 characters.</value>
		public string String15Characters01 { get; private set; }

		/// <summary>
		/// Gets the string15 characters02.
		/// </summary>
		/// <value>The string15 characters02.</value>
		public string String15Characters02 { get; private set; }

		/// <summary>
		/// Gets the string1 empty.
		/// </summary>
		/// <value>The string1 empty.</value>
		public string StringEmpty { get; private set; } = string.Empty;

		/// <summary>
		/// Gets the string1 null.
		/// </summary>
		/// <value>The string1 null.</value>
		public string StringNull { get; private set; }

		/// <summary>
		/// Gets the string to trim.
		/// </summary>
		/// <value>The string to trim.</value>
		public virtual string StringToTrim { get; private set; }

		/// <summary>
		/// The test email lower case
		/// </summary>
		public string TestEmailLowerCase { get; } = "fake@fakelive.com";

		/// <summary>
		/// The test email mixed case
		/// </summary>
		public string TestEmailMixedCase { get; } = "Fake@FakeLive.com";

		/// <summary>
		/// Gets the test unique identifier.
		/// </summary>
		/// <value>The test unique identifier.</value>
		public Guid TestGuid { get; internal set; }

		/// <summary>
		/// The upper case string
		/// </summary>
		public string UpperCaseString { get; } = "JOHN DOE";

		/// <summary>
		/// Gets the XML test data.
		/// </summary>
		/// <value>The XML test data.</value>
		public string XmlTestDataPersonProper
		{
			get
			{
				return Resources.XmlTestDataPersonProper;
			}
		}

		/// <summary>
		/// Gets the XML test data person record.
		/// </summary>
		/// <value>The XML test data person record.</value>
		public string XmlTestDataPersonRecord
		{
			get
			{
				return Resources.XmlTestDataPersonRecord;
			}
		}

	}
}
