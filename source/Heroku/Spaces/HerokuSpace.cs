using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Heroku.Spaces
{
	/// <summary>
	/// 
	/// </summary>
	public class HerokuSpace :
		HerokuObject<HerokuSpaceId>
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"cidr")]
		public string Cidr { get; init; }

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
			"data_cidr")]
		public string DataCidr { get; init; }

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
			"region")]
		public HerokuSpaceRegion Region { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"shield")]
		public bool IsShieldEnabled {  get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"state")]
		public HerokuSpaceState State {  get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"team")]
		public HerokuSpaceTeam Team { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"updated_at")]
		public DateTimeOffset UpdatedAt { get; init; }
	}
}
