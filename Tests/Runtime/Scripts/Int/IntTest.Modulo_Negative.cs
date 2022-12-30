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
		public void Modulo_Negative_Offset0()
		{
			int range = 5;
			int[] input = (-range).Range(range * 2 + 1).ToArray();
			Debug.Log(input);

			int modulo = -3;
			int[] expected = { -2, -1, 0, -2, -1, 0, -2, -1, 0, -2, -1 };
			Debug.Log(expected);

			int[] actual = input.Select(value => value.Modulo(modulo)).ToArray();
			Debug.Log(actual);

			Assert.AreEqual(expected, actual);
		}
	}
}