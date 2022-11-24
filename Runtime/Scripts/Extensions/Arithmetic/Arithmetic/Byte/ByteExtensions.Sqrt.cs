namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ByteExtensions
	{
		public static double Sqrt(this byte value)
		{
			return Math.Sqrt(value);
		}

		public static float SqrtF(this byte value)
		{
			return (float)Math.Sqrt(value);
		}
	}
}