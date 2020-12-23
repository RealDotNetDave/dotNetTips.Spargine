// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 12-08-2020
// ***********************************************************************
// <copyright file="ListExtensionsTests.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using dotNetTips.Spargine.Core;
using dotNetTips.Utility.Standard.Tester;
using dotNetTips.Utility.Standard.Tester.Collections;
using dotNetTips.Utility.Standard.Tester.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Spargine.Extensions.Tests
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class ListExtensionsTests
    {

        [TestMethod]
        public void AddIfNotExistsTwoListsTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(20).ToArray();

            people = people.AddIfNotExists(null);
            Assert.IsTrue(people.Count() == 20);

            var newPeople = RandomData.GeneratePersonCollection<PersonProper>(10).ToArray();

            people = people.AddIfNotExists(newPeople);
            Assert.IsTrue(people.Count() == 30);

            people = people.AddIfNotExists(newPeople);
            Assert.IsTrue(people.Count() == 30);
        }

        [TestMethod]
        public void AddLastTest()
        {
            var peopleList = RandomData.GeneratePersonCollection<PersonProper>(10);
            var peopleArray = peopleList.ToArray();
            var person = RandomData.GeneratePerson<PersonProper>();
            PersonProper nullPerson = null;

            //Test Parameters
            _ = Assert.ThrowsException<ArgumentReadOnlyException>(() => peopleList.ToReadOnlyCollection()
                .AddLast(person));

            // Test List
            Assert.IsFalse(peopleList.AddLast(nullPerson));
            Assert.IsTrue(peopleList.Count() == peopleList.Count);

            Assert.IsTrue(peopleList.AddLast(person));
            Assert.IsTrue(peopleList.Last().Equals(person));


            // Test Array
            var result2 = peopleArray.AddLast(person);
            Assert.IsTrue(result2.Last().Equals(person));
            Assert.IsTrue(peopleArray.AddLast(null).Length == peopleArray.Length);
        }
        [TestMethod]
        public void ClearNullListTest()
        {
            var count = RandomData.GenerateInteger(10, 500);
            var people = RandomData.GeneratePersonCollection<PersonProper>(count);

            people.Add(null);

            Assert.IsTrue(people.ClearNulls());

            Assert.IsFalse(people.ClearNulls());

            Assert.IsFalse(new List<PersonProper>(10).ClearNulls());
        }
        [TestMethod]
        public void CopyToListTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10);
            var newPeople = people.CopyToList();

            Assert.IsTrue(people.Count == newPeople.Count);
        }
        [TestMethod]
        public void HasItemsTest()
        {
            var collection = RandomData.GenerateCoordinateCollection<Coordinate>(10);

            Assert.IsFalse(collection.ToList().HasItems(p => p.X == 999999999));
        }
        [TestMethod]
        public void IndexOfTest()
        {
            var peopleList = RandomData.GeneratePersonCollection<PersonProper>(10);
            var testPerson = peopleList[5];

            //Test Parameters
            _ = Assert.ThrowsException<ArgumentNullException>(() => peopleList.IndexOf(testPerson, null));
            _ = Assert.ThrowsException<ArgumentNullException>(() => peopleList.IndexOf(null, new PersonProperComparer()));

            // Test 
            Assert.IsTrue(peopleList.IndexOf(testPerson, new PersonProperComparer()) >= 0);
        }
        [TestMethod]
        public void ListHashCodeTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10);

            var result = people.ListHashCode();

            Assert.IsTrue(result.IsInRange(int.MinValue, int.MaxValue));

            result = people.ToArray().ListHashCode();

            Assert.IsTrue(result.IsInRange(int.MinValue, int.MaxValue));

            result = people.ToReadOnlyCollection().ListHashCode();

            Assert.IsTrue(result.IsInRange(int.MinValue, int.MaxValue));
        }
        [TestMethod]
        public void PagingTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(1000);
            const int pageCount = 10;
            var peopleCount = 0;
            var loopedCount = 0;

            foreach (var peoplePage in people.Page(pageCount))
            {
                loopedCount++;
                peopleCount += peoplePage.Count();
            }

            Assert.IsTrue(peopleCount == 1000);

            Assert.IsTrue(loopedCount == 100);
        }
        [TestMethod]
        public void PickRandomTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToDictionary(p => p.Id);

            var result = people.PickRandom();

            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void RemoveFirstTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToArray();

            Assert.IsTrue(people.RemoveFirst().Count() == 9);
        }
        [TestMethod]
        public void RemoveLastTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToArray();

            Assert.IsTrue(people.RemoveLast().Count() == 9);
        }
        [TestMethod]
        public void ShuffleImmutableArrayTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToImmutable();
            PersonCollection<PersonProper> nullList = null;

            _ = Assert.ThrowsException<ArgumentNullException>(nullList.Shuffle);

            var shuffledPeople = people.Shuffle();

            Assert.IsTrue(people.Count == shuffledPeople.Count());
        }
        [TestMethod]
        public void ShuffleTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10);
            PersonCollection<PersonProper> nullList = null;
            _ = Assert.ThrowsException<ArgumentNullException>(nullList.Shuffle);

            var shuffleCount = people.Shuffle().Count();

            Assert.IsTrue(people.Count == shuffleCount);
        }
    }
}
