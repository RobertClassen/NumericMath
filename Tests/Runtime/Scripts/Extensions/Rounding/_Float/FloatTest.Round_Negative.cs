namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class FloatTest
	{
		[Test]
		public void Round_NegativeValue_NegativeDigits_Throws()
		{
			const float value = -0.124816f;

			Assert.Throws<ArgumentOutOfRangeException>(() => value.Round(-1));
		}

		[Test]
		public void Round_NegativeValue_PositiveDigits()
		{
			const float value = -0.124816f;

			Assert.AreEqual(-0f, value.Round(0));
			Assert.AreEqual(-0.1f, value.Round(1));
			Assert.AreEqual(-0.12f, value.Round(2));
			Assert.AreEqual(-0.125f, value.Round(3));
			Assert.AreEqual(-0.1248f, value.Round(4));
		}
	}
}