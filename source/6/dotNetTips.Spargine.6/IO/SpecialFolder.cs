// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6
// Author           : David McCarter
// Created          : 03-02-2021
//
// Last Modified By : David McCarter
// Last Modified On : 03-04-2021
// ***********************************************************************
// <copyright file="SpecialFolder.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.IO;

/// <summary>
/// Enum SpecialFolder.
/// </summary>
public enum SpecialFolder
{
	/// <summary>
	/// The logical Desktop rather than the physical file system location.
	/// </summary>
	Desktop = 0,

	/// <summary>
	/// The directory that contains the user's program groups.
	/// </summary>
	Programs = 2,

	/// <summary>
	/// The directory that serves as a common repository for documents.
	/// </summary>
	Personal = 5,

	/// <summary>
	/// The directory that serves as a common repository for the user's favorite items.
	/// </summary>
	Favorites = 6,

	/// <summary>
	/// The directory that corresponds to the user's Startup program group.
	/// </summary>
	Startup = 7,

	/// <summary>
	/// The directory that contains the user's most recently used documents.
	/// </summary>
	Recent = 8,

	/// <summary>
	/// The directory that contains the Send To menu items.
	/// </summary>
	SendTo = 9,

	/// <summary>
	/// The directory that contains the Start menu items.
	/// </summary>
	StartMenu = 11,

	/// <summary>
	/// The My Music folder.
	/// </summary>
	MyMusic = 13,

	/// <summary>
	/// The file system directory that serves as a repository for videos that belong
	/// to a user. Added in the .NET Framework 4.
	/// </summary>
	MyVideos = 14,

	/// <summary>
	/// The directory used to physically store file objects on the desktop.
	/// </summary>
	DesktopDirectory = 16,

	/// <summary>
	/// The My Computer folder.
	/// </summary>
	MyComputer = 17,

	/// <summary>
	/// A file system directory that contains the link objects that may exist in the
	/// My Network Places virtual folder. Added in the .NET Framework 4.
	/// </summary>
	NetworkShortcuts = 19,

	/// <summary>
	/// A virtual folder that contains fonts. Added in the .NET Framework 4.
	/// </summary>
	Fonts = 20,

	/// <summary>
	/// The directory that serves as a common repository for document templates.
	/// </summary>
	Templates = 21,

	/// <summary>
	/// The file system directory that contains the programs and folders that appear
	/// on the Start menu for all users. This special folder is valid only for Windows
	/// NT systems. Added in the .NET Framework 4.
	/// </summary>
	CommonStartMenu = 22,

	/// <summary>
	/// A folder for components that are shared across applications. This special folder
	/// is valid only for Windows NT, Windows 2000, and Windows XP systems. Added in
	/// the .NET Framework 4.
	/// </summary>
	CommonPrograms = 23,

	/// <summary>
	/// The file system directory that contains the programs that appear in the Startup
	/// folder for all users. This special folder is valid only for Windows NT systems.
	/// Added in the .NET Framework 4.
	/// </summary>
	CommonStartup = 24,

	/// <summary>
	/// The file system directory that contains files and folders that appear on the
	/// desktop for all users. This special folder is valid only for Windows NT systems.
	/// Added in the .NET Framework 4.
	/// </summary>
	CommonDesktopDirectory = 25,

	/// <summary>
	/// The directory that serves as a common repository for application-specific data
	/// for the current roaming user.
	/// </summary>
	ApplicationData = 26,

	/// <summary>
	/// The file system directory that contains the link objects that can exist in the
	/// Printers virtual folder. Added in the .NET Framework 4.
	/// </summary>
	PrinterShortcuts = 27,

	/// <summary>
	/// The directory that serves as a common repository for application-specific data
	/// that is used by the current, non-roaming user.
	/// </summary>
	LocalApplicationData = 28,

	/// <summary>
	/// The directory that serves as a common repository for temporary Internet files.
	/// </summary>
	InternetCache = 32,

	/// <summary>
	/// The directory that serves as a common repository for Internet cookies.
	/// </summary>
	Cookies = 33,

	/// <summary>
	/// The directory that serves as a common repository for Internet history items.
	/// </summary>
	History = 34,

	/// <summary>
	/// The directory that serves as a common repository for application-specific data
	/// that is used by all users.
	/// </summary>
	CommonApplicationData = 35,

