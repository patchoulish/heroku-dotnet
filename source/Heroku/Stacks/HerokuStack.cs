using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Heroku.Stacks
{
	/// <summary>
	/// 
	/// </summary>
	public sealed class HerokuStack :
		HerokuObject<HerokuStackId>
	{
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
			"default")]
		public bool IsDefault { get; init; }

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
			"state")]
		public HerokuStackState State { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"updated_at")]
		public DateTimeOffset UpdatedAt { get; init; }
	}
}
