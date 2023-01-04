namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class ByteExtensions
	{
		public static byte RoundToMid(this byte value, double stepSize, 
			MidpointRounding mode = MidpointRounding.ToEven)
		{
			return (byte)Math.Round(((double)value).RoundBetweenMinToMax(stepSize, Double.OneHalf), mode);
		}
	}
}