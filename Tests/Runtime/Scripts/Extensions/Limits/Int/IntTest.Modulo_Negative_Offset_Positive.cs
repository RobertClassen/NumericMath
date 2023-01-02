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
		public void Modulo_Negative_PositiveOffset0()
		{
			const int range = 5;
			int[] input = (-range).Range(range * 2 + 1).ToArray();
			Debug.Log(input, "Input");

			const int modulo = -3;
			Debug.Log(modulo, "Modulo");
			const int offset = 0;
			Debug.Log(offset, "Offset");
			int[] expected = { -2, -1, 0, -2, -1, 0, -2, -1, 0, -2, -1 };

			int[] actual = input.Select(value => value.Modulo(modulo, offset)).ToArray();

			AreEqual(expected, actual);
		}

		[Test]
		public void Modulo_Negative_PositiveOffset1()
		{
			const int range = 5;
			int[] input = (-range).Range(range * 2 + 1).ToArray();
			Debug.Log(input, "Input");

			const int modulo = -3;
			Debug.Log(modulo, "Modulo");
			const int offset = 1;
			Debug.Log(offset, "Offset");
			int[] expected = { 1, -1, 0, 1, -1, 0, 1, -1, 0, 1, -1 };

			int[] actual = input.Select(value => value.Modulo(modulo, offset)).ToArray();

			AreEqual(expected, actual);
		}

		[Test]
		public void Modulo_Negative_PositiveOffset2()
		{
			const int range = 5;
			int[] input = (-range).Range(range * 2 + 1).ToArray();
			Debug.Log(input, "Input");

			const int modulo = -3;
			Debug.Log(modulo, "Modulo");
			const int offset = 2;
			Debug.Log(offset, "Offset");
			int[] expected = { 1, 2, 0, 1, 2, 0, 1, 2, 0, 1, 2 };

			int[] actual = input.Select(value => value.Modulo(modulo, offset)).ToArray();

			AreEqual(expected, actual);
		}

		[Test]
		public void Modulo_Negative_PositiveOffset3()
		{
			const int range = 5;
			int[] input = (-range).Range(range * 2 + 1).ToArray();
			Debug.Log(input, "Input");

			const int modulo = -3;
			Debug.Log(modulo, "Modulo");
			const int offset = 3;
			Debug.Log(offset, "Offset");
			int[] expected = { 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2 };

			int[] actual = input.Select(value => value.Modulo(modulo, offset)).ToArray();

			AreEqual(expected, actual);
		}

		[Test]
		public void Modulo_Negative_PositiveOffset4()
		{
			const int range = 5;
			int[] input = (-range).Range(range * 2 + 1).ToArray();
			Debug.Log(input, "Input");

			const int modulo = -3;
			Debug.Log(modulo, "Modulo");
			const int offset = 4;
			Debug.Log(offset, "Offset");
			int[] expected = { 4, 2, 3, 4, 2, 3, 4, 2, 3, 4, 2 };

			int[] actual = input.Select(value => value.Modulo(modulo, offset)).ToArray();

			AreEqual(expected, actual);
		}
	}
}