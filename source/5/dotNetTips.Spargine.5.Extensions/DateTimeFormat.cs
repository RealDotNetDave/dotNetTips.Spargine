// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions
// Author           : David McCarter
// Created          : 12-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 12-21-2020
// ***********************************************************************
// <copyright file="DateTimeFormat.cs" company="dotNetTips.Spargine.5.Extensions">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using dotNetTips.Spargine.Core;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Extensions
{
	/// <summary>
	/// DateTime Format.
	/// Implements the <see cref="dotNetTips.Spargine.Core.Enumeration" />
	/// </summary>
	/// <seealso cref="dotNetTips.Spargine.Core.Enumeration" />
	public class DateTimeFormat : Enumeration
	{

		/// <summary>
		/// Custom format. Example: Monday, December 21, 2020 3:16:12 PM
		/// </summary>
		public static readonly DateTimeFormat FullDateLongTime = new DateTimeFormat(0, "F");

		/// <summary>
		/// Custom format. Example: Monday, December 21, 2020 3:16 PM
		/// </summary>
		public static readonly DateTimeFormat FullDateShortTime = new DateTimeFormat(1, "f");

		/// <summary>
		/// Custom format. Example: Monday, December 21, 2020 3:16 PM
		/// </summary>
		public static readonly DateTimeFormat FullDateTime = new DateTimeFormat(2, "f");

		/// <summary>
		/// Custom format. Example: 2/21/2020 3:16:12 PM
		/// </summary>
		public static readonly DateTimeFormat GeneralDateLongTime = new DateTimeFormat(3, "G");

		/// <summary>
		/// Custom format. Example: 12/21/2020 3:16 PM
		/// </summary>
		public static readonly DateTimeFormat GeneralDateShortTime = new DateTimeFormat(4, "g");
		/// <summary>
		/// Custom format. Example: Dec 21, 2020
		/// </summary>
		public static readonly DateTimeFormat Jan01Comma2020 = new DateTimeFormat(5, "MMM dd, yyyy");

		/// <summary>
		/// Custom format. Example: December 21, 2020
		/// </summary>
		public static readonly DateTimeFormat Janurary01Comma2020 = new DateTimeFormat(6, "MMMM dd, yyyy");

		/// <summary>
		/// Custom format. Example: Monday, December 21, 2020
		/// </summary>
		public static readonly DateTimeFormat LongDate = new DateTimeFormat(7, "D");

		/// <summary>
		/// Custom format. Example: 3:16:12 PM
		/// </summary>
		public static readonly DateTimeFormat LongTime = new DateTimeFormat(8, "T");

		/// <summary>
		/// Custom format. Example: December 21
		/// </summary>
		public static readonly DateTimeFormat MonthDay = new DateTimeFormat(9, "M");

		/// <summary>
		/// Custom format. Example: December 2020
		/// </summary>
		public static readonly DateTimeFormat MonthYear = new DateTimeFormat(16, "Y");

		/// <summary>
		/// Custom format. Example: Mon, 21 Dec 2020 15:16:12 GMT
		/// </summary>
		public static readonly DateTimeFormat RFC1123 = new DateTimeFormat(10, "R");

		/// <summary>
		/// Custom format. Example: 2020-12-21T15:16:12.2487693-08:00
		/// </summary>
		public static readonly DateTimeFormat RoundTripDateTime = new DateTimeFormat(11, "O");

		/// <summary>
		/// Custom format. Example: 12/21/2020
		/// </summary>
		public static readonly DateTimeFormat ShortDate = new DateTimeFormat(12, "d");

		/// <summary>
		/// Custom format. Example: 3:16 PM
		/// </summary>
		public static readonly DateTimeFormat ShortTime = new DateTimeFormat(13, "t");

		/// <summary>
		/// Custom format. Example: 2020-12-21T15:16:12
		/// </summary>
		public static readonly DateTimeFormat SortableDateTime = new DateTimeFormat(14, "s");

		/// <summary>
		/// Custom format. Example: Monday, December 21, 2020 11:16:12 PM
		/// </summary>
		public static readonly DateTimeFormat UniversalFullDateTime = new DateTimeFormat(15, "U");

		/// <summary>
		/// Prevents a default instance of the <see cref="DateTimeFormat" /> class from being created.
		/// </summary>
		private DateTimeFormat() { }

		/// <summary>
		/// Initializes a new instance of the <see cref="DateTimeFormat" /> class.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="displayName">The display name.</param>
		private DateTimeFormat(int value, string displayName) : base(value, displayName) { }
	}
}
