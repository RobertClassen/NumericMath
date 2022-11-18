namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
	{
		public static float Truncate(this float value)
		{
			return (float)Math.Truncate(value);
		}
	}
}