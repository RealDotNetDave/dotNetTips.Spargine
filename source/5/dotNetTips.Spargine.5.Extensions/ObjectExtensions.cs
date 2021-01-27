// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions **
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 01-19-2021
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
using System.Text.Json;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Core.OOP;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Class ObjectExtensions.
	/// </summary>
	public static class ObjectExtensions
	{
		private const string NullString = "[null]";

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
		[Information(nameof(DisposeFields), UnitTestCoverage = 100, Status = Status.Available)]
		public static void DisposeFields(this IDisposable obj)
		{
			if (obj is null)
			{
				return;
			}

			var list = obj.GetType().GetRuntimeFields().Where(p => p.IsStatic == false).ToList();

			if (list.DoesNotHaveItems())
			{
				return;
			}

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
		/// <exception cref="ArgumentNullException">Object cannot be null.</exception>
		[Information(nameof(InitializeFields), UnitTestCoverage = 100, Status = Status.Available)]
		public static void InitializeFields(this object obj)
		{
			Encapsulation.TryValidateNullParam(obj, nameof(obj));

			var fieldInfos = obj.GetType().GetRuntimeFields().ToList();

			if (fieldInfos.DoesNotHaveItems())
			{
				return;
			}

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
		public static bool IsNotNull(this object obj) => obj is not null;

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
		/// <param name="memberName">Name of the member used to identify the object.</param>
		/// <param name="ignoreNulls">if set to <c>true</c> [ignore <see langword="null"/> property values].</param>
		/// <returns>IDictionary&lt;System.String, System.Object&gt;.</returns>
		/// <exception cref="ArgumentNullException">Object cannot be null.</exception>
		/// <example>Output:
		/// [0]: {[PersonRecord.BornOn, 1/29/2007 11:52:12 AM -08:00]}
		/// [1]: {[PersonRecord.CellPhone, 747-388-4458]}
		/// [2]: {[PersonRecord.Email, elfhlsoepfmuiyr@uomrrywscvaapwjcu.org.uk]}
		/// [3]: {[PersonRecord.FirstName, ZyeMgwQRFABsisq]}
		/// [4]: {[PersonRecord.HomePhone, 255 - 871 - 4415]}
		/// [5]: {[PersonRecord.Id, 58dc933fe6004719a37e7a35373ad645]}
		/// [6]: {[PersonRecord.LastName, j_`iqWAGoOeKTpjWhojFyRHld]}
		/// [7]: {[PersonRecord.Addresses[0].Address1, XkbOcAlseMEMnPY ^ jkEcYWnFD]}
		/// [8]: {[PersonRecord.Addresses[0].Address2, tJkpTHikrRfFaGENX]`_agaw[]}
		/// [9]: {[PersonRecord.Addresses[0].City, KlWA ^ Aw]KhqADREV\uwmXJeAU]}
		/// [10]: {[PersonRecord.Addresses[0].Country, AtN`\NbnUIVSjUQicVXNMUL[J]}
		/// [11]: {[PersonRecord.Addresses[0].Id, 9330f3a225b14d96b67779f2c932302a]}
		/// [12]: {[PersonRecord.Addresses[0].CountyProvince, EkdKDBGWf ^ Givi[OMhIh]}
		/// [13]: {[PersonRecord.Addresses[0].State, RGOuDpJyfgwxyfC]}
		/// [14]: {[PersonRecord.Addresses[0].Phone, 065 - 507 - 7161]}
		/// [15]: {[PersonRecord.Addresses[0].PostalCode, 56633485]}
		/// [16]: {[PersonRecord.Addresses[1].Address1, lGSJwGNOtd ^ rXv`RxPcVCZHhk]}
		/// [17]: {[PersonRecord.Addresses[1].Address2, \EJGOmHyfAPERA ^ DrTR`xlDFU]}
		/// [18]: {[PersonRecord.Addresses[1].City, xiWPASydY[BEHfpVrluPNgOFS]}
		/// [19]: {[PersonRecord.Addresses[1].Country, JFpIljBDlQEkiehQ[r`\xjh[J]}
		/// [20]: {[PersonRecord.Addresses[1].Id, 8c95fd0cbbcf4beb993081bdd9c96ceb]}
		/// [21]: {[PersonRecord.Addresses[1].CountyProvince, FyHoHRZQwpMJ[gjABVUk]}
		/// [22]: {[PersonRecord.Addresses[1].State, dxeZkn[HyLo\wUS]}
		/// [23]: {[PersonRecord.Addresses[1].Phone, 511 - 286 - 7653]}
		/// [24]: {[PersonRecord.Addresses[1].PostalCode, 33385672]}
		/// </example>
		[Information("Original code by: Diego De Vita", author: "David McCarter", createdOn: "11/19/2020", modifiedOn: "1/26/2021", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.New)]
		public static IDictionary<string, string> PropertiesToDictionary(this object obj, string memberName = ControlChars.EmptyString, bool ignoreNulls = true)
		{
			// TODO: ADD LINK TO ARTICLE FOR THIS METHOD.
			Encapsulation.TryValidateNullParam(obj, nameof(obj));
			Encapsulation.TryValidateNullParam(memberName, nameof(memberName));

			var result = new Dictionary<string, string>();

			if (obj is null)
			{
				result.Add(memberName, NullString);
				return result;
			}

			var objectType = obj.GetType();

			// Reserve a special treatment for specific types by design (like string -that's a list of chars and you don't want to iterate on its items)
			if (TypeHelper.BuiltInTypeNames.ContainsKey(objectType))
			{
				result.Add(memberName, obj.ToString());
				return result;
			}

			// If the type implements the IEnumerable interface.
			if (objectType.IsEnumerable())
			{
				var itemCount = 0;

				// Loop through the collection using the enumerator strategy and collect all items in the result bag
				// Note: if the collection is empty it will not return anything about its existence,
				// because the method is supposed to catch value items not the list itself                
				foreach (var item in (IEnumerable)obj)
				{
					var itemId = itemCount++;

					// TODO: CHANGE TO USE ID PROPERTY AS INDEX
					//if (objectType == typeof(IDataModel<,>))
					//{

					//}

					var itemInnerMember = string.Format(CultureInfo.CurrentCulture, "{0}[{1}]", memberName, itemId);
					result = result.Concat(item.PropertiesToDictionary(itemInnerMember)).ToDictionary(e => e.Key, e => e.Value);
				}
				return result;
			}

			// Otherwise go deeper in the object tree.           
			// And foreach object public property collect each value
			var propertyCollection = objectType.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance);

			var newMemberName = string.Empty;

			if (memberName.Length > 0)
			{
				newMemberName = memberName + ControlChars.Dot;
			}

			foreach (var property in propertyCollection)
			{
				var innerObject = property.GetValue(obj, null);

				if (ignoreNulls && innerObject == null)
				{
					continue;
				}

				var innerMember = string.Format(CultureInfo.CurrentCulture, "{0}{1}", newMemberName, property.Name);
				result = result.Concat(innerObject.PropertiesToDictionary(innerMember)).ToDictionary(e => e.Key, e => e.Value);
			}

			return result;
		}

		/// <summary>
		/// Generates a string that returns the property names and values.
		/// The input cannot be a collection type.
		/// Supports nested types.
		/// </summary>
		/// <param name="obj">The input.</param>
		/// <param name="header">The header.</param>
		/// <param name="keyValueSeparator">The key value separator.</param>
		/// <param name="sequenceSeparator">The delimiter.</param>
		/// <param name="ignoreNulls">if set to <c>true</c> [ignore null values].</param>
		/// <returns>System.String.</returns>
		/// <exception cref="ArgumentNullException">Object cannot be null.</exception>
		/// <exception cref="ArgumentInvalidException">Object cannot be a collection type.</exception>
		/// <example>Output:
		/// PersonRecord, PersonRecord.BornOn:1/29/2007 11:52:12 AM -08:00, PersonRecord.CellPhone:747-388-4458,
		/// PersonRecord.Email:elfhlsoepfmuiyr @uomrrywscvaapwjcu.org.uk, PersonRecord.FirstName:ZyeMgwQRFABsisq,
		/// PersonRecord.HomePhone:255-871-4415, PersonRecord.Id:58dc933fe6004719a37e7a35373ad645,
		/// PersonRecord.LastName:j_`iqWAGoOeKTpjWhojFyRHld, PersonRecord.Addresses[0].Address1:XkbOcAlseMEMnPY^jkEcYWnFD,
		/// PersonRecord.Addresses[0].Address2:tJkpTHikrRfFaGENX]`_agaw[,
		/// PersonRecord.Addresses[0].City:KlWA ^ Aw] KhqADREV\\uwmXJeAU,
		/// PersonRecord.Addresses[0].Country:AtN`\\NbnUIVSjUQicVXNMUL[J,
		/// PersonRecord.Addresses[0].Id:9330f3a225b14d96b67779f2c932302a,
		/// PersonRecord.Addresses[0].CountyProvince:EkdKDBGWf ^ Givi[OMhIh,
		/// PersonRecord.Addresses[0].State:RGOuDpJyfgwxyfC, PersonRecord.Addresses[0].Phone:065 - 507 - 7161,
		/// PersonRecord.Addresses[0].PostalCode:56633485, PersonRecord.Addresses[1].Address1:lGSJwGNOtd ^ rXv`RxPcVCZHhk,
		/// PersonRecord.Addresses[1].Address2:\\EJGOmHyfAPERA ^ DrTR`xlDFU,
		/// PersonRecord.Addresses[1].City:xiWPASydY[BEHfpVrluPNgOFS,
		/// PersonRecord.Addresses[1].Country:JFpIljBDlQEkiehQ[r`\\xjh[J,
		/// PersonRecord.Addresses[1].Id:8c95fd0cbbcf4beb993081bdd9c96ceb,
		/// PersonRecord.Addresses[1].CountyProvince:FyHoHRZQwpMJ[gjABVUk,
		/// PersonRecord.Addresses[1].State:dxeZkn[HyLo\\wUS, PersonRecord.Addresses[1].Phone:511 - 286 - 7653,
		/// PersonRecord.Addresses[1].PostalCode:33385672
		/// </example>
		[Information(nameof(PropertiesToString), author: "David McCarter", createdOn: "11/19/2020", modifiedOn: "1/26/2021", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.New)]
		public static string PropertiesToString(this object obj, string header = ControlChars.EmptyString, char keyValueSeparator = ControlChars.Colon, string sequenceSeparator = ControlChars.DefaultSeparator, bool ignoreNulls = true)
		{
			// TODO: ADD LINK TO ARTICLE FOR THIS METHOD.
			Encapsulation.TryValidateNullParam(obj, nameof(obj));
			Encapsulation.TryValidateNullParam(header, nameof(header));
			Encapsulation.TryValidateNullParam(sequenceSeparator, nameof(sequenceSeparator));

			var typeName = obj.GetType().Name;

			if (typeName == typeof(List<>).Name)
			{
				typeName = "Item";
			}

			var properties = obj.PropertiesToDictionary(memberName: typeName, ignoreNulls: ignoreNulls);

			var result = properties.Aggregate(header, (acc, pair) => string.Format(CultureInfo.CurrentCulture, "{0}{1}{2}{3}{4}", acc, sequenceSeparator, pair.Key, keyValueSeparator, pair.Value));

			return result.StartsWith(sequenceSeparator, StringComparison.CurrentCulture) ? result.Remove(0, sequenceSeparator.Length) : result;
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

			return JsonSerializer.Serialize(obj);
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

			var json = JsonSerializer.Serialize(obj);

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
			return JsonSerializer.Deserialize<T>(json);
		}

	}
}
