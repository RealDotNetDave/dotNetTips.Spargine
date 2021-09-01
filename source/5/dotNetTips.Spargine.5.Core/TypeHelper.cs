// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Core
// Author           : David McCarter
// Created          : 11-11-2020
//
// Last Modified By : David McCarter
// Last Modified On : 08-23-2021
// ***********************************************************************
// <copyright file="TypeHelper.cs" company="dotNetTips.Spargine.5.Core">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Core
{
	/// <summary>
	/// Class TypeHelper.
	/// </summary>
	public static class TypeHelper
	{
		/// <summary>
		/// Gets the built in type names.
		/// </summary>
		/// <value>The built in type names.</value>
		public static Dictionary<Type, string> BuiltInTypeNames { get; } = new()
		{
			{ typeof(DateTime), "datetime" },
			{ typeof(DateTimeOffset), "datetimeoffset" },
			{ typeof(TimeSpan), "timespan" },
			{ typeof(bool), "bool" },
			{ typeof(byte), "byte" },
			{ typeof(char), "char" },
			{ typeof(decimal), "decimal" },
			{ typeof(double), "double" },
			{ typeof(float), "float" },
			{ typeof(int), "int" },
			{ typeof(long), "long" },
			{ typeof(object), "object" },
			{ typeof(sbyte), "sbyte" },
			{ typeof(short), "short" },
			{ typeof(string), "string" },
			{ typeof(uint), "uint" },
			{ typeof(ulong), "ulong" },
			{ typeof(ushort), "ushort" },
			{ typeof(void), "void" },
		};

		/// <summary>
		/// Creates type instance.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <returns>T.</returns>
		/// <remarks>Original code by: Jeremy Clark</remarks>
		[Information(UnitTestCoverage = 100, Status = Status.Available)]
		public static T Create<T>()
			where T : class
		{
			var instance = Activator.CreateInstance<T>();

			return instance is T ? instance : null;
		}

		/// <summary>
		/// Creates the specified parameter array.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="paramArray">The parameter array.</param>
		/// <returns>T.</returns>
		[Information(UnitTestCoverage = 100, Status = Status.Available)]
		public static T Create<T>([NotNull] params object[] paramArray)
		{
			var instance = (T)Activator.CreateInstance(typeof(T), args: paramArray);

			return instance;
		}

		/// <summary>
		/// Does the object equal instance.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="instance">The instance.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		[Information(UnitTestCoverage = 100, Status = Status.Available)]
		public static bool DoesObjectEqualInstance([NotNull] object value, [NotNull] object instance)
		{
			var result = object.ReferenceEquals(value, instance);

			return result;
		}

		/// <summary>
		/// Finds the derived types in the app folder.
		/// </summary>
		/// <param name="baseType">Type of the base.</param>
		/// <param name="classOnly">The class only.</param>
		/// <returns>IEnumerable&lt;Type&gt;.</returns>
		[Information(UnitTestCoverage = 100, Status = Status.Available)]
		public static IEnumerable<Type> FindDerivedTypes([NotNull] Type baseType, Tristate classOnly)
		{
			var path = Path.GetDirectoryName(AppContext.BaseDirectory);

			return FindDerivedTypes(path, SearchOption.AllDirectories, baseType, classOnly);
		}


		/// <summary>
		/// Finds the derived types.
		/// </summary>
		/// <param name="currentDomain">The current domain.</param>
		/// <param name="baseType">Type of the base.</param>
		/// <param name="classOnly">if set to <c>true</c> [class only].</param>
		/// <returns>IEnumerable&lt;Type&gt;.</returns>
		[Information(UnitTestCoverage = 100, Status = Status.Available)]
		public static IEnumerable<Type> FindDerivedTypes([NotNull] AppDomain currentDomain, [NotNull] Type baseType, Tristate classOnly)
		{
			List<Type> types = null;

			var array = currentDomain.GetAssemblies();

			for (var assemblyCount = 0; assemblyCount < array.Length; assemblyCount++)
			{
				try
				{
					var assembly = array[assemblyCount];
					var tempTypes = LoadDerivedTypes(assembly.DefinedTypes, baseType, classOnly).ToList();

					if (tempTypes?.Count() > 0)
					{
						if (types is null)
						{
							types = tempTypes;
						}
						else
						{
							types.AddRange(tempTypes);
						}
					}
				}
				catch (ReflectionTypeLoadException reflectionEx)
				{
					Trace.WriteLine(reflectionEx.GetAllMessages());
				}
			}

			return types;
		}

		/// <summary>
		/// Finds the derived types using the path.
		/// </summary>
		/// <param name="path">The path.</param>
		/// <param name="fileSearchType">The search option.</param>
		/// <param name="baseType">Type of the base.</param>
		/// <param name="classOnly">if set to <c>true</c> [class only].</param>
		/// <returns>IEnumerable&lt;Type&gt;.</returns>
		/// <exception cref="DirectoryNotFoundException">Could not find path.</exception>
		/// <exception cref="ArgumentNullException">Could not find path.</exception>
		[Information(UnitTestCoverage = 100, Status = Status.Available)]
		public static IEnumerable<Type> FindDerivedTypes([NotNull] string path, SearchOption fileSearchType, [NotNull] Type baseType, Tristate classOnly)
		{
			if (Directory.Exists(path) == false)
			{
				ExceptionThrower.ThrowDirectoryNotFoundException("Could not find path.", path);
			}

			var files = Directory.EnumerateFiles(path, "*.dll", fileSearchType).ToList();

			var list = files.ToList();
			var foundTypes = new List<Type>();

			for (var fileCount = 0; fileCount < list.Count; fileCount++)
			{
				try
				{
					var assembly = Assembly.LoadFile(list[fileCount]);
					var exportedTypes = assembly.ExportedTypes.ToList().Where(p => p.BaseType is not null).ToList();

					if (exportedTypes?.Count() > 0)
					{
						var containsBaseType = exportedTypes.Any(p => string.Compare(p.BaseType.FullName, baseType.FullName, StringComparison.Ordinal) == 0);

						if (containsBaseType)
						{
							foundTypes.AddRange(LoadDerivedTypes(assembly.DefinedTypes, baseType, classOnly));
						}
					}
				}
				catch (BadImageFormatException ex)
				{
					Trace.WriteLine(ex.Message);
				}
			}

			return foundTypes;
		}

		/// <summary>
		/// Creates object from Json.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="json">The json.</param>
		/// <returns>T.</returns>
		[Information(nameof(FromJson), UnitTestCoverage = 100, Status = Status.Available)]
		public static T FromJson<T>([NotNull] string json)
			where T : class
		{
			return JsonSerializer.Deserialize<T>(json);
		}

		/// <summary>
		/// Creates object from a Json file.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="fileName">Name of the file.</param>
		/// <returns>T.</returns>
		/// <exception cref="FileNotFoundException">The exception.</exception>
		/// <exception cref="FileNotFoundException">The exception.</exception>
		[Information(nameof(FromJsonFile), UnitTestCoverage = 99, Status = Status.Available)]
		public static T FromJsonFile<T>([NotNull] string fileName)
			where T : class
		{
			if (File.Exists(fileName) == false)
			{
				ExceptionThrower.ThrowFileNotFoundException("File not found.", fileName);
			}

			var json = File.ReadAllText(fileName, Encoding.UTF8);

			return JsonSerializer.Deserialize<T>(json);
		}

		/// <summary>
		/// Gets the default type.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <returns>T.</returns>
		[Information(UnitTestCoverage = 100, Status = Status.Available)]
		public static T GetDefault<T>()
		{
			var result = default(T);

			return result;
		}

		/// <summary>
		/// Gets the instance hash code.
		/// </summary>
		/// <param name="instance">The instance.</param>
		/// <returns>Int32.</returns>
		[Information(UnitTestCoverage = 100, Status = Status.Available)]
		public static int GetInstanceHashCode([NotNull] object instance)
		{
			var hash = instance.GetType().GetRuntimeProperties().Where(p => p is not null).Select(prop => prop.GetValue(instance)).Where(value => value is not null).Aggregate(-1, (accumulator, value) => accumulator ^ value.GetHashCode());

			return hash;
		}



		/// <summary>
		/// Gets the property values from a type.
		/// </summary>
		/// <typeparam name="T">Generic type.</typeparam>
		/// <param name="input">The input.</param>
		/// <returns>ImmutableDictionary&lt;System.String, System.String&gt;.</returns>
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
		[Information(nameof(GetPropertyValues), author: "David McCarter", createdOn: "11/03/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "http://bit.ly/SpargineMarch2021")]
		public static ImmutableDictionary<string, string> GetPropertyValues<T>([NotNull] T input)
		{
			var returnValue = new Dictionary<string, string>();

			var properties = input.GetType().GetAllProperties().Where(p => p.CanRead).OrderBy(p => p.Name).ToArray();

			for (var i = 0; i < properties.Length; i++)
			{
				var propertyInfo = properties[i];

				if (string.Compare(propertyInfo.PropertyType.Name, "IDictionary", StringComparison.Ordinal) == 0)
				{
					var propertyValue = propertyInfo.GetValue(input) as IDictionary;

					if (propertyValue?.Count > 0)
					{
						_ = returnValue.AddIfNotExists(new KeyValuePair<string, string>(propertyInfo.Name, propertyValue.ToDelimitedString()));
					}
				}
				else
				{
					// Get property value
					var propertyValue = propertyInfo.GetValue(input);

					if (propertyValue is not null)
					{
						_ = returnValue.AddIfNotExists(new KeyValuePair<string, string>(propertyInfo.Name, propertyValue.ToString()));
					}
				}
			}

			return returnValue.ToImmutableDictionary();
		}

		/// <summary>
		/// Gets the display name of the type.
		/// </summary>
		/// <param name="item">The item.</param>
		/// <param name="fullName">if set to <c>true</c> [full name].</param>
		/// <returns>System.String.</returns>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/31/2020", modifiedOn: "7/31/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static string GetTypeDisplayName([NotNull] object item, bool fullName = true)
		{
			return item is null ? null : GetTypeDisplayName(item.GetType(), fullName);
		}

		/// <summary>
		/// Pretty print a type name.
		/// </summary>
		/// <param name="type">The <see cref="Type" />.</param>
		/// <param name="fullName"><c>true</c> to print a fully qualified name.</param>
		/// <param name="includeGenericParameterNames"><c>true</c> to include generic parameter names.</param>
		/// <param name="includeGenericParameters"><c>true</c> to include generic parameters.</param>
		/// <param name="nestedTypeDelimiter">Character to use as a delimiter in nested type names</param>
		/// <returns>The pretty printed type name.</returns>
		/// <exception cref="ArgumentNullException">type</exception>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/31/2020", modifiedOn: "7/31/2020", UnitTestCoverage = 100, Status = Status.Available)]
		public static string GetTypeDisplayName([NotNull] Type type, bool fullName = true, bool includeGenericParameterNames = false, bool includeGenericParameters = true, char nestedTypeDelimiter = ControlChars.Plus)
		{
			var sb = new StringBuilder();

			ProcessType(sb, type, new DisplayNameOptions(fullName, includeGenericParameterNames, includeGenericParameters, nestedTypeDelimiter));

			return sb.ToString();
		}

		/// <summary>
		/// Processes the type.
		/// </summary>
		/// <param name="builder">The builder.</param>
		/// <param name="type">The type.</param>
		/// <param name="options">The options.</param>
		[Information(UnitTestCoverage = 99, Status = Status.Available)]
		internal static void ProcessType([NotNull] StringBuilder builder, [NotNull] Type type, in DisplayNameOptions options)
		{
			if (type.IsGenericType)
			{
				var genericArguments = type.GetGenericArguments();
				ProcessGenericType(builder, type, genericArguments, genericArguments.Length, options);
			}
			else if (type.IsArray)
			{
				ProcessType(builder, type, options);
			}
			else if (BuiltInTypeNames.TryGetValue(type, out var builtInName))
			{
				_ = builder.Append(builtInName);
			}
			else if (type.IsGenericParameter)
			{
				if (options.IncludeGenericParameterNames)
				{
					_ = builder.Append(type.Name);
				}
			}
			else
			{
				var name = options.FullName ? type.FullName : type.Name;
				_ = builder.Append(name);

				if (options.NestedTypeDelimiter != ControlChars.Plus)
				{
					_ = builder.Replace(ControlChars.Plus, options.NestedTypeDelimiter, builder.Length - name.Length, name.Length);
				}
			}
		}

		/// <summary>
		/// Loads the derived types of a type.
		/// </summary>
		/// <param name="types">The types.</param>
		/// <param name="baseType">Type of the base.</param>
		/// <param name="classOnly">if set to <c>true</c> [class only].</param>
		/// <returns>IEnumerable&lt;Type&gt;.</returns>
		[Information(UnitTestCoverage = 99, Status = Status.Available)]
		private static IEnumerable<Type> LoadDerivedTypes([NotNull] IEnumerable<TypeInfo> types, [NotNull] Type baseType, Tristate classOnly)
		{
			// works out the derived types
			var list = types.ToList();

			for (var i = 0; i < list.Count; i++)
			{
				var type = list[i];

				// if classOnly, it must be a class
				// useful when you want to create instance
				if (( classOnly == Tristate.True || classOnly == Tristate.UseDefault ) && !type.IsClass)
				{
					continue;
				}

				if (baseType.IsInterface)
				{
					if (type.GetInterface(baseType.FullName) is not null)
					{
						// add it to result list
						yield return type;
					}
				}
				else if (type.IsSubclassOf(baseType))
				{
					// add it to result list
					yield return type;
				}
			}
		}

		/// <summary>
		/// Processes the type of the generic.
		/// </summary>
		/// <param name="builder">The builder.</param>
		/// <param name="type">The type.</param>
		/// <param name="genericArguments">The generic arguments.</param>
		/// <param name="length">The length.</param>
		/// <param name="options">The options.</param>
		[Information(UnitTestCoverage = 99, Status = Status.Available)]
		private static void ProcessGenericType([NotNull] StringBuilder builder, [NotNull] Type type, Type[] genericArguments, int length, in DisplayNameOptions options)
		{
			var offset = 0;

			if (type.IsNested)
			{
				offset = type.DeclaringType.GetGenericArguments().Length;
			}

			if (options.FullName)
			{
				if (type.IsNested)
				{
					ProcessGenericType(builder, type.DeclaringType, genericArguments, offset, options);
					_ = builder.Append(options.NestedTypeDelimiter);
				}
				else if (!string.IsNullOrEmpty(type.Namespace))
				{
					_ = builder.Append(type.Namespace);
					_ = builder.Append(ControlChars.Dot);
				}
			}

			var genericPartIndex = type.Name.IndexOf('`', StringComparison.Ordinal);
			if (genericPartIndex <= 0)
			{
				_ = builder.Append(type.Name);
				return;
			}

			_ = builder.Append(type.Name, 0, genericPartIndex);

			if (options.IncludeGenericParameters)
			{
				_ = builder.Append(ControlChars.StartAngleBracket);

				for (var i = offset; i < length; i++)
				{
					ProcessType(builder, genericArguments[i], options);

					if (i + 1 == length)
					{
						continue;
					}

					_ = builder.Append(ControlChars.Comma);
					if (options.IncludeGenericParameterNames || !genericArguments[i + 1].IsGenericParameter)
					{
						_ = builder.Append(ControlChars.Space);
					}
				}

				_ = builder.Append(ControlChars.EndAngleBracket);
			}
		}

		/// <summary>
		/// Struct DisplayNameOptions.
		/// </summary>
		internal struct DisplayNameOptions
		{
			/// <summary>
			/// Initializes a new instance of the <see cref="DisplayNameOptions" /> struct.
			/// </summary>
			/// <param name="fullName">if set to <c>true</c> [full name].</param>
			/// <param name="includeGenericParameterNames">if set to <c>true</c> [include generic parameter names].</param>
			/// <param name="includeGenericParameters">if set to <c>true</c> [include generic parameters].</param>
			/// <param name="nestedTypeDelimiter">The nested type delimiter.</param>
			public DisplayNameOptions(bool fullName, bool includeGenericParameterNames, bool includeGenericParameters, char nestedTypeDelimiter)
			{
				this.FullName = fullName;
				this.IncludeGenericParameters = includeGenericParameters;
				this.IncludeGenericParameterNames = includeGenericParameterNames;
				this.NestedTypeDelimiter = nestedTypeDelimiter;
			}

			/// <summary>
			/// Gets a value indicating whether [full name].
			/// </summary>
			/// <value><c>true</c> if [full name]; otherwise, <c>false</c>.</value>
			public bool FullName { get; }

			/// <summary>
			/// Gets a value indicating whether [include generic parameter names].
			/// </summary>
			/// <value><c>true</c> if [include generic parameter names]; otherwise, <c>false</c>.</value>
			public bool IncludeGenericParameterNames { get; }

			/// <summary>
			/// Gets a value indicating whether [include generic parameters].
			/// </summary>
			/// <value><c>true</c> if [include generic parameters]; otherwise, <c>false</c>.</value>
			public bool IncludeGenericParameters { get; }

			/// <summary>
			/// Gets the nested type delimiter.
			/// </summary>
			/// <value>The nested type delimiter.</value>
			public char NestedTypeDelimiter { get; }

		}

	}
}
