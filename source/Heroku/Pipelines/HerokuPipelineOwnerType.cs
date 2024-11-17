using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Heroku.Pipelines
{
	/// <summary>
	/// 
	/// </summary>
	[JsonConverter(
		typeof(JsonStringEnumConverter<HerokuPipelineOwnerType>))]
	public enum HerokuPipelineOwnerType
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"team")]
		Team,

		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"user")]
		Account,
	}
}
