using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Heroku
{
	/// <summary>
	/// 
	/// </summary>
	public class HerokuError
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"id")]
		public string Id { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"message")]
		public string Message { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"url")]
		public Uri Url { get; init; }
	}
}
