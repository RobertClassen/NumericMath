namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DoubleExtensions
	{
		public static double Asin(this double sin, bool isDegrees = Angle.IsDegreesDefault)
		{
			return Math.Asin(sin.ToRadians(isDegrees));
		}

		public static double Sin(this double angle, bool isDegrees = Angle.IsDegreesDefault)
		{
			return Math.Sin(angle.ToRadians(isDegrees));
		}

		public static double Sinh(this double hyperbolicAngle)
		{
			return Math.Sinh(hyperbolicAngle);
		}
	}
}