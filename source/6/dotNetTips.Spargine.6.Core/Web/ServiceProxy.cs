// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Core
// Author           : David McCarter
// Created          : 02-07-2021
//
// Last Modified By : David McCarter
// Last Modified On : 03-28-2022
// ***********************************************************************
// <copyright file="ServiceProxy.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.ServiceModel;
using System.ServiceModel.Channels;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.Web
{
	/// <summary>
	/// Class ServiceProxy.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <seealso cref="IDisposable" />
	public abstract class ServiceProxy<T> : IDisposable where T : ICommunicationObject
	{
		/// <summary>
		/// The channel.
		/// </summary>
		private T _channel;

		/// <summary>
		/// The channel factory.
		/// </summary>
		private IChannelFactory<T> _channelFactory;

		/// <summary>
		/// The lock.
		/// </summary>
		private readonly object _lock = new();

		/// <summary>
		/// The service endpoint.
		/// </summary>
		private readonly string _serviceEndpoint;

		/// <summary>
		/// Initializes a new instance of the <see cref="ServiceProxy{T}" /> class.
		/// </summary>
		/// <param name="serviceEndpoint">The service endpoint.</param>
		protected ServiceProxy([NotNull] string serviceEndpoint) => this._serviceEndpoint = serviceEndpoint;

		/// <summary>
		/// Initializes this instance.
		/// </summary>
		private void Initialize()
		{
			lock (this._lock)
			{
				if (this.Channel is not null)
				{
					return;
				} ( this._channelFactory as IDisposable )?.Dispose();

				this._channelFactory = new ChannelFactory<T>(this._serviceEndpoint);

				this.Channel = this._channelFactory.CreateChannel(to: new EndpointAddress(this._serviceEndpoint));
			}
		}

		/// <summary>
		/// Closes the channel.
		/// </summary>
		protected void CloseChannel()
		{
			if (this.Channel is not null && this.Disposed is false)
			{
				this.Channel.Close();
			}
		}

		/// <summary>
		/// Releases unmanaged and - optionally - managed resources.
		/// </summary>
		/// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
		protected virtual void Dispose(bool disposing)
		{
			// Do nothing if the object has already been disposed of.
			if (this.Disposed)
			{
				return;
			}

			if (disposing)
			{
				lock (this._lock)
				{
					// Release disposable objects used by this instance here.
					( this._channel as IDisposable )?.Dispose();
					( this._channelFactory as IDisposable )?.Dispose();
				}
			}

			// Remember that the object has been disposed of.
			this.Disposed = true;
		}

		/// <summary>
		/// Gets the channel.
		/// </summary>
		/// <value>The channel.</value>
		protected T Channel
		{
			get
			{
				this.Initialize();
				return this._channel;
			}

			private set => this._channel = value;
		}

		/// <summary>
		/// Gets or sets a value indicating whether <see cref="ServiceProxy{T}" /> is disposed.
		/// </summary>
		/// <value><c>true</c> if disposed; otherwise, <c>false</c>.</value>
		protected bool Disposed { get; set; }

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			this.Dispose(true);

			// Unregister object for finalization.
			GC.SuppressFinalize(this);
		}
	}
}
