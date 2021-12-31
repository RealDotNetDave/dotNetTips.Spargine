// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Core
// Author           : David McCarter
// Created          : 02-10-2021
//
// Last Modified By : David McCarter
// Last Modified On : 09-17-2021
// ***********************************************************************
// <copyright file="InternalMethods.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;

namespace dotNetTips.Spargine.Core.Internal
{
	/// <summary>
	/// Class InternalMethods.
	/// </summary>
	internal static class InternalMethods
	{
		/// <summary>
		/// The null string
		/// </summary>
		private const string NullString = "[null]";

		/// <summary>
		/// Ensures the minimum.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="minValue">The minimum value.</param>
		/// <returns>System.Int32.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(EnsureMinimum), UnitTestCoverage = 100, Status = Status.Updated)]
		public static int EnsureMinimum(this int value, int minValue) => value < minValue ? minValue : value;

		/// <summary>
		/// Byteses to string.
		/// </summary>
		/// <param name="array">The array.</param>
		/// <returns>System.String.</returns>
		internal static string BytesToString(this byte[] array)
		{
			Validate.TryValidateParam(collection: array, nameof(array));

			var sb = new StringBuilder();

			for (var byteCount = 0; byteCount < array.Length; byteCount++)
			{
				_ = sb.Append(array[byteCount].ToString("x2", CultureInfo.InvariantCulture));
			}

			return sb.ToString();
		}

		/// <summary>
		/// Determines whether the specified type is enumerable.
		/// </summary>
		/// <param name="type">The type.</param>
		/// <returns><c>true</c> if the specified type is enumerable; otherwise, <c>false</c>.</returns>
		internal static bool IsEnumerable(Type type) => type.GetInterfaces().Any(t => t == typeof(IEnumerable));

		/// <summary>
		/// Propertieses to dictionary.
		/// </summary>
		/// <param name="obj">The object.</param>
		/// <param name="memberName">Name of the member.</param>
		/// <param name="ignoreNulls">if set to <c>true</c> [ignore nulls].</param>
		/// <returns>IDictionary&lt;System.String, System.String&gt;.</returns>
		internal static IDictionary<string, string> PropertiesToDictionary(object obj, string memberName = ControlChars.EmptyString, bool ignoreNulls = true)
		{
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
			if (InternalMethods.IsEnumerable(objectType))
			{
				var itemCount = 0;

				// Loop through the collection using the enumerator strategy and collect all items in the result bag
				// Note: if the collection is empty it will not return anything about its existence,
				// because the method is supposed to catch value items not the list itself
				foreach (var item in (IEnumerable)obj)
				{
					var itemId = itemCount++;

					var itemInnerMember = string.Format(CultureInfo.CurrentCulture, "{0}[{1}]", memberName, itemId);
					result = result.Concat(PropertiesToDictionary(item, itemInnerMember)).ToDictionary(e => e.Key, e => e.Value);
				}
				return result;
			}

			// Otherwise go deeper in the object tree.
			// And foreach object public property collect each value
			var propertyCollection = objectType.GetProperties();

			var newMemberName = string.Empty;

			if (memberName.Length > 0)
			{
				newMemberName = $"{memberName}{ControlChars.Dot}";
			}

			foreach (var property in propertyCollection)
			{
				var innerObject = property.GetValue(obj, null);

				if (ignoreNulls && innerObject is null)
				{
					continue;
				}

				var innerMember = string.Format(CultureInfo.CurrentCulture, "{0}{1}", newMemberName, property.Name);
				result = result.Concat(PropertiesToDictionary(innerObject, innerMember)).ToDictionary(e => e.Key, e => e.Value);
			}

			return result;
		}

		/// <summary>
		/// Propertieses to string.
		/// </summary>
		/// <param name="obj">The object.</param>
		/// <param name="header">The header.</param>
		/// <param name="keyValueSeparator">The key value separator.</param>
		/// <param name="sequenceSeparator">The sequence separator.</param>
		/// <param name="ignoreNulls">if set to <c>true</c> [ignore nulls].</param>
		/// <param name="includeMemberName">if set to <c>true</c> [include member name].</param>
		/// <returns>System.String.</returns>
		internal static string PropertiesToString(this object obj, string header = ControlChars.EmptyString, char keyValueSeparator = ControlChars.Colon, string sequenceSeparator = ControlChars.DefaultSeparator, bool ignoreNulls = true, bool includeMemberName = true)
		{
			var typeName = obj.GetType().Name;

			if (string.Equals(typeName, typeof(List<>).Name, StringComparison.Ordinal))
			{
				typeName = "Item";
			}
			else if (includeMemberName == false)
			{
				typeName = string.Empty;
			}

			var properties = PropertiesToDictionary(obj, memberName: typeName, ignoreNulls: ignoreNulls);

			var result = properties.Aggregate(header, (acc, pair) => string.Format(CultureInfo.CurrentCulture, "{0}{1}{2}{3}{4}", acc, sequenceSeparator, pair.Key, keyValueSeparator, pair.Value));

			return result.StartsWith(sequenceSeparator, StringComparison.CurrentCulture) ? result.Remove(0, sequenceSeparator.Length) : result;
		}
	}
}
