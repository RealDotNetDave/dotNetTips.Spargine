// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 01-16-2022
//
// Last Modified By : David McCarter
// Last Modified On : 08-09-2023
// ***********************************************************************
// <copyright file="SingletonTests.cs" company="dotNetTips.Spargine.Core.Tests">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.Tests;
[ExcludeFromCodeCoverage]
[TestClass]
public class SingletonTests
{

	[TestMethod]
	public void SingletonTest01()
	{
		var list = Singleton<ObservableList<string>>.Instance;

		Assert.IsNotNull(list);

		Assert.IsInstanceOfType(list, typeof(ObservableList<string>));
	}

}
