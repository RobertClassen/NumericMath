namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Linq;

	public partial class FloatTest : NumericTest
	{
		private const float delta = 0.0001f;

		private static readonly float[] StepSizes = 10f.Divide(new []{ 2f, 3f, 4f, 5f, 10f }).Reverse().ToArray();
	}
}