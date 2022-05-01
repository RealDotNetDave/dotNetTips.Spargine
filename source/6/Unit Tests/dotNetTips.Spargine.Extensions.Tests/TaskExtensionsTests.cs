// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 01-16-2022
//
// Last Modified By : David McCarter
// Last Modified On : 04-04-2022
// ***********************************************************************
// <copyright file="TaskExtensionsTests.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.Tests
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
			Action<Exception> p = (Exception ex) =>
			{
				Debug.WriteLine(ex.Message);
			};

			this.Fire(nameof(this.FireAndForgetTest01)).FireAndForget(p);

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
