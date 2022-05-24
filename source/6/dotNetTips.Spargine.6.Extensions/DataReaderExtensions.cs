// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions
// Author           : David McCarter
// Created          : 10-08-2020
//
// Last Modified By : David McCarter
// Last Modified On : 05-24-2022
// ***********************************************************************
// <copyright file="DataReaderExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;
using DotNetTips.Spargine.Core;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions
{
	/// <summary>
	/// DataReaderExtensions.
	/// </summary>
	public static class DataReaderExtensions
	{
		/// <summary>
		/// Converts <see cref="IDataReader" /> to CSV format.
		/// </summary>
		/// <param name="dataReader">The data reader.</param>
		/// <param name="includeHeaderAsFirstRow">if set to <c>true</c> [include header as first row].</param>
		/// <param name="separator">The separator.</param>
		/// <returns>List&lt;System.String&gt;.</returns>
		[Information(nameof(ToCsv), author: "David McCarter", createdOn: "10/8/2020", UnitTestCoverage = 0, Status = Status.Available)]
		public static IList<string> ToCsv([NotNull] this IDataReader dataReader, in bool includeHeaderAsFirstRow, char separator = ControlChars.Comma)
		{
			dataReader = dataReader.ArgumentNotNull();

			var convertedRows = new List<string>();

			if (includeHeaderAsFirstRow)
			{
				var sb = new StringBuilder();

				for (var fieldIndex = 0; fieldIndex <= dataReader.FieldCount - 1; fieldIndex++)
				{
					if (dataReader.GetName(fieldIndex) is not null)
					{
						_ = sb.Append(dataReader.GetName(fieldIndex));
					}

					if (fieldIndex < dataReader.FieldCount - 1)
					{
						_ = sb.Append(separator);
					}
				}

				convertedRows.Add(sb.ToString());
			}

			while (dataReader.Read())
			{
				var sb = new StringBuilder();

				for (var fieldIndex = 0; fieldIndex <= dataReader.FieldCount - 2; fieldIndex++)
				{
					if (!dataReader.IsDBNull(fieldIndex))
					{
						var value = dataReader.GetValue(fieldIndex).ToString();
						if (dataReader.GetFieldType(fieldIndex) == typeof(string))
						{
							// If double quotes are used in value, ensure each are replaced but 2.
							if (value.Contains(ControlChars.Backslash, StringComparison.Ordinal))
							{
								value = value.Replace("\"", "\"\"", StringComparison.Ordinal);
							}

							// If separator are is in value, ensure it is put in double quotes.
							if (value.Contains(separator, StringComparison.CurrentCulture))
							{
								value = $"{Convert.ToString(ControlChars.Backslash, CultureInfo.InvariantCulture)}{value}{ControlChars.Backslash}";
							}
						}

						_ = sb.Append(value);
					}

					if (fieldIndex < dataReader.FieldCount - 1)
					{
						_ = sb.Append(separator);
					}
				}

				if (!dataReader.IsDBNull(dataReader.FieldCount - 1))
				{
					_ = sb.Append(dataReader.GetValue(dataReader.FieldCount - 1).ToString().Replace(separator, ControlChars.Space));
				}

				convertedRows.Add(sb.ToString());
			}

			return convertedRows;
		}
	}
}
