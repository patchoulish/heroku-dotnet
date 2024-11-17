using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Heroku.Pipelines
{
	/// <summary>
	/// 
	/// </summary>
	public class HerokuPipelineUpdateOptions
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"name")]
		public string Name { get; init; }
	}
}
