namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ShortExtensions
	{
		public static float Sqrt(this short value)
		{
			return (float)Math.Sqrt(value);
		}
	}
}