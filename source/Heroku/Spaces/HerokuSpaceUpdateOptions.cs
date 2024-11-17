using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Heroku.Spaces
{
	/// <summary>
	/// 
	/// </summary>
	public class HerokuSpaceUpdateOptions
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"name")]
		public string Name { get; init; }
	}
}
