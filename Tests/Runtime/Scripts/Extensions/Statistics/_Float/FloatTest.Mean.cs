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
		public void Mean_Arithmetic()
		{
			float[] input = { 4f, 36f, 45f, 50f, 75f };

			const float expected = 42f;

			float actual = input.Mean(Mean.Arithmetic);

			Assert.AreEqual(expected, actual);
		}

		/// <remarks>
		/// @see https://en.wikipedia.org/wiki/Mean#Geometric_mean_(GM)
		/// </remarks>
		[Test]
		public void Mean_Geometric()
		{
			float[] input = { 4f, 36f, 45f, 50f, 75f };

			const float expected = 30f;

			float actual = input.Mean(Mean.Geometric);

			Assert.AreEqual(expected, actual);
		}

		/// <remarks>
		/// @see https://en.wikipedia.org/wiki/Mean#Harmonic_mean_(HM)
		/// </remarks>
		[Test]
		public void Mean_Harmonic()
		{
			float[] input = { 4f, 36f, 45f, 50f, 75f };

			const float expected = 15f;

			float actual = input.Mean(Mean.Harmonic);

			Assert.AreEqual(expected, actual);
		}
	}
}