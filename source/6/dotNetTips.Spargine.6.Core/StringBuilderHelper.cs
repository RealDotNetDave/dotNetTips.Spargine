// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Core
// Author           : David McCarter
// Created          : 02-18-2021
//
// Last Modified By : David McCarter
// Last Modified On : 07-31-2022
// ***********************************************************************
// <copyright file="StringBuilderHelper.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core
{
	/// <summary>
	/// StringBuilder Helper.
	/// </summary>
	public static class StringBuilderHelper
	{
		/// <summary>
		/// Converts bytes to string using object pool.
		/// </summary>
		/// <param name="bytes">The bytes.</param>
		/// <returns>System.String.</returns>
		[Information(nameof(BytesToString), author: "David McCarter", createdOn: "2/18/2021", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
		public static string BytesToString([NotNull] byte[] bytes)
		{
			bytes = bytes.ArgumentNotNull();

			var sb = new StringBuilder();

			_ = sb.Append("'0x");

			for (var byteCount = 0; byteCount < bytes.Length; byteCount++)
			{
				_ = sb.Append(bytes[byteCount].ToString("X2", CultureInfo.InvariantCulture));
			}

			_ = sb.Append('\'');

			return sb.ToString();
		}

		/// <summary>
		/// Concat to string.
		/// </summary>
		/// <param name="delimiter">The delimiter.</param>
		/// <param name="addLineFeed">The add line feed. If set to true, delimiter will not be used.</param>
		/// <param name="args">The arguments.</param>
		/// <returns>System.String.</returns>
		/// <exception cref="ArgumentInvalidException">input cannot be null.</exception>
		[Information(nameof(ConcatToString), "David McCarter", "2/19/2021", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
		public static string ConcatToString(string delimiter, Tristate addLineFeed, [NotNull] params string[] args)
		{
			delimiter = delimiter.ArgumentNotNullOrEmpty();
			args = args.ArgumentNotNull();

			var sb = new StringBuilder();

			if (args.Length > 0)
			{
				for (var argumentIndex = 0; argumentIndex < args.Length; argumentIndex++)
				{
					var value = args[argumentIndex];

					_ = addLineFeed is Tristate.True or Tristate.UseDefault ? sb.AppendLine(value) : sb.Append(string.Concat(value, delimiter));
				}
			}

			return sb.ToString();
		}

		/// <summary>
		/// Converts to list to a delimited string.
		/// </summary>
		/// <typeparam name="TKey">The type of the t key.</typeparam>
		/// <typeparam name="TValue">The type of the t value.</typeparam>
		/// <param name="collection">The list.</param>
		/// <param name="delimiter">The delimiter.</param>
		/// <returns>System.String.</returns>
		[Information(nameof(ToDelimitedString), "David McCarter", "1/1/2021", Status = Status.Available, BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Documentation = "https://bit.ly/SpargineFeb21")]
		public static string ToDelimitedString<TKey, TValue>([NotNull] Dictionary<TKey, TValue> collection, char delimiter = ControlChars.Comma)
		{
			if (collection.CheckItemsExists() is false)
			{
				return string.Empty;
			}

			var sb = new StringBuilder();

			foreach (KeyValuePair<TKey, TValue> item in collection)
			{
				if (sb.Length > 0)
				{
					_ = sb.Append(delimiter.ToString(CultureInfo.CurrentCulture));
				}

				_ = sb.Append($"{item.Key}: {item.Value}".ToString(CultureInfo.CurrentCulture));
			}

			return sb.ToString(startIndex: 0, length: sb.Length - 1);
		}
	}
}
