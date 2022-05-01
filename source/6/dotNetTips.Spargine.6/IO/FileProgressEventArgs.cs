// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6
// Author           : David McCarter
// Created          : 03-02-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-20-2022
// ***********************************************************************
// <copyright file="FileProgressEventArgs.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.IO
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
