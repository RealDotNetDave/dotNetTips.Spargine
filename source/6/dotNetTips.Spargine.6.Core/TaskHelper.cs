// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Core
// Author           : David McCarter
// Created          : 07-25-2021
//
// Last Modified By : David McCarter
// Last Modified On : 04-14-2022
// ***********************************************************************
// <copyright file="TaskHelper.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core
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
		/// TaskHelper.RunSync(() =&gt; SomeType.FireAsync("Test Message"));
		/// </example>
		[Information("Original code from: https://weblog.west-wind.com/posts/2021/Jul/07/Thoughts-on-AsyncAwait-Conversion-in-a-Desktop-App", "David McCarter", "7/13/2021", UnitTestCoverage = 100, Status = Status.Available, Documentation = "ADD URL TO SEP ARTICLE")]
		public static void RunSync([NotNull] Func<Task> task)
		{
			_taskFactory.StartNew(task.ArgumentNotNull()).Unwrap().GetAwaiter().GetResult();
		}

		/// <summary>
		/// Executes an async Task&lt;T&gt; method which has a T return type synchronously.
		/// </summary>
		/// <typeparam name="TResult">Return Type</typeparam>
		/// <param name="task">Task&lt;T&gt; method to execute</param>
		/// <returns>TResult.</returns>
		/// <example>
		/// TaskHelper.RunSync(() =&gt; SomeType.FireWithReturnAsync("Test Message"));
		/// </example>
		[Information("Original code from: https://weblog.west-wind.com/posts/2021/Jul/07/Thoughts-on-AsyncAwait-Conversion-in-a-Desktop-App", "David McCarter", "7/13/2021", UnitTestCoverage = 100, Status = Status.Available, Documentation = "ADD URL TO SEP ARTICLE")]
		public static TResult RunSync<TResult>([NotNull] this Func<Task<TResult>> task)
		{
			task = task.ArgumentNotNull();

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
		/// TaskHelper.RunSync(() =&gt; SomeType.FireWithReturnAsync("Test Message", cancellationToken: cancelToken);
		/// </example>
		[Information("Original code from: https://weblog.west-wind.com/posts/2021/Jul/07/Thoughts-on-AsyncAwait-Conversion-in-a-Desktop-App", "David McCarter", "7/13/2021", UnitTestCoverage = 100, Status = Status.Available, Documentation = "ADD URL TO SEP ARTICLE")]
		public static TResult RunSync<TResult>([NotNull] Func<Task<TResult>> func, CancellationToken cancellationToken, TaskCreationOptions taskCreation = TaskCreationOptions.None, TaskContinuationOptions taskContinuation = TaskContinuationOptions.None, TaskScheduler taskScheduler = null)
		{
			func = func.ArgumentNotNull();

			if (taskScheduler is null)
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
		/// TaskHelper.RunSync(() =&gt; SomeType.FireAsync("Test Message"), cancellationToken: cancelToken);
		/// </example>
		[Information("Original code from: https://weblog.west-wind.com/posts/2021/Jul/07/Thoughts-on-AsyncAwait-Conversion-in-a-Desktop-App", "David McCarter", "7/13/2021", UnitTestCoverage = 100, Status = Status.Available, Documentation = "ADD URL TO SEP ARTICLE")]
		public static void RunSync([NotNull] this Func<Task> task, CancellationToken cancellationToken, TaskCreationOptions taskCreation = TaskCreationOptions.None, TaskContinuationOptions taskContinuation = TaskContinuationOptions.None, TaskScheduler taskScheduler = null)
		{
			task = task.ArgumentNotNull();

			if (taskScheduler is null)
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
