// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 04-16-2021
//
// Last Modified By : David McCarter
// Last Modified On : 04-16-2021
// ***********************************************************************
// <copyright file="PropertiesTest.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using dotNetTips.Spargine.Tester.Models;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Extensions.Tests
{
	[ExcludeFromCodeCoverage]
	public class PropertiesTest
	{

		public DateTimeOffset? ClosedOn { get; set; }
		public string Id { get; set; }

		public PersonProper PersonProper { get; set; }

		public PersonRecord PersonRecord { get; set; }

		public DateTimeOffset Today { get; set; }
	}
}
