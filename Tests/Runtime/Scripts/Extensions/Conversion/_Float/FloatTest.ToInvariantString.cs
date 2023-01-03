namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Globalization;
	using NUnit.Framework;

	public partial class FloatTest
	{
		[Test]
		public void ToInvariantString()
		{
			const float value = 1234.5678f;

			Assert.AreEqual("1234.568", value.ToInvariantString());
		}

		[Test]
		public void ToInvariantString_N2()
		{
			const float value = 1234.5678f;

			Assert.AreEqual("1,234.57", value.ToInvariantString("N2"));
		}
	}
}