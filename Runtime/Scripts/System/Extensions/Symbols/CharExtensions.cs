namespace System.Extensions
{
	using Collections;
	using Collections.Generic;
	using Utilities;
	using Char = Utilities.Char;

	public static class CharExtensions
	{
		#region Fields
		
		#endregion

		#region Properties
		
		#endregion

		#region Constructors
		
		#endregion

		#region Methods
		public static bool IsClamped(this char value, char min, char max, bool isInclusive = true)
		{
			return isInclusive ? min <= value && value <= max : min < value && value < max;
		}

		public static bool IsDecimalDigit(this char value)
		{
			return value.IsClamped(Char.Zero, Char.Nine);
		}

		public static bool IsDigit(this char value)
		{
			return char.IsDigit(value);
		}

		public static int ToInt(this char digit)
		{
			if(digit.IsDecimalDigit())
			{
				return digit - Char.Zero;
			}
			throw new ArgumentOutOfRangeException(nameof(digit), string.Format("'{0}' is not a valid decimal digit", digit));
		}

		public static char ToLower(this char c)
		{
			return char.ToLower(c);
		}

		public static char ToLowerInvariant(this char c)
		{
			return char.ToLowerInvariant(c);
		}

		public static char ToUpper(this char c)
		{
			return char.ToUpper(c);
		}

		public static char ToUpperInvariant(this char c)
		{
			return char.ToUpperInvariant(c);
		}
		#endregion
	}
}