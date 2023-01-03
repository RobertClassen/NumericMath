namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class FloatTest
	{
		[Test]
		public void Pow_Negative()
		{
			const float exponent = -3f;
			Assert.AreEqual(0.001f, 10f.Pow(exponent), Delta);
		}

		[Test]
		public void Pow_Zero()
		{
			const float exponent = 0f;
			Assert.AreEqual(1f, 10f.Pow(exponent), Delta);
		}

		[Test]
		public void Pow_Positive()
		{
			const float exponent = 3f;
			Assert.AreEqual(1000f, 10f.Pow(exponent), Delta);
		}
	}
}