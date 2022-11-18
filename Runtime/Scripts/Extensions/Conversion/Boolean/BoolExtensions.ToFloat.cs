namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class BoolExtensions
	{
		public static float ToFloat(this bool value)
		{
			return value ? Float.One : Float.Zero;
		}
	}
}