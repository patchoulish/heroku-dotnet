using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Heroku
{
	/// <summary>
	/// 
	/// </summary>
	internal sealed class EitherJsonConverter :
		JsonConverterFactory
	{
		/// <inheritdoc/>
		public override bool CanConvert(
			Type typeToConvert)
		{
			Guard.NotNull(
				typeToConvert,
				nameof(typeToConvert));

			return
				typeToConvert.IsValueType &&
				typeToConvert.IsGenericType &&
				typeToConvert.GetGenericTypeDefinition() == typeof(Either<,>);
		}

		/// <inheritdoc/>
		public override JsonConverter CreateConverter(
			Type typeToConvert,
			JsonSerializerOptions options)
		{
			Guard.NotNull(
				typeToConvert,
				nameof(typeToConvert));

			Guard.NotNull(
				options,
				nameof(options));

			var converterType =
				typeof(EitherJsonConverter<,>)
				.MakeGenericType(
					typeToConvert.GenericTypeArguments[0],
					typeToConvert.GenericTypeArguments[1]);

			return (Activator.CreateInstance(converterType) as JsonConverter);
		}
	}

	/// <summary>
	/// 
	/// </summary>
	internal sealed class EitherJsonConverter<T1, T2>
		: JsonConverter<Either<T1, T2>>
	{
		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="writer"></param>
		/// <param name="value"></param>
		/// <param name="options"></param>
		/// <exception cref="JsonException"></exception>
		private static void WriteInternal<T>(
			Utf8JsonWriter writer,
			T value,
			JsonSerializerOptions options)
		{
			var jsonConverter =
				(options.GetConverter(typeof(T)) as JsonConverter<T>) ??
					throw new JsonException(
						$"Couldn't find converter for type {typeof(T)}.");

			jsonConverter.Write(
				writer,
				value,
				options);
		}

		/// <inheritdoc/>
		public override Either<T1, T2> Read(
			ref Utf8JsonReader reader,
			Type typeToConvert,
			JsonSerializerOptions options) =>
				throw new NotSupportedException();

		/// <inheritdoc/>
		public override void Write(
			Utf8JsonWriter writer,
			Either<T1, T2> value,
			JsonSerializerOptions options) =>
				value.Match(
					(some1) => WriteInternal(
						writer,
						some1,
						options),
					(some2) => WriteInternal(
						writer,
						some2,
						options));
	}
}
