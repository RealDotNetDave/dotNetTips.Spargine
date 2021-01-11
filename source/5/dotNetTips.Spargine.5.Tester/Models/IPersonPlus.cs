// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Tester
// Author           : David McCarter
// Created          : 11-22-2020
//
// Last Modified By : David McCarter
// Last Modified On : 01-03-2021
// ***********************************************************************
// <copyright file="IPersonPlus.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Example interface that has implementation.</summary>
// ***********************************************************************
using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

//![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Tester.Models
{
	/// <summary>
	/// Interface IPersonPlus
	/// </summary>
	[XmlRoot(ElementName = "IPersonPlus", Namespace = "http://dotNetTips.Spargine.Tester.Models")]
	public interface IPersonPlus : IPerson
	{
		/// <summary>
		/// Gets the age.
		/// </summary>
		/// <value>The age.</value>
		[IgnoreDataMember]
		public TimeSpan Age => this.CalculateAge();

		/// <summary>
		/// Calculates the person's current age.
		/// </summary>
		/// <returns>TimeSpan.</returns>
		private TimeSpan CalculateAge() => DateTimeOffset.UtcNow.Subtract(this.BornOn);
	}
}
