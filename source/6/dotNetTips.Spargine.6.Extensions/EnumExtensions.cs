// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 05-24-2022
// ***********************************************************************
// <copyright file="EnumExtensions.cs" company="David McCarter - dotNetTips.com">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.ComponentModel;
using DotNetTips.Spargine.Core;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Extension methods for <see cref="Enum" />.
	/// </summary>
	public static class EnumExtensions
	{
		/// <summary>
		/// Gets the <see cref="Enum" /> description.
		/// </summary>
		/// <param name="input">The value.</param>
		/// <returns>System.String.</returns>
		/// <exception cref="ArgumentNullException">val</exception>
		[Information(nameof(GetDescription), UnitTestCoverage = 100, Status = Status.Available)]
		public static string GetDescription(this Enum input)
		{
			input = input.ArgumentNotNull();

			var field = input.GetType().GetField(input.ToString());
			var attributes = (DescriptionAttribute[])field.GetCustomAttributes(typeof(DescriptionAttribute), false);

			return attributes.Length > 0 ? attributes[0].Description : input.ToString();
		}


		/// <summary>
		/// Gets the names and values of an <see cref="Enum" />.
		/// </summary>
		/// <param name="input">The enumeration.</param>
		/// <returns>IEnumerable&lt;System.ValueTuple&lt;System.String, System.Int32&gt;&gt;.</returns>
		[Information(nameof(GetItems), UnitTestCoverage = 100, Status = Status.Available)]
		public static IList<(string Description, int Value)> GetItems(this Enum input)
		{
			input = input.ArgumentNotNull();

			var items = new List<(string Desctiption, int Value)>();

			foreach (var name in Enum.GetNames(input.GetType()))
			{
				items.Add((Desctiption: name, Value: (int)Enum.Parse(input.GetType(), name)));
			}

			return items;
		}

		/// <summary>
		/// Parses the specified <see cref="Enum" /> name.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="name">The name.</param>
		/// <returns>T.</returns>
		/// <exception cref="ArgumentException">name</exception>
		/// <exception cref="ArgumentException">The exception.</exception>
		[Information(nameof(Parse), UnitTestCoverage = 100, Status = Status.Available)]
		public static T Parse<T>(this string name)
			where T : Enum
		{
			name = name.ArgumentNotNullOrEmpty();

			return (T)Enum.Parse(typeof(T), name);
		}
	}
}
