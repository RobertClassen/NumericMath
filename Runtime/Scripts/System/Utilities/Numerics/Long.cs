namespace WellDefinedTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static class Long
	{
		#region Constants
		public const byte BitCount = sizeof(long) * Byte.BitCount;

		public const long Zero = Byte.Zero;
		public const long One = Byte.One;
		public const long Ten = Byte.Ten;
		public const long Hundred = Byte.Hundred;

		private static readonly Random random = new Random();
		#endregion

		#region Enums
		[Flags]
		public enum Enum : ulong
		{
			#if !LONG_FLAGS
			[Obsolete("To enable Long.Enum add the Scripting Define Symbol 'LONG_FLAGS' in the Player Settings.")]
			Disabled,
			#endif
			#if LONG_FLAGS
			/// <summary>
			/// 0
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Nothing = Flag00 >> (int)Flag00,
			/// <summary>
			/// 1
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0001
			/// </remarks>
			Flag00 = One,
			/// <summary>
			/// 2
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0010
			/// </remarks>
			Flag01 = Flag00 << (int)Flag00,
			/// <summary>
			/// 4
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0100
			/// </remarks>
			Flag02 = Flag01 << (int)Flag00,
			/// <summary>
			/// 8
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 1000
			/// </remarks>
			Flag03 = Flag02 << (int)Flag00,
			/// <summary>
			/// 16
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0001 0000
			/// </remarks>
			Flag04 = Flag03 << (int)Flag00,
			/// <summary>
			/// 32
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0010 0000
			/// </remarks>
			Flag05 = Flag04 << (int)Flag00,
			/// <summary>
			/// 64
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0100 0000
			/// </remarks>
			Flag06 = Flag05 << (int)Flag00,
			/// <summary>
			/// 128
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 1000 0000
			/// </remarks>
			Flag07 = Flag06 << (int)Flag00,
			/// <summary>
			/// 256
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0001 0000 0000
			/// </remarks>
			Flag08 = Flag07 << (int)Flag00,
			/// <summary>
			/// 512
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0010 0000 0000
			/// </remarks>
			Flag09 = Flag08 << (int)Flag00,
			/// <summary>
			/// 1,024
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0100 0000 0000
			/// </remarks>
			Flag10 = Flag09 << (int)Flag00,
			/// <summary>
			/// 2,048
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 1000 0000 0000
			/// </remarks>
			Flag11 = Flag10 << (int)Flag00,
			/// <summary>
			/// 4,096
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0001 0000 0000 0000
			/// </remarks>
			Flag12 = Flag11 << (int)Flag00,
			/// <summary>
			/// 8,192
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0010 0000 0000 0000
			/// </remarks>
			Flag13 = Flag12 << (int)Flag00,
			/// <summary>
			/// 16,384
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0100 0000 0000 0000
			/// </remarks>
			Flag14 = Flag13 << (int)Flag00,
			/// <summary>
			/// 32,768
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 1000 0000 0000 0000
			/// </remarks>
			Flag15 = Flag14 << (int)Flag00,
			/// <summary>
			/// 65,536
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0001 0000 0000 0000 0000
			/// </remarks>
			Flag16 = Flag15 << (int)Flag00,
			/// <summary>
			/// 131,072
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0010 0000 0000 0000 0000
			/// </remarks>
			Flag17 = Flag16 << (int)Flag00,
			/// <summary>
			/// 262,144
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0100 0000 0000 0000 0000
			/// </remarks>
			Flag18 = Flag17 << (int)Flag00,
			/// <summary>
			/// 524,288
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 1000 0000 0000 0000 0000
			/// </remarks>
			Flag19 = Flag18 << (int)Flag00,
			/// <summary>
			/// 1,048,576
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0001 0000 0000 0000 0000 0000
			/// </remarks>
			Flag20 = Flag19 << (int)Flag00,
			/// <summary>
			/// 2,097,152
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0010 0000 0000 0000 0000 0000
			/// </remarks>
			Flag21 = Flag20 << (int)Flag00,
			/// <summary>
			/// 4,194,304
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0100 0000 0000 0000 0000 0000
			/// </remarks>
			Flag22 = Flag21 << (int)Flag00,
			/// <summary>
			/// 8,388,608
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 1000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag23 = Flag22 << (int)Flag00,
			/// <summary>
			/// 16,777,216
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0000 0000 0000 0001 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag24 = Flag23 << (int)Flag00,
			/// <summary>
			/// 33,554,432
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0000 0000 0000 0010 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag25 = Flag24 << (int)Flag00,
			/// <summary>
			/// 67,108,864
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0000 0000 0000 0100 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag26 = Flag25 << (int)Flag00,
			/// <summary>
			/// 134,217,728
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0000 0000 0000 1000 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag27 = Flag26 << (int)Flag00,
			/// <summary>
			/// 268,435,456
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0000 0000 0001 0000 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag28 = Flag27 << (int)Flag00,
			/// <summary>
			/// 536,870,912
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0000 0000 0010 0000 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag29 = Flag28 << (int)Flag00,
			/// <summary>
			/// 1,073,741,824
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0000 0000 0100 0000 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag30 = Flag29 << (int)Flag00,
			/// <summary>
			/// 2,147,483,648
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0000 0000 1000 0000 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag31 = Flag30 << (int)Flag00,
			/// <summary>
			/// 4,294,967,296
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0000 0001 0000 0000 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag32 = Flag31 << (int)Flag00,
			/// <summary>
			/// 8,589,934,592
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0000 0010 0000 0000 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag33 = Flag32 << (int)Flag00,
			/// <summary>
			/// 17,179,869,184
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0000 0100 0000 0000 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag34 = Flag33 << (int)Flag00,
			/// <summary>
			/// 34,359,738,368
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0000 1000 0000 0000 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag35 = Flag34 << (int)Flag00,
			/// <summary>
			/// 68,719,476,736
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0001 0000 0000 0000 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag36 = Flag35 << (int)Flag00,
			/// <summary>
			/// 137,438,953,472
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0010 0000 0000 0000 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag37 = Flag36 << (int)Flag00,
			/// <summary>
			/// 274,877,906,944
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 0100 0000 0000 0000 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag38 = Flag37 << (int)Flag00,
			/// <summary>
			/// 549,755,813,888
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0000 1000 0000 0000 0000 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag39 = Flag38 << (int)Flag00,
			/// <summary>
			/// 1,099,511,627,776
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0001 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag40 = Flag39 << (int)Flag00,
			/// <summary>
			/// 2,199,023,255,552
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0010 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag41 = Flag40 << (int)Flag00,
			/// <summary>
			/// 4,398,046,511,104
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 0100 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag42 = Flag41 << (int)Flag00,
			/// <summary>
			/// 8,796,093,022,208
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0000 1000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag43 = Flag42 << (int)Flag00,
			/// <summary>
			/// 17,592,186,044,416
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0001 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag44 = Flag43 << (int)Flag00,
			/// <summary>
			/// 35,184,372,088,832
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0010 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag45 = Flag44 << (int)Flag00,
			/// <summary>
			/// 70,368,744,177,664
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 0100 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag46 = Flag45 << (int)Flag00,
			/// <summary>
			/// 140,737,488,355,328
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000 1000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag47 = Flag46 << (int)Flag00,
			/// <summary>
			/// 281,474,976,710,656
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0001 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag48 = Flag47 << (int)Flag00,
			/// <summary>
			/// 562,949,953,421,312
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0010 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag49 = Flag48 << (int)Flag00,
			/// <summary>
			/// 1,125,899,906,842,624
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0100 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag50 = Flag49 << (int)Flag00,
			/// <summary>
			/// 2,251,799,813,685,248
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 1000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag51 = Flag50 << (int)Flag00,
			/// <summary>
			/// 4,503,599,627,370,496
			/// </summary>
			/// <remarks>
			/// 0000 0000 0001 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag52 = Flag51 << (int)Flag00,
			/// <summary>
			/// 9,007,199,254,740,992
			/// </summary>
			/// <remarks>
			/// 0000 0000 0010 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag53 = Flag52 << (int)Flag00,
			/// <summary>
			/// 18,014,398,509,481,984
			/// </summary>
			/// <remarks>
			/// 0000 0000 0100 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag54 = Flag53 << (int)Flag00,
			/// <summary>
			/// 36,028,797,018,963,968
			/// </summary>
			/// <remarks>
			/// 0000 0000 1000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag55 = Flag54 << (int)Flag00,
			/// <summary>
			/// 72,057,594,037,927,936
			/// </summary>
			/// <remarks>
			/// 0000 0001 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag56 = Flag55 << (int)Flag00,
			/// <summary>
			/// 144,115,188,075,855,872
			/// </summary>
			/// <remarks>
			/// 0000 0010 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag57 = Flag56 << (int)Flag00,
			/// <summary>
			/// 288,230,376,151,711,744
			/// </summary>
			/// <remarks>
			/// 0000 0100 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag58 = Flag57 << (int)Flag00,
			/// <summary>
			/// 576,460,752,303,423,488
			/// </summary>
			/// <remarks>
			/// 0000 1000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag59 = Flag58 << (int)Flag00,
			/// <summary>
			/// 1,152,921,504,606,846,976
			/// </summary>
			/// <remarks>
			/// 0001 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag60 = Flag59 << (int)Flag00,
			/// <summary>
			/// 2,305,843,009,213,693,952
			/// </summary>
			/// <remarks>
			/// 0010 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag61 = Flag60 << (int)Flag00,
			/// <summary>
			/// 4,611,686,018,427,387,904
			/// </summary>
			/// <remarks>
			/// 0100 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag62 = Flag61 << (int)Flag00,
			/// <summary>
			/// 9,223,372,036,854,775,808
			/// </summary>
			/// <remarks>
			/// 1000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000
			/// </remarks>
			Flag63 = Flag62 << (int)Flag00,
			/// <summary>
			/// 18,446,744,073,709,551,615
			/// </summary>
			/// <remarks>
			/// 1111 1111 1111 1111 1111 1111 1111 1111 1111 1111 1111 1111 1111 1111 1111 1111
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