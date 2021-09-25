namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class CharExtensions
	{
		public static bool IsDecimalDigit(this char value)
		{
			return value.IsClamped(Char.Zero, Char.Nine);
		}

		public static bool IsDigit(this char value)
		{
			return char.IsDigit(value);
		}
	}
}