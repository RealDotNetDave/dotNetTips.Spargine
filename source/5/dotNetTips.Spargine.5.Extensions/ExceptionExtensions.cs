// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions **
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 11-11-2020
// ***********************************************************************
// <copyright file="ExceptionExtensions.cs" company="David McCarter - dotNetTips.com">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Threading;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Core.OOP;
using dotNetTips.Spargine.Extensions.Properties;

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
        public static IEnumerable<TSource> FromHierarchy<TSource>(this TSource source, Func<TSource, TSource> nextItem) where TSource : Exception
        {
            Encapsulation.TryValidateParam<ArgumentNullException>(source != null, nameof(source));
            Encapsulation.TryValidateParam<ArgumentNullException>(nextItem != null, nameof(nextItem));

            return FromHierarchy(source, nextItem, s => s != null);
        }

        /// <summary>
        /// Hierarchy.
        /// </summary>
        /// <typeparam name="TSource">The type of the t source.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="nextItem">The next item.</param>
        /// <param name="canContinue">The can continue.</param>
        /// <returns>IEnumerable&lt;TSource&gt;.</returns>
        /// <exception cref="ArgumentNullException">nameof(canContinue), $"{nameof(canContinue)} is null.</exception>
        /// <exception cref="ArgumentNullException">nameof(canContinue), $"{nameof(canContinue)} is null.</exception>
        /// <exception cref="System.ArgumentNullException">canContinue or nextItem</exception>
        [Information(nameof(FromHierarchy), UnitTestCoverage = 99, Status = Status.Available)]
        public static IEnumerable<TSource> FromHierarchy<TSource>(this TSource source, Func<TSource, TSource> nextItem, Func<TSource, bool> canContinue)
            where TSource : Exception
        {
            if (source is null)
            {
                yield return null;
            }

            Encapsulation.TryValidateParam<ArgumentNullException>(canContinue != null, nameof(canContinue));
            Encapsulation.TryValidateParam<ArgumentNullException>(nextItem != null, nameof(nextItem));

            for (var current = source; canContinue(current); current = nextItem(current))
            {
                yield return current;
            }
        }

        /// <summary>
        /// Gets all messages.
        /// </summary>
        /// <param name="exception">The exception.</param>
        /// <returns>System.String.</returns>
        [Information(nameof(GetAllMessages), UnitTestCoverage = 100, Status = Status.Available)]
        public static string GetAllMessages(this Exception exception) => GetAllMessages(exception, ControlChars.Comma);

        /// <summary>
        /// Gets all Exception messages.
        /// </summary>
        /// <param name="exception">The exception.</param>
        /// <param name="separator">The separator.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="ArgumentNullException">nameof(exception)</exception>
        [Information(nameof(GetAllMessages), UnitTestCoverage = 100, Status = Status.Available)]
        public static string GetAllMessages(this Exception exception, char separator = ControlChars.Comma)
        {
            Encapsulation.TryValidateParam<ArgumentNullException>(exception != null, nameof(exception));

            var messages = exception.FromHierarchy(ex => ex.InnerException).Select(ex => ex.Message);

            return string.Join(separator, messages);
        }

        /// <summary>
        /// Gets all messages with stack trace.
        /// </summary>
        /// <param name="exception">The exception.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="ArgumentNullException">nameof(exception)</exception>
        /// <exception cref="ArgumentException">exception</exception>
        [Information(nameof(GetAllMessagesWithStackTrace), author: "David McCarter", createdOn: "10/12/2020", modifiedOn: "10/12/2020", UnitTestCoverage = 0, Status = Status.Available)]
        public static List<(string message, string StackTrace)> GetAllMessagesWithStackTrace(this Exception exception)
        {
            Encapsulation.TryValidateParam<ArgumentNullException>(exception != null, nameof(exception));

            var messages = exception.FromHierarchy(ex => ex.InnerException)
                .Select(ex => new
                {
                    Message = ex.Message,
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
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 0, Status = Status.Available)]
        public static bool IsCritical(this Exception ex)
        {
            return ex is NullReferenceException ||
                ex is StackOverflowException ||
                ex is OutOfMemoryException ||
                ex is ThreadAbortException ||
                ex is IndexOutOfRangeException ||
                ex is AccessViolationException;
        }

        /// <summary>
        /// Determines whether the specified ex is fatal.
        /// </summary>
        /// <param name="ex">The ex.</param>
        /// <returns><c>true</c> if the specified ex is fatal; otherwise, <c>false</c>.</returns>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 0, Status = Status.Available)]
        public static bool IsFatal(this Exception ex)
        {
            return ex is OutOfMemoryException;
        }

        /// <summary>
        /// Determines whether [is security or critical] [the specified ex].
        /// </summary>
        /// <param name="ex">The ex.</param>
        /// <returns><c>true</c> if [is security or critical] [the specified ex]; otherwise, <c>false</c>.</returns>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 0, Status = Status.Available)]
        public static bool IsSecurityOrCritical(this Exception ex)
        {
            return ( ex is SecurityException ) || ex.IsCritical();
        }

        /// <summary>
        /// Traverses Exception.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="ex">The ex.</param>
        /// <returns>T.</returns>
        /// <exception cref="ArgumentNullException">nameof(ex), Resources.ExceptionCannotBeNull</exception>
        [Information(nameof(TraverseFor), UnitTestCoverage = 0, Status = Status.Available)]
        public static T TraverseFor<T>(this Exception ex)
            where T : class
        {
            if (ex is null)
            {
                ExceptionThrower.ThrowArgumentNullException(Resources.ExceptionCannotBeNull, nameof(ex));
            }

            if (ReferenceEquals(ex.GetType(), typeof(T)))
            {
                return ex as T;
            }

            return ex.InnerException.TraverseFor<T>();
        }
    }
}
