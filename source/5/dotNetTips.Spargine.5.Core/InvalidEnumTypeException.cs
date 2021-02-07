// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core
// Author           : David McCarter
// Created          : 10-27-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-02-2021
// ***********************************************************************
// <copyright file="InvalidEnumTypeException.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Runtime.Serialization;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Core
{
	/// <summary>
	/// InvalidEnumTypeException.
	/// Implements the <see cref="System.Exception" />
	/// </summary>
	/// <seealso cref="System.Exception" />
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
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo"></see> that holds the serialized object data about the exception being thrown.</param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext"></see> that contains contextual information about the source or destination.</param>
		protected InvalidEnumTypeException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
