namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Linq;
	using NUnit.Framework;

	public partial class IntTest
	{
		[Test]
		public void Remainder_Positive()
		{
			int[] input = { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 };
			int modulo = 3;
			int[] expected = { -2, -1, 0, -2, -1, 0, 1, 2, 0, 1, 2 };

			#pragma warning disable 618
			int[] actual = input.Select(value => value.Remainder(modulo)).ToArray();
			#pragma warning restore 618

			Assert.AreEqual(expected, actual, string.Join(" ", expected) + "\n" + string.Join(" ", actual));
		}

		[Test]
		public void Remainder_Negative()
		{
			int[] input = { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 };
			int modulo = -3;
			int[] expected = { -2, -1, 0, -2, -1, 0, 1, 2, 0, 1, 2 };

			#pragma warning disable 618
			int[] actual = input.Select(value => value.Remainder(modulo)).ToArray();
			#pragma warning restore 618

			Assert.AreEqual(expected, actual, string.Join(" ", expected) + "\n" + string.Join(" ", actual));
		}
	}
}