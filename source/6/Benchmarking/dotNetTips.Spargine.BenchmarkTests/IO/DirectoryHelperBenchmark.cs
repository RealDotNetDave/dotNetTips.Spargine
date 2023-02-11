// ***********************************************************************
// Assembly         : DotNetTips.Spargine.BenchmarkTests
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-06-2023
// ***********************************************************************
// <copyright file="DirectoryHelperBenchmark.cs" company="DotNetTips.Spargine.BenchmarkTests">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.IO;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Loggers;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.IO;
using DotNetTips.Spargine.Tester;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.BenchmarkTests.IO;

[BenchmarkCategory(Categories.IO)]
public class DirectoryHelperBenchmark : Benchmark
{

	private const int FileCount = 100;
	private const int FileLength = 1024;

	private readonly DirectoryInfo _sourcePath = new(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), nameof(DirectoryHelperBenchmark) + RandomData.GenerateKey()));

	private readonly DirectoryInfo _tempPath = new(Path.Combine(Path.GetTempPath(), nameof(DirectoryHelperBenchmark) + RandomData.GenerateKey()));

	[Benchmark(Description = nameof(DirectoryHelper.AppDataFolder))]
	public void AppDataFolder()
	{
		var folder = DirectoryHelper.AppDataFolder();

		this.Consume(folder);
	}

	public override void Cleanup()
	{
		base.Cleanup();

		DirectoryHelper.DeleteDirectory(this._tempPath, retries: 5);
		DirectoryHelper.DeleteDirectory(this._sourcePath, retries: 5);
	}

	[Benchmark(Description = nameof(DirectoryHelper.SafeDirectorySearch))]
	public void SafeDirectorySearch01()
	{
		var folders = DirectoryHelper.SafeDirectorySearch(this._sourcePath, "*.dll", SearchOption.TopDirectoryOnly);

		this.Consume(folders);
	}

	[Benchmark(Description = nameof(DirectoryHelper.SafeFileSearch))]
	public void SafeFileSearch01()
	{
		var files = DirectoryHelper.SafeFileSearch(this._sourcePath, "*.dll", SearchOption.TopDirectoryOnly);

		base.Consume(files);
	}

	[Benchmark(Description = nameof(DirectoryHelper.SetFileAttributesToNormal))]
	public void SetFileAttributesToNormal01()
	{
		DirectoryHelper.SetFileAttributesToNormal(this._sourcePath);
	}
	public override void Setup()
	{
		base.Setup();

		if (this._tempPath.Exists is false)
		{
			this._tempPath.Create();
		}

		if (Directory.Exists(this._sourcePath.FullName) is false)
		{
			_ = Directory.CreateDirectory(this._sourcePath.FullName);
		}

		ConsoleLogger.Default.WriteLine($"Temp Path={this._tempPath}");
		ConsoleLogger.Default.WriteLine($"Source Path={this._sourcePath}");

		_ = RandomData.GenerateFiles(this._sourcePath.FullName, FileCount, FileLength);
	}
}
