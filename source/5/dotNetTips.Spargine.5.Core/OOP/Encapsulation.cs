// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core
// Author           : David McCarter
// Created          : 06-26-2017
//
// Last Modified By : David McCarter
// Last Modified On : 01-16-2021
// ***********************************************************************
// <copyright file="Encapsulation.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Methods to validate parameters.</summary>
// ***********************************************************************
using System;
using System.Collections;
using System.IO;
using System.Text.RegularExpressions;
using dotNetTips.Spargine.Core.Properties;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Core.OOP
{
	/// <summary>
	/// Class to validate method parameters.
	/// </summary>
	public static class Encapsulation
	{
		/// <summary>
		/// Tries the validate if the object is null.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="paramName">Name of the parameter.</param>
		/// <param name="message">The message.</param>
		/// <exception cref="ArgumentNullException">Value cannot be null.</exception>
		[Information(nameof(TryValidateNullParam), "David McCarter", "1/8/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.New)]
		public static void TryValidateNullParam(object value, string paramName, string message = "")
		{
			if (value is null)
			{
				message = CreateExceptionMessage(message, Resources.ParameterCannotBeNull);

				ExceptionThrower.ThrowArgumentNullException(message, paramName);
			}
		}

		/// <summary>
		/// Tries the validate parameter.
		/// </summary>
		/// <typeparam name="TException">The type of the t exception.</typeparam>
		/// <param name="condition">if set to <c>true</c> [condition].</param>
		/// <param name="paramName">Name of the parameter.</param>
		/// <param name="message">The message.</param>
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
		/// Tries to validate a method parameter.
		/// </summary>
		/// <param name="collection">The collection.</param>
		/// <param name="paramName">Name of the parameter.</param>
		/// <param name="message">The message.</param>
		/// <exception cref="ArgumentNullException">Collection is null or has no items.</exception>
		[Information(nameof(TryValidateParam), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
		public static void TryValidateParam(IEnumerable collection, string paramName, string message = "")
		{
			if (collection is null || collection.Count() == 0)
			{
				message = CreateExceptionMessage(message, Resources.CollectionIsNullOrHasNoItems);
				ExceptionThrower.ThrowArgumentNullException(message, paramName);
			}
		}

		/// <summary>
		/// Tries to validate a method parameter.
		/// </summary>
		/// <param name="file">The file.</param>
		/// <param name="paramName">Name of the parameter.</param>
		/// <param name="message">The message.</param>
		/// <exception cref="ArgumentNullException">File cannot be null.</exception>
		/// <exception cref="FileNotFoundException">File not not found.</exception>
		[Information(nameof(TryValidateParam), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
		public static void TryValidateParam(FileInfo file, string paramName, string message = "")
		{
			if (file is null)
			{
				message = CreateExceptionMessage(message, Resources.FileCannotBeNull);

				ExceptionThrower.ThrowArgumentNullException(message, paramName);
			}
			else if (file.Exists == false)
			{
				message = CreateExceptionMessage(message, Resources.FileNotFound);

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
		[Information(nameof(TryValidateParam), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
		public static void TryValidateParam(DirectoryInfo directory, string paramName, string message = "")
		{
			if (directory is null)
			{
				message = CreateExceptionMessage(message, Resources.DirectoryCannotBeNull);

				ExceptionThrower.ThrowArgumentNullException(message, paramName);
			}
			else if (directory.Exists == false)
			{
				message = CreateExceptionMessage(message, Resources.DirectoryDoesNotExist);

				ExceptionThrower.ThrowDirectoryNotFoundException(message, directory?.FullName);
			}
		}

		/// <summary>
		/// Tries to validate a method parameter.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="paramName">Name of the parameter.</param>
		/// <param name="message">The message.</param>
		/// <exception cref="ArgumentOutOfRangeException">The value is not defined in the enum type.</exception>
		[Information(nameof(TryValidateParam), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
		public static void TryValidateParam(Enum value, string paramName, string message = "")
		{
			if (Enum.IsDefined(value.GetType(), value) == false)
			{
				message = CreateExceptionMessage(message, Resources.TheValueIsNotDefinedInTheEnumeration);

				ExceptionThrower.ThrowArgumentOutOfRangeException(message, paramName);
			}
		}

		/// <summary>
		/// Tries to validate a method parameter.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="paramName">Name of the parameter.</param>
		/// <param name="message">The message.</param>
		/// <exception cref="ArgumentInvalidException">Guid cannot be empty.</exception>
		[Information(nameof(TryValidateParam), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
		public static void TryValidateParam(Guid value, string paramName, string message = "")
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
		[Information(nameof(TryValidateParam), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
		public static void TryValidateParam(Uri value, string paramName, string message = "")
		{
			if (value is null)
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
		/// Tries to validate a method parameter.
		/// </summary>
		/// <param name="collection">The collection.</param>
		/// <param name="size">The size.</param>
		/// <param name="paramName">Name of the parameter.</param>
		/// <param name="message">The message.</param>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		/// <exception cref="ArgumentNullException">Collection does not match size.</exception>
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
		[Information(nameof(TryValidateParam), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
		public static void TryValidateParam(string value, Regex match, string paramName, string message = "")
		{
			if (match is null)
			{
				ExceptionThrower.ThrowArgumentNullException(nameof(match));
			}

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
		[Information(nameof(TryValidateParam), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
		public static void TryValidateParam(Type value, Type expectedType, string paramName, string message = "")
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
		[Information(nameof(TryValidateParam), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
		public static void TryValidateParam(int value, int minimumValue = int.MinValue, int maximumValue = int.MaxValue, string paramName = "", string message = "")
		{
			if (value.IsInRange(minimumValue, maximumValue) == false)
			{
				message = CreateExceptionMessage(message, Resources.NumberNotInRange);

				ExceptionThrower.ThrowArgumentOutOfRangeException(message, paramName);
			}
		}

		/// <summary>
		/// Tries the validate a <see cref="double" /> parameter.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="minimumValue">The minimum value.</param>
		/// <param name="maximumValue">The maximum value.</param>
		/// <param name="paramName">Name of the parameter.</param>
		/// <param name="message">The message.</param>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		[Information(nameof(TryValidateParam), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
		public static void TryValidateParam(double value, double minimumValue = double.MinValue, double maximumValue = double.MaxValue, string paramName = "", string message = "")
		{
			if (value.IsInRange(minimumValue, maximumValue) == false)
			{
				message = CreateExceptionMessage(message, Resources.NumberNotInRange);

				ExceptionThrower.ThrowArgumentOutOfRangeException(message, paramName);
			}
		}

		/// <summary>
		/// Tries the validate a <see cref="long" /> parameter.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="minimumValue">The minimum value.</param>
		/// <param name="maximumValue">The maximum value.</param>
		/// <param name="paramName">Name of the parameter.</param>
		/// <param name="message">The message.</param>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		[Information(nameof(TryValidateParam), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
		public static void TryValidateParam(long value, long minimumValue = long.MinValue, long maximumValue = long.MaxValue, string paramName = "", string message = "")
		{
			if (value.IsInRange(minimumValue, maximumValue) == false)
			{
				message = CreateExceptionMessage(message, Resources.NumberNotInRange);

				ExceptionThrower.ThrowArgumentOutOfRangeException(message, paramName);
			}
		}

		/// <summary>
		/// Tries the validate a <see cref="decimal" /> parameter.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="minimumValue">The minimum value.</param>
		/// <param name="maximumValue">The maximum value.</param>
		/// <param name="paramName">Name of the parameter.</param>
		/// <param name="message">The message.</param>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		[Information(nameof(TryValidateParam), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
		public static void TryValidateParam(decimal value, decimal minimumValue, decimal maximumValue, string paramName, string message = "")
		{
			if (value.IsInRange(minimumValue, maximumValue) == false)
			{
				message = CreateExceptionMessage(message, Resources.NumberNotInRange);

				ExceptionThrower.ThrowArgumentOutOfRangeException(message, paramName);
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
		[Information(nameof(TryValidateParam), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
		public static void TryValidateParam(string value, int minimumLength, int maximumLength, string paramName, string message = "")
		{
			TryValidateParam(value, paramName, message);
			TryValidateParam(minimumLength, 0, int.MaxValue, nameof(minimumLength));
			TryValidateParam(maximumLength, 1, int.MaxValue, nameof(minimumLength));

			if (value.Length.IsInRange(minimumLength, maximumLength) == false)
			{
				message = CreateExceptionMessage(message, string.Format(Resources.InvalidStringLengthAcceptableRange, minimumLength, maximumLength));

				ExceptionThrower.ThrowArgumentOutOfRangeException(message, paramName);
			}
		}

		/// <summary>
		/// Tries the validate a <see cref="string" /> parameter.
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
		[Information(nameof(TryValidateParam), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
		public static void TryValidateParam(string value, StringType stringType, int minimumLength, int maximumLength, string paramName, string message = "")
		{
			TryValidateParam(value, paramName, message);
			TryValidateParam(stringType, nameof(stringType), Resources.InvalidStringType);

			if (value.Length.IsInRange(minimumLength, maximumLength) == false)
			{
				message = CreateExceptionMessage(message, string.Format(Resources.InvalidStringLengthAcceptableRange, minimumLength, maximumLength));

				ExceptionThrower.ThrowArgumentOutOfRangeException(message, paramName);
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
			}
		}

		/// <summary>
		/// Creates the exception message.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="messageFromResource">The message from resource.</param>
		/// <returns>System.String.</returns>
		private static string CreateExceptionMessage(string message, string messageFromResource)
		{
			if (string.IsNullOrEmpty(message))
			{
				return messageFromResource;
			}

			//TODO: THIS CONDITION NOT BEING TESTED
			return message;
		}
	}
}
