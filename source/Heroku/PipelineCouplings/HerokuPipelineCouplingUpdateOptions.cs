using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Heroku.PipelineCouplings
{
	/// <summary>
	/// 
	/// </summary>
	public class HerokuPipelineCouplingUpdateOptions
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"stage")]
		public HerokuPipelineCouplingStage Stage { get; init; }
	}
}
