namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ShortExtensions
	{
		public static short Root(this short value, double root)
		{
			return (short)Math.Pow(value, Double.One / root);
		}
	}
}