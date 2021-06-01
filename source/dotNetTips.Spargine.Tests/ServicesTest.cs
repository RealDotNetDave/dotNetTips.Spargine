using dotNetTips.Spargine.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Spargine.Tests
{
	[TestClass]
	public class ServicesTest
	{
		[TestMethod]
		public void AllServices01()
		{
			var result = Services.AllServices();

			Assert.IsTrue(result.HasItems());
		}

		[TestMethod]
		public void LoadService01()
		{
			var result = Services.Load;

			Assert.IsTrue(result.HasItems());
		}
	}
}
