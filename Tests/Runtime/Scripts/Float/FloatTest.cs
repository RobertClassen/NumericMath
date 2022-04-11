namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class FloatTest
	{
		private const float delta = 0.0001f;

		private void AreEqual(IList<float> expected, IList<float> actual)
		{
			Assert.AreEqual(expected.Count, actual.Count);
			for(int i = 0; i < expected.Count; i++)
			{
				Assert.AreEqual(expected[i], actual[i], delta, "Values differ at index [" + i + "]");
			}
		}
	}
}