// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Core
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 06-29-2023
// ***********************************************************************
// <copyright file="EnumHelper.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Facilitates the usage of Enum's by providing convenient methods such
// as: AdjustCamelCase(), AdjustName(), GetNames(), and GetValues().
// </summary>
// ***********************************************************************
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// EnumHelper.
/// </summary>
public static class EnumHelper
{
	/// <summary>
	/// The title case regex
	/// </summary>
	private static readonly Regex _titleCaseRegex = new(@"(\B[A-Z])", RegexOptions.Multiline | RegexOptions.Compiled);

	/// <summary>
	/// Adjusts the camel case.
	/// </summary>
	/// <param name="name">The name.</param>
	/// <returns>System.String.</returns>
	private static string AdjustCamelCase(string name) => _titleCaseRegex.Replace(name, replacement: " $1");

	/// <summary>
	/// Adjusts the name.
	/// </summary>
	/// <param name="name">The name.</param>
	/// <returns>System.String.</returns>
	private static string AdjustName(string name) => AdjustCamelCase(name.Replace(ControlChars.Underscore, ControlChars.Space))
			.Replace(ControlChars.Space, ControlChars.Space);

	/// <summary>
	/// Gets the enum names.
	/// </summary>
	/// <param name="t">The t.</param>
	/// <param name="fixNames">if set to <c>true</c> [fix names].</param>
	/// <param name="useXml">if set to <c>true</c> [use XML].</param>
	/// <returns>List&lt;System.String&gt;.</returns>
	private static List<string> GetNames([NotNull] Type t, bool fixNames = true, bool useXml = true)
	{
		// Set up result
		var result = new List<string>();

		// Enum names (text) are defined as fields for the type
		for (var fieldCount = 0; fieldCount < t.GetFields(BindingFlags.Public | BindingFlags.Static).Length; fieldCount++)
		{
			var enumValue = t.GetFields(BindingFlags.Public | BindingFlags.Static)[fieldCount];

			// If XML is specified and found, use this name
			if (useXml)
			{
				var attribute = (XmlEnumAttribute)Attribute.GetCustomAttribute(enumValue, typeof(XmlEnumAttribute));

				if (attribute is not null)
				{
					result.Add(attribute.Name);
					continue;
				}
			}

			// Attempt to use the Description attribute (if present)
			var description = (DescriptionAttribute)Attribute.GetCustomAttribute(enumValue, typeof(DescriptionAttribute));

			if (description is not null)
			{
				// use this value
				result.Add(description.Description);
			}
			else
			{
				// If not found use the Enum name, with adjustment if requested
				result.Add(fixNames ? AdjustName(enumValue.Name) : enumValue.Name);
			}
		}

		return result;
	}

	/// <summary>
	/// Gets the enum values.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="fixNames">if set to <c>true</c> [fix names].</param>
	/// <param name="useXmlNames">if set to <c>true</c> [use XML names].</param>
	/// <returns>List&lt;EnumValue&gt;.</returns>
	/// <exception cref="InvalidEnumTypeException"></exception>
	[Information(nameof(GetValues), author: "David McCarter", createdOn: "1/1/2020", UnitTestCoverage = 100, Status = Status.Available)]
	public static IEnumerable<EnumValue> GetValues<T>(bool fixNames = true, bool useXmlNames = true)
		where T : Enum
	{
		var enumType = typeof(T);

		// Get the enum values
		var allValues = (int[])Enum.GetValues(enumType);

		// Get list of names
		// Add values to result
		var result = new List<EnumValue>();

		var enumNames = GetNames(enumType, fixNames, useXmlNames);

		for (var valueCount = 0; valueCount < allValues.Length; valueCount++)
		{
			result.Add(new EnumValue(allValues[valueCount], enumNames[valueCount]));
		}

		return result.AsEnumerable();
	}
}
