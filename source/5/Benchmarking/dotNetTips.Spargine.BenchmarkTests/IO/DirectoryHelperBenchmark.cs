using System;
using System.Diagnostics;
using System.IO;
using BenchmarkDotNet.Attributes;
using dotNetTips.Spargine.Benchmarking;
using dotNetTips.Spargine.IO;
using dotNetTips.Spargine.Tester;

namespace dotNetTips.Spargine.BenchmarkTests
{
	[BenchmarkCategory("DirectoryHelper")]
	public class DirectoryHelperBenchmark : Benchmark
	{

		private const int FileCount = 50;
		private const int FileLength = 50;

		private readonly string _sourcePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), nameof(DirectoryHelperBenchmark) + RandomData.GenerateKey());

		private readonly DirectoryInfo _tempPath = new(Path.Combine(Path.GetTempPath(), nameof(DirectoryHelperBenchmark) + RandomData.GenerateKey()));

		[Benchmark(Description = nameof(DirectoryHelper.AppDataFolder))]
		public void AppDataFolder01()
		{
			var folder = DirectoryHelper.AppDataFolder();

			this.Consumer.Consume(folder);
		}

		public override void Cleanup()
		{
			DirectoryHelper.DeleteDirectory(this._tempPath.ToString(), retries: 5);
			DirectoryHelper.DeleteDirectory(this._sourcePath.ToString(), retries: 5);

			base.Cleanup();
		}

		[Benchmark(Description = "Copy & Delete Directory")]
		public void CopyDeleteDirectory01()
		{
			var destinationPath = Path.Combine(this._tempPath.FullName, nameof(this.CopyDeleteDirectory01));

			try
			{
				DirectoryHelper.CopyDirectory(this._sourcePath, destinationPath, overwrite: true);
			}
			finally
			{
				DirectoryHelper.DeleteDirectory(destinationPath, 3);
			}

		}

		[Benchmark(Description = "Copy & Move Directory")]
		public void CopyMoveDirectory01()
		{
			//Copy files to new source folder
			var source = Path.Combine(this._sourcePath, nameof(this.CopyMoveDirectory01) + RandomData.GenerateKey());

			DirectoryHelper.CopyDirectory(this._sourcePath, source, true);

			DirectoryHelper.MoveDirectory(source, Path.Combine(this._tempPath.ToString(), nameof(this.CopyMoveDirectory01) + RandomData.GenerateKey()), 5);
		}

		[Benchmark(Description = nameof(DirectoryHelper.DeleteDirectory))]
		public void DeleteDirectory01()
		{
			var destinationPath = Path.Combine(this._tempPath.FullName, nameof(this.DeleteDirectory01));

			DirectoryHelper.DeleteDirectory(destinationPath, 3);
		}

		[Benchmark(Description = nameof(DirectoryHelper.LoadOneDriveFolders))]
		public void LoadOneDriveFolders01()
		{
			var folders = DirectoryHelper.LoadOneDriveFolders();

			this.Consumer.Consume(folders);
		}

		[Benchmark(Description = nameof(DirectoryHelper.SafeDirectorySearch))]
		public void SafeDirectorySearch01()
		{
			var folders = DirectoryHelper.SafeDirectorySearch(new DirectoryInfo(this._sourcePath), "*.*", SearchOption.TopDirectoryOnly);

			this.Consumer.Consume(folders);
		}

		[Benchmark(Description = nameof(DirectoryHelper.SafeFileSearch))]
		public void SafeFileSearch01()
		{
			var files = DirectoryHelper.SafeFileSearch(new DirectoryInfo(this._sourcePath), "*.*", SearchOption.TopDirectoryOnly);

			this.Consumer.Consume(files);
		}

		[Benchmark(Description = nameof(DirectoryHelper.SetFileAttributesToNormal))]
		public void SetFileAttributesToNormal01()
		{
			DirectoryHelper.SetFileAttributesToNormal(this._sourcePath);
		}
		public override void Setup()
		{
			if (this._tempPath.Exists == false)
			{
				this._tempPath.Create();
			}

			if (Directory.Exists(this._sourcePath) == false)
			{
				Directory.CreateDirectory(this._sourcePath);
			}

			Debug.WriteLine($"Temp Path={this._tempPath}");
			Debug.WriteLine($"Source Path={this._sourcePath}");

			_ = RandomData.GenerateFiles(this._sourcePath, FileCount, FileLength);

			base.Setup();
		}
	}
}
