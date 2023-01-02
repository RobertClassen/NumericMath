namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class IntTest
	{
		[Test]
		public void IsEven()
		{
			Assert.IsTrue((-4).IsEven());
			Assert.IsTrue((-2).IsEven());
			Assert.IsTrue(0.IsEven());
			Assert.IsTrue(2.IsEven());
			Assert.IsTrue(4.IsEven());
		}

		[Test]
		public void IsOdd()
		{
			Assert.IsTrue((-3).IsOdd());
			Assert.IsTrue((-1).IsOdd());
			Assert.IsTrue(1.IsOdd());
			Assert.IsTrue(3.IsOdd());
		}
	}
}