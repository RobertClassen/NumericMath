namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ByteExtensions
	{
		public static byte Add(this byte value, byte addend)
		{
			return (byte)(value + addend);
		}

		public static IEnumerable<byte> Add(this byte value, byte addend, int count)
		{
			if(count < Int.Zero)
			{
				throw new ArgumentLessThanZeroException(nameof(count), count);
			}
			for(int i = Int.Zero; i < count; i++)
			{
				yield return value += addend;
			}
		}
	}
}