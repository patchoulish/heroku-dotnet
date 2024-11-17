using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime;
using System.Runtime.CompilerServices;

namespace Heroku
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TId"></typeparam>
	public class HerokuObject<TId>
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"id")]
		public TId Id { get; init; }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="value"></param>
		[MethodImpl(
			MethodImplOptions.AggressiveInlining)]
		public static implicit operator TId(
			HerokuObject<TId> value) =>
				value.Id;
	}
}
