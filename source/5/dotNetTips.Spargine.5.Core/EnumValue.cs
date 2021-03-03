// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Common
// Author           : David McCarter
// Created          : 10-27-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-02-2021
// ***********************************************************************
// <copyright file="EnumValue.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Core
{
	/// <summary>
	/// Holds Enum name and value.
	/// </summary>
	public record EnumValue
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="EnumValue" /> struct.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="name">The name.</param>
		public EnumValue(int value, string name)
		{
			this.Value = value;
			this.Name = name;
		}

		/// <summary>
		/// Gets the enum name.
		/// </summary>
		/// <value>The Enum name.</value>
		public string Name { get; init; }

		/// <summary>
		/// Gets the enum value.
		/// </summary>
		/// <value>The Enum value.</value>
		public int Value { get; init; }
	}
}
