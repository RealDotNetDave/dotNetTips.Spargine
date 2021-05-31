// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5
// Author           : David McCarter
// Created          : 03-02-2021
//
// Last Modified By : David McCarter
// Last Modified On : 03-02-2021
// ***********************************************************************
// <copyright file="DriveHelper.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
using System;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Management;
using dotNetTips.Spargine.Core;

namespace dotNetTips.Spargine.IO
{
	/// <summary>
	/// Class DriveHelper.
	/// </summary>
	public static class DriveHelper
	{
		/// <summary>
		/// Gets the serial number of a drive.
		/// </summary>
		/// <param name="drive">The drive.</param>
		/// <returns>System.String.</returns>
		[Information(nameof(GetDriveSerialNumber), author: "David McCarter", createdOn: "9/6/2020", UnitTestCoverage = 100, Status = Status.New, Documentation = "ADD JUNE 21 URL")]
		public static string GetDriveSerialNumber(string drive)
		{
			Validate.TryValidateParam(drive, nameof(drive));

			var driveSerial = string.Empty;

			// No matter what is sent in, get just the drive letter
			var driveFixed = Path.GetPathRoot(drive).Replace(@"\", string.Empty);

			// Perform Query
			using (var querySearch = new ManagementObjectSearcher(string.Format(format: "SELECT VolumeSerialNumber FROM Win32_LogicalDisk Where Name = '{0}'", driveFixed)))
			{
				using var queryCollection = querySearch.Get();

				foreach (var moItem in queryCollection)
				{
					driveSerial = Convert.ToString(moItem.GetPropertyValue(propertyName: "VolumeSerialNumber"));
					break;
				}
			}

			return driveSerial;
		}

		/// <summary>
		/// Gets the fixed drives, that are ready, for a computer.
		/// </summary>
		/// <returns>IImmutableList&lt;DirectoryInfo&gt;.</returns>
		/// <returns>System.String.</returns>
		[Information(nameof(GetDriveSerialNumber), author: "David McCarter", createdOn: "9/6/2020", UnitTestCoverage = 100, Status = Status.New, Documentation = "ADD JUNE 21 URL")]
		public static IImmutableList<DriveInfo> GetFixedDrives()
		{
			return DriveInfo.GetDrives()
				.Where(p => p.DriveType == DriveType.Fixed & p.IsReady)
				.Distinct()
				.ToImmutableList();
		}

		/// <summary>
		/// Gets the removable drives, that are ready, for a computer.
		/// </summary>
		/// <returns>IImmutableList&lt;DriveInfo&gt;.</returns>
		/// <returns>System.String.</returns>
		[Information(nameof(GetDriveSerialNumber), author: "David McCarter", createdOn: "9/6/2020", UnitTestCoverage = 100, Status = Status.New, Documentation = "ADD JUNE 21 URL")]
		public static IImmutableList<DriveInfo> GetRemovableDrives()
		{
			return DriveInfo.GetDrives()
				.Where(p => p.DriveType == DriveType.Removable & p.IsReady)
				.Distinct()
				.ToImmutableList();
		}
	}
}
