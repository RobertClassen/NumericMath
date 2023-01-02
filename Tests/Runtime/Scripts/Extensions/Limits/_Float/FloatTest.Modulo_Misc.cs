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
		public void Modulo_Divisor0_Throws()
		{
			Assert.Throws<DivideByZeroException>(() => 5f.Modulo(0f));
			Assert.Throws<DivideByZeroException>(() => (-5f).Modulo(0f));
		}

		[Test]
		public void Modulo_Misc()
		{
			Assert.AreEqual(7f, (-193f).Modulo(8f));
			Assert.AreEqual(6f, (-194f).Modulo(8f));
		}
	}
}