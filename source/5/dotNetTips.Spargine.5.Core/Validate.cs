// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core
// Author           : David McCarter
// Created          : 06-26-2017
//
// Last Modified By : David McCarter
// Last Modified On : 11-27-2021
// ***********************************************************************
// <copyright file="Validate.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Methods to validate parameters.</summary>
// ***********************************************************************
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text.RegularExpressions;
using dotNetTips.Spargine.Core.Properties;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Core
{
	//TODO: MAKE ONE FOR DATETIME
	/// <summary>
	/// Class to validate method parameters.
	/// </summary>
	public static class Validate
	{
		/// <summary>
		/// Creates the exception message.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="messageFromResource">The message from resource.</param>
		/// <returns>System.String.</returns>
		private static string CreateExceptionMessage(string message, string messageFromResource)
		{
			return string.IsNullOrEmpty(message) ? messageFromResource : message;
		}

		/// <summary>
		/// Creates the exception message.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="paramName">Name of the parameter.</param>
		/// <param name="messageFromResource">The message from resource.</param>
		/// <returns>System.String.</returns>
		private static string CreateParamExceptionMessage(string message, string paramName, string messageFromResource)
		{
			var returnMessage = $"{paramName}: ";

			returnMessage = string.IsNullOrEmpty(message)
				? returnMessage + messageFromResource
				: returnMessage + message;

			return returnMessage;
		}

		/// <summary>
		/// Tries the validate null.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="throwException">if set to <c>true</c> [throw exception].</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		[Information(nameof(TryValidateNull), "David McCarter", "2/10/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "http://bit.ly/SpargineMarch2021")]
		public static bool TryValidateNull(object value, bool throwException = false)
		{
			if (( value is null ) && throwException)
			{
				ExceptionThrower.ThrowInvalidValueException(Resources.ObjectValidationFailed, value);
			}

			return value is null;
		}

		/// <summary>
		/// Tries the validate null.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="message">The message.</param>
		/// <param name="throwException">if set to <c>true</c> [throw exception].</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		[Information(nameof(TryValidateNull), "David McCarter", "2/10/2021", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
		public static bool TryValidateNull(object value, [NotNull] string message, bool throwException = false)
		{
			if (( value is null ) && throwException)
			{
				ExceptionThrower.ThrowInvalidValueException(message, value);
			}

			return value is null;
		}

		/// <summary>
		/// Tries the validate an object.
		/// </summary>
		/// <typeparam name="TException">The type of the TException.</typeparam>
		/// <param name="condition">if set to <c>true</c> [condition].</param>
		/// <param name="message">The message.</param>
		[DoesNotReturn]
		[Information(nameof(TryValidateObject), "David McCarter", "2/1/2021", UnitTestCoverage = 99, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
		public static void TryValidateObject<TException>(bool condition, string message = "")
			where TException : Exception, new()
		{
			if (string.Equals(typeof(TException).Name, nameof(Exception), StringComparison.Ordinal))
			{
				ExceptionThrower.ThrowArgumentInvalidException(
					"Exception is not allowed to be used for this method. Please choose a more detailed Exception type.",
					nameof(TException));
			}

			if (condition is false)
			{
				message = CreateExceptionMessage(message, Resources.ObjectValidationFailed);

				var ex = Activator.CreateInstance(typeof(TException), message).As<TException>();

				throw ex;
			}
		}

		/// <summary>
		/// Tries the validate parameter.
		/// </summary>
		/// <typeparam name="TException">The type of the t exception.</typeparam>
		/// <param name="condition">if set to <c>true</c> [condition].</param>
		/// <param name="paramName">Name of the parameter.</param>
		/// <param name="message">The message.</param>
		[DoesNotReturn]
		[Information(nameof(TryValidateParam), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
		public static void TryValidateParam<TException>(bool condition, string paramName, string message = "")
			where TException : ArgumentException, new()
		{
			if (condition is false)
			{
				message = CreateExceptionMessage(message, Resources.ParameterIsInvalid);

				var ex = Activator.CreateInstance(typeof(TException), paramName, message).As<TException>();

				throw ex;
			}
		}

		/// <summary>
		/// Tries to validate a method parameter. Also validates that the file exists.
		/// </summary>
		/// <param name="file">The file.</param>
		/// <param name="paramName">Name of the parameter.</param>
		/// <param name="message">The message.</param>
		/// <exception cref="ArgumentNullException">File cannot be null.</exception>
		/// <exception cref="FileNotFoundException">File not not found.</exception>
		[DoesNotReturn]
		[Information(nameof(TryValidateParam), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
		public static void TryValidateParam([NotNull] FileInfo file, string paramName, string message = "")
		{
			if (file.Exists == false)
			{
				message = CreateParamExceptionMessage(message, paramName, Resources.FileNotFound);

				ExceptionThrower.ThrowFileNotFoundException(message, file.FullName);
			}
		}

		/// <summary>
		/// Tries to validate a method parameter.
		/// </summary>
		/// <param name="directory">The directory.</param>
		/// <param name="paramName">Name of the parameter.</param>
		/// <param name="message">The message.</param>
		/// <exception cref="ArgumentNullException">Directory cannot be null.</exception>
		/// <exception cref="DirectoryNotFoundException">Directory not found.</exception>
		[DoesNotReturn]
		[Information(nameof(TryValidateParam), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
		public static void TryValidateParam([NotNull] DirectoryInfo directory, string paramName, string message = "")
		{
			if (directory.Exists == false)
			{
				message = CreateParamExceptionMessage(message, paramName, Resources.DirectoryDoesNotExist);

				ExceptionThrower.ThrowDirectoryNotFoundException(message, directory?.FullName);
			}
		}

		/// <summary>
		/// Tries the validate parameter. Ensures ReadOnlySpan is not empty.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="span">The array.</param>
		/// <param name="paramName">Name of the parameter.</param>
		/// <param name="message">The message.</param>
		[DoesNotReturn]
		[Information(nameof(TryValidateParam), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
		public static void TryValidateParam<T>([NotNull] ReadOnlySpan<T> span, string paramName, string message = "")
		{
			if (span.IsEmpty)
			{
				message = CreateExceptionMessage(message, Resources.ReadOnlySpanCannotBeNull);

				ExceptionThrower.ThrowArgumentNullException(message, paramName);
			}
		}

		/// <summary>
		/// Tries the validate parameter. Ensures that Span is not empty.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="span">The span.</param>
		/// <param name="paramName">Name of the parameter.</param>
		/// <param name="message">The message.</param>
		[DoesNotReturn]
		[Information(nameof(TryValidateParam), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
		public static void TryValidateParam<T>([NotNull] Span<T> span, string paramName, string message = "")
		{
			if (span.IsEmpty)
			{
				message = CreateExceptionMessage(message, Resources.SpanCannotBeNullOrEmpty);

				ExceptionThrower.ThrowArgumentNullException(message, paramName);
			}
		}

		/// <summary>
		/// Tries to validate a method parameter.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="paramName">Name of the parameter.</param>
		/// <param name="message">The message.</param>
		/// <exception cref="ArgumentOutOfRangeException">The value is not defined in the enum type.</exception>
		[DoesNotReturn]
		[Information(nameof(TryValidateParam), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
		public static void TryValidateParam([NotNull] Enum value, string paramName, string message = "")
		{
			if (Enum.IsDefined(value.GetType(), value) == false)
			{
				message = CreateExceptionMessage(message, Resources.TheValueIsNotDefinedInTheEnumeration);

				ExceptionThrower.ThrowArgumentOutOfRangeException(paramName, message);
			}
		}

		/// <summary>
		/// Tries to validate a method parameter. Ensures Guid is not empty.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="paramName">Name of the parameter.</param>
		/// <param name="message">The message.</param>
		/// <exception cref="ArgumentInvalidException">Guid cannot be empty.</exception>
		[DoesNotReturn]
		[Information(nameof(TryValidateParam), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
		public static void TryValidateParam([NotNull] Guid value, string paramName, string message = "")
		{
			if (value.Equals(Guid.Empty))
			{
				message = CreateExceptionMessage(message, Resources.GuidIsEmpty);

				ExceptionThrower.ThrowArgumentInvalidException(message, paramName);
			}
		}

		/// <summary>
		/// Tries the validate parameter.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="paramName">Name of the parameter.</param>
		/// <param name="message">The message.</param>
		/// <exception cref="ArgumentInvalidException"></exception>
		[DoesNotReturn]
		[Information(nameof(TryValidateParam), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
		public static void TryValidateParam(Uri value, string paramName, string message = "")
		{
			if (Validate.TryValidateNull(value))
			{
				message = CreateExceptionMessage(message, Resources.UriCannotBeNull);

				ExceptionThrower.ThrowArgumentInvalidException(message, paramName);
			}
		}

		/// <summary>
		/// Tries to validate a method parameter.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="paramName">Name of the parameter.</param>
		/// <param name="message">The message.</param>
		/// <exception cref="ArgumentNullException">Value cannot be null.</exception>
		[DoesNotReturn]
		[Information(nameof(TryValidateParam), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
		public static void TryValidateParam(string value, string paramName, string message = "")
		{
			if (string.IsNullOrEmpty(value))
			{
				message = CreateExceptionMessage(message, Resources.StringIsEmpty);

				ExceptionThrower.ThrowArgumentNullException(message, paramName);
			}
		}

		/// <summary>
		/// Tries to validate a method parameter. Ensures the collection has items.
		/// </summary>
		/// <param name="collection">The collection.</param>
		/// <param name="paramName">Name of the parameter.</param>
		/// <param name="message">The message.</param>
		/// <exception cref="ArgumentNullException">Collection is null or has no items.</exception>
		[DoesNotReturn]
		[Information(nameof(TryValidateParam), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
		public static void TryValidateParam([NotNull] IEnumerable collection, string paramName, string message = "")
		{
			if (collection.Count() == 0)
			{
				message = CreateExceptionMessage(message, Resources.CollectionIsNullOrHasNoItems);
				ExceptionThrower.ThrowArgumentNullException(message, paramName);
			}
		}

		/// <summary>
		/// Tries to validate a method parameter.
		/// </summary>
		/// <param name="collection">The collection.</param>
		/// <param name="size">The size.</param>
		/// <param name="paramName">Name of the parameter.</param>
		/// <param name="message">The message.</param>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <exception cref="ArgumentNullException">Collection does not match size.</exception>
		[DoesNotReturn]
		[Information(nameof(TryValidateParam), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
		public static void TryValidateParam(IEnumerable collection, int size, string paramName, string message = "")
		{
			TryValidateParam(collection, paramName, message);

			if (collection.Count() != size)
			{
				message = CreateExceptionMessage(message, Resources.CollectionSizeIsNotValid);

				ExceptionThrower.ThrowArgumentOutOfRangeException(paramName, message);
			}
		}

		/// <summary>
		/// Tries to validate a method parameter.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="match">The match.</param>
		/// <param name="paramName">Name of the parameter.</param>
		/// <param name="message">The message.</param>
		/// <exception cref="ArgumentNullException">match</exception>
		/// <exception cref="ArgumentInvalidException"></exception>
		[DoesNotReturn]
		[Information(nameof(TryValidateParam), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
		public static void TryValidateParam(string value, [NotNull] Regex match, string paramName, string message = "")
		{
			TryValidateParam(value, paramName, message);

			if (match.IsMatch(value) == false)
			{
				message = CreateExceptionMessage(message, Resources.StringIsNotValid);

				ExceptionThrower.ThrowArgumentInvalidException(message, paramName);
			}
		}

		/// <summary>
		/// Tries to validate a method parameter.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="expectedType">The expected type.</param>
		/// <param name="paramName">Name of the parameter.</param>
		/// <param name="message">The message.</param>
		/// <exception cref="ArgumentInvalidException"></exception>
		[DoesNotReturn]
		[Information(nameof(TryValidateParam), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
		public static void TryValidateParam([NotNull] Type value, [NotNull] Type expectedType, string paramName, string message = "")
		{
			if (value != expectedType)
			{
				message = CreateExceptionMessage(message, Resources.InvalidType);

				ExceptionThrower.ThrowArgumentInvalidException(message, paramName);
			}
		}

		/// <summary>
		/// Tries the validate an integer value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="minimumValue">The minimum value.</param>
		/// <param name="maximumValue">The maximum value.</param>
		/// <param name="paramName">Name of the parameter.</param>
		/// <param name="message">The error message.</param>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		[DoesNotReturn]
		[Information(nameof(TryValidateParam), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
		public static void TryValidateParam(int value, int minimumValue = int.MinValue, int maximumValue = int.MaxValue, string paramName = "", string message = "")
		{
			if (value.IsInRange(minimumValue, maximumValue) == false)
			{
				message = CreateExceptionMessage(message, Resources.NumberNotInRange);

				ExceptionThrower.ThrowArgumentOutOfRangeException(paramName, message);
			}
		}

		/// <summary>
		/// Tries the validate a <see cref="double"/> parameter.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="minimumValue">The minimum value.</param>
		/// <param name="maximumValue">The maximum value.</param>
		/// <param name="paramName">Name of the parameter.</param>
		/// <param name="message">The message.</param>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		[DoesNotReturn]
		[Information(nameof(TryValidateParam), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
		public static void TryValidateParam(double value, double minimumValue = double.MinValue, double maximumValue = double.MaxValue, string paramName = "", string message = "")
		{
			if (value.IsInRange(minimumValue, maximumValue) == false)
			{
				message = CreateExceptionMessage(message, Resources.NumberNotInRange);

				ExceptionThrower.ThrowArgumentOutOfRangeException(paramName, message);
			}
		}

		/// <summary>
		/// Tries the validate a <see cref="long"/> parameter.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="minimumValue">The minimum value.</param>
		/// <param name="maximumValue">The maximum value.</param>
		/// <param name="paramName">Name of the parameter.</param>
		/// <param name="message">The message.</param>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		[DoesNotReturn]
		[Information(nameof(TryValidateParam), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
		public static void TryValidateParam(long value, long minimumValue = long.MinValue, long maximumValue = long.MaxValue, string paramName = "", string message = "")
		{
			if (value.IsInRange(minimumValue, maximumValue) == false)
			{
				message = CreateExceptionMessage(message, Resources.NumberNotInRange);

				ExceptionThrower.ThrowArgumentOutOfRangeException(paramName, message);
			}
		}

		/// <summary>
		/// Tries the validate a <see cref="decimal"/> parameter.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="minimumValue">The minimum value.</param>
		/// <param name="maximumValue">The maximum value.</param>
		/// <param name="paramName">Name of the parameter.</param>
		/// <param name="message">The message.</param>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		[DoesNotReturn]
		[Information(nameof(TryValidateParam), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
		public static void TryValidateParam(decimal value, decimal minimumValue, decimal maximumValue, string paramName, string message = "")
		{
			if (value.IsInRange(minimumValue, maximumValue) == false)
			{
				message = CreateExceptionMessage(message, Resources.NumberNotInRange);

				ExceptionThrower.ThrowArgumentOutOfRangeException(paramName, message);
			}
		}

		/// <summary>
		/// Tries to validate a method parameter.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="minimumLength">The minimum length.</param>
		/// <param name="maximumLength">The maximum length.</param>
		/// <param name="paramName">Name of the parameter.</param>
		/// <param name="message">The message.</param>
		/// <exception cref="ArgumentInvalidException">Value cannot be null.</exception>
		/// <exception cref="ArgumentOutOfRangeException">Minimum length is not valid.</exception>
		/// <exception cref="ArgumentOutOfRangeException">Maximum length is not valid.</exception>
		/// <exception cref="ArgumentOutOfRangeException">Value is not within range.</exception>
		[DoesNotReturn]
		[Information(nameof(TryValidateParam), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
		public static void TryValidateParam(string value, int minimumLength, int maximumLength, string paramName, string message = "")
		{
			TryValidateParam(value, paramName, message);
			TryValidateParam(minimumLength, 0, int.MaxValue, nameof(minimumLength));
			TryValidateParam(maximumLength, 1, int.MaxValue, nameof(minimumLength));

			if (value.Length.IsInRange(minimumLength, maximumLength) == false)
			{
				message = CreateExceptionMessage(
					message,
					string.Format(
						CultureInfo.CurrentCulture,
						Resources.InvalidStringLengthAcceptableRange,
						minimumLength,
						maximumLength));

				ExceptionThrower.ThrowArgumentOutOfRangeException(paramName, message);
			}
		}

		/// <summary>
		/// Tries the validate a <see cref="string"/> parameter.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="stringType">Type of the string.</param>
		/// <param name="minimumLength">The minimum length.</param>
		/// <param name="maximumLength">The maximum length.</param>
		/// <param name="paramName">Name of the parameter.</param>
		/// <param name="message">The message.</param>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <exception cref="ArgumentInvalidException"></exception>
		/// <exception cref="ArgumentInvalidException"></exception>
		/// <exception cref="ArgumentNullException">Value cannot be null or empty.</exception>
		/// <exception cref="ArgumentOutOfRangeException">StringType is invalid.</exception>
		[DoesNotReturn]
		[Information(nameof(TryValidateParam), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
		public static void TryValidateParam(string value, StringType stringType, int minimumLength, int maximumLength, string paramName, string message = "")
		{
			//TODO: Add more string types.
			TryValidateParam(value, paramName, message);
			TryValidateParam(stringType, nameof(stringType), Resources.InvalidStringType);

			if (value.Length.IsInRange(minimumLength, maximumLength) == false)
			{
				message = CreateExceptionMessage(
					message,
					string.Format(
						CultureInfo.CurrentCulture,
						Resources.InvalidStringLengthAcceptableRange,
						minimumLength,
						maximumLength));

				ExceptionThrower.ThrowArgumentOutOfRangeException(paramName, message);
			}


			// Final string validation
			switch (stringType)
			{
				case StringType.Email:
					if (value.IsEmailAddress() == false)
					{
						message = CreateExceptionMessage(message, Resources.InvalidEmailAddress);

						ExceptionThrower.ThrowArgumentInvalidException(message, paramName);
					}

					break;
				case StringType.Url:
					if (value.IsUrl() == false)
					{
						message = CreateExceptionMessage(message, Resources.InvalidUrlAddress);

						ExceptionThrower.ThrowArgumentInvalidException(message, paramName);
					}

					break;
				case StringType.NotSet:
					break;
				default:
					break;
			}
		}

		/// <summary>
		/// Tries the validate a string value.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <param name="throwException">if set to <c>true</c> [throw exception].</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		/// <exception cref="InvalidValueException{String}">String cannot be null or empty.</exception>
		[Information(nameof(TryValidateValue), "David McCarter", "2/10/2021", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
		public static bool TryValidateValue(string input, bool throwException = false)
		{
			var result = string.IsNullOrEmpty(input);

			if (result is true && throwException)
			{
				ExceptionThrower.ThrowInvalidValueException(Resources.StringIsNotValid, input);
			}

			return result;
		}

		/// <summary>
		/// Tries the validate value.
		/// </summary>
		/// <typeparam name="TValue">The type of the t value.</typeparam>
		/// <param name="input">The value.</param>
		/// <param name="condition">if set to <c>true</c> [condition].</param>
		/// <param name="message">The message.</param>
		/// <param name="throwException">if set to <c>true</c> [throw exception].</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		[Information(nameof(TryValidateValue), "David McCarter", "2/10/2021", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
		public static bool TryValidateValue<TValue>(
			TValue input,
			bool condition,
			string message = "",
			 bool throwException = false)
		{
			if (condition is false && throwException)
			{
				message = CreateExceptionMessage(message, Resources.InvalidValue);
				ExceptionThrower.ThrowInvalidValueException<object>(message, input);
			}

			return condition;
		}
	}
}
