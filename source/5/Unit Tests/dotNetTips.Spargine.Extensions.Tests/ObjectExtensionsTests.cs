using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotNetTips.Utility.Standard.Tester;
using dotNetTips.Utility.Standard.Tester.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Spargine.Extensions.Tests
{
    [TestClass]
    public class ObjectExtensionsTests
    {
        [TestMethod]
        public void AsTest()
        {
            var personProper = RandomData.GeneratePerson<PersonFixed>();

            try
            {
                Assert.IsNotNull(personProper.As<IPerson>());
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Assert.Fail();
            }
        }

        [TestMethod]
        public void PropertiesToNamesAndValuesTest()
        {
            var personProper = RandomData.GeneratePerson<PersonProper>();

            var result = personProper.PropertiesToDictionary();

            Assert.IsTrue(result.Count() > 1);
        }

        [TestMethod]
        public void PropertiesToStringTest()
        {
            var personProper = RandomData.GeneratePerson<PersonProper>();

            var result = personProper.PropertiesToString(false);

            Assert.IsTrue(result.Length > 300);
        }
    }
}
