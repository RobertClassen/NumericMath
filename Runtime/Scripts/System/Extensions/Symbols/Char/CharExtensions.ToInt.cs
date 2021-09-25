namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class CharExtensions
	{
		public static int ToInt(this char digit)
		{
			if(digit.IsDecimalDigit())
			{
				return digit - Char.Zero;
			}
			throw new ArgumentOutOfRangeException(nameof(digit), string.Format("'{0}' is not a valid decimal digit", digit));
		}
	}
}