	/// <summary>
	/// The Windows directory or SYSROOT. This corresponds to the %windir% or %SYSTEMROOT%
	/// environment variables. Added in the .NET Framework 4.
	/// </summary>
	Windows = 36,

	/// <summary>
	/// The System directory.
	/// </summary>
	System = 37,

	/// <summary>
	/// The program files directory.On a non-x86 system, passing System.Environment.SpecialFolder.ProgramFiles
	/// to the System.Environment.GetFolderPath(System.Environment.SpecialFolder) method
	/// returns the path for non-x86 programs. To get the x86 program files directory
	/// on a non-x86 system, use the System.Environment.SpecialFolder.ProgramFilesX86 member.
	/// </summary>
	ProgramFiles = 38,

	/// <summary>
	/// The My Pictures folder.
	/// </summary>
	MyPictures = 39,

	/// <summary>
	/// The user's profile folder. Applications should not create files or folders at
	/// this level; they should put their data under the locations referred to by
	/// System.Environment.SpecialFolder.ApplicationData. Added in the .NET Framework 4.
	/// </summary>
	UserProfile = 40,

	/// <summary>
	/// The Windows System folder. Added in the .NET Framework 4.
	/// </summary>
	SystemX86 = 41,

	/// <summary>
	/// The x86 Program Files folder. Added in the .NET Framework 4.
	/// </summary>
	ProgramFilesX86 = 42,

	/// <summary>
	/// The directory for components that are shared across applications.To get the x86
	/// common program files directory on a non-x86 system, use the
	/// System.Environment.SpecialFolder.ProgramFilesX86 member.
	/// </summary>
	CommonProgramFiles = 43,

	/// <summary>
	/// The Program Files folder. Added in the .NET Framework 4.
	/// </summary>
	CommonProgramFilesX86 = 44,

	/// <summary>
	/// The file system directory that contains the templates that are available to all
	/// users. This special folder is valid only for Windows NT systems. Added in the
	/// .NET Framework 4.
	/// </summary>
	CommonTemplates = 45,

	/// <summary>
	/// The file system directory that contains documents that are common to all users.
	/// This special folder is valid for Windows NT systems, Windows 95, and Windows
	/// 98 systems with Shfolder.dll installed. Added in the .NET Framework 4.
	/// </summary>
	CommonDocuments = 46,

	/// <summary>
	/// The file system directory that contains administrative tools for all users of
	/// the computer. Added in the .NET Framework 4.
	/// </summary>
	CommonAdminTools = 47,

	/// <summary>
	/// The file system directory that is used to store administrative tools for an individual
	/// user. The Microsoft Management Console (MMC) will save customized consoles to
	/// this directory, and it will roam with the user. Added in the .NET Framework 4.
	/// </summary>
	AdminTools = 48,

	/// <summary>
	/// The file system directory that serves as a repository for music files common
	/// to all users. Added in the .NET Framework 4.
	/// </summary>
	CommonMusic = 53,

	/// <summary>
	/// The file system directory that serves as a repository for image files common
	/// to all users. Added in the .NET Framework 4.
	/// </summary>
	CommonPictures = 54,

	/// <summary>
	/// The file system directory that serves as a repository for video files common
	/// to all users. Added in the .NET Framework 4.
	/// </summary>
	CommonVideos = 55,

	/// <summary>
	/// The file system directory that contains resource data. Added in the .NET Framework 4.
	/// </summary>
	Resources = 56,

	/// <summary>
	/// The file system directory that contains localized resource data. Added in the
	/// .NET Framework 4.
	/// </summary>
	LocalizedResources = 57,

	/// <summary>
	/// This value is recognized in Windows Vista for backward compatibility, but the
	/// special folder itself is no longer used. Added in the .NET Framework 4.
	/// </summary>
	CommonOemLinks = 58,

	/// <summary>
	/// The file system directory that acts as a staging area for files waiting to be
	/// written to a CD. Added in the .NET Framework 4.
	/// </summary>
	CDBurning = 59,

	/// <summary>
	/// The My Documents folder.
	/// </summary>
	UserDocuments = 60,

	/// <summary>
	/// The Microsoft .NET folder.
	/// </summary>
	MicrosoftNet = 500,
}
