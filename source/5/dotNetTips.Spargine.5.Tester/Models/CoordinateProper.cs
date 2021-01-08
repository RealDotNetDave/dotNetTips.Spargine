// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Tester
// Author           : David McCarter
// Created          : 06-04-2019
//
// Last Modified By : David McCarter
// Last Modified On : 03-10-2020
// ***********************************************************************
// <copyright file="CoordinateProper.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;

namespace dotNetTips.Spargine.Tester.Models
{
    /// <summary>
    /// Struct CoordinateProper
    /// Implements the <see cref="dotNetTips.Spargine.Tester.Models.ICoordinate" />
    /// Implements the <see cref="System.IComparable" />>
    /// </summary>
    /// <seealso cref="System.IComparable" />
    /// <seealso cref="dotNetTips.Spargine.Tester.Models.ICoordinate" />
    [Serializable]
    public struct CoordinateProper : ICoordinate, IEquatable<CoordinateProper>, IComparable, IComparable<CoordinateProper>
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

        /// <summary>
        /// Implements the &gt;= operator.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(CoordinateProper left, CoordinateProper right)
        {
            return left.CompareTo(right) >= 0;
        }

        /// <summary>
        /// Implements the &gt; operator.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(CoordinateProper left, CoordinateProper right)
        {
            return left.CompareTo(right) > 0;
        }

        /// <summary>
        /// Implements the == operator.
        /// </summary>
        /// <param name="cord1">The first coordinate.</param>
        /// <param name="cord2">The second coordinate.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(CoordinateProper cord1, CoordinateProper cord2)
        {
            return cord1.Equals(cord2);
        }

        /// <summary>
        /// Implements the &lt;= operator.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(CoordinateProper left, CoordinateProper right)
        {
            return left.CompareTo(right) <= 0;
        }

        /// <summary>
        /// Implements the &lt; operator.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(CoordinateProper left, CoordinateProper right)
        {
            return left.CompareTo(right) < 0;
        }
        /// <summary>
        /// Implements the != operator.
        /// </summary>
        /// <param name="cord1">The first coordinate.</param>
        /// <param name="cord2">The second coordinate.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(CoordinateProper cord1, CoordinateProper cord2)
        {
            return !( cord1 == cord2 );
        }

        /// <summary>
        /// Compares to.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns>System.Int32.</returns>
        /// <exception cref="ArgumentException">obj</exception>
        public int CompareTo(object obj)
        {
            if (!( obj is CoordinateProper ))
            {
                throw new ArgumentException(nameof(obj) + " is not a " + nameof(CoordinateProper));
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
        /// Determines whether the specified <see cref="System.Object" /> is equal to this instance.
        /// </summary>
        /// <param name="obj">The object to compare with the this instance.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            return obj is CoordinateProper && this.Equals((CoordinateProper)obj);
        }

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this instance.</param>
        /// <returns>True if the current object is equal to the <paramref name="other">other</paramref> parameter; otherwise, false.</returns>
        public bool Equals(CoordinateProper other)
        {
            return this.X == other.X && this.Y == other.Y;
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(this.X, this.Y);
        }

        /// <summary>
        /// Returns a <see cref="string" /> of the coordinates.
        /// </summary>
        /// <returns>A <see cref="string" /> of the coordinates.</returns>
        public override string ToString()
        {
            return $"{this.X}-{this.Y}";
        }
    }
}
