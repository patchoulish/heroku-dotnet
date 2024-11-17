using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Heroku.Spaces
{
	/// <summary>
	/// 
	/// </summary>
	[StructLayout(
		LayoutKind.Sequential)]
	[JsonConverter(
		typeof(HerokuSpaceIdJsonConverter))]
	public readonly struct HerokuSpaceId :
		IEquatable<HerokuSpaceId>
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="valueA"></param>
		/// <param name="valueB"></param>
		/// <returns></returns>
		public static bool Equals(
			HerokuSpaceId valueA,
			HerokuSpaceId valueB)
		{
			return
				(valueA.value == valueB.value);
		}

		private readonly Guid value;

		/// <summary>
		/// 
		/// </summary>
		public Guid Value =>
			this.value;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="value"></param>
		public HerokuSpaceId(
			Guid value)
		{
			this.value = value;
		}

		/// <inheritdoc/>
		public bool Equals(
			HerokuSpaceId other) =>
				Equals(
					this,
					other);

		/// <inheritdoc/>
		public override bool Equals(
			object obj)
		{
			if (obj is HerokuSpaceId other)
			{
				return Equals(
					this,
					other);
			}

			return false;
		}

		/// <inheritdoc/>
		public override int GetHashCode() =>
			this.value.GetHashCode();

		/// <inheritdoc/>
		public override string ToString() =>
			this.value.ToString();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="value"></param>
		[MethodImpl(
			MethodImplOptions.AggressiveInlining)]
		public static implicit operator Guid(
			HerokuSpaceId value) =>
				value.Value;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="valueLeft"></param>
		/// <param name="valueRight"></param>
		/// <returns></returns>
		[MethodImpl(
			MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(
			HerokuSpaceId valueLeft,
			HerokuSpaceId valueRight) =>
				Equals(
					valueLeft,
					valueRight);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="valueLeft"></param>
		/// <param name="valueRight"></param>
		/// <returns></returns>
		[MethodImpl(
			MethodImplOptions.AggressiveInlining)]
		public static bool operator !=(
			HerokuSpaceId valueLeft,
			HerokuSpaceId valueRight) =>
				!Equals(
					valueLeft,
					valueRight);
	}
}
