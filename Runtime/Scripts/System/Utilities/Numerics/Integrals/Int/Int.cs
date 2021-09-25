namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class Int
	{
		#region Constants
		public const byte BitCount = sizeof(int) * Byte.BitCount;
		public const int HexLength = BitCount >> (One + One);

		public const int Zero = Byte.Zero;
		public const int One = Byte.One;
		public const int Hundred = Byte.Hundred;

		private static readonly Random random = new Random();
		#endregion

		#region Methods
		public static int Random(int min, int max)
		{
			return random.Next(min, max);
		}

		public static IEnumerable<int> Sequence(int start, int increment, int count)
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