// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6
// Author           : David McCarter
// Created          : 03-02-2021
//
// Last Modified By : David McCarter
// Last Modified On : 08-23-2021
// ***********************************************************************
// <copyright file="GlobalSuppressions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "<Pending>", Scope = "member", Target = "~M:dotNetTips.Spargine.IO.DriveHelper.GetDriveSerialNumber(System.String)~System.String")]
[assembly: SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "<Pending>", Scope = "member", Target = "~M:dotNetTips.Spargine.Services.AllServices~System.Collections.Generic.IEnumerable{System.String}")]
[assembly: SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "<Pending>", Scope = "member", Target = "~M:dotNetTips.Spargine.Services.StopService(System.String)~dotNetTips.Spargine.ServiceActionResult")]
[assembly: SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "<Pending>", Scope = "member", Target = "~M:dotNetTips.Spargine.Services.StartService(System.String)~dotNetTips.Spargine.ServiceActionResult")]
[assembly: SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "<Pending>", Scope = "member", Target = "~M:dotNetTips.Spargine.Services.LoadService(System.String)~System.ServiceProcess.ServiceController")]
[assembly: SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "<Pending>", Scope = "member", Target = "~M:dotNetTips.Spargine.Services.ServiceStatus(System.String)~System.ServiceProcess.ServiceControllerStatus")]
[assembly: SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "<Pending>", Scope = "member", Target = "~M:dotNetTips.Spargine.Win32.RegistryHelper.GetRegistryKey(System.String,Microsoft.Win32.RegistryHive)~Microsoft.Win32.RegistryKey")]
[assembly: SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "<Pending>", Scope = "member", Target = "~M:dotNetTips.Spargine.IO.DirectoryHelper.LoadOneDriveFolders~System.Collections.Immutable.ImmutableArray{dotNetTips.Spargine.IO.OneDriveFolder}")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<Pending>", Scope = "member", Target = "~M:dotNetTips.Spargine.IO.DirectoryHelper.DeleteDirectory(System.IO.DirectoryInfo)")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<Pending>", Scope = "member", Target = "~M:dotNetTips.Spargine.IO.DirectoryHelper.SafeDirectorySearch(System.IO.DirectoryInfo,System.String,System.IO.SearchOption)~System.Collections.Generic.IEnumerable{System.IO.DirectoryInfo}")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "<Pending>", Scope = "member", Target = "~M:dotNetTips.Spargine.IO.FileProcessor.CopyFiles(System.Collections.Generic.IEnumerable{System.IO.FileInfo},System.IO.DirectoryInfo)~System.Int32")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<Pending>", Scope = "member", Target = "~M:dotNetTips.Spargine.IO.PathHelper.PathHasInvalidChars(System.String)~System.Boolean")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<Pending>", Scope = "member", Target = "~M:dotNetTips.Spargine.IO.PathHelper.HasInvalidFilterChars(System.String)~System.Boolean")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<Pending>", Scope = "member", Target = "~M:dotNetTips.Spargine.Net.Http.HttpClientHelper.GetHttpResponseAsync(System.String,System.Threading.CancellationTokenSource)~System.Threading.Tasks.Task{System.Net.Http.HttpResponseMessage}")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<Pending>", Scope = "member", Target = "~M:dotNetTips.Spargine.IO.FileHelper.CopyFile(System.IO.FileInfo,System.IO.DirectoryInfo)~System.Int64")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<Pending>", Scope = "member", Target = "~M:dotNetTips.Spargine.IO.FileProcessor.CopyFiles(System.Collections.Generic.IEnumerable{System.IO.FileInfo},System.IO.DirectoryInfo)~System.Int32")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<Pending>", Scope = "member", Target = "~M:dotNetTips.Spargine.IO.FileHelper.CopyFileAsync(System.IO.FileInfo,System.IO.DirectoryInfo)~System.Threading.Tasks.Task{System.Int64}")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<Pending>", Scope = "member", Target = "~M:dotNetTips.Spargine.Net.Sockets.SocketsHelper.ConnectTcpAsync(System.Net.Http.SocketsHttpConnectionContext,System.Threading.CancellationToken)~System.Threading.Tasks.ValueTask{System.IO.Stream}")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<Pending>", Scope = "member", Target = "~M:dotNetTips.Spargine.Net.Http.HttpClientHelper.GetHttpResponseAsync(System.Uri)~System.Threading.Tasks.Task{System.Net.Http.HttpResponseMessage}")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<Pending>", Scope = "member", Target = "~M:dotNetTips.Spargine.Extensions.RegistryExtensions.GetValue``1(Microsoft.Win32.RegistryKey,System.String)~``0")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<Pending>", Scope = "member", Target = "~M:dotNetTips.Spargine.Extensions.RegistryExtensions.GetSubKey(Microsoft.Win32.RegistryKey,System.String)~Microsoft.Win32.RegistryKey")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<Pending>", Scope = "member", Target = "~M:dotNetTips.Spargine.IO.FileHelper.FileHasInvalidChars(System.String)~System.Boolean")]
[assembly: SuppressMessage("Design", "CA1054:URI-like parameters should not be strings", Justification = "<Pending>", Scope = "member", Target = "~M:dotNetTips.Spargine.Net.Http.HttpClientHelper.GetStreamAsync(System.String)~System.Threading.Tasks.Task{System.IO.Stream}")]
[assembly: SuppressMessage("Design", "CA1054:URI-like parameters should not be strings", Justification = "<Pending>", Scope = "member", Target = "~M:dotNetTips.Spargine.Net.Http.HttpClientHelper.GetHttpResponseAsync(System.String,System.Threading.CancellationTokenSource)~System.Threading.Tasks.Task{System.Net.Http.HttpResponseMessage}")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<Pending>", Scope = "member", Target = "~M:dotNetTips.Spargine.IO.FileHelper.DownloadFileFromWebAndUnzipAsync(System.Uri,System.String)~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Naming", "CA1724:Type names should not match namespaces", Justification = "<Pending>", Scope = "type", Target = "~T:dotNetTips.Spargine.Services")]
[assembly: SuppressMessage("Major Code Smell", "S2589:Boolean expressions should not be gratuitous", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.IO.FileHelper.CheckPermission(System.String,System.Security.AccessControl.FileSystemRights)~System.Boolean")]
[assembly: SuppressMessage("Major Code Smell", "S2589:Boolean expressions should not be gratuitous", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.IO.DirectoryHelper.CheckPermission(System.String,System.Security.AccessControl.FileSystemRights)~System.Boolean")]
