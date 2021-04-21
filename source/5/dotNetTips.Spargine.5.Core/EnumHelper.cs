// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Core
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 04-18-2021
// ***********************************************************************
// <copyright file="EnumHelper.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Core
{
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
		/// Gets the enum values.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="fixNames">if set to <c>true</c> [fix names].</param>
		/// <param name="useXmlNames">if set to <c>true</c> [use XML names].</param>
		/// <returns>List&lt;EnumValue&gt;.</returns>
		/// <exception cref="InvalidEnumTypeException"></exception>
		[Information(nameof(GetValues), author: "David McCarter", createdOn: "1/1/2020", modifiedOn: "11/24/2020", UnitTestCoverage = 99, Status = Status.Available)]
		public static List<EnumValue> GetValues<T>(bool fixNames, bool useXmlNames)
			where T : Enum
		{
			var enumType = typeof(T);

			// Get the enum values
			var allValues = (int[])Enum.GetValues(enumType);

			// Get list of names
			// Add values to result
			var result = new List<EnumValue>();

			// TODO: This does not work if enums are not defined 0,1,2, etc
			var enumNames = GetNames(enumType, fixNames, useXmlNames);

			for (var i = 0; i < allValues.Length; i++)
			{
				result.Add(new EnumValue(allValues[i], enumNames[i]));
			}

			return result;
		}

		/// <summary>
		/// Adjusts the camel case.
		/// </summary>
		/// <param name="name">The name.</param>
		/// <returns>System.String.</returns>
		private static string AdjustCamelCase(string name)
		{
			//TODO: BEFORE NEXT RLEASE, SEE IF COMPILING THIS REGEX HELPED PERFORMANCE.
			return _titleCaseRegex.Replace(name, replacement: " $1");
		}

		/// <summary>
		/// Adjusts the name.
		/// </summary>
		/// <param name="name">The name.</param>
		/// <returns>System.String.</returns>
		private static string AdjustName(string name)
		{
			return AdjustCamelCase(name.Replace(ControlChars.Underscore, ControlChars.Space))
				.Replace(ControlChars.Space, ControlChars.Space);
		}

		/// <summary>
		/// Gets the enum names.
		/// </summary>
		/// <param name="t">The t.</param>
		/// <param name="fixNames">if set to <c>true</c> [fix names].</param>
		/// <param name="useXml">if set to <c>true</c> [use XML].</param>
		/// <returns>List&lt;System.String&gt;.</returns>
		[Information(nameof(GetNames), UnitTestCoverage = 99, Status = Status.Available)]
		private static List<string> GetNames(Type t, bool fixNames, bool useXml)
		{
			// Set up result
			var result = new List<string>();

			// Enum names (text) are defined as fields for the type
			for (var i = 0; i < t.GetFields(BindingFlags.Public | BindingFlags.Static).Length; i++)
			{
				var enumValue = t.GetFields(BindingFlags.Public | BindingFlags.Static)[i];

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
	}
}
