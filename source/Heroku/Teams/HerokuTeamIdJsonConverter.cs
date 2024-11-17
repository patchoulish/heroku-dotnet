using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Heroku.Teams
{
	/// <summary>
	/// 
	/// </summary>
	internal sealed class HerokuTeamIdJsonConverter
		: JsonConverter<HerokuTeamId>
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="reader"></param>
		/// <param name="typeToConvert"></param>
		/// <param name="options"></param>
		/// <returns></returns>
		public override HerokuTeamId Read(
			ref Utf8JsonReader reader,
			Type typeToConvert,
			JsonSerializerOptions options) =>
				new HerokuTeamId(
					reader.GetGuid());

		/// <summary>
		/// 
		/// </summary>
		/// <param name="writer"></param>
		/// <param name="value"></param>
		/// <param name="options"></param>
		public override void Write(
			Utf8JsonWriter writer,
			HerokuTeamId value,
			JsonSerializerOptions options) =>
				writer.WriteStringValue(
					value.Value);
	}
}
