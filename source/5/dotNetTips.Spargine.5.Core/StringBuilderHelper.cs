// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Core
// Author           : David McCarter
// Created          : 02-18-2021
//
// Last Modified By : David McCarter
// Last Modified On : 12-27-2021
// ***********************************************************************
// <copyright file="StringBuilderHelper.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Core
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
			var sb = new StringBuilder();

			_ = sb.Append("'0x");

			for (var i = 0; i < bytes.Length; i++)
			{
				_ = sb.Append(bytes[i].ToString("X2", CultureInfo.InvariantCulture));
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
		public static string ConcatToString([NotNull] string delimiter, Tristate addLineFeed, params string[] args)
		{
			var sb = new StringBuilder();

			if (args.Length > 0)
			{
				for (var argCount = 0; argCount < args.Length; argCount++)
				{
					var value = args[argCount];

					//TODO: ADD EXTENSION METHOD TO TEST FOR ENUM VALUES
					if (addLineFeed is Tristate.True or Tristate.UseDefault)
					{
						//TODO: THIS CONDITION NOT BEING TESTED
						_ = sb.AppendLine(value);
					}
					else
					{
						_ = sb.Append(string.Concat(value, delimiter));
					}
				}
			}

			return sb.ToString();
		}

		/// <summary>
		/// Converts to list to a delimited string.
		/// </summary>
		/// <typeparam name="TKey">The type of the t key.</typeparam>
		/// <typeparam name="TValue">The type of the t value.</typeparam>
		/// <param name="list">The list.</param>
		/// <param name="delimiter">The delimiter.</param>
		/// <returns>System.String.</returns>
		public static string ToDelimitedString<TKey, TValue>([NotNull] Dictionary<TKey, TValue> list, char delimiter = ControlChars.Comma)
		{
			// TODO: ADD LINK TO ARTICLE FOR THIS METHOD.
			if (list?.LongCount() == 0)
			{
				return string.Empty;
			}

			var sb = new StringBuilder();

			foreach (var item in list)
			{
				_ = sb.Append($"{item.Key}:{item.Value}{delimiter.ToString(CultureInfo.CurrentCulture)}");
			}

			return sb.ToString(startIndex: 0, length: sb.Length - 1);
		}
	}
}
