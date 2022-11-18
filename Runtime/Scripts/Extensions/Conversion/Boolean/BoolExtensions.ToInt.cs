namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class BoolExtensions
	{
		public static int ToInt(this bool value)
		{
			return value ? Int.One : Int.Zero;
		}
	}
}