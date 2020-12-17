// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Common.Tests
// Author           : David McCarter
// Created          : 11-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 11-28-2020
// ***********************************************************************
// <copyright file="ComputerInfoTests.cs" company="dotNetTips.Spargine.Core.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using dotNetTips.Spargine.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Spartine.Core.Tests
{
    [TestClass]
    public class ComputerInfoTests
    {

        [TestMethod]
        public void ComputerInfoTest()
        {
            var ci = new ComputerInfo();

            Assert.IsNotNull(ci);
        }
    }
}
