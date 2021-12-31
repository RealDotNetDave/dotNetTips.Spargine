// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5
// Author           : David McCarter
// Created          : 03-02-2021
//
// Last Modified By : David McCarter
// Last Modified On : 12-27-2021
// ***********************************************************************
// <copyright file="FileProgressEventArgs.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png; https://www.spargine.net )

namespace dotNetTips.Spargine.IO
{
	/// <summary>
	/// Class FileProgressEventArgs. This class cannot be inherited.
	/// Implements the <see cref="EventArgs" />
	/// </summary>
	/// <seealso cref="EventArgs" />
	public sealed class FileProgressEventArgs : EventArgs
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="FileProgressEventArgs" /> class.
		/// </summary>
		public FileProgressEventArgs() => this.Message = string.Empty;

		/// <summary>
		/// Gets or sets the file progress message.
		/// </summary>
		/// <value>The message.</value>
		public string Message
		{
			get; internal set;
		}

		/// <summary>
		/// Gets or sets the full path and file name.
		/// </summary>
		/// <value>The full name.</value>
		public string Name
		{
			get; internal set;
		}

		/// <summary>
		/// Gets or sets the progress state.
		/// </summary>
		/// <value>The state of the progress.</value>
		public FileProgressState ProgressState
		{
			get; internal set;
		}

		/// <summary>
		/// Gets or sets the file size.
		/// </summary>
		/// <value>The size.</value>
		public long Size
		{
			get; internal set;
		}

		/// <summary>
		/// Gets or sets the speed in milliseconds.
		/// </summary>
		/// <value>The speed in milliseconds.</value>
		public double SpeedInMilliseconds
		{
			get; internal set;
		}
	}
}
