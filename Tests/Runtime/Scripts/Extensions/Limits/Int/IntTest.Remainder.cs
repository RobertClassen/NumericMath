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
			const int range = 5;
			int[] input = (-range).Range(range * 2 + 1).ToArray();
			Debug.Log(input);

			const int modulo = 3;
			int[] expected = { -2, -1, 0, -2, -1, 0, 1, 2, 0, 1, 2 };

			int[] actual = input.Select(value => value.Remainder(modulo)).ToArray();

			AreEqual(expected, actual);
		}

		[Test]
		public void Remainder_Negative()
		{
			const int range = 5;
			int[] input = (-range).Range(range * 2 + 1).ToArray();
			Debug.Log(input);

			const int modulo = -3;
			int[] expected = { -2, -1, 0, -2, -1, 0, 1, 2, 0, 1, 2 };

			int[] actual = input.Select(value => value.Remainder(modulo)).ToArray();

			AreEqual(expected, actual);
		}
	}
}