using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

using Heroku;
using Heroku.Apps;
using Heroku.Pipelines;

namespace Heroku.PipelineCouplings
{
	/// <summary>
	/// 
	/// </summary>
	public class HerokuPipelineCouplingCreateOptions
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"app")]
		public HerokuAppId App { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"pipeline")]
		public HerokuPipelineId Pipeline { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"stage")]
		public HerokuPipelineCouplingStage Stage { get; init; }
	}
}
