// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6
// Author           : David McCarter
// Created          : 03-02-2021
//
// Last Modified By : David McCarter
// Last Modified On : 11-02-2023
// ***********************************************************************
// <copyright file="DriveHelper.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Common methods for use when working with disk drives.</summary>
// ***********************************************************************
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Management;
using System.Runtime.Versioning;
using DotNetTips.Spargine.Core;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.IO;

/// <summary>
/// Class DriveHelper.
/// </summary>
[SupportedOSPlatform("windows")]
public static class DriveHelper
{

	/// <summary>
	/// Gets the serial number of the drive.
	/// </summary>
	/// <param name="drive">The drive.</param>
	/// <returns>System.String.</returns>
	[Information(nameof(GetDriveSerialNumber), author: "David McCarter", createdOn: "9/6/2020", UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://dotnettips.wordpress.com/2007/12/14/finding-a-drives-serial-number/")]
	public static string GetDriveSerialNumber([NotNull] string drive)
	{
		drive = drive.ArgumentNotNullOrEmpty();

		var driveSerial = string.Empty;

		// No matter what is sent in, get just the drive letter
		var driveFixed = Path.GetPathRoot(drive).Replace(@"\", string.Empty, StringComparison.Ordinal);

		// Perform Query
		using (var querySearch = new ManagementObjectSearcher(
			$"SELECT VolumeSerialNumber FROM Win32_LogicalDisk Where Name = '{driveFixed}'"))
		{
			using (var queryCollection = querySearch.Get())
			{
				foreach (var driveInfo in queryCollection)
				{
					driveSerial = Convert.ToString(
						driveInfo.GetPropertyValue(propertyName: "VolumeSerialNumber"),
						CultureInfo.CurrentCulture);
				}
			}
		}

		return driveSerial;
	}

	/// <summary>
	/// Gets the fixed drives, that are ready, for a computer.
	/// </summary>
	/// <returns>IImmutableList&lt;DirectoryInfo&gt;.</returns>
	/// <example>Result Example - [0]: {C:\}</example>
	[Information(nameof(GetDriveSerialNumber), author: "David McCarter", createdOn: "9/6/2020", UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static IImmutableList<DriveInfo> GetFixedDrives()
	{
		return DriveInfo.GetDrives()
					.Where(p => p.DriveType == DriveType.Fixed && p.IsReady)
					.Distinct()
					.ToImmutableList();
	}

	/// <summary>
	/// Gets the removable drives, that are ready, for a computer.
	/// </summary>
	/// <returns>IImmutableList&lt;DriveInfo&gt;.</returns>
	/// <example>Result example - [0]: {E:\} [1]: {F:\}</example>
	[Information(nameof(GetDriveSerialNumber), author: "David McCarter", createdOn: "9/6/2020", UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static IImmutableList<DriveInfo> GetRemovableDrives()
	{
		return DriveInfo.GetDrives()
					.Where(p => p.DriveType == DriveType.Removable && p.IsReady)
					.Distinct()
					.ToImmutableList();
	}

}
