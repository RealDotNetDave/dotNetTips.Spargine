//![](05CD5CE05AF2C0FDDE3210EB79859750_1.png;http://dotnettips.com )

// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core
// Author           : David McCarter
// Created          : 09-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 09-28-2020
// ***********************************************************************
// <copyright file="MessageNotQueuedException.cs" company="dotNetTips.Spargine.Core">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Runtime.Serialization;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Core
{
	/// <summary>
	/// Class MessageNotQueuedException.
	/// Implements the <see cref="dotNetTips.Spargine.Core.LoggableException" />
	/// </summary>
	/// <seealso cref="dotNetTips.Spargine.Core.LoggableException" />
	/// <seealso cref="System.Exception" />
	[Serializable]
	public class MessageNotQueuedException : LoggableException
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="MessageNotQueuedException" /> class.
		/// </summary>
		public MessageNotQueuedException()
		{

		}

		/// <summary>
		/// Initializes a new instance of the <see cref="MessageNotQueuedException" /> class.
		/// </summary>
		/// <param name="message">The message that describes the error.</param>
		public MessageNotQueuedException(string message) : base(message)
		{

		}

		/// <summary>
		/// Initializes a new instance of the <see cref="MessageNotQueuedException" /> class.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="messageId">The message identifier.</param>
		public MessageNotQueuedException(string message, string messageId) : base(message)
		{
			this.MessageId = messageId;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="MessageNotQueuedException" /> class.
		/// </summary>
		/// <param name="message">The error message that explains the reason for the exception.</param>
		/// <param name="innerException">The inner exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
		public MessageNotQueuedException(string message, Exception innerException) : base(message, innerException)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="MessageNotQueuedException" /> class.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="messageId">The message identifier.</param>
		/// <param name="innerException">The inner exception.</param>
		public MessageNotQueuedException(string message, string messageId, Exception innerException) : base(message, innerException)
		{
			this.MessageId = messageId;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="MessageNotQueuedException" /> class.
		/// </summary>
		/// <param name="serializationInfo">The serialization information.</param>
		/// <param name="streamingContext">The streaming context.</param>
		/// <exception cref="System.NotImplementedException">The exception.</exception>
		/// <exception cref="System.NotImplementedException">The exception.</exception>
		protected MessageNotQueuedException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext)
		{

		}

		/// <summary>
		/// Gets the message identifier.
		/// </summary>
		/// <value>The message identifier.</value>
		public string MessageId { get; private set; }

	}
}
