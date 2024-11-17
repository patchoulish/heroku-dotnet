using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Heroku.Stacks
{
	/// <summary>
	/// 
	/// </summary>
	internal sealed class HerokuStackIdJsonConverter
		: JsonConverter<HerokuStackId>
	{
		/// <inheritdoc/>
		public override HerokuStackId Read(
			ref Utf8JsonReader reader,
			Type typeToConvert,
			JsonSerializerOptions options) =>
				new HerokuStackId(
					reader.GetGuid());

		/// <inheritdoc/>
		public override void Write(
			Utf8JsonWriter writer,
			HerokuStackId value,
			JsonSerializerOptions options) =>
				writer.WriteStringValue(
					value.Value);
	}
}
