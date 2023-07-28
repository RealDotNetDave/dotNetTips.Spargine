// ***********************************************************************
// Assembly         : dotNetTips.Spargine.6.Tester
// Author           : David McCarter
// Created          : 01-03-2021
//
// Last Modified By : David McCarter
// Last Modified On : 06-29-2023
// ***********************************************************************
// <copyright file="PersonRecord.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Properties;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Tester.Models.RefTypes;

/// <summary>
/// Class Person with proper encapsulation and validation.
/// Implements the <see cref="IDataRecord" />
/// </summary>
[DebuggerDisplay("{Email}")]
[Serializable]
[XmlRoot(ElementName = "PersonRecord", Namespace = "http://dotNetTips.Spargine.Tester.Models.RefTypes")]
[DataContract(Name = "personRecord", Namespace = "http://dotNetTips.Spargine.Tester.Models.RefTypes")]
[Information(Status = Status.Available, Documentation = "https://bit.ly/UnitTestRandomData7")]
public sealed record PersonRecord : IDataRecord, IComparable<PersonRecord>
{
	/// <summary>
	/// The born on
	/// </summary>
	private DateTimeOffset _bornOn;

	/// <summary>
	/// The cell phone number
	/// </summary>
	private string _cellPhone;

	/// <summary>
	/// The email
	/// </summary>
	private string _email;

	/// <summary>
	/// The first name
	/// </summary>
	private string _firstName;

	/// <summary>
	/// The home phone number
	/// </summary>
	private string _homePhone;

	/// <summary>
	/// The last name
	/// </summary>
	private string _lastName;

	/// <summary>
	/// Prevents a default instance of the <see cref="PersonRecord" /> class from being created.
	/// </summary>
	private PersonRecord()
	{ }

	/// <summary>
	/// Initializes a new instance of the <see cref="Person" /> class.
	/// </summary>
	/// <param name="email">The email.</param>
	/// <param name="id">The identifier.</param>
	public PersonRecord(string email, string id)
	{
		this.Email = email;
		this.Id = id;
	}

	/// <summary>
	/// Implements the &lt; operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	public static bool operator <(PersonRecord left, PersonRecord right)
	{
		return left is null ? right is not null : left.CompareTo(right) < 0;
	}

	/// <summary>
	/// Implements the &lt;= operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	public static bool operator <=(PersonRecord left, PersonRecord right)
	{
		return left is null || left.CompareTo(right) <= 0;
	}

	/// <summary>
	/// Implements the &gt; operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	public static bool operator >(PersonRecord left, PersonRecord right)
	{
		return left is not null && left.CompareTo(right) > 0;
	}

	/// <summary>
	/// Implements the &gt;= operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	public static bool operator >=(PersonRecord left, PersonRecord right)
	{
		return left is null ? right is null : left.CompareTo(right) >= 0;
	}

	/// <summary>
	/// Compares to.
	/// </summary>
	/// <param name="other">The other.</param>
	/// <returns>System.Int32.</returns>
	public int CompareTo(PersonRecord other)
	{
		if (other is null)
		{
			return 1;
		}

		var result = this._bornOn.CompareTo(other._bornOn);
		if (result != 0)
		{
			return result;
		}

		result = string.Compare(this._cellPhone, other._cellPhone, StringComparison.OrdinalIgnoreCase);
		if (result != 0)
		{
			return result;
		}

		result = string.Compare(this._email, other._email, StringComparison.OrdinalIgnoreCase);
		if (result != 0)
		{
			return result;
		}

		result = string.Compare(this._firstName, other._firstName, StringComparison.OrdinalIgnoreCase);
		if (result != 0)
		{
			return result;
		}

		result = string.Compare(this._homePhone, other._homePhone, StringComparison.OrdinalIgnoreCase);
		if (result != 0)
		{
			return result;
		}

		result = string.Compare(this.Id, other.Id, StringComparison.OrdinalIgnoreCase);
		if (result != 0)
		{
			return result;
		}

		result = string.Compare(this._lastName, other._lastName, StringComparison.OrdinalIgnoreCase);
		if (result != 0)
		{
			return result;
		}

		return result;
	}

	/// <summary>
	/// Gets or sets the addresses.
	/// </summary>
	/// <value>The addresses.</value>
	[DataMember(Name = "adresses")]
	[XmlElement]
	public Collection<AddressRecord> Addresses { get; init; }

	/// <summary>
	/// Gets or sets the born on date.
	/// </summary>
	/// <value>The born on date.</value>
	/// <exception cref="ArgumentOutOfRangeException">BornOn</exception>
	[DataMember(Name = "bornOn")]
	[XmlElement]
	public DateTimeOffset BornOn
	{
		get => this._bornOn;
		init
		{
			if (this._bornOn == value)
			{
				return;
			}

			this._bornOn = value.ToUniversalTime() > DateTimeOffset.UtcNow
				? throw new ArgumentOutOfRangeException(
					nameof(this.BornOn),
					Resources.PersonBornOnCannotBeInTheFuture)
				: value;
		}
	}

