using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Spargine.Extensions.Tests
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class DirectoryInfoExtensionsTests
    {
        [TestMethod]
        public void DirectoryInfoSizeTest01()
        {
            var directory = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));

            var result = directory.GetSize();

            Assert.IsTrue(result > 0);

            Assert.ThrowsException<ArgumentNullException>(() => DirectoryInfoExtensions.GetSize(null));
        }

        [TestMethod]
        public void DirectoryInfoSizeTest02()
        {
            var directory = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));

            var result = directory.GetSize("*.txt");

            Assert.IsTrue(result > 0);

            Assert.ThrowsException<ArgumentNullException>(() => directory.GetSize(null) == 0);
        }

        [TestMethod]
        public void DirectoryInfoSizeTest03()
        {
            var directory = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));

            var result = directory.GetSize(searchPattern: "*.txt", searchOption: SearchOption.AllDirectories);

            Assert.IsTrue(result > 0);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => directory.GetSize("*.txt", (SearchOption)100) ==
                0);
        }
    }
}
