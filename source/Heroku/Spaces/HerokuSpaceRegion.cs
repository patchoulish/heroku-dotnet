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
	public class HerokuSpaceRegion :
		HerokuObject<HerokuRegionId>
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"name")]
		public string Name { get; init; }
	}
}
