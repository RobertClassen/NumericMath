namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DoubleExtensions
	{
		public static double Atan(this double tan, bool isDegrees = Angle.IsDegreesDefault)
		{
			return Math.Atan(tan).ToDegrees(isDegrees);
		}

		public static double Atan2(this double y, double x, bool isDegrees = Angle.IsDegreesDefault)
		{
			return Math.Atan2(y, x).ToDegrees(isDegrees);
		}

		public static double Tan(this double angle, bool isDegrees = Angle.IsDegreesDefault)
		{
			return Math.Tan(angle.ToRadians(isDegrees));
		}

		public static double Tanh(this double hyperbolicAngle)
		{
			return Math.Tanh(hyperbolicAngle);
		}
	}
}