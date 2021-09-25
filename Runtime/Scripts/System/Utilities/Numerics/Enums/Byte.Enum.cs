namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class Byte
	{
		[Flags]
		public enum Enum : byte
		{
			#if !BYTE_FLAGS
			[Obsolete("To enable Byte.Enum add the Scripting Define Symbol 'BYTE_FLAGS' in the Player Settings.")]
			Disabled,
			#endif
			#if BYTE_FLAGS
			/// <summary>
			/// 0
			/// </summary>
			/// <remarks>
			/// 0000 0000
			/// </remarks>
			Nothing = Flag00 >> Flag00,
			/// <summary>
			/// 1
			/// </summary>
			/// <remarks>
			/// 0000 0001
			/// </remarks>
			Flag00 = One,
			/// <summary>
			/// 2
			/// </summary>
			/// <remarks>
			/// 0000 0010
			/// </remarks>
			Flag01 = Flag00 << Flag00,
			/// <summary>
			/// 4
			/// </summary>
			/// <remarks>
			/// 0000 0100
			/// </remarks>
			Flag02 = Flag01 << Flag00,
			/// <summary>
			/// 8
			/// </summary>
			/// <remarks>
			/// 0000 1000
			/// </remarks>
			Flag03 = Flag02 << Flag00,
			/// <summary>
			/// 16
			/// </summary>
			/// <remarks>
			/// 0001 0000
			/// </remarks>
			Flag04 = Flag03 << Flag00,
			/// <summary>
			/// 32
			/// </summary>
			/// <remarks>
			/// 0010 0000
			/// </remarks>
			Flag05 = Flag04 << Flag00,
			/// <summary>
			/// 64
			/// </summary>
			/// <remarks>
			/// 0100 0000
			/// </remarks>
			Flag06 = Flag05 << Flag00,
			/// <summary>
			/// 128
			/// </summary>
			/// <remarks>
			/// 1000 0000
			/// </remarks>
			Flag07 = Flag06 << Flag00,
			/// <summary>
			/// 255
			/// </summary>
			/// <remarks>
			/// 1111 1111
			/// </remarks>
			Everything = unchecked((byte)~Nothing),
			#endif
		}
	}
}