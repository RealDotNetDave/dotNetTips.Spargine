// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Tester
// Author           : David McCarter
// Created          : 12-29-2020
//
// Last Modified By : David McCarter
// Last Modified On : 12-27-2021
// ***********************************************************************
// <copyright file="ICoordinate.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png; https://www.spargine.net )

namespace dotNetTips.Spargine.Tester.Models.ValueTypes
{
	/// <summary>
	/// Interface ICoordinate used to create Coordinate.
	/// </summary>
	public interface ICoordinate
	{
		/// <summary>
		/// Gets or sets the x coordinate.
		/// </summary>
		/// <value>The x value.</value>
		int X { get; set; }

		/// <summary>
		/// Gets or sets the y coordinate.
		/// </summary>
		/// <value>The y value.</value>
		int Y { get; set; }

		/// <summary>
		/// Returns a <see cref="string" /> of the coordinates.
		/// </summary>
		/// <returns>A <see cref="string" /> of the coordinates.</returns>
		string ToString();

	}
}
