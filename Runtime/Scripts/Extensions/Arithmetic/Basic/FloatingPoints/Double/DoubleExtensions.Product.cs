namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DoubleExtensions
	{
		public static double Product(this IEnumerable<double> values)
		{
			double product = Double.One;
			foreach(double value in values)
			{
				product *= value;
			}
			return product;
		}
	}
}