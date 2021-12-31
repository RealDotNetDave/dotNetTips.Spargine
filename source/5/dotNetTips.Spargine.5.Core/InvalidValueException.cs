// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Core
// Author           : David McCarter
// Created          : 02-10-2021
//
// Last Modified By : David McCarter
// Last Modified On : 12-27-2021
// ***********************************************************************
// <copyright file="InvalidValueException.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Runtime.Serialization;
using dotNetTips.Spargine.Core.Internal;
using dotNetTips.Spargine.Core.Properties;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png; https://www.spargine.net )
namespace dotNetTips.Spargine.Core
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
		public InvalidValueException() : base(Resources.GoToDotNetTipsComForHelp)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="InvalidValueException{TValue}" /> class.
		/// </summary>
		/// <param name="value">The value.</param>
		public InvalidValueException(TValue value) : base(Resources.GoToDotNetTipsComForHelp) => this.Value = value;

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
		/// Initializes a new instance of the <see cref="InvalidValueException{TValue}" /> class.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="value">The value.</param>
		/// <param name="innerException">The inner exception.</param>
		public InvalidValueException(string message, TValue value, Exception innerException) : base(message, innerException) => this.Value = value;

		/// <summary>
		/// Initializes a new instance of the <see cref="InvalidValueException{TValue}" /> class.
		/// </summary>
		/// <param name="serializationInfo">The serialization information.</param>
		/// <param name="streamingContext">The streaming context.</param>
		/// <exception cref="NotImplementedException"></exception>
		private InvalidValueException(SerializationInfo serializationInfo, StreamingContext streamingContext) => throw new NotImplementedException();

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
