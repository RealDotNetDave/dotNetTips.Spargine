// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions
// Author           : David McCarter
// Created          : 07-29-2018
//
// Last Modified By : David McCarter
// Last Modified On : 11-13-2020
// ***********************************************************************
// <copyright file="ColorExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extensions methods for the Color type.</summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using dotNetTips.Spargine.Core;

//![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Class ColorExtensionsExtensions methods for the Color type.
	/// </summary>
	public static class ColorExtensions
	{
		/// <summary>
		/// Averages the specified colors in the collection.
		/// </summary>
		/// <param name="colors">The colors.</param>
		/// <returns>Color.</returns>
		/// <exception cref="ArgumentOutOfRangeException">colors - colors</exception>
		[Information(nameof(Average), "David McCarter", "1/1/2015", BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
		public static Color Average(this IEnumerable<Color> colors)
		{
			if (colors.HasItems() == false)
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException(nameof(colors));
			}

			var r = colors.Average(c => c.R).Round();
			var g = colors.Average(c => c.G).Round();
			var b = colors.Average(c => c.B).Round();

			return Color.FromArgb(r, g, b);
		}
	}
}
