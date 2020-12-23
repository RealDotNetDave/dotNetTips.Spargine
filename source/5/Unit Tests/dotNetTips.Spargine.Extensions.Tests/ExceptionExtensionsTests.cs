using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security;
using System.ServiceModel.Security;
using System.Text;
using System.Threading.Tasks;
using dotNetTips.Utility.Standard.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Spargine.Extensions.Tests
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class ExceptionExtensionsTest
    {

        [TestMethod]
        public void GetAllMessagesTest()
        {
            var innerEx = new SecurityException("Message from SecurityException", new DataMisalignedException("Cannot access service!"));

            var ex = new SecurityAccessDeniedException("Message from SecurityAccessDeniedException", innerEx);

            var messages = ex.GetAllMessages();

            Assert.IsTrue(messages.IsNotEmpty());
        }

        [TestMethod]
        public void GetAllMessagesWithStackTraceTest()
        {
            var innerEx = new SecurityException("Message from SecurityException", new DataMisalignedException("Cannot access service!"));

            var ex = new SecurityAccessDeniedException("Message from SecurityAccessDeniedException", innerEx);

            var messages = ex.GetAllMessagesWithStackTrace(",");

            Assert.IsTrue(messages.HasItems());
        }
        [TestMethod]
        public void IsCriticalTest()
        {
            var exGood = new NullReferenceException();
            var exBad = new ArgumentNullException();

            Assert.IsTrue(exGood.IsCritical());
            Assert.IsFalse(exBad.IsCritical());
        }

        [TestMethod]
        public void IsFatalTest()
        {
            var exGood = new OutOfMemoryException();
            var exBad = new ArgumentNullException();

            Assert.IsTrue(exGood.IsFatal());
            Assert.IsFalse(exBad.IsFatal());
        }

        [TestMethod]
        public void IsSecurityOrCriticalTest()
        {
            var exGood = new SecurityException();
            var exBad = new ArgumentNullException();

            Assert.IsTrue(exGood.IsSecurityOrCritical());
            Assert.IsFalse(exBad.IsSecurityOrCritical());
        }
    }
}
