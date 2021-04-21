// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 04-16-2021
//
// Last Modified By : David McCarter
// Last Modified On : 04-16-2021
// ***********************************************************************
// <copyright file="TestType.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Diagnostics;
using System.Linq;
using System.Xml.Serialization;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Extensions.Tests
{
	/// <summary>
	/// Class TestType.
	/// </summary>
	[XmlRoot]
	public class TestType
	{
		/// <summary>
		/// Gets or sets the name of the user.
		/// </summary>
		/// <value>The name of the user.</value>
		[XmlIgnore]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public string UserName { get; set; }


		/// <summary>
		/// Gets the name.
		/// </summary>
		/// <returns>System.String.</returns>
		public static string GetName()
		{
			return "GetName";
		}

		/// <summary>
		/// Invokes the specified input.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <returns>System.String.</returns>
		public string Invoke(string input)
		{
			return input;
		}

		/// <summary>
		/// Runs this instance.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		public void Run<T>() where T : class
		{
			//Do Nothing
		}

	}
}
