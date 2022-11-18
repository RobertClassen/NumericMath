namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class BoolExtensions
	{
		public static double ToDouble(this bool value)
		{
			return value ? Double.One : Double.Zero;
		}
	}
}