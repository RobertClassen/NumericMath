namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class IntExtensions
	{
		public static int Product(this IEnumerable<int> values)
		{
			int product = Int.One;
			foreach(int value in values)
			{
				product *= value;
			}
			return product;
		}
	}
}