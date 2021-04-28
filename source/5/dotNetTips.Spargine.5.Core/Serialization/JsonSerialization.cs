// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Core
// Author           : David McCarter
// Created          : 02-21-2021
//
// Last Modified By : David McCarter
// Last Modified On : 04-21-2021
// ***********************************************************************
// <copyright file="JsonSerialization.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Core.Serialization
{
	/// <summary>
	/// Class JsonSerializer.
	/// </summary>
	public static class JsonSerialization
	{
		/// <summary>
		/// Deserializes the specified Json.
		/// </summary>
		/// <typeparam name="TResult">The type of the t result.</typeparam>
		/// <param name="json">The json.</param>
		/// <returns>T.</returns>
		[Information(nameof(Deserialize), author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static TResult Deserialize<TResult>(string json)
		{
			Validate.TryValidateParam(json, nameof(json));

			var obj = JsonSerializer.Deserialize<TResult>(json);

			return obj;
		}

		/// <summary>
		/// Deserializes JSON from a file.
		/// </summary>
		/// <typeparam name="TResult">The type of the t result.</typeparam>
		/// <param name="fileName">Name of the file.</param>
		/// <returns>TResult.</returns>
		/// <exception cref="FileNotFoundException">File not found. Cannot deserialize from XML.</exception>
		/// <exception cref="System.IO.FileNotFoundException">File not found. Cannot deserialize from XML.</exception>
		[Information(nameof(DeserializeFromFile), BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static TResult DeserializeFromFile<TResult>(string fileName) where TResult : class
		{
			Validate.TryValidateParam(fileName, nameof(fileName));

			if (File.Exists(fileName) == false)
			{
				throw new FileNotFoundException("File not found. Cannot deserialize from XML.", fileName);
			}

			return Deserialize<TResult>(File.ReadAllText(fileName));
		}

		/// <summary>
		/// Jsons the equal.
		/// </summary>
		/// <param name="actual">The actual.</param>
		/// <param name="expected">The expected.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static bool JsonEqual(string actual, string expected)
		{
			using var expectedDom = JsonDocument.Parse(expected);
			using var actualDom = JsonDocument.Parse(actual);

			return JsonEqual(expectedDom.RootElement, actualDom.RootElement);
		}

		/// <summary>
		/// Serializes the specified object.
		/// </summary>
		/// <param name="obj">The object.</param>
		/// <returns>System.String.</returns>
		[Information(nameof(Serialize), author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static string Serialize(object obj)
		{
			Validate.TryValidateNullParam(obj, nameof(obj));

			var json = JsonSerializer.Serialize(obj);

			return json;
		}

		/// <summary>
		/// Serializes to and object to a JSON file.
		/// </summary>
		/// <param name="obj">The object.</param>
		/// <param name="fileName">Name of the file.</param>
		[Information(nameof(SerializeToFile), BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static void SerializeToFile(object obj, string fileName)
		{
			Validate.TryValidateNullParam(obj, nameof(obj));
			Validate.TryValidateParam(fileName, nameof(fileName));

			if (File.Exists(fileName))
			{
				File.Delete(fileName);
			}

			File.WriteAllText(fileName, Serialize(obj));
		}

		/// <summary>
		/// Jsons the equal.
		/// </summary>
		/// <param name="expected">The expected.</param>
		/// <param name="actual">The actual.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		/// <exception cref="NotSupportedException">Unexpected JsonValueKind: JsonValueKind.{valueKind}.</exception>
		/// <exception cref="System.NotSupportedException">Unexpected JsonValueKind: JsonValueKind.{valueKind}.</exception>
		private static bool JsonEqual(JsonElement expected, JsonElement actual)
		{
			var valueKind = expected.ValueKind;

			if (valueKind != actual.ValueKind)
			{
				return false;
			}

			switch (valueKind)
			{
				case JsonValueKind.Object:
					var propertyNames = new HashSet<string>();

					foreach (var property in expected.EnumerateObject())
					{
						propertyNames.Add(property.Name);
					}

					foreach (var property in actual.EnumerateObject())
					{
						propertyNames.Add(property.Name);
					}

					foreach (var name in propertyNames)
					{
						if (!JsonEqual(expected.GetProperty(name), actual.GetProperty(name)))
						{
							return false;
						}
					}

					return true;
				case JsonValueKind.Array:
					using (var expectedEnumerator = actual.EnumerateArray())
					{
						using var actualEnumerator = expected.EnumerateArray();

						while (expectedEnumerator.MoveNext())
						{
							if (!actualEnumerator.MoveNext())
							{
								return false;
							}

							if (!JsonEqual(expectedEnumerator.Current, actualEnumerator.Current))
							{
								return false;
							}
						}

						return !actualEnumerator.MoveNext();
					}

				case JsonValueKind.String:
					return expected.GetString() == actual.GetString();
				case JsonValueKind.Number:
				case JsonValueKind.True:
				case JsonValueKind.False:
				case JsonValueKind.Null:
					return expected.GetRawText() == actual.GetRawText();
				default:
					throw new NotSupportedException($"Unexpected JsonValueKind: JsonValueKind.{valueKind}.");
			}
		}
	}
}