	/// <summary>
	/// Gets or sets the cell phone number.
	/// </summary>
	/// <value>The cell phone number.</value>
	/// <exception cref="ArgumentOutOfRangeException">CellPhone</exception>
	/// <exception cref="ArgumentNullException">CellPhone</exception>
	[DataMember(Name = "cellPhone")]
	[XmlElement]
	public string CellPhone
	{
		get => this._cellPhone;
		init
		{
			if (string.Equals(this._cellPhone, value, StringComparison.Ordinal))
			{
				return;
			}

			this._cellPhone = value.HasValue(0, 50) is false
				? throw new ArgumentOutOfRangeException(
					nameof(this.CellPhone),
					Resources.PhoneNumberIsLimitedTo50Characters)
				: value;
		}
	}
	//#if NET7_0_OR_GREATER
	//		/// <summary>
	//	/// Gets or sets the email address.
	//	/// </summary>
	//	/// <value>The email address.</value>
	//	/// <exception cref="ArgumentOutOfRangeException">Email</exception>
	//	/// <exception cref="ArgumentNullException">Email - Value for Email cannot be null or empty.</exception>
	//	[DisallowNull]
	//	[DataMember(Name = "email")]
	//	[XmlElement]
	//	public required string Email
	//	{
	//		get => this._email;
	//		init
	//		{
	//			if (string.Equals(this._email, value, StringComparison.Ordinal))
	//			{
	//				return;
	//			}

	//			this._email = value.HasValue(0, 75) is false
	//				? throw new ArgumentOutOfRangeException(
	//					nameof(this.Email),
	//					Resources.EmailLengthIsLimitedTo75Characters)
	//				: value;
	//		}
	//	}
	//#else
	/// <summary>
	/// Gets or sets the email address.
	/// </summary>
	/// <value>The email address.</value>
	/// <exception cref="ArgumentOutOfRangeException">Email</exception>
	/// <exception cref="ArgumentNullException">Email</exception>
	[DisallowNull]
	[DataMember(Name = "email")]
	[XmlElement]
	public string Email
	{
		get => this._email;
		init
		{
			if (string.Equals(this._email, value, StringComparison.Ordinal))
			{
				return;
			}

			this._email = value.HasValue(0, 75) is false
				? throw new ArgumentOutOfRangeException(
					nameof(this.Email),
					Resources.EmailLengthIsLimitedTo75Characters)
				: value;
		}
	}
	//#endif
	/// <summary>
	/// Gets or sets the first name.
	/// </summary>
	/// <value>The first name.</value>
	/// <exception cref="ArgumentOutOfRangeException">FirstName</exception>
	/// <exception cref="ArgumentNullException">FirstName</exception>
	[DataMember(Name = "firstName")]
	[XmlElement]
	public string FirstName
	{
		get => this._firstName;
		init
		{
			if (string.Equals(this._firstName, value, StringComparison.Ordinal))
			{
				return;
			}

			this._firstName = value.HasValue(0, 50) is false
				? throw new ArgumentOutOfRangeException(
					nameof(this.FirstName),
					Resources.FirstNameLengthIsLimitedTo50Characters)
				: value;
		}
	}

	/// <summary>
	/// Gets or sets the home phone number.
	/// </summary>
	/// <value>The home phone.</value>
	/// <exception cref="ArgumentOutOfRangeException">HomePhone</exception>
	/// <exception cref="ArgumentNullException">HomePhone</exception>
	[DataMember(Name = "homePhone")]
	[XmlElement]
	public string HomePhone
	{
		get => this._homePhone;
		init
		{
			if (string.Equals(this._homePhone, value, StringComparison.Ordinal))
			{
				return;
			}

			this._homePhone = value.HasValue(0, 50) is false
				? throw new ArgumentOutOfRangeException(
					nameof(this.HomePhone),
					Resources.PhoneNumberIsLimitedTo50Characters)
				: value;
		}
	}

	//#if NET7_0_OR_GREATER
	//		/// <summary>
	//	/// Gets or sets the identifier.
	//	/// </summary>
	//	/// <value>The identifier.</value>
	//	[DisallowNull]
	//	[DataMember(Name = "id")]
	//	[XmlElement]
	//	public required string Id { get; init; }
	//#else
	/// <summary>
	/// Gets or sets the identifier.
	/// </summary>
	/// <value>The identifier.</value>
	[DisallowNull]
	[DataMember(Name = "id")]
	[XmlElement]
	public string Id { get; init; }
	//#endif
	/// <summary>
	/// Gets or sets the last name.
	/// </summary>
	/// <value>The last name.</value>
	/// <exception cref="ArgumentOutOfRangeException">LastName</exception>
	/// <exception cref="ArgumentNullException">LastName</exception>
	[DataMember(Name = "lastName")]
	[XmlElement]
	public string LastName
	{
		get => this._lastName;
		init
		{
			if (string.Equals(this._lastName, value, StringComparison.Ordinal))
			{
				return;
			}

			this._lastName = value.HasValue(0, 50) is false
				? throw new ArgumentOutOfRangeException(
					nameof(this.LastName),
					Resources.LastNameLengthIsLimitedTo50Characters)
				: value;
		}
	}
}
