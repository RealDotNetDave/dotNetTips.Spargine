// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Core
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 08-18-2021
// ***********************************************************************
// <copyright file="ExecutionHelper.cs" company="dotNetTips.Spargine.5.Core">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Core
{
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
		[Information(nameof(ProgressiveRetry), UnitTestCoverage = 0, Status = Status.Available)]
		public static int ProgressiveRetry([NotNull] Action operation, byte retryCount = 3, int retryWaitMilliseconds = 100)
		{
			Validate.TryValidateParam(retryCount, minimumValue: 1, maximumValue: byte.MaxValue, paramName: nameof(retryCount));
			Validate.TryValidateParam(retryWaitMilliseconds, minimumValue: 1, paramName: nameof(retryWaitMilliseconds));

			var attempts = 0;

			do
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
			} while (true);
		}
	}
}
