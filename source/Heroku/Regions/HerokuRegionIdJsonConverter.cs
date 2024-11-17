using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Heroku.Regions
{
	/// <summary>
	/// 
	/// </summary>
	internal sealed class HerokuRegionIdJsonConverter
		: JsonConverter<HerokuRegionId>
	{
		/// <inheritdoc/>
		public override HerokuRegionId Read(
			ref Utf8JsonReader reader,
			Type typeToConvert,
			JsonSerializerOptions options) =>
				new HerokuRegionId(
					reader.GetGuid());

		/// <inheritdoc/>
		public override void Write(
			Utf8JsonWriter writer,
			HerokuRegionId value,
			JsonSerializerOptions options) =>
				writer.WriteStringValue(
					value.Value);
	}
}
