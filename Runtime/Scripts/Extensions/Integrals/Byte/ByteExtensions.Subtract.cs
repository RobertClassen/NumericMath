namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ByteExtensions
	{
		public static byte Subtract(this byte start, byte increment)
		{
			return (byte)(start - increment);
		}

		public static IEnumerable<byte> Subtract(this byte start, byte increment, int count)
		{
			if(count < Int.Zero)
			{
				throw new ArgumentLessThanZeroException();
			}
			for(int i = Int.Zero; i < count; i++)
			{
				yield return start;
				start -= increment;
			}
		}
	}
}