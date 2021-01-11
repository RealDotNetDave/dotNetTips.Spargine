// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Core
// Author           : David McCarter
// Created          : 11-11-2020
//
// Last Modified By : David McCarter
// Last Modified On : 11-04-2020
// ***********************************************************************
// <copyright file="Singleton.cs" company="dotNetTips.Spargine.5.Core">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
//![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Core
{
	/// <summary>
	/// Class Singleton.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	public abstract class Singleton<T>
		where T : Singleton<T>, new()
	{
		/// <summary>
		/// The instance
		/// </summary>
		private static T _instance = new T();

		/// <summary>
		/// Gets the instance.
		/// </summary>
		/// <value>The instance.</value>
		public static T Instance => _instance;

		/// <summary>
		/// ts this instance.
		/// </summary>
		/// <param name="data">The data.</param>
		protected static void LoadData(T data)
		{
			if (data != null)
			{
				_instance = data;
			}
		}
	}
}
