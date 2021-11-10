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
		public void Modulo_Throws_When_Divisor_Is_Zero()
		{
			Assert.Throws<DivideByZeroException>(() => 5.Modulo(0));
			Assert.Throws<DivideByZeroException>(() => (-5).Modulo(0));
		}

		[Test]
		public void Modulo_Positive_Equals_Expected()
		{
			int[] input = { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 };
			int modulo = 3;
			int[] expected = { 1, 2, 0, 1, 2, 0, 1, 2, 0, 1, 2 };

			int[] actual = input.Select(value => value.Modulo(modulo)).ToArray();

			Assert.AreEqual(expected, actual, string.Join(" ", expected) + "\n" + string.Join(" ", actual));
		}

		[Test]
		public void Modulo_Negative_Equals_Expected()
		{
			int[] input = { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 };
			int modulo = -3;
			int[] expected = { -2, -1, 0, -2, -1, 0, -2, -1, 0, -2, -1 };

			int[] actual = input.Select(value => value.Modulo(modulo)).ToArray();

			Assert.AreEqual(expected, actual, string.Join(" ", expected) + "\n" + string.Join(" ", actual));
		}

		[Test]
		public void Modulo_Misc()
		{
			Assert.AreEqual(7, (-193).Modulo(8));
			Assert.AreEqual(6, (-194).Modulo(8));
		}
	}
}