// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions **
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 12-21-2020
// ***********************************************************************
// <copyright file="TypeExtensions.cs" company="David McCarter - dotNetTips.com">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary>Extension methods for general types.</summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Core.OOP;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
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
		[Information(nameof(DoesObjectImplementInterface), UnitTestCoverage = 0, Status = Status.Available)]
		public static IEnumerable<string> DoesObjectImplementInterface(object input, params string[] interfaceNames)
		{
			Encapsulation.TryValidateNullParam(input, nameof(input));

			//TODO: CHANGE TO ALL LINQ? typeof(IMyInterface).IsAssignableFrom(typeof(MyType))
			var interfaces = input.GetType().GetInterfaces().Select(p => p.Name);

			var foundInterfaces = new List<string>();
			foundInterfaces.AddRange(foundInterfaces.Where(interfaceName => interfaces.Contains(interfaceName)));
			return interfaceNames;
		}

		/// <summary>
		/// Gets the abstract methods.
		/// </summary>
		/// <param name="type">The type.</param>
		/// <returns>IEnumerable&lt;MethodInfo&gt;.</returns>
		/// <exception cref="ArgumentNullException">Type cannot be null.</exception>
		[Information(nameof(GetAllAbstractMethods), UnitTestCoverage = 100, Status = Status.Available)]
		public static IEnumerable<MethodInfo> GetAllAbstractMethods(this Type type)
		{
			Encapsulation.TryValidateNullParam(type, nameof(type));

			return type.GetRuntimeMethods().Where(m => m.IsAbstract);
		}

		/// <summary>
		/// Gets the declared fields.
		/// </summary>
		/// <param name="type">The type.</param>
		/// <returns>IEnumerable&lt;FieldInfo&gt;.</returns>
		/// <exception cref="ArgumentNullException">Type cannot be null.</exception>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", modifiedOn: "7/30/2020", UnitTestCoverage = 0, Status = Status.Available)]
		public static IEnumerable<FieldInfo> GetAllDeclaredFields(this Type type)
		{
			Encapsulation.TryValidateNullParam(type, nameof(type));

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
		[Information("Original Code .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", modifiedOn: "7/30/2020", UnitTestCoverage = 0, Status = Status.Available)]
		public static IEnumerable<MethodInfo> GetAllDeclaredMethods(this Type type)
		{
			Encapsulation.TryValidateNullParam(type, nameof(type));

			for (var i = 0; i <
				type.GetMethods(BindingFlags.Instance |
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
		[Information(nameof(GetAllFields), UnitTestCoverage = 0, Status = Status.Available)]
		public static IEnumerable<FieldInfo> GetAllFields(this Type type)
		{
			Encapsulation.TryValidateNullParam(type, nameof(type));

			var typeInfo = type.GetTypeInfo();

			while (typeInfo != null)
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
		public static IEnumerable<MethodInfo> GetAllGenericMethods(this Type type)
		{
			Encapsulation.TryValidateNullParam(type, nameof(type));

			return type.GetRuntimeMethods().Where(m => m.IsGenericMethod);
		}

		/// <summary>
		/// Gets all methods.
		/// </summary>
		/// <param name="type">The type.</param>
		/// <returns>IEnumerable&lt;MethodInfo&gt;.</returns>
		/// <exception cref="ArgumentNullException">Type cannot be null.</exception>
		[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, Status = Status.Available)]
		public static IEnumerable<MethodInfo> GetAllMethods(this Type type)
		{
			Encapsulation.TryValidateNullParam(type, nameof(type));

			var typeInfo = type.GetTypeInfo();

			while (typeInfo != null)
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
		public static IEnumerable<PropertyInfo> GetAllProperties(this Type type)
		{
			Encapsulation.TryValidateNullParam(type, nameof(type));

			var typeInfo = type.GetTypeInfo();

			while (typeInfo != null)
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
		public static IEnumerable<MethodInfo> GetAllPublicMethods(this Type type)
		{
			Encapsulation.TryValidateNullParam(type, nameof(type));

			return type.GetRuntimeMethods().Where(m => m.IsPublic);
		}

		/// <summary>
		/// Gets the static methods.
		/// </summary>
		/// <param name="type">The type.</param>
		/// <returns>IEnumerable&lt;MethodInfo&gt;.</returns>
		/// <exception cref="ArgumentNullException">Type cannot be null.</exception>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 0, Status = Status.Available)]
		public static IEnumerable<MethodInfo> GetAllStaticMethods(this Type type)
		{
			Encapsulation.TryValidateNullParam(type, nameof(type));

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
		public static T GetAttribute<T>(this Type type)
			where T : Attribute
		{
			Encapsulation.TryValidateNullParam(type, nameof(type));

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
		public static T GetAttribute<T>(this MethodInfo methodInfo)
			where T : Attribute
		{
			Encapsulation.TryValidateNullParam(methodInfo, nameof(methodInfo));

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
		public static T GetAttribute<T>(this PropertyInfo propertyInfo)
			where T : Attribute
		{
			Encapsulation.TryValidateNullParam(propertyInfo, nameof(propertyInfo));

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
		public static T GetAttribute<T>(this FieldInfo fieldInfo)
			where T : Attribute
		{
			Encapsulation.TryValidateNullParam(fieldInfo, nameof(fieldInfo));

			return fieldInfo?.GetCustomAttributes(typeof(T), false).FirstOrDefault() as T;
		}

		/// <summary>
		/// Gets the field hash.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="callback">The callback.</param>
		/// <returns>Hash for the field as System.String.</returns>
		/// <exception cref="ArgumentNullException">Callback cannot be null.</exception>
		[Information(nameof(GetFieldHash), UnitTestCoverage = 0, Status = Status.Available)]
		public static string GetFieldHash<T>(this Func<T> callback)
		{
			Encapsulation.TryValidateNullParam(callback, nameof(callback));

			return new string(callback.Target
				.GetType()
				.GetFields()
				.Where(x => x.MemberType == MemberTypes.Field)
				.Select(x => x.GetValue(callback.Target))
				.Where(x => x != null)
				.SelectMany(x => x.ToString())
				.ToArray());
		}


		/// <summary>
		/// Gets the type members with given attribute.
		/// </summary>
		/// <typeparam name="TAttribute">The type of the t attribute.</typeparam>
		/// <param name="type">The type.</param>
		/// <returns>System.ValueTuple&lt;System.String, TAttribute, System.Boolean, System.Boolean, Type&gt;[].</returns>
		/// <exception cref="InvalidOperationException">Member \"{member.Name}\" must be public if it has the [{typeof(TAttribute).Name}] attribute applied to it</exception>
		/// <exception cref="ArgumentNullException">Type cannot be null.</exception>
		[Information("https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 99, Status = Status.Available)]
		public static (string Name, TAttribute Attribute, bool IsPrivate, bool IsStatic, Type ParameterType)[] GetTypeMembersWithAttribute<TAttribute>(this Type type)
			where TAttribute : Attribute
		{
			Encapsulation.TryValidateNullParam(type, nameof(type));

			var allFields = type.GetFields()
				.Select(f => (f.Name,
								Attribute: f.GetAttribute<TAttribute>(), f.IsPrivate, f.IsStatic,
								ParameterType: f.FieldType));

			var allProperties = type.GetProperties()
				.Select(p => (p.Name,
								Attribute: p.GetAttribute<TAttribute>(),
								IsPrivate: p.GetSetMethod() == null,
								IsStatic: p.GetSetMethod() != null && p.GetSetMethod().IsStatic, p.PropertyType));

			var joined = allFields.Concat(allProperties).Where(member => member.Attribute != null).ToArray();

			foreach (var member in joined.Where(m => m.IsPrivate))
			{
				ExceptionThrower.ThrowArgumentOutOfRangeException($"Member \"{member.Name}\" must be public if it has the [{typeof(TAttribute).Name}] attribute applied to it", "Member");
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
		[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 0, Status = Status.Available)]
		public static bool HasAttribute<T>(this MethodInfo methodInfo) where T : Attribute
		{
			Encapsulation.TryValidateNullParam(methodInfo, nameof(methodInfo));

			return methodInfo.GetAttribute<T>() != null;
		}


		/// <summary>
		/// Determines whether the type inherits the base class].
		/// </summary>
		/// <param name="type">The type.</param>
		/// <param name="baseClass">The base class.</param>
		/// <returns><c>true</c> if [has base class of] [the specified base class]; otherwise, <c>false</c>.</returns>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", modifiedOn: "7/30/2020", UnitTestCoverage = 0, Status = Status.Available)]
		public static bool HasBaseClass(this Type type, Type baseClass)
		{
			if (type == baseClass)
			{
				return false;
			}

			while (type != null)
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
		[Information(nameof(HasParameterlessConstructor), UnitTestCoverage = 0, Status = Status.Available)]
		public static bool HasParameterlessConstructor(this Type type)
		{
			Encapsulation.TryValidateNullParam(type, nameof(type));

			return type.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Type.EmptyTypes, null) != null;
		}

		/// <summary>
		/// Determines whether the specified type is nullable.
		/// </summary>
		/// <param name="type">The type.</param>
		/// <returns><c>true</c> if the specified type is nullable; otherwise, <c>false</c>.</returns>
		[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 0, Status = Status.Available)]
		public static bool IsNullable(this Type type) => Nullable.GetUnderlyingType(type) != null;

		/// <summary>
		/// Determines whether the specified property is static.
		/// </summary>
		/// <param name="property">The property.</param>
		/// <returns><c>true</c> if the specified property is static; otherwise, <c>false</c>.</returns>
		/// <exception cref="ArgumentNullException">PropertyInfo cannot be null.</exception>
		[Information("From .NET EF Core source.", author: "David McCarter", createdOn: "7/31/2020", modifiedOn: "7/31/2020", UnitTestCoverage = 0, Status = Status.Available)]
		public static bool IsStatic(this PropertyInfo property)
		{
			Encapsulation.TryValidateNullParam(property, nameof(property));

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
		[Information(nameof(Max), UnitTestCoverage = 0, Status = Status.Available)]
		public static T Max<T>(this T obj1, T obj2)
			where T : IComparable
		{
			Encapsulation.TryValidateNullParam(obj2, nameof(obj2));

			return obj1.CompareTo(obj2) >= 0 ? obj1 : obj2;
		}
	}
}
