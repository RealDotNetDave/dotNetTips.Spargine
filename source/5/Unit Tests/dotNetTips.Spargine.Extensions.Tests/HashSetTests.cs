using System.Linq;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Spargine.Extensions.Tests
{
	[TestClass]
	public class HashSetTests
	{
		[TestMethod]
		public void AddIfTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToHashSet();
			var person = RandomData.GeneratePerson<PersonProper>();

			people.AddIf(person, true);

			Assert.IsTrue(people.Count() == 11);

			people.AddIf(person, false);

			Assert.IsTrue(people.Count() == 11);

		}

		[TestMethod]
		public void ToImmutableTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToHashSet().ToImmutable();

			Assert.IsTrue(people.Count() == 10);
		}

		[TestMethod]
		public void UpsertTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToHashSet();
			var person = RandomData.GeneratePerson<PersonProper>();
			var personFromCollection = people.Shuffle().First();

			people.Upsert(person);

			Assert.IsTrue(people.Count() == 11);

			people.Upsert(personFromCollection);

			Assert.IsTrue(people.Count() == 11);

		}

	}
}
