namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ShortExtensions
	{
		public static int BigMul(this short value, short factor)
		{
			return (int)Math.BigMul(value, factor);
		}
	}
}