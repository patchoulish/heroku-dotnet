using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Heroku.Stacks
{
	/// <summary>
	/// 
	/// </summary>
	[JsonConverter(
		typeof(JsonStringEnumConverter<HerokuStackState>))]
	public enum HerokuStackState
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"public")]
		Public,

		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"beta")]
		Beta,

		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"deprecated")]
		Deprecated,
	}
}
