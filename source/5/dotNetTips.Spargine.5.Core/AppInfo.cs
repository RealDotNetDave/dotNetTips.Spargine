// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Core
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 04-15-2021
// ***********************************************************************
// <copyright file="AppInfo.cs" company="dotNetTips.Spargine.5.Core">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using dotNetTips.Spargine.Core.Properties;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Core
{
	/// <summary>
	/// Class Info.
	/// </summary>
	[ExcludeFromCodeCoverage]
	public record AppInfo
	{
		/// <summary>
		/// Gets the company.
		/// </summary>
		/// <value>The company.</value>
		public string Company
		{
			get; init;
		}

		/// <summary>
		/// Gets the configuration.
		/// </summary>
		/// <value>The configuration.</value>
		public string Configuration
		{
			get; init;
		}

		/// <summary>
		/// Gets the copyright.
		/// </summary>
		/// <value>The copyright.</value>
		public string Copyright
		{
			get; init;
		}

		/// <summary>
		/// Gets the culture.
		/// </summary>
		/// <value>The culture.</value>
		public string Culture
		{
			get; init;
		}

		/// <summary>
		/// Gets the description.
		/// </summary>
		/// <value>The description.</value>
		public string Description
		{
			get; init;
		}

		/// <summary>
		/// Gets the file version.
		/// </summary>
		/// <value>The file version.</value>
		public string FileVersion
		{
			get; init;
		}

		/// <summary>
		/// Gets the memory allocated.
		/// </summary>
		/// <value>The memory allocated.</value>
		public long MemoryAllocated { get; internal set; }

		/// <summary>
		/// Gets the memory information.
		/// </summary>
		/// <value>The memory information.</value>
		public GCMemoryInfo MemoryInfo { get; internal set; }

		/// <summary>
		/// Gets the assembly product.
		/// </summary>
		/// <value>The assembly product.</value>
		public string Product
		{
			get; init;

		}

		/// <summary>
		/// Gets the thread allocated bytes.
		/// </summary>
		/// <value>The thread allocated bytes.</value>
		public long ThreadAllocatedBytes { get; internal set; }

		/// <summary>
		/// Gets the assembly title.
		/// </summary>
		/// <value>The assembly title.</value>
		public string Title
		{
			get; init;
		}

		/// <summary>
		/// Gets the total allocated bytes.
		/// </summary>
		/// <value>The total allocated bytes.</value>
		public long TotalAllocatedBytes { get; internal set; }

		/// <summary>
		/// Gets the assembly version.
		/// </summary>
		/// <value>The assembly version.</value>
		public string Version
		{
			get; init;
		}

		/// <summary>
		/// Names the application name and version.
		/// </summary>
		/// <returns>System.String.</returns>
		public string NameAndVersion() => string.Format(CultureInfo.CurrentCulture, Resources.AppNameAndVersion, this.Product, this.Version);
	}
}
