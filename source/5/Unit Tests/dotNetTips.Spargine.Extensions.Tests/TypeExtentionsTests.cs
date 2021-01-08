using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using dotNetTips.Spargine.Tester.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Spargine.Extensions.Tests
{
    public abstract class AbstractTestType
    {

        public abstract string Name();

    }

    [XmlRoot]
    public class TestType
    {
        [XmlIgnore]
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        public string UserName { get; set; }


        public static string GetName()
        {
            return "GetName";
        }

        /// <summary>
        /// Invokes the specified input.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>System.String.</returns>
        public string Invoke(string input)
        {
            return input;
        }

        public void Run<T>() where T : class
        {
            //Do Nothing
        }

    }

    [ExcludeFromCodeCoverage]
    [TestClass]
    public class TypeExtensionsTests
    {

        [TestMethod]
        public void GetAbstractMethodsTest()
        {
            var result = typeof(AbstractTestType).GetAllAbstractMethods();

            Assert.IsTrue(result.Count() == 1);
        }

        [TestMethod]
        public void GetAllFieldsTest()
        {
            var result = typeof(TestType).GetAllFields();

            Assert.IsTrue(result.Count() == 1);

            result = typeof(PersonProper).GetAllFields();

            Assert.IsTrue(result.Count() == 12);
        }

        [TestMethod]
        public void GetAllMethodsTest()
        {
            var result = typeof(TestType).GetAllMethods();

            Assert.IsTrue(result.Count() == 13);

            result = typeof(PersonProper).GetAllMethods();

            Assert.IsTrue(result.Count() == 45);
        }

        [TestMethod]
        public void GetAttributeFieldTest()
        {
            var field = typeof(TestType).GetAllFields().FirstOrDefault();

            var result = field.GetAttribute<CompilerGeneratedAttribute>();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetAttributeMethodTest()
        {
            var method = typeof(TestType).GetAllMethods().Where(p => p.Name == "get_UserName").FirstOrDefault();

            var result = method.GetAttribute<CompilerGeneratedAttribute>();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetAttributePropertyTest()
        {
            var property = typeof(TestType).GetAllProperties().FirstOrDefault();

            var result = property.GetAttribute<DebuggerBrowsableAttribute>();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetAttributeTypeTest()
        {
            var result = typeof(TestType).GetAttribute<XmlRootAttribute>();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetGenericMethodsTest()
        {
            var result = typeof(TestType).GetAllGenericMethods();

            Assert.IsTrue(result.Count() == 1);
        }

        [TestMethod]
        public void GetPropertiesTest()
        {
            var result = typeof(PersonProper).GetAllProperties();

            Assert.IsTrue(result.Count() == 13);
        }

        [TestMethod]
        public void GetPublicMethodsTest()
        {
            var result = typeof(PersonProper).GetAllPublicMethods();

            Assert.IsTrue(result.Count() == 37);
        }

        [TestMethod]
        public void GetStaticMethodsTest()
        {
            var result = typeof(TestType).GetAllStaticMethods();

            Assert.IsTrue(result.Count() == 1);
        }

        [TestMethod]
        public void GetTypeMembersWithGivenAttributeTest()
        {
            var result = typeof(TestType).GetTypeMembersWithAttribute<XmlIgnoreAttribute>();

            Assert.IsTrue(result.Count() == 1);
        }

    }
}
