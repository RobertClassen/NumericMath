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
		public void Sin()
		{
			float angle = 15f;
			float[] input = 0f.Range((int)(Float.FullCircleDegrees / angle) + 1, angle).ToArray();
			float[] expected = {
				0f, 0.258819f, 0.5f, 0.707107f, 0.866025f, 0.965926f,
				1f, 0.965926f, 0.866025f, 0.707107f, 0.5f, 0.258819f,
				0f, -0.258819f, -0.5f, -0.707107f, -0.866025f, -0.965926f,
				-1f, -0.965926f, -0.866025f, -0.707107f, -0.5f, -0.258819f,
				0f,
			};

			float[] actual = input.Select(value => value.Sin()).ToArray();

			AreEqual(expected, actual, Delta);
		}
	}
}