using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Heroku
{
	/// <summary>
	/// 
	/// </summary>
	public sealed class HerokuHttpMessageHandler :
		DelegatingHandler
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="innerHandler"></param>
		public HerokuHttpMessageHandler(
			HttpMessageHandler innerHandler) :
				base(
					innerHandler)
		{ }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		protected override async Task<HttpResponseMessage> SendAsync(
			HttpRequestMessage request,
			CancellationToken cancellationToken)
		{
			var response = default(HttpResponseMessage);

			try
			{
				response =
					await base.SendAsync(
						request,
						cancellationToken);
			}
			catch(Exception ex)
			{
				throw new HerokuException(
					"The operation was not successful.",
					ex);
			}

			if (!response.IsSuccessStatusCode)
			{
				var responseError =
					await response.Content
						.ReadFromJsonAsync<HerokuError>(
							HerokuService.JsonSerializerOptions,
							cancellationToken);

				throw new HerokuException(
					"The operation was not successful.",
					default,
					response.StatusCode,
					responseError);
			}

			return response;
		}
	}
}
