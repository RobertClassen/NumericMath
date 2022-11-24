namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ShortExtensions
	{
		/// <summary>
		/// Returns the extreme value with the same sign.
		/// </summary>
		public static short Extreme(this short value)
		{
			return value < Short.Zero ? short.MinValue : short.MaxValue;
		}
	}
}