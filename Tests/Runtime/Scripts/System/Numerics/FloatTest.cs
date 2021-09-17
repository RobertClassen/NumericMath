namespace System.Tests
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Extensions;
	using System.Linq;
	using System.Utilities;
	using NUnit.Framework;

	public class FloatTest
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

			float[] sequence = Float.Sequence(0f, 1f, count).ToArray();

			Assert.AreEqual(count, sequence.Length);
		}

		[Test]
		public void Sequence_Throws_When_Negative_Length()
		{
			const int count = -6;

			Assert.Throws<ArgumentLessThanZeroException>(() => Float.Sequence(0f, 1f, count).ToArray());
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
			float[] input = { -5.9f, -4.9f, -3.9f, -2.9f, -1.9f, -0.9f, 0.1f, 1.1f, 2.1f, 3.1f, 4.1f };
			float modulo = 3f;
			float[] expected = { 0.1f, 1.1f, 2.1f, 0.1f, 1.1f, 2.1f, 0.1f, 1.1f, 2.1f, 0.1f, 1.1f };

			float[] actual = input.Select(value => value.Modulo(modulo)).ToArray();

			for(int i = 0; i < input.Length; i++)
			{
				Assert.AreEqual(expected[i], actual[i], 0.00001f, i + ": " + expected[i] + " != " + actual[i]);
			}
		}

		[Test]
		public void Modulo_Negative_Equals_Expected()
		{
			float[] input = { -5.9f, -4.9f, -3.9f, -2.9f, -1.9f, -0.9f, 0.1f, 1.1f, 2.1f, 3.1f, 4.1f };
			float modulo = -3f;
			float[] expected = { -2.9f, -1.9f, -0.9f, -2.9f, -1.9f, -0.9f, -2.9f, -1.9f, -0.9f, -2.9f, -1.9f };

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
		#endregion
	}
}