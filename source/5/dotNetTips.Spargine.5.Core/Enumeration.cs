// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Core
// Author           : David McCarter
// Created          : 12-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 05-31-2021
// ***********************************************************************
// <copyright file="Enumeration.cs" company="dotNetTips.Spargine.5.Core">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Core
{
	/// <summary>
	/// Enumeration class.
	/// Implements the <see cref="System.IComparable" />
	/// </summary>
	/// <seealso cref="System.IComparable" />
	/// <remarks>Original code by: Jimmy Bogard</remarks>
	[Information(nameof(Enumeration), Status = Status.Available, Documentation = "http://bit.ly/SpargineFeb2021")]
	public abstract record Enumeration
	{
		/// <summary>
		/// The display name
		/// </summary>
		private readonly string _displayName;

		/// <summary>
		/// The value
		/// </summary>
		private int _value;

		/// <summary>
		/// Initializes a new instance of the <see cref="Enumeration" /> class.
		/// </summary>
		public Enumeration()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Enumeration" /> class.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="displayName">The display name.</param>
		[Information(nameof(Enumeration), UnitTestCoverage = 100, Status = Status.Available)]
		protected Enumeration(int value, string displayName)
		{
			this._value = value;
			this.DisplayName = displayName;
		}

		/// <summary>
		/// Gets the display name.
		/// </summary>
		/// <value>The display name.</value>
		[Information(nameof(DisplayName), UnitTestCoverage = 100, Status = Status.Available)]
		public string DisplayName
		{
			get => this._displayName;
			init
			{
				Validate.TryValidateParam(value, nameof(this.DisplayName));

				this._displayName = value;
			}
		}

		/// <summary>
		/// Gets the value.
		/// </summary>
		/// <value>The value.</value>
		[Information(nameof(Value), UnitTestCoverage = 0, Status = Status.Available)]
		public int Value
		{
			get => this._value;
			init
			{
				Validate.TryValidateParam(this.Value, minimumValue: 0, paramName: nameof(this.Value));

				this._value = value;
			}
		}

		/// <summary>
		/// Absolutes the difference.
		/// </summary>
		/// <param name="firstValue">The first value.</param>
		/// <param name="secondValue">The second value.</param>
		/// <returns>System.Int32.</returns>
		[Information(nameof(AbsoluteDifference), UnitTestCoverage = 0, Status = Status.Available)]
		public static int AbsoluteDifference(Enumeration firstValue, Enumeration secondValue)
		{
			Validate.TryValidateNullParam(firstValue, nameof(firstValue));
			Validate.TryValidateNullParam(secondValue, nameof(secondValue));

			var absoluteDifference = Math.Abs(firstValue.Value - secondValue.Value);
			return absoluteDifference;
		}

		/// <summary>
		/// Convert display name to Enumeration.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="displayName">The display name.</param>
		/// <returns>T.</returns>
		[Information(nameof(FromDisplayName), UnitTestCoverage = 0, Status = Status.Available)]
		public static T FromDisplayName<T>(string displayName) where T : Enumeration, new()
		{
			Validate.TryValidateParam(displayName, nameof(displayName));

			var matchingItem = Parse<T, string>(displayName, description: "display name", predicate: item => string.Compare(item.DisplayName, displayName, StringComparison.Ordinal) == 0);
			return matchingItem;
		}

		/// <summary>
		/// Converts number value to enumeration.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="value">The value.</param>
		/// <returns>T.</returns>
		[Information(nameof(FromValue), UnitTestCoverage = 0, Status = Status.Available)]
		public static T FromValue<T>(int value) where T : Enumeration, new()
		{
			var matchingItem = Parse<T, int>(value, nameof(value), item => item.Value == value);
			return matchingItem;
		}

		/// <summary>
		/// Gets all.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <returns>IEnumerable&lt;T&gt;.</returns>
		[Information(nameof(GetAll), UnitTestCoverage = 0, Status = Status.Available)]
		public static IEnumerable<T> GetAll<T>() where T : Enumeration, new()
		{
			var type = typeof(T);
			var fields = type.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);

			for (var i = 0; i < fields.Length; i++)
			{
				var instance = new T();

				if (fields[i].GetValue(instance) is T locatedValue)
				{
					yield return locatedValue;
				}
			}
		}

		/// <summary>
		/// Parses the specified value.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <typeparam name="K"></typeparam>
		/// <param name="value">The value.</param>
		/// <param name="description">The description.</param>
		/// <param name="predicate">The predicate.</param>
		/// <returns>T.</returns>
		/// <exception cref="ApplicationException"></exception>
		private static T Parse<T, K>(K value, string description, Func<T, bool> predicate) where T : Enumeration, new()
		{
			var matchingItem = GetAll<T>().FirstOrDefault(predicate);

			if (matchingItem is null)
			{
				var message = $"'{value}' is not a valid {description} in {typeof(T)}.";

				ExceptionThrower.ThrowArgumentNullException(message, nameof(predicate));
			}

			return matchingItem;
		}
	}
}
