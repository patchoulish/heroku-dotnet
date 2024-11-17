using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Heroku.Dynos
{
	/// <summary>
	/// 
	/// </summary>
	[JsonConverter(
		typeof(JsonStringEnumConverter<HerokuDynoState>))]
	public enum HerokuDynoState
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"crashed")]
		Crashed,

		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"down")]
		Down,

		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"idle")]
		Idle,

		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"starting")]
		Starting,

		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"up")]
		Up,
	}
}
