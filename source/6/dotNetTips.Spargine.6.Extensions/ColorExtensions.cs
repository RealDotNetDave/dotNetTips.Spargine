// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions
// Author           : David McCarter
// Created          : 07-29-2018
//
// Last Modified By : David McCarter
// Last Modified On : 07-17-2022
// ***********************************************************************
// <copyright file="ColorExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extensions methods for the Color type.</summary>
// ***********************************************************************
using System.Drawing;
using DotNetTips.Spargine.Core;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Class ColorExtensionsExtensions methods for the Color type.
	/// </summary>
	public static class ColorExtensions
	{
		/// <summary>
		/// Averages the specified colors in the collection.
		/// Validates that <paramref name="colors" /> is not null and has items.
		/// </summary>
		/// <param name="colors">The colors.</param>
		/// <returns>Color.</returns>
		/// <exception cref="ArgumentOutOfRangeException">colors - colors</exception>
		[Information(nameof(Average), "David McCarter", "1/1/2015", BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
		public static Color Average(this IEnumerable<Color> colors)
		{
			colors = colors.ArgumentItemsExists();

			var r = colors.Average(c => c.R).Round();
			var g = colors.Average(c => c.G).Round();
			var b = colors.Average(c => c.B).Round();

			return Color.FromArgb(r, g, b);
		}
	}
}
