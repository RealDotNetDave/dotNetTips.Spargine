// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions **
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 12-21-2020
// ***********************************************************************
// <copyright file="ThreadExtensions.cs" company="David McCarter - dotNetTips.com">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Threading;
using dotNetTips.Spargine.Core;

namespace dotNetTips.Spargine.Extensions
{
    /// <summary>
    /// Class ThreadExtensions.
    /// </summary>
    public static class ThreadExtensions
    {

        /// <summary>
        /// Tries the set priority.
        /// </summary>
        /// <param name="thread">The thread.</param>
        /// <param name="priority">The priority.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="ArgumentNullException">thread or logger</exception>
        /// <exception cref="ArgumentOutOfRangeException">priority</exception>
        [Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 0, Status = Status.Available)]
        public static bool TrySetPriority(this Thread thread, ThreadPriority priority)
        {
            if (thread == null)
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(thread));
            }

            if (Enum.IsDefined(typeof(ThreadPriority), priority) == false)
            {
                ExceptionThrower.ThrowArgumentOutOfRangeException(nameof(priority));
            }

            try
            {
                thread.Priority = priority;
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Waits for a certain amount of time. Does not use timer (no need to call Dispose).
        /// </summary>
        /// <param name="thread">The thread.</param>
        /// <param name="interval">The wait interval.</param>
        [Information(nameof(WaitUntil), UnitTestCoverage = 0, Status = Status.Available)]
        public static void WaitUntil(this Thread thread, TimeSpan interval)
        {
            WaitUntil(thread, interval);
        }

        /// <summary>
        /// Waits the until.
        /// </summary>
        /// <param name="thread">The thread.</param>
        /// <param name="interval">The wait interval.</param>
        /// <param name="waitIterations">The wait iterations.</param>
        /// <exception cref="ArgumentNullException">thread</exception>
        [Information(nameof(WaitUntil), UnitTestCoverage = 0, Status = Status.Available)]
        public static void WaitUntil(this Thread thread, TimeSpan interval, int waitIterations)
        {
            if (thread is null)
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(thread));
            }

            var stopAt = DateTime.Now.Add(interval);

            do
            {
                Thread.SpinWait(waitIterations);
            } while (thread.IsAlive && DateTime.Now < stopAt);
        }
    }
}
