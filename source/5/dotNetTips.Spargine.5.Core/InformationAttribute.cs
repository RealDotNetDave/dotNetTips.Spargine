// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core
// Author           : David McCarter
// Created          : 09-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 12-27-2021
// ***********************************************************************
// <copyright file="InformationAttribute.cs" company="dotNetTips.Spargine.Core">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using dotNetTips.Spargine.Core.Properties;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png; https://www.spargine.net )
namespace dotNetTips.Spargine.Core
{

	/// <summary>
	/// Class InformationAttribute. This class cannot be inherited.
	/// Implements the <see cref="Attribute" />
	/// </summary>
	/// <seealso cref="Attribute" />
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Delegate, Inherited = false)]
	public sealed class InformationAttribute : Attribute
	{
		/// <summary>
		/// The unit test coverage
		/// </summary>
		private int _unitTestCoverage;

		/// <summary>
		/// Initializes a new instance of the <see cref="InformationAttribute" /> class.
		/// </summary>
		public InformationAttribute()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="InformationAttribute" /> class.
		/// </summary>
		/// <param name="description">The description.</param>
		public InformationAttribute(string description)
			: this(description, string.Empty, string.Empty, string.Empty)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="InformationAttribute" /> class.
		/// </summary>
		/// <param name="description">The message.</param>
		/// <param name="author">The author.</param>
		/// <param name="createdOn">The created on.</param>
		public InformationAttribute(string description, string author, string createdOn)
			: this(description, author, createdOn, createdOn)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="InformationAttribute" /> class.
		/// </summary>
		/// <param name="description">The message.</param>
		/// <param name="author">The author.</param>
		/// <param name="createdOn">The created on.</param>
		/// <param name="modifiedOn">The modified on.</param>
		public InformationAttribute(string description, string author, string createdOn, string modifiedOn)
		{
			this.Description = description;

			this.Author = string.IsNullOrEmpty(author) ? Resources.UserUnknown : author;

			if (string.IsNullOrEmpty(createdOn) == false && DateTimeOffset.TryParse(createdOn, out var createdDate))
			{
				this.CreatedOn = createdDate;

				if (string.IsNullOrEmpty(modifiedOn) == DateTimeOffset.TryParse(modifiedOn, out var modifiedDate))
				{
					this.ModifiedOn = modifiedDate;
				}
			}

			if (string.IsNullOrEmpty(this.ModifiedBy))
			{
				this.ModifiedBy = author;
			}
		}

		/// <summary>
		/// Gets the author.
		/// </summary>
		/// <value>The author.</value>
		public string Author { get; }

		/// <summary>
		/// Gets or sets the benchmark status.
		/// </summary>
		/// <value>The bench mark status.</value>
		public BenchMarkStatus BenchMarkStatus { get; set; } = BenchMarkStatus.None;

		/// <summary>
		/// Gets the created on date.
		/// </summary>
		/// <value>The created on.</value>
		public DateTimeOffset CreatedOn { get; }

		/// <summary>
		/// Gets the description of the type, method or event.
		/// </summary>
		/// <value>The message.</value>
		public string Description { get; }

		/// <summary>
		/// Gets or sets the Uri for external documentation.
		/// </summary>
		/// <value>The documentation Uri.</value>
		public string Documentation { get; set; }

		/// <summary>
		/// Gets or sets the modified by.
		/// </summary>
		/// <value>The modified by.</value>
		public string ModifiedBy { get; set; }

		/// <summary>
		/// Gets the modified on date.
		/// </summary>
		/// <value>The modified on.</value>
		public DateTimeOffset ModifiedOn { get; }

		/// <summary>
		/// Gets or sets the status.
		/// </summary>
		/// <value>The status.</value>
		public Status Status { get; set; } = Status.NotSet;

		/// <summary>
		/// Gets or sets the unit test coverage.
		/// </summary>
		/// <value>The unit test coverage.</value>
		/// <exception cref="ArgumentOutOfRangeException">value - Unit test coverage must be in the range of 0 - 100.</exception>
		/// <remarks>Value must be between 0 - 100</remarks>
		public int UnitTestCoverage
		{
			get => this._unitTestCoverage;
			set
			{
				if (this._unitTestCoverage == value)
				{
					return;
				}

				if (value.IsInRange(0, 100))
				{
					this._unitTestCoverage = value;
				}
				else
				{
					ExceptionThrower.ThrowArgumentOutOfRangeException("Unit test coverage must be in the range of 0 - 100.", nameof(value));
				}
			}
		}
	}
}
