// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions **
// Author           : David McCarter
// Created          : 11-25-2019
//
// Last Modified By : David McCarter
// Last Modified On : 07-25-2021
// ***********************************************************************
// <copyright file="TaskExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Threading.Tasks;
using dotNetTips.Spargine.Core;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Extension helper methods for <see cref="Task" />.
	/// </summary>
	public static class TaskExtensions
	{
		/// <summary>
		/// Fires the and forget<seealso cref="Task" />.
		/// </summary>
		/// <param name="task">The Task.</param>
		/// <example>
		/// SomeType.FireAsync("Test Message").FireAndForget();
		/// </example>
		[Information("Original code from: https://weblog.west-wind.com/posts/2021/Jul/07/Thoughts-on-AsyncAwait-Conversion-in-a-Desktop-App", "David McCarter", "7/13/2021", UnitTestCoverage = 100, Status = Status.New, Documentation = "ADD URL TO SEP ARTICLE")]
		public static void FireAndForget(this Task task)
		{
			_ = task.ContinueWith(tsk => tsk.Exception, TaskContinuationOptions.OnlyOnFaulted);
		}

		/// <summary>
		/// Fires the and forget a <seealso cref="Task" />.
		/// </summary>
		/// <param name="task">The Task.</param>
		/// <param name="ex">The Exception to throw.</param>
		/// <example>
		/// Action&lt;Exception&gt; exAction = (Exception ex) => Debug.WriteLine(ex.Message);
		/// SomeType.FireAsync("Test Message").FireAndForget(exAction);
		/// </example>
		[Information("Original code from: https://weblog.west-wind.com/posts/2021/Jul/07/Thoughts-on-AsyncAwait-Conversion-in-a-Desktop-App", "David McCarter", "7/13/2021", UnitTestCoverage = 100, Status = Status.New, Documentation = "ADD URL TO SEP ARTICLE")]
		public static void FireAndForget(this Task task, Action<Exception> ex)
		{
			_ = task.ContinueWith((tsk) => ex?.Invoke(tsk.Exception), TaskContinuationOptions.OnlyOnFaulted);
		}
	}
}
