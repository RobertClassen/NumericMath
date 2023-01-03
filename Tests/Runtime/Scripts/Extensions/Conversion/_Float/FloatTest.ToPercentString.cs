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
		public void ToPercentString_0()
		{
			const float value = 1234.5678f;

			Assert.AreEqual("123,457 %", value.ToPercentString(0));
		}

		[Test]
		public void ToPercentString_0_de_de()
		{
			const float value = 1234.5678f;

			CultureInfo culture = CultureInfo.GetCultureInfo("de-de");
			Assert.AreEqual("123.457 %", value.ToPercentString(0, culture));
		}

		[Test]
		public void ToPercentString_2()
		{
			const float value = 1234.5678f;

			Assert.AreEqual("123,456.80 %", value.ToPercentString());
		}

		[Test]
		public void ToPercentString_2_de_de()
		{
			const float value = 1234.5678f;

			CultureInfo culture = CultureInfo.GetCultureInfo("de-de");
			Assert.AreEqual("123.456,80 %", value.ToPercentString(2, culture));
		}
	}
}