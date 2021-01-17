// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core
// Author           : David McCarter
// Created          : 09-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 09-28-2020
// ***********************************************************************
// <copyright file="DirectoryNotFoundException.cs" company="dotNetTips.Spargine.Core">
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
	/// Class DirectoryNotFoundException.
	/// Implements the <see cref="LoggableException" />
	/// Implements the <see cref="dotNetTips.Spargine.Core.LoggableException" />
	/// </summary>
	/// <seealso cref="LoggableException" />
	/// <seealso cref="Exception" />
	[Serializable]
	public class DirectoryNotFoundException : LoggableException
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DirectoryNotFoundException"></see> class.
		/// </summary>
		public DirectoryNotFoundException()
		{

		}

		/// <summary>
		/// Initializes a new instance of the <see cref="DirectoryNotFoundException" /> class.
		/// </summary>
		/// <param name="message">The message that describes the error.</param>
		public DirectoryNotFoundException(string message) : base(message)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="DirectoryNotFoundException"></see> class with a specified error message.
		/// </summary>
		/// <param name="message">The message that describes the error.</param>
		/// <param name="directory">The directory.</param>
		public DirectoryNotFoundException(string message, string directory) : base(message)
		{
			this.Directory = directory;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="DirectoryNotFoundException" /> class.
		/// </summary>
		/// <param name="message">The error message that explains the reason for the exception.</param>
		/// <param name="innerException">The inner exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
		public DirectoryNotFoundException(string message, Exception innerException) : base(message, innerException)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="DirectoryNotFoundException"></see> class with a specified error message and a reference to the inner exception that is the cause of this exception.
		/// </summary>
		/// <param name="message">The error message that explains the reason for the exception.</param>
		/// <param name="directory">The directory.</param>
		/// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
		public DirectoryNotFoundException(string message, string directory, Exception innerException) : base(message, innerException)
		{
			this.Directory = directory;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="DirectoryNotFoundException" /> class.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="ex">The Exception.</param>
		/// <param name="userMessage">The user message.</param>
		public DirectoryNotFoundException(string message, Exception ex, string userMessage) : base(message, ex, userMessage)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="DirectoryNotFoundException"></see> class with serialized data.
		/// </summary>
		/// <param name="info">The <see cref="SerializationInfo"></see> that holds the serialized object data about the exception being thrown.</param>
		/// <param name="context">The <see cref="StreamingContext"></see> that contains contextual information about the source or destination.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="info">info</paramref> parameter is null.</exception>
		/// <exception cref="SerializationException">The class name is null or <see cref="Exception.HResult"></see> is zero (0).</exception>
		protected DirectoryNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
		{

		}

		/// <summary>
		/// Gets the directory.
		/// </summary>
		/// <value>The directory.</value>
		public string Directory { get; private set; }

	}
}
