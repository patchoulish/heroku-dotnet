using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Heroku
{
	/// <summary>
	/// 
	/// </summary>
	public sealed partial class HerokuService :
		IHerokuService
	{
		/// <summary>
		/// 
		/// </summary>
		public static Uri DefaultBaseUrl { get; } =
			new Uri(
				"https://api.heroku.com/");

		/// <summary>
		/// 
		/// </summary>
		internal static JsonSerializerOptions JsonSerializerOptions { get; } =
			new JsonSerializerOptions()
			{
				AllowOutOfOrderMetadataProperties = true,
				DefaultIgnoreCondition =
					JsonIgnoreCondition.WhenWritingNull
			};

		/// <summary>
		/// 
		/// </summary>
		/// <param name="baseUrl"></param>
		/// <param name="apiKey"></param>
		/// <returns></returns>
		private static HttpClient CreateClient(
			Uri baseUrl,
			string apiKey)
		{
			Guard.NotNull(
				baseUrl,
				nameof(baseUrl));

			Guard.NotNullOrEmpty(
				apiKey,
				nameof(apiKey));

			var client =
				new HttpClient(
					new HerokuHttpMessageHandler(
						new HttpClientHandler()),
					disposeHandler: true);

			client.BaseAddress =
				baseUrl;

			client.DefaultRequestHeaders.Add(
				$"Authorization",
				$"Bearer {apiKey}");

			client.DefaultRequestHeaders.Add(
				$"Accept",
				$"application/vnd.heroku+json; version=3");

			return client;
		}

		private readonly HttpClient httpClient;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="apiKey"></param>
		public HerokuService(
			string apiKey) :
				this(
					DefaultBaseUrl,
					apiKey)
		{ }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="baseUrl"></param>
		/// <param name="apiKey"></param>
		public HerokuService(
			Uri baseUrl,
			string apiKey) :
				this(
					CreateClient(
						baseUrl,
						apiKey))
		{ }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="httpClient"></param>
		public HerokuService(
			HttpClient httpClient)
		{
			Guard.NotNull(
				httpClient,
				nameof(httpClient));

			this.httpClient = httpClient;
		}
	}
}
