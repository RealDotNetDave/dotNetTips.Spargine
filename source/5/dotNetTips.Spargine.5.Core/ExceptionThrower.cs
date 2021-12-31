﻿// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core
// Author           : David McCarter
// Created          : 09-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 12-27-2021
// ***********************************************************************
// <copyright file="ExceptionThrower.cs" company="dotNetTips.Spargine.Core">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using dotNetTips.Spargine.Core.Properties;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png; https://www.spargine.net )
namespace dotNetTips.Spargine.Core
{
	/// <summary>
	/// Exception Thrower.
	/// </summary>
	public static class ExceptionThrower
	{
		/// <summary>
		/// Throws the ArgumentException.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="paramName">Name of the parameter.</param>
		/// <exception cref="System.ArgumentException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage]
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", modifiedOn: "7/30/2020", Status = Status.Available)]
		public static void ThrowArgumentException([NotNull] string message, [NotNull] string paramName) => throw new ArgumentException(paramName, message.DefaultIfNull(Resources.ExMessageInvalidArgument));

		/// <summary>
		/// Throws the ArgumentException.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="innerException">The inner exception.</param>
		/// <exception cref="System.ArgumentException"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage]
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", modifiedOn: "7/30/2020", Status = Status.Available)]
		public static void ThrowArgumentException([NotNull] string message, [AllowNull] Exception innerException) => throw new ArgumentException(message.DefaultIfNull(Resources.ExMessageInvalidArgument), innerException);

		/// <summary>
		/// Throws the ArgumentInvalidException.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="paramName">Name of the parameter.</param>
		/// <exception cref="dotNetTips.Spargine.Core.ArgumentInvalidException"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage]
		[Information(nameof(ThrowArgumentInvalidException), author: "David McCarter", createdOn: "8/13/2020", modifiedOn: "8/13/2020", Status = Status.Available)]
		public static void ThrowArgumentInvalidException([NotNull] string message, [NotNull] string paramName) => throw new ArgumentInvalidException(paramName, message.DefaultIfNull(Resources.ExMessageInvalidArgument));

		/// <summary>
		/// Throws the ArgumentInvalidException.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="innerException">The inner exception.</param>
		/// <exception cref="dotNetTips.Spargine.Core.ArgumentInvalidException"></exception>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="ArgumentNullException"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage]
		[Information(nameof(ThrowArgumentInvalidException), author: "David McCarter", createdOn: "8/13/2020", modifiedOn: "8/13/2020", Status = Status.Available)]
		public static void ThrowArgumentInvalidException([NotNull] string message, [AllowNull] Exception innerException) => throw new ArgumentInvalidException(message.DefaultIfNull(Resources.ExMessageInvalidArgument), innerException);

