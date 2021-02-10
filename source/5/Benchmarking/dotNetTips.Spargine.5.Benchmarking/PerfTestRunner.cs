using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Order;
using static BenchmarkDotNet.Attributes.MarkdownExporterAttribute;

namespace dotNetTips.Spargine.Benchmarking
{
	/// <summary>
	/// Class PerfTestRunner.
	/// Implements the <see cref="object" />
	/// </summary>
	/// <seealso cref="object" />
	[CategoriesColumn]
	[CsvExporter]
	[EvaluateOverhead]
	[GcServer(true)]
	[GitHub]
	[HtmlExporter]
	[JsonExporter(indentJson: true)]
	[MarkdownExporter]
	[MemoryDiagnoser]
	[Orderer(SummaryOrderPolicy.Method)]
	[StopOnFirstError(true)]
	public abstract class PerfTestRunner
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
		/// The long test string
		/// </summary>
		protected string LongTestString = "Parsing and formatting are the lifeblood of any modern web app or service: take data off the wire, parse it, manipulate it, format it back out. As such, in .NET Core 2.1 along with bringing up Span<T>, we invested in the formatting and parsing of primitives, from Int32 to DateTime. Many of those changes can be read about in my previous blog posts, but one of the key factors in enabling those performance improvements was in moving a lot of native code to managed. That may be counter-intuitive, in that it’s “common knowledge” that C code is faster than C# code. However, in addition to the gap between them narrowing, having (mostly) safe C# code has made the code base easier to experiment in, so whereas we may have been skittish about tweaking the native implementations, the community-at-large has dived head first into optimizing these implementations wherever possible. That effort continues in full force in .NET Core 3.0, with some very nice rewards reaped.";

		private readonly Consumer _consumer = new Consumer();

		/// <summary>
		/// The test time span
		/// </summary>
		private TimeSpan _testTimeSpan = new TimeSpan(days: 300, hours: 13, minutes: 33, seconds: 34, milliseconds: 9876);

		/// <summary>
		/// Gets the consumer.
		/// </summary>
		/// <value>The consumer.</value>
		protected Consumer Consumer => this._consumer;

		/// <summary>
		/// Gets or sets the test time span.
		/// </summary>
		/// <value>The test time span.</value>
		protected TimeSpan TestTimeSpan
		{
			get
			{
				return this._testTimeSpan;
			}
			set
			{
				this._testTimeSpan = value;
			}
		}

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
			this.Setup();
		}

		/// <summary>
		/// Setups this instance.
		/// </summary>
		public virtual void Setup()
		{
			ConsoleLogger.Default.WriteLine(LogKind.Info, $"Setup() - {this.GetType().FullName}.");
		}

	}
}
