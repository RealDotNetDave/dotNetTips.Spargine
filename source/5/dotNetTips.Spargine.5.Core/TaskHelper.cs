// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Core
// Author           : David McCarter
// Created          : 07-25-2021
//
// Last Modified By : David McCarter
// Last Modified On : 07-25-2021
// ***********************************************************************
// <copyright file="TaskHelper.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Threading;
using System.Threading.Tasks;

namespace dotNetTips.Spargine.Core
{
	/// <summary>
	/// Class TaskHelper.
	/// </summary>
	public static class TaskHelper
	{
		/// <summary>
		/// The task factory
		/// </summary>
		private static readonly TaskFactory _taskFactory = new(CancellationToken.None, TaskCreationOptions.None, TaskContinuationOptions.None, TaskScheduler.Default);

		/// <summary>
		/// Fires the and forget<seealso cref="Task" />.
		/// </summary>
		/// <param name="task">The Task.</param>
		/// <example>
		/// TaskHelper.RunSync(() => SomeType.FireAsync("Test Message"));
		/// </example>
		[Information("Original code from: https://weblog.west-wind.com/posts/2021/Jul/07/Thoughts-on-AsyncAwait-Conversion-in-a-Desktop-App", "David McCarter", "7/13/2021", UnitTestCoverage = 100, Status = Status.New, Documentation = "ADD URL TO SEP ARTICLE")]
		public static void RunSync(Func<Task> task)
		{
			_taskFactory.StartNew(task).Unwrap().GetAwaiter().GetResult();
		}

		/// <summary>
		/// Executes an async Task&lt;T&gt; method which has a T return type synchronously.
		/// </summary>
		/// <typeparam name="TResult">Return Type</typeparam>
		/// <param name="task">Task&lt;T&gt; method to execute</param>
		/// <returns>TResult.</returns>
		/// <example>
		/// TaskHelper.RunSync(() => SomeType.FireWithReturnAsync("Test Message"));
		/// </example>
		[Information("Original code from: https://weblog.west-wind.com/posts/2021/Jul/07/Thoughts-on-AsyncAwait-Conversion-in-a-Desktop-App", "David McCarter", "7/13/2021", UnitTestCoverage = 100, Status = Status.New, Documentation = "ADD URL TO SEP ARTICLE")]
		public static TResult RunSync<TResult>(this Func<Task<TResult>> task)
		{
			return _taskFactory
				.StartNew(task)
				.Unwrap()
				.GetAwaiter()
				.GetResult();
		}

		/// <summary>
		/// Executes an async Task&lt;T&gt; method which has a T return type synchronously.
		/// </summary>
		/// <typeparam name="TResult">Return Type</typeparam>
		/// <param name="func">Task&lt;T&gt; method to execute</param>
		/// <param name="cancellationToken">The cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <param name="taskCreation">The task creation.</param>
		/// <param name="taskContinuation">The task continuation.</param>
		/// <param name="taskScheduler">The task scheduler.</param>
		/// <returns>TResult.</returns>
		/// <example>
		/// var cancelToken = new CancellationTokenSource().Token;
		/// TaskHelper.RunSync(() => SomeType.FireWithReturnAsync("Test Message", cancellationToken: cancelToken);
		/// </example>
		[Information("Original code from: https://weblog.west-wind.com/posts/2021/Jul/07/Thoughts-on-AsyncAwait-Conversion-in-a-Desktop-App", "David McCarter", "7/13/2021", UnitTestCoverage = 100, Status = Status.New, Documentation = "ADD URL TO SEP ARTICLE")]
		public static TResult RunSync<TResult>(Func<Task<TResult>> func, CancellationToken cancellationToken, TaskCreationOptions taskCreation = TaskCreationOptions.None, TaskContinuationOptions taskContinuation = TaskContinuationOptions.None, TaskScheduler taskScheduler = null)
		{
			if (taskScheduler == null)
			{
				taskScheduler = TaskScheduler.Default;
			}

			return new TaskFactory(cancellationToken, taskCreation, taskContinuation, taskScheduler)
				.StartNew(func, cancellationToken)
				.Unwrap()
				.GetAwaiter()
				.GetResult();
		}

		/// <summary>
		/// Fires the and forget<seealso cref="Task" />.
		/// </summary>
		/// <param name="task">The Task.</param>
		/// <param name="cancellationToken">The cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <param name="taskCreation">The task creation.</param>
		/// <param name="taskContinuation">The task continuation.</param>
		/// <param name="taskScheduler">The task scheduler.</param>
		/// <example>
		/// var cancelToken = new CancellationTokenSource().Token;
		/// TaskHelper.RunSync(() => SomeType.FireAsync("Test Message"), cancellationToken: cancelToken);
		/// </example>
		[Information("Original code from: https://weblog.west-wind.com/posts/2021/Jul/07/Thoughts-on-AsyncAwait-Conversion-in-a-Desktop-App", "David McCarter", "7/13/2021", UnitTestCoverage = 100, Status = Status.New, Documentation = "ADD URL TO SEP ARTICLE")]
		public static void RunSync(this Func<Task> task, CancellationToken cancellationToken, TaskCreationOptions taskCreation = TaskCreationOptions.None, TaskContinuationOptions taskContinuation = TaskContinuationOptions.None, TaskScheduler taskScheduler = null)
		{
			if (taskScheduler == null)
			{
				taskScheduler = TaskScheduler.Default;
			}

			new TaskFactory(cancellationToken, taskCreation, taskContinuation, taskScheduler)
				.StartNew(task)
				.Unwrap()
				.GetAwaiter()
				.GetResult();
		}
	}
}
