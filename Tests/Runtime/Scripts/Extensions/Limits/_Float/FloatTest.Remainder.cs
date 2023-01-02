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
		public void Remainder_Positive()
		{
			// Equal to IntTest but with 0.1f added
			const int range = 5;
			float[] input = (-range + 0.1f).Range(range * 2 + 1).ToArray();
			Debug.Log(input);

			const float modulo = 3f;
			float[] expected = { -1.9f, -0.9f, -2.9f, -1.9f, -0.9f, 0.1f, 1.1f, 2.1f, 0.1f, 1.1f, 2.1f };

			float[] actual = input.Select(value => value.Remainder(modulo)).ToArray();

			AreEqual(expected, actual, Delta);
		}

		[Test]
		public void Remainder_Negative()
		{
			// Equal to IntTest but with 0.1f added
			const int range = 5;
			float[] input = (-range + 0.1f).Range(range * 2 + 1).ToArray();
			Debug.Log(input);

			const float modulo = -3f;
			float[] expected = { -1.9f, -0.9f, -2.9f, -1.9f, -0.9f, 0.1f, 1.1f, 2.1f, 0.1f, 1.1f, 2.1f };

			float[] actual = input.Select(value => value.Remainder(modulo)).ToArray();

			AreEqual(expected, actual, Delta);
		}
	}
}