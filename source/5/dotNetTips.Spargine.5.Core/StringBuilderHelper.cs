// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Core
// Author           : David McCarter
// Created          : 02-18-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-21-2021
// ***********************************************************************
// <copyright file="StringBuilderHelper.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Microsoft.Extensions.ObjectPool;

namespace dotNetTips.Spargine.Core
{
	/// <summary>
	/// StringBuilder Helper.
	/// </summary>
	public static class StringBuilderHelper
	{
		/// <summary>
		/// The string builder pool
		/// </summary>
		private static readonly ObjectPool<StringBuilder> _stringBuilderPool = new DefaultObjectPoolProvider().CreateStringBuilderPool();


		/// <summary>
		/// Converts bytes to string using object pool.
		/// </summary>
		/// <param name="bytes">The bytes.</param>
		/// <returns>System.String.</returns>
		[Information(nameof(BytesToString), author: "David McCarter", createdOn: "2/18/2021", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.New)]
		public static string BytesToString(byte[] bytes)
		{
			Validate.TryValidateParam(bytes, nameof(bytes));

			var sb = _stringBuilderPool.Get();

			try
			{
				sb.Append("'0x");

				for (var i = 0; i < bytes.Length; i++)
				{
					sb.Append(bytes[i].ToString("X2", CultureInfo.InvariantCulture));
				}

				sb.Append('\'');

				return sb.ToString();
			}
			finally
			{
				_stringBuilderPool.Return(sb);
			}

		}

		/// <summary>
		/// Concatenates the specified first message with passed in string[].
		/// </summary>
		/// <param name="input">The first message.</param>
		/// <param name="delimiter">The delimiter.</param>
		/// <param name="addLineFeed">The add line feed. If set to true, delimiter will not be used.</param>
		/// <param name="args">The arguments.</param>
		/// <returns>System.String.</returns>
		/// <exception cref="ArgumentInvalidException">input cannot be null.</exception>
		[Information(nameof(ConcatToString), "David McCarter", "2/19/2021", UnitTestCoverage = 0, Status = Status.New)]
		public static string ConcatToString(string input, string delimiter, Tristate addLineFeed, params string[] args)
		{
			Validate.TryValidateParam(input, nameof(input));

			var sb = _stringBuilderPool.Get();

			try
			{
				if (args.Length > 0)
				{
					for (var argCount = 0; argCount < args.Length; argCount++)
					{
						var value = args[argCount];

						//TODO: ADD EXTENSION METHOD TO TEST FOR ENUM VALUES
						if (addLineFeed == Tristate.True || addLineFeed == Tristate.UseDefault)
						{
							//TODO: THIS CONDITION NOT BEING TESTED
							sb.AppendLine(value);
						}
						else
						{
							sb.Append(string.Concat(value, delimiter));
						}
					}
				}

				return sb.ToString();

			}
			finally
			{
				_stringBuilderPool.Return(sb);
			}
		}

		/// <summary>
		/// Converts to list to a delimited string.
		/// </summary>
		/// <typeparam name="TKey">The type of the t key.</typeparam>
		/// <typeparam name="TValue">The type of the t value.</typeparam>
		/// <param name="list">The list.</param>
		/// <param name="delimiter">The delimiter.</param>
		/// <returns>System.String.</returns>
		public static string ToDelimitedString<TKey, TValue>(Dictionary<TKey, TValue> list, char delimiter = ControlChars.Comma)
		{
			// TODO: ADD LINK TO ARTICLE FOR THIS METHOD.
			if (list.Count == 0)
			{
				return string.Empty;
			}

			var sb = _stringBuilderPool.Get();

			try
			{
				foreach (var item in list)
				{
					_ = sb.Append($"{item.Key}:{item.Value}{delimiter.ToString(CultureInfo.CurrentCulture)}");
				}

				return sb.ToString(startIndex: 0, length: sb.Length - 1);
			}
			finally
			{
				_stringBuilderPool.Return(sb);
			}
		}
	}
}
