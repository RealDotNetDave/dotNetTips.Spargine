// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Core
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 01-16-2022
// ***********************************************************************
// <copyright file="EnumValue.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core
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
