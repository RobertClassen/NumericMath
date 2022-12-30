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
		public void Modulo_Throws_When_Divisor_Is_Zero()
		{
			Assert.Throws<DivideByZeroException>(() => 5.Modulo(0));
			Assert.Throws<DivideByZeroException>(() => (-5).Modulo(0));
		}

		[Test]
		public void Modulo_Positive_Offset0()
		{
			int range = 5;
			int[] input = (-range).Range(range * 2 + 1).ToArray();
			Debug.Log(input);

			int modulo = 3;
			int[] expected = { 1, 2, 0, 1, 2, 0, 1, 2, 0, 1, 2 };
			Debug.Log(expected);

			int[] actual = input.Select(value => value.Modulo(modulo)).ToArray();
			Debug.Log(actual);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void Modulo_Positive_Offset1()
		{
			int range = 5;
			int[] input = (-range).Range(range * 2 + 1).ToArray();
			Debug.Log(input);

			int modulo = 3;
			int offset = 1;
			int[] expected = { 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2 };
			Debug.Log(expected);

			int[] actual = input.Select(value => value.Modulo(modulo, offset)).ToArray();
			Debug.Log(actual);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void Modulo_Positive_Offset2()
		{
			int range = 5;
			int[] input = (-range).Range(range * 2 + 1).ToArray();
			Debug.Log(input);

			int modulo = 3;
			int offset = 2;
			int[] expected = { 4, 2, 3, 4, 2, 3, 4, 2, 3, 4, 2 };
			Debug.Log(expected);

			int[] actual = input.Select(value => value.Modulo(modulo, offset)).ToArray();
			Debug.Log(actual);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void Modulo_Positive_Offset3()
		{
			int range = 5;
			int[] input = (-range).Range(range * 2 + 1).ToArray();
			Debug.Log(input);

			int modulo = 3;
			int offset = 3;
			int[] expected = { 4, 5, 3, 4, 5, 3, 4, 5, 3, 4, 5 };
			Debug.Log(expected);

			int[] actual = input.Select(value => value.Modulo(modulo, offset)).ToArray();
			Debug.Log(actual);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void Modulo_Positive_Offset4()
		{
			int range = 5;
			int[] input = (-range).Range(range * 2 + 1).ToArray();
			Debug.Log(input);

			int modulo = 3;
			int offset = 4;
			int[] expected = { 4, 5, 6, 4, 5, 6, 4, 5, 6, 4, 5 };
			Debug.Log(expected);

			int[] actual = input.Select(value => value.Modulo(modulo, offset)).ToArray();
			Debug.Log(actual);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void Modulo_Negative()
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

		[Test]
		public void Modulo_Misc()
		{
			Assert.AreEqual(7, (-193).Modulo(8));
			Assert.AreEqual(6, (-194).Modulo(8));

			Assert.AreEqual(1, (13).Modulo(12, 1));
			Assert.AreEqual(2, (14).Modulo(12, 1));
			Assert.AreEqual(1, (25).Modulo(12, 1));
			Assert.AreEqual(2, (26).Modulo(12, 1));
		}
	}
}