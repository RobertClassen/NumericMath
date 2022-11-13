namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class IntExtensions
	{
		public static float Sqrt(this int value)
		{
			return (float)Math.Sqrt(value);
		}
	}
}