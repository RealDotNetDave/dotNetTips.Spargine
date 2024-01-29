// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Core
// Author           : David McCarter
// Created          : 02-16-2022
//
// Last Modified By : David McCarter
// Last Modified On : 11-02-2023
// ***********************************************************************
// <copyright file="Validator.Argument.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Methods that facilitate the validation of arguments and values,
// ensuring simplicity and accuracy. When invalid data is encountered,
// an Exception will be thrown, providing an appropriate error message,
// either custom or default.
// </summary>
// ***********************************************************************
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using DotNetTips.Spargine.Core.Properties;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

#nullable enable
namespace DotNetTips.Spargine.Core;

/// <summary>
/// Class to validate method parameters.
/// </summary>
public static partial class Validator
{

	/// <summary>
	/// Creates the exception message.
	/// </summary>
	/// <param name="message">The message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <param name="messageFromResource">The message from resource.</param>
	/// <returns>System.String.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static string CreateParamExceptionMessage(string message, string paramName, string messageFromResource)
	{
		var returnMessage = $"{paramName}: ";

		return message switch
		{
			null => $"{returnMessage}{messageFromResource}",
			_ => $"{returnMessage}{message}"
		};
	}

	/// <summary>
	/// Tries to validate the <see cref="Enum" /> input.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="input">The <see cref="Enum" /> input to validate.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>Enum.</returns>
	/// <exception cref="ArgumentOutOfRangeException">The value is not defined in the enum type.</exception>
	[Information(nameof(ArgumentDefined), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T ArgumentDefined<T>(this T input, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "") where T : Enum
	{
		var isValid = Enum.IsDefined(input.GetType(), input);

		if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(CreateExceptionMessage(errorMessage, Resources.ErrorEnumNotDefined), paramName);
		}

		return input;
	}

	/// <summary>
	/// Tries to validate that the <see cref="Type" /> matches the expected <see cref="Type" />.
	/// </summary>
	/// <param name="input">The <see cref="Type" /> to validate.</param>
	/// <param name="expectedType">The expected <see cref="Type" />.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>Type.</returns>
	/// <exception cref="ArgumentInvalidException"></exception>
	[Information(nameof(ArgumentEquals), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Type ArgumentEquals(this Type input, Type expectedType, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		input = input.ArgumentNotNull();
		expectedType = expectedType.ArgumentNotNull();

		if (input.CheckEquals(expectedType) is false)
		{
			ExceptionThrower.ThrowArgumentInvalidException(CreateExceptionMessage(errorMessage, Resources.ErrorInvalidType), paramName);
		}

		return input!;
	}

	/// <summary>
	/// Checks that the <see cref="DirectoryInfo" /> exists.
	/// </summary>
	/// <param name="input">The <see cref="DirectoryInfo" /> to validate.</param>
	/// <param name="defaultValue">The default value that will be returned if the directory does not exist.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>System.IO.DirectoryInfo.</returns>
	/// <exception cref="ArgumentNullException">input</exception>
	/// <exception cref="DirectoryNotFoundException">Directory cannot be null.</exception>
	/// <remarks>This also checks the input for null.</remarks>
	[Information(nameof(ArgumentExists), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static DirectoryInfo ArgumentExists(this DirectoryInfo input, DirectoryInfo? defaultValue = null, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		if (input.CheckIsNotNull() is false)
		{
			ExceptionThrower.ThrowArgumentNullException(CreateParamExceptionMessage(errorMessage, paramName, Resources.ErrorArgumentNull));
		}

		var isValid = input!.Exists;

		if (isValid is false && defaultValue is not null)
		{
			input = defaultValue!;
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowDirectoryNotFoundException(CreateParamExceptionMessage(errorMessage, paramName, $"{Resources.ErrorDirectoryDoesNotExist} Directory:{input!.FullName}"), input);
		}

		return input!;
	}

	/// <summary>
	/// Validates that the <see cref="FileInfo" /> exists.
	/// </summary>
	/// <param name="input">The <see cref="FileInfo" /> to validate.</param>
	/// <param name="defaultValue">The default <see cref="FileInfo" /> value that will be returned if the file does not exist.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>A valid <see cref="FileInfo" /> object.</returns>
	/// <exception cref="ArgumentException">'paramName' cannot be null or empty. - paramName</exception>
	/// <exception cref="FileNotFoundException">File cannot be found.</exception>
	/// <remarks>This also checks the input for null.</remarks>
	[Information(nameof(ArgumentExists), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static FileInfo ArgumentExists(this FileInfo input, FileInfo? defaultValue = null, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		var isValid = input.CheckExists();

		if (isValid is false && defaultValue is not null)
		{
			input = defaultValue!;
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowFileNotFoundException(CreateParamExceptionMessage(errorMessage, paramName, Resources.ErrorFileNotFound), input!.FullName);
		}

		return input!;
	}

	/// <summary>
	/// Validates the <see cref="byte" /> is in range.
	/// </summary>
	/// <param name="input">The <see cref="byte" /> input to validate.</param>
	/// <param name="lower">The minimum value. Default = 0.</param>
	/// <param name="upper">The maximum value.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>System.Byte.</returns>
	[Information(nameof(ArgumentInRange), "David McCarter", "1/29/2022", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static byte ArgumentInRange(this byte input, byte lower = byte.MinValue, byte upper = byte.MaxValue, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		var isValid = input.CheckIsInRange(lower, upper);

		if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(CreateExceptionMessage(errorMessage, Resources.ErrorNumberIsInvalidBasedOnTheMinMaxValue), paramName);
		}

		return input;
	}
	/// <summary>
	/// Tries the validate <see cref="DateTime" /> parameter.
	/// </summary>
	/// <param name="input">The <see cref="DateTime" /> to validate.</param>
	/// <param name="lower">The minimum date time.</param>
	/// <param name="upper">The maximum date time.</param>
	/// <param name="defaultValue">The default value that will be returned if validation fails.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>DateTime.</returns>
	[Information(nameof(ArgumentInRange), "David McCarter", "1/21/2022", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static DateTime ArgumentInRange(this DateTime input, DateTime lower, DateTime upper, DateTime? defaultValue = null, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		var isValid = input.CheckIsInRange(lower, upper);

		if (isValid is false && defaultValue.HasValue)
		{
			input = defaultValue.GetValueOrDefault();
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(CreateExceptionMessage(errorMessage, Resources.ErrorDateIsInvalidBasedOnMinMaxDateTime), paramName);
		}

		return input;
	}

	/// <summary>
	/// Tries the validate <see cref="DateTimeOffset" /> parameter.
	/// </summary>
	/// <param name="input">The <see cref="DateTimeOffset" /> to validate.</param>
	/// <param name="lower">The minimum date time.</param>
	/// <param name="upper">The maximum date time.</param>
	/// <param name="defaultValue">The default value that will be returned if validation fails.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>DateTimeOffset.</returns>
	[Information(nameof(ArgumentInRange), "David McCarter", "1/21/2022", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static DateTimeOffset ArgumentInRange(this DateTimeOffset input, DateTimeOffset lower, DateTimeOffset upper, DateTimeOffset? defaultValue = null, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		var isValid = input.CheckIsInRange(lower, upper);

		if (isValid is false && defaultValue is not null)
		{
			input = defaultValue!.Value;
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(CreateExceptionMessage(errorMessage, Resources.ErrorDateIsInvalidBasedOnMinMaxDateTime), paramName);
		}

		return input;
	}

	/// <summary>
	/// Tries the validate an <see cref="int" /> value.
	/// </summary>
	/// <param name="input">The <see cref="int" /> to validate</param>
	/// <param name="lower">The minimum value. Default = 0.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <param name="upper">The maximum value.</param>
	/// <param name="defaultValue">The default value that will be returned if validation fails.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <returns>System.Int32.</returns>
	/// <exception cref="ArgumentOutOfRangeException"></exception>
	[Information(nameof(ArgumentInRange), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int ArgumentInRange(this int input, int lower = 0, [CallerArgumentExpression(nameof(input))] string paramName = "", int upper = int.MaxValue, int? defaultValue = null, string errorMessage = "")
	{
		var isValid = input.CheckIsInRange(lower, upper);

		if (isValid is false && defaultValue is not null)
		{
			input = defaultValue!.Value;
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(CreateExceptionMessage(errorMessage, Resources.ErrorNumberIsInvalidBasedOnTheMinMaxValue), paramName);
		}

		return input;
	}

	/// <summary>
	/// Tries the validate a <see cref="double" /> parameter.
	/// </summary>
	/// <param name="input">The <see cref="double" /> to validate.</param>
	/// <param name="lower">The minimum value. Default = 0.</param>
	/// <param name="upper">The maximum value.</param>
	/// <param name="defaultValue">The default value that will be returned if validation fails.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>System.Double.</returns>
	/// <exception cref="ArgumentOutOfRangeException"></exception>
	[Information(nameof(ArgumentInRange), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double ArgumentInRange(this double input, double lower = 0, double upper = double.MaxValue, double? defaultValue = null, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		var isValid = input.CheckIsInRange(lower, upper);

		if (isValid is false && defaultValue is not null)
		{
			input = defaultValue!.Value;
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(CreateExceptionMessage(errorMessage, Resources.ErrorNumberIsInvalidBasedOnTheMinMaxValue), paramName);
		}

		return input;
	}

	/// <summary>
	/// Tries the validate a <see cref="long" /> parameter.
	/// </summary>
	/// <param name="input">The <see cref="long" /> to validate.</param>
	/// <param name="lower">The minimum value. Default = 0.</param>
	/// <param name="upper">The maximum value.</param>
	/// <param name="defaultValue">The default value that will be returned if validation fails.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>System.Int64.</returns>
	/// <exception cref="ArgumentOutOfRangeException"></exception>
	[Information(nameof(ArgumentInRange), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static long ArgumentInRange(this long input, long lower = 0, long upper = long.MaxValue, long? defaultValue = null, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		var isValid = input.CheckIsInRange(lower, upper);

		if (isValid is false && defaultValue is not null)
		{
			input = defaultValue!.Value;
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(CreateExceptionMessage(errorMessage, Resources.ErrorNumberIsInvalidBasedOnTheMinMaxValue), paramName);
		}

		return input;
	}

	/// <summary>
	/// Tries the validate a <see cref="decimal" /> input.
	/// </summary>
	/// <param name="input">The <see cref="decimal" /> to validate.</param>
	/// <param name="lower">The minimum value.</param>
	/// <param name="upper">The maximum value.</param>
	/// <param name="defaultValue">The default value that will be returned if validation fails.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>System.Decimal.</returns>
	/// <exception cref="ArgumentOutOfRangeException"></exception>
	[Information(nameof(ArgumentInRange), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static decimal ArgumentInRange(this decimal input, decimal lower = 0, decimal upper = decimal.MaxValue, decimal? defaultValue = null, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		var isValid = input.CheckIsInRange(lower, upper);

		if (isValid is false && defaultValue is not null)
		{
			input = defaultValue!.Value;
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(CreateExceptionMessage(errorMessage, Resources.ErrorNumberIsInvalidBasedOnTheMinMaxValue), paramName);
		}

		return input;
	}

	/// <summary>
	/// Tries to validate the <see cref="DateOnly" /> input.
	/// </summary>
	/// <param name="input">The <see cref="DateOnly" /> input to validate.</param>
	/// <param name="lower">The minimum date.</param>
	/// <param name="upper">The maximum date.</param>
	/// <param name="defaultValue">The default value that will be returned if validation fails.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>DateOnly.</returns>
	[Information(nameof(ArgumentInRange), "David McCarter", "2/15/2022", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static DateOnly ArgumentInRange(this DateOnly input, DateOnly lower, DateOnly upper, DateOnly? defaultValue = null, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		var isValid = input.CheckIsInRange(lower, upper);

		if (isValid is false && defaultValue.HasValue)
		{
			input = defaultValue.GetValueOrDefault();
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(CreateExceptionMessage(errorMessage, Resources.ErrorDateIsInvalidBasedOnMinMaxDateTime), paramName);
		}

		return input;
	}

	/// <summary>
	/// Tries to validate the <see cref="TimeOnly" /> input.
	/// </summary>
	/// <param name="input">The <see cref="TimeOnly" /> to validate.</param>
	/// <param name="lower">The minimum time.</param>
	/// <param name="upper">The maximum time.</param>
	/// <param name="defaultValue">The default value that will be returned if validation fails.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>TimeOnly.</returns>
	[Information(nameof(ArgumentInRange), "David McCarter", "2/15/2022", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static TimeOnly ArgumentInRange(this TimeOnly input, TimeOnly lower, TimeOnly upper, TimeOnly? defaultValue = null, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		var isValid = input!.CheckIsInRange(lower, upper);

		if (isValid is false && defaultValue.HasValue)
		{
			input = defaultValue.GetValueOrDefault();
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(CreateExceptionMessage(errorMessage, Resources.ErrorTimeIsInvalidBasedOnTheMinMaxRange), paramName);
		}

		return input;
	}

	/// <summary>
	/// Tries to validate the <see cref="string" /> input.
	/// </summary>
	/// <param name="input">The <see cref="string" /> to validate.</param>
	/// <param name="lower">The minimum length.</param>
	/// <param name="upper">The maximum length.</param>
	/// <param name="trim">if set to <c>true</c> trims the string.</param>
	/// <param name="defaultValue">The default value that will be returned if validation fails.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>System.String.</returns>
	/// <exception cref="ArgumentInvalidException">Value cannot be null.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Minimum length is not valid.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Value is not within range.</exception>
	/// <remarks>This also checks the input for null.</remarks>
	[Information(nameof(ArgumentInRange), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static string ArgumentInRange(this string input, int lower = 0, int upper = int.MaxValue, bool trim = true, string? defaultValue = null, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		var isValid = input.CheckIsNotNull() && input!.Length.CheckIsInRange(lower, upper);

		if (isValid is false && string.IsNullOrEmpty(defaultValue) is false)
		{
			input = defaultValue;
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(CreateExceptionMessage(errorMessage, string.Format(CultureInfo.CurrentCulture, Resources.ErrorInvalidStringLengthAcceptableRange, lower, upper)), paramName);
		}

		return trim ? input!.Trim() : input!;
	}

	/// <summary>
	/// Tries to validate the <see cref="IEnumerable{T}" /> is not null and has items.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="input">The <see cref="IEnumerable{T}" /> to validate.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>IEnumerable.</returns>
	/// <exception cref="ArgumentNullException">Collection is null or has no items.</exception>
	/// <remarks>This also checks the input for null.</remarks>
	[Information(nameof(ArgumentItemsExists), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static IEnumerable<T> ArgumentItemsExists<T>(this IEnumerable<T> input, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		var isValid = input.CheckItemsExists();

		if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentNullException(CreateExceptionMessage(errorMessage, Resources.ErrorCollectionIsNullOrHasNoItems), paramName);
		}

		return input!;
	}

	///// <summary>
	///// Arguments the items exists.
	///// </summary>
	///// <typeparam name="T"></typeparam>
	///// <param name="input">The input.</param>
	///// <param name="errorMessage">The error message.</param>
	///// <param name="paramName">Name of the parameter.</param>
	///// <returns>IReadOnlyList&lt;T&gt;.</returns>
	//[Information(nameof(ArgumentItemsExists), "David McCarter", "5/25/2022", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
	//[MethodImpl(MethodImplOptions.AggressiveInlining)]
	//public static IReadOnlyList<T> ArgumentItemsExists<T>(this IReadOnlyList<T> input, string errorMessage = "", [CallerArgumentExpression("input")] string paramName = "")
	//{
	//	var isValid = input.CheckItemsExists();

	//	if (isValid is false)
	//	{
	//		ExceptionThrower.ThrowArgumentNullException(CreateExceptionMessage(errorMessage, Resources.ErrorCollectionIsNullOrHasNoItems), paramName);
	//	}

	//	return input!;
	//}

	///// <summary>
	///// Arguments the items exists.
	///// </summary>
	///// <typeparam name="T"></typeparam>
	///// <param name="input">The input.</param>
	///// <param name="errorMessage">The error message.</param>
	///// <param name="paramName">Name of the parameter.</param>
	///// <returns>IReadOnlyCollection&lt;T&gt;.</returns>
	//[Information(nameof(ArgumentItemsExists), "David McCarter", "5/27/2022", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
	//[MethodImpl(MethodImplOptions.AggressiveInlining)]
	//public static IReadOnlyCollection<T> ArgumentItemsExists<T>(this IReadOnlyCollection<T> input, string errorMessage = "", [CallerArgumentExpression("input")] string paramName = "")
	//{
	//	var isValid = input.CheckItemsExists();

	//	if (isValid is false)
	//	{
	//		ExceptionThrower.ThrowArgumentNullException(CreateExceptionMessage(errorMessage, Resources.ErrorCollectionIsNullOrHasNoItems), paramName);
	//	}

	//	return input!;
	//}

	/// <summary>
	/// Tries to validate the <see cref="List{T}" /> has items.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="input">The <see cref="List{T}" /> to validate.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>IEnumerable.</returns>
	/// <exception cref="ArgumentNullException">Collection is null or has no items.</exception>
	/// <remarks>This also checks the input for null.</remarks>
	[Information(nameof(ArgumentItemsExists), "David McCarter", "2/17/2022", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static IList<T> ArgumentItemsExists<T>(this IList<T> input, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		var isValid = input.CheckItemsExists();

		if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentNullException(CreateExceptionMessage(errorMessage, Resources.ErrorCollectionIsNullOrHasNoItems), paramName);
		}

		return input!;
	}

	/// <summary>
	/// Tries to validate the array has items.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="input">The array to validate.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>T[].</returns>
	/// <remarks>This also checks the input for null.</remarks>
	[Information(nameof(ArgumentItemsExists), "David McCarter", "2/4/2022", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T[] ArgumentItemsExists<T>(this T[] input, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		var isValid = input.CheckItemsExists();

		if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentNullException(CreateExceptionMessage(errorMessage, Resources.ErrorCollectionSizeIsNotValid), paramName);
		}

		return input!;
	}

	/// <summary>
	/// Tries to validate the <see cref="IEnumerable{T}" /> has the given count.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="input">The <see cref="IEnumerable{T}" /> to validate.</param>
	/// <param name="count">The count.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>IEnumerable&lt;T&gt;.</returns>
	/// <remarks>This also checks the input for null.</remarks>
	[Information(nameof(ArgumentItemsExists), "David McCarter", "4/4/2022", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static IEnumerable<T> ArgumentItemsExists<T>(this IEnumerable<T> input, long count, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		input = input.ArgumentNotNull();

		var isValid = input!.TryGetNonEnumeratedCount(out var collectionCount) && collectionCount == count;

		if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(CreateExceptionMessage(errorMessage, "Collection has no items."), paramName);
		}

		return input!;
	}

	/// <summary>
	/// Tries to validate the <see cref="string" /> input. Trims the string.
	/// </summary>
	/// <param name="input">The <see cref="string" /> to validate.</param>
	/// <param name="match">The match.</param>
	/// <param name="trim">if set to <c>true</c> trims the string.</param>
	/// <param name="defaultValue">The default value that will be returned if validation fails.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>System.String.</returns>
	/// <exception cref="ArgumentException">'input' cannot be null or empty. - input</exception>
	/// <exception cref="ArgumentNullException">match</exception>
	/// <remarks>This also checks the input for null.</remarks>
	[Information(nameof(ArgumentMatched), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static string ArgumentMatched(this string input, Regex match, bool trim = true, string? defaultValue = null, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		input = input!.ArgumentNotNullOrEmpty();
		match = match.ArgumentNotNull();

		var isValid = match!.IsMatch(input);

		if (isValid is false && string.IsNullOrEmpty(defaultValue) is false)
		{
			input = defaultValue; // Not being tested 
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentInvalidException(CreateExceptionMessage(errorMessage, Resources.ErrorStringIsNotValid), paramName);
		}

		return trim ? input!.Trim() : input!;
	}

	/// <summary>
	/// Checks a condition against the input.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="input">The input to validate.</param>
	/// <param name="condition">if set to <c>true</c> [condition].</param>
	/// <param name="defaultValue">The default value to be returned if condition failed.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>T.</returns>
	/// <remarks>This also checks the input for null.</remarks>
	[Information(nameof(ArgumentMeetsCondition), "David McCarter", "4/4/2022", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T ArgumentMeetsCondition<T>(this T input, bool condition, T? defaultValue = default, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		var isValid = input is not null && condition;

		if (isValid is false && defaultValue is not null)
		{
			input = defaultValue!;
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentInvalidException(CreateExceptionMessage(errorMessage, Resources.ErrorInvalidValue), paramName);
		}

		return input!;
	}

	/// <summary>
	/// Determines whether the <see cref="ReadOnlySpan{T}" /> is empty.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="input">The <see cref="ReadOnlySpan{T}" /> to validate.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>ReadOnlySpan&lt;T&gt;.</returns>
	[Information(nameof(ArgumentNotEmpty), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ReadOnlySpan<T> ArgumentNotEmpty<T>(this ReadOnlySpan<T> input, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		if (input.CheckIsNotEmpty() is false)
		{
			ExceptionThrower.ThrowArgumentNullException(CreateExceptionMessage(errorMessage, Resources.ErrorReadOnlySpanCannotBeNull), paramName);
		}

		return input;
	}

	/// <summary>
	/// Determines whether the <see cref="Span{T}" /> is empty.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="input">The <see cref="Span{T}" /> to validate.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>Span&lt;T&gt;.</returns>
	[Information(nameof(ArgumentNotEmpty), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Span<T> ArgumentNotEmpty<T>(this Span<T> input, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		if (input.IsEmpty)
		{
			ExceptionThrower.ThrowArgumentNullException(CreateExceptionMessage(errorMessage, Resources.ErrorSpanCannotBeNullOrEmpty), paramName);
		}

		return input;
	}

	/// <summary>
	/// Validates the input is not <see langword="null" />.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="input">The input to validate.</param>
	/// <param name="defaultValue">The default value that will be returned if validation fails.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	/// <remarks>This also checks the input for null.</remarks>
	[Information(nameof(ArgumentNotNull), "David McCarter", "2/10/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T ArgumentNotNull<T>(this T input, T? defaultValue = default, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "") //where T : class
	{
		var isValid = input is not null;

		if (isValid is false && defaultValue is not null)
		{
			input = defaultValue;
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentNullException(CreateParamExceptionMessage(errorMessage, paramName, Resources.ErrorObjectCannotBeNull));
		}

		return input!;
	}

	/// <summary>
	/// Tries the validate that the <see cref="Uri" /> is not null.
	/// </summary>
	/// <param name="input">The <see cref="Uri" /> to validate.</param>
	/// <param name="defaultValue">The default value that will be returned if validation fails.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>Uri.</returns>
	/// <remarks>This also checks the input for null.</remarks>
	[Information(nameof(ArgumentNotNull), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Uri ArgumentNotNull(this Uri input, Uri? defaultValue = null, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		var isValid = input.CheckIsNotNull();

		if (isValid is false && defaultValue is not null)
		{
			input = defaultValue;
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentNullException(CreateExceptionMessage(errorMessage, Resources.ErrorUriCannotBeNull), paramName);
		}

		return input!;
	}

	/// <summary>
	/// Tries to validate the <see cref="Guid" /> is not empty.
	/// </summary>
	/// <param name="input">The <see cref="Guid" /> to validate.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="defaultValue">The default value that will be returned if validation fails.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>Guid.</returns>
	/// <exception cref="ArgumentInvalidException">Guid cannot be empty.</exception>
	[Information(nameof(ArgumentNotNullOrEmpty), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Guid ArgumentNotNullOrEmpty(this Guid input, string errorMessage = "", Guid? defaultValue = null, [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		var isValid = input.CheckIsNotEmpty();

		if (isValid is false && defaultValue is not null)
		{
			input = defaultValue.Value;
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentInvalidException(CreateExceptionMessage(errorMessage, Resources.ErrorGuidIsNullOrEmpty), paramName);
		}

		return input;
	}

	/// <summary>
	/// Tries to validate that the <see cref="string" /> is not null or empty.
	/// </summary>
	/// <param name="input">The <see cref="string" /> to validate.</param>
	/// <param name="trim">if set to <c>true</c> trims the string.</param>
	/// <param name="defaultValue">The default value that will be returned if validation fails.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>System.String.</returns>
	/// <exception cref="ArgumentException">'input' cannot be null or empty. - input</exception>
	/// <exception cref="ArgumentException">'paramName' cannot be null or empty. - paramName</exception>
	[Information(nameof(ArgumentNotNullOrEmpty), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static string ArgumentNotNullOrEmpty(this string input, bool trim = true, string? defaultValue = null, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		var isValid = string.IsNullOrEmpty(input) is false;

		if (isValid is false && string.IsNullOrEmpty(defaultValue) is false)
		{
			input = defaultValue;
		}
		else if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentNullException(CreateExceptionMessage(errorMessage, Resources.ErrorStringIsNullOrEmpty), paramName);
		}

		return trim ? input.Trim() : input;
	}

	/// <summary>
	/// Validates the <see cref="IList{T}" /> is not read only.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="input">The <see cref="IList{T}" /> to validate.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>IList&lt;T&gt;.</returns>
	/// <remarks>This also checks the input for null.</remarks>
	[Information(nameof(ArgumentNotReadOnly), "David McCarter", "1/29/2022", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static IList<T> ArgumentNotReadOnly<T>(this IList<T> input, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		var isValid = input is not null && input.IsReadOnly is false;

		if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentReadOnlyException(CreateExceptionMessage(errorMessage, Resources.ErrorListCannotBeReadOnly), paramName);
		}

		return input!;
	}

	/// <summary>
	/// Validates the <see cref="ICollection{T}" /> is not read only.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="input">The <see cref="ICollection{T}" /> to validate.</param>
	/// <param name="errorMessage">The error message to be used in the Exception message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>ICollection&lt;T&gt;.</returns>
	/// <remarks>This also checks the input for null.</remarks>
	[Information(nameof(ArgumentNotReadOnly), "David McCarter", "1/28/2022", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineMay2022Args")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ICollection<T> ArgumentNotReadOnly<T>(this ICollection<T> input, string errorMessage = "", [CallerArgumentExpression(nameof(input))] string paramName = "")
	{
		var isValid = input is not null && input!.IsReadOnly is false;

		if (isValid is false)
		{
			ExceptionThrower.ThrowArgumentReadOnlyException(CreateExceptionMessage(errorMessage, Resources.ErrorCollectionIsNullOrHasNoItems), paramName);
		}

		return input!;
	}

}
