using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Heroku.Spaces
{
	/// <summary>
	/// 
	/// </summary>
	internal sealed class HerokuSpaceIdJsonConverter
		: JsonConverter<HerokuSpaceId>
	{
		/// <inheritdoc/>
		public override HerokuSpaceId Read(
			ref Utf8JsonReader reader,
			Type typeToConvert,
			JsonSerializerOptions options) =>
				new HerokuSpaceId(
					reader.GetGuid());

		/// <inheritdoc/>
		public override void Write(
			Utf8JsonWriter writer,
			HerokuSpaceId value,
			JsonSerializerOptions options) =>
				writer.WriteStringValue(
					value.Value);
	}
}
