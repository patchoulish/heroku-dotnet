using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

using Heroku;
using Heroku.Releases;

namespace Heroku.Dynos
{
	/// <summary>
	/// 
	/// </summary>
	public class HerokuDynoRelease
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"id")]
		public HerokuReleaseId Id { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"version")]
		public int Version { get; init; }
	}
}
