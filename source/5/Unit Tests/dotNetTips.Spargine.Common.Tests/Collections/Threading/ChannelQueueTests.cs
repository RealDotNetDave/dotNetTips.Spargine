// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 07-26-2021
//
// Last Modified By : David McCarter
// Last Modified On : 07-26-2021
// ***********************************************************************
// <copyright file="ChannelQueueTests.cs" company="dotNetTips.Spargine.Core.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;
using dotNetTips.Spargine.Core.Collections;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Spargine.Core.Tests.Collections.Threading
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

			await channel.WriteAsync(person, cancellationToken: token);

			Assert.IsTrue(channel.Count == 1);
		}

		[TestMethod]
		public async Task WriteAsyncTest02()
		{
			var channel = new ChannelQueue<PersonProper>();
			var person = RandomData.GeneratePerson<PersonProper>();
			var token = CancellationToken.None;

			channel.Lock();

			try
			{
				await channel.WriteAsync(person, cancellationToken: token);
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
			var people = RandomData.GeneratePersonCollection<PersonProper>(100);
			var token = CancellationToken.None;

			await channel.WriteAsync(people, lockQueue: true, cancellationToken: token);

			Assert.IsTrue(channel.Count == 100);

		}

		[TestMethod]
		public async Task WriteReadAsyncTest01()
		{
			var channel = new ChannelQueue<PersonProper>();
			var person = RandomData.GeneratePerson<PersonProper>();
			var token = CancellationToken.None;

			await channel.WriteAsync(person, cancellationToken: token);

			Assert.IsTrue(channel.Count == 1);

			var item = await channel.ReadAsync(token);

			Assert.IsTrue(channel.Count == 0);
		}

		[TestMethod]
		public async Task WriteReadAsyncTest02()
		{
			var channel = new ChannelQueue<PersonProper>();
			var people = RandomData.GeneratePersonCollection<PersonProper>(1000);
			var token = CancellationToken.None;

			foreach (var person in people)
			{
				await channel.WriteAsync(person, cancellationToken: token);
			}

			Assert.IsTrue(channel.Count == 1000);

			do
			{
				var item = await channel.ReadAsync(token);

			} while (channel.Count != 0);

			Assert.IsTrue(channel.Count == 0);
		}

		[TestMethod]
		public async Task WriteReadAsyncTest03()
		{
			var channel = new ChannelQueue<PersonProper>();
			var people = RandomData.GeneratePersonCollection<PersonProper>(5);
			var token = CancellationToken.None;

			foreach (var person in people)
			{
				await channel.WriteAsync(person, cancellationToken: token);
			}

			Assert.IsTrue(channel.Count == 5);

			channel.Lock();

			await foreach (var item in channel.ListenAsync(token))
			{
				Trace.WriteLine(item.Email);
			}

			Assert.IsTrue(channel.Count == 0);
		}

		[TestMethod]
		public async Task WriteReadAsyncTest04()
		{
			var channel = new ChannelQueue<PersonProper>(1000);
			var people = RandomData.GeneratePersonCollection<PersonProper>(1000);
			var token = CancellationToken.None;

			foreach (var person in people)
			{
				await channel.WriteAsync(person, cancellationToken: token);
			}

			Assert.IsTrue(channel.Count == 1000);

			do
			{
				var item = await channel.ReadAsync(token);

			} while (channel.Count != 0);

			Assert.IsTrue(channel.Count == 0);
		}
	}
}
