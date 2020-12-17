using System;
using System.Linq;
using dotNetTips.Spargine.Core.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Spartine.Core.Tests.Logging
{
    [TestClass]
    public class LoggingHelperTest
    {

        [TestMethod]
        public void RetrieveAllExceptionMessagesTest()
        {
            var testException = new ArgumentNullException("TEST EX1.", new ArithmeticException("TEST EX2"));

            var result = LoggingHelper.RetrieveAllExceptionMessages(testException);

            Assert.IsTrue(result.Count() == 2);
        }
        [TestMethod]
        public void RetrieveAllExceptionsTest()
        {
            var testException = new ArgumentNullException("TEST EX1.", new ArithmeticException("TEST EX2"));

            var result = LoggingHelper.RetrieveAllExceptions(testException);

            Assert.IsTrue(result.Count() == 2);
        }
    }
}
