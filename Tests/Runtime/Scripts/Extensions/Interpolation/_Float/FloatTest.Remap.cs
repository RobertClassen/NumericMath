namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class FloatTest
	{
		[Test]
		public void Remap()
		{
			Assert.AreEqual(75f, 5f.Remap(0f, 10f, 50f, 100f), Delta);
			Assert.AreEqual(-15f, 5f.Remap(-20f, 10f, 10f, -20f), Delta);
		}
	}
}