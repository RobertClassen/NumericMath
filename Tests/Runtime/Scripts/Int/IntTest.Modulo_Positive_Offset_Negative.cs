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
		public void Modulo_Positive_Offset_Negative0()
		{
			int range = 5;
			int[] input = (-range).Range(range * 2 + 1).ToArray();
			Debug.Log(input);

			int modulo = 3;
			int offset = -0;
			int[] expected = { 1, 2, 0, 1, 2, 0, 1, 2, 0, 1, 2 };
			Debug.Log(expected);

			int[] actual = input.Select(value => value.Modulo(modulo, offset)).ToArray();
			Debug.Log(actual);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void Modulo_Positive_Offset_Negative1()
		{
			int range = 5;
			int[] input = (-range).Range(range * 2 + 1).ToArray();
			Debug.Log(input);

			int modulo = 3;
			int offset = -1;
			int[] expected = { 1, -1, 0, 1, -1, 0, 1, -1, 0, 1, -1 };
			Debug.Log(expected);

			int[] actual = input.Select(value => value.Modulo(modulo, offset)).ToArray();
			Debug.Log(actual);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void Modulo_Positive_Offset_Negative2()
		{
			int range = 5;
			int[] input = (-range).Range(range * 2 + 1).ToArray();
			Debug.Log(input);

			int modulo = 3;
			int offset = -2;
			int[] expected = { -2, -1, 0, -2, -1, 0, -2, -1, 0, -2, -1 };
			Debug.Log(expected);

			int[] actual = input.Select(value => value.Modulo(modulo, offset)).ToArray();
			Debug.Log(actual);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void Modulo_Positive_Offset_Negative3()
		{
			int range = 5;
			int[] input = (-range).Range(range * 2 + 1).ToArray();
			Debug.Log(input);

			int modulo = 3;
			int offset = -3;
			int[] expected = { -2, -1, -3, -2, -1, -3, -2, -1, -3, -2, -1 };
			Debug.Log(expected);

			int[] actual = input.Select(value => value.Modulo(modulo, offset)).ToArray();
			Debug.Log(actual);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void Modulo_Positive_Offset_Negative4()
		{
			int range = 5;
			int[] input = (-range).Range(range * 2 + 1).ToArray();
			Debug.Log(input);

			int modulo = 3;
			int offset = -4;
			int[] expected = { -2, -4, -3, -2, -4, -3, -2, -4, -3, -2, -4 };
			Debug.Log(expected);

			int[] actual = input.Select(value => value.Modulo(modulo, offset)).ToArray();
			Debug.Log(actual);

			Assert.AreEqual(expected, actual);
		}
	}
}