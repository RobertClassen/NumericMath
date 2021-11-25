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
		public void Range_Is_Correct_Length()
		{
			const int count = 6;

			float[] sequence = 0f.Range(count).ToArray();

			Assert.AreEqual(count, sequence.Length);
		}

		[Test]
		public void Range_Throws_When_Negative_Length()
		{
			const int count = -6;

			Assert.Throws<ArgumentLessThanZeroException>(() => 0f.Range(count).ToArray());
		}
	}
}