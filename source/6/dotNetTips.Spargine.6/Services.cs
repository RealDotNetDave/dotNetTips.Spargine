// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6
// Author           : David McCarter
// Created          : 03-15-2021
//
// Last Modified By : David McCarter
// Last Modified On : 08-02-2023
// ***********************************************************************
// <copyright file="Services.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Convenient helper methods for seamless management of Windows services.
// Key features include loading a service, checking its running status,
// starting and stopping services, and more.
// </summary>
// ***********************************************************************
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Versioning;
using System.ServiceProcess;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Properties;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine;

/// <summary>
/// Helper class for Services.
/// </summary>
public static class Services
{
	/// <summary>
	/// Loads the service.
	/// </summary>
	/// <param name="serviceName">Name of the service.</param>
	/// <returns>ServiceController.</returns>
	[SupportedOSPlatform("windows")]
	[Information(nameof(LoadService), author: "David McCarter", createdOn: "1/1/2016", UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	private static ServiceController LoadService(string serviceName)
	{
		return Array.Find(ServiceController.GetServices(), p => string.Equals(p.ServiceName, serviceName, StringComparison.Ordinal));
	}

	/// <summary>
	/// Alls the services.
	/// </summary>
	/// <returns>IEnumerable&lt;System.String&gt;.</returns>
	[SupportedOSPlatform("windows")]
	[Information(nameof(AllServices), author: "David McCarter", createdOn: "1/1/2016", UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static IEnumerable<string> AllServices()
	{
		return ServiceController.GetServices().Select(p => p.ServiceName).AsEnumerable();
	}

	/// <summary>
	/// Determines whether [is application already running] [the specified process name].
	/// </summary>
	/// <param name="processName">Name of the process.</param>
	/// <returns><c>true</c> if [is application already running] [the specified process name]; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">processName - Process name is required.</exception>
	[SupportedOSPlatform("windows")]
	[Information(Status = Status.Available)]
	public static bool IsProcessRunning(string processName)
	{
		processName = processName.ArgumentNotNullOrEmpty();

		return Process.GetProcessesByName(processName).Length > 0;
	}

	/// <summary>
	/// Kills the process.
	/// </summary>
	/// <param name="processName">Name of the process.</param>
	/// <exception cref="ArgumentNullException">Process name is nothing or empty.</exception>
	[SupportedOSPlatform("windows")]
	[Information(UnitTestCoverage = 0, Status = Status.Available)]
	public static void KillProcess(string processName)
	{
		var app = Process.GetProcessesByName(processName.ArgumentNotNullOrEmpty()).FirstOrDefault();

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
	[SupportedOSPlatform("windows")]
	[Information(nameof(ServiceExists), author: "David McCarter", createdOn: "1/1/2016", UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static bool ServiceExists(string serviceName)
	{
		var service = LoadService(serviceName.ArgumentNotNullOrEmpty());

		return service is not null;
	}

	/// <summary>
	/// Services the status.
	/// </summary>
	/// <param name="serviceName">Name of the service.</param>
	/// <returns>ServiceControllerStatus.</returns>
	/// <exception cref="InvalidOperationException"></exception>
	[SupportedOSPlatform("windows")]
	[Information(nameof(ServiceStatus), author: "David McCarter", createdOn: "1/1/2016", UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static ServiceControllerStatus ServiceStatus(string serviceName)
	{
		var service = LoadService(serviceName.ArgumentNotNullOrEmpty());
		return service is not null ? service.Status : throw new InvalidOperationException(Resources.ServiceNotFound);
	}

	/// <summary>
	/// Starts the service.
	/// </summary>
	/// <param name="serviceName">Name of the service.</param>
	/// <returns>ServiceActionResult.</returns>
	[SupportedOSPlatform("windows")]
	[Information(nameof(StartService), author: "David McCarter", createdOn: "1/1/2016", UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static ServiceActionResult StartService(string serviceName)
	{
		serviceName = serviceName.ArgumentNotNullOrEmpty();

		var statusResult = ServiceActionResult.Error;

		if (ServiceExists(serviceName) is false)
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
	[SupportedOSPlatform("windows")]
	[Information(nameof(StartServices), author: "David McCarter", createdOn: "1/1/2016", UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static void StartServices([NotNull] IReadOnlyCollection<ServiceAction> requests)
	{
		requests.ToList().ForEach(request => request.ServiceActionResult = StartService(request.ServiceName));
	}

	/// <summary>
	/// Starts or stops services.
	/// </summary>
	/// <param name="requests">The requests.</param>
	[SupportedOSPlatform("windows")]
	[Information(nameof(StartStopServices), author: "David McCarter", createdOn: "1/1/2016", UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static void StartStopServices([NotNull] IReadOnlyCollection<ServiceAction> requests)
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
	[SupportedOSPlatform("windows")]
	[Information(nameof(StopService), author: "David McCarter", createdOn: "1/1/2016", UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static ServiceActionResult StopService(string serviceName)
	{
		serviceName = serviceName.ArgumentNotNullOrEmpty();

		var statusResult = ServiceActionResult.NotFound;

		if (ServiceExists(serviceName) is false)
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
	[SupportedOSPlatform("windows")]
	[Information(nameof(StopServices), author: "David McCarter", createdOn: "1/1/2016", UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static void StopServices([NotNull] IEnumerable<ServiceAction> requests)
	{
		requests.ToList().ForEach(request => request.ServiceActionResult = StopService(request.ServiceName));
	}
}
