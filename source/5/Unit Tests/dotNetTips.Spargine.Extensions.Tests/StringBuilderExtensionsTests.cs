// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-22-2021
// ***********************************************************************
// <copyright file="StringBuilderExtensionsTests.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
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


			var pool = new StringBuilder();

			pool.AppendBytes(byteArray);

			Assert.IsTrue(pool.Length > 50);
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

			var pool = new StringBuilder();

			foreach (var person in people)
			{
				pool.AppendKeyValue(person.Key, person.Value.Email);
				pool.AppendKeyValue(person.Key, person.Value.Email, includeQuotes: Tristate.True);
				pool.AppendKeyValue(person.Key, person.Value.Email, includeComma: Tristate.True);
				pool.AppendKeyValue(person.Key, person.Value.Email, includeQuotes: Tristate.True, includeComma: Tristate.True);

				Assert.ThrowsException<ArgumentNullException>(() => pool.AppendKeyValue(person.Key, null));
				Assert.ThrowsException<ArgumentNullException>(() => pool.AppendKeyValue(null, person.Value.Email));
			}

			Assert.IsTrue(pool.ToString().Length > 50 * 4);
		}

		[TestMethod]
		public void AppendValues01()
		{
			var sb = new StringBuilder();
			var values = RandomData.GenerateWords(count: 5, minLength: 5, maxLength: 7);

			sb.AppendValues(", ", values);

			Assert.IsTrue(sb.Length > 10);

			var pool = new StringBuilder();

			pool.AppendValues(", ", values);

			Assert.IsTrue(pool.Length > 10);
		}

		[TestMethod]
		public void AppendValues02()
		{
			var sb = new StringBuilder();

			sb.AppendValues(", ", RandomData.GenerateWord(100), RandomData.GenerateWord(100));

			Assert.IsTrue(sb.Length > 10);

			var pool = new StringBuilder();

			pool.AppendValues(", ", RandomData.GenerateWord(100), RandomData.GenerateWord(100));

			Assert.IsTrue(pool.Length > 10);
		}


		[TestMethod]
		public void AppendValuesTest()
		{
			var sb = new StringBuilder();
			var values = RandomData.GenerateCoordinateCollection<Coordinate>(count: 15);

			sb.AppendValues(", ", values, (person) =>
			{
				sb.Append(person.X);
				sb.Append(ControlChars.Colon);
				sb.Append(person.Y);
			});

			Assert.IsTrue(sb.Length > 50);

			var pool = new StringBuilder();

			pool.AppendValues(", ", values, (person) =>
			{
				pool.Append(person.X);
				pool.Append(ControlChars.Colon);
				pool.Append(person.Y);
			});

			Assert.IsTrue(pool.Length > 50);
		}

	}
}
