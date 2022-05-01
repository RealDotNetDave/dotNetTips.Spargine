// ***********************************************************************
// Assembly         : DotNetTips.Spargine.5.Tester
// Author           : David McCarter
// Created          : 12-29-2020
//
// Last Modified By : David McCarter
// Last Modified On : 04-01-2022
// ***********************************************************************
// <copyright file="Coordinate.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

using System.Diagnostics.CodeAnalysis;

namespace DotNetTips.Spargine.Tester.Models.ValueTypes
{
	/// <summary>
	/// Struct Coordinate
	/// Implements the <see cref="ICoordinate" />
	/// </summary>
	/// <seealso cref="ICoordinate" />
	[Serializable]
	[SuppressMessage("Microsoft.Performance", "CA1815")]
	public struct Coordinate : ICoordinate
	{
		/// <summary>
		/// Gets or sets the x coordinate.
		/// </summary>
		/// <value>The x.</value>
		public int X { get; set; }

		/// <summary>
		/// Gets or sets the y coordinate.
		/// </summary>
		/// <value>The y.</value>
		public int Y { get; set; }
	}
}
