namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Linq;
	using NUnit.Framework;

	public partial class IntTest
	{
		[Test]
		public void Modulo_Divisor0_Throws()
		{
			Assert.Throws<DivideByZeroException>(() => 5.Modulo(0));
			Assert.Throws<DivideByZeroException>(() => (-5).Modulo(0));
		}

		[Test]
		public void Modulo_Misc()
		{
			Assert.AreEqual(7, (-193).Modulo(8));
			Assert.AreEqual(6, (-194).Modulo(8));

			Assert.AreEqual(1, (13).Modulo(12, 1));
			Assert.AreEqual(2, (14).Modulo(12, 1));
			Assert.AreEqual(1, (25).Modulo(12, 1));
			Assert.AreEqual(2, (26).Modulo(12, 1));
		}
	}
}