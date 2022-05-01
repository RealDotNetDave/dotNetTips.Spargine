// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core
// Author           : David McCarter
// Created          : 06-26-2017
//
// Last Modified By : David McCarter
// Last Modified On : 04-26-2022
// ***********************************************************************
// <copyright file="Validator.Check.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Methods to validate parameters and values.</summary>
// ***********************************************************************
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core.Properties;

#nullable enable

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core
{
	/// <summary>
	/// Class to validate method parameters.
	/// </summary>
	public static partial class Validator
	{
		/// <summary>
		/// Creates the exception message.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="messageFromResource">The message from resource.</param>
		/// <returns>System.String.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string CreateExceptionMessage(in string message, in string messageFromResource)
		{
			return string.IsNullOrEmpty(message) ? messageFromResource : message;
		}

		/// <summary>
		/// Tries the validate input.
		/// </summary>
		/// <typeparam name="T">The type of the t value.</typeparam>
		/// <param name="input">The value to validate.</param>
		/// <param name="condition">if set to <c>true</c> [condition].</param>
		/// <param name="throwException">if set to <c>true</c> [throws exception].</param>
		/// <param name="errorMessage">The error message to be used in the Exception message.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		[Information(nameof(CheckIsCondition), "David McCarter", "2/10/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "ADD LINK TO VALIDATION ARTICLE")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool CheckIsCondition<T>(this T input, bool condition, in bool throwException = false, in string errorMessage = "")
		{
			var isValid = input is not null && condition;

			if (isValid is false && throwException)
			{
				ExceptionThrower.ThrowInvalidValueException<object>(CreateExceptionMessage(errorMessage, Resources.ErrorInvalidValue), input!);
			}

			return isValid;
		}

		/// <summary>
		/// Checks to insure <see cref="Type" />s are the same.
		/// </summary>
		/// <param name="input">The <see cref="Type" /> to validate.</param>
		/// <param name="expectedType">The expected type.</param>
		/// <param name="throwException">if set to <c>true</c> [throws exception].</param>
		/// <param name="errorMessage">The error message to be used in the Exception message.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		[Information(nameof(CheckEquals), "David McCarter", "1/31/2022", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.New, Documentation = "ADD LINK TO VALIDATION ARTICLE")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool CheckEquals(this Type input, Type expectedType, in bool throwException = false, in string errorMessage = "")
		{
			var isValid = ( input is not null ) && ( expectedType != null ) && ( input == expectedType );

			if (isValid is false && throwException)
			{
				ExceptionThrower.ThrowInvalidValueException(CreateExceptionMessage(errorMessage, Resources.ErrorInvalidType), expectedType);
			}

			return isValid;
		}

		/// <summary>
		/// Checks if <see cref="DirectoryInfo" /> directory exists. Creates path if it does not exist.
		/// </summary>
		/// <param name="input">The <see cref="DirectoryInfo" /> directory to validate.</param>
		/// <param name="throwException">if set to <c>true</c> [throws exception].</param>
		/// <param name="errorMessage">The error message to be used in the Exception message.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		[Information(nameof(CheckExists), "David McCarter", "1/31/2022", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.New, Documentation = "ADD LINK TO VALIDATION ARTICLE")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool CheckExists(this DirectoryInfo input, in bool throwException = false, in string errorMessage = "")
		{
			var isValid = input is not null && input.Exists;

			if (isValid is false && throwException)
			{
				ExceptionThrower.ThrowDirectoryNotFoundException(CreateExceptionMessage(errorMessage, input!.FullName), input);
			}
			else if (isValid is false)
			{
				input!.Create();

				isValid = true;
			}

			return isValid;
		}

		/// <summary>
		/// Checks to see if the <see cref="FileInfo" /> file exists.
		/// </summary>
		/// <param name="input">The <see cref="FileInfo" /> file.</param>
		/// <param name="throwException">if set to <c>true</c> [throws exception].</param>
		/// <param name="errorMessage">The error message to be used in the Exception message.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		[Information(nameof(CheckExists), "David McCarter", "1/31/2022", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.New, Documentation = "ADD LINK TO VALIDATION ARTICLE")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool CheckExists(this FileInfo input, in bool throwException = false, in string errorMessage = "")
		{
			var isValid = input is not null && input.Exists;

			if (isValid is false && throwException)
			{
				ExceptionThrower.ThrowFileNotFoundException(CreateExceptionMessage(errorMessage, Resources.ErrorFileNotFound), input!.FullName);
			}

			return isValid;
		}

		/// <summary>
		/// Checks to see if the <see cref="Enum" /> is defined.
		/// </summary>
		/// <param name="input">The <see cref="Enum" /> to validate.</param>
		/// <param name="throwException">if set to <c>true</c> [throws exception].</param>
		/// <param name="errorMessage">The error message to be used in the Exception message.</param>
		/// <returns><c>true</c> if the specified throw exception is defined; otherwise, <c>false</c>.</returns>
		[Information(nameof(CheckIsDefined), "David McCarter", "1/31/2022", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.New, Documentation = "ADD LINK TO VALIDATION ARTICLE")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool CheckIsDefined(this Enum input, in bool throwException = false, in string errorMessage = "")
		{
			var isValid = input is not null && Enum.IsDefined(input.GetType(), input);

			if (isValid is false && throwException)
			{
				ExceptionThrower.ThrowInvalidValueException(CreateExceptionMessage(errorMessage, Resources.ErrorEnumNotDefined), input);
			}

			return isValid;
		}

		/// <summary>
		/// Checks that the <see cref="DateTime" /> is in range.
		/// </summary>
		/// <param name="input">The <see cref="DateTime" /> to validate.</param>
		/// <param name="lower">The minimum <see cref="DateTime" />.</param>
		/// <param name="upper">The maximum <see cref="DateTime" />.</param>
		/// <param name="throwException">if set to <c>true</c> [throws exception].</param>
		/// <param name="errorMessage">The error message to be used in the Exception message.</param>
		/// <returns>DateTime.</returns>
		[Information(nameof(CheckIsInRange), "David McCarter", "1/31/2022", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.New, Documentation = "ADD LINK TO VALIDATION ARTICLE")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool CheckIsInRange(this in DateTime input, in DateTime lower, in DateTime upper, in bool throwException = false, in string errorMessage = "")
		{
			var isValid = ( input >= lower ) && ( input <= upper );

			if (isValid is false && throwException)
			{
				ExceptionThrower.ThrowInvalidValueException(CreateExceptionMessage(errorMessage, Resources.ErrorDateIsInvalidBasedOnMinMaxDateTime), input);
			}

			return isValid;
		}

		/// <summary>
		/// Checks that the <see cref="TimeOnly" /> in range.
		/// </summary>
		/// <param name="input">The <see cref="TimeOnly" /> to validate.</param>
		/// <param name="lower">The minimum <see cref="TimeOnly" />.</param>
		/// <param name="upper">The maximum <see cref="TimeOnly" />.</param>
		/// <param name="throwException">if set to <c>true</c> [throws exception].</param>
		/// <param name="errorMessage">The error message to be used in the Exception message.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		[Information(nameof(CheckIsInRange), "David McCarter", "2/14/2022", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.New, Documentation = "ADD LINK TO VALIDATION ARTICLE")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool CheckIsInRange(this in TimeOnly input, in TimeOnly lower, in TimeOnly upper, in bool throwException = false, in string errorMessage = "")
		{
			var isValid = ( input >= lower ) && ( input <= upper );

			if (isValid is false && throwException)
			{
				ExceptionThrower.ThrowInvalidValueException(CreateExceptionMessage(errorMessage, Resources.ErrorTimeIsInvalidBasedOnTheMinMaxRange), input);
			}

			return isValid;
		}

		/// <summary>
		/// Checks the is in range.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <param name="lower">The minimum.</param>
		/// <param name="upper">The maximum.</param>
		/// <param name="throwException">if set to <c>true</c> [throws exception].</param>
		/// <param name="errorMessage">The error message to be used in the Exception message.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		[Information(nameof(CheckIsInRange), "David McCarter", "2/14/2022", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.New, Documentation = "ADD LINK TO VALIDATION ARTICLE")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool CheckIsInRange(this in DateOnly input, in DateOnly lower, in DateOnly upper, in bool throwException = false, in string errorMessage = "")
		{
			var isValid = ( input >= lower ) && ( input <= upper );

			if (!isValid && throwException)
			{
				ExceptionThrower.ThrowInvalidValueException(CreateExceptionMessage(errorMessage, Resources.ErrorDateIsInvalidBasedOnTheMinMaxRange), input);
			}

			return isValid;
		}

		/// <summary>
		/// Checks that the <see cref="int" /> is in range.
		/// </summary>
		/// <param name="input">The <see cref="int" /> to validate.</param>
		/// <param name="lower">The minimum <see cref="int" />.</param>
		/// <param name="upper">The maximum <see cref="int" />.</param>
		/// <param name="throwException">if set to <c>true</c> [throws exception].</param>
		/// <param name="errorMessage">The error message to be used in the Exception message.</param>
		/// <returns>System.Int32.</returns>
		[Information(nameof(CheckIsInRange), "David McCarter", "2/3/2022", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.New, Documentation = "ADD LINK TO VALIDATION ARTICLE")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool CheckIsInRange(this in int input, in int lower, in int upper, in bool throwException = false, in string errorMessage = "")
		{
			var isValid = ( input >= lower ) && ( input <= upper );

			if (isValid is false && throwException)
			{
				ExceptionThrower.ThrowInvalidValueException(CreateExceptionMessage(errorMessage, Resources.ErrorNumberIsInvalidBasedOnTheMinMaxValue), input);
			}

			return isValid;
		}

		/// <summary>
		/// Checks that the <see cref="long" /> is in range.
		/// </summary>
		/// <param name="input">The <see cref="long" /> to validate.</param>
		/// <param name="lower">The minimum <see cref="long" />.</param>
		/// <param name="upper">The maximum <see cref="long" />.</param>
		/// <param name="throwException">if set to <c>true</c> [throws exception].</param>
		/// <param name="errorMessage">The error message to be used in the Exception message.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		[Information(nameof(CheckIsInRange), "David McCarter", "2/14/2022", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.New, Documentation = "ADD LINK TO VALIDATION ARTICLE")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool CheckIsInRange(this in long input, in long lower, in long upper, in bool throwException = false, in string errorMessage = "")
		{
			var isValid = ( input >= lower ) && ( input <= upper );

			if (isValid is false && throwException)
			{
				ExceptionThrower.ThrowInvalidValueException(CreateExceptionMessage(errorMessage, Resources.ErrorNumberIsInvalidBasedOnTheMinMaxValue), input);
			}

			return isValid;
		}

		/// <summary>
		/// Checks that the <see cref="double" /> is in range.
		/// </summary>
		/// <param name="input">The <see cref="double" /> to validate.</param>
		/// <param name="lower">The minimum <see cref="double" />.</param>
		/// <param name="upper">The maximum <see cref="double" />.</param>
		/// <param name="throwException">if set to <c>true</c> [throws exception].</param>
		/// <param name="errorMessage">The errorMessage.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		[Information(nameof(CheckIsInRange), "David McCarter", "2/14/2022", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.New, Documentation = "ADD LINK TO VALIDATION ARTICLE")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool CheckIsInRange(this in double input, in double lower, in double upper, in bool throwException = false, in string errorMessage = "")
		{
			var isValid = ( input >= lower ) && ( input <= upper );

			if (isValid is false && throwException)
			{
				ExceptionThrower.ThrowInvalidValueException(CreateExceptionMessage(errorMessage, Resources.ErrorNumberIsInvalidBasedOnTheMinMaxValue), input);
			}

			return isValid;
		}

		/// <summary>
		/// Checks that the <see cref="decimal" /> is in range.
		/// </summary>
		/// <param name="input">The <see cref="decimal" /> to validate.</param>
		/// <param name="lower">The minimum <see cref="decimal" />.</param>
		/// <param name="upper">The maximum <see cref="decimal" />.</param>
		/// <param name="throwException">if set to <c>true</c> [throws exception].</param>
		/// <param name="errorMessage">The error message to be used in the Exception message.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		[Information(nameof(CheckIsInRange), "David McCarter", "2/14/2022", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.New, Documentation = "ADD LINK TO VALIDATION ARTICLE")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool CheckIsInRange(this in decimal input, in decimal lower, in decimal upper, in bool throwException = false, in string errorMessage = "")
		{
			var isValid = ( input >= lower ) && ( input <= upper );

			if (isValid is false && throwException)
			{
				ExceptionThrower.ThrowInvalidValueException(CreateExceptionMessage(errorMessage, Resources.ErrorNumberIsInvalidBasedOnTheMinMaxValue), input);
			}

			return isValid;
		}

		/// <summary>
		/// Checks that the <see cref="DateTimeOffset" /> is in range.
		/// </summary>
		/// <param name="input">The <see cref="DateTimeOffset" /> to validate.</param>
		/// <param name="lower">The minimum <see cref="DateTimeOffset" />.</param>
		/// <param name="upper">The maximum <see cref="DateTimeOffset" />.</param>
		/// <param name="throwException">if set to <c>true</c> [throws exception].</param>
		/// <param name="errorMessage">The error message to be used in the Exception message.</param>
		/// <returns>DateTimeOffset.</returns>
		[Information(nameof(CheckIsInRange), "David McCarter", "1/31/2022", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.New, Documentation = "ADD LINK TO VALIDATION ARTICLE")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool CheckIsInRange(this in DateTimeOffset input, in DateTimeOffset lower, in DateTimeOffset upper, in bool throwException = false, in string errorMessage = "")
		{
			var isValid = ( input >= lower ) && ( input <= upper );

			if (isValid is false && throwException)
			{
				ExceptionThrower.ThrowInvalidValueException(CreateExceptionMessage(errorMessage, Resources.ErrorDateIsInvalidBasedOnMinMaxDateTime), input);
			}

			return isValid;
		}

		/// <summary>
		/// Determines whether the <see cref="ReadOnlySpan{T}" /> is not empty.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="input">The <see cref="ReadOnlySpan{T}" /> to validate.</param>
		/// <param name="throwException">if set to <c>true</c> [throws exception].</param>
		/// <param name="errorMessage">The error message to be used in the Exception message.</param>
		/// <returns><c>true</c> if [is not empty] [the specified span]; otherwise, <c>false</c>.</returns>
		[Information(nameof(CheckIsNotEmpty), "David McCarter", "6/26/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.New, Documentation = "ADD LINK TO VALIDATION ARTICLE")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool CheckIsNotEmpty<T>(this in ReadOnlySpan<T> input, in bool throwException = false, in string errorMessage = "")
		{
			var isValid = input.IsEmpty is false;

			if (isValid is false && throwException)
			{
				ExceptionThrower.ThrowInvalidOperationException(CreateExceptionMessage(errorMessage, Resources.ErrorSpanIsEmpty));
			}

			return isValid;
		}

		/// <summary>
		/// Checks that the <see cref="Guid" /> is not empty.
		/// </summary>
		/// <param name="input">The <see cref="Guid" /> to validate.</param>
		/// <param name="throwException">if set to <c>true</c> [throws exception].</param>
		/// <param name="errorMessage">The error message to be used in the Exception message.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		[Information(nameof(CheckIsNotEmpty), "David McCarter", "2/2/2022", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.New, Documentation = "ADD LINK TO VALIDATION ARTICLE")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool CheckIsNotEmpty(this in Guid input, in bool throwException = false, in string errorMessage = "")
		{
			var isValid = input.Equals(Guid.Empty) is false;

			if (isValid is false && throwException)
			{
				ExceptionThrower.ThrowInvalidOperationException(CreateExceptionMessage(errorMessage, Resources.ErrorGUIDIsEmpty));
			}

			return isValid;
		}

		/// <summary>
		/// Checks that the input is not <see langword="null" />.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="input">The value to validate.</param>
		/// <param name="throwException">if set to <c>true</c> [throws exception].</param>
		/// <param name="errorMessage">The error message to be used in the Exception message.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		[Information(nameof(CheckIsNotNull), "David McCarter", "2/10/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Updated, Documentation = "ADD LINK TO VALIDATION ARTICLE")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool CheckIsNotNull<T>(this T input, in bool throwException = false, in string errorMessage = "") where T : class
		{
			var isValid = input != null;

			if (isValid is false && throwException)
			{
				ExceptionThrower.ThrowInvalidValueException(CreateExceptionMessage(errorMessage, Resources.ErrorObjectCannotBeNull), input);
			}

			return isValid;
		}

		/// <summary>
		/// Checks the <see cref="IEnumerable{T}" /> exists.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="input">The <see cref="IEnumerable{T}" /> to validate.</param>
		/// <param name="throwException">if set to <c>true</c> [throw exception].</param>
		/// <param name="errorMessage">The error message.</param>
		/// <returns>IEnumerable&lt;T&gt;.</returns>
		[Information(nameof(CheckItemsExists), "David McCarter", "4/14/2022", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.New, Documentation = "ADD LINK TO VALIDATION ARTICLE")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool CheckItemsExists<T>(this IEnumerable<T> input, in bool throwException = false, in string errorMessage = "")
		{
			var isValid = input is not null && input.TryGetNonEnumeratedCount(out var collectionCount) && collectionCount > 0;

			if (isValid is false && throwException)
			{
				ExceptionThrower.ThrowInvalidValueException(CreateExceptionMessage(errorMessage, Resources.ErrorCollectionIsNullOrHasNoItems), input);
			}

			return isValid;
		}
	}
}
