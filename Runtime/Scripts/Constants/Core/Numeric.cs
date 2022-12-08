namespace NumericMath.Core
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static class Numeric
	{
		public static class Base
		{
			public const byte Binary = 2;
			public const byte Octal = 8;
			public const byte Decimal = 10;
			public const byte Hex = 16;
		}

		public const bool IsClampEnabledDefault = true;
		public const bool IsClampedInclusiveDefault = true;
		public const bool IsLerpClampedDefault = false;
		public const bool RepeatByIndexDefault = false;

		public const char Zero = '0';
	}
}