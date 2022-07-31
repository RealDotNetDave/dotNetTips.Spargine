// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Core
// Author           : David McCarter
// Created          : 12-23-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-31-2022
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
[assembly: SuppressMessage("Major Bug", "S2259:Null pointers should not be dereferenced", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1.Add(`0)")]
[assembly: SuppressMessage("Roslynator", "RCS1049:Simplify boolean comparison.", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString``2(System.Collections.Generic.Dictionary{``0,``1},System.Char)~System.String")]
[assembly: SuppressMessage("IDisposableAnalyzers.Correctness", "IDISP003:Dispose previous before re-assigning", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Core.Network.HttpRequestsObserver.OnNext(System.Diagnostics.DiagnosticListener)")]
[assembly: SuppressMessage("Critical Code Smell", "S1186:Methods should not be empty", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Core.Network.HttpRequestsObserver.OnCompleted")]
[assembly: SuppressMessage("Critical Code Smell", "S1186:Methods should not be empty", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Core.Network.HttpRequestsObserver.OnError(System.Exception)")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Core.TypeHelper.FindDerivedTypes(System.IO.DirectoryInfo,System.IO.SearchOption,System.Type,DotNetTips.Spargine.Core.Tristate)~System.Collections.Generic.IEnumerable{System.Type}")]
[assembly: SuppressMessage("Roslynator", "RCS1084:Use coalesce expression instead of conditional expression.", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Core.TypeHelper.Create``1~``0")]
[assembly: SuppressMessage("Roslynator", "RCS1049:Simplify boolean comparison.", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Core.Extensions.HasValue(System.String)~System.Boolean")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Core.Network.HttpRequestsObserver.OnNext(System.Diagnostics.DiagnosticListener)")]
