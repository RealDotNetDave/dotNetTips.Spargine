// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-03-2023
// ***********************************************************************
// <copyright file="GlobalSuppressions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Roslynator", "RCS1046:Asynchronous method name should end with 'Async'.", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Extensions.EnumerableExtensions.FastParallelProcessor``1(System.Collections.Generic.IEnumerable{``0},System.Action{``0},System.Int32,System.Boolean,System.Threading.Tasks.TaskScheduler)~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Performance", "CA1829:Use Length/Count property instead of Count() when available", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Extensions.ListExtensions.HasItems``1(System.Collections.Generic.List{``0})~System.Boolean")]
[assembly: SuppressMessage("Performance", "CA1829:Use Length/Count property instead of Count() when available", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Extensions.ListExtensions.HasItems``1(System.Collections.Generic.List{``0},System.Int32)~System.Boolean")]
[assembly: SuppressMessage("Roslynator", "RCS1049:Simplify boolean comparison.", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Extensions.ArrayExtensions.AddIfNotExists``1(``0[],``0[])~``0[]")]
[assembly: SuppressMessage("Major Code Smell", "S1854:Unused assignments should be removed", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Extensions.ArrayExtensions.GenerateHashCode``1(``0[])~System.Int32")]
[assembly: SuppressMessage("Roslynator", "RCS1049:Simplify boolean comparison.", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Extensions.DictionaryExtensions.AddIfNotExists``2(System.Collections.Generic.IDictionary{``0,``1},``0,``1)~System.Boolean")]
[assembly: SuppressMessage("Roslynator", "RCS1049:Simplify boolean comparison.", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd``2(System.Collections.Generic.IDictionary{``0,``1},``0,``1)~``1")]
[assembly: SuppressMessage("Style", "IDE0075:Simplify conditional expression", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems``2(System.Collections.Generic.IDictionary{``0,``1},System.Func{System.Collections.Generic.KeyValuePair{``0,``1},System.Boolean})~System.Boolean")]
[assembly: SuppressMessage("Naming", "CA1720:Identifier contains type name", Justification = "<Pending>", Scope = "member", Target = "~F:DotNetTips.Spargine.Extensions.NumericFormat.Decimal")]
[assembly: SuppressMessage("Info Code Smell", "S1135:Track uses of \"TODO\" tags", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String,System.String,DotNetTips.Spargine.Core.Tristate,System.String[])~System.String")]
[assembly: SuppressMessage("Major Code Smell", "S125:Sections of code should not be commented out", Justification = "<Pending>", Scope = "type", Target = "~T:DotNetTips.Spargine.Extensions.GuidExtensions")]
[assembly: SuppressMessage("Major Code Smell", "S125:Sections of code should not be commented out", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson``1(System.String)~``0")]
[assembly: SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Extensions.StringExtensions.ToBrotliStringAsync(System.String,System.IO.Compression.CompressionLevel)~System.Threading.Tasks.Task{System.String}")]
[assembly: SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Extensions.StringExtensions.ToDeflateStringAsync(System.String,System.IO.Compression.CompressionLevel)~System.Threading.Tasks.Task{System.String}")]
[assembly: SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Extensions.StringExtensions.ToGZipStringAsync(System.String,System.IO.Compression.CompressionLevel)~System.Threading.Tasks.Task{System.String}")]
[assembly: SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Extensions.StringExtensions.ToZLibStringAsync(System.String,System.IO.Compression.CompressionLevel)~System.Threading.Tasks.Task{System.String}")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String,System.String,DotNetTips.Spargine.Core.Tristate,System.String[])~System.String")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Extensions.ListExtensions.HasItems``1(System.Collections.Generic.List{``0},System.Predicate{``0})~System.Boolean")]
[assembly: SuppressMessage("Design", "CA1030:Use events where appropriate", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Extensions.TaskExtensions.FireAndForget(System.Threading.Tasks.Task)")]
[assembly: SuppressMessage("Style", "IDE0075:Simplify conditional expression", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Extensions.ListExtensions.ClearNulls``1(System.Collections.Generic.List{``0})~System.Boolean")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object,System.String,System.Boolean)~System.Collections.Generic.IDictionary{System.String,System.String}")]
[assembly: SuppressMessage("Roslynator", "RCS1104:Simplify conditional expression.", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Extensions.ListExtensions.ClearNulls``1(System.Collections.Generic.List{``0})~System.Boolean")]
[assembly: SuppressMessage("IDisposableAnalyzers.Correctness", "IDISP007:Don't dispose injected", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Extensions.ObjectExtensions.TryDispose(System.IDisposable,System.Boolean)")]
[assembly: SuppressMessage("Performance", "CA1851:Possible multiple enumerations of 'IEnumerable' collection", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Extensions.ColorExtensions.Average(System.Collections.Generic.IEnumerable{System.Drawing.Color})~System.Drawing.Color")]
[assembly: SuppressMessage("Performance", "CA1851:Possible multiple enumerations of 'IEnumerable' collection", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Extensions.EnumerableExtensions.Split``1(System.Collections.Generic.IEnumerable{``0},System.Int32)~System.Collections.Generic.IEnumerable{System.Collections.Generic.IEnumerable{``0}}")]
[assembly: SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>", Scope = "member", Target = "~F:DotNetTips.Spargine.Extensions.StringExtensions._guidRegEx")]
[assembly: SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>", Scope = "member", Target = "~F:DotNetTips.Spargine.Extensions.StringExtensions._macAddressRegEx")]
[assembly: SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>", Scope = "member", Target = "~F:DotNetTips.Spargine.Extensions.StringExtensions._sha1HashRegEx")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "<Pending>", Scope = "member", Target = "~M:DotNetTips.Spargine.Extensions.EnumerableExtensions.RemoveDuplicates``1(System.Collections.Generic.IEnumerable{``0})~DotNetTips.Spargine.Core.SimpleResult{System.Collections.Generic.IEnumerable{``0}}")]
