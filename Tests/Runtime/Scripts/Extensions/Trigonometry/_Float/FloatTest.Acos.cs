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
		public void Acos_Degrees()
		{
			float angle = 15f;
			float[] input = 0f.Range((int)(Float.FullCircleDegrees / angle) + 1, angle).ToArray();
			float[] expected = {
				0f, 15f, 30f, 45f, 60f, 75f,
				90f, 105f, 120f, 135f, 150f, 165f,
				180f, 165f, 150f, 135f, 120f, 105f,
				90f, 75f, 60f, 45f, 30f, 15f,
				0f,
			};

			float[] actual = input.Select(value => value.Cos().Acos()).ToArray();

			AreEqual(expected, actual, Delta);
		}

		[Test]
		public void Acos_Radians()
		{
			float angle = 15f;
			float[] input = 0f.Range((int)(Float.FullCircleDegrees / angle) + 1, angle)
				.Select(value => value.ToRadians()).ToArray();
			float[] expected = new [] {
				0f, 15f, 30f, 45f, 60f, 75f,
				90f, 105f, 120f, 135f, 150f, 165f,
				180f, 165f, 150f, 135f, 120f, 105f,
				90f, 75f, 60f, 45f, 30f, 15f,
				0f,
			}.Select(value => value.ToRadians()).ToArray();

			float[] actual = input.Select(value => value.Cos(false).Acos(false)).ToArray();

			AreEqual(expected, actual, Delta);
		}
	}
}