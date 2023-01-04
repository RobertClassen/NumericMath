namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NUnit.Framework;

	public partial class FloatTest
	{
		[Test]
		public void Atan()
		{
			Assert.AreEqual(5f, 5f.Tan().Atan(), Delta);
		}
	}
}