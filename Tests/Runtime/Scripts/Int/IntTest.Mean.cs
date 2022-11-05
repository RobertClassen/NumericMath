namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Linq;
	using NUnit.Framework;

	public partial class IntTest
	{
		/// <remarks>
		/// See https://en.wikipedia.org/wiki/Mean#Arithmetic_mean_(AM)
		/// </remarks>
		[Test]
		public void ArithmeticMean()
		{
			int[] input = { 4, 36, 45, 50, 75 };

			const int expected = 42;

			int actual = input.ArithmeticMean();

			Assert.AreEqual(expected, actual);
		}

		/// <remarks>
		/// See https://en.wikipedia.org/wiki/Mean#Geometric_mean_(GM)
		/// </remarks>
		[Test]
		public void GeometricMean()
		{
			int[] input = { 4, 36, 45, 50, 75 };

			const int expected = 30;

			int actual = input.GeometricMean();

			Assert.AreEqual(expected, actual);
		}

		/// <remarks>
		/// See https://en.wikipedia.org/wiki/Mean#Harmonic_mean_(HM)
		/// </remarks>
		[Test]
		public void HarmonicMean()
		{
			int[] input = { 4, 36, 45, 50, 75 };

			const int expected = 15;

			int actual = input.HarmonicMean();

			Assert.AreEqual(expected, actual);
		}
	}
}