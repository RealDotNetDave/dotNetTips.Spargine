// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core
// Author           : David McCarter
// Created          : 09-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 08-02-2023
// ***********************************************************************
// <copyright file="ArgumentReadOnlyException.cs" company="dotNetTips.Spargine.Core">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary>Custom Exception type for argument values that are read-only, such as collections.</summary>
// ***********************************************************************
using System.Runtime.Serialization;
using DotNetTips.Spargine.Core.Properties;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Class ArgumentIsReadOnlyException.
/// Implements the <see cref="ArgumentException" />
/// </summary>
/// <seealso cref="ArgumentException" />
/// <seealso cref="ArgumentException" />
/// <seealso cref="Exception" />
[Serializable]
public sealed class ArgumentReadOnlyException : ArgumentException
{

	/// <summary>
	/// Initializes a new instance of the <see cref="ArgumentReadOnlyException"></see> class with serialized data.
	/// </summary>
	/// <param name="info">The object that holds the serialized object data.</param>
	/// <param name="context">The contextual information about the source or destination.</param>
	private ArgumentReadOnlyException(SerializationInfo info, StreamingContext context) : base(info, context)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="ArgumentReadOnlyException" /> class.
	/// </summary>
	public ArgumentReadOnlyException() : base(Resources.ErrorReadOnlyCollection)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="ArgumentReadOnlyException" /> class.
	/// </summary>
	/// <param name="paramName">Name of the parameter.</param>
	public ArgumentReadOnlyException(string paramName) : base(Resources.ErrorReadOnlyCollection, paramName)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="ArgumentReadOnlyException" /> class.
	/// </summary>
	/// <param name="message">The message.</param>
	/// <param name="paramName">Name of the parameter.</param>
	public ArgumentReadOnlyException(string message, string paramName) : base(paramName, message)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="ArgumentReadOnlyException" /> class.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in
	/// Visual Basic) if no inner exception is specified.</param>
	public ArgumentReadOnlyException(string message, Exception innerException) : base(message, innerException)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="ArgumentReadOnlyException" /> class.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="paramName">The name of the parameter that caused the current exception.</param>
	/// <param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException" /> parameter is not a null reference, the current exception is raised in a <see langword="catch" /> block that handles the inner exception.</param>
	public ArgumentReadOnlyException(string message, string paramName, Exception innerException) : base(message, paramName, innerException)
	{
	}

}
