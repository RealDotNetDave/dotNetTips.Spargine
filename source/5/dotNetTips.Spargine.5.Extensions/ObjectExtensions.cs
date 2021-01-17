// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions **
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 01-07-2021
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
using dotNetTips.Spargine.Core.OOP;
using Newtonsoft.Json;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
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
		/// <param name="obj">The value.</param>
		/// <returns>T.</returns>
		/// <exception cref="ArgumentNullException">Object cannot be null.</exception>
		[Information(nameof(As), UnitTestCoverage = 100, Status = Status.Available)]
		public static T As<T>(this object obj)
		{
			Encapsulation.TryValidateNullParam(obj, nameof(obj));

			return (T)obj;
		}

		/// <summary>
		/// Clones the specified object.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="obj">The object.</param>
		/// <returns>T.</returns>
		/// <exception cref="ArgumentNullException">Object cannot be null.</exception>
		[Information(nameof(Clone), UnitTestCoverage = 100, Status = Status.Available)]
		public static T Clone<T>(this object obj)
			where T : class
		{
			Encapsulation.TryValidateNullParam(obj, nameof(obj));

			return FromJson<T>(obj.ToJson());
		}

		/// <summary>
		/// Computes the sha256 hash.
		/// </summary>
		/// <param name="obj">The data.</param>
		/// <returns>System.String.</returns>
		/// <exception cref="ArgumentNullException">Object cannot be null.</exception>
		[Information(nameof(ComputeSha256Hash), UnitTestCoverage = 100, Status = Status.Available)]
		public static string ComputeSha256Hash(this object obj)
		{
			Encapsulation.TryValidateNullParam(obj, nameof(obj));

			// Create a SHA256   
			using var sha256Hash = SHA256.Create();
			// ComputeHash - returns byte array  
			var bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(obj.ToJson()));

			// Convert byte array to a string   
			var sb = TypeHelper.CreateStringBuilder();

			for (var i = 0; i < bytes.Length; i++)
			{
				sb.Append(bytes[i].ToString("x2", CultureInfo.InvariantCulture));
			}

			return sb.ToString();
		}

		/// <summary>
		/// Disposes the fields.
		/// </summary>
		/// <param name="obj">The object.</param>
		/// <exception cref="ArgumentNullException">obj</exception>
		[Information(nameof(DisposeFields), UnitTestCoverage = 100, Status = Status.Available)]
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
		/// Determines whether the specified object has the property.
		/// </summary>
		/// <param name="obj">The instance.</param>
		/// <param name="propertyName">Name of the property.</param>
		/// <returns><c>true</c> if the specified property name has property; otherwise, <c>false</c>.</returns>
		/// <exception cref="ArgumentNullException">Object name cannot be null.</exception>
		[Information(nameof(HasProperty), UnitTestCoverage = 100, Status = Status.Available)]
		public static bool HasProperty(this object obj, string propertyName)
		{
			Encapsulation.TryValidateNullParam(obj, nameof(obj));

			var propertyInfo = obj.GetType().GetRuntimeProperties().FirstOrDefault(p => p.Name == propertyName);

			return propertyInfo != null;
		}

		/// <summary>
		/// Initializes the fields of an object.
		/// </summary>
		/// <param name="obj">The object.</param>
		/// <exception cref="ArgumentNullException">Input cannot be null.</exception>
		[Information(nameof(InitializeFields), UnitTestCoverage = 100, Status = Status.Available)]
		public static void InitializeFields(this object obj)
		{
			Encapsulation.TryValidateNullParam(obj, nameof(obj));

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
		public static bool IsNotNull(this object obj) => obj != null; //TODO: THIS CONDITION NOT BEING TESTED

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
		/// <param name="obj">The input.</param>
		/// <param name="bindingFlags">The binding flags.</param>
		/// <returns>IDictionary&lt;System.String, System.Object&gt;.</returns>
		/// <example>Output:
		/// [Address1, `fqrZjAqTNANUNIyJWFyNjCQx]
		/// [Address2, bSUnkmaIIMutgJtAKYZANpSHM]
		/// [Age, 23360.00:00:00.0086580]
		/// [BornOn, 1/23/1957 2:45:24 PM -08:00]
		/// [CellPhone, 704-375-5873]
		/// [City, fDbZYFMANE\MLxD]
		/// [Country, RbPjkyMasw`gnWR]
		/// [Email, thmiduaodph@djpumhmaheckkmrmwkkpxs.gov]
		/// [FirstName, ugdv\bhaHgSY^Ui]
		/// [HomePhone, 147-205-1085]
		/// [Id, f1bcbdbdf18a4adaa89e46383b235008]
		/// [LastName, H^hkKhwWggIrUCYbbxiFEJGJM]
		/// [PostalCode, 86560656].
		/// </example>
		[Information(nameof(PropertiesToDictionary), author: "David McCarter", createdOn: "11/19/2020", modifiedOn: "11/19/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.New)]
		public static IDictionary<string, object> PropertiesToDictionary(this object obj, BindingFlags bindingFlags = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance)
		{
			Encapsulation.TryValidateParam<ArgumentException>(obj != null, nameof(obj));

			return obj.GetType()
				 .GetProperties(bindingFlags | BindingFlags.GetProperty)
				 .ToDictionary(prop => prop.Name, prop => prop.GetValue(obj));
		}

		/// <summary>
		/// Generates a string that returns the property names and values.
		/// The input cannot be a collection type.
		/// Supports nested types.
		/// </summary>
		/// <param name="obj">The input.</param>
		/// <param name="ignoreNullValues">if set to <c>true</c> [ignore null values].</param>
		/// <param name="delimiter">The delimiter.</param>
		/// <returns>System.String.</returns>
		/// <exception cref="ArgumentNullException">Object cannot be null.</exception>
		/// <exception cref="ArgumentInvalidException">Object cannot be a collection type.</exception>
		[Information(nameof(PropertiesToString), author: "David McCarter", createdOn: "11/19/2020", modifiedOn: "11/19/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.New)]
		public static string PropertiesToString(this object obj, bool ignoreNullValues = true, char delimiter = ControlChars.Comma)
		{
			Encapsulation.TryValidateNullParam(obj, nameof(obj));
			Encapsulation.TryValidateParam<ArgumentInvalidException>(obj.GetType().Name != typeof(List<>).Name, nameof(obj));

			var properties = obj.PropertiesToDictionary();

			if (properties.Count == 0)
			{
				return string.Empty;
			}
			else
			{
				var propertiesSb = TypeHelper.CreateStringBuilder();

				foreach (var property in properties.OrderBy(p => p.Key))
				{
					if (property.Value.IsNull() && ignoreNullValues)
					{
						// Ignore
					}
					else if (property.Value.GetType().UnderlyingSystemType.Name == typeof(List<>).Name)
					{
						var collectionSb = TypeHelper.CreateStringBuilder();

						foreach (var item in (IEnumerable)property.Value)
						{
							collectionSb.Append(item.PropertiesToString(true));
						}

						//Process collection
						propertiesSb.Append($"{property.Key}: {collectionSb}{ControlChars.Space}");
					}
					else
					{
						propertiesSb.Append($"{property.Key}: {property.Value}{delimiter}{ControlChars.Space}");
					}
				}

				var returnValue = propertiesSb.ToString(0, propertiesSb.Length - 1);

				return returnValue;
			}
		}

		/// <summary>
		/// Returns ToString() value if not null.
		/// </summary>
		/// <param name="obj">The field.</param>
		/// <returns>System.String.</returns>
		[Information(nameof(StripNull), UnitTestCoverage = 100, Status = Status.Available)]
		public static string StripNull(this object obj) => obj == null ? string.Empty : obj.ToString();

		/// <summary>
		/// Serializes object to Json.
		/// </summary>
		/// <param name="obj">The instance.</param>
		/// <returns>System.String.</returns>
		[Information(nameof(ToJson), UnitTestCoverage = 100, Status = Status.Available)]
		public static string ToJson(this object obj)
		{
			if (obj is null)
			{
				return string.Empty;
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
		[Information(nameof(ToJsonFile), UnitTestCoverage = 100, Status = Status.Available)]
		public static void ToJsonFile(this object obj, string fileName)
		{
			Encapsulation.TryValidateNullParam(obj, nameof(obj));
			Encapsulation.TryValidateParam(fileName, nameof(fileName));

			var json = JsonConvert.SerializeObject(obj);

			File.WriteAllText(fileName, json, Encoding.UTF8);
		}

		/// <summary>
		/// Tries the to call Dispose.
		/// </summary>
		/// <param name="obj">The obj.</param>
		[Information(nameof(TryDispose), UnitTestCoverage = 100, Status = Status.Available)]
		public static void TryDispose(this IDisposable obj) => ObjectExtensions.TryDispose(obj, false);

		/// <summary>
		/// Tries to Dispose the object.
		/// </summary>
		/// <param name="obj">The obj.</param>
		/// <param name="throwException">if set to <count>true</count> [throw exception].</param>
		/// <exception cref="ArgumentNullException">obj</exception>
		[Information(nameof(TryDispose), UnitTestCoverage = 100, Status = Status.Available)]
		public static void TryDispose(this IDisposable obj, bool throwException)
		{
			if (obj is null)
			{
				return;
			}

			try
			{
				if (obj is IAsyncDisposable asyncDisposable)
				{
					_ = asyncDisposable.DisposeAsync();
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

		/// <summary>
		/// Converts JSON to Type.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="json">The json.</param>
		/// <returns>T.</returns>
		private static T FromJson<T>(string json)
	where T : class
		{
			return JsonConvert.DeserializeObject<T>(json);
		}

	}
}
