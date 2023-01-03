namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
	{
		public static int FloorToInt(this float value)
		{
			return (int)value.Floor();
		}
	}
}