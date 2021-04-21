// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 04-16-2021
//
// Last Modified By : David McCarter
// Last Modified On : 04-18-2021
// ***********************************************************************
// <copyright file="DisposableFields.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Extensions.Tests
{
	/// <summary>
	/// Class DisposableFields.
	/// Implements the <see cref="System.IDisposable" />
	/// </summary>
	/// <seealso cref="System.IDisposable" />
	[ExcludeFromCodeCoverage]
	public class DisposableFields : IDisposable
	{
		/// <summary>
		/// The data set
		/// </summary>
		private readonly DataSet _dataSet = new("TEST");
		/// <summary>
		/// The disposed value
		/// </summary>
		private bool disposedValue;

		/// <summary>
		/// Disposes this instance.
		/// </summary>
		public void Dispose()
		{
			// Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
			this.Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}

		/// <summary>
		/// Disposes the specified disposing.
		/// </summary>
		/// <param name="disposing">The disposing.</param>
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposedValue)
			{
				if (disposing)
				{
					this._dataSet.Dispose();
				}

				this.disposedValue = true;
			}
		}
	}
}
