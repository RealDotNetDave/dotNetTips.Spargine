// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6
// Author           : David McCarter
// Created          : 04-02-2021
//
// Last Modified By : David McCarter
// Last Modified On : 07-17-2022
// ***********************************************************************
// <copyright file="FileMoveOptions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.IO
{
	/// <summary>
	/// Enum FileMoveOptions
	/// </summary>
	[Flags]
	public enum FileMoveOptions
	{
		/// <summary>
		/// None
		/// </summary>
		None = 0,

		/// <summary>
		/// If the destination file exists, the function replaces its contents
		/// with the contents of the existing file, if security requirements
		/// regarding access control lists (ACLs) are met.
		/// </summary>
		ReplaceExisting = 1,

		/// <summary>
		/// If the file is to be moved to a different volume if the file is
		/// successfully copied to a different volume and the original file
		/// is unable to be deleted, the function succeeds leaving the source
		/// file intact. This value cannot be used with DelayUntilReboot.
		/// </summary>
		CopyAllowed = 2,

		/// <summary>
		/// The system does not move the file until the operating system is
		/// restarted. The system moves the file immediately after AUTOCHK is
		/// executed, but before creating any paging files. Consequently, this
		/// parameter enables the function to delete paging files from previous
		/// startups. This value can be used only if the process is in the context
		/// of a user who belongs to the administrator’s group or the LocalSystem
		/// account. This value cannot be used with CopyAllowed.
		/// </summary>
		DelayUntilReboot = 4,

		/// <summary>
		/// The function fails if the source file is a link source, but the file
		/// cannot be tracked after the move. This situation can occur if the
		/// destination is a volume formatted with the FAT file system.
		/// </summary>
		FailIfNotTrackable = 32,

		/// <summary>
		/// The function does not return until the file is actually moved on the
		/// disk. Setting this value guarantees that a move performed as a copy
		/// and delete operation is flushed to disk before the function returns.
		/// The flush occurs at the end of the copy operation.
		/// </summary>
		WriteThrough = 8,
	}
}
