// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Common
// Author           : David McCarter
// Created          : 10-23-2020
//
// Last Modified By : David McCarter
// Last Modified On : 12-01-2020
// ***********************************************************************
// <copyright file="EnumHelper.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace dotNetTips.Spargine.Core
{
    /// <summary>
    /// EnumHelper.
    /// </summary>
    public static class EnumHelper
    {
        /// <summary>
        /// Gets the enum values.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="fixNames">if set to <c>true</c> [fix names].</param>
        /// <param name="useXmlNames">if set to <c>true</c> [use XML names].</param>
        /// <returns>List&lt;EnumValue&gt;.</returns>
        /// <exception cref="InvalidEnumTypeException"></exception>
        [Information(nameof(GetEnumValues), author: "David McCarter", createdOn: "1/1/2020", modifiedOn: "11/24/2020", UnitTestCoverage = 100, Status = Status.Available)]
        public static List<EnumValue> GetEnumValues<T>(bool fixNames, bool useXmlNames)
            where T : Enum
        {
            var enumType = typeof(T);

            if (enumType == null)
            {
                ExceptionThrower.ThrowInvalidEnumTypeException(string.Format(CultureInfo.CurrentCulture, "Failed to find type {0}", enumType.Name));
            }

            // Get the enum values
            var allValues = (int[])Enum.GetValues(enumType);

            // Get list of names
            // Add values to result
            var result = new List<EnumValue>();

            // TODO: This does not work if enums are not defined 0,1,2, etc
            var enumNames = GetEnumNames(enumType, fixNames, useXmlNames);

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
            const string ToTitleCase = @"(\B[A-Z])";
            return Regex.Replace(name, ToTitleCase, " $1");
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
        private static List<string> GetEnumNames(Type t, bool fixNames, bool useXml)
        {
            // Set up result
            var result = new List<string>();

            // Enum names (text) are defined as fields for the type
            foreach (FieldInfo enumValue in t.GetFields(BindingFlags.Public | BindingFlags.Static))
            {
                // If XML is specified and found, use this name
                if (useXml)
                {
                    var attribute = (XmlEnumAttribute)Attribute.GetCustomAttribute(enumValue, typeof(XmlEnumAttribute));

                    if (attribute != null)
                    {
                        result.Add(attribute.Name);
                        continue;
                    }
                }

                // Attempt to use the Description attribute (if present)
                var description = (DescriptionAttribute)Attribute.GetCustomAttribute(enumValue, typeof(DescriptionAttribute));

                if (description != null)
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
