namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ShortExtensions
	{
		public static short Divide(this short value, short divisor)
		{
			return (short)(value / divisor);
		}

		public static IEnumerable<short> Divide(this short value, short divisor, int count)
		{
			if(count < Int.Zero)
			{
				throw new ArgumentLessThanZeroException();
			}
			for(int i = Int.Zero; i < count; i++)
			{
				yield return value /= divisor;
			}
		}
	}
}