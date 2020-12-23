
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using dotNetTips.Spargine.Core.OOP;

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
        public static int ProgressiveRetry(Action operation, byte retryCount = 3, int retryWaitMilliseconds = 100)
        {
            Encapsulation.TryValidateParam<ArgumentNullException>(operation != null);
            Encapsulation.TryValidateParam<ArgumentOutOfRangeException>(retryCount > 0);
            Encapsulation.TryValidateParam<ArgumentOutOfRangeException>(retryWaitMilliseconds > 0);

            var attempts = 0;

            do
            {
                try
                {
                    attempts++;

                    operation();

                    return attempts;
                }
                catch (Exception ex)
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
