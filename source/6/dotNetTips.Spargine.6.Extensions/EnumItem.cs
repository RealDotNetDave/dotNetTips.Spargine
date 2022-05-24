// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 05-24-2022
// ***********************************************************************
// <copyright file="EnumItem.cs" company="David McCarter - dotNetTips.com">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Class EnumItem.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	public record EnumItem<T>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="EnumItem{T}" /> class.
		/// </summary>
		/// <param name="description">The description.</param>
		/// <param name="value">The value.</param>
		public EnumItem(in string description, in T value)
		{
			this.Description = description;
			this.Value = value;
		}

		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		/// <value>The description.</value>
		public string Description
		{
			get; init;
		}

		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		/// <value>The value.</value>
		public T Value
		{
			get; init;
		}
	}
}
