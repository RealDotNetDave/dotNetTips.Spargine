﻿// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions
// Author           : David McCarter
// Created          : 01-07-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-21-2021
// ***********************************************************************
// <copyright file="AssemblyExtensions.cs" company="dotNetTips.Spargine.5.Extensions">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Extension methods for Assembly.</summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using dotNetTips.Spargine.Core;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Extensions
{
	/// <summary>
	/// AssemblyExtensions.
	/// </summary>
	public static class AssemblyExtensions
	{
		/// <summary>
		/// Gets all types in an assembly.
		/// </summary>
		/// <param name="assembly">The assembly.</param>
		/// <returns>IEnumerable&lt;Type&gt;.</returns>
		[Information(nameof(GetAllTypes), "David McCarter", "221/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.New)]
		public static IEnumerable<Type> GetAllTypes(this Assembly assembly)
		{
			Validate.TryValidateNullParam(assembly, nameof(assembly));

			return assembly.GetTypes().Where(p => !p.IsAbstract).AsEnumerable();
		}

		/// <summary>
		/// Gets the instances.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="assembly">The assembly.</param>
		/// <returns>IEnumerable&lt;T&gt;.</returns>
		/// <exception cref="ArgumentNullException">assembly</exception>
		/// <remarks>Original code from: oqtane.framework</remarks>
		[Information(nameof(GetInstances), "David McCarter", "1/7/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.New, Documentation = "ADD LINK")]
		public static IEnumerable<T> GetInstances<T>(this Assembly assembly) where T : class
		{
			Validate.TryValidateNullParam(assembly, nameof(assembly));

			var types = assembly.GetTypes()
				.Where(x => !x.IsInterface
				&& !x.IsAbstract && !x.IsGenericType
				&& typeof(T).IsAssignableFrom(x));

			foreach (var type in types)
			{
				if (Activator.CreateInstance(type) is T instance)
				{
					yield return instance;
				}
			}
		}

		/// <summary>
		/// Gets the interfaces.
		/// </summary>
		/// <param name="assembly">The assembly.</param>
		/// <returns>IEnumerable&lt;Type&gt;.</returns>
		/// <exception cref="ArgumentNullException">assembly</exception>
		/// <remarks>Original code from: oqtane.framework</remarks>
		[Information(nameof(GetInterfaces), "David McCarter", "1/7/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.New)]
		public static IEnumerable<Type> GetInterfaces(this Assembly assembly)
		{
			Validate.TryValidateNullParam(assembly, nameof(assembly));

			var interfaces = new List<Type>();

			foreach (var type in assembly.GetTypes())
			{
				interfaces.AddRange(type.GetInterfaces());
			}

			return interfaces.AsEnumerable();
		}

		/// <summary>
		/// Gets the types included in the assembly that are not abstract
		/// and is assignable.
		/// </summary>
		/// <param name="assembly">The assembly.</param>
		/// <param name="type">Type of the interface.</param>
		/// <returns>IEnumerable&lt;Type&gt;.</returns>
		/// <exception cref="ArgumentNullException">assembly</exception>
		/// <exception cref="ArgumentNullException">interfaceType</exception>
		/// <remarks>Original code from: oqtane.framework</remarks>
		[Information(nameof(GetTypes), "David McCarter", "1/7/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.New)]
		public static IEnumerable<Type> GetTypes(this Assembly assembly, Type type)
		{
			Validate.TryValidateNullParam(assembly, nameof(assembly));
			Validate.TryValidateNullParam(type, nameof(assembly));

			return assembly.GetTypes().Where(p => !p.IsAbstract && type.IsAssignableFrom(p)).AsEnumerable();
		}
	}
}
