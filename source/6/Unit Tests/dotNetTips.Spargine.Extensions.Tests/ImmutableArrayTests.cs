// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 01-16-2022
//
// Last Modified By : David McCarter
// Last Modified On : 04-04-2022
// ***********************************************************************
// <copyright file="ImmutableArrayTests.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Linq;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.Tests
{
	[TestClass]
	public class ImmutableArrayTests
	{
		[TestMethod]
		public void ImmutableArrayTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10).ToHashSet().ToImmutable();
			var copyPeople = people;
			Assert.IsTrue(people == copyPeople);
			Assert.IsFalse(people == copyPeople.Shuffle());
		}
	}
}
