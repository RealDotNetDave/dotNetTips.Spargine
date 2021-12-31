// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 07-26-2021
//
// Last Modified By : David McCarter
// Last Modified On : 07-28-2021
// ***********************************************************************
// <copyright file="ChannelQueueTests.cs" company="dotNetTips.Spargine.Core.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png; https://www.spargine.net )
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;
using dotNetTips.Spargine.Core.Collections.Generic.Concurrent;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Spargine.Core.Tests.Collections.Generic.Concurrent
{
	[ExcludeFromCodeCoverage]
	[TestClass]
	public class ChannelQueueTests
	{
		[TestMethod]
		public async Task WriteAsyncTest01()
		{
			var channel = new ChannelQueue<PersonProper>();
			var person = RandomData.GeneratePerson<PersonProper>();
			var token = CancellationToken.None;

			await channel.WriteAsync(person, cancellationToken: token).ConfigureAwait(false);

			Assert.IsTrue(channel.Count == 1);
		}

		[TestMethod]
		public async Task WriteAsyncTest02()
		{
			var channel = new ChannelQueue<PersonProper>();
			var person = RandomData.GeneratePerson<PersonProper>();
			var token = CancellationToken.None;

			_ = channel.Lock();

			try
			{
				await channel.WriteAsync(person, cancellationToken: token).ConfigureAwait(false);
			}
			catch (ChannelClosedException ex)
			{
				Trace.WriteLine(ex);

				Assert.IsTrue(true);
			}
			catch
			{
				Assert.Fail();
			}
		}

		[TestMethod]
		public async Task WriteAsyncTest03()
		{
			var channel = new ChannelQueue<PersonProper>();
			const int Count = 100;

			var people = RandomData.GeneratePersonCollection<PersonProper>(Count);
			var token = CancellationToken.None;

			await channel.WriteAsync(people, lockQueue: true, cancellationToken: token).ConfigureAwait(false);

			Assert.IsTrue(channel.Count == Count);

		}

		[TestMethod]
		public void WriteListenTest01()
		{
			const int Capacity = 100;
			var channel = new ChannelQueue<PersonProper>();
			var people = RandomData.GeneratePersonCollection<PersonProper>(Capacity);
			var token = CancellationToken.None;

			var tasks = new List<Task>();

			tasks.Add(AddToQueueAsync(channel, people, token));

			tasks.Add(ListenToQueue(channel, token));

			Task.WaitAll(tasks.ToArray());

			Assert.IsTrue(channel.Count == 0);
		}

		[TestMethod]
		public async Task WriteReadAsyncTest01()
		{
			var channel = new ChannelQueue<PersonProper>();
			var person = RandomData.GeneratePerson<PersonProper>();
			var token = CancellationToken.None;

			await channel.WriteAsync(person, cancellationToken: token).ConfigureAwait(false);

			Assert.IsTrue(channel.Count == 1);

			_ = await channel.ReadAsync(token).ConfigureAwait(false);

			Assert.IsTrue(channel.Count == 0);
		}

		[TestMethod]
		public async Task WriteReadAsyncTest02()
		{
			var channel = new ChannelQueue<PersonProper>();
			const int Count = 100;

			var people = RandomData.GeneratePersonCollection<PersonProper>(Count);
			var token = CancellationToken.None;

			/// Write
			foreach (var person in people)
			{
				await channel.WriteAsync(person, cancellationToken: token).ConfigureAwait(false);
			}

			Assert.IsTrue(channel.Count == Count);

			/// Read
			do
			{
				_ = await channel.ReadAsync(token).ConfigureAwait(false);

			} while (channel.Count > 0);

			Assert.IsTrue(channel.Count == 0);
		}

		[TestMethod]
		public async Task WriteReadAsyncTest03()
		{
			var channel = new ChannelQueue<PersonProper>();
			const int Count = 5;

			var people = RandomData.GeneratePersonCollection<PersonProper>(Count);
			var token = CancellationToken.None;

			foreach (var person in people)
			{
				await channel.WriteAsync(person, cancellationToken: token).ConfigureAwait(false);
			}

			Assert.IsTrue(channel.Count == Count);

			_ = channel.Lock();

			await foreach (var item in channel.ListenAsync(token))
			{
				Trace.WriteLine(item.Email);
			}

			Assert.IsTrue(channel.Count == 0);
		}

		[TestMethod]
		public async Task WriteReadAsyncTest04()
		{
			const int Capacity = 100;
			var channel = new ChannelQueue<PersonProper>(Capacity);
			var people = RandomData.GeneratePersonCollection<PersonProper>(Capacity);
			var token = CancellationToken.None;

			foreach (var person in people)
			{
				await channel.WriteAsync(person, cancellationToken: token).ConfigureAwait(false);
			}

			Assert.IsTrue(channel.Count == Capacity);

			do
			{
				_ = await channel.ReadAsync(token).ConfigureAwait(false);

			} while (channel.Count != 0);

			Assert.IsTrue(channel.Count == 0);
		}

		private static async Task AddToQueueAsync(ChannelQueue<PersonProper> channel, List<PersonProper> people, CancellationToken token)
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
				Debug.WriteLine(item.Email);
			}
		}
	}
}
