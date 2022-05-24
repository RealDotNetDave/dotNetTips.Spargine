// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 04-28-2022
// ***********************************************************************
// <copyright file="ExceptionExtensions.cs" company="David McCarter - dotNetTips.com">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Security;
using DotNetTips.Spargine.Core;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Class ExceptionExtension.
	/// </summary>
	public static class ExceptionExtensions
	{
		/// <summary>
		/// Returns the hierarchy from the source.
		/// </summary>
		/// <typeparam name="TSource">The type of the t source.</typeparam>
		/// <param name="source">The source.</param>
		/// <param name="nextItem">The next item.</param>
		/// <returns>IEnumerable&lt;TSource&gt;.</returns>
		[Information(nameof(FromHierarchy), UnitTestCoverage = 100, Status = Status.Available)]
		public static IEnumerable<TSource> FromHierarchy<TSource>([NotNull] this TSource source, [NotNull] Func<TSource, TSource> nextItem) where TSource : Exception
		{
			source = source.ArgumentNotNull();
			nextItem = nextItem.ArgumentNotNull();

			return FromHierarchy(source, nextItem, s => s is not null);
		}

		/// <summary>
		/// Returns the hierarchy from the source.
		/// </summary>
		/// <typeparam name="TSource">The type of the t source.</typeparam>
		/// <param name="source">The source.</param>
		/// <param name="nextItem">The next item.</param>
		/// <param name="canContinue">The can continue.</param>
		/// <returns>IEnumerable&lt;TSource&gt;.</returns>
		[Information(nameof(FromHierarchy), UnitTestCoverage = 99, Status = Status.Available)]
		public static IEnumerable<TSource> FromHierarchy<TSource>([NotNull] this TSource source, [NotNull] Func<TSource, TSource> nextItem, [NotNull] Func<TSource, bool> canContinue)
			where TSource : Exception
		{
			source = source.ArgumentNotNull();
			nextItem = nextItem.ArgumentNotNull();
			canContinue = canContinue.ArgumentNotNull();

			for (var current = source; canContinue(current); current = nextItem(current))
			{
				yield return current;
			}
		}

		/// <summary>
		/// Gets all messages from an <see cref="Exception" />.
		/// </summary>
		/// <param name="exception">The exception.</param>
		/// <param name="separator">The separator.</param>
		/// <returns>System.String.</returns>
		[Information(nameof(GetAllMessages), UnitTestCoverage = 100, Status = Status.Available)]
		public static string GetAllMessages([NotNull] this Exception exception, char separator = ControlChars.Comma)
		{
			exception = exception.ArgumentNotNull();

			var messages = exception.FromHierarchy(ex => ex.InnerException).Select(ex => ex.Message);

			return string.Join(separator, messages);
		}

		/// <summary>
		/// Gets all messages from a <see cref="Exception" /> including the stack trace.
		/// </summary>
		/// <param name="exception">The exception.</param>
		/// <returns>System.String.</returns>
		[Information(nameof(GetAllMessagesWithStackTrace), author: "David McCarter", createdOn: "10/12/2020", UnitTestCoverage = 100, Status = Status.Available)]
		public static IList<(string message, string StackTrace)> GetAllMessagesWithStackTrace([NotNull] this Exception exception)
		{
			exception = exception.ArgumentNotNull();

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
		/// Determines whether the specified <see cref="Exception" /> is critical is a
		/// <see cref="NullReferenceException" />, <see cref="StackOverflowException" />,
		/// <see cref="OutOfMemoryException" />, <see cref="ThreadAbortException" />,
		/// <see cref="IndexOutOfRangeException" /> or <see cref="AccessViolationException" />.
		/// </summary>
		/// <param name="exception">The ex.</param>
		/// <returns><c>true</c> if the specified ex is critical; otherwise, <c>false</c>.</returns>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, Status = Status.Available)]
		public static bool IsCritical([NotNull] this Exception exception)
		{
			exception = exception.ArgumentNotNull();

			return exception is NullReferenceException or
			StackOverflowException or
			OutOfMemoryException or
							ThreadAbortException or
							IndexOutOfRangeException or
							AccessViolationException;
		}

		/// <summary>
		/// Determines whether the specified  <see cref="Exception" /> is fatal (<see cref="OutOfMemoryException" />).
		/// </summary>
		/// <param name="exception">The ex.</param>
		/// <returns><c>true</c> if the specified ex is fatal; otherwise, <c>false</c>.</returns>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, Status = Status.Available)]
		public static bool IsFatal([NotNull] this Exception exception)
		{
			exception = exception.ArgumentNotNull();

			return exception is OutOfMemoryException;
		}

		/// <summary>
		/// Determines whether the <see cref="Exception" /> is <see cref="SecurityException" /> or is critical].
		/// </summary>
		/// <param name="exception">The ex.</param>
		/// <returns><c>true</c> if [is security or critical] [the specified ex]; otherwise, <c>false</c>.</returns>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, Status = Status.Available)]
		public static bool IsSecurityOrCritical([NotNull] this Exception exception)
		{
			exception = exception.ArgumentNotNull();

			return ( exception is SecurityException ) || exception.IsCritical();
		}

		/// <summary>
		/// Traverses the <see cref="Exception" />.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="exception">The ex.</param>
		/// <returns>T.</returns>
		[Information(nameof(TraverseFor), UnitTestCoverage = 0, Status = Status.Available)]
		public static T TraverseFor<T>([NotNull] this Exception exception)
			where T : class
		{
			exception = exception.ArgumentNotNull();

			return ReferenceEquals(exception.GetType(), typeof(T)) ? exception as T : exception.InnerException.TraverseFor<T>();
		}
	}
}
