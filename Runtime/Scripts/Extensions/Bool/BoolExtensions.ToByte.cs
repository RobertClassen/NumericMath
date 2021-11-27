namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class BoolExtensions
	{
		public static byte ToByte(this bool value)
		{
			return value ? Byte.One : Byte.Zero;
		}
	}
}