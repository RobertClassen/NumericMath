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
		public void Range_IsCorrectLength()
		{
			const int count = 6;

			int[] sequence = 0.Range(count).ToArray();

			Assert.AreEqual(count, sequence.Length);
		}

		[Test]
		public void Range_NegativeCount_Throws()
		{
			const int count = -6;

			Assert.Throws<ArgumentLessThanZeroException>(() => 0.Range(count).ToArray());
		}
	}
}