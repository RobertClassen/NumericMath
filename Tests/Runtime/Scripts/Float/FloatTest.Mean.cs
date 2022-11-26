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
		/// @see https://en.wikipedia.org/wiki/Mean#Arithmetic_mean_(AM)
		/// </remarks>
		[Test]
		public void ArithmeticMean()
		{
			float[] input = { 4f, 36f, 45f, 50f, 75f };

			const float expected = 42f;

			float actual = input.ArithmeticMean();

			Assert.AreEqual(expected, actual);
		}

		/// <remarks>
		/// @see https://en.wikipedia.org/wiki/Mean#Geometric_mean_(GM)
		/// </remarks>
		[Test]
		public void GeometricMean()
		{
			float[] input = { 4f, 36f, 45f, 50f, 75f };

			const float expected = 30f;

			float actual = input.GeometricMean();

			Assert.AreEqual(expected, actual);
		}

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