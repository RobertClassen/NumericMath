namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class FloatTest
	{
		private const float delta = 0.00001f;

		private void AreEqual(float[] expected, float[] actual)
		{
			for(int i = 0; i < expected.Length; i++)
			{
				Assert.AreEqual(expected[i], actual[i], delta, "Values differ at index [" + i + "]");
			}
		}
	}
}