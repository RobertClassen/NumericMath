namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static class Decimal
	{
		#region Constants
		public const byte BitCount = (byte)(sizeof(decimal) * Byte.BitCount);

		public const decimal Zero = Byte.Zero;
		public const decimal One = Byte.One;
		public const decimal Hundred = Byte.Hundred;

		public const decimal OneHalf = One / (One + One);

		private static readonly Random random = new Random();
		#endregion

		#region Methods
		public static decimal InverseLerp(decimal a, decimal b, decimal value, bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return Math.Abs(a - b) > (decimal)double.Epsilon ? 
				((value - a) / (b - a)).Clamp01(isClamped) : Zero;
		}

		public static decimal Lerp(decimal a, decimal b, decimal t = OneHalf, bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return a + (b - a) * t.Clamp01(isClamped);
		}

		public static decimal Random(int min, int max)
		{
			return Int.Random(min, max);
		}

		public static decimal Random(int min, int max, int decimals)
		{
			decimal magnitude = (decimal)Math.Pow((double)Numeric.Base.Decimal, decimals);
			return Random(min * (int)magnitude, max * (int)magnitude) / magnitude;
		}

		public static decimal Remap(decimal fromA, decimal fromB, decimal toA, decimal toB, decimal value, 
			bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return Lerp(toA, toB, InverseLerp(fromA, fromB, value, isClamped), isClamped);
		}

		public static IEnumerable<decimal> Sequence(decimal start, decimal increment, int count)
		{
			if(count < Int.Zero)
			{
				throw new ArgumentLessThanZeroException();
			}
			for(int i = Int.Zero; i < count; i++)
			{
				yield return start;
				start += increment;
			}
		}
		#endregion
	}
}