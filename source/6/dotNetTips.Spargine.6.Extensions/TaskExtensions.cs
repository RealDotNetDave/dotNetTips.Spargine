// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions **
// Author           : David McCarter
// Created          : 11-25-2019
//
// Last Modified By : David McCarter
// Last Modified On : 07-17-2022
// ***********************************************************************
// <copyright file="TaskExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Extension helper methods for <see cref="Task" />.
	/// </summary>
	public static class TaskExtensions
	{
		/// <summary>
		/// Fires the and forget<seealso cref="Task" />.
		/// Validates that <paramref name="task" /> is not null.
		/// </summary>
		/// <param name="task">The Task.</param>
		/// <example>
		/// SomeType.FireAsync("Test Message").FireAndForget();
		/// </example>
		[Information("Original code from: https://weblog.west-wind.com/posts/2021/Jul/07/Thoughts-on-AsyncAwait-Conversion-in-a-Desktop-App", "David McCarter", "7/13/2021", UnitTestCoverage = 100, Status = Status.Available, Documentation = "ADD URL TO SEP ARTICLE")]
		public static void FireAndForget([NotNull] this Task task)
		{
			_ = task.ArgumentNotNull().ContinueWith(tsk => tsk.Exception, TaskContinuationOptions.OnlyOnFaulted);
		}

		/// <summary>
		/// Fires the and forget a <seealso cref="Task" />.
		/// Validates that <paramref name="task" /> is not null.
		/// </summary>
		/// <param name="task">The Task.</param>
		/// <param name="action">The Exception to throw.</param>
		/// <example>
		/// Action&lt;Exception&gt; exAction = (Exception ex) =&gt; Debug.WriteLine(ex.Message);
		/// SomeType.FireAsync("Test Message").FireAndForget(exAction);
		/// </example>
		[Information("Original code from: https://weblog.west-wind.com/posts/2021/Jul/07/Thoughts-on-AsyncAwait-Conversion-in-a-Desktop-App", "David McCarter", "7/13/2021", UnitTestCoverage = 100, Status = Status.Available, Documentation = "ADD URL TO SEP ARTICLE")]
		public static void FireAndForget([NotNull] this Task task, Action<Exception> action)
		{
			_ = task.ArgumentNotNull().ContinueWith((tsk) => action?.Invoke(tsk.Exception), TaskContinuationOptions.OnlyOnFaulted);
		}
	}
}
