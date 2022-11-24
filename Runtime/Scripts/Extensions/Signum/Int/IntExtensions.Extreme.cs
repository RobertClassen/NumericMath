namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class IntExtensions
	{
		/// <summary>
		/// Returns the extreme value with the same sign.
		/// </summary>
		public static int Extreme(this int value)
		{
			return value < Int.Zero ? int.MinValue : int.MaxValue;
		}
	}
}