// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 02-01-2021
// ***********************************************************************
// <copyright file="EnumExtensions.cs" company="David McCarter - dotNetTips.com">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using dotNetTips.Spargine.Core;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Extension methods for <see cref="Enum" />.
	/// </summary>
	public static class EnumExtensions
	{
		/// <summary>
		/// Gets the enum description.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>System.String.</returns>
		/// <exception cref="ArgumentNullException">val</exception>
		[Information(nameof(GetDescription), UnitTestCoverage = 100, Status = Status.Available)]
		public static string GetDescription(this Enum value)
		{
			Validate.TryValidateParam(value, nameof(value));

			var field = value.GetType().GetField(value.ToString());
			var attributes = (DescriptionAttribute[])field.GetCustomAttributes(typeof(DescriptionAttribute), false);
			return attributes.Length > 0 ? attributes[0].Description : value.ToString();
		}


		/// <summary>
		/// Gets the names and values of an enum type.
		/// </summary>
		/// <param name="enum">The enumeration.</param>
		/// <returns>IEnumerable&lt;System.ValueTuple&lt;System.String, System.Int32&gt;&gt;.</returns>
		[Information(nameof(GetItems), UnitTestCoverage = 100, Status = Status.Available)]
		public static IList<(string Description, int Value)> GetItems(this Enum @enum)
		{
			Validate.TryValidateParam(@enum, nameof(@enum));

			var items = new List<(string Desctiption, int Value)>();

			foreach (var name in Enum.GetNames(@enum.GetType()))
			{
				items.Add((Desctiption: name, Value: (int)Enum.Parse(@enum.GetType(), name)));
			}

			return items;
		}

		/// <summary>
		/// Parses the specified enum name.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="name">The name.</param>
		/// <returns>T.</returns>
		/// <exception cref="ArgumentException">name</exception>
		/// <exception cref="System.ArgumentException">The exception.</exception>
		[Information(nameof(Parse), UnitTestCoverage = 100, Status = Status.Available)]
		public static T Parse<T>(this string name)
			where T : Enum
		{
			Validate.TryValidateParam(name, nameof(name));

			return (T)Enum.Parse(typeof(T), name);
		}

		/// <summary>
		/// Gets the description of the enum value.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="obj">The value.</param>
		/// <returns>EnumItem&lt;T&gt;.</returns>
		/// <exception cref="ArgumentNullException">val</exception>
		/// <exception cref="System.ArgumentNullException">The exception.</exception>
		private static EnumItem<T> GetDescriptionInternal<T>(object obj)
		{
			var field = obj.GetType().GetField(obj.ToString());
			var attributes = (DescriptionAttribute[])field.GetCustomAttributes(typeof(DescriptionAttribute), false);

			var enumItem = new EnumItem<T>
			{
				Description = attributes.Length > 0 ? attributes[0].Description : obj.ToString(),
				Value = (T)obj,
			};

			return enumItem;
		}
	}
}
