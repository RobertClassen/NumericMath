namespace WellDefinedNumerics
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Linq;
	using NUnit.Framework;

	public class IntTest
	{
		[Test]
		public void Sequence_Is_Correct_Length()
		{
			const int count = 6;

			int[] sequence = 1.Sequence(count, 0).ToArray();

			Assert.AreEqual(count, sequence.Length);
		}

		[Test]
		public void Sequence_Throws_When_Negative_Length()
		{
			const int count = -6;

			Assert.Throws<ArgumentLessThanZeroException>(() => 1.Sequence(count).ToArray());
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

		[Test]
		public void Remainder_Positive_Equals_Expected()
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
		public void Remainder_Negative_Equals_Expected()
		{
			int[] input = { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 };
			int modulo = -3;
			int[] expected = { -2, -1, 0, -2, -1, 0, 1, 2, 0, 1, 2 };

			#pragma warning disable 618
			int[] actual = input.Select(value => value.Remainder(modulo)).ToArray();
			#pragma warning restore 618

			Assert.AreEqual(expected, actual, string.Join(" ", expected) + "\n" + string.Join(" ", actual));
		}

		[Test]
		public void Numbers_Are_Even()
		{
			Assert.IsTrue((-4).IsEven());
			Assert.IsTrue((-2).IsEven());
			Assert.IsTrue(0.IsEven());
			Assert.IsTrue(2.IsEven());
			Assert.IsTrue(4.IsEven());
		}

		[Test]
		public void Numbers_Are_Odd()
		{
			Assert.IsTrue((-3).IsOdd());
			Assert.IsTrue((-1).IsOdd());
			Assert.IsTrue(1.IsOdd());
			Assert.IsTrue(3.IsOdd());
		}
	}
}