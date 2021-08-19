// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 02-19-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-20-2021
// ***********************************************************************
// <copyright file="CollectionCollectionPerfTestRunner.cs" company="dotNetTips.Spargine.Core.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using dotNetTips.Spargine.Benchmarking;
using dotNetTips.Spargine.Core.Collections.Generic.Concurrent;
using dotNetTips.Spargine.Tester.Models;

namespace dotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading
{
	/// <summary>
	/// Collection type PerfTestRunner.
	/// Implements the <see cref="dotNetTips.Spargine.Benchmarking.CounterBenchmark" />
	/// </summary>
	/// <seealso cref="dotNetTips.Spargine.Benchmarking.CounterBenchmark" />
	[BenchmarkCategory("Queue")]
	public class ChannelQueueCollectionBenchmark : CollectionBenchmark
	{
		[Benchmark(Description = "WriteAsync")]
		public async Task WriteAsync01()
		{
			var channel = new ChannelQueue<PersonProper>();
			var people = this.PersonProperList;

			for (var peopleCount = 0; peopleCount < people.Count; peopleCount++)
			{
				await channel.WriteAsync(people[peopleCount]).ConfigureAwait(false);
			}

			this.Consumer.Consume(channel.Count);
		}

		[Benchmark(Description = "WriteAsync: IEnumerable")]
		public async Task WriteAsync02()
		{
			var channel = new ChannelQueue<PersonProper>();
			var people = this.PersonProperList;

			await channel.WriteAsync(people).ConfigureAwait(false);

			this.Consumer.Consume(channel.Count);
		}


		[Benchmark(Description = "Write & Listen Async")]
		public void WriteListenTest01()
		{
			var channel = new ChannelQueue<PersonProper>();
			var people = this.PersonProperList;
			var token = CancellationToken.None;

			var tasks = new List<Task>();

			tasks.Add(AddToQueue(channel, people, token));

			tasks.Add(ListenToQueue(channel, token));

			Task.WaitAll(tasks.ToArray());

			this.Consumer.Consume(channel.Count);
		}

		[Benchmark(Description = "Write & Read Async")]
		public async Task WriteReadAsync01()
		{
			var channel = new ChannelQueue<PersonProper>();
			var people = this.PersonProperList;

			for (var personCount = 0; personCount < people.Count; personCount++)
			{
				await channel.WriteAsync(people[personCount]).ConfigureAwait(false);
			}

			while (channel.Count > 0)
			{
				this.Consumer.Consume(await channel.ReadAsync().ConfigureAwait(false));
			}
		}

		[Benchmark(Description = "Write & Read Async: IEnumerable")]
		public async Task WriteReadAsync02()
		{
			var channel = new ChannelQueue<PersonProper>();
			var people = this.PersonProperList;

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

			channel.Lock();
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
