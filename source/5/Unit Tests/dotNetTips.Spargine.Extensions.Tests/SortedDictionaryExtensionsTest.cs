using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using dotNetTips.Spargine.Extensions;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Spargine.Extensions.Tests
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class SortedDictionaryExtensionsTest
    {
        [TestMethod]
        public void ToImmutableTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(100).ToDictionary(p => p.Id);

            var peopleSortedSet = new SortedDictionary<string, PersonProper>(people);

            var result = peopleSortedSet.ToImmutable();

            Assert.IsNotNull(result);

            SortedDictionary<string, PersonProper> nullSet = null;

            Assert.ThrowsException<ArgumentNullException>(() => nullSet.ToImmutable());
        }
    }
}
