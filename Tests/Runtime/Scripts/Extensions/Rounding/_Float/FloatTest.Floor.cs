namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class FloatTest
	{
		[Test]
		public void Floor_Negative()
		{
			const float value = -1.1f;

			Assert.AreEqual(-2f, value.Floor());
		}

		[Test]
		public void Floor_Positive()
		{
			const float value = 1.1f;

			Assert.AreEqual(1f, value.Floor());
		}
	}
}