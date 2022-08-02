// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 02-19-2021
//
// Last Modified By : David McCarter
// Last Modified On : 08-01-2022
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

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading
{
	/// <summary>
	/// Collection type PerfTestRunner.
	/// Implements the <see cref="CounterBenchmark" />
	/// </summary>
	/// <seealso cref="CounterBenchmark" />
	[BenchmarkCategory(Categories.Async)]
	public class ChannelQueueCollectionBenchmark : LargeCollectionsBenchmark
	{
		private static async Task AddToQueueAsync(ChannelQueue<PersonProper> channel, IList<PersonProper> people, CancellationToken token)
		{
			foreach (PersonProper person in people)
			{
				await channel.WriteAsync(person, cancellationToken: token).ConfigureAwait(false);
			}

			_ = channel.Lock();
		}

		private static async Task ListenToQueueAsync(ChannelQueue<PersonProper> channel, CancellationToken token)
		{
			await foreach (PersonProper item in channel.ListenAsync(token))
			{
				Trace.WriteLine(item.Email);
			}
		}

		[Benchmark(Description = "WriteAsync")]
		[BenchmarkCategory(Categories.Async)]
		public async Task WriteAsync()
		{
			var channel = new ChannelQueue<PersonProper>();
			PersonProper[] people = this.GetPersonProperRefArray();

			for (var peopleCount = 0; peopleCount < people.Length; peopleCount++)
			{
				await channel.WriteAsync(people[peopleCount]).ConfigureAwait(false);
			}

			Consumer.Consume(channel.Count);
		}

		[Benchmark(Description = "WriteAsync: IEnumerable")]
		[BenchmarkCategory(Categories.Async)]
		public async Task WriteAsyncIEnumerableAsync()
		{
			var channel = new ChannelQueue<PersonProper>();
			PersonProper[] people = this.GetPersonProperRefArray();

			await channel.WriteAsync(people).ConfigureAwait(false);

			Consumer.Consume(channel.Count);
		}

		[Benchmark(Description = "Write & Listen Async")]
		[BenchmarkCategory(Categories.Async)]
		public void WriteListenAsyncTest()
		{
			var channel = new ChannelQueue<PersonProper>();
			PersonProper[] people = this.GetPersonProperRefArray();
			CancellationToken token = CancellationToken.None;

			var tasks = new List<Task>
			{
			AddToQueueAsync(channel, people, token),
			ListenToQueueAsync(channel, token)
			};

			Task.WaitAll(tasks.ToArray());

			Consumer.Consume(channel.Count);
		}

		[Benchmark(Description = "Write & Read Async")]
		[BenchmarkCategory(Categories.Async)]
		public async Task WriteReadAsync()
		{
			var channel = new ChannelQueue<PersonProper>();
			PersonProper[] people = this.GetPersonProperRefArray();

			for (var personCount = 0; personCount < people.Length; personCount++)
			{
				await channel.WriteAsync(people[personCount]).ConfigureAwait(false);
			}

			while (channel.Count > 0)
			{
				Consumer.Consume(await channel.ReadAsync().ConfigureAwait(false));
			}
		}

		[Benchmark(Description = "Write & Read Async: IEnumerable")]
		[BenchmarkCategory(Categories.Async)]
		public async Task WriteReadAsyncIEnumerableAsync()
		{
			var channel = new ChannelQueue<PersonProper>();
			PersonProper[] people = this.GetPersonProperRefArray();

			await channel.WriteAsync(people).ConfigureAwait(false);

			while (channel.Count > 0)
			{
				Consumer.Consume(await channel.ReadAsync().ConfigureAwait(false));
			}
		}
	}
}
