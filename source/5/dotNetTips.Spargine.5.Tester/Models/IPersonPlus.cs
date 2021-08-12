// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Tester
// Author           : David McCarter
// Created          : 11-22-2020
//
// Last Modified By : David McCarter
// Last Modified On : 01-15-2021
// ***********************************************************************
// <copyright file="IPersonPlus.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Example interface that has implementation.</summary>
// ***********************************************************************
using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Tester.Models
{
	/// <summary>
	/// Interface IPersonPlus
	/// </summary>
	[Obsolete("This class will be removed at the end of 2021. Instead use Person or PersonRecord.")]
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
