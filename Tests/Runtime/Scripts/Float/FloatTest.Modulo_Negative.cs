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
		public void Modulo_Negative()
		{
			// Equal to IntTest but with 0.1f added
			int range = 5;
			float[] input = (-range + 0.1f).Range(range * 2 + 1).ToArray();
			Debug.Log(input);

			float modulo = -3f;
			float[] expected = { -1.9f, -0.9f, -2.9f, -1.9f, -0.9f, -2.9f, -1.9f, -0.9f, -2.9f, -1.9f, -0.9f };
			Debug.Log(expected);

			float[] actual = input.Select(value => value.Modulo(modulo)).ToArray();
			Debug.Log(actual);

			for(int i = 0; i < input.Length; i++)
			{
				Assert.AreEqual(expected[i], actual[i], delta, i + ": " + expected[i] + " != " + actual[i]);
			}
		}
	}
}