// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Core
// Author           : David McCarter
// Created          : 08-12-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-16-2022
// ***********************************************************************
// <copyright file="ObservableHashSetSingletons.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.ComponentModel;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.Collections.Generic
{
	/// <summary>
	/// ObservableHashSetSingletons.
	/// </summary>
	internal static class ObservableHashSetSingletons
	{
		/// <summary>
		/// Gets the count property changed.
		/// </summary>
		/// <value>The count property changed.</value>
		internal static PropertyChangedEventArgs CountPropertyChanged { get; } = new(propertyName: "Count");

		/// <summary>
		/// Gets the count property changing.
		/// </summary>
		/// <value>The count property changing.</value>
		internal static PropertyChangingEventArgs CountPropertyChanging { get; } = new(propertyName: "Count");

		/// <summary>
		/// Gets the no items.
		/// </summary>
		/// <value>The no items.</value>
		internal static object[] NoItems { get; } = Array.Empty<object>();
	}
}
