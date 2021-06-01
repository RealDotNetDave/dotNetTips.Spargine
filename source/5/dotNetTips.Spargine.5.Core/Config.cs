// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Core
// Author           : David McCarter
// Created          : 02-07-2021
//
// Last Modified By : David McCarter
// Last Modified On : 04-16-2021
// ***********************************************************************
// <copyright file="Config.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.IO;
using System.Xml.Serialization;
using dotNetTips.Spargine.Core.Serialization;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Core
{
	/// <summary>
	/// Class Config.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	public class Config<T> where T : class, new()
	{
		/// <summary>
		/// The instance.
		/// </summary>
		private static T _instance = new();

		/// <summary>
		/// Prevents a default instance of the <see cref="Config{T}" /> class from being created.
		/// </summary>
		protected Config()
		{
			var localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
			var fileName = $"{App.AppInfo.Product}.config";
			var folder = Path.Combine(localAppData, App.AppInfo.Company);
			this.ConfigFileName = Path.Combine(folder, fileName);
		}

		/// <summary>
		/// Gets the name of the configuration file.
		/// </summary>
		/// <value>The name of the configuration file.</value>
		[XmlIgnore]
		public string ConfigFileName { get; private set; }

		/// <summary>
		/// Gets the instance for the object.
		/// </summary>
		/// <value>The instance.</value>
		[XmlIgnore]
		public T Instance
		{
			get { return _instance; }
		}

		/// <summary>
		/// Loads this instance.
		/// </summary>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		public virtual bool Load()
		{
			if (File.Exists(this.ConfigFileName))
			{
				_instance = XmlSerialization.DeserializeFromFile<T>(this.ConfigFileName);

				return true;
			}

			return false;
		}

		/// <summary>
		/// Saves this instance.
		/// </summary>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		public virtual bool Save()
		{
			if (File.Exists(this.ConfigFileName))
			{
				File.Delete(this.ConfigFileName);
			}

			XmlSerialization.SerializeToFile(this.Instance, this.ConfigFileName);

			return true;
		}
	}
}
