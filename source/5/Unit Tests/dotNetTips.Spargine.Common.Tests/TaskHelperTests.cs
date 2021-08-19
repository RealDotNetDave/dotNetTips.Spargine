using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Spargine.Core.Tests
{
	[TestClass]
	public class TaskHelperTests
	{
		private string _fireResult = string.Empty;

		[TestMethod]
		public void RunSync10()
		{
			TaskHelper.RunSync(() => this.Fire(nameof(this.RunSync10)));

			Assert.AreEqual(this._fireResult, nameof(this.RunSync10));
		}

		[TestMethod]
		public void RunSync11()
		{
			var cancelToken = new CancellationTokenSource().Token;

			TaskHelper.RunSync(() => this.Fire(nameof(this.RunSync11)), cancellationToken: cancelToken);

			Assert.AreEqual(this._fireResult, nameof(this.RunSync11));
		}

		[TestMethod]
		public void RunSync20()
		{
			_ = TaskHelper.RunSync(() => this.FireWithReturn(nameof(this.RunSync20)));

			Assert.AreEqual(this._fireResult, nameof(this.RunSync20));
		}

		[TestMethod]
		public void RunSync21()
		{
			var cancelToken = new CancellationTokenSource().Token;

			_ = TaskHelper.RunSync(() => this.FireWithReturn(nameof(this.RunSync21)), cancellationToken: cancelToken);

			Assert.AreEqual(this._fireResult, nameof(this.RunSync21));
		}

		private async Task Fire(string input)
		{
			this._fireResult = input;

			Console.WriteLine(input);

			await Task.Delay(1).ConfigureAwait(false);
		}

		private async Task<string> FireWithReturn(string input)
		{
			this._fireResult = input;

			Console.WriteLine(input);

			await Task.Delay(1).ConfigureAwait(false);

			return input;
		}
	}
}
