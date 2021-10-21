namespace WellDefinedNumerics
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Linq;
	using NUnit.Framework;

	public class FloatTest
	{
		[Test]
		public void Sequence_Is_Correct_Length()
		{
			const int count = 6;

			float[] sequence = 1f.Sequence(count, 0f).ToArray();

			Assert.AreEqual(count, sequence.Length);
		}

		[Test]
		public void Sequence_Throws_When_Negative_Length()
		{
			const int count = -6;

			Assert.Throws<ArgumentLessThanZeroException>(() => 1f.Sequence(count, 0f).ToArray());
		}

		[Test]
		public void Modulo_Throws_When_Divisor_Is_Zero()
		{
			Assert.Throws<DivideByZeroException>(() => 5f.Modulo(0f));
			Assert.Throws<DivideByZeroException>(() => (-5f).Modulo(0f));
		}

		[Test]
		public void Modulo_Positive_Equals_Expected()
		{
			// Equal to IntTest but with 0.1f added
			float[] input = { -4.9f, -3.9f, -2.9f, -1.9f, -0.9f, 0.1f, 1.1f, 2.1f, 3.1f, 4.1f, 5.1f };
			float modulo = 3f;
			float[] expected = { 1.1f, 2.1f, 0.1f, 1.1f, 2.1f, 0.1f, 1.1f, 2.1f, 0.1f, 1.1f, 2.1f };

			float[] actual = input.Select(value => value.Modulo(modulo)).ToArray();

			for(int i = 0; i < input.Length; i++)
			{
				Assert.AreEqual(expected[i], actual[i], 0.00001f, i + ": " + expected[i] + " != " + actual[i]);
			}
		}

		[Test]
		public void Modulo_Negative_Equals_Expected()
		{
			// Equal to IntTest but with 0.1f added
			float[] input = { -4.9f, -3.9f, -2.9f, -1.9f, -0.9f, 0.1f, 1.1f, 2.1f, 3.1f, 4.1f, 5.1f };
			float modulo = -3f;
			float[] expected = { -1.9f, -0.9f, -2.9f, -1.9f, -0.9f, -2.9f, -1.9f, -0.9f, -2.9f, -1.9f, -0.9f };

			float[] actual = input.Select(value => value.Modulo(modulo)).ToArray();

			for(int i = 0; i < input.Length; i++)
			{
				Assert.AreEqual(expected[i], actual[i], 0.00001f, i + ": " + expected[i] + " != " + actual[i]);
			}
		}

		[Test]
		public void Modulo_Misc()
		{
			Assert.AreEqual(7f, (-193f).Modulo(8f));
			Assert.AreEqual(6f, (-194f).Modulo(8f));
		}

		[Test]
		public void Remainder_Positive_Equals_Expected()
		{
			// Equal to IntTest but with 0.1f added
			float[] input = { -4.9f, -3.9f, -2.9f, -1.9f, -0.9f, 0.1f, 1.1f, 2.1f, 3.1f, 4.1f, 5.1f };
			float modulo = 3f;
			float[] expected = { -1.9f, -0.9f, -2.9f, -1.9f, -0.9f, 0.1f, 1.1f, 2.1f, 0.1f, 1.1f, 2.1f };

			#pragma warning disable 618
			float[] actual = input.Select(value => value.Remainder(modulo)).ToArray();
			#pragma warning restore 618

			for(int i = 0; i < input.Length; i++)
			{
				Assert.AreEqual(expected[i], actual[i], 0.00001f, i + ": " + expected[i] + " != " + actual[i]);
			}
		}

		[Test]
		public void Remainder_Negative_Equals_Expected()
		{
			// Equal to IntTest but with 0.1f added
			float[] input = { -4.9f, -3.9f, -2.9f, -1.9f, -0.9f, 0.1f, 1.1f, 2.1f, 3.1f, 4.1f, 5.1f };
			float modulo = -3f;
			float[] expected = { -1.9f, -0.9f, -2.9f, -1.9f, -0.9f, 0.1f, 1.1f, 2.1f, 0.1f, 1.1f, 2.1f };

			#pragma warning disable 618
			float[] actual = input.Select(value => value.Remainder(modulo)).ToArray();
			#pragma warning restore 618

			for(int i = 0; i < input.Length; i++)
			{
				Assert.AreEqual(expected[i], actual[i], 0.00001f, i + ": " + expected[i] + " != " + actual[i]);
			}
		}
	}
}