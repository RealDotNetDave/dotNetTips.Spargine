﻿// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5
// Author           : David McCarter
// Created          : 03-15-2021
//
// Last Modified By : David McCarter
// Last Modified On : 09-17-2021
// ***********************************************************************
// <copyright file="Services.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.ServiceProcess;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Properties;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine
{
	/// <summary>
	/// Helper class for Services.
	/// </summary>
	public static class Services
	{
		/// <summary>
		/// Alls the services.
		/// </summary>
		/// <returns>IEnumerable&lt;System.String&gt;.</returns>
		[Information(nameof(AllServices), author: "David McCarter", createdOn: "1/1/2016", UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static IEnumerable<string> AllServices() => ServiceController.GetServices().Select(p => p.ServiceName).AsEnumerable();

		/// <summary>
		/// Determines whether [is application already running] [the specified process name].
		/// </summary>
		/// <param name="processName">Name of the process.</param>
		/// <returns><c>true</c> if [is application already running] [the specified process name]; otherwise, <c>false</c>.</returns>
		/// <exception cref="ArgumentNullException">processName - Process name is required.</exception>
		[Information(Status = Status.Available)]
		public static bool IsProcessRunning([NotNull] string processName)
		{
			return Process.GetProcessesByName(processName).Length > 0;
		}

		/// <summary>
		/// Kills the process.
		/// </summary>
		/// <param name="processName">Name of the process.</param>
		/// <exception cref="ArgumentNullException">Process name is nothing or empty.</exception>
		[Information(UnitTestCoverage = 0, Status = Status.Available)]
		public static void KillProcess([NotNull] string processName)
		{
			var app = Process.GetProcessesByName(processName).FirstOrDefault();

			if (app is not null)
			{
				app.Kill();
				_ = app.WaitForExit(milliseconds: 6000);
			}
		}

		/// <summary>
		/// Services the exists.
		/// </summary>
		/// <param name="serviceName">Name of the service.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		[Information(nameof(ServiceExists), author: "David McCarter", createdOn: "1/1/2016", UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static bool ServiceExists([NotNull] string serviceName)
		{
			var service = LoadService(serviceName);

			return service is not null;
		}

		/// <summary>
		/// Services the status.
		/// </summary>
		/// <param name="serviceName">Name of the service.</param>
		/// <returns>ServiceControllerStatus.</returns>
		/// <exception cref="InvalidOperationException"></exception>
		[Information(nameof(ServiceStatus), author: "David McCarter", createdOn: "1/1/2016", UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static ServiceControllerStatus ServiceStatus([NotNull] string serviceName)
		{
			var service = LoadService(serviceName);

			return service is not null ? service.Status : throw new InvalidOperationException(Resources.ServiceNotFound);
		}

		/// <summary>
		/// Starts the service.
		/// </summary>
		/// <param name="serviceName">Name of the service.</param>
		/// <returns>ServiceActionResult.</returns>
		[Information(nameof(StartService), author: "David McCarter", createdOn: "1/1/2016", UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static ServiceActionResult StartService([NotNull] string serviceName)
		{
			var statusResult = ServiceActionResult.Error;

			if (ServiceExists(serviceName) == false)
			{
				return ServiceActionResult.NotFound;
			}

			var service = LoadService(serviceName);

			if (service is not null && service.Status == ServiceControllerStatus.Stopped)
			{
				service.Start();
				statusResult = ServiceActionResult.Running;
			}

			return statusResult;
		}

		/// <summary>
		/// Starts the services.
		/// </summary>
		/// <param name="requests">The requests.</param>
		/// <returns>IEnumerable&lt;System.String&gt;.</returns>
		[Information(nameof(StartServices), author: "David McCarter", createdOn: "1/1/2016", UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static void StartServices([NotNull] IEnumerable<ServiceAction> requests)
		{
			requests.ToList().ForEach(request =>
			{
				request.ServiceActionResult = StartService(request.ServiceName);
			});
		}

		/// <summary>
		/// Starts or stops services.
		/// </summary>
		/// <param name="requests">The requests.</param>
		[Information(nameof(StartStopServices), author: "David McCarter", createdOn: "1/1/2016", UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static void StartStopServices([NotNull] IEnumerable<ServiceAction> requests)
		{
			requests.ToList().ForEach(request =>
			{
				if (request.ServiceActionRequest == ServiceActionRequest.Start)
				{
					request.ServiceActionResult = StartService(request.ServiceName);
				}
				else if (request.ServiceActionRequest == ServiceActionRequest.Stop)
				{
					request.ServiceActionResult = StopService(request.ServiceName);
				}
			});
		}

		/// <summary>
		/// Stops the service.
		/// </summary>
		/// <param name="serviceName">Name of the service.</param>
		/// <returns>ServiceActionResult.</returns>
		[Information(nameof(StopService), author: "David McCarter", createdOn: "1/1/2016", UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static ServiceActionResult StopService([NotNull] string serviceName)
		{
			var statusResult = ServiceActionResult.NotFound;

			if (ServiceExists(serviceName) == false)
			{
				return statusResult;
			}

			var service = LoadService(serviceName);

			if (service is not null && service.Status == ServiceControllerStatus.Running)
			{
				service.Stop();
				statusResult = ServiceActionResult.Stopped;
			}

			return statusResult;
		}

		/// <summary>
		/// Stops the services.
		/// </summary>
		/// <param name="requests">The requests.</param>
		[Information(nameof(StopServices), author: "David McCarter", createdOn: "1/1/2016", UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static void StopServices([NotNull] IEnumerable<ServiceAction> requests)
		{
			requests.ToList().ForEach(request =>
					{
						request.ServiceActionResult = StopService(request.ServiceName);
					});
		}

		/// <summary>
		/// Loads the service.
		/// </summary>
		/// <param name="serviceName">Name of the service.</param>
		/// <returns>ServiceController.</returns>
		[Information(nameof(LoadService), author: "David McCarter", createdOn: "1/1/2016", UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		private static ServiceController LoadService([NotNull] string serviceName) => ServiceController.GetServices().FirstOrDefault(p => string.Equals(p.ServiceName, serviceName, StringComparison.Ordinal));
	}
}
