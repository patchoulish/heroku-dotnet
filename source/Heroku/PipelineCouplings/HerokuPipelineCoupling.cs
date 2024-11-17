using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Heroku.PipelineCouplings
{
	/// <summary>
	/// 
	/// </summary>
	public class HerokuPipelineCoupling :
		HerokuObject<HerokuPipelineCouplingId>
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"app")]
		public HerokuPipelineCouplingApp App { get; init; }

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
			"pipeline")]
		public HerokuPipelineCouplingPipeline Pipeline { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"stage")]
		public HerokuPipelineCouplingStage Stage { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"updated_at")]
		public DateTimeOffset UpdatedAt { get; init; }
	}
}
