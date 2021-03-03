// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 02-22-2021
// ***********************************************************************
// <copyright file="EnumItem.cs" company="David McCarter - dotNetTips.com">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Class EnumItem.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	public record EnumItem<T>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="EnumItem{T}"/> class.
		/// </summary>
		/// <param name="description">The description.</param>
		/// <param name="value">The value.</param>
		public EnumItem(string description, T value)
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
