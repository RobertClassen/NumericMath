namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class BoolExtensions
	{
		public static short ToShort(this bool value)
		{
			return value ? Short.One : Short.Zero;
		}
	}
}