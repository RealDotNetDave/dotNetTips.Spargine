// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Core
// Author           : David McCarter
// Created          : 12-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 03-13-2023
// ***********************************************************************
// <copyright file="Enumeration.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Enumeration class.
/// Implements the <see cref="IComparable" />
/// </summary>
/// <seealso cref="IComparable" />
/// <remarks>Original code by: Jimmy Bogard</remarks>
[Information(nameof(Enumeration), Status = Status.Available, Documentation = "http://bit.ly/SpargineFeb2021")]
[DebuggerDisplay(nameof(DisplayName))]
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
	private Enumeration()
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
	/// Parses the specified value.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="description">The description.</param>
	/// <param name="predicate">The predicate.</param>
	/// <returns>T.</returns>
	/// <exception cref="ApplicationException"></exception>
	private static T Parse<T>(string description, [NotNull] Func<T, bool> predicate) where T : Enumeration, new()
	{
		var matchingItem = GetAll<T>().FirstOrDefault(predicate);

		if (matchingItem is null)
		{
			var message = $"Is not a valid {description} in {typeof(T)}.";

			ExceptionThrower.ThrowArgumentNullException(message, nameof(predicate));
		}

		return matchingItem;
	}

	/// <summary>
	/// Absolutes the difference.
	/// </summary>
	/// <param name="firstValue">The first value.</param>
	/// <param name="secondValue">The second value.</param>
	/// <returns>System.Int32.</returns>
	[Information(nameof(AbsoluteDifference), UnitTestCoverage = 100, Status = Status.Available)]
	public static int AbsoluteDifference([NotNull] Enumeration firstValue, [NotNull] Enumeration secondValue)
	{
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
		displayName = displayName.ArgumentNotNullOrEmpty();

		var matchingItem = Parse<T>(displayName, predicate: item => string.Equals(item.DisplayName, displayName, StringComparison.Ordinal));

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
		var matchingItem = Parse<T>("Validating int.", item => item.Value == value);

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

		for (var fieldCount = 0; fieldCount < fields.Length; fieldCount++)
		{
			var instance = new T();

			if (fields[fieldCount].GetValue(instance) is T locatedValue)
			{
				yield return locatedValue;
			}
		}
	}

	/// <summary>
	/// Gets the display name.
	/// </summary>
	/// <value>The display name.</value>
	[Information(nameof(DisplayName), UnitTestCoverage = 100, Status = Status.Available)]
	public string DisplayName
	{
		get => this._displayName;
		init => this._displayName = value.ArgumentNotNullOrEmpty();
	}

	/// <summary>
	/// Gets the value.
	/// </summary>
	/// <value>The value.</value>
	[Information(nameof(Value), UnitTestCoverage = 0, Status = Status.Available)]
	public int Value
	{
		get => this._value;
		init => this._value = value.ArgumentInRange(lower: 0);
	}

}
