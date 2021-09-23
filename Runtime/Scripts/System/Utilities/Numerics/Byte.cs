namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class Byte
	{
		#region Constants
		public const int BitCount = sizeof(byte) * 8;

		public const byte Zero = One - One;
		public const byte One = 1;
		public const byte Ten = 10;
		public const byte Hundred = Ten * Ten;
		#endregion

		#region Fields
		
		#endregion

		#region Properties
		
		#endregion

		#region Constructors
		
		#endregion

		#region Methods
		public static byte Random(byte min, byte max)
		{
			return (byte)Int.Random(min, max);
		}

		public static IEnumerable<byte> Sequence(byte start, byte increment, int count)
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