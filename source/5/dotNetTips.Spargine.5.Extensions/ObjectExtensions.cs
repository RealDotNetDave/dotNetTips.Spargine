// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions **
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 12-17-2020
// ***********************************************************************
// <copyright file="ObjectExtensions.cs" company="David McCarter - dotNetTips.com">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Extensions.Properties;
using Newtonsoft.Json;

namespace dotNetTips.Spargine.Extensions
{
    /// <summary>
    /// Class ObjectExtensions.
    /// </summary>
    public static class ObjectExtensions
    {
        /// <summary>
        /// Converts object to a different type.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="value">The value.</param>
        /// <returns>T.</returns>
        /// <exception cref="ArgumentNullException">value - Value cannot be null.</exception>
        [Information(nameof(As), UnitTestCoverage = 99, Status = Status.Available)]
        public static T As<T>(this object value)
        {
            if (value == null)
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(value));
            }

            return (T)value;
        }

        /// <summary>
        /// Clones the specified object.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="obj">The object.</param>
        /// <returns>T.</returns>
        /// <exception cref="ArgumentNullException">obj</exception>
        [Information(nameof(Clone), UnitTestCoverage = 99, Status = Status.Available)]
        public static T Clone<T>(this object obj)
            where T : class
        {
            if (obj is null)
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(obj));
            }

            return obj.ToJson().FromJson<T>();
        }

        /// <summary>
        /// Computes the sha256 hash.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>System.String.</returns>
        [Information(nameof(ComputeSha256Hash), UnitTestCoverage = 0, Status = Status.Available)]
        public static string ComputeSha256Hash(this object data)
        {
            // Create a SHA256   
            using var sha256Hash = SHA256.Create();
            // ComputeHash - returns byte array  
            var bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(data.ToJson()));

            // Convert byte array to a string   
            var builder = new StringBuilder();

            for (var i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2", CultureInfo.InvariantCulture));
            }

            return builder.ToString();
        }

        /// <summary>
        /// Disposes the fields.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <exception cref="ArgumentNullException">obj</exception>
        [Information(nameof(DisposeFields), UnitTestCoverage = 0, Status = Status.Available)]
        public static void DisposeFields(this IDisposable obj)
        {
            if (obj == null)
            {

                return;
            }

            var list = obj.GetType().GetRuntimeFields().Where(p => p.IsStatic == false).ToList();

            for (var fieldCount = 0; fieldCount < list.Count; fieldCount++)
            {
                var value = list[fieldCount].GetValue(obj);

                if (value != null)
                {
                    if (value is IDisposable disposableItem)
                    {
                        disposableItem.TryDispose();
                    }
                    else if (value is IEnumerable collection)
                    {
                        collection.DisposeCollection();
                    }
                }
            }
        }

        /// <summary>
        /// Creates object from Json.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="json">The json.</param>
        /// <returns>T.</returns>
        [Information(nameof(FromJson), UnitTestCoverage = 99, Status = Status.Available)]
        public static T FromJson<T>(this string json)
            where T : class
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

        /// <summary>
        /// Creates object from a Json file.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="fileName">Name of the file.</param>
        /// <returns>T.</returns>
        /// <exception cref="FileNotFoundException">The exception.</exception>
        /// <exception cref="System.IO.FileNotFoundException">The exception.</exception>
        [Information(nameof(FromJsonFile), UnitTestCoverage = 0, Status = Status.Available)]
        public static T FromJsonFile<T>(string fileName)
            where T : class
        {
            if (File.Exists(fileName) == false)
            {
                ExceptionThrower.ThrowFileNotFoundException(Resources.FileNotFound, fileName);
            }

            var json = File.ReadAllText(fileName, Encoding.UTF8);

            return JsonConvert.DeserializeObject<T>(json);
        }

        /// <summary>
        /// Determines whether the specified object has the property.
        /// </summary>
        /// <param name="obj">The instance.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <returns><c>true</c> if the specified property name has property; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">propertyName - Source cannot be null.</exception>
        [Information(nameof(HasProperty), UnitTestCoverage = 0, Status = Status.Available)]
        public static bool HasProperty(this object obj, string propertyName)
        {
            if (obj is null)
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(obj));
            }

            var propertyInfo = obj.GetType().GetRuntimeProperties().FirstOrDefault(p => p.Name == propertyName);

            return propertyInfo != null;
        }

        /// <summary>
        /// Ins the specified source.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="list">The list.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="ArgumentNullException">source - Source cannot be null.
        /// or
        /// list - List cannot be null or have a 0 length.</exception>
        /// <remarks>Original code by: Rory Becker</remarks>
        [Information(nameof(In), UnitTestCoverage = 0, Status = Status.Available)]
        public static bool In<T>(this T source, params T[] list) => list.FastAny(value => value.Equals(source));

        /// <summary>
        /// Initializes the fields of an object.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <exception cref="ArgumentNullException">Input cannot be null.</exception>
        [Information(nameof(InitializeFields), UnitTestCoverage = 0, Status = Status.Available)]
        public static void InitializeFields(this object obj)
        {
            if (obj is null)
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(obj));
            }

            var fieldInfos = obj.GetType().GetRuntimeFields().ToList();

            for (var fieldCount = 0; fieldCount < fieldInfos.Count; fieldCount++)
            {
                var fieldInfo = fieldInfos[fieldCount];
                var objectValue = fieldInfo.GetValue(obj);
                var runtimeField = obj.GetType().GetRuntimeField(fieldInfo.Name);

                if (runtimeField != null)
                {
                    var t = Nullable.GetUnderlyingType(runtimeField.FieldType) ?? runtimeField.FieldType;
                    var safeValue = ( objectValue == null )
                        ? null
                        : Convert.ChangeType(objectValue, t, CultureInfo.InvariantCulture);
                    runtimeField.SetValue(obj, safeValue);
                }
            }
        }

        /// <summary>
        /// Determines whether [is not null] [the specified object].
        /// </summary>
        /// <param name="obj">The obj.</param>
        /// <returns><count>true</count> if [is not null] [the specified object]; otherwise, <count>false</count>.</returns>
        [Information(nameof(IsNotNull), UnitTestCoverage = 100, Status = Status.Available)]
        public static bool IsNotNull(this object obj) => obj != null;

        /// <summary>
        /// Determines whether the specified object is null.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns><count>true</count> if the specified object is null; otherwise, <count>false</count>.</returns>
        [Information(nameof(IsNull), UnitTestCoverage = 100, Status = Status.Available)]
        public static bool IsNull(this object obj) => obj is null;

        /// <summary>
        /// Generates a Dictionary that represents the property name (Key) and it's value.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="bindingFlags">The binding flags.</param>
        /// <returns>IDictionary&lt;System.String, System.Object&gt;.</returns>
        [Information(nameof(PropertiesToDictionary), author: "David McCarter", createdOn: "11/19/2020", modifiedOn: "11/19/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.New)]
        public static IDictionary<string, object> PropertiesToDictionary(this object input, BindingFlags bindingFlags = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance)
        {
            return input.GetType()
                 .GetProperties(bindingFlags | BindingFlags.GetProperty)
                 .ToDictionary(prop => prop.Name, prop => prop.GetValue(input, null));
        }

        /// <summary>
        /// Generates a string that returns the property names and values.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="ignoreNullValues">if set to <c>true</c> [ignore null values].</param>
        /// <param name="delimiter">The delimiter.</param>
        /// <returns>System.String.</returns>
        [Information(nameof(PropertiesToString), author: "David McCarter", createdOn: "11/19/2020", modifiedOn: "11/19/2020", UnitTestCoverage = 99, BenchMarkStatus = BenchMarkStatus.None, Status = Status.New)]
        public static string PropertiesToString(this object input, bool ignoreNullValues, char delimiter = ControlChars.Comma)
        {
            //TODO: LOOK INTO MAKING THIS BETTER WITH TYPES LIKE COLLECTIONS AND GENERICS.
            var properties = input.PropertiesToDictionary();

            if (properties.Count == 0)
            {
                return string.Empty;
            }
            else
            {
                var sb = new StringBuilder();

                foreach (var property in properties)
                {
                    if (ignoreNullValues && property.Value.IsNull())
                    {
                        // Ignore
                    }
                    else
                    {
                        sb.Append($"{property.Key}: {property.Value}, ");
                    }
                }

                var returnValue = sb.ToString(0, sb.Length - 1);

                return returnValue;
            }
        }

        /// <summary>
        /// Strips the null.
        /// </summary>
        /// <param name="input">The field.</param>
        /// <returns>System.String.</returns>
        [Information(nameof(StripNull), UnitTestCoverage = 0, Status = Status.Available)]
        public static string StripNull(this object input) => input == null ? string.Empty : input.ToString();

        /// <summary>
        /// Serializes object to Json.
        /// </summary>
        /// <param name="obj">The instance.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="ArgumentNullException">obj</exception>
        [Information(nameof(ToJson), UnitTestCoverage = 99, Status = Status.Available)]
        public static string ToJson(this object obj)
        {
            if (obj is null)
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(obj));
            }

            return JsonConvert.SerializeObject(obj);
        }

        /// <summary>
        /// Saves object to Json file.
        /// </summary>
        /// <param name="obj">The instance.</param>
        /// <param name="fileName">The file.</param>
        /// <exception cref="ArgumentNullException">obj</exception>
        /// <exception cref="ArgumentException">message - fileName</exception>
        [Information(nameof(ToJsonFile), UnitTestCoverage = 0, Status = Status.Available)]
        public static void ToJsonFile(this object obj, string fileName)
        {
            if (obj is null)
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(obj));
            }

            if (string.IsNullOrEmpty(fileName))
            {
                ExceptionThrower.ThrowArgumentException(Resources.InvalidFileName, nameof(fileName));
            }

            var json = JsonConvert.SerializeObject(obj);


            File.WriteAllText(fileName, json, Encoding.UTF8);
        }

        /// <summary>
        /// Tries the to call Dispose.
        /// </summary>
        /// <param name="obj">The obj.</param>
        [Information(nameof(TryDispose), UnitTestCoverage = 0, Status = Status.Available)]
        public static void TryDispose(this IDisposable obj) => ObjectExtensions.TryDispose(obj, false);

        /// <summary>
        /// Tries to Dispose the object.
        /// </summary>
        /// <param name="obj">The obj.</param>
        /// <param name="throwException">if set to <count>true</count> [throw exception].</param>
        /// <exception cref="ArgumentNullException">obj</exception>
        [Information(nameof(TryDispose), UnitTestCoverage = 0, Status = Status.Available)]
        public static void TryDispose(this IDisposable obj, bool throwException)
        {
            if (obj is null)
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(obj));
            }

            // Swallow exception on purpose.
            try
            {
                if (obj is IAsyncDisposable asyncDisposable)
                {
                    asyncDisposable.DisposeAsync();
                }
                else
                {
                    obj.Dispose();
                }

                obj = null;
            }
            catch
            {
                if (throwException)
                {
                    throw;
                }
            }
        }

    }
}
