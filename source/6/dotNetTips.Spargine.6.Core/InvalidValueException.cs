// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Core
// Author           : David McCarter
// Created          : 02-10-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-21-2022
// ***********************************************************************
// <copyright file="InvalidValueException.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Runtime.Serialization;
using DotNetTips.Spargine.Core.Internal;
using DotNetTips.Spargine.Core.Properties;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core
{
	/// <summary>
	/// Class InvalidValueException. This class cannot be inherited.
	/// </summary>
	/// <typeparam name="TValue">The type of the t value.</typeparam>
	[Serializable]
	public sealed class InvalidValueException<TValue> : Exception
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="InvalidValueException{TValue}" /> class.
		/// </summary>
		public InvalidValueException() : base(Resources.MessageGoToDotNetTipsComForHelp)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="InvalidValueException{TValue}" /> class.
		/// </summary>
		/// <param name="value">The value.</param>
		public InvalidValueException(TValue value) : base(Resources.MessageGoToDotNetTipsComForHelp) => this.Value = value;

		/// <summary>
		/// Initializes a new instance of the <see cref="InvalidValueException{TValue}" /> class.
		/// </summary>
		/// <param name="message">The message.</param>
		public InvalidValueException(string message) : base(message)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="InvalidValueException{TValue}" /> class.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="value">The value.</param>
		public InvalidValueException(string message, TValue value) : base(message) => this.Value = value;

		/// <summary>
		/// Initializes a new instance of the <see cref="InvalidValueException{TValue}" /> class.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="innerException">The inner exception.</param>
		public InvalidValueException(string message, Exception innerException) : base(message, innerException)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="InvalidValueException{TValue}"/> class.
		/// </summary>
		/// <param name="info">The <see cref="SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
		/// <param name="context">The <see cref="StreamingContext" /> that contains contextual information about the source or destination.</param>
		private InvalidValueException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="InvalidValueException{TValue}" /> class.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="value">The value.</param>
		/// <param name="innerException">The inner exception.</param>
		public InvalidValueException(string message, TValue value, Exception innerException) : base(message, innerException) => this.Value = value;

		/// <summary>
		/// Gets the value.
		/// </summary>
		/// <value>The value.</value>
		public TValue Value { get; private set; }

		/// <summary>
		/// Converts to string.
		/// </summary>
		/// <returns>string.</returns>
		public override string ToString()
		{
			var valueProperties = ControlChars.Space.ToString();
			var innerException = ControlChars.Space.ToString();

			if (this.Value is not null)
			{
				valueProperties = InternalMethods.PropertiesToString(this.Value);
			}

			if (this.InnerException is not null)
			{
				innerException = InternalMethods.PropertiesToString(this.InnerException);
			}

			return $"{this.Message} InnerException: {innerException} Value: {valueProperties}.";
		}
	}
}
