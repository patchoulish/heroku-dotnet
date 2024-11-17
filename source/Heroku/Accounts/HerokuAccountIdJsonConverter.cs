using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Heroku.Accounts
{
	/// <summary>
	/// 
	/// </summary>
	internal sealed class HerokuAccountIdJsonConverter
		: JsonConverter<HerokuAccountId>
	{
		/// <inheritdoc/>
		public override HerokuAccountId Read(
			ref Utf8JsonReader reader,
			Type typeToConvert,
			JsonSerializerOptions options) =>
				new HerokuAccountId(
					reader.GetGuid());

		/// <inheritdoc/>
		public override void Write(
			Utf8JsonWriter writer,
			HerokuAccountId value,
			JsonSerializerOptions options) =>
				writer.WriteStringValue(
					value.Value);
	}
}
