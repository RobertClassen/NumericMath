namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Linq;
	using NUnit.Framework;

	public partial class FloatTest
	{
		[Test]
		public void Modulo_Throws_When_Divisor_Is_Zero()
		{
			Assert.Throws<DivideByZeroException>(() => 5f.Modulo(0f));
			Assert.Throws<DivideByZeroException>(() => (-5f).Modulo(0f));
		}

		[Test]
		public void Modulo_Positive()
		{
			// Equal to IntTest but with 0.1f added
			float[] input = { -4.9f, -3.9f, -2.9f, -1.9f, -0.9f, 0.1f, 1.1f, 2.1f, 3.1f, 4.1f, 5.1f };
			float modulo = 3f;
			float[] expected = { 1.1f, 2.1f, 0.1f, 1.1f, 2.1f, 0.1f, 1.1f, 2.1f, 0.1f, 1.1f, 2.1f };

			float[] actual = input.Select(value => value.Modulo(modulo)).ToArray();

			for(int i = 0; i < input.Length; i++)
			{
				Assert.AreEqual(expected[i], actual[i], delta, i + ": " + expected[i] + " != " + actual[i]);
			}
		}

		[Test]
		public void Modulo_Negative()
		{
			// Equal to IntTest but with 0.1f added
			float[] input = { -4.9f, -3.9f, -2.9f, -1.9f, -0.9f, 0.1f, 1.1f, 2.1f, 3.1f, 4.1f, 5.1f };
			float modulo = -3f;
			float[] expected = { -1.9f, -0.9f, -2.9f, -1.9f, -0.9f, -2.9f, -1.9f, -0.9f, -2.9f, -1.9f, -0.9f };

			float[] actual = input.Select(value => value.Modulo(modulo)).ToArray();

			for(int i = 0; i < input.Length; i++)
			{
				Assert.AreEqual(expected[i], actual[i], delta, i + ": " + expected[i] + " != " + actual[i]);
			}
		}

		[Test]
		public void Modulo_Misc()
		{
			Assert.AreEqual(7f, (-193f).Modulo(8f));
			Assert.AreEqual(6f, (-194f).Modulo(8f));
		}
	}
}