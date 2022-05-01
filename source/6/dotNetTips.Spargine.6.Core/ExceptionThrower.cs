// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core
// Author           : David McCarter
// Created          : 09-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 04-25-2022
// ***********************************************************************
// <copyright file="ExceptionThrower.cs" company="dotNetTips.Spargine.Core">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core.Properties;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core
{
	/// <summary>
	/// Exception Thrower.
	/// </summary>
	public static class ExceptionThrower
	{
		/// <summary>
		/// Defaults if null.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="defaultValue">The default value.</param>
		/// <returns>System.String.</returns>
		private static string DefaultIfNull(this string value, string defaultValue)
		{
			return value ?? defaultValue.Trim() ?? string.Empty;
		}

		/// <summary>
		/// Throws the ArgumentException.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="paramName">Name of the parameter.</param>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", Status = Status.Available)]
		public static void ThrowArgumentException(string message, string paramName)
		{
			throw new ArgumentException(message.DefaultIfNull(Resources.ErrorInvalidArgument), paramName.ArgumentNotNullOrEmpty(true));
		}

		/// <summary>
		/// Throws the ArgumentException.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="innerException">The inner exception.</param>
		/// <exception cref="ArgumentException"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", Status = Status.Available)]
		public static void ThrowArgumentException(string message, [AllowNull] Exception innerException)
		{
			throw new ArgumentException(message.DefaultIfNull(Resources.ErrorInvalidArgument), innerException);
		}

		/// <summary>
		/// Throws the ArgumentInvalidException.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="paramName">Name of the parameter.</param>
		/// <exception cref="ArgumentInvalidException"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
		[Information(nameof(ThrowArgumentInvalidException), author: "David McCarter", createdOn: "8/13/2020", Status = Status.Available)]
		public static void ThrowArgumentInvalidException(string message, string paramName)
		{
			throw new ArgumentInvalidException(message.DefaultIfNull(Resources.ErrorInvalidArgument), paramName.ArgumentNotNullOrEmpty(true));
		}

		/// <summary>
		/// Throws the ArgumentInvalidException.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="paramName">Name of the parameter.</param>
		/// <param name="innerException">The inner exception.</param>
		/// <exception cref="ArgumentInvalidException"></exception>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
		[Information(nameof(ThrowArgumentInvalidException), author: "David McCarter", createdOn: "8/13/2020", Status = Status.Available)]
		public static void ThrowArgumentInvalidException(string message, string paramName, Exception innerException)
		{
			throw new ArgumentInvalidException(message.DefaultIfNull(Resources.ErrorInvalidArgument), paramName.ArgumentNotNullOrEmpty(true), innerException);
		}

		/// <summary>
		/// Throws the argument null exception.
		/// </summary>
		/// <param name="paramName">Name of the parameter.</param>
		/// <exception cref="ArgumentNullException"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "8/12/2020", Status = Status.Available)]
		public static void ThrowArgumentNullException(string paramName)
		{
			throw new ArgumentNullException(paramName.ArgumentNotNullOrEmpty(true), Resources.ErrorArgumentNull);
		}

		/// <summary>
		/// Throws the ArgumentNullException.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="paramName">Name of the parameter.</param>
		/// <exception cref="ArgumentNullException"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", Status = Status.Available)]
		public static void ThrowArgumentNullException(string message, string paramName)
		{
			throw new ArgumentNullException(paramName.ArgumentNotNullOrEmpty(true), message.DefaultIfNull(Resources.ErrorArgumentNull));
		}

		/// <summary>
		/// Throws the ArgumentNullException.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="innerException">The inner exception.</param>
		/// <exception cref="ArgumentNullException"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", Status = Status.Available)]
		public static void ThrowArgumentNullException(string message, [AllowNull] Exception innerException)
		{
			throw new ArgumentNullException(message.DefaultIfNull(Resources.ErrorArgumentNull), innerException);
		}

		/// <summary>
		/// Throws the argument out of range exception.
		/// </summary>
		/// <param name="paramName">Name of the parameter.</param>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
		[Information(nameof(ThrowArgumentOutOfRangeException), author: "David McCarter", createdOn: "9/5/2020", Status = Status.Available)]
		public static void ThrowArgumentOutOfRangeException(string paramName)
		{
			throw new ArgumentOutOfRangeException(paramName.ArgumentNotNullOrEmpty(true), Resources.ErrorArgumentOutOfRange);
		}

		/// <summary>
		/// Throws the argument out of range exception.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="paramName">Name of the parameter.</param>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
		[Information(nameof(ThrowArgumentOutOfRangeException), author: "David McCarter", createdOn: "9/5/2020", Status = Status.Available)]
		public static void ThrowArgumentOutOfRangeException(string message, string paramName)
		{
			throw new ArgumentOutOfRangeException(paramName.ArgumentNotNullOrEmpty(true), message.DefaultIfNull(Resources.ErrorArgumentOutOfRange));
		}

		/// <summary>
		/// Throws the argument out of range exception.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="innerException">The inner exception.</param>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
		[Information(nameof(ThrowArgumentOutOfRangeException), author: "David McCarter", createdOn: "9/5/2020", Status = Status.Available)]
		public static void ThrowArgumentOutOfRangeException(string message, [AllowNull] Exception innerException)
		{
			throw new ArgumentOutOfRangeException(message.DefaultIfNull(Resources.ErrorArgumentOutOfRange), innerException);
		}

		/// <summary>
		/// Throws the ArgumentReadOnlyException.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="paramName">Name of the parameter.</param>
		/// <exception cref="ArgumentReadOnlyException"></exception>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", Status = Status.Available)]
		public static void ThrowArgumentReadOnlyCollectionException(string message, string paramName)
		{
			throw new ArgumentReadOnlyException(message.DefaultIfNull(Resources.ErrorReadOnlyCollection), paramName.ArgumentNotNullOrEmpty(true));
		}

		/// <summary>
		/// Throws the ArgumentInvalidException.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="directory">The directory.</param>
		/// <exception cref="DirectoryNotFoundException"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
		[Information(nameof(ThrowDirectoryNotFoundException), author: "David McCarter", createdOn: "8/13/2020", Status = Status.Available)]
		public static void ThrowDirectoryNotFoundException(string message, [NotNull] DirectoryInfo directory)
		{
			throw new DirectoryNotFoundException(message.DefaultIfNull(Resources.ErrorDirectoryNotFound), directory.ArgumentNotNull());
		}

		/// <summary>
		/// Throws the ArgumentInvalidException.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="innerException">The inner exception.</param>
		/// <exception cref="ArgumentInvalidException"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
		[Information(nameof(ThrowDirectoryNotFoundException), author: "David McCarter", createdOn: "8/13/2020", Status = Status.Available)]
		public static void ThrowDirectoryNotFoundException(string message, [AllowNull] Exception innerException)
		{
			throw new ArgumentInvalidException(message.DefaultIfNull(Resources.ErrorDirectoryNotFound), innerException);
		}

		/// <summary>
		/// Throws the file not found exception.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="innerException">The inner exception.</param>
		/// <exception cref="FileNotFoundException"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
		[Information(nameof(ThrowFileNotFoundException), author: "David McCarter", createdOn: "11/11/2020", Status = Status.Available)]
		public static void ThrowFileNotFoundException(string message, [AllowNull] Exception innerException)
		{
			throw new FileNotFoundException(message.DefaultIfNull(Resources.ErrorFileNotFound), innerException);
		}

		/// <summary>
		/// Throws the file not found exception.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="fileName">Name of the file.</param>
		/// <exception cref="FileNotFoundException"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
		[Information(nameof(ThrowFileNotFoundException), author: "David McCarter", createdOn: "11/11/2020", Status = Status.Available)]
		public static void ThrowFileNotFoundException(string message, string fileName)
		{
			fileName = fileName.ArgumentNotNullOrEmpty();

			throw new FileNotFoundException(message.DefaultIfNull(Resources.ErrorFileNotFound), fileName.ArgumentNotNullOrEmpty(true));
		}

		/// <summary>
		/// Throws the file not found exception.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="fileName">Name of the file.</param>
		/// <param name="innerException">The inner exception.</param>
		/// <exception cref="FileNotFoundException"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
		[Information(nameof(ThrowFileNotFoundException), author: "David McCarter", createdOn: "11/11/2020", Status = Status.Available)]
		public static void ThrowFileNotFoundException(string message, string fileName, [AllowNull] Exception innerException)
		{
			fileName = fileName.ArgumentNotNullOrEmpty();

			throw new FileNotFoundException(message.DefaultIfNull(Resources.ErrorFileNotFound), fileName.ArgumentNotNullOrEmpty(true), innerException);
		}

		/// <summary>
		/// Throws the invalid cast exception.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="paramName">Name of the parameter.</param>
		/// <exception cref="InvalidCastException"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
		[Information(nameof(ThrowInvalidCastException), author: "David McCarter", createdOn: "11/11/2020", Status = Status.Available)]
		public static void ThrowInvalidCastException(string message, string paramName)
		{
			throw new InvalidCastException($"{message.DefaultIfNull(Resources.ErrorInvalidArgument)} ParamName: {paramName.ArgumentNotNullOrEmpty(true)}");
		}


		/// <summary>
		/// Throws the invalid cast exception.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="innerException">The inner exception.</param>
		/// <exception cref="InvalidCastException"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
		[Information(nameof(ThrowInvalidCastException), author: "David McCarter", createdOn: "11/11/2020", Status = Status.Available)]
		public static void ThrowInvalidCastException(string message, [AllowNull] Exception innerException)
		{
			throw new InvalidCastException(message.DefaultIfNull(Resources.ErrorInvalidArgument), innerException);
		}

		/// <summary>
		/// Throws the invalid enum type exception.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <exception cref="InvalidEnumTypeException"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
		[Information(nameof(ThrowInvalidEnumTypeException), author: "David McCarter", createdOn: "7/30/2020", Status = Status.Available)]
		public static void ThrowInvalidEnumTypeException(string message)
		{
			throw new InvalidEnumTypeException(message.DefaultIfNull(Resources.ErrorInvalidEnumType));
		}

		/// <summary>
		/// Throws the invalid enum type exception.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="innerException">The inner exception.</param>
		/// <exception cref="InvalidCastException"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
		[Information(nameof(ThrowInvalidEnumTypeException), author: "David McCarter", createdOn: "11/11/2020", Status = Status.Available)]
		public static void ThrowInvalidEnumTypeException(string message, [AllowNull] Exception innerException)
		{
			throw new InvalidCastException(message.DefaultIfNull(Resources.ErrorInvalidEnumType), innerException);
		}

		/// <summary>
		/// Throws a InvalidOperationException.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <exception cref="InvalidOperationException"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", Status = Status.Available)]
		public static void ThrowInvalidOperationException(string message)
		{
			throw new InvalidOperationException(message.DefaultIfNull(Resources.ErrorInvalidOperation));
		}

		/// <summary>
		/// Throws a InvalidOperationException.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="innerException">The inner exception.</param>
		/// <exception cref="InvalidOperationException"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", Status = Status.Available)]
		public static void ThrowInvalidOperationException(string message, [AllowNull] Exception innerException)
		{
			throw new InvalidOperationException(message.DefaultIfNull(Resources.ErrorInvalidOperation), innerException);
		}

		/// <summary>
		/// Throws the invalid value exception.
		/// </summary>
		/// <typeparam name="TValue">The type of the t value.</typeparam>
		/// <param name="message">The message.</param>
		/// <param name="value">The value.</param>
		/// <exception cref="InvalidValueException{TValue}"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
		[Information(nameof(ThrowInvalidValueException), author: "David McCarter", createdOn: "2/10/2021", Status = Status.Available)]
		public static void ThrowInvalidValueException<TValue>(string message, [NotNull] TValue value)
		{
			throw new InvalidValueException<TValue>(message, value: value);
		}

		/// <summary>
		/// Throws the invalid value exception.
		/// </summary>
		/// <typeparam name="TValue">The type of the t value.</typeparam>
		/// <param name="message">The message.</param>
		/// <param name="value">The value.</param>
		/// <param name="innerException">The inner exception.</param>
		/// <exception cref="InvalidValueException{TValue}"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
		[Information(nameof(ThrowInvalidValueException), author: "David McCarter", createdOn: "2/10/2021", Status = Status.Available)]
		public static void ThrowInvalidValueException<TValue>(string message, [NotNull] TValue value, [AllowNull] Exception innerException)
		{
			throw new InvalidValueException<TValue>(message, value: value, innerException: innerException);
		}
	}
}
