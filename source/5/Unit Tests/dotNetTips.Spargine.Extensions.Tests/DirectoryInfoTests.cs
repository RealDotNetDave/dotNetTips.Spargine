using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Spargine.Extensions.Tests
{
    [TestClass]
    public class DirectoryInfoExtensionsTests
    {
        [TestMethod]
        public void DirectoryInfoSizeTest01()
        {
            var directory = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Cookies));

            var result = directory.GetSize();

            Assert.IsTrue(result > 0);

            Assert.ThrowsException<ArgumentNullException>(() => DirectoryInfoExtensions.GetSize(null));
        }

        [TestMethod]
        public void DirectoryInfoSizeTest02()
        {
            var directory = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Cookies));

            var result = directory.GetSize("*.cookie");

            Assert.IsTrue(result > 0);

            Assert.ThrowsException<ArgumentNullException>(() => directory.GetSize(null) == 0);
        }

        [TestMethod]
        public void DirectoryInfoSizeTest03()
        {
            var directory = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Cookies));

            var result = directory.GetSize(searchPattern: "*.cookie", searchOption: SearchOption.AllDirectories);

            Assert.IsTrue(result > 0);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => directory.GetSize("*.cookie", (SearchOption)100) ==
                0);
        }
    }
}
