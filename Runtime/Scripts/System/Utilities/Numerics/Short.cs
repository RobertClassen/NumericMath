namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static class Short
	{
		#region Constants
		public const byte BitCount = sizeof(short) * Byte.BitCount;

		public const short Zero = Byte.Zero;
		public const short One = Byte.One;
		public const short Ten = Byte.Ten;
		public const short Hundred = Byte.Hundred;
		#endregion

		#region Enums
		[Flags]
		public enum Enum : ushort
		{
			#if !SHORT_FLAGS
			[Obsolete("To enable Short.Enum add the Scripting Define Symbol 'SHORT_FLAGS' in the Player Settings.")]
			Disabled,
			#endif
			#if SHORT_FLAGS
			/// <summary>
			/// 0
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0000
			/// </remarks>
			Nothing = Flag00 >> Flag00,
			/// <summary>
			/// 1
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0001
			/// </remarks>
			Flag00 = (ushort)One,
			/// <summary>
			/// 2
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0010
			/// </remarks>
			Flag01 = Flag00 << Flag00,
			/// <summary>
			/// 4
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 0100
			/// </remarks>
			Flag02 = Flag01 << Flag00,
			/// <summary>
			/// 8
			/// </summary>
			/// <remarks>
			/// 0000 0000 0000 1000
			/// </remarks>
			Flag03 = Flag02 << Flag00,
			/// <summary>
			/// 16
			/// </summary>
			/// <remarks>
			/// 0000 0000 0001 0000
			/// </remarks>
			Flag04 = Flag03 << Flag00,
			/// <summary>
			/// 32
			/// </summary>
			/// <remarks>
			/// 0000 0000 0010 0000
			/// </remarks>
			Flag05 = Flag04 << Flag00,
			/// <summary>
			/// 64
			/// </summary>
			/// <remarks>
			/// 0000 0000 0100 0000
			/// </remarks>
			Flag06 = Flag05 << Flag00,
			/// <summary>
			/// 128
			/// </summary>
			/// <remarks>
			/// 0000 0000 1000 0000
			/// </remarks>
			Flag07 = Flag06 << Flag00,
			/// <summary>
			/// 256
			/// </summary>
			/// <remarks>
			/// 0000 0001 0000 0000
			/// </remarks>
			Flag08 = Flag07 << Flag00,
			/// <summary>
			/// 512
			/// </summary>
			/// <remarks>
			/// 0000 0010 0000 0000
			/// </remarks>
			Flag09 = Flag08 << Flag00,
			/// <summary>
			/// 1,024
			/// </summary>
			/// <remarks>
			/// 0000 0100 0000 0000
			/// </remarks>
			Flag10 = Flag09 << Flag00,
			/// <summary>
			/// 2,048
			/// </summary>
			/// <remarks>
			/// 0000 1000 0000 0000
			/// </remarks>
			Flag11 = Flag10 << Flag00,
			/// <summary>
			/// 4,096
			/// </summary>
			/// <remarks>
			/// 0001 0000 0000 0000
			/// </remarks>
			Flag12 = Flag11 << Flag00,
			/// <summary>
			/// 8,192
			/// </summary>
			/// <remarks>
			/// 0010 0000 0000 0000
			/// </remarks>
			Flag13 = Flag12 << Flag00,
			/// <summary>
			/// 16,384
			/// </summary>
			/// <remarks>
			/// 0100 0000 0000 0000
			/// </remarks>
			Flag14 = Flag13 << Flag00,
			/// <summary>
			/// 32,768
			/// </summary>
			/// <remarks>
			/// 1000 0000 0000 0000
			/// </remarks>
			Flag15 = Flag14 << Flag00,
			/// <summary>
			/// 65,535
			/// </summary>
			/// <remarks>
			/// 1111 1111 1111 1111
			/// </remarks>
			Everything = unchecked((ushort)~Nothing),
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