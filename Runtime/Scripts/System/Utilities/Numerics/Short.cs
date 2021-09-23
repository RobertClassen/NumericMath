namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class Short
	{
		#region Constants
		public const byte BitCount = sizeof(short) * Byte.BitCount;

		public const short Zero = Byte.Zero;
		public const short One = Byte.One;
		public const short Hundred = Byte.Hundred;
		#endregion

		#region Fields

		#endregion

		#region Properties

		#endregion

		#region Constructors

		#endregion

		#region Methods
		public static short Random(short min, short max)
		{
			return (short)Int.Random(min, max);
		}

		public static IEnumerable<short> Sequence(short start, short increment, int count)
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