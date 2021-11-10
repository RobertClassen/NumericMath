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
		public void Lerp_Equals_Expected()
		{
			Assert.AreEqual(0f, 0f.Lerp(10f, 0f), delta);
			Assert.AreEqual(5f, 0f.Lerp(10f, 0.5f), delta);
			Assert.AreEqual(10f, 0f.Lerp(10f, 1f), delta);

			Assert.AreEqual(11f, 0f.Lerp(10f, 1.1f), delta);
			Assert.AreEqual(10f, 0f.Lerp(10f, 1.1f, true), delta);
		}
	}
}