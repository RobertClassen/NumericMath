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
		public void Modulo_Negative_Offset_Positive0()
		{
			int range = 5;
			int[] input = (-range).Range(range * 2 + 1).ToArray();
			Debug.Log(input);

			int modulo = -3;
			int offset = 0;
			int[] expected = { -2, -1, 0, -2, -1, 0, -2, -1, 0, -2, -1 };

			int[] actual = input.Select(value => value.Modulo(modulo, offset)).ToArray();

			AreEqual(expected, actual);
		}

		[Test]
		public void Modulo_Negative_Offset_Positive1()
		{
			int range = 5;
			int[] input = (-range).Range(range * 2 + 1).ToArray();
			Debug.Log(input);

			int modulo = -3;
			int offset = 1;
			int[] expected = { 1, -1, 0, 1, -1, 0, 1, -1, 0, 1, -1 };

			int[] actual = input.Select(value => value.Modulo(modulo, offset)).ToArray();

			AreEqual(expected, actual);
		}

		[Test]
		public void Modulo_Negative_Offset_Positive2()
		{
			int range = 5;
			int[] input = (-range).Range(range * 2 + 1).ToArray();
			Debug.Log(input);

			int modulo = -3;
			int offset = 2;
			int[] expected = { 1, 2, 0, 1, 2, 0, 1, 2, 0, 1, 2 };

			int[] actual = input.Select(value => value.Modulo(modulo, offset)).ToArray();

			AreEqual(expected, actual);
		}

		[Test]
		public void Modulo_Negative_Offset_Positive3()
		{
			int range = 5;
			int[] input = (-range).Range(range * 2 + 1).ToArray();
			Debug.Log(input);

			int modulo = -3;
			int offset = 3;
			int[] expected = { 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2 };

			int[] actual = input.Select(value => value.Modulo(modulo, offset)).ToArray();

			AreEqual(expected, actual);
		}

		[Test]
		public void Modulo_Negative_Offset_Positive4()
		{
			int range = 5;
			int[] input = (-range).Range(range * 2 + 1).ToArray();
			Debug.Log(input);

			int modulo = -3;
			int offset = 4;
			int[] expected = { 4, 2, 3, 4, 2, 3, 4, 2, 3, 4, 2 };

			int[] actual = input.Select(value => value.Modulo(modulo, offset)).ToArray();

			AreEqual(expected, actual);
		}
	}
}