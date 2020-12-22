using System.Diagnostics.CodeAnalysis;
using System.Linq;
using dotNetTips.Utility.Standard.Tester;
using dotNetTips.Utility.Standard.Tester.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Spargine.Extensions.Tests
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class ArrayExtensionsTests
    {
        [TestMethod]
        public void AddFirstTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToArray();
            var person = RandomData.GeneratePerson<PersonProper>();

            var result = people.AddFirst(person);

            Assert.IsTrue(result.Count() == 11);
            Assert.IsTrue(result.First() == person);

            Assert.IsTrue(result.AddFirst(null).Count() == 11);
        }

        [TestMethod]
        public void AddLastTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToArray();
            var person = RandomData.GeneratePerson<PersonProper>();

            var result = people.AddLast(person);

            Assert.IsTrue(result.Count() == 11);
            Assert.IsTrue(result.Last() == person);

            Assert.IsTrue(result.AddLast(null).Count() == 11);
        }

        [TestMethod]
        public void AreEqualTest()
        {
            var people1 = RandomData.GeneratePersonCollection<PersonProper>(10).ToArray();
            var people2 = people1;
            var people3 = RandomData.GeneratePersonCollection<PersonProper>(10).ToArray();


            Assert.IsFalse(people1.AreEqual(people3));

            Assert.IsTrue(people1.AreEqual(people2));
        }

        [TestMethod]
        public void BytesToStringTest()
        {
            var bytes = RandomData.GenerateByteArray(100);

            var result = bytes.BytesToString();

            Assert.IsTrue(result.Length > 20000);
        }

        [TestMethod]
        public void CloneTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToArray();

            var result = people.Clone<PersonProper>();

            Assert.IsTrue(people.AreEqual(result));
        }

        [TestMethod]
        public void ContainsAnyTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToArray();
            var person = RandomData.GeneratePerson<PersonProper>();

            Assert.IsFalse(people.ContainsAny(person));

            Assert.IsTrue(people.ContainsAny(people.Last())); ;

        }

        [TestMethod]
        public void ToDistinctTest()
        {
            var people = RandomData.GenerateWords(10, 10, 100).ToArray();

            people = people.AddLast(people.First());

            Assert.IsTrue(people.ToDistinct().Count() == 10);
        }
    }
}