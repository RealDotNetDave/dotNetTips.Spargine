// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions
// Author           : David McCarter
// Created          : 10-08-2020
//
// Last Modified By : David McCarter
// Last Modified On : 11-24-2020
// ***********************************************************************
// <copyright file="DataReaderExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Core.OOP;

//![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Extensions
{
	/// <summary>
	/// DataReaderExtensions.
	/// </summary>
	public static class DataReaderExtensions
	{
		/// <summary>
		/// Converts DataReader to CSV format.
		/// </summary>
		/// <param name="dataReader">The data reader.</param>
		/// <param name="includeHeaderAsFirstRow">if set to <c>true</c> [include header as first row].</param>
		/// <param name="separator">The separator.</param>
		/// <returns>List&lt;System.String&gt;.</returns>
		[Information(nameof(ToCsv), author: "David McCarter", createdOn: "10/8/2020", modifiedOn: "11/24/2020", UnitTestCoverage = 0, Status = Status.Available)]
		public static List<string> ToCsv(this IDataReader dataReader, bool includeHeaderAsFirstRow, char separator = ControlChars.Comma)
		{
			Encapsulation.TryValidateNullParam(dataReader, nameof(dataReader));

			var convertedRows = new List<string>();

			if (includeHeaderAsFirstRow)
			{
				var sb = TypeHelper.CreateStringBuilder();

				for (var index = 0; index <= dataReader.FieldCount - 1; index++)
				{
					if (dataReader.GetName(index) != null)
					{
						sb.Append(dataReader.GetName(index));
					}

					if (index < dataReader.FieldCount - 1)
					{
						sb.Append(separator);
					}
				}

				convertedRows.Add(sb.ToString());
			}

			while (dataReader.Read())
			{
				var sb = TypeHelper.CreateStringBuilder();

				for (var index = 0; index <= dataReader.FieldCount - 2; index++)
				{
					if (!dataReader.IsDBNull(index))
					{
						var value = dataReader.GetValue(index).ToString();
						if (dataReader.GetFieldType(index) == typeof(string))
						{
							// If double quotes are used in value, ensure each are replaced but 2.
							if (value.IndexOf(ControlChars.Backslash, StringComparison.Ordinal) >= 0)
							{
								value = value.Replace("\"", "\"\"");
							}

							// If separator are is in value, ensure it is put in double quotes.
							if (value.IndexOf(separator, StringComparison.Ordinal) >= 0)
							{
								value = Convert.ToString(ControlChars.Backslash, CultureInfo.InvariantCulture) + value + ControlChars.Backslash;
							}
						}

						sb.Append(value);
					}

					if (index < dataReader.FieldCount - 1)
					{
						sb.Append(separator);
					}
				}

				if (!dataReader.IsDBNull(dataReader.FieldCount - 1))
				{
					sb.Append(dataReader.GetValue(dataReader.FieldCount - 1).ToString().Replace(separator, ControlChars.Space));
				}

				convertedRows.Add(sb.ToString());
			}

			return convertedRows;
		}
	}
}
