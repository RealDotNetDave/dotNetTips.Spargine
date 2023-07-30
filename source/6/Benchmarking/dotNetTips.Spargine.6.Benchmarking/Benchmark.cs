// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Benchmarking
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 07-30-2023
// ***********************************************************************
// <copyright file="Benchmark.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

using System.Diagnostics;
using System.Runtime.CompilerServices;
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
using static BenchmarkDotNet.Attributes.JsonExporterAttribute;
using static BenchmarkDotNet.Attributes.MarkdownExporterAttribute;

namespace DotNetTips.Spargine.Benchmarking;

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
[MemoryDiagnoser(displayGenColumns: false)]
[MinColumn]
[MValueColumn]
[NamespaceColumn]
[Orderer(SummaryOrderPolicy.Method)]
[PlainExporter]
[RankColumn]
[SkewnessColumn]
[StackOverflow]
[StatisticalTestColumn(StatisticalTestKind.Welch, showPValues: true)]
[StopOnFirstError(true)]
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
	/// The lower case string
	/// </summary>
	/// <value>The lower case string.</value>
	public const string LowerCaseString = "john doe";

	/// <summary>
	/// The proper case string
	/// </summary>
	/// <value>The proper case string.</value>
	public const string ProperCaseString = "John Doe";

	/// <summary>
	/// Gets the string10 characters.
	/// </summary>
	/// <value>The string10 characters.</value>
	public const string String10Characters01 = "2ds9JiOtNF";

	/// <summary>
	/// Gets the string10 characters02.
	/// </summary>
	/// <value>The string10 characters02.</value>
	public const string String10Characters02 = "ndA5nJSHnU";

	/// <summary>
	/// Gets the string15 characters.
	/// </summary>
	/// <value>The string15 characters.</value>
	public const string String15Characters01 = "C8IIVjaUi0owZh6";

	/// <summary>
	/// Gets the string15 characters02.
	/// </summary>
	/// <value>The string15 characters02.</value>
	public const string String15Characters02 = "Q7sXguwS9vZpOo6";

	/// <summary>
	/// The test email lower case
	/// </summary>
	/// <value>The test email lower case.</value>
	public const string TestEmailLowerCase = "fake@fakelive.com";

	/// <summary>
	/// The test email mixed case
	/// </summary>
	/// <value>The test email mixed case.</value>
	public const string TestEmailMixedCase = "Fake@FakeLive.com";

	/// <summary>
	/// The upper case string
	/// </summary>
	/// <value>The upper case string.</value>
	public const string UpperCaseString = "JOHN DOE";

	/// <summary>
	/// The byte array cache
	/// </summary>
	private readonly Dictionary<int, byte[]> _byteArrayCache = new();

	/// <summary>
	/// The string array cache
	/// </summary>
	private readonly Dictionary<string, string[]> _stringArrayCache = new();

	/// <summary>
	/// Gets the consumer.
	/// </summary>
	/// <value>The consumer.</value>
	private Consumer Consumer { get; } = new();

	/// <summary>
	/// Cleanups this instance.
	/// </summary>
	public virtual void Cleanup()
	{
		ConsoleLogger.Default.WriteLine(LogKind.Info, $"Cleanup(): {nameof(Benchmark)}.");
	}

	/// <summary>
	/// Consumes the specified object.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="obj">The object.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Consume<T>(T obj)
	{
		this.Consumer.Consume(obj);
	}

	/// <summary>
	/// Consume as an asynchronous operation.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="obj">The object.</param>
	/// <returns>A Task representing the asynchronous operation.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public async Task ConsumeAsync<T>(T obj)
	{
		await Task.Run(() => this.Consumer.Consume(obj)).ConfigureAwait(false);
	}

	/// <summary>
	/// Gets the byte array.
	/// </summary>
	/// <param name="sizeInKb">The size in kb.</param>
	/// <returns>System.Byte[].</returns>
	public byte[] GetByteArray(int sizeInKb)
	{
		sizeInKb = sizeInKb.EnsureMinimum(1);

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

		this.PersonRef01 = RandomData.GenerateRefPerson<Tester.Models.RefTypes.Person>();

		this.PersonRef02 = RandomData.GenerateRefPerson<Tester.Models.RefTypes.Person>();

		this.PersonProperRef02 = RandomData.GenerateRefPerson<PersonProper>();

		this.PersonVal01 = RandomData.GenerateValPerson<Tester.Models.ValueTypes.Person>();

		this.PersonVal02 = RandomData.GenerateValPerson<Tester.Models.ValueTypes.Person>();

		this.PersonRecord01 = RandomData.GeneratePersonRecord();

		this.PersonRecord02 = RandomData.GeneratePersonRecord();

		this.StringToTrim = $"          {this.LongTestString}          ";

		this.CoordinateProper01 = RandomData.GenerateCoordinate<CoordinateProper>();

		this.CoordinateProper02 = RandomData.GenerateCoordinate<CoordinateProper>();

		this.Coordinate01 = RandomData.GenerateCoordinate<Coordinate>();

		this.Coordinate02 = RandomData.GenerateCoordinate<Coordinate>();

		this.TestGuid = Guid.NewGuid();
	}

	/// <summary>
	/// Updates the coord's email address.
	/// </summary>
	/// <param name="person">The coord.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Update(IPerson person)
	{
		if (person is not null)
		{
			person.Email = TestEmailLowerCase;
		}
	}

	/// <summary>
	/// Updates the coord's email address.
	/// </summary>
	/// <param name="person">The coord.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Update(PersonRecord person)
	{
		if (person is not null)
		{
			_ = person with { Email = TestEmailLowerCase };
		}
	}

	/// <summary>
	/// Updates the coord's email address.
	/// </summary>
	/// <param name="coord">The coord.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Update(ICoordinate coord)
	{
		if (coord is not null)
		{
			coord.X = 100;
			coord.Y = 200;
		}
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
	/// Gets the json test data coord proper.
	/// </summary>
	/// <value>The json test data coord proper.</value>
	public static string JsonTestDataPersonProper => Resources.JsonTestDataPersonProper;

	/// <summary>
	/// Gets the json test data coord record.
	/// </summary>
	/// <value>The json test data coord record.</value>
	public static string JsonTestDataPersonRecord => Resources.JsonTestDataPersonRecord;

	/// <summary>
	/// Gets or sets a value indicating whether to [launch the debugger].
	/// </summary>
	/// <value><c>true</c> if [launch debugger]; otherwise, <c>false</c>.</value>
	public bool LaunchDebugger { get; set; }

	/// <summary>
	/// The long test string
	/// </summary>
	/// <value>The long test string.</value>
	public string LongTestString { get; } = "Parsing and formatting are the lifeblood of any modern web app or service: take data off the wire, parse it, manipulate it, format it back out. As such, in .NET Core 2.1 along with bringing up Span<T>, we invested in the formatting and parsing of primitives, from Int32 to DateTime. Many of those changes can be read about in my previous blog posts, but one of the key factors in enabling those performance improvements was in moving a lot of native code to managed. That may be counter-intuitive, in that it’s “common knowledge” that C code is faster than C# code. However, in addition to the gap between them narrowing, having (mostly) safe C# code has made the code base easier to experiment in, so whereas we may have been skittish about tweaking the native implementations, the community-at-large has dived head first into optimizing these implementations wherever possible. That effort continues in full force in .NET Core 3.0, with some very nice rewards reaped.";

	/// <summary>
	/// Gets the coord proper01.
	/// </summary>
	/// <value>The coord proper01.</value>
	public PersonProper PersonProperRef01 { get; private set; }

	/// <summary>
	/// Gets the coord proper02.
	/// </summary>
	/// <value>The coord proper02.</value>
	public PersonProper PersonProperRef02 { get; private set; }

	/// <summary>
	/// Gets the coord record01.
	/// </summary>
	/// <value>The coord record01.</value>
	public PersonRecord PersonRecord01 { get; private set; }

	/// <summary>
	/// Gets the coord record02.
	/// </summary>
	/// <value>The coord record02.</value>
	public PersonRecord PersonRecord02 { get; private set; }

	/// <summary>
	/// Gets the coord ref01.
	/// </summary>
	/// <value>The coord ref01.</value>
	public Tester.Models.RefTypes.Person PersonRef01 { get; private set; }

	/// <summary>
	/// Gets the coord ref02.
	/// </summary>
	/// <value>The coord ref02.</value>
	public Tester.Models.RefTypes.Person PersonRef02 { get; private set; }

	/// <summary>
	/// Gets the coord value01.
	/// </summary>
	/// <value>The coord value01.</value>
	public Tester.Models.ValueTypes.Person PersonVal01 { get; private set; }

	/// <summary>
	/// Gets the coord value02.
	/// </summary>
	/// <value>The coord value02.</value>
	public Tester.Models.ValueTypes.Person PersonVal02 { get; private set; }

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
	/// Gets the test unique identifier.
	/// </summary>
	/// <value>The test unique identifier.</value>
	public Guid TestGuid { get; internal set; }

	/// <summary>
	/// Gets the XML test data.
	/// </summary>
	/// <value>The XML test data.</value>
	public static string XmlTestDataPersonProper => Resources.XmlTestDataPersonProper;

	/// <summary>
	/// Gets the XML test data coord record.
	/// </summary>
	/// <value>The XML test data coord record.</value>
	public static string XmlTestDataPersonRecord => Resources.XmlTestDataPersonRecord;

}
