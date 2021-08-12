// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Tester
// Author           : David McCarter
// Created          : 01-16-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-16-2021
// ***********************************************************************
// <copyright file="TestClass.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Common methods for TestClasses.</summary>
// ***********************************************************************
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using dotNetTips.Spargine.Extensions;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Tester
{
	/// <summary>
	/// Class TestClass.
	/// </summary>
	[ExcludeFromCodeCoverage]
	public class TestClass
	{
		/// <summary>
		/// Prints the result.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="input">The input.</param>
		/// <param name="methodName">Name of the method.</param>
		protected static void PrintResult<T>(T input, string methodName)
		{
			var message = input is string || input.GetType().IsValueType ? $"{methodName}: {input.ToString():C}" : $"{methodName}: {input.PropertiesToString(includeMemberName: false)}";

			Debug.WriteLine(message);
		}
	}
}
