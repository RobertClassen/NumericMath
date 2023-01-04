namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Linq;
	using NUnit.Framework;

	public partial class FloatTest
	{
		/// <remarks>
		/// @see https://en.wikipedia.org/wiki/Mean#Harmonic_mean_(HM)
		/// </remarks>
		[Test]
		public void HarmonicMean()
		{
			float[] input = { 4f, 36f, 45f, 50f, 75f };

			const float expected = 15f;

			float actual = input.HarmonicMean();

			Assert.AreEqual(expected, actual);
		}
	}
}