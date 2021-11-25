namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ByteExtensions
	{
		public static byte Divide(this byte value, byte divisor)
		{
			return (byte)(value / divisor);
		}

		public static IEnumerable<byte> Divide(this byte value, byte divisor, int count)
		{
			if(count < Int.Zero)
			{
				throw new ArgumentLessThanZeroException(nameof(count), count);
			}
			for(int i = Int.Zero; i < count; i++)
			{
				yield return value /= divisor;
			}
		}
	}
}