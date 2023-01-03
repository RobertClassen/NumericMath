namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
	{
		public static float Floor(this float value)
		{
			return (float)Math.Floor(value);
		}
	}
}