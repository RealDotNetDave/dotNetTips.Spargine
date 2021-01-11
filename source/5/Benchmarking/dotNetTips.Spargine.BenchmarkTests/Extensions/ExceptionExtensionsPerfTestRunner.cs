using System.Data.Services.Client;
using System.Security;
using System.ServiceModel.Security;
using BenchmarkDotNet.Attributes;
using dotNetTips.Utility.Standard.Extensions;

namespace dotNetTips.Spargine.BenchmarkTests.Extensions
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
