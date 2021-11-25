namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ByteExtensions
	{
		public static byte Subtract(this byte value, byte subtrahend)
		{
			return (byte)(value - subtrahend);
		}

		public static IEnumerable<byte> Subtract(this byte value, byte subtrahend, int count)
		{
			if(count < Int.Zero)
			{
				throw new ArgumentLessThanZeroException(nameof(count), count);
			}
			for(int i = Int.Zero; i < count; i++)
			{
				yield return value -= subtrahend;
			}
		}
	}
}