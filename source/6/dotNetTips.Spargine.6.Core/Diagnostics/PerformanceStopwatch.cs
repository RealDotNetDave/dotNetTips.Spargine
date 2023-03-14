// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Core
// Author           : David McCarter
// Created          : 11-11-2020
//
// Last Modified By : David McCarter
// Last Modified On : 01-18-2023
// ***********************************************************************
// <copyright file="PerformanceStopwatch.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Performance Stopwatch</summary>
// ***********************************************************************
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core.Internal;
using Microsoft.Extensions.Logging;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )
namespace DotNetTips.Spargine.Core.Diagnostics;

/// <summary>
/// <see cref="Stopwatch" /> with added features.
/// </summary>
/// <seealso cref="Stopwatch" />
[ExcludeFromCodeCoverage]
[Information(nameof(PerformanceStopwatch), "David McCarter", "11/11/2020", Status = Status.Available, BenchMarkStatus = BenchMarkStatus.NotRequired, Documentation = "bit.ly/SpargineFeb2023")]
public class PerformanceStopwatch : Stopwatch
{
	/// <summary>
	/// The diagnostics
	/// </summary>
	private readonly List<string> _diagnostics = new();

	/// <summary>
	/// Initializes a new instance of the <see cref="PerformanceStopwatch" /> class.
	/// </summary>
	/// <param name="title">The title message.</param>
	private PerformanceStopwatch(string title)
	{
		this.Title = title;
	}

	/// <summary>
	/// Creates the message.
	/// </summary>
	/// <param name="message">The message.</param>
	/// <param name="result">The result.</param>
	/// <returns>System.String.</returns>
	private string CreateMessage(string message, TimeSpan result)
	{
		var formattedMessage = string.Concat(this.Title, message, $" Time: {result.TotalMilliseconds} ms");

		this._diagnostics.Add(formattedMessage);

		return formattedMessage;
	}

	/// <summary>
	/// Starts the new.
	/// </summary>
	/// <param name="title">The title to be used with logging.</param>
	/// <returns>PerformanceStopwatch.</returns>
	[Information(nameof(StartNew), "David McCarter", "11/11/2020", Status = Status.Available)]
	public static PerformanceStopwatch StartNew(string title = ControlChars.EmptyString)
	{
		if (title.HasValue())
		{
			title = string.Concat(title, ControlChars.Colon);
		}
		var sw = new PerformanceStopwatch(title);

		sw.Start();

		return sw;
	}

	/// <summary>
	/// Stops and resets stopwatch.
	/// </summary>
	/// <returns>TimeSpan.</returns>
	[Information(nameof(StopReset), "David McCarter", "11/11/2020", Status = Status.Available)]
	public TimeSpan StopReset()
	{
		this.Stop();
		var result = this.Elapsed;
		this.Reset();

		return result;
	}

	/// <summary>
	/// Stops and resets stopwatch to zero and logs a message.
	/// </summary>
	/// <param name="logger">The logger.</param>
	/// <param name="message">The message.</param>
	/// <returns>TimeSpan.</returns>
	/// <example>
	/// Output: LoadUsers():Call to Database. Time: 1006.3728 ms
	/// </example>
	[Information(nameof(StopReset), "David McCarter", "1/18/2023", Status = Status.Available)]
	public TimeSpan StopReset(ILogger logger, string message)
	{
		var result = this.StopReset();

		logger.WriteInformationMessage(this.CreateMessage(message, result));

		return result;
	}

	/// <summary>
	/// Stops and restarts stopwatch.
	/// </summary>
	/// <returns>TimeSpan.</returns>
	[Information(nameof(StopRestart), "David McCarter", "11/11/2020", Status = Status.Available)]
	public TimeSpan StopRestart()
	{
		var result = this.Elapsed;

		this.Restart();

		return result;
	}

	/// <summary>
	/// Stops and restarts stopwatch and logs a message.
	/// </summary>
	/// <param name="logger">The logger.</param>
	/// <param name="message">The message.</param>
	/// <returns>TimeSpan.</returns>
	/// <example>
	/// Output: LoadUsers():Call to Database. Time: 1006.3728 ms
	/// </example>
	[Information(nameof(StopRestart), "David McCarter", "1/18/2023", Status = Status.Available)]
	public TimeSpan StopRestart(ILogger logger, string message)
	{
		var result = this.StopRestart();

		logger.WriteInformationMessage(this.CreateMessage(message, result));

		return result;
	}

	/// <summary>
	/// Returns a <see cref="string" /> of all the logged messages.
	/// </summary>
	/// <returns>A <see cref="string" /> of all the logged messages.</returns>
	public override string ToString()
	{
		return FastStringBuilder.CombineStrings(Tristate.True, this.Diagnostics.ToArray());
	}

	/// <summary>
	/// Gets the logged messages.
	/// </summary>
	/// <value>The logged messages.</value>
	/// <example>
	/// Output:
	/// GetUsers():Load users from database. Time: 1013.02 ms
	/// GetUsers():Save users to database.Time: 1013.7925 ms
	/// </example>
	public ImmutableArray<string> Diagnostics => this._diagnostics.ToImmutableArray();

	/// <summary>
	/// Gets the title.
	/// </summary>
	/// <value>The title.</value>
	public string Title { get; private set; }
}
