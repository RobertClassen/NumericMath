namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Linq;
	using NUnit.Framework;

	public partial class FloatTest
	{
		[Test]
		public void Lerp()
		{
			Assert.AreEqual(0f, 0f.Lerp(0f, 10f), delta);
			Assert.AreEqual(5f, 0.5f.Lerp(0f, 10f), delta);
			Assert.AreEqual(10f, 1f.Lerp(0f, 10f), delta);

			Assert.AreEqual(11f, 1.1f.Lerp(0f, 10f), delta);
			Assert.AreEqual(10f, 1.1f.Lerp(0f, 10f, true), delta);
		}
	}
}