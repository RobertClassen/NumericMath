namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ByteExtensions
	{
		public static byte ArithmeticMean(this IEnumerable<byte> values)
		{
			double sum = Double.Zero;
			int count = Int.Zero;
			foreach(byte value in values)
			{
				sum += value;
				count++;
			}
			return (byte)(sum / (double)count);
		}

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

		public static byte HarmonicMean(this IEnumerable<byte> values)
		{
			double sum = Double.Zero;
			int count = Int.Zero;
			foreach(byte value in values)
			{
				sum += Double.One / (double)value;
				count++;
			}
			return (byte)(count / sum);
		}
	}
}