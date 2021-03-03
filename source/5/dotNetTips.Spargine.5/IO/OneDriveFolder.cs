using System.IO;
using dotNetTips.Spargine.Extensions;

namespace dotNetTips.Spargine.IO
{
	public class OneDriveFolder
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="OneDriveFolder" /> class.
		/// </summary>
		public OneDriveFolder()
		{
			this.InitializeFields();
		}

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
