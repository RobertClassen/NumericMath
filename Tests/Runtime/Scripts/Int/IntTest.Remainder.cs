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
			int range = 5;
			int[] input = (-range).Range(range * 2 + 1).ToArray();
			Debug.Log(input);

			int modulo = 3;
			int[] expected = { -2, -1, 0, -2, -1, 0, 1, 2, 0, 1, 2 };
			Debug.Log(expected);

			int[] actual = input.Select(value => value.Remainder(modulo)).ToArray();
			Debug.Log(actual);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void Remainder_Negative()
		{
			int range = 5;
			int[] input = (-range).Range(range * 2 + 1).ToArray();
			Debug.Log(input);

			int modulo = -3;
			int[] expected = { -2, -1, 0, -2, -1, 0, 1, 2, 0, 1, 2 };
			Debug.Log(expected);

			int[] actual = input.Select(value => value.Remainder(modulo)).ToArray();
			Debug.Log(actual);

			Assert.AreEqual(expected, actual);
		}
	}
}