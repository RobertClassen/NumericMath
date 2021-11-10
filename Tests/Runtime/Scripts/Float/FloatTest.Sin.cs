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
		public void Sin_Equals_Expected()
		{
			float angle = 15f;
			float[] input = angle.Sequence((int)(Float.FullCircleDegrees / angle) + 1).ToArray();
			float[] expected = {
				0f, 0.258819f, 0.5f, 0.707107f, 0.866025f, 0.965926f,
				1f, 0.965926f, 0.866025f, 0.707107f, 0.5f, 0.258819f,
				0f, -0.258819f, -0.5f, -0.707107f, -0.866025f, -0.965926f,
				-1f, -0.965926f, -0.866025f, -0.707107f, -0.5f, -0.258819f,
				0f,
			};

			float[] actual = input.Select(value => value.Sin()).ToArray();

			AreEqual(expected, actual);
		}

		[Test]
		public void Asin_Degrees_Equals_Expected()
		{
			float angle = 15f;
			float[] input = angle.Sequence((int)(Float.FullCircleDegrees / angle) + 1).ToArray();
			float[] expected = {
				0f, 15f, 30f, 45f, 60f, 75f,
				90f, 75f, 60f, 45f, 30f, 15f,
				0f, -15f, -30f, -45f, -60f, -75f,
				-90f, -75f, -60f, -45f, -30f, -15f,
				0f,
			};

			float[] actual = input.Select(value => value.Sin().Asin()).ToArray();

			AreEqual(expected, actual);
		}

		[Test]
		public void Asin_Radians_Equals_Expected()
		{
			float angle = 15f;
			float[] input = angle.Sequence((int)(Float.FullCircleDegrees / angle) + 1)
				.Select(value => value.ToRadians()).ToArray();
			float[] expected = new [] {
				0f, 15f, 30f, 45f, 60f, 75f,
				90f, 75f, 60f, 45f, 30f, 15f,
				0f, -15f, -30f, -45f, -60f, -75f,
				-90f, -75f, -60f, -45f, -30f, -15f,
				0f,
			}.Select(value => value.ToRadians()).ToArray();

			float[] actual = input.Select(value => value.Sin(false).Asin(false)).ToArray();

			AreEqual(expected, actual);
		}
	}
}