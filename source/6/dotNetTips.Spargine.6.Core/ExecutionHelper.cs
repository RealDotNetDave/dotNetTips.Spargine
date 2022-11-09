// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Core
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 11-09-2022
// ***********************************************************************
// <copyright file="ExecutionHelper.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Helper class for executing methods.
/// </summary>
public static class ExecutionHelper
{
	/// <summary>
	/// Progressive retry for a function call.
	/// </summary>
	/// <param name="operation">The operation to perform.</param>
	/// <param name="retryCount">The retry count (default 3).</param>
	/// <param name="retryWaitMilliseconds">The retry wait milliseconds (default 100).</param>
	/// <returns>System.Int32.</returns>
	[Information(nameof(ProgressiveRetry), UnitTestCoverage = 100, Status = Status.Available)]
	public static int ProgressiveRetry([NotNull] Action operation, byte retryCount = 3, int retryWaitMilliseconds = 100)
	{
		operation = operation.ArgumentNotNull();
		retryCount = retryCount.ArgumentInRange(lower: 1, upper: byte.MaxValue);
		retryWaitMilliseconds = retryWaitMilliseconds.ArgumentInRange(lower: 1);

		var attempts = 0;

		while (true)
		{
			try
			{
				attempts++;

				operation();

				return attempts;
			}
			catch (Exception ex) // Catching Exception since the type of Exception is unknown.
			{
				if (attempts == retryCount)
				{
					throw;
				}

				Debug.WriteLine(ex.GetAllMessages());

				Task.Delay(retryWaitMilliseconds * attempts).Wait();
			}
		}
	}
}
