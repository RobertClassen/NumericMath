namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static class Float
	{
		#region Constants
		public const byte BitCount = sizeof(float) * Byte.BitCount;

		public const float Zero = Byte.Zero;
		public const float One = Byte.One;
		public const float Ten = Byte.Ten;
		public const float Hundred = Byte.Hundred;

		public const float OneHalf = One / (One + One);

		private static readonly Random random = new Random();
		#endregion

		#region Fields
		
		#endregion

		#region Properties
		
		#endregion

		#region Constructors
		
		#endregion

		#region Methods
		public static float InverseLerp(float a, float b, float value, bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return Math.Abs(a - b) > float.Epsilon ? 
				((value - a) / (b - a)).Clamp01(isClamped) : Zero;
		}

		public static float Lerp(float a, float b, float t = OneHalf, bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return a + (b - a) * t.Clamp01(isClamped);
		}

		public static float Random(int min, int max)
		{
			return Int.Random(min, max);
		}

		public static float Random(int min, int max, int decimals)
		{
			float magnitude = (float)Math.Pow(Numeric.DecimalBase, decimals);
			return Random(min * (int)magnitude, max * (int)magnitude) / magnitude;
		}

		public static float Remap(float fromA, float fromB, float toA, float toB, float value, 
			bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return Lerp(toA, toB, InverseLerp(fromA, fromB, value, isClamped), isClamped);
		}

		public static IEnumerable<float> Sequence(float start, float increment, int count)
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