namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ByteExtensions
	{
		public static IEnumerable<byte> Range(this byte start, int count, byte increment = Byte.One)
		{
			if(count < Int.Zero)
			{
				throw new ArgumentLessThanZeroException(nameof(count), count);
			}
			for(int i = Int.Zero; i < count; i++)
			{
				yield return start;
				start += increment;
			}
		}
	}
}