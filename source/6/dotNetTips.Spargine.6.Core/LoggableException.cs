// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core
// Author           : David McCarter
// Created          : 09-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 01-03-2023
// ***********************************************************************
// <copyright file="LoggableException.cs" company="dotNetTips.Spargine.Core">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Xml.Serialization;
using DotNetTips.Spargine.Core.Logging;
using Microsoft.Extensions.ObjectPool;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Class LoggableException.
/// </summary>
/// <seealso cref="Exception" />
/// <seealso cref="IXmlSerializable" />
[Serializable]
public class LoggableException : Exception
{
	/// <summary>
	/// The string builder pool
	/// </summary>
	private static readonly ObjectPool<System.Text.StringBuilder> _stringBuilderPool =
	new DefaultObjectPoolProvider().CreateStringBuilderPool();

	/// <summary>
	/// The exception has been logged
	/// </summary>
	[NonSerialized]
	[XmlIgnore]
	private bool _hasBeenLogged;

	/// <summary>
	/// Initializes a new instance of the <see cref="LoggableException" /> class.
	/// </summary>
	/// <param name="serializationInfo">The serialization information.</param>
	/// <param name="streamingContext">The streaming context.</param>
	/// <exception cref="NotImplementedException"></exception>
	protected LoggableException(SerializationInfo serializationInfo, StreamingContext streamingContext)
	 : base(serializationInfo, streamingContext) => throw new NotImplementedException();

	/// <summary>
	/// Initializes a new instance of the <see cref="LoggableException" /> class.
	/// </summary>
	public LoggableException()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="LoggableException" /> class.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	public LoggableException(string message) : base(message)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="LoggableException" /> class.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
	public LoggableException(string message, [AllowNull] Exception innerException) : base(message, innerException)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="LoggableException" /> class.
	/// </summary>
	/// <param name="message">The message.</param>
	/// <param name="ex">The ex.</param>
	/// <param name="userMessage">The user message.</param>
	public LoggableException(string message, [NotNull] Exception ex, [AllowNull] string userMessage) : base(message, ex) => this.UserMessage = userMessage;

	/// <summary>
	/// Return's a list of properties and their value using <see cref="ObjectPool&lt;StringBuilder&gt;"/> to improve performance.
	/// </summary>
	/// <param name="ex">The ex.</param>
	/// <returns>System.String.</returns>
	private static string ReflectException(Exception ex)
	{
		var sb = _stringBuilderPool.Get();

		try
		{
			var properties = ex.GetType().GetRuntimeProperties().ToList();

			properties.ForEach(
				current =>
				{
					object objectValue = null;

					try
					{
						objectValue = RuntimeHelpers.GetObjectValue(current.GetValue(ex, null));
					}
					catch (SecurityException securityEx)
					{
						Trace.WriteLine(securityEx);
					}

					if ((objectValue is not null) &&
						(!string.Equals(
						objectValue.ToString(),
						objectValue.GetType().FullName,
						StringComparison.Ordinal)))
					{
						_ = sb.AppendFormat(
							CultureInfo.CurrentCulture,
							"{0}: {1}",
							new object[] { current.Name, RuntimeHelpers.GetObjectValue(current) })
							.AppendLine();
					}
				});

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb);
		}
	}

	/// <summary>
	/// When overridden in a derived class, sets the <see cref="SerializationInfo"></see> with information about the exception.
	/// </summary>
	/// <param name="info">The <see cref="SerializationInfo"></see> that holds the serialized object data about the exception being thrown.</param>
	/// <param name="context">The <see cref="StreamingContext"></see> that contains contextual information about the source or destination.</param>
	[Preserve(preserveReason: PreserveReason.MethodOverride, reason: "Used by serialization.", createdOn: "01/07/2023", createdBy: "David McCarter")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);

		info.AddValue(nameof(this.UserMessage), this.UserMessage);
	}

	/// <summary>
	/// Gets Exception message, including inner Exceptions.
	/// </summary>
	/// <returns>System.String[].</returns>
	/// <value>The messages.</value>
	public virtual string[] Messages()
	{
		var exceptions = LoggingHelper.RetrieveAllExceptions(this);
		var errorMessages = new List<string>();

		for (var exCount = 0; exCount < exceptions.Length; exCount++)
		{
			var current = exceptions[exCount];
			errorMessages.Add(current.GetType().FullName);
			errorMessages.Add(ReflectException(current));

			if (current.StackTrace is not null)
			{
				errorMessages.Add(current.StackTrace);
			}
		}

		return errorMessages.ToArray();
	}

	/// <summary>
	/// Gets or sets a value indicating whether this instance has been logged.
	/// </summary>
	/// <value><c>true</c> if this instance has been logged; otherwise, <c>false</c>.</value>
	public bool HasBeenLogged
	{
		get => this._hasBeenLogged;

		set
		{
			// Prevent from being set (from code) to false.
			if (value)
			{
				this._hasBeenLogged = value;
			}
		}
	}

	/// <summary>
	/// Gets or sets the user message.
	/// </summary>
	/// <value>The user message.</value>
	public virtual string UserMessage { get; }
}
