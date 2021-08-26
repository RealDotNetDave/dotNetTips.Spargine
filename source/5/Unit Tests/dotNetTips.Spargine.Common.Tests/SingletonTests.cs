using dotNetTips.Spargine.Core.Collections.Generic;
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
