// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Tester
// Author           : David McCarter
// Created          : 12-29-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-25-2021
// ***********************************************************************
// <copyright file="Coordinate.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Tester.Models
{
	/// <summary>
	/// Struct Coordinate
	/// Implements the <see cref="dotNetTips.Spargine.Tester.Models.ICoordinate" />
	/// </summary>
	/// <seealso cref="dotNetTips.Spargine.Tester.Models.ICoordinate" />
	[Serializable]
	public struct Coordinate : ICoordinate, IEquatable<Coordinate>
	{

		/// <summary>
		/// Gets or sets the i coordinate.
		/// </summary>
		/// <value>The i coordinate.</value>
		public ICoordinate ICoordinate
		{
			get => default;
			set
			{
			}
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
		/// Implements the == operator.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>The result of the operator.</returns>
		public static bool operator ==(Coordinate left, Coordinate right) => left.Equals(right);

		/// <summary>
		/// Implements the != operator.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>The result of the operator.</returns>
		public static bool operator !=(Coordinate left, Coordinate right) => !( left == right );

		/// <summary>
		/// Determines whether the specified <see cref="object" /> is equal to this instance.
		/// </summary>
		/// <param name="obj">The object to compare with the current instance.</param>
		/// <returns><c>true</c> if the specified <see cref="object" /> is equal to this instance; otherwise, <c>false</c>.</returns>
		/// <exception cref="NotImplementedException"></exception>
		public override bool Equals(object obj)
		{
			var thisObj = this;
			return ReferenceEquals(objA: thisObj, objB: obj);
		}

		/// <summary>
		/// Indicates whether the current object is equal to another object of the same type.
		/// </summary>
		/// <param name="other">An object to compare with this object.</param>
		/// <returns>true if the current object is equal to the <paramref name="other">other</paramref> parameter; otherwise, false.</returns>
		public bool Equals(Coordinate other) => this.X == other.X && this.Y == other.Y;

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
