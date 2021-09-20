namespace WellDefinedValues.Tests
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Linq;
	using NUnit.Framework;

	public class IntTest
	{
		#region Fields

		#endregion

		#region Properties

		#endregion

		#region Constructors

		#endregion

		#region Methods
		[Test]
		public void Sequence_Is_Correct_Length()
		{
			const int count = 6;

			int[] sequence = Int.Sequence(0, 1, count).ToArray();

			Assert.AreEqual(count, sequence.Length);
		}

		[Test]
		public void Sequence_Throws_When_Negative_Length()
		{
			const int count = -6;

			Assert.Throws<ArgumentLessThanZeroException>(() => Int.Sequence(0, 1, count).ToArray());
		}

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
		#endregion
	}
}