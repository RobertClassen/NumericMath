namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ByteExtensions
	{
		public static byte Root(this byte value, double root)
		{
			return (byte)Math.Pow(value, Double.One / root);
		}
	}
}