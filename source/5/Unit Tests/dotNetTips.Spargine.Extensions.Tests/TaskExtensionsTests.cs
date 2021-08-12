using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.IO;
using Microsoft.AspNetCore.Components;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Spargine.Extensions.Tests
{
	[TestClass]
	public class TaskExtensionsTests
	{
		private string _fireResult = string.Empty;

		[TestMethod]
		public void FireAndForgetTest01()
		{
			this.Fire(nameof(this.FireAndForgetTest01)).FireAndForget();

			Assert.AreEqual(this._fireResult, nameof(this.FireAndForgetTest01));
		}

		[TestMethod]
		public void FireAndForgetTest02()
		{
			Action<Exception> p = (Exception ex) => Debug.WriteLine(ex.Message);
			var exAction = p;

			this.Fire(nameof(this.FireAndForgetTest01)).FireAndForget(exAction);

			Assert.AreEqual(this._fireResult, nameof(this.FireAndForgetTest01));
		}

		private async Task Fire(string input)
		{
			this._fireResult = input;

			Console.WriteLine(input);

			await Task.Delay(1).ConfigureAwait(false);
		}

	}
}
