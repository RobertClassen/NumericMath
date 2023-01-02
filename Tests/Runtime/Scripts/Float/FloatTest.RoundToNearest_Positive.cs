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
		public void RoundToNearest_PositiveValue_NegativeStepSize_Throws()
		{
			const float value = 1234.5678f;
			Assert.Throws<ArgumentLessEqualsZeroException>(() => value.RoundToNearest(-1));
		}

		[Test]
		public void RoundToNearest_PositiveValue_ZeroStepSize_Throws()
		{
			const float value = 1234.5678f;
			Assert.Throws<ArgumentLessEqualsZeroException>(() => value.RoundToNearest(0));
		}

		[Test]
		public void RoundToNearest_PositiveValue_PositiveStepSize_Magnitude0_001()
		{
			const float value = 1234.5678f;
			const float scaleFactor = 0.001f;
			Debug.Log(StepSizes.Multiply(scaleFactor));

			throw new NotImplementedException();
			float[] expected = { };
			float[] actual = StepSizes.Multiply(scaleFactor).Select(stepSize => value.RoundToNearest(stepSize)).ToArray();

			AreEqual(expected, actual, Delta);
		}

		[Test]
		public void RoundToNearest_PositiveValue_PositiveStepSize_Magnitude0_01()
		{
			const float value = 1234.5678f;
			const float scaleFactor = 0.01f;
			Debug.Log(StepSizes.Multiply(scaleFactor));

			throw new NotImplementedException();
			float[] expected = { };
			float[] actual = StepSizes.Multiply(scaleFactor).Select(stepSize => value.RoundToNearest(stepSize)).ToArray();

			AreEqual(expected, actual, Delta);
		}

		[Test]
		public void RoundToNearest_PositiveValue_PositiveStepSize_Magnitude0_1()
		{
			const float value = 1234.5678f;
			const float scaleFactor = 0.1f;
			Debug.Log(StepSizes.Multiply(scaleFactor));

			float[] expected = { 1234.6f, 1234.6f, 1234.666f, 1234.5f, 1234.5f };
			float[] actual = StepSizes.Multiply(scaleFactor).Select(stepSize => value.RoundToNearest(stepSize)).ToArray();

			AreEqual(expected, actual, Delta);
		}

		[Test]
		public void RoundToNearest_PositiveValue_PositiveStepSize_Magnitude1()
		{
			const float value = 1234.5678f;
			const float scaleFactor = 1f;
			Debug.Log(StepSizes.Multiply(scaleFactor));

			float[] expected = { 1235, 1234, 1235, 1233, 1235 };
			float[] actual = StepSizes.Multiply(scaleFactor).Select(stepSize => value.RoundToNearest(stepSize)).ToArray();

			AreEqual(expected, actual, Delta);
		}

		[Test]
		public void RoundToNearest_PositiveValue_PositiveStepSize_Magnitude10()
		{
			const float value = 1234.5678f;
			const float scaleFactor = 10f;
			Debug.Log(StepSizes.Multiply(scaleFactor));

			float[] expected = { 1230, 1240, 1225, 1233, 1250 };
			float[] actual = StepSizes.Multiply(scaleFactor).Select(stepSize => value.RoundToNearest(stepSize)).ToArray();

			AreEqual(expected, actual, Delta);
		}

		[Test]
		public void RoundToNearest_PositiveValue_PositiveStepSize_Magnitude100()
		{
			const float value = 1234.5678f;
			const float scaleFactor = 100f;
			Debug.Log(StepSizes.Multiply(scaleFactor));

			float[] expected = { 1200, 1200, 1250, 1333, 1000 };
			float[] actual = StepSizes.Multiply(scaleFactor).Select(stepSize => value.RoundToNearest(stepSize)).ToArray();

			AreEqual(expected, actual, Delta);
		}

		[Test]
		public void RoundToNearest_PositiveValue_PositiveStepSize_Magnitude1000()
		{
			const float value = 1234.5678f;
			const float scaleFactor = 1000f;
			Debug.Log(StepSizes.Multiply(scaleFactor));

			float[] expected = { 1000, 2000, 0, 0, 0 };
			float[] actual = StepSizes.Multiply(scaleFactor).Select(stepSize => value.RoundToNearest(stepSize)).ToArray();

			AreEqual(expected, actual, Delta);
		}
	}
}