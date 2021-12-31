// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 12-27-2021
// ***********************************************************************
// <copyright file="ExceptionExtensions.cs" company="David McCarter - dotNetTips.com">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Security;
using dotNetTips.Spargine.Core;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png; https://www.spargine.net )
namespace dotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Class ExceptionExtension.
	/// </summary>
	public static class ExceptionExtensions
	{
		/// <summary>
		/// Hierarchy.
		/// </summary>
		/// <typeparam name="TSource">The type of the t source.</typeparam>
		/// <param name="source">The source.</param>
		/// <param name="nextItem">The next item.</param>
		/// <returns>IEnumerable&lt;TSource&gt;.</returns>
		[Information(nameof(FromHierarchy), UnitTestCoverage = 100, Status = Status.Available)]
		public static IEnumerable<TSource> FromHierarchy<TSource>([NotNull] this TSource source, [NotNull] Func<TSource, TSource> nextItem) where TSource : Exception
		{
			return FromHierarchy(source, nextItem, s => s is not null);
		}

		/// <summary>
		/// Hierarchy.
		/// </summary>
		/// <typeparam name="TSource">The type of the t source.</typeparam>
		/// <param name="source">The source.</param>
		/// <param name="nextItem">The next item.</param>
		/// <param name="canContinue">The can continue.</param>
		/// <returns>IEnumerable&lt;TSource&gt;.</returns>
		[Information(nameof(FromHierarchy), UnitTestCoverage = 99, Status = Status.Available)]
		public static IEnumerable<TSource> FromHierarchy<TSource>(this TSource source, [NotNull] Func<TSource, TSource> nextItem, [NotNull] Func<TSource, bool> canContinue)
			where TSource : Exception
		{
			if (Validate.TryValidateNull(source))
			{
				yield return null;
			}

			for (var current = source; canContinue(current); current = nextItem(current))
			{
				yield return current;
			}
		}

		/// <summary>
		/// Gets all Exception messages.
		/// </summary>
		/// <param name="exception">The exception.</param>
		/// <param name="separator">The separator.</param>
		/// <returns>System.String.</returns>
		[Information(nameof(GetAllMessages), UnitTestCoverage = 100, Status = Status.Available)]
		public static string GetAllMessages([NotNull] this Exception exception, char separator = ControlChars.Comma)
		{
			var messages = exception.FromHierarchy(ex => ex.InnerException).Select(ex => ex.Message);

			return string.Join(separator, messages);
		}

		/// <summary>
		/// Gets all messages with stack trace.
		/// </summary>
		/// <param name="exception">The exception.</param>
		/// <returns>System.String.</returns>
		[Information(nameof(GetAllMessagesWithStackTrace), author: "David McCarter", createdOn: "10/12/2020", modifiedOn: "10/12/2020", UnitTestCoverage = 100, Status = Status.Available)]
		public static IList<(string message, string StackTrace)> GetAllMessagesWithStackTrace([NotNull] this Exception exception)
		{
			var messages = exception.FromHierarchy(ex => ex.InnerException)
				.Select(ex => new
				{
					ex.Message,
					StackTrace = ex.StackTrace.IsNotEmpty() ? ex.StackTrace : "NONE"
				})
				.AsEnumerable()
				.Select(c => (c.Message, c.StackTrace))
				.ToList();

			return messages;
		}


		/// <summary>
		/// Determines whether the specified ex is critical.
		/// </summary>
		/// <param name="ex">The ex.</param>
		/// <returns><c>true</c> if the specified ex is critical; otherwise, <c>false</c>.</returns>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, Status = Status.Available)]
		public static bool IsCritical([NotNull] this Exception ex)
		{
			return ex is NullReferenceException or
				StackOverflowException or
				OutOfMemoryException or
				ThreadAbortException or
				IndexOutOfRangeException or
				AccessViolationException;
		}

		/// <summary>
		/// Determines whether the specified ex is fatal.
		/// </summary>
		/// <param name="ex">The ex.</param>
		/// <returns><c>true</c> if the specified ex is fatal; otherwise, <c>false</c>.</returns>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, Status = Status.Available)]
		public static bool IsFatal([NotNull] this Exception ex)
		{
			return ex is OutOfMemoryException;
		}

		/// <summary>
		/// Determines whether [is security or critical] [the specified ex].
		/// </summary>
		/// <param name="ex">The ex.</param>
		/// <returns><c>true</c> if [is security or critical] [the specified ex]; otherwise, <c>false</c>.</returns>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, Status = Status.Available)]
		public static bool IsSecurityOrCritical([NotNull] this Exception ex)
		{
			return ( ex is SecurityException ) || ex.IsCritical();
		}

		/// <summary>
		/// Traverses Exception.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="ex">The ex.</param>
		/// <returns>T.</returns>
		[Information(nameof(TraverseFor), UnitTestCoverage = 0, Status = Status.Available)]
		public static T TraverseFor<T>([NotNull] this Exception ex)
			where T : class
		{
			return ReferenceEquals(ex.GetType(), typeof(T)) ? ex as T : ex.InnerException.TraverseFor<T>();
		}
	}
}
