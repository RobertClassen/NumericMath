namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class FloatTest
	{
		[Test]
		public void Atan2()
		{
			Assert.AreEqual(0f, 0f.Atan2(10f), Delta);
			Assert.AreEqual(90f, 10f.Atan2(0f), Delta);
		}
	}
}