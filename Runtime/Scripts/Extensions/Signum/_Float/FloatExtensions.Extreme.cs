namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
	{
		/// <summary>
		/// Returns the extreme value with the same sign.
		/// </summary>
		public static float Extreme(this float value)
		{
			return value < Float.Zero ? float.MinValue : float.MaxValue;
		}
	}
}