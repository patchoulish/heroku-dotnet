using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Heroku.PipelineCouplings
{
	/// <summary>
	/// 
	/// </summary>
	[JsonConverter(
		typeof(JsonStringEnumConverter<HerokuPipelineCouplingStage>))]
	public enum HerokuPipelineCouplingStage
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"test")]
		Test,

		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"review")]
		Review,

		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"development")]
		Development,

		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"staging")]
		Staging,

		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"production")]
		Production,
	}
}
