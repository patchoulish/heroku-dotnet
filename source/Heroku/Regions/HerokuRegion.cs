using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Heroku.Regions
{
	/// <summary>
	/// 
	/// </summary>
	public class HerokuRegion :
		HerokuObject<HerokuRegionId>
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"country")]
		public string Country { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"created_at")]
		public DateTimeOffset CreatedAt { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"description")]
		public string Description { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"locale")]
		public string Locale { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"name")]
		public string Name { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"private_capable")]
		public bool IsPrivateCapable { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"provider")]
		public HerokuRegionProvider Provider { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"updated_at")]
		public DateTimeOffset UpdatedAt { get; init; }
	}
}
