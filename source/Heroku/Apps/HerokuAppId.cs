using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Heroku.Apps
{
	/// <summary>
	/// 
	/// </summary>
	[StructLayout(
		LayoutKind.Sequential)]
	[JsonConverter(
		typeof(HerokuAppIdJsonConverter))]
	public readonly struct HerokuAppId :
		IEquatable<HerokuAppId>
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="valueA"></param>
		/// <param name="valueB"></param>
		/// <returns></returns>
		public static bool Equals(
			HerokuAppId valueA,
			HerokuAppId valueB)
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
		public HerokuAppId(
			Guid value)
		{
			this.value = value;
		}

		/// <inheritdoc/>
		public bool Equals(
			HerokuAppId other) =>
				Equals(
					this,
					other);

		/// <inheritdoc/>
		public override bool Equals(
			object obj)
		{
			if (obj is HerokuAppId other)
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
			HerokuAppId value) =>
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
			HerokuAppId valueLeft,
			HerokuAppId valueRight) =>
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
			HerokuAppId valueLeft,
			HerokuAppId valueRight) =>
				!Equals(
					valueLeft,
					valueRight);
	}
}
