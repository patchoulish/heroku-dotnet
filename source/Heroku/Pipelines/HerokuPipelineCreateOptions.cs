using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Heroku.Pipelines
{
	/// <summary>
	/// 
	/// </summary>
	public class HerokuPipelineCreateOptions
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
			"owner")]
		public HerokuPipelineOwner Owner { get; init; }
	}
}
