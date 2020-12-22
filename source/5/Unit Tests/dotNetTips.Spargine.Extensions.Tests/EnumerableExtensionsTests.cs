using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using dotNetTips.Utility.Standard.Extensions;
using dotNetTips.Utility.Standard.Tester;
using dotNetTips.Utility.Standard.Tester.Collections;
using dotNetTips.Utility.Standard.Tester.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Spargine.Extensions.Tests
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class EnumerableExtensionsTests
    {

        [TestMethod]
        public void ContainsAnyTest()
        {
            var people1 = RandomData.GeneratePersonCollection<PersonProper>(10);

            var people2 = RandomData.GeneratePersonCollection<PersonProper>(10);

            Assert.IsFalse(people1.ContainsAny(people2.ToArray()));

            people1.AddRange(people2);

            Assert.IsTrue(people1.ContainsAny(people2.ToArray()));
        }

        [TestMethod]
        public void CountTest()
        {
            const int count = 10;
            var people = RandomData.GeneratePersonCollection<PersonProper>(count).AsEnumerable();

            Assert.IsTrue(people.Count() == count);
        }

        [TestMethod]
        public void DoesNotHaveItemsTest()
        {
            var people = new PersonCollection<PersonProper>();

            Assert.IsTrue(people.DoesNotHaveItems());
        }

        [TestMethod]
        public void FastAnyTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(1000);

            //Test Params
            _ = Assert.ThrowsException<ArgumentNullException>(() => people.FastAny(null));

            //Test Finding Days of over 100
            Assert.IsTrue(people.FastAny(p => p.Age.TotalDays > 100));
        }

        [TestMethod]
        public void FastCountTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(1000);

            // Test Params
            _ = Assert.ThrowsException<ArgumentNullException>(() => people.FastCount(null));

            //Test Finding Days of over 100
            Assert.IsTrue(people.FastCount(p => p.Age.TotalDays >= 1) > 0);
        }

        [TestMethod]
        public void FirstOrDefaultTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10);
            var person1 = RandomData.GeneratePerson<PersonProper>();
            var person2 = RandomData.GeneratePerson<PersonProper>();
            people.Add(person1);

            //Test Finding item in collection
            Assert.IsNotNull(people.FirstOrDefault(person1) == person1);
            Assert.IsNotNull(people.FirstOrDefault(p => p.Age.TotalDays > 100, person1).Equals(person1));
        }

        [TestMethod]
        public void FirstOrNullTest()
        {
            var coordinates = RandomData.GenerateCoordinateCollection<CoordinateProper>(10).AsEnumerable();
            var searchValue = coordinates.Last().X;

            //Test Params
            _ = Assert.ThrowsException<ArgumentNullException>(() => coordinates.FirstOrNull(null));

            //Test Finding Days of over 100
            Assert.IsNotNull(coordinates.FirstOrNull(p => p.X == searchValue));
            Assert.IsNull(coordinates.FirstOrNull(p => p.X == int.MinValue));
        }

        [TestMethod]
        public void FromDelimitedStringTest()
        {
            var testValue = ".net, c#, vb, f#";

            //Test
            Assert.IsTrue(testValue.ToDelimitedString(',').HasItems());
            Assert.IsTrue(testValue.ToDelimitedString().HasItems());
        }

        [TestMethod]
        public void ShuffleWithCountTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10);
            PersonCollection<PersonProper> nullList = null;

            _ = Assert.ThrowsException<ArgumentNullException>(nullList.Shuffle);

            Assert.IsTrue(people.Shuffle(5).Count() == 5);
        }

        [TestMethod]
        public void StartsWithTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(50);

            Assert.IsTrue(people.StartsWith(people.Take(5)));
        }

        [TestMethod]
        public void StructuralSequenceEqualTest()
        {
            var people1 = RandomData.GeneratePersonCollection<PersonProper>(50);

            var people2 = people1.Clone<PersonCollection<PersonProper>>();

            Assert.IsFalse(people1.StructuralSequenceEqual(people2));
        }

        [TestMethod]
        public void ToDelimitedStringTest()
        {
            var words = RandomData.GenerateWords(10, 25, 50);

            Assert.IsNotNull(words.ToDelimitedString(','));
        }

        [TestMethod]
        public void ToLinkedListTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(50);

            Assert.IsTrue(people.ToLinkedList().HasItems());
        }
    }
}
