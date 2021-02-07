// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-02-2021
// ***********************************************************************
// <copyright file="ExceptionExtensionsPerfTestRunner.cs" company="dotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Data.Services.Client;
using System.Security;
using System.ServiceModel.Security;
using BenchmarkDotNet.Attributes;
using dotNetTips.Spargine.Benchmarking;

namespace dotNetTips.Spargine.Extensions.BenchmarkTests
{
	[BenchmarkCategory(nameof(ExceptionExtensions))]
	public class ExceptionExtensionsPerfTestRunner : PerfTestRunner
	{
		[Benchmark(Description = nameof(ExceptionExtensions.GetAllMessages))]
		public void GetAllMessages()
		{
			var innerEx = new SecurityException("Messsage from SecurityException", new DataServiceClientException("Cannot access service!"));

			var ex = new SecurityAccessDeniedException("Message from SecurityAccessDeniedException", innerEx);

			this.Consumer.Consume(ex.GetAllMessages());
		}
	}
}
