// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core
// Author           : David McCarter
// Created          : 10-27-2020
//
// Last Modified By : David McCarter
// Last Modified On : 08-02-2023
// ***********************************************************************
// <copyright file="InvalidEnumTypeException.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Custom Exception to be used when a value for an Enum is invalid.</summary>
// ***********************************************************************
using System.Runtime.Serialization;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// InvalidEnumTypeException.
/// Implements the <see cref="Exception" />
/// </summary>
/// <seealso cref="Exception" />
[Serializable]
public class InvalidEnumTypeException : Exception
{
	/// <summary>
	/// Initializes a new instance of the <see cref="InvalidEnumTypeException" /> class.
	/// </summary>
	public InvalidEnumTypeException()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="InvalidEnumTypeException" /> class.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	public InvalidEnumTypeException(string message) : base(message)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="InvalidEnumTypeException" /> class.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
	public InvalidEnumTypeException(string message, Exception innerException) : base(message, innerException)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="InvalidEnumTypeException" /> class.
	/// </summary>
	/// <param name="info">The <see cref="SerializationInfo"></see> that holds the serialized object data about the exception being thrown.</param>
	/// <param name="context">The <see cref="StreamingContext"></see> that contains contextual information about the source or destination.</param>
	protected InvalidEnumTypeException(SerializationInfo info, StreamingContext context) : base(info, context)
	{
	}
}
