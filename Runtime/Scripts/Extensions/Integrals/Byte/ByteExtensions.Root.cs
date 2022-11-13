namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ByteExtensions
	{
		public static double Root(this byte value, double root)
		{
			return Math.Pow(value, Double.One / root);
		}

		public static float RootF(this byte value, double root)
		{
			return (float)Math.Pow(value, Double.One / root);
		}
	}
}