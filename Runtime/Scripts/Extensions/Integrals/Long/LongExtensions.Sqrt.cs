namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class LongExtensions
	{
		public static float Sqrt(this long value)
		{
			return (float)Math.Sqrt(value);
		}
	}
}