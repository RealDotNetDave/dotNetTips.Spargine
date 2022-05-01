// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6
// Author           : David McCarter
// Created          : 03-01-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-20-2022
// ***********************************************************************
// <copyright file="OneDriveFolder.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using DotNetTips.Spargine.Extensions;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.IO
{
	/// <summary>
	/// Class OneDriveFolder.
	/// </summary>
	public class OneDriveFolder
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="OneDriveFolder" /> class.
		/// </summary>
		public OneDriveFolder() => this.InitializeFields();

		/// <summary>
		/// Gets the name of the account.
		/// </summary>
		/// <value>The name of the account.</value>
		public string AccountName { get; internal set; }

		/// <summary>
		/// Gets the type of the account.
		/// </summary>
		/// <value>The type of the account.</value>
		public OneDriveAccountType AccountType { get; internal set; } = OneDriveAccountType.Personal;

		/// <summary>
		/// Gets the directory information.
		/// </summary>
		/// <value>The directory information.</value>
		public DirectoryInfo DirectoryInfo { get; internal set; }

		/// <summary>
		/// Gets the account email.
		/// </summary>
		/// <value>The account email.</value>
		public string UserEmail { get; internal set; }
	}
}
