using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Heroku
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T1"></typeparam>
	/// <typeparam name="T2"></typeparam>
	[StructLayout(
		LayoutKind.Explicit)]
	[JsonConverter(
		typeof(EitherJsonConverter))]
	public readonly struct Either<T1, T2> :
		IEquatable<Either<T1, T2>>
	{
		/// <summary>
		/// 
		/// </summary>
		private const bool DiscriminatorForValue1 = false;

		/// <summary>
		/// 
		/// </summary>
		private const bool DiscriminatorForValue2 = true;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="valueA"></param>
		/// <param name="valueB"></param>
		/// <returns></returns>
		public static bool Equals(
			Either<T1, T2> valueA,
			Either<T1, T2> valueB)
		{
			return
				(valueA.discriminator == valueB.discriminator) &&
				(valueA.discriminator ?
					Equals(valueA.value1, valueB.value1) :
					Equals(valueA.value2, valueB.value2));
		}

		[FieldOffset(0)]
		private readonly bool discriminator;
		[FieldOffset(1)]
		private readonly T1 value1;
		[FieldOffset(1)]
		private readonly T2 value2;

		/// <summary>
		/// 
		/// </summary>
		public bool IsValue1 =>
			(this.discriminator == DiscriminatorForValue1);

		/// <summary>
		/// 
		/// </summary>
		public bool IsValue2 =>
			(this.discriminator == DiscriminatorForValue2);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="value"></param>
		public Either(
			T1 value)
		{
			this.discriminator = DiscriminatorForValue1;
			this.value1 = value;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="value"></param>
		public Either(
			T2 value)
		{
			this.discriminator = DiscriminatorForValue2;
			this.value2 = value;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="some1"></param>
		/// <param name="some2"></param>
		public void Match(
			Action<T1> some1,
			Action<T2> some2)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="TResult"></typeparam>
		/// <param name="some1"></param>
		/// <param name="some2"></param>
		/// <returns></returns>
		public TResult Match<TResult>(
			Func<T1, TResult> some1,
			Func<T2, TResult> some2)
		{
			throw new NotImplementedException();
		}

		/// <inheritdoc/>
		public bool Equals(
			Either<T1, T2> other) =>
				Equals(
					this,
					other);

		/// <inheritdoc/>
		public override bool Equals(
			object obj)
		{
			if (obj is Either<T1, T2> other)
			{
				return Equals(
					this,
					other);
			}

			return false;
		}

		/// <inheritdoc/>
		public override int GetHashCode() =>
			Match(
				(some1) => some1.GetHashCode(),
				(some2) => some2.GetHashCode());

		/// <inheritdoc/>
		public override string ToString() =>
			Match(
				(some1) => some1.ToString(),
				(some2) => some2.ToString());

		/// <summary>
		/// 
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		[MethodImpl(
			MethodImplOptions.AggressiveInlining)]
		public static implicit operator Either<T1, T2>(
			T1 value) =>
				new Either<T1, T2>(
					value);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		[MethodImpl(
			MethodImplOptions.AggressiveInlining)]
		public static implicit operator Either<T1, T2>(
			T2 value) =>
				new Either<T1, T2>(
					value);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="valueLeft"></param>
		/// <param name="valueRight"></param>
		/// <returns></returns>
		[MethodImpl(
			MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(
			Either<T1, T2> valueLeft,
			Either<T1, T2> valueRight) =>
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
			Either<T1, T2> valueLeft,
			Either<T1, T2> valueRight) =>
				!Equals(
					valueLeft,
					valueRight);
	}
}
