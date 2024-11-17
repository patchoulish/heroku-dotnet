using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

using Heroku;
using Heroku.Teams;

namespace Heroku.Spaces
{
	/// <summary>
	/// 
	/// </summary>
	public class HerokuSpaceTeam :
		HerokuObject<HerokuTeamId>
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"name")]
		public string Name { get; init; }
	}
}
