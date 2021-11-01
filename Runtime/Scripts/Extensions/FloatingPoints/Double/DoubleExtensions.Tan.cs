namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DoubleExtensions
	{
		public static double Atan(this double value, bool isDegrees = Angle.IsDegreesDefault)
		{
			return Math.Atan(value.ToRadians(isDegrees));
		}

		public static double Atan2(this double y, double x, bool isDegrees = Angle.IsDegreesDefault)
		{
			return Math.Atan2(y, x).ToDegrees(isDegrees);
		}

		public static double Tan(this double value, bool isDegrees = Angle.IsDegreesDefault)
		{
			return Math.Tan(value.ToRadians(isDegrees));
		}

		public static double Tanh(this double value, bool isDegrees = Angle.IsDegreesDefault)
		{
			return Math.Tanh(value.ToRadians(isDegrees));
		}
	}
}