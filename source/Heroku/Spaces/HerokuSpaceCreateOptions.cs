using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

using Heroku;
using Heroku.Regions;

namespace Heroku.Spaces
{
	/// <summary>
	/// 
	/// </summary>
	public class HerokuSpaceCreateOptions
	{
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
			"team")]
		public string TeamName {  get; init; }

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
			"data_cidr")]
		public string DataCidr { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"log_drain_url")]
		public Uri LogDrainUrl {  get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"region")]
		public Either<HerokuRegionId, string> RegionIdOrName {  get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"shield")]
		public bool EnableShield { get; init; }
	}
}
