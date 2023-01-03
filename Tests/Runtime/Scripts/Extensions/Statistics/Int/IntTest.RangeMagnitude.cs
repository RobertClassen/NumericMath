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
		public void RangeMagnitude_IsCommutative_NegativeNegative()
		{
			const int value0 = -5;
			const int value1 = -20;
			
			Assert.AreEqual(value0.RangeMagnitude(value1), value1.RangeMagnitude(value0));
		}

		[Test]
		public void RangeMagnitude_IsCommutative_NegativePositive()
		{
			const int value0 = -5;
			const int value1 = 20;

			Assert.AreEqual(value0.RangeMagnitude(value1), value1.RangeMagnitude(value0));
		}

		[Test]
		public void RangeMagnitude_IsCommutative_PositiveNegative()
		{
			const int value0 = 5;
			const int value1 = -20;

			Assert.AreEqual(value0.RangeMagnitude(value1), value1.RangeMagnitude(value0));
		}

		[Test]
		public void RangeMagnitude_IsCommutative_PositivePositive()
		{
			const int value0 = 5;
			const int value1 = 20;

			Assert.AreEqual(value0.RangeMagnitude(value1), value1.RangeMagnitude(value0));
		}
	}
}