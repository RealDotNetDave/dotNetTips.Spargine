// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions **
// Author           : David McCarter
// Created          : 11-25-2019
//
// Last Modified By : David McCarter
// Last Modified On : 01-15-2021
// ***********************************************************************
// <copyright file="TaskExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Threading.Tasks;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Extension helper methods for <see cref="Task" />.
	/// </summary>
	public static class TaskExtensions
	{
		///// <summary>
		///// Forgets the specified task.
		///// </summary>
		///// <param name="task">The task.</param>
		///// <remarks>From: https://www.meziantou.net/fire-and-forget-a-task-in-dotnet.htm </remarks>
		//public static void Forget(this Task task)
		//{
		//    // note: this code is inspired by a tweet from Ben Adams. If someone find the link to the tweet I'll be pleased to add it here.
		//    // Only care about tasks that may fault (not completed) or are faulted,
		//    // so fast-path for SuccessfullyCompleted and Canceled tasks.
		//    if (!task.IsCompleted || task.IsFaulted)
		//    {
		//        // use "_" (Discard operation) to remove the warning IDE0058: Because this call is not awaited, execution of the current method continues before the call is completed
		//        // https://docs.microsoft.com/en-us/dotnet/csharp/discards#a-standalone-discard
		//        _ = ForgetAwaited(task);
		//    }

		//    // Allocate the async/await state machine only when needed for performance reason.
		//    // More info about the state machine: https://blogs.msdn.microsoft.com/seteplia/2017/11/30/dissecting-the-async-methods-in-c/
		//    async static Task ForgetAwaited(Task task)
		//    {
		//        try
		//        {
		//            // No need to resume on the original SynchronizationContext, so use ConfigureAwait(false)
		//            await task.ConfigureAwait(false);
		//        }
		//        catch
		//        {
		//            // Nothing to do here
		//        }
		//    }
		//}
	}
}
