using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Heroku.PipelineCouplings
{
	/// <summary>
	/// 
	/// </summary>
	internal sealed class HerokuPipelineCouplingIdJsonConverter
		: JsonConverter<HerokuPipelineCouplingId>
	{
		/// <inheritdoc/>
		public override HerokuPipelineCouplingId Read(
			ref Utf8JsonReader reader,
			Type typeToConvert,
			JsonSerializerOptions options) =>
				new HerokuPipelineCouplingId(
					reader.GetGuid());

		/// <inheritdoc/>
		public override void Write(
			Utf8JsonWriter writer,
			HerokuPipelineCouplingId value,
			JsonSerializerOptions options) =>
				writer.WriteStringValue(
					value.Value);
	}
}
