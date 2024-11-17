using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Heroku.Pipelines
{
	/// <summary>
	/// 
	/// </summary>
	public class HerokuPipeline :
		HerokuObject<HerokuPipelineId>
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
			"name")]
		public string Name { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"owner")]
		public HerokuPipelineOwner Owner { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"updated_at")]
		public DateTimeOffset UpdatedAt { get; init; }
	}
}
