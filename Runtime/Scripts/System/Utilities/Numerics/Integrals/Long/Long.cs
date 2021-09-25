namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class Long
	{
		#region Constants
		public const byte BitCount = sizeof(long) * Byte.BitCount;
		public const int HexLength = BitCount >> (int)(One + One);

		public const long Zero = Byte.Zero;
		public const long One = Byte.One;
		public const long Hundred = Byte.Hundred;

		private static readonly Random random = new Random();
		#endregion

		#region Methods
		public static int Random(int min, int max)
		{
			return random.Next(min, max);
		}

		public static IEnumerable<long> Sequence(long start, long increment, int count)
		{
			if(count < Int.Zero)
			{
				throw new ArgumentLessThanZeroException();
			}
			for(int i = Int.Zero; i < count; i++)
			{
				yield return start;
				start += increment;
			}
		}
		#endregion
	}
}