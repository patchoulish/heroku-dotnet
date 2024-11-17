using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Heroku.Dynos
{
	/// <summary>
	/// 
	/// </summary>
	internal sealed class HerokuDynoIdJsonConverter
		: JsonConverter<HerokuDynoId>
	{
		/// <inheritdoc/>
		public override HerokuDynoId Read(
			ref Utf8JsonReader reader,
			Type typeToConvert,
			JsonSerializerOptions options) =>
				new HerokuDynoId(
					reader.GetGuid());

		/// <inheritdoc/>
		public override void Write(
			Utf8JsonWriter writer,
			HerokuDynoId value,
			JsonSerializerOptions options) =>
				writer.WriteStringValue(
					value.Value);
	}
}
