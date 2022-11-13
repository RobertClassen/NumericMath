namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ByteExtensions
	{
		public static float Sqrt(this byte value)
		{
			return (float)Math.Sqrt(value);
		}
	}
}