using System.Linq;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Spargine.Extensions.Tests
{
	[TestClass]
	public class ImmutableArrayTests
	{
		[TestMethod]
		public void ImmutableArrayTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToHashSet().ToImmutable();
			var copyPeople = people;
			Assert.IsTrue(people == copyPeople);
			Assert.IsFalse(people == copyPeople.Shuffle());
		}
	}
}
