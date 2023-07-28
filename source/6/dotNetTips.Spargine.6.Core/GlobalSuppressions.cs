// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Core
// Author           : David McCarter
// Created          : 12-23-2020
//
// Last Modified By : David McCarter
// Last Modified On : 03-20-2023
// ***********************************************************************
// <copyright file="GlobalSuppressions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Minor Code Smell", "S101:Types should be named in PascalCase", Justification = "<Pending>", Scope = "type", Target = "~T:DotNetTips.Spargine.Core.Security.SHA256PasswordHasher")]
[assembly: SuppressMessage("Style", "IDE0059:Unnecessary assignment of a value", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String,System.Boolean,System.String,System.String,System.String)~System.String")]
[assembly: SuppressMessage("Style", "IDE0059:Unnecessary assignment of a value", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition``1(``0,System.Boolean,``0,System.String,System.String)~``0")]
[assembly: SuppressMessage("Major Code Smell", "S2743:Static fields should not be used in generic types", Justification = "<Pending>", Scope = "member", Target = "~F:DotNetTips.Spargine.Core.Config`1._instance")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Core.Validator.ArgumentExists(System.IO.DirectoryInfo,System.IO.DirectoryInfo,System.String,System.String)~System.IO.DirectoryInfo")]
[assembly: SuppressMessage("Performance", "CA1829:Use Length/Count property instead of Count() when available", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1.ExceptWith(System.Collections.Generic.IEnumerable{`0})")]
[assembly: SuppressMessage("Performance", "CA1829:Use Length/Count property instead of Count() when available", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1.IntersectWith(System.Collections.Generic.IEnumerable{`0})")]
[assembly: SuppressMessage("IDisposableAnalyzers.Correctness", "IDISP003:Dispose previous before re-assigning", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Core.Network.HttpRequestsObserver.OnNext(System.Diagnostics.DiagnosticListener)")]
[assembly: SuppressMessage("Critical Code Smell", "S1186:Methods should not be empty", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Core.Network.HttpRequestsObserver.OnCompleted")]
[assembly: SuppressMessage("Critical Code Smell", "S1186:Methods should not be empty", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Core.Network.HttpRequestsObserver.OnError(System.Exception)")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Core.TypeHelper.FindDerivedTypes(System.IO.DirectoryInfo,System.IO.SearchOption,System.Type,DotNetTips.Spargine.Core.Tristate)~System.Collections.Generic.IEnumerable{System.Type}")]
[assembly: SuppressMessage("Roslynator", "RCS1084:Use coalesce expression instead of conditional expression.", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Core.TypeHelper.Create``1~``0")]
[assembly: SuppressMessage("Roslynator", "RCS1049:Simplify boolean comparison.", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Core.Extensions.HasValue(System.String)~System.Boolean")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Core.Network.HttpRequestsObserver.OnNext(System.Diagnostics.DiagnosticListener)")]
[assembly: SuppressMessage("Major Code Smell", "S2743:Static fields should not be used in generic types", Justification = "<Pending>", Scope = "member", Target = "~P:DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1.DefaultConcurrencyLevel")]
[assembly: SuppressMessage("Design", "CA1000:Do not declare static members on generic types", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Core.Collections.Generic.Collection`1.Create~DotNetTips.Spargine.Core.Collections.Generic.Collection`1")]
[assembly: SuppressMessage("Design", "CA1000:Do not declare static members on generic types", Justification = "<Pending>", Scope = "member", Target = "~P:DotNetTips.Spargine.Core.Singleton`1.Instance")]
[assembly: SuppressMessage("Reliability", "CA2008:Do not create tasks without passing a TaskScheduler", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Core.TaskHelper.RunSync``1(System.Func{System.Threading.Tasks.Task{``0}},System.Threading.CancellationToken,System.Threading.Tasks.TaskCreationOptions,System.Threading.Tasks.TaskContinuationOptions,System.Threading.Tasks.TaskScheduler)~``0")]
[assembly: SuppressMessage("Reliability", "CA2008:Do not create tasks without passing a TaskScheduler", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Core.TaskHelper.RunSync(System.Func{System.Threading.Tasks.Task},System.Threading.CancellationToken,System.Threading.Tasks.TaskCreationOptions,System.Threading.Tasks.TaskContinuationOptions,System.Threading.Tasks.TaskScheduler)")]
[assembly: SuppressMessage("Design", "CA1000:Do not declare static members on generic types", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Core.Collections.Generic.Collection`1.Create(System.Int32)~DotNetTips.Spargine.Core.Collections.Generic.Collection`1")]
[assembly: SuppressMessage("Design", "CA1000:Do not declare static members on generic types", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Core.Collections.Generic.Collection`1.Create(System.Collections.Generic.IEnumerable{`0},DotNetTips.Spargine.Core.Tristate)~DotNetTips.Spargine.Core.Collections.Generic.Collection`1")]
[assembly: SuppressMessage("Design", "CA1000:Do not declare static members on generic types", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Core.Collections.Generic.Collection`1.Create(System.Collections.Generic.IEnumerable{`0})~DotNetTips.Spargine.Core.Collections.Generic.Collection`1")]
[assembly: SuppressMessage("Roslynator", "RCS1049:Simplify boolean comparison.", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Core.Serialization.JsonSerialization.SerializeToFile(System.Object,System.String)")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Core.Validator.CheckExists(System.IO.DirectoryInfo,System.Boolean,System.Boolean,System.String)~System.Boolean")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Core.Validator.CheckExists(System.IO.FileInfo,System.Boolean,System.String)~System.Boolean")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Core.Validator.ArgumentExists(System.IO.FileInfo,System.IO.FileInfo,System.String,System.String)~System.IO.FileInfo")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Core.DataRecordComparer.GetHashCode(DotNetTips.Spargine.Core.IDataRecord)~System.Int32")]
[assembly: SuppressMessage("Design", "CA1000:Do not declare static members on generic types", Justification = "<Pending>", Scope = "member", Target = "~P:DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1.DefaultConcurrencyLevel")]
[assembly: SuppressMessage("Spellchecker", "CRRSP08:A misspelled word has been found", Justification = "<Pending>", Scope = "member", Target = "~F:DotNetTips.Spargine.Core.EnvironmentKey.windir")]
[assembly: SuppressMessage("Naming", "CA1710:Identifiers should have correct suffix", Justification = "<Pending>", Scope = "type", Target = "~T:DotNetTips.Spargine.Core.Collections.Generic.ObservableList`1")]
[assembly: SuppressMessage("Naming", "CA1710:Identifiers should have correct suffix", Justification = "<Pending>", Scope = "type", Target = "~T:DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1")]
[assembly: SuppressMessage("Design", "CA1019:Define accessors for attribute arguments", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Core.PreserveAttribute.#ctor(DotNetTips.Spargine.Core.PreserveReason,System.String,System.String,System.String)")]
[assembly: SuppressMessage("Build", "IDE0005:Using directive is unnecessary.", Justification = "<Pending>")]
[assembly: SuppressMessage("Design", "CA1060:Move pinvokes to native methods class", Justification = "<Pending>", Scope = "type", Target = "~T:DotNetTips.Spargine.Core.SourceGenerators")]
[assembly: SuppressMessage("Interoperability", "SYSLIB1054:Use 'LibraryImportAttribute' instead of 'DllImportAttribute' to generate P/Invoke marshalling code at compile time", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Core.SourceGenerators.GetSystemInfoDllImport(DotNetTips.Spargine.Core.SourceGenerators.SystemInfo@)")]
[assembly: SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>", Scope = "member", Target = "~F:DotNetTips.Spargine.Core.EnumHelper._titleCaseRegex")]
[assembly: SuppressMessage("GeneratedRegex", "SYSLIB1045:Convert to 'GeneratedRegexAttribute'.", Justification = "<Pending>", Scope = "member", Target = "~F:DotNetTips.Spargine.Core.EnumHelper._titleCaseRegex")]
[assembly: SuppressMessage("Design", "CA1000:Do not declare static members on generic types", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Core.SimpleResult`1.FromResult(DotNetTips.Spargine.Core.SimpleResult{`0}@)~`0")]
[assembly: SuppressMessage("Design", "CA1019:Define accessors for attribute arguments", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Core.InformationAttribute.#ctor(System.String,System.String,System.String)")]
[assembly: SuppressMessage("Design", "CA1019:Define accessors for attribute arguments", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Core.InformationAttribute.#ctor(System.String,System.String,System.String,System.String)")]
