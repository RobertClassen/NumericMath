namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DecimalExtensions
	{
		public static decimal Truncate(this decimal value)
		{
			return Math.Truncate(value);
		}
	}
}