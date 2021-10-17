namespace WellDefinedValues.Core
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static class Numeric
	{
		public enum Base
		{
			Binary = 2,
			Octal = 8,
			Decimal = 10,
			Hex = 16,
		}

		public const bool IsAngleSignedDefault = true;
		public const bool IsClampEnabledDefault = true;
		public const bool IsClampedInclusiveDefault = true;
		public const bool IsLerpClampedDefault = false;

		public const float MagnitudeDelta = 0.00001f;

		public const char Percent = '%';
		public const char Zero = '0';

		public static readonly Random Random = new Random();
	}
}