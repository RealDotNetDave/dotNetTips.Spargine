// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core
// Author           : David McCarter
// Created          : 02-05-2020
//
// Last Modified By : David McCarter
// Last Modified On : 12-27-2021
// ***********************************************************************
// <copyright file="IDataModel.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.ComponentModel.DataAnnotations;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png; https://www.spargine.net )
namespace dotNetTips.Spargine.Core
{
	/// <summary>
	/// Interface IDataModel
	/// Implements the <see cref="IComparable{T}" />
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <typeparam name="TKey">The type of the t key.</typeparam>
	/// <seealso cref="IComparable{T}" />
	public interface IDataModel<T, TKey> : IComparable<T>, IEquatable<T>
	{
		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
		[Required]
		TKey Id { get; set; }
	}
}
