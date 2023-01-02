namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class FloatTest
	{
		[Test]
		public void Tan()
		{
			Assert.AreEqual(5f.Sin() / 5f.Cos(), 5f.Tan(), Delta);
		}

		[Test]
		public void Atan()
		{
			Assert.AreEqual(5f, 5f.Tan().Atan(), Delta);
		}

		[Test]
		public void Atan2()
		{
			Assert.AreEqual(0f, 0f.Atan2(10f), Delta);
			Assert.AreEqual(90f, 10f.Atan2(0f), Delta);
		}
	}
}