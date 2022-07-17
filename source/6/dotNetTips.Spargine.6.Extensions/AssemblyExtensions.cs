// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions
// Author           : David McCarter
// Created          : 01-07-2021
//
// Last Modified By : David McCarter
// Last Modified On : 07-17-2022
// ***********************************************************************
// <copyright file="AssemblyExtensions.cs" company="dotNetTips.Spargine.6.Extensions">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Extension methods for Assembly.</summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using DotNetTips.Spargine.Core;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions
{
	/// <summary>
	/// AssemblyExtensions.
	/// </summary>
	public static class AssemblyExtensions
	{
		/// <summary>
		/// Gets all interfaces in an <see cref="Assembly" />.
		/// Validates that <paramref name="assembly" /> is not null.
		/// </summary>
		/// <param name="assembly">The assembly.</param>
		/// <returns>IEnumerable&lt;Type&gt;.</returns>
		/// <exception cref="ArgumentNullException">assembly</exception>
		/// <remarks>Original code from: oqtane.framework</remarks>
		[Information(nameof(GetAllInterfaces), "David McCarter", "1/7/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static IEnumerable<Type> GetAllInterfaces([NotNull] this Assembly assembly)
		{
			assembly = assembly.ArgumentNotNull();

			var interfaces = new Collection<Type>();

			foreach (Type type in assembly.GetTypes())
			{
				_ = interfaces.AddRange(type.GetInterfaces());
			}

			return interfaces.AsEnumerable();
		}

		/// <summary>
		/// Gets all types in an <see cref="Assembly" />.
		/// Validates that <paramref name="assembly" /> is not null.
		/// </summary>
		/// <param name="assembly">The assembly.</param>
		/// <returns>IEnumerable&lt;Type&gt;.</returns>
		[Information(nameof(GetAllTypes), "David McCarter", "221/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static IEnumerable<Type> GetAllTypes([NotNull] this Assembly assembly)
		{
			assembly = assembly.ArgumentNotNull();

			return assembly.GetTypes().Where(p => !p.IsAbstract).AsEnumerable();
		}

		/// <summary>
		/// Gets all instances in a <see cref="Assembly" />.
		/// Validates that <paramref name="assembly" /> is not null.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="assembly">The assembly.</param>
		/// <returns>IEnumerable&lt;T&gt;.</returns>
		/// <exception cref="ArgumentNullException">assembly</exception>
		/// <remarks>Original code from: oqtane.framework</remarks>
		[Information(nameof(GetInstances), "David McCarter", "1/7/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static IEnumerable<T> GetInstances<T>([NotNull] this Assembly assembly) where T : class
		{
			assembly = assembly.ArgumentNotNull();

			IEnumerable<Type> types = assembly.GetTypes()
				.Where(x => !x.IsInterface
				&& !x.IsAbstract && !x.IsGenericType
				&& typeof(T).IsAssignableFrom(x));

			foreach (Type type in types)
			{
				if (Activator.CreateInstance(type) is T instance)
				{
					yield return instance;
				}
			}
		}

		/// <summary>
		/// Gets the types included in the <see cref="Assembly" /> that are not abstract
		/// and is assignable.
		/// Validates that <paramref name="assembly" />  and <paramref name="type" /> is not null.
		/// </summary>
		/// <param name="assembly">The assembly.</param>
		/// <param name="type">Type of the interface.</param>
		/// <returns>IEnumerable&lt;Type&gt;.</returns>
		/// <exception cref="ArgumentNullException">assembly</exception>
		/// <exception cref="ArgumentNullException">interfaceType</exception>
		/// <remarks>Original code from: oqtane.framework</remarks>
		[Information(nameof(GetTypes), "David McCarter", "1/7/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static IEnumerable<Type> GetTypes([NotNull] this Assembly assembly, [NotNull] Type type)
		{
			assembly = assembly.ArgumentNotNull();
			type = type.ArgumentNotNull();

			return assembly.GetTypes().Where(p => !p.IsAbstract && type.IsAssignableFrom(p)).AsEnumerable();
		}
	}
}
