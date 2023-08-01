// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Core
// Author           : David McCarter
// Created          : 02-21-2021
//
// Last Modified By : David McCarter
// Last Modified On : 08-01-2023
// ***********************************************************************
// <copyright file="JsonSerialization.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// This class facilitates easy serialization and deserialization of
// strings to and from JSON format using the JsonSerializer. JSON
// serialization is a common and efficient way to store and exchange
// data in various applications and APIs.
// </summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.Serialization;

/// <summary>
/// Class JsonSerializer.
/// </summary>
public static class JsonSerialization
{
	/// <summary>
	/// Jsons the equal.
	/// </summary>
	/// <param name="expected">The expected.</param>
	/// <param name="actual">The actual.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	/// <exception cref="System.NotSupportedException">Undefined JsonValueKind: {valueKind}.</exception>
	/// <exception cref="System.NotSupportedException">Unexpected JsonValueKind: {valueKind}.</exception>
	private static bool JsonEqual([NotNull] JsonElement expected, [NotNull] JsonElement actual)
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

				using (var expectedEnumerator = expected.EnumerateObject())
				{
					foreach (var property in expectedEnumerator)
					{
						_ = propertyNames.Add(property.Name);
					}
				}

				using (var actualEnumerator = actual.EnumerateObject())
				{
					foreach (var property in actualEnumerator)
					{
						_ = propertyNames.Add(property.Name);
					}
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
					using (var actualEnumerator = expected.EnumerateArray())
					{
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
				}

			case JsonValueKind.String:
				return string.Equals(expected.GetString(), actual.GetString(), StringComparison.Ordinal);
			case JsonValueKind.Number:
			case JsonValueKind.True:
			case JsonValueKind.False:
			case JsonValueKind.Null:
				return string.Equals(expected.GetRawText(), actual.GetRawText(), StringComparison.Ordinal);
			case JsonValueKind.Undefined:
				throw new NotSupportedException($"Undefined JsonValueKind: {valueKind}.");
			default:
				throw new NotSupportedException($"Unexpected JsonValueKind: {valueKind}.");
		}
	}

	/// <summary>
	/// Deserializes the specified Json.
	/// </summary>
	/// <typeparam name="TResult">The type of the t result.</typeparam>
	/// <param name="json">The json.</param>
	/// <returns>T.</returns>
	[Information(nameof(Deserialize), author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public static TResult Deserialize<TResult>([NotNull] string json)
	{
		var options = new JsonSerializerOptions()
		{
			NumberHandling = JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString
		};

		var obj = JsonSerializer.Deserialize<TResult>(json.ArgumentNotNullOrEmpty(true), options);

		return obj;
	}

	/// <summary>
	/// Deserialize JSON from a file.
	/// </summary>
	/// <typeparam name="TResult">The type of the t result.</typeparam>
	/// <param name="fileName">Name of the file.</param>
	/// <returns>TResult.</returns>
	/// <exception cref="FileNotFoundException">File not found. Cannot deserialize from JSON.</exception>
	[Information(nameof(DeserializeFromFile), BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
	public static TResult DeserializeFromFile<TResult>([NotNull] string fileName) where TResult : class
	{
		if (File.Exists(fileName) is false)
		{
			ExceptionThrower.ThrowFileNotFoundException("File not found. Cannot deserialize from JSON.", fileName);
		}

		return Deserialize<TResult>(File.ReadAllText(fileName));
	}

	/// <summary>
	/// Jsons the equal.
	/// </summary>
	/// <param name="actual">The actual.</param>
	/// <param name="expected">The expected.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public static bool JsonEqual([NotNull] string actual, [NotNull] string expected)
	{
		actual = actual.ArgumentNotNullOrEmpty();
		expected = expected.ArgumentNotNullOrEmpty();

		using (var expectedDom = JsonDocument.Parse(expected))
		{
			using (var actualDom = JsonDocument.Parse(actual))
			{
				return JsonEqual(expectedDom.RootElement, actualDom.RootElement);
			}
		}
	}

	/// <summary>
	/// Serializes the specified object.
	/// </summary>
	/// <param name="obj">The object.</param>
	/// <returns>System.String.</returns>
	[Information(nameof(Serialize), author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public static string Serialize([NotNull] object obj)
	{
		return JsonSerializer.Serialize(obj.ArgumentNotNull());
	}

	/// <summary>
	/// Serializes to and object to a JSON file.
	/// </summary>
	/// <param name="obj">The object.</param>
	/// <param name="fileName">Name of the file.</param>
	[Information(nameof(SerializeToFile), BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
	public static void SerializeToFile([NotNull] object obj, [NotNull] string fileName)
	{
		obj = obj.ArgumentNotNull();
		fileName = fileName.ArgumentNotNullOrEmpty(true);

		if (File.Exists(fileName))
		{
			File.Delete(fileName);
		}

		var directoryName = Path.GetDirectoryName(fileName);

		if (Directory.Exists(directoryName) is false)
		{
			_ = Directory.CreateDirectory(directoryName);
		}

		File.WriteAllText(fileName, Serialize(obj));
	}
}
