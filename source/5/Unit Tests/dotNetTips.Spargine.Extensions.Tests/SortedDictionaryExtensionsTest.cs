using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using dotNetTips.Utility.Standard.Tester;
using dotNetTips.Utility.Standard.Tester.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using dotNetTips.Spargine.Extensions;
using System.Linq;

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
