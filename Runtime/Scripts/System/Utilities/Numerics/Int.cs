namespace System.Utilities
{
	using Collections;
	using Collections.Generic;
	using Extensions;

	public static class Int
	{
		#region Constants
		public const byte BitCount = sizeof(int) * Byte.BitCount;

		public const int Zero = Byte.Zero;
		public const int One = Byte.One;
		public const int Two = Byte.Two;
		public const int Three = Byte.Three;
		public const int Four = Byte.Four;
		public const int Five = Byte.Five;
		public const int Six = Byte.Six;
		public const int Seven = Byte.Seven;
		public const int Eight = Byte.Eight;
		public const int Nine = Byte.Nine;
		public const int Ten = Byte.Ten;
		public const int Hundred = Byte.Hundred;

		private static readonly Random random = new Random();
		#endregion

		#region Enums
		[Flags]
		public enum Enum : uint
		{
			#if !INT_FLAGS
			[Obsolete("To enable Int.Enum add the Scripting Define Symbol 'INT_FLAGS' in the Player Settings.")]
			Disabled,
			#endif
			#if INT_FLAGS
			/// <summary>
			/// 0
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Nothing = Flag00 >> (int)Flag00,
			/// <summary>
			/// 1
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0000 0001
			/// </remarks>
			Flag00 = One,
			/// <summary>
			/// 2
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0000 0010
			/// </remarks>
			Flag01 = Flag00 << (int)Flag00,
			/// <summary>
			/// 4
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0000 0100
			/// </remarks>
			Flag02 = Flag01 << (int)Flag00,
			/// <summary>
			/// 8
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0000 1000
			/// </remarks>
			Flag03 = Flag02 << (int)Flag00,
			/// <summary>
			/// 16
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0001 0000
			/// </remarks>
			Flag04 = Flag03 << (int)Flag00,
			/// <summary>
			/// 32
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0010 0000
			/// </remarks>
			Flag05 = Flag04 << (int)Flag00,
			/// <summary>
			/// 64
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0100 0000
			/// </remarks>
			Flag06 = Flag05 << (int)Flag00,
			/// <summary>
			/// 128
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 1000 0000
			/// </remarks>
			Flag07 = Flag06 << (int)Flag00,
			/// <summary>
			/// 256
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0001 0000 0000
			/// </remarks>
			Flag08 = Flag07 << (int)Flag00,
			/// <summary>
			/// 512
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0010 0000 0000
			/// </remarks>
			Flag09 = Flag08 << (int)Flag00,
			/// <summary>
			/// 1,024
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0100 0000 0000
			/// </remarks>
			Flag10 = Flag09 << (int)Flag00,
			/// <summary>
			/// 2,048
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 1000 0000 0000
			/// </remarks>
			Flag11 = Flag10 << (int)Flag00,
			/// <summary>
			/// 4,096
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0001 0000 0000 0000
			/// </remarks>
			Flag12 = Flag11 << (int)Flag00,
			/// <summary>
			/// 8,192
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0010 0000 0000 0000
			/// </remarks>
			Flag13 = Flag12 << (int)Flag00,
			/// <summary>
			/// 16,384
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0100 0000 0000 0000
			/// </remarks>
			Flag14 = Flag13 << (int)Flag00,
			/// <summary>
			/// 32,768
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 1000 0000 0000 0000
			/// </remarks>
			Flag15 = Flag14 << (int)Flag00,
			/// <summary>
			/// 65,536
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0001 0000 0000 0000 0000
			/// </remarks>
			Flag16 = Flag15 << (int)Flag00,
			/// <summary>
			/// 131,072
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0010 0000 0000 0000 0000
			/// </remarks>
			Flag17 = Flag16 << (int)Flag00,
			/// <summary>
			/// 262,144
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0100 0000 0000 0000 0000
			/// </remarks>
			Flag18 = Flag17 << (int)Flag00,
			/// <summary>
			/// 524,288
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 1000 0000 0000 0000 0000
			/// </remarks>
			Flag19 = Flag18 << (int)Flag00,
			/// <summary>
			/// 1,048,576
			/// </summary>
			/// <remarks>
			/// 0000 0000 0001 0000 0000 0000 0000 0000
			/// </remarks>
			Flag20 = Flag19 << (int)Flag00,
			/// <summary>
			/// 2,097,152
			/// </summary>
			/// <remarks>
			/// 0000 0000 0010 0000 0000 0000 0000 0000
			/// </remarks>
			Flag21 = Flag20 << (int)Flag00,
			/// <summary>
			/// 4,194,304
			/// </summary>
			/// <remarks>
			/// 0000 0000 0100 0000 0000 0000 0000 0000
			/// </remarks>
			Flag22 = Flag21 << (int)Flag00,
			/// <summary>
			/// 8,388,608
			/// </summary>
			/// <remarks>
			/// 0000 0000 1000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag23 = Flag22 << (int)Flag00,
			/// <summary>
			/// 16,777,216
			/// </summary>
			/// <remarks>
			/// 0000 0001 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag24 = Flag23 << (int)Flag00,
			/// <summary>
			/// 33,554,432
			/// </summary>
			/// <remarks>
			/// 0000 0010 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag25 = Flag24 << (int)Flag00,
			/// <summary>
			/// 67,108,864
			/// </summary>
			/// <remarks>
			/// 0000 0100 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag26 = Flag25 << (int)Flag00,
			/// <summary>
			/// 134,217,728
			/// </summary>
			/// <remarks>
			/// 0000 1000 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag27 = Flag26 << (int)Flag00,
			/// <summary>
			/// 268,435,456
			/// </summary>
			/// <remarks>
			/// 0001 0000 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag28 = Flag27 << (int)Flag00,
			/// <summary>
			/// 536,870,912
			/// </summary>
			/// <remarks>
			/// 0010 0000 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag29 = Flag28 << (int)Flag00,
			/// <summary>
			/// 1,073,741,824
			/// </summary>
			/// <remarks>
			/// 0100 0000 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag30 = Flag29 << (int)Flag00,
			/// <summary>
			/// 2,147,483,648
			/// </summary>
			/// <remarks>
			/// 1000 0000 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag31 = Flag30 << (int)Flag00,
			/// <summary>
			/// 4,294,967,295
			/// </summary>
			/// <remarks>
			/// 1111 1111 1111 1111 1111 1111 1111 1111
			/// </remarks>
			Everything = unchecked(~Nothing),
			#endif
		}
		#endregion

		#region Fields

		#endregion

		#region Properties
		
		#endregion

		#region Constructors
		
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