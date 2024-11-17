using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Heroku.Dynos
{
	/// <summary>
	/// 
	/// </summary>
	public class HerokuDyno :
		HerokuObject<HerokuDynoId>
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"app")]
		public HerokuDynoApp App { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"attach_url")]
		public Uri AttachUrl { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"command")]
		public string Command { get; init; }

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
			"name")]
		public string Name { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"release")]
		public HerokuDynoRelease Release { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"size")]
		public string Size { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"state")]
		public HerokuDynoState State { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"type")]
		public string Type { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"updated_at")]
		public DateTimeOffset UpdatedAt { get; init; }
	}
}
