// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 03-29-2023
// ***********************************************************************
// <copyright file="TypeExtensions.cs" company="David McCarter - dotNetTips.com">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary>Extension methods for general types.</summary>
// ***********************************************************************
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Type Extensions.
/// </summary>
public static partial class TypeExtensions
{

	/// <summary>
	/// Gets the type of the type of.
	/// </summary>
	/// <param name="obj">The object.</param>
	/// <returns>DotNetTips.Spargine.Extensions.TypeExtensions.TypeOfType.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GetTypeOfType), UnitTestCoverage = 100, Status = Status.Available)]
	public static TypeOfType GetTypeOfType(this object obj)
	{
		var objType = obj?.GetType();

		if (objType.IsValueType)
		{
			return TypeOfType.Value;
		}
		else if (objType.IsClass)
		{
			var members = objType.GetMember("ToString");

			if (members != null)
			{
				var member = members.First();

				return member.GetCustomAttribute<CompilerGeneratedAttribute>() != null ? TypeOfType.Record : TypeOfType.Reference;
			}
		}

		return TypeOfType.Unknown;
	}

	/// <summary>
	/// Does the object implement  any of the interfaces.
	/// Validates that <paramref name="input" /> and <paramref name="interfaceNames" /> is not null.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <param name="interfaceNames">The interface names.</param>
	/// <returns>IEnumerable&lt;System.String&gt;.</returns>
	/// <exception cref="ArgumentNullException">Input cannot be null.</exception>
	[Information(nameof(GetImplementedInterfaces), UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static IEnumerable<string> GetImplementedInterfaces(this object input, params string[] interfaceNames)
	{
		input = input.ArgumentNotNull();
		interfaceNames = interfaceNames.ArgumentNotNull();

		var interfaces = input.GetType().GetInterfaces().Select(p => p.Name);
		var foundInterfaces = new HashSet<string>(interfaces.Intersect(interfaceNames));

		return foundInterfaces;
	}

	/// <summary>
	/// Gets the abstract methods.
	/// Validates that <paramref name="type" /> is not null.
	/// </summary>
	/// <param name="type">The type.</param>
	/// <returns>IEnumerable&lt;MethodInfo&gt;.</returns>
	/// <exception cref="ArgumentNullException">Type cannot be null.</exception>
	[Information(nameof(GetAllAbstractMethods), UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static IEnumerable<MethodInfo> GetAllAbstractMethods([NotNull] this Type type)
	{
		return type.ArgumentNotNull().GetRuntimeMethods().Where(m => m.IsAbstract);
	}

	/// <summary>
	/// Gets the declared fields.
	/// Validates that <paramref name="type" /> is not null.
	/// </summary>
	/// <param name="type">The type.</param>
	/// <returns>IEnumerable&lt;FieldInfo&gt;.</returns>
	/// <exception cref="ArgumentNullException">Type cannot be null.</exception>
	/// <example>
	/// Output: _address1,_address2,_bornOn,_cellPhone,_city,_country,_email,_firstName,
	/// _homePhone,_id,_lastName,_postalCode,_state
	/// </example>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", UnitTestCoverage = 100, Status = Status.Available)]
	public static IEnumerable<FieldInfo> GetAllDeclaredFields([NotNull] this Type type)
	{
		type = type.ArgumentNotNull();

		for (var fieldIndex = 0; fieldIndex <
						type.GetFields(BindingFlags.Instance |
							BindingFlags.Static |
							BindingFlags.Public |
							BindingFlags.NonPublic |
							BindingFlags.DeclaredOnly)
							.Length; fieldIndex++)
		{
			yield return type.GetFields(BindingFlags.Instance |
				BindingFlags.Static |
				BindingFlags.Public |
				BindingFlags.NonPublic |
				BindingFlags.DeclaredOnly)[fieldIndex];
		}
	}

	/// <summary>
	/// Gets declared methods.
	/// Validates that <paramref name="type" /> is not null.
	/// </summary>
	/// <param name="type">The type.</param>
	/// <returns>IEnumerable&lt;MethodInfo&gt;.</returns>
	/// <exception cref="ArgumentNullException">Type cannot be null.</exception>
	/// <example>
	/// Output: get_Address1, set_Address1, get_Address2, set_Address2, get_BornOn, set_BornOn, get_CellPhone,
	/// set_CellPhone, get_City, set_City, get_Country, set_Country, get_Email, set_Email, get_FirstName, set_FirstName,
	/// get_HomePhone, set_HomePhone, get_Id,set_Id, get_LastName, set_LastName, get_PostalCode, set_PostalCode,
	/// get_State, set_State, op_GreaterThanOrEqual, op_GreaterThan, op_Equality, op_LessThanOrEqual, op_LessThan,
	/// op_Inequality, CompareTo, Equals, Equals, GetHashCode, ToString, CalculateAge"
	/// </example>
	[Information("Original Code .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static IEnumerable<MethodInfo> GetAllDeclaredMethods([NotNull] this Type type)
	{
		type = type.ArgumentNotNull();

		for (var methodIndex = 0; methodIndex < type.GetMethods(BindingFlags.Instance |
				BindingFlags.Static |
				BindingFlags.Public |
				BindingFlags.NonPublic |
				BindingFlags.DeclaredOnly)
				.Length; methodIndex++)
		{
			yield return type.GetMethods(BindingFlags.Instance |
				BindingFlags.Static |
				BindingFlags.Public |
				BindingFlags.NonPublic |
				BindingFlags.DeclaredOnly)[methodIndex];
		}
	}

	/// <summary>
	/// Gets all fields.
	/// Validates that <paramref name="type" /> is not null.
	/// </summary>
	/// <param name="type">The type.</param>
	/// <returns>IEnumerable&lt;FieldInfo&gt;.</returns>
	/// <exception cref="ArgumentNullException">Type cannot be null.</exception>
	[Information(nameof(GetAllFields), UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static IEnumerable<FieldInfo> GetAllFields(this Type type)
	{
		var typeTypeInfo = type?.GetTypeInfo();
		while (typeTypeInfo != null)
		{
			foreach (var fieldInfo in typeTypeInfo.DeclaredFields)
			{
				yield return fieldInfo;
			}

			typeTypeInfo = typeTypeInfo.BaseType?.GetTypeInfo();
		}
	}

	/// <summary>
	/// Gets the generic methods.
	/// Validates that <paramref name="type" /> is not null.
	/// </summary>
	/// <param name="type">The type.</param>
	/// <returns>IEnumerable&lt;MethodInfo&gt;.</returns>
	/// <exception cref="ArgumentNullException">Type cannot be null.</exception>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static IEnumerable<MethodInfo> GetAllGenericMethods([NotNull] this Type type)
	{
		return type.ArgumentNotNull().GetRuntimeMethods().Where(m => m.IsGenericMethod);
	}

	/// <summary>
	/// Gets all methods.
	/// Validates that <paramref name="type" /> is not null.
	/// </summary>
	/// <param name="type">The type.</param>
	/// <returns>IEnumerable&lt;MethodInfo&gt;.</returns>
	/// <exception cref="ArgumentNullException">Type cannot be null.</exception>
	[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static IEnumerable<MethodInfo> GetAllMethods([NotNull] this Type type)
	{
		var typeInfo = type.ArgumentNotNull().GetTypeInfo();

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
	/// Validates that <paramref name="type" /> is not null.
	/// </summary>
	/// <param name="type">The type.</param>
	/// <returns>IEnumerable&lt;PropertyInfo&gt;.</returns>
	/// <exception cref="ArgumentNullException">Type cannot be null.</exception>
	[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static IEnumerable<PropertyInfo> GetAllProperties([NotNull] this Type type)
	{
		var typeInfo = type.ArgumentNotNull().GetTypeInfo();

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
	/// Validates that <paramref name="type" /> is not null.
	/// </summary>
	/// <param name="type">The type.</param>
	/// <returns>IEnumerable&lt;MethodInfo&gt;.</returns>
	/// <exception cref="ArgumentNullException">Type cannot be null.</exception>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static IEnumerable<MethodInfo> GetAllPublicMethods([NotNull] this Type type)
	{
		return type.ArgumentNotNull().GetRuntimeMethods().Where(m => m.IsPublic);
	}

	/// <summary>
	/// Gets the static methods.
	/// Validates that <paramref name="type" /> is not null.
	/// </summary>
	/// <param name="type">The type.</param>
	/// <returns>IEnumerable&lt;MethodInfo&gt;.</returns>
	/// <exception cref="ArgumentNullException">Type cannot be null.</exception>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static IEnumerable<MethodInfo> GetAllStaticMethods([NotNull] this Type type)
	{
		return type.ArgumentNotNull().GetRuntimeMethods().Where(m => m.IsStatic);
	}

	/// <summary>
	/// Resolves the attribute.
	/// Validates that <paramref name="type" /> is not null.
	/// </summary>
	/// <typeparam name="TAttribute">Generic type parameter.</typeparam>
	/// <param name="type">The type.</param>
	/// <returns>TAttribute.</returns>
	/// <exception cref="ArgumentNullException">Type cannot be null.</exception>
	[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static TAttribute GetAttribute<TAttribute>([NotNull] this Type type)
		where TAttribute : Attribute
	{
		return type.ArgumentNotNull().GetTypeInfo().GetCustomAttributes(typeof(TAttribute), false).OfType<TAttribute>().FirstOrDefault();
	}

	/// <summary>
	/// Resolves the attribute.
	/// Validates that <paramref name="methodInfo" /> is not null.
	/// </summary>
	/// <typeparam name="TAttribute">Generic type parameter.</typeparam>
	/// <param name="methodInfo">The method information.</param>
	/// <returns>TAttribute.</returns>
	/// <exception cref="ArgumentNullException">MethodInfo cannot be null.</exception>
	[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static TAttribute GetAttribute<TAttribute>([NotNull] this MethodInfo methodInfo)
		where TAttribute : Attribute
	{
		return methodInfo.ArgumentNotNull().GetCustomAttributes(typeof(TAttribute), false).FirstOrDefault() as TAttribute;
	}

	/// <summary>
	/// Resolves the attribute.
	/// Validates that <paramref name="propertyInfo" /> is not null.
	/// </summary>
	/// <typeparam name="TAttribute">Generic type parameter.</typeparam>
	/// <param name="propertyInfo">The property information.</param>
	/// <returns>TAttribute.</returns>
	/// <exception cref="ArgumentNullException">PropertyInfo cannot be null.</exception>
	[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static TAttribute GetAttribute<TAttribute>([NotNull] this PropertyInfo propertyInfo)
		where TAttribute : Attribute
	{
		return propertyInfo.ArgumentNotNull().GetCustomAttributes(typeof(TAttribute), false).FirstOrDefault() as TAttribute;
	}

	/// <summary>
	/// Resolves the attribute.
	/// </summary>
	/// <typeparam name="TAttribute">Generic type parameter.</typeparam>
	/// <param name="fieldInfo">The field information.</param>
	/// <returns>TAttribute.</returns>
	/// <exception cref="ArgumentNullException">FieldInfo cannot be null.</exception>
	[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static TAttribute GetAttribute<TAttribute>([NotNull] this FieldInfo fieldInfo)
		where TAttribute : Attribute
	{
		return fieldInfo?.GetCustomAttributes(typeof(TAttribute), false).FirstOrDefault() as TAttribute;
	}

	/// <summary>
	/// Gets the type members with given attribute.
	/// Validates that <paramref name="type" /> is not null.
	/// </summary>
	/// <typeparam name="TAttribute">The type of the t attribute.</typeparam>
	/// <param name="type">The type.</param>
	/// <returns>System.ValueTuple&lt;System.String, TAttribute, System.Boolean, System.Boolean, Type&gt;[].</returns>
	/// <exception cref="InvalidOperationException">Member \"{member.Name}\" must be public if it has the [{typeof(TAttribute).Name}] attribute applied to it</exception>
	/// <exception cref="ArgumentNullException">Type cannot be null.</exception>
	[Information("https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static (string Name, TAttribute Attribute, bool IsPrivate, bool IsStatic, Type ParameterType)[] GetTypeMembersWithAttribute<TAttribute>([NotNull] this Type type)
		where TAttribute : Attribute
	{
		type = type.ArgumentNotNull();

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
			ExceptionThrower.ThrowArgumentOutOfRangeException($"Member \"{member.Name}\" must be public if it has the [{typeof(TAttribute).Name}] attribute applied to it", "Member");
		}

		return joined;
	}

	/// <summary>
	/// Determines whether the specified method information has attribute.
	/// Validates that <paramref name="methodInfo" /> is not null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="methodInfo">The method information.</param>
	/// <returns><c>true</c> if the specified method information has attribute; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">MethodInfo cannot be null.</exception>
	[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool HasAttribute<T>([NotNull] this MethodInfo methodInfo) where T : Attribute
	{
		return methodInfo.ArgumentNotNull().GetAttribute<T>() is not null;
	}

	/// <summary>
	/// Determines whether the type inherits the base class].
	/// </summary>
	/// <param name="type">The type.</param>
	/// <param name="baseClass">The base class.</param>
	/// <returns><c>true</c> if [has base class of] [the specified base class]; otherwise, <c>false</c>.</returns>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool HasBaseClass([NotNull] this Type type, [NotNull] Type baseClass)
	{
		if (type.CheckIsNotNull() is false && baseClass.CheckIsNotNull() is false)
		{
			return false;
		}

		while (type.CheckIsNotNull())
		{
			if (type.CheckEquals(baseClass))
			{
				return true;
			}
			else
			{
				type = type.BaseType;
			}
		}

		return false;
	}

	/// <summary>
	/// Determines whether [has parameterless constructor] [the specified type].
	/// Validates that <paramref name="type" /> is not null.
	/// </summary>
	/// <param name="type">The type.</param>
	/// <returns><c>true</c> if [has parameterless constructor] [the specified type]; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Type cannot be null.</exception>
	[Information(nameof(HasParameterlessConstructor), UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool HasParameterlessConstructor([NotNull] this Type type)
	{
		return type.ArgumentNotNull().GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Type.EmptyTypes, null) is not null;
	}

	/// <summary>
	/// Determines whether the specified type implements <see cref="IEnumerable" />.
	/// Validates that <paramref name="type" /> is not null.
	/// </summary>
	/// <param name="type">The type.</param>
	/// <returns><c>true</c> if the specified type is <see cref="IEnumerable" />; otherwise, <c>false</c>.</returns>
	[Information(nameof(HasParameterlessConstructor), UnitTestCoverage = 100, Status = Status.Available, Documentation = "http://bit.ly/SpargineMarch2021")]
	public static bool IsEnumerable([NotNull] this Type type)
	{
		return type.ArgumentNotNull().GetInterfaces().Any(t => t == typeof(IEnumerable));
	}

	/// <summary>
	/// Determines whether the specified type is nullable.
	/// </summary>
	/// <param name="type">The type.</param>
	/// <returns><c>true</c> if the specified type is nullable; otherwise, <c>false</c>.</returns>
	[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsNullable([AllowNull] this Type type)
	{
		return Nullable.GetUnderlyingType(type) is not null;
	}

	/// <summary>
	/// Determines whether the specified property is static.
	/// Validates that <paramref name="property" /> is not null.
	/// </summary>
	/// <param name="property">The property.</param>
	/// <returns><c>true</c> if the specified property is static; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">PropertyInfo cannot be null.</exception>
	[Information("From .NET EF Core source.", author: "David McCarter", createdOn: "7/31/2020", UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsStatic([NotNull] this PropertyInfo property)
	{
		return (property.ArgumentNotNull().GetMethod ?? property.SetMethod).IsStatic;
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
	public static T Max<T>(this T obj1, T obj2) where T : IComparable
	{
		return obj1.CompareTo(obj2) >= 0 ? obj1 : obj2;
	}
}
