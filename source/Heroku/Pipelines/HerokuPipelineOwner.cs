using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Heroku.Pipelines
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPolymorphic(
		TypeDiscriminatorPropertyName = "type")]
	[JsonDerivedType(
		typeof(HerokuTeamPipelineOwner),
		"team")]
	[JsonDerivedType(
		typeof(HerokuAccountPipelineOwner),
		"user")]
	public class HerokuPipelineOwner
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"type")]
		public HerokuPipelineOwnerType Type { get; init; }
	}
}
