namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ByteExtensions
	{
		public static byte GeometricMean(this IEnumerable<byte> values)
		{
			double sum = Double.One;
			int count = Int.Zero;
			foreach(byte value in values)
			{
				sum *= value;
				count++;
			}
			return (byte)sum.Root(count);
		}
	}
}