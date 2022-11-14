// ***********************************************************************
// Assembly         : dotNetTips.Spargine.6.Tester
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

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

using DotNetTips.Spargine.Core;

namespace DotNetTips.Spargine.Tester.Models.ValueTypes;

/// <summary>
/// Interface ICoordinate used to create Coordinate.
/// </summary>
[Information(Status = Status.Available, Documentation = "https://bit.ly/UnitTestRandomData7")]
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
