using System;
using System.Net;
using System.Net.Http;

namespace Heroku
{
	/// <summary>
	/// 
	/// </summary>
	public class HerokuException :
		HttpRequestException
	{
#if NETSTANDARD
		
		/// <summary>
		/// 
		/// </summary>
		public HttpStatusCode? StatusCode { get; private init; }

#endif

		/// <summary>
		/// 
		/// </summary>
		public HerokuError Error { get; private init; }

		/// <summary>
		/// 
		/// </summary>
		public HerokuException() :
			this(
				default)
		{ }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		public HerokuException(
			string message) :
				this(
					message,
					default)
		{ }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		/// <param name="innerException"></param>
		public HerokuException(
			string message,
			Exception innerException) :
				this(
					message,
					innerException,
					default)
		{ }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		/// <param name="innerException"></param>
		/// <param name="statusCode"></param>
		public HerokuException(
			string message,
			Exception innerException,
			HttpStatusCode? statusCode) :
				this(
					message,
					innerException,
					statusCode,
					default)
		{ }

#if NETSTANDARD

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		/// <param name="innerException"></param>
		/// <param name="statusCode"></param>
		/// <param name="error"></param>
		public HerokuException(
			string message,
			Exception innerException,
			HttpStatusCode? statusCode,
			HerokuError error) :
				base(
					message,
					innerException)
		{
			StatusCode = statusCode;
			Error = error;
		}

#else

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		/// <param name="inner"></param>
		/// <param name="statusCode"></param>
		/// <param name="error"></param>
		public HerokuException(
			string message,
			Exception inner,
			HttpStatusCode? statusCode,
			HerokuError error) :
				base(
					message,
					inner,
					statusCode)
		{
			Error = error;
		}

#endif
	}
}
