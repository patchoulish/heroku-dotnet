using System;
using System.Collections.Immutable;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Heroku.Dynos
{
	/// <summary>
	/// 
	/// </summary>
	public class HerokuDynoCreateOptions
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"command")]
		public string Command { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"attach")]
		public bool? Attach { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"env")]
		public ImmutableDictionary<string, string> Env { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"force_no_tty")]
		public bool? ForceNoTty { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"size")]
		public string Size { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"time_to_live")]
		public int? TimeToLive { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"type")]
		public string Type { get; init; }
	}
}
