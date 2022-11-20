namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DoubleExtensions
	{
		public static double Acos(this double cos, bool isDegrees = Angle.IsDegreesDefault)
		{
			return Math.Acos(cos).ToDegrees(isDegrees);
		}

		public static double Cos(this double angle, bool isDegrees = Angle.IsDegreesDefault)
		{
			return Math.Cos(angle.ToRadians(isDegrees));
		}

		public static double Cosh(this double hyperbolicAngle)
		{
			return Math.Cosh(hyperbolicAngle);
		}
	}
}