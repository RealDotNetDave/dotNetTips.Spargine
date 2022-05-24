// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions **
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 05-24-2022
// ***********************************************************************
// <copyright file="ThreadExtensions.cs" company="David McCarter - dotNetTips.com">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions
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
		[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 0, Status = Status.Available)]
		public static bool TrySetPriority([NotNull] this Thread thread, ThreadPriority priority = ThreadPriority.Normal)
		{
			thread.ArgumentNotNull().Priority = priority.ArgumentDefined();

			return true;
		}

		/// <summary>
		/// Waits for a certain amount of time. Does not use timer (no need to call Dispose).
		/// </summary>
		/// <param name="thread">The thread.</param>
		/// <param name="interval">The wait interval.</param>
		[Information(nameof(WaitUntil), UnitTestCoverage = 0, Status = Status.Available)]
		public static void WaitUntil([NotNull] this Thread thread, in TimeSpan interval)
		{
			WaitUntil(thread.ArgumentNotNull(), interval);
		}

		/// <summary>
		/// Waits the until.
		/// </summary>
		/// <param name="thread">The thread.</param>
		/// <param name="interval">The wait interval.</param>
		/// <param name="waitIterations">The wait iterations.</param>
		/// <exception cref="ArgumentNullException">thread</exception>
		[Information(nameof(WaitUntil), UnitTestCoverage = 0, Status = Status.Available)]
		public static void WaitUntil([NotNull] this Thread thread, in TimeSpan interval, int waitIterations)
		{
			thread = thread.ArgumentNotNull();
			waitIterations = waitIterations.ArgumentInRange(paramName: nameof(waitIterations), lower: 0);

			var stopAt = DateTime.Now.Add(interval);

			do
			{
				Thread.SpinWait(waitIterations);
			} while (thread.IsAlive && DateTime.Now < stopAt);
		}
	}
}
