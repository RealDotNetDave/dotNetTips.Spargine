// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions
// Author           : David McCarter
// Created          : 12-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 04-16-2022
// ***********************************************************************
// <copyright file="DateTimeFormat.cs" company="dotNetTips.Spargine.6.Extensions">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using DotNetTips.Spargine.Core;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions
{
	/// <summary>
	/// DateTime Format.
	/// Implements the <see cref="Enumeration" />
	/// </summary>
	/// <seealso cref="Enumeration" />
	public record DateTimeFormat : Enumeration
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DateTimeFormat" /> class.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="displayName">The display name.</param>
		private DateTimeFormat(int value, string displayName) : base(value, displayName) { }

		/// <summary>
		/// Custom format. Example: Monday, December 21, 2020 3:16:12 PM
		/// </summary>
		public static readonly DateTimeFormat FullDateLongTime = new(0, "F");

		/// <summary>
		/// Custom format. Example: Monday, December 21, 2020 3:16 PM
		/// </summary>
		public static readonly DateTimeFormat FullDateShortTime = new(1, "f");

		/// <summary>
		/// Custom format. Example: Monday, December 21, 2020 3:16 PM
		/// </summary>
		public static readonly DateTimeFormat FullDateTime = new(2, "f");

		/// <summary>
		/// Custom format. Example: 2/21/2020 3:16:12 PM
		/// </summary>
		public static readonly DateTimeFormat GeneralDateLongTime = new(3, "G");

		/// <summary>
		/// Custom format. Example: 12/21/2020 3:16 PM
		/// </summary>
		public static readonly DateTimeFormat GeneralDateShortTime = new(4, "g");
		/// <summary>
		/// Custom format. Example: Dec 21, 2020
		/// </summary>
		public static readonly DateTimeFormat Jan01Comma2020 = new(5, "MMM dd, yyyy");

		/// <summary>
		/// Custom format. Example: December 21, 2020
		/// </summary>
		public static readonly DateTimeFormat Janurary01Comma2020 = new(6, "MMMM dd, yyyy");

		/// <summary>
		/// Custom format. Example: Monday, December 21, 2020
		/// </summary>
		public static readonly DateTimeFormat LongDate = new(7, "D");

		/// <summary>
		/// Custom format. Example: 3:16:12 PM
		/// </summary>
		public static readonly DateTimeFormat LongTime = new(8, "T");

		/// <summary>
		/// Custom format. Example: December 21
		/// </summary>
		public static readonly DateTimeFormat MonthDay = new(9, "M");

		/// <summary>
		/// Custom format. Example: December 2020
		/// </summary>
		public static readonly DateTimeFormat MonthYear = new(16, "Y");

		/// <summary>
		/// Custom format. Example: Mon, 21 Dec 2020 15:16:12 GMT
		/// </summary>
		public static readonly DateTimeFormat RFC1123 = new(10, "R");

		/// <summary>
		/// Custom format. Example: 2020-12-21T15:16:12.2487693-08:00
		/// </summary>
		public static readonly DateTimeFormat RoundTripDateTime = new(11, "O");

		/// <summary>
		/// Custom format. Example: 12/21/2020
		/// </summary>
		public static readonly DateTimeFormat ShortDate = new(12, "d");

		/// <summary>
		/// Custom format. Example: 3:16 PM
		/// </summary>
		public static readonly DateTimeFormat ShortTime = new(13, "t");

		/// <summary>
		/// Custom format. Example: 2020-12-21T15:16:12
		/// </summary>
		public static readonly DateTimeFormat SortableDateTime = new(14, "s");

		/// <summary>
		/// Custom format. Example: Monday, December 21, 2020 11:16:12 PM
		/// </summary>
		public static readonly DateTimeFormat UniversalFullDateTime = new(15, "U");
	}
}
