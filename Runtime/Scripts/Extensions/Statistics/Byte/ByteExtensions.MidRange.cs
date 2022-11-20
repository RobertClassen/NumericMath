namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ByteExtensions
	{
		public static double MidRange(this IEnumerable<byte> values)
		{
			byte min = byte.MaxValue;
			byte max = byte.MinValue;
			foreach(byte value in values)
			{
				if(value < min)
				{
					min = value;
				}
				if(value > max)
				{
					max = value;
				}
			}
			return (min + max) * Double.OneHalf;
		}
	}
}