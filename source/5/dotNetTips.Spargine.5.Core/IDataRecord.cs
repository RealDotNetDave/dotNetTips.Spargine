// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Core
// Author           : David McCarter
// Created          : 02-01-2021
//
// Last Modified By : David McCarter
// Last Modified On : 06-22-2021
// ***********************************************************************
// <copyright file="IDataRecord.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using dotNetTips.Spargine.Core.Internal;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Core
{
	/// <summary>
	/// Interface for data record classes.
	/// </summary>
	[Information(nameof(IDataRecord), author: "David McCarter", createdOn: "3/4/2021", BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "http://bit.ly/SpargineMarch2021")]
	public interface IDataRecord
	{
		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
		[Required]
		[MaxLength(length: 50, ErrorMessage = "Id must be 10 characters to a max of 50.")]
		[MinLength(length: 10, ErrorMessage = "Id must be 10 characters to a max of 50.")]
		[DisallowNull]
		public string Id { get; init; }

		/// <summary>
		/// Alls the properties to string.
		/// </summary>
		/// <returns>string.</returns>
		/// <remarks>This method uses reflection.</remarks>
		public sealed string AllPropertiesToString() => this.PropertiesToString();
	}
}
