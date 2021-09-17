namespace System.Utilities
{
	using Collections;
	using Collections.Generic;
	using Extensions;

	public static class Decimal
	{
		#region Constants
		public const byte BitCount = (byte)(sizeof(decimal) * Byte.BitCount);

		public const decimal Zero = Byte.Zero;
		public const decimal One = Byte.One;
		public const decimal Two = Byte.Two;
		public const decimal Three = Byte.Three;
		public const decimal Four = Byte.Four;
		public const decimal Five = Byte.Five;
		public const decimal Six = Byte.Six;
		public const decimal Seven = Byte.Seven;
		public const decimal Eight = Byte.Eight;
		public const decimal Nine = Byte.Nine;
		public const decimal Ten = Byte.Ten;
		public const decimal Hundred = Byte.Hundred;

		public const decimal OneHalf = One / Two;
		public const decimal OneThird = One / Three;
		public const decimal TwoThird = Two / Three;
		public const decimal OneQuarter = One / Four;
		public const decimal ThreeQuarter = Three / Four;

		private static readonly Random random = new Random();
		#endregion

		#region Fields

		#endregion

		#region Properties

		#endregion

		#region Constructors

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
			decimal magnitude = (decimal)Math.Pow(Int.Ten, decimals);
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