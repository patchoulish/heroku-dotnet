using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

using Heroku;
using Heroku.Apps;

namespace Heroku.Dynos
{
	/// <summary>
	/// 
	/// </summary>
	public class HerokuDynoApp
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"id")]
		public HerokuAppId Id { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"name")]
		public string Name { get; init; }
	}
}
