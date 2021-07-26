using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotNetTips.Spargine.Cache;
using dotNetTips.Spargine.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Spargine.Core.Tests
{
	[TestClass]
	public class SingletonTests
	{
		[TestMethod]
		public void SingletonTest01()
		{
			var list = Singleton<ObservableList<string>>.Instance;

			Assert.IsNotNull(list);

			Assert.IsInstanceOfType(list, typeof(ObservableList<string>));
		}
	}
}
