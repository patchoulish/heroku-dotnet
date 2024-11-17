using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Heroku.Regions
{
	/// <summary>
	/// 
	/// </summary>
	public class HerokuRegionProvider
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
			"region")]
		public HerokuRegionProviderRegion Region { get; init; }
	}
}
