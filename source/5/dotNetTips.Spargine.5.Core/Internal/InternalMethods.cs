using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace dotNetTips.Spargine.Core.Internal
{
	internal static class InternalMethods
	{
		private const string NullString = "[null]";

		internal static bool IsEnumerable(Type type)
		{
			return type.GetInterfaces().Any(t => t == typeof(IEnumerable));
		}

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

		internal static string PropertiesToString(this object obj, string header = ControlChars.EmptyString, char keyValueSeparator = ControlChars.Colon, string sequenceSeparator = ControlChars.DefaultSeparator, bool ignoreNulls = true, bool includeMemberName = true)
		{
			var typeName = obj.GetType().Name;

			if (string.Compare(typeName, typeof(List<>).Name, StringComparison.Ordinal) == 0)
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
