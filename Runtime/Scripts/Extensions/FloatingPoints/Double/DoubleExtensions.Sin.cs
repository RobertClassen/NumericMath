namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DoubleExtensions
	{
		public static double Asin(this double value, bool isDegrees = Angle.IsDegreesDefault)
		{
			return Math.Asin(value.ToRadians(isDegrees));
		}

		public static double Sin(this double value, bool isDegrees = Angle.IsDegreesDefault)
		{
			return Math.Sin(value.ToRadians(isDegrees));
		}

		public static double Sinh(this double value, bool isDegrees = Angle.IsDegreesDefault)
		{
			return Math.Sinh(value.ToRadians(isDegrees));
		}
	}
}