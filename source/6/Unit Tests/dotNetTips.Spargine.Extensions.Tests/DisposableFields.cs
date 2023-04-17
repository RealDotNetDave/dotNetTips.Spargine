// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 04-16-2021
//
// Last Modified By : David McCarter
// Last Modified On : 03-29-2023
// ***********************************************************************
// <copyright file="DisposableFields.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.Tests;

/// <summary>
/// Class DisposableFields.
/// Implements the <see cref="IDisposable" />
/// </summary>
/// <seealso cref="IDisposable" />
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
	private bool _disposedValue;

	/// <summary>
	/// Disposes this instance.
	/// </summary>
	[Preserve("Part of IDisposable", "4/16/2023", "David McCarter")]
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
		if (!this._disposedValue)
		{
			if (disposing)
			{
				this._dataSet.Dispose();
			}

			this._disposedValue = true;
		}
	}
}
