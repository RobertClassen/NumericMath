namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DoubleExtensions
	{
		public static double Mean(this IEnumerable<double> values, Mean mean)
		{
			switch(mean)
			{
				case NumericMath.Mean.Arithmetic:
					return values.ArithmeticMean();
				case NumericMath.Mean.Geometric:
					return values.GeometricMean();
				case NumericMath.Mean.Harmonic:
					return values.HarmonicMean();
				default:
					throw new NotImplementedException(mean.ToString());
			}
		}
	}
}