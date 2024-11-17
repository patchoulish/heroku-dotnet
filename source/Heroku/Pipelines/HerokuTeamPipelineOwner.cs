using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

using Heroku;
using Heroku.Teams;

namespace Heroku.Pipelines
{
	/// <summary>
	/// 
	/// </summary>
	public class HerokuTeamPipelineOwner :
		HerokuPipelineOwner
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"id")]
		public HerokuTeamId Id { get; init; }

		/// <summary>
		/// 
		/// </summary>
		public HerokuTeamPipelineOwner() :
			base()
		{
			Type = HerokuPipelineOwnerType.Team;
		}
	}
}
