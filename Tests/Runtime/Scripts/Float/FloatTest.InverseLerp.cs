namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class FloatTest
	{
		[Test]
		public void InverseLerp()
		{
			Assert.AreEqual(0f, 0f.InverseLerp(0f, 10f), Delta);
			Assert.AreEqual(0.5f, 5f.InverseLerp(0f, 10f), Delta);
			Assert.AreEqual(1f, 10f.InverseLerp(0f, 10f), Delta);

			Assert.AreEqual(1.1f, 11f.InverseLerp(0f, 10f), Delta);
			Assert.AreEqual(1f, 11f.InverseLerp(0f, 10f, true), Delta);
		}
	}
}