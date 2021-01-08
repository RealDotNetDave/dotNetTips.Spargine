using System.Diagnostics.CodeAnalysis;
using System.Linq;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Spargine.Extensions.Tests
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class ObservableCollectionExtensionsTests
    {
        [TestMethod]
        public void HasItemsTest()
        {
            var collection = RandomData.GenerateCoordinateCollection<Coordinate>(10).ToList();

            Assert.IsTrue(collection.HasItems());

            Assert.IsTrue(collection.HasItems(10));

            Assert.IsTrue(collection.ToObservableCollection().HasItems());

            Assert.IsTrue(collection.ToObservableCollection().HasItems(10));
        }

        [TestMethod]
        public void ToObservableCollectionTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10);

            //Test 
            Assert.IsTrue(people.ToObservableCollection().HasItems());
        }
    }
}
