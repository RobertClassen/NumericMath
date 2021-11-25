namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ShortExtensions
	{
		public static short Multiply(this short value, short factor)
		{
			return (short)(value * factor);
		}

		public static IEnumerable<short> Multiply(this short value, short factor, int count)
		{
			if(count < Int.Zero)
			{
				throw new ArgumentLessThanZeroException(nameof(count), count);
			}
			for(int i = Int.Zero; i < count; i++)
			{
				yield return value *= factor;
			}
		}
	}
}