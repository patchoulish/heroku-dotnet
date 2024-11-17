using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Heroku.Releases
{
	/// <summary>
	/// 
	/// </summary>
	internal sealed class HerokuReleaseIdJsonConverter
		: JsonConverter<HerokuReleaseId>
	{
		/// <inheritdoc/>
		public override HerokuReleaseId Read(
			ref Utf8JsonReader reader,
			Type typeToConvert,
			JsonSerializerOptions options) =>
				new HerokuReleaseId(
					reader.GetGuid());

		/// <inheritdoc/>
		public override void Write(
			Utf8JsonWriter writer,
			HerokuReleaseId value,
			JsonSerializerOptions options) =>
				writer.WriteStringValue(
					value.Value);
	}
}
