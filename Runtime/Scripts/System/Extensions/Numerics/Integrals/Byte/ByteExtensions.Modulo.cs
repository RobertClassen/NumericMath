namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ByteExtensions
	{
		public static byte Modulo(this byte dividend, byte divisor)
		{
			if(divisor == Int.Zero)
			{
				throw new DivideByZeroException(nameof(Modulo) + "(0) is undefined.");
			}

			// Puts the dividend in the [-divisor+1, divisor-1] range
			byte remainder = (byte)(dividend % divisor);

			// If the remainder is less than zero and the divisor is greater than zero, 
			// then adding the divisor puts it in the [0, divisor-1] range.
			// If the divisor is less than zero and the remainder is greater than zero, 
			// then adding the divisor puts it in the [divisor-1, 0] range.
			return (byte)(Byte.Zero.IsClamped(remainder, divisor, false) || Byte.Zero.IsClamped(divisor, remainder, false) ? 
				remainder + divisor : remainder);
		}
	}
}