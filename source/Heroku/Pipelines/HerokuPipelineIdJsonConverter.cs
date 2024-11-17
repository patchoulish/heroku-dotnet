using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Heroku.Pipelines
{
	/// <summary>
	/// 
	/// </summary>
	internal sealed class HerokuPipelineIdJsonConverter
		: JsonConverter<HerokuPipelineId>
	{
		/// <inheritdoc/>
		public override HerokuPipelineId Read(
			ref Utf8JsonReader reader,
			Type typeToConvert,
			JsonSerializerOptions options) =>
				new HerokuPipelineId(
					reader.GetGuid());

		/// <inheritdoc/>
		public override void Write(
			Utf8JsonWriter writer,
			HerokuPipelineId value,
			JsonSerializerOptions options) =>
				writer.WriteStringValue(
					value.Value);
	}
}
