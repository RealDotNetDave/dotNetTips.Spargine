using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Spartine.Core.Tests
{
    [TestClass]
    public class ExecutionHelperTests
    {
        [TestMethod]
        public void ProgressiveRetryTest()
        {
            var tries = 0;

            try
            {
                //TODO: FIX
                //tries = ExecutionHelper.ProgressiveRetry(() =>
                //  {
                //      var drives = DriveHelper.GetRemovableDrives();
                //  }, 3, 10);
            }
            catch (Exception ex)
            {
                Assert.Fail($"Progressive retry failed: {ex.Message}.");
            }

            Assert.IsTrue(tries > 0);
        }
    }
}
