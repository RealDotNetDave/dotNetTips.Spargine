using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using dotNetTips.Spargine.Core;
using dotNetTips.Utility.Standard.Tester;
using dotNetTips.Utility.Standard.Tester.Models;
using Microsoft.Extensions.ObjectPool;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Spargine.Extensions.Tests
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class StringBuilderExtensionsTests
    {

        [TestMethod]
        public void AppendBytesTest()
        {
            var sb = new StringBuilder();
            var byteArray = RandomData.GenerateByteArray(sizeInKb: 1);
            sb.AppendBytes(byteArray);

            Assert.IsTrue(sb.Length > 50);

            //Test ObjectPool
            var objectPool = new DefaultObjectPoolProvider();
            var stringBuilderPool = objectPool.CreateStringBuilderPool().Get();

            stringBuilderPool.AppendBytes(byteArray);

            Assert.IsTrue(stringBuilderPool.Length > 50);
        }

        [TestMethod]
        public void AppendKeyValueTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToDictionary(p => p.Id);

            var sb = new StringBuilder();

            foreach (var person in people)
            {
                sb.AppendKeyValue(person.Key, person.Value.Email);
                sb.AppendKeyValue(person.Key, person.Value.Email, includeQuotes: Tristate.True);
                sb.AppendKeyValue(person.Key, person.Value.Email, includeComma: Tristate.True);
                sb.AppendKeyValue(person.Key, person.Value.Email, includeQuotes: Tristate.True, includeComma: Tristate.True);

                Assert.ThrowsException<ArgumentNullException>(() => sb.AppendKeyValue(person.Key, null));
                Assert.ThrowsException<ArgumentNullException>(() => sb.AppendKeyValue(null, person.Value.Email));
            }

            Assert.IsTrue(sb.ToString().Length > 50 * 4);

            //Test ObjectPool
            var objectPool = new DefaultObjectPoolProvider();
            var stringBuilderPool = objectPool.CreateStringBuilderPool().Get();

            foreach (var person in people)
            {
                stringBuilderPool.AppendKeyValue(person.Key, person.Value.Email);
                stringBuilderPool.AppendKeyValue(person.Key, person.Value.Email, includeQuotes: Tristate.True);
                stringBuilderPool.AppendKeyValue(person.Key, person.Value.Email, includeComma: Tristate.True);
                stringBuilderPool.AppendKeyValue(person.Key, person.Value.Email, includeQuotes: Tristate.True, includeComma: Tristate.True);

                Assert.ThrowsException<ArgumentNullException>(() => stringBuilderPool.AppendKeyValue(person.Key, null));
                Assert.ThrowsException<ArgumentNullException>(() => stringBuilderPool.AppendKeyValue(null, person.Value.Email));
            }

            Assert.IsTrue(stringBuilderPool.ToString().Length > 50 * 4);
        }

        [TestMethod]
        public void AppendValues01()
        {
            var sb = new StringBuilder();
            var values = RandomData.GenerateWords(count: 5, minLength: 5, maxLength: 7);

            sb.AppendValues(", ", values);

            Assert.IsTrue(sb.Length > 10);

            //Test ObjectPool
            var objectPool = new DefaultObjectPoolProvider();
            var stringBuilderPool = objectPool.CreateStringBuilderPool().Get();

            stringBuilderPool.AppendValues(", ", values);

            Assert.IsTrue(stringBuilderPool.Length > 10);
        }

        [TestMethod]
        public void AppendValues02()
        {
            var sb = new StringBuilder();

            sb.AppendValues(", ", RandomData.GenerateWord(100), RandomData.GenerateWord(100));

            Assert.IsTrue(sb.Length > 10);

            //Test ObjectPool
            var objectPool = new DefaultObjectPoolProvider();
            var stringBuilderPool = objectPool.CreateStringBuilderPool().Get();

            stringBuilderPool.AppendValues(", ", RandomData.GenerateWord(100), RandomData.GenerateWord(100));

            Assert.IsTrue(stringBuilderPool.Length > 10);
        }


        [TestMethod]
        public void AppendValuesTest()
        {
            var sb = new StringBuilder();
            var values = RandomData.GenerateCoordinateCollection<Coordinate>(count: 15);

            sb.AppendValues(", ", values, (person) =>
            {
                sb.Append(person.X);
                sb.Append(Utility.Standard.Common.ControlChars.Colon);
                sb.Append(person.Y);
            });

            Assert.IsTrue(sb.Length > 50);

            //Test ObjectPool
            var objectPool = new DefaultObjectPoolProvider();
            var stringBuilderPool = objectPool.CreateStringBuilderPool().Get();

            stringBuilderPool.AppendValues(", ", values, (person) =>
            {
                stringBuilderPool.Append(person.X);
                stringBuilderPool.Append(Utility.Standard.Common.ControlChars.Colon);
                stringBuilderPool.Append(person.Y);
            });

            Assert.IsTrue(stringBuilderPool.Length > 50);
        }

    }
}
