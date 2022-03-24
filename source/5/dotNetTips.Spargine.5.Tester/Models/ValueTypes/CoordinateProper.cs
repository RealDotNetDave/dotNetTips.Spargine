// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Tester
// Author           : David McCarter
// Created          : 06-04-2019
//
// Last Modified By : David McCarter
// Last Modified On : 03-23-2022
// ***********************************************************************
// <copyright file="CoordinateProper.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using dotNetTips.Spargine.Core;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png; https://www.spargine.net )
namespace dotNetTips.Spargine.Tester.Models.ValueTypes
{
	/// <summary>
	/// Struct CoordinateProper
	/// Implements the <see cref="ICoordinate" />
	/// Implements the <see cref="IComparable" />&gt;
	/// </summary>
	/// <seealso cref="IComparable" />
	/// <seealso cref="ICoordinate" />
	[Serializable]
	public struct CoordinateProper : ICoordinate, IEquatable<CoordinateProper>, IComparable, IComparable<CoordinateProper>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CoordinateProper" /> struct.
		/// </summary>
		/// <param name="x">The x.</param>
		/// <param name="y">The y.</param>
		public CoordinateProper(int x, int y)
		{
			this.X = x;
			this.Y = y;
		}

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

		/// <summary>
		/// Implements the &gt;= operator.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>The result of the operator.</returns>
		public static bool operator >=(CoordinateProper left, CoordinateProper right) => left.CompareTo(right) >= 0;

		/// <summary>
		/// Implements the &gt; operator.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>The result of the operator.</returns>
		public static bool operator >(CoordinateProper left, CoordinateProper right) => left.CompareTo(right) > 0;

		/// <summary>
		/// Implements the == operator.
		/// </summary>
		/// <param name="cord1">The first coordinate.</param>
		/// <param name="cord2">The second coordinate.</param>
		/// <returns>The result of the operator.</returns>
		public static bool operator ==(CoordinateProper cord1, CoordinateProper cord2) => cord1.Equals(cord2);

		/// <summary>
		/// Implements the &lt;= operator.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>The result of the operator.</returns>
		public static bool operator <=(CoordinateProper left, CoordinateProper right) => left.CompareTo(right) <= 0;

		/// <summary>
		/// Implements the &lt; operator.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>The result of the operator.</returns>
		public static bool operator <(CoordinateProper left, CoordinateProper right) => left.CompareTo(right) < 0;
		/// <summary>
		/// Implements the != operator.
		/// </summary>
		/// <param name="cord1">The first coordinate.</param>
		/// <param name="cord2">The second coordinate.</param>
		/// <returns>The result of the operator.</returns>
		public static bool operator !=(CoordinateProper cord1, CoordinateProper cord2) => !( cord1 == cord2 );

		/// <summary>
		/// Compares to.
		/// </summary>
		/// <param name="obj">The object.</param>
		/// <returns>System.Int32.</returns>
		/// <exception cref="ArgumentException">obj</exception>
		public int CompareTo(object obj)
		{
			if (obj is not CoordinateProper)
			{
				ExceptionThrower.ThrowArgumentInvalidException(nameof(obj), $"{nameof(obj)} is not a {nameof(CoordinateProper)}");
			}

			return this.CompareTo((CoordinateProper)obj);
		}

		/// <summary>
		/// Compares to.
		/// </summary>
		/// <param name="other">The other.</param>
		/// <returns>System.Int32.</returns>
		public int CompareTo(CoordinateProper other)
		{
			var result = this.X.CompareTo(other.X);
			if (result != 0)
			{
				return result;
			}

			result = this.Y.CompareTo(other.Y);

			if (result != 0)
			{
				return result;
			}

			return result;
		}

		/// <summary>
		/// Determines whether the specified <see cref="object" /> is equal to this instance.
		/// </summary>
		/// <param name="obj">The object to compare with the this instance.</param>
		/// <returns><c>true</c> if the specified <see cref="object" /> is equal to this instance; otherwise, <c>false</c>.</returns>
		public override bool Equals(object obj) => obj is CoordinateProper proper && this.Equals(proper);

		/// <summary>
		/// Indicates whether the current object is equal to another object of the same type.
		/// </summary>
		/// <param name="other">An object to compare with this instance.</param>
		/// <returns>True if the current object is equal to the <paramref name="other">other</paramref> parameter; otherwise, false.</returns>
		public bool Equals(CoordinateProper other) => this.X == other.X && this.Y == other.Y;

		/// <summary>
		/// Returns a hash code for this instance.
		/// </summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
		public override int GetHashCode() => HashCode.Combine(this.X, this.Y);

		/// <summary>
		/// Returns a <see cref="string" /> of the coordinates.
		/// </summary>
		/// <returns>A <see cref="string" /> of the coordinates.</returns>
		public override string ToString() => $"{this.X}-{this.Y}";
	}
}
