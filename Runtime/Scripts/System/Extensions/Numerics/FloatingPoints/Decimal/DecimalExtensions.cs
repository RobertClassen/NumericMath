namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DecimalExtensions
	{
		public static decimal Abs(this decimal value)
		{
			return Math.Abs(value);
		}
	}
}