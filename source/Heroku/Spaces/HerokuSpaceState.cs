using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Heroku.Spaces
{
	/// <summary>
	/// 
	/// </summary>
	[JsonConverter(
		typeof(JsonStringEnumConverter<HerokuSpaceState>))]
	public enum HerokuSpaceState
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"allocating")]
		Allocating,

		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"allocated")]
		Allocated,

		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"deleting")]
		Deleting,
	}
}
