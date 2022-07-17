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
