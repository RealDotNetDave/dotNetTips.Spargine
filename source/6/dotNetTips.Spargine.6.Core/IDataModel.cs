// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core
// Author           : David McCarter
// Created          : 02-05-2020
//
// Last Modified By : David McCarter
// Last Modified On : 08-02-2023
// ***********************************************************************
// <copyright file="IDataModel.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// This is an interface designed for model classes, enforcing the
// implementation of the "Id" property, which is mandatory.
// </summary>
// ***********************************************************************
using System.ComponentModel.DataAnnotations;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Interface IDataModel to ensure all types have an Id property.
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