		/// <summary>
		/// Throws the argument null exception.
		/// </summary>
		/// <param name="paramName">Name of the parameter.</param>
		/// <exception cref="System.ArgumentNullException"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage]
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "8/12/2020", modifiedOn: "8/12/2020", Status = Status.Available)]
		public static void ThrowArgumentNullException([NotNull] string paramName) => throw new ArgumentNullException(paramName, Resources.ExMessageArgumentNull);

		/// <summary>
		/// Throws the ArgumentNullException.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="paramName">Name of the parameter.</param>
		/// <exception cref="System.ArgumentNullException"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage]
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", modifiedOn: "7/30/2020", Status = Status.Available)]
		public static void ThrowArgumentNullException([NotNull] string message, [NotNull] string paramName) => throw new ArgumentNullException(paramName, message.DefaultIfNull(Resources.ExMessageArgumentNull));

		/// <summary>
		/// Throws the ArgumentNullException.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="innerException">The inner exception.</param>
		/// <exception cref="System.ArgumentNullException"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage]
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", modifiedOn: "7/30/2020", Status = Status.Available)]
		public static void ThrowArgumentNullException([NotNull] string message, [AllowNull] Exception innerException) => throw new ArgumentNullException(message.DefaultIfNull(Resources.ExMessageArgumentNull), innerException);

		/// <summary>
		/// Throws the argument out of range exception.
		/// </summary>
		/// <param name="paramName">Name of the parameter.</param>
		/// <exception cref="System.ArgumentOutOfRangeException"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage]
		[Information(nameof(ThrowArgumentOutOfRangeException), author: "David McCarter", createdOn: "9/5/2020", modifiedOn: "9/5/2020", Status = Status.Available)]
		public static void ThrowArgumentOutOfRangeException([NotNull] string paramName) => throw new ArgumentOutOfRangeException(paramName, Resources.ExArgumentOutOfRange);

		/// <summary>
		/// Throws the argument out of range exception.
		/// </summary>
		/// <param name="paramName">Name of the parameter.</param>
		/// <param name="message">The message.</param>
		/// <exception cref="System.ArgumentOutOfRangeException"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage]
		[Information(nameof(ThrowArgumentOutOfRangeException), author: "David McCarter", createdOn: "9/5/2020", modifiedOn: "9/5/2020", Status = Status.Available)]
		public static void ThrowArgumentOutOfRangeException([NotNull] string paramName, [NotNull] string message) => throw new ArgumentOutOfRangeException(paramName, message.DefaultIfNull(Resources.ExArgumentOutOfRange));

		/// <summary>
		/// Throws the argument out of range exception.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="innerException">The inner exception.</param>
		/// <exception cref="System.ArgumentOutOfRangeException"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage]
		[Information(nameof(ThrowArgumentOutOfRangeException), author: "David McCarter", createdOn: "9/5/2020", modifiedOn: "9/5/2020", Status = Status.Available)]
		public static void ThrowArgumentOutOfRangeException([NotNull] string message, [AllowNull] Exception innerException) => throw new ArgumentOutOfRangeException(message.DefaultIfNull(Resources.ExArgumentOutOfRange), innerException);

		/// <summary>
		/// Throws the ArgumentReadOnlyException.
		/// </summary>
		/// <param name="paramName">Name of the parameter.</param>
		/// <exception cref="dotNetTips.Spargine.Core.ArgumentReadOnlyException"></exception>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage]
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", modifiedOn: "7/30/2020", Status = Status.Available)]
		public static void ThrowArgumentReadOnlyCollectionException([NotNull] string paramName) => throw new ArgumentReadOnlyException(Resources.ExMessageReadonlyCollection, paramName);

		/// <summary>
		/// Throws the ArgumentInvalidException.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="directory">The directory.</param>
		/// <exception cref="dotNetTips.Spargine.Core.DirectoryNotFoundException"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage]
		[Information(nameof(ThrowDirectoryNotFoundException), author: "David McCarter", createdOn: "8/13/2020", modifiedOn: "8/13/2020", Status = Status.Available)]
		public static void ThrowDirectoryNotFoundException([NotNull] string message, [NotNull] string directory) => throw new DirectoryNotFoundException(directory, message.DefaultIfNull(Resources.ExMessageDirectoryNotFound));

		/// <summary>
		/// Throws the ArgumentInvalidException.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="innerException">The inner exception.</param>
		/// <exception cref="dotNetTips.Spargine.Core.ArgumentInvalidException"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage]
		[Information(nameof(ThrowDirectoryNotFoundException), author: "David McCarter", createdOn: "8/13/2020", modifiedOn: "8/13/2020", Status = Status.Available)]
		public static void ThrowDirectoryNotFoundException([NotNull] string message, [AllowNull] Exception innerException) => throw new ArgumentInvalidException(message.DefaultIfNull(Resources.ExMessageDirectoryNotFound), innerException);

		/// <summary>
		/// Throws the file not found exception.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="innerException">The inner exception.</param>
		/// <exception cref="System.IO.FileNotFoundException"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage]
		[Information(nameof(ThrowFileNotFoundException), author: "David McCarter", createdOn: "11/11/2020", modifiedOn: "11/11/2020", Status = Status.Available)]
		public static void ThrowFileNotFoundException([NotNull] string message, [AllowNull] Exception innerException) => throw new FileNotFoundException(message.DefaultIfNull(Resources.FileNotFound), innerException);

		/// <summary>
		/// Throws the file not found exception.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="fileName">Name of the file.</param>
		/// <exception cref="System.IO.FileNotFoundException"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage]
		[Information(nameof(ThrowFileNotFoundException), author: "David McCarter", createdOn: "11/11/2020", modifiedOn: "11/11/2020", Status = Status.Available)]
		public static void ThrowFileNotFoundException([NotNull] string message, [NotNull] string fileName) => throw new FileNotFoundException(message.DefaultIfNull(Resources.FileNotFound), fileName);

		/// <summary>
		/// Throws the file not found exception.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="fileName">Name of the file.</param>
		/// <param name="innerException">The inner exception.</param>
		/// <exception cref="System.IO.FileNotFoundException"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage]
		[Information(nameof(ThrowFileNotFoundException), author: "David McCarter", createdOn: "11/11/2020", modifiedOn: "11/11/2020", Status = Status.Available)]
		public static void ThrowFileNotFoundException([NotNull] string message, [NotNull] string fileName, [AllowNull] Exception innerException) => throw new FileNotFoundException(message.DefaultIfNull(Resources.FileNotFound), fileName, innerException);

		/// <summary>
		/// Throws the invalid cast exception.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="paramName">Name of the parameter.</param>
		/// <exception cref="System.InvalidCastException"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage]
		[Information(nameof(ThrowInvalidCastException), author: "David McCarter", createdOn: "11/11/2020", modifiedOn: "11/11/2020", Status = Status.Available)]
		public static void ThrowInvalidCastException([NotNull] string message, [NotNull] string paramName) => throw new InvalidCastException($"{message.DefaultIfNull(Resources.ExMessageInvalidArgument)} ParamName: {paramName}");


		/// <summary>
		/// Throws the invalid cast exception.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="innerException">The inner exception.</param>
		/// <exception cref="System.InvalidCastException"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage]
		[Information(nameof(ThrowInvalidCastException), author: "David McCarter", createdOn: "11/11/2020", modifiedOn: "11/11/2020", Status = Status.Available)]
		public static void ThrowInvalidCastException([NotNull] string message, [AllowNull] Exception innerException) => throw new InvalidCastException(message.DefaultIfNull(Resources.ExMessageInvalidArgument), innerException);

		/// <summary>
		/// Throws the invalid enum type exception.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <exception cref="dotNetTips.Spargine.Core.InvalidEnumTypeException"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage]
		[Information(nameof(ThrowInvalidEnumTypeException), author: "David McCarter", createdOn: "7/30/2020", modifiedOn: "7/30/2020", Status = Status.Available)]
		public static void ThrowInvalidEnumTypeException([NotNull] string message) => throw new InvalidEnumTypeException(message.DefaultIfNull(Resources.ExMessageInvalidEnumType));

		/// <summary>
		/// Throws the invalid enum type exception.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="innerException">The inner exception.</param>
		/// <exception cref="System.InvalidCastException"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage]
		[Information(nameof(ThrowInvalidEnumTypeException), author: "David McCarter", createdOn: "11/11/2020", modifiedOn: "11/11/2020", Status = Status.Available)]
		public static void ThrowInvalidEnumTypeException([NotNull] string message, [AllowNull] Exception innerException) => throw new InvalidCastException(message.DefaultIfNull(Resources.ExMessageInvalidEnumType), innerException);

		/// <summary>
		/// Throws a InvalidOperationException.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <exception cref="System.InvalidOperationException"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage]
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", modifiedOn: "7/30/2020", Status = Status.Available)]
		public static void ThrowInvalidOperationException([NotNull] string message) => throw new InvalidOperationException(message.DefaultIfNull(Resources.ExMessageInvalidOperation));

		/// <summary>
		/// Throws a InvalidOperationException.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="innerException">The inner exception.</param>
		/// <exception cref="System.InvalidOperationException"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage]
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", modifiedOn: "7/30/2020", Status = Status.Available)]
		public static void ThrowInvalidOperationException([NotNull] string message, [AllowNull] Exception innerException) => throw new InvalidOperationException(message.DefaultIfNull(Resources.ExMessageInvalidOperation), innerException);

		/// <summary>
		/// Throws the invalid value exception.
		/// </summary>
		/// <typeparam name="TValue">The type of the t value.</typeparam>
		/// <param name="message">The message.</param>
		/// <param name="value">The value.</param>
		/// <exception cref="InvalidValueException{TValue}"></exception>
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[ExcludeFromCodeCoverage]
		[Information(nameof(ThrowInvalidValueException), author: "David McCarter", createdOn: "2/10/2021", Status = Status.Available)]
		public static void ThrowInvalidValueException<TValue>([NotNull] string message, [NotNull] TValue value) => throw new InvalidValueException<TValue>(message: message, value: value);

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
		[ExcludeFromCodeCoverage]
		[Information(nameof(ThrowInvalidValueException), author: "David McCarter", createdOn: "2/10/2021", Status = Status.Available)]
		public static void ThrowInvalidValueException<TValue>([NotNull] string message, [NotNull] TValue value, [AllowNull] Exception innerException) => throw new InvalidValueException<TValue>(message: message, value: value, innerException: innerException);

		/// <summary>
		/// Defaults if null.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="defaultValue">The default value.</param>
		/// <returns>System.String.</returns>
		private static string DefaultIfNull([NotNull] this string value, [NotNull] string defaultValue) => value ?? defaultValue ?? string.Empty;
	}
}
