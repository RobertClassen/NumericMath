namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class ByteExtensions
	{
		/// <summary>
		/// Rounds the value to the specified percentage 
		/// between the nearest and furthest value 
		/// of the next-lower and next-higher value 
		/// at the specified <c>stepSize</c>.
		/// </summary>
		public static byte RoundBetweenNearestToFurthest(this byte value, double stepSize, double percent, 
			bool clamp = Numeric.IsLerpClampedDefault)
		{
			return (byte)((double)value).RoundBetweenNearestToFurthest(stepSize, percent, clamp);
		}
	}
}