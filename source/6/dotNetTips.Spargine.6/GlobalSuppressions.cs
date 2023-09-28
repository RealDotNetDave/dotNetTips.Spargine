// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6
// Author           : David McCarter
// Created          : 03-02-2021
//
// Last Modified By : David McCarter
// Last Modified On : 07-17-2022
// ***********************************************************************
// <copyright file="GlobalSuppressions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Major Code Smell", "S2589:Boolean expressions should not be gratuitous", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.IO.FileHelper.CheckPermission(System.String,System.Security.AccessControl.FileSystemRights)~System.Boolean")]
[assembly: SuppressMessage("Major Code Smell", "S2589:Boolean expressions should not be gratuitous", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.IO.DirectoryHelper.CheckPermission(System.String,System.Security.AccessControl.FileSystemRights)~System.Boolean")]
[assembly: SuppressMessage("Roslynator", "RCS1171:Simplify lazy initialization.", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.IO.FileHelper.GetHttpClient~System.Net.Http.HttpClient")]
[assembly: SuppressMessage("IDisposableAnalyzers.Correctness", "IDISP014:Use a single instance of HttpClient", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.IO.FileHelper.GetHttpClient~System.Net.Http.HttpClient")]
[assembly: SuppressMessage("Roslynator", "RCS1049:Simplify boolean comparison.", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.IO.FileProcessor.CopyFiles(System.Collections.Generic.IEnumerable{System.IO.FileInfo},System.IO.DirectoryInfo)~System.Int32")]
[assembly: SuppressMessage("Roslynator", "RCS1049:Simplify boolean comparison.", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.IO.FileProcessor.DeleteFiles(System.Collections.Generic.IEnumerable{System.IO.FileInfo})~System.Int32")]
[assembly: SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.IO.DriveHelper.GetDriveSerialNumber(System.String)~System.String")]
[assembly: SuppressMessage("Roslynator", "RCS1049:Simplify boolean comparison.", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.IO.FileHelper.DownloadFileFromWebAsync(System.Uri,System.IO.DirectoryInfo)~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Roslynator", "RCS1049:Simplify boolean comparison.", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Services.StartService(System.String)~DotNetTips.Spargine.ServiceActionResult")]
[assembly: SuppressMessage("Roslynator", "RCS1049:Simplify boolean comparison.", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Services.StopService(System.String)~DotNetTips.Spargine.ServiceActionResult")]
[assembly: SuppressMessage("Security", "CA5389:Do Not Add Archive Item's Path To The Target File System Path", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.IO.FileHelper.UnWinZipAsync(System.String,System.String)~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Naming", "CA1724:Type names should not match namespaces", Justification = "<Pending>", Scope = "type", Target = "~T:DotNetTips.Spargine.Services")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.IO.FileHelper.DownloadFileFromWebAsync(System.Uri,System.IO.DirectoryInfo)~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.IO.FileHelper.UnGZipAsync(System.IO.FileInfo,System.IO.DirectoryInfo)~System.Threading.Tasks.Task")]
