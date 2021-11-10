namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class FloatTest
	{
		[Test]
		public void Tan_Equals_Expected()
		{
			Assert.AreEqual(5f.Sin() / 5f.Cos(), 5f.Tan(), delta);
		}

		[Test]
		public void Atan_Equals_Expected()
		{
			Assert.AreEqual(5f, 5f.Tan().Atan(), delta);
		}

		[Test]
		public void Atan2_Equals_Expected()
		{
			Assert.AreEqual(0f, 0f.Atan2(10f), delta);
			Assert.AreEqual(90f, 10f.Atan2(0f), delta);
		}
	}
}