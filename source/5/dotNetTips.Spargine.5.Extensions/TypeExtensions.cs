﻿// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 08-19-2021
// ***********************************************************************
// <copyright file="TypeExtensions.cs" company="David McCarter - dotNetTips.com">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary>Extension methods for general types.</summary>
// ***********************************************************************
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using dotNetTips.Spargine.Core;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Type Extensions.
	/// </summary>
	public static class TypeExtensions
	{
		/// <summary>
		/// Does the object implement  any of the interfaces.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <param name="interfaceNames">The interface names.</param>
		/// <returns>IEnumerable&lt;System.String&gt;.</returns>
		/// <exception cref="ArgumentNullException">Input cannot be null.</exception>
		[Information(nameof(DoesObjectImplementInterface), UnitTestCoverage = 100, Status = Status.Available)]
		public static IEnumerable<string> DoesObjectImplementInterface([NotNull] this object input, [NotNull] params string[] interfaceNames)
		{
			//TODO: CHANGE TO ALL LINQ? typeof(IMyInterface).IsAssignableFrom(typeof(MyType))
			var interfaces = input.GetType().GetInterfaces().Select(p => p.Name);
			var foundInterfaces = new List<string>();

			foundInterfaces.AddRange(interfaceNames.Where(interfaceName => interfaces.Contains(interfaceName)));

			return foundInterfaces;
		}

		/// <summary>
		/// Gets the abstract methods.
		/// </summary>
		/// <param name="type">The type.</param>
		/// <returns>IEnumerable&lt;MethodInfo&gt;.</returns>
		/// <exception cref="ArgumentNullException">Type cannot be null.</exception>
		[Information(nameof(GetAllAbstractMethods), UnitTestCoverage = 100, Status = Status.Available)]
		public static IEnumerable<MethodInfo> GetAllAbstractMethods([NotNull] this Type type)
		{
			return type.GetRuntimeMethods().Where(m => m.IsAbstract);
		}

		/// <summary>
		/// Gets the declared fields.
		/// </summary>
		/// <param name="type">The type.</param>
		/// <returns>IEnumerable&lt;FieldInfo&gt;.</returns>
		/// <exception cref="ArgumentNullException">Type cannot be null.</exception>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", modifiedOn: "7/30/2020", UnitTestCoverage = 100, Status = Status.Available)]
		public static IEnumerable<FieldInfo> GetAllDeclaredFields([NotNull] this Type type)
		{
			for (var i = 0; i <
							type.GetFields(BindingFlags.Instance |
								BindingFlags.Static |
								BindingFlags.Public |
								BindingFlags.NonPublic |
								BindingFlags.DeclaredOnly)
								.Length; i++)
			{
				yield return type.GetFields(BindingFlags.Instance |
					BindingFlags.Static |
					BindingFlags.Public |
					BindingFlags.NonPublic |
					BindingFlags.DeclaredOnly)[i];
			}
		}

		/// <summary>
		/// Gets declared methods.
		/// </summary>
		/// <param name="type">The type.</param>
		/// <returns>IEnumerable&lt;MethodInfo&gt;.</returns>
		/// <exception cref="ArgumentNullException">Type cannot be null.</exception>
		[Information("Original Code .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", modifiedOn: "7/30/2020", UnitTestCoverage = 100, Status = Status.Available)]
		public static IEnumerable<MethodInfo> GetAllDeclaredMethods([NotNull] this Type type)
		{
			for (var i = 0; i < type.GetMethods(BindingFlags.Instance |
					BindingFlags.Static |
					BindingFlags.Public |
					BindingFlags.NonPublic |
					BindingFlags.DeclaredOnly)
					.Length; i++)
			{
				yield return type.GetMethods(BindingFlags.Instance |
					BindingFlags.Static |
					BindingFlags.Public |
					BindingFlags.NonPublic |
					BindingFlags.DeclaredOnly)[i];
			}
		}

		/// <summary>
		/// Gets all fields.
		/// </summary>
		/// <param name="type">The type.</param>
		/// <returns>IEnumerable&lt;FieldInfo&gt;.</returns>
		/// <exception cref="ArgumentNullException">Type cannot be null.</exception>
		[Information(nameof(GetAllFields), UnitTestCoverage = 100, Status = Status.Available)]
		public static IEnumerable<FieldInfo> GetAllFields([NotNull] this Type type)
		{
			var typeInfo = type.GetTypeInfo();

			while (typeInfo is not null)
			{
				foreach (var fieldInfo in typeInfo.DeclaredFields)
				{
					yield return fieldInfo;
				}

				typeInfo = typeInfo.BaseType?.GetTypeInfo();
			}
		}

		/// <summary>
		/// Gets the generic methods.
		/// </summary>
		/// <param name="type">The type.</param>
		/// <returns>IEnumerable&lt;MethodInfo&gt;.</returns>
		/// <exception cref="ArgumentNullException">Type cannot be null.</exception>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, Status = Status.Available)]
		public static IEnumerable<MethodInfo> GetAllGenericMethods([NotNull] this Type type)
		{
			return type.GetRuntimeMethods().Where(m => m.IsGenericMethod);
		}

		/// <summary>
		/// Gets all methods.
		/// </summary>
		/// <param name="type">The type.</param>
		/// <returns>IEnumerable&lt;MethodInfo&gt;.</returns>
		/// <exception cref="ArgumentNullException">Type cannot be null.</exception>
		[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, Status = Status.Available)]
		public static IEnumerable<MethodInfo> GetAllMethods([NotNull] this Type type)
		{
			var typeInfo = type.GetTypeInfo();

			while (typeInfo is not null)
			{
				foreach (var methodInfo in typeInfo.DeclaredMethods)
				{
					yield return methodInfo;
				}

				typeInfo = typeInfo.BaseType?.GetTypeInfo();
			}
		}

		/// <summary>
		/// Gets all properties.
		/// </summary>
		/// <param name="type">The type.</param>
		/// <returns>IEnumerable&lt;PropertyInfo&gt;.</returns>
		/// <exception cref="ArgumentNullException">Type cannot be null.</exception>
		[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, Status = Status.Available)]
		public static IEnumerable<PropertyInfo> GetAllProperties([NotNull] this Type type)
		{
			var typeInfo = type.GetTypeInfo();

			while (typeInfo is not null)
			{
				foreach (var propertyInfo in typeInfo.DeclaredProperties)
				{
					yield return propertyInfo;
				}

				typeInfo = typeInfo.BaseType?.GetTypeInfo();
			}
		}

		/// <summary>
		/// Gets the public methods.
		/// </summary>
		/// <param name="type">The type.</param>
		/// <returns>IEnumerable&lt;MethodInfo&gt;.</returns>
		/// <exception cref="ArgumentNullException">Type cannot be null.</exception>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, Status = Status.Available)]
		public static IEnumerable<MethodInfo> GetAllPublicMethods([NotNull] this Type type)
		{
			return type.GetRuntimeMethods().Where(m => m.IsPublic);
		}

		/// <summary>
		/// Gets the static methods.
		/// </summary>
		/// <param name="type">The type.</param>
		/// <returns>IEnumerable&lt;MethodInfo&gt;.</returns>
		/// <exception cref="ArgumentNullException">Type cannot be null.</exception>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, Status = Status.Available)]
		public static IEnumerable<MethodInfo> GetAllStaticMethods([NotNull] this Type type)
		{
			return type.GetRuntimeMethods().Where(m => m.IsStatic);
		}

		/// <summary>
		/// Resolves the attribute.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="type">The type.</param>
		/// <returns>T.</returns>
		/// <exception cref="ArgumentNullException">Type cannot be null.</exception>
		[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, Status = Status.Available)]
		public static T GetAttribute<T>([NotNull] this Type type)
			where T : Attribute
		{
			return type.GetTypeInfo().GetCustomAttributes(typeof(T), false).OfType<T>().FirstOrDefault();
		}

		/// <summary>
		/// Resolves the attribute.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="methodInfo">The method information.</param>
		/// <returns>T.</returns>
		/// <exception cref="ArgumentNullException">MethodInfo cannot be null.</exception>
		[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, Status = Status.Available)]
		public static T GetAttribute<T>([NotNull] this MethodInfo methodInfo)
			where T : Attribute
		{
			return methodInfo.GetCustomAttributes(typeof(T), false).FirstOrDefault() as T;
		}

		/// <summary>
		/// Resolves the attribute.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="propertyInfo">The property information.</param>
		/// <returns>T.</returns>
		/// <exception cref="ArgumentNullException">PropertyInfo cannot be null.</exception>
		[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, Status = Status.Available)]
		public static T GetAttribute<T>([NotNull] this PropertyInfo propertyInfo)
			where T : Attribute
		{
			return propertyInfo.GetCustomAttributes(typeof(T), false).FirstOrDefault() as T;
		}

		/// <summary>
		/// Resolves the attribute.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="fieldInfo">The field information.</param>
		/// <returns>T.</returns>
		/// <exception cref="ArgumentNullException">FieldInfo cannot be null.</exception>
		[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, Status = Status.Available)]
		public static T GetAttribute<T>([NotNull] this FieldInfo fieldInfo)
			where T : Attribute
		{
			return fieldInfo?.GetCustomAttributes(typeof(T), false).FirstOrDefault() as T;
		}

		/// <summary>
		/// Gets the type members with given attribute.
		/// </summary>
		/// <typeparam name="TAttribute">The type of the t attribute.</typeparam>
		/// <param name="type">The type.</param>
		/// <returns>System.ValueTuple&lt;System.String, TAttribute, System.Boolean, System.Boolean, Type&gt;[].</returns>
		/// <exception cref="InvalidOperationException">Member \"{member.Name}\" must be public if it has the [{typeof(TAttribute).Name}] attribute applied to it</exception>
		/// <exception cref="ArgumentNullException">Type cannot be null.</exception>
		[Information("https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, Status = Status.Available)]
		public static (string Name, TAttribute Attribute, bool IsPrivate, bool IsStatic, Type ParameterType)[] GetTypeMembersWithAttribute<TAttribute>([NotNull] this Type type)
			where TAttribute : Attribute
		{
			var allFields = type.GetFields()
							.Select(f => (f.Name,
											Attribute: f.GetAttribute<TAttribute>(), f.IsPrivate, f.IsStatic,
											ParameterType: f.FieldType));

			var allProperties = type.GetProperties()
				.Select(p => (p.Name,
								Attribute: p.GetAttribute<TAttribute>(),
								IsPrivate: p.GetSetMethod() is null,
								IsStatic: p.GetSetMethod() is not null && p.GetSetMethod().IsStatic, p.PropertyType));

			var joined = allFields.Concat(allProperties).Where(member => member.Attribute is not null).ToArray();

			foreach (var member in joined.Where(m => m.IsPrivate))
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException("Member", $"Member \"{member.Name}\" must be public if it has the [{typeof(TAttribute).Name}] attribute applied to it");
			}

			return joined;
		}

		/// <summary>
		/// Determines whether the specified method information has attribute.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="methodInfo">The method information.</param>
		/// <returns><c>true</c> if the specified method information has attribute; otherwise, <c>false</c>.</returns>
		/// <exception cref="ArgumentNullException">MethodInfo cannot be null.</exception>
		[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, Status = Status.Available)]
		public static bool HasAttribute<T>([NotNull] this MethodInfo methodInfo) where T : Attribute
		{
			return methodInfo.GetAttribute<T>() is not null;
		}


		/// <summary>
		/// Determines whether the type inherits the base class].
		/// </summary>
		/// <param name="type">The type.</param>
		/// <param name="baseClass">The base class.</param>
		/// <returns><c>true</c> if [has base class of] [the specified base class]; otherwise, <c>false</c>.</returns>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", modifiedOn: "7/30/2020", UnitTestCoverage = 100, Status = Status.Available)]
		public static bool HasBaseClass(this Type type, Type baseClass)
		{
			if (type == baseClass)
			{
				return false;
			}

			while (type is not null)
			{
				if (type == baseClass)
				{
					return true;
				}

				type = type.BaseType;
			}

			return false;
		}

		/// <summary>
		/// Determines whether [has parameterless constructor] [the specified type].
		/// </summary>
		/// <param name="type">The type.</param>
		/// <returns><c>true</c> if [has parameterless constructor] [the specified type]; otherwise, <c>false</c>.</returns>
		/// <exception cref="ArgumentNullException">Type cannot be null.</exception>
		[Information(nameof(HasParameterlessConstructor), UnitTestCoverage = 100, Status = Status.Available)]
		public static bool HasParameterlessConstructor([NotNull] this Type type)
		{
			return type.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Type.EmptyTypes, null) is not null;
		}

		/// <summary>
		/// Determines whether the specified type implements <see cref="IEnumerable" />.
		/// </summary>
		/// <param name="type">The type.</param>
		/// <returns><c>true</c> if the specified type is <see cref="IEnumerable" />; otherwise, <c>false</c>.</returns>
		[Information(nameof(HasParameterlessConstructor), UnitTestCoverage = 100, Status = Status.Available, Documentation = "http://bit.ly/SpargineMarch2021")]
		public static bool IsEnumerable([NotNull] this Type type)
		{
			return type.GetInterfaces().Any(t => t == typeof(IEnumerable));
		}

		/// <summary>
		/// Determines whether the specified type is nullable.
		/// </summary>
		/// <param name="type">The type.</param>
		/// <returns><c>true</c> if the specified type is nullable; otherwise, <c>false</c>.</returns>
		[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, Status = Status.Available)]
		public static bool IsNullable(this Type type) => Nullable.GetUnderlyingType(type) is not null;

		/// <summary>
		/// Determines whether the specified property is static.
		/// </summary>
		/// <param name="property">The property.</param>
		/// <returns><c>true</c> if the specified property is static; otherwise, <c>false</c>.</returns>
		/// <exception cref="ArgumentNullException">PropertyInfo cannot be null.</exception>
		[Information("From .NET EF Core source.", author: "David McCarter", createdOn: "7/31/2020", modifiedOn: "7/31/2020", UnitTestCoverage = 100, Status = Status.Available)]
		public static bool IsStatic([NotNull] this PropertyInfo property)
		{
			return ( property.GetMethod ?? property.SetMethod ).IsStatic;
		}

		/// <summary>
		/// Return maximum type. Works with value and reference types.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="obj1">The obj1.</param>
		/// <param name="obj2">The obj2.</param>
		/// <returns>T.</returns>
		/// <exception cref="ArgumentNullException">Object 2 cannot be null.</exception>
		/// <remarks>Original code by: Jeremy Clark</remarks>
		[Information(nameof(Max), UnitTestCoverage = 100, Status = Status.Available)]
		public static T Max<T>(this T obj1, T obj2)
			where T : IComparable => obj1.CompareTo(obj2) >= 0 ? obj1 : obj2;
	}
}
