// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 02-19-2021
//
// Last Modified By : David McCarter
// Last Modified On : 05-06-2022
// ***********************************************************************
// <copyright file="ChannelQueueCollectionBenchmark.cs" company="DotNetTips.Spargine.Core.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Collections.Generic.Concurrent;
using DotNetTips.Spargine.Tester.Models.RefTypes;

namespace DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading
{
	/// <summary>
	/// Collection type PerfTestRunner.
	/// Implements the <see cref="CounterBenchmark" />
	/// </summary>
	/// <seealso cref="CounterBenchmark" />
	[BenchmarkCategory(Categories.Async)]
	public class ChannelQueueCollectionBenchmark : LargeCollectionBenchmark
	{
		[Benchmark(Description = "WriteAsync")]
		[BenchmarkCategory(Categories.Async)]
		public async Task WriteAsync01()
		{
			var channel = new ChannelQueue<PersonProper>();
			var people = this.GetPersonProperArray(Tristate.False);

			for (var peopleCount = 0; peopleCount < people.Length; peopleCount++)
			{
				await channel.WriteAsync(people[peopleCount]).ConfigureAwait(false);
			}

			this.Consumer.Consume(channel.Count);
		}

		[Benchmark(Description = "WriteAsync: IEnumerable")]
		[BenchmarkCategory(Categories.Async)]
		public async Task WriteAsync02()
		{
			var channel = new ChannelQueue<PersonProper>();
			var people = this.GetPersonProperArray(Tristate.False);

			await channel.WriteAsync(people).ConfigureAwait(false);

			this.Consumer.Consume(channel.Count);
		}


		[Benchmark(Description = "Write & Listen Async")]
		[BenchmarkCategory(Categories.Async)]
		public void WriteListenTest01()
		{
			var channel = new ChannelQueue<PersonProper>();
			var people = this.GetPersonProperArray(Tristate.False);
			var token = CancellationToken.None;

			var tasks = new List<Task>
			{
				AddToQueue(channel, people, token),
				ListenToQueue(channel, token)
			};

			Task.WaitAll(tasks.ToArray());

			this.Consumer.Consume(channel.Count);
		}

		[Benchmark(Description = "Write & Read Async")]
		[BenchmarkCategory(Categories.Async)]
		public async Task WriteReadAsync01()
		{
			var channel = new ChannelQueue<PersonProper>();
			var people = this.GetPersonProperArray(Tristate.False);

			for (var personCount = 0; personCount < people.Length; personCount++)
			{
				await channel.WriteAsync(people[personCount]).ConfigureAwait(false);
			}

			while (channel.Count > 0)
			{
				this.Consumer.Consume(await channel.ReadAsync().ConfigureAwait(false));
			}
		}

		[Benchmark(Description = "Write & Read Async: IEnumerable")]
		[BenchmarkCategory(Categories.Async)]
		public async Task WriteReadAsync02()
		{
			var channel = new ChannelQueue<PersonProper>();
			var people = this.GetPersonProperArray(Tristate.False);

			await channel.WriteAsync(people).ConfigureAwait(false);

			while (channel.Count > 0)
			{
				this.Consumer.Consume(await channel.ReadAsync().ConfigureAwait(false));
			}
		}

		private static async Task AddToQueue(ChannelQueue<PersonProper> channel, IList<PersonProper> people, CancellationToken token)
		{
			foreach (var person in people)
			{
				await channel.WriteAsync(person, cancellationToken: token).ConfigureAwait(false);
			}

			_ = channel.Lock();
		}

		private static async Task ListenToQueue(ChannelQueue<PersonProper> channel, CancellationToken token)
		{
			await foreach (var item in channel.ListenAsync(token))
			{
				Trace.WriteLine(item.Email);
			}
		}
	}
}
