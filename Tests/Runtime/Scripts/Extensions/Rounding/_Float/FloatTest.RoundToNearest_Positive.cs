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
			const float value = 1.2345678f;
			Debug.Log(value, "Value");
			const float scaleFactor = 0.001f;
			Debug.Log(StepSizes.Multiply(scaleFactor), "Nearest");

			float[] expected = { 1.235f, 1.234f, 1.235f, 1.2333333f, 1.235f };
			float[] actual = StepSizes.Multiply(scaleFactor).Select(stepSize => value.RoundToNearest(stepSize)).ToArray();

			AreEqual(expected, actual, scaleFactor * Delta);
		}

		[Test]
		public void RoundToNearest_PositiveValue_PositiveStepSize_Magnitude0_01()
		{
			const float value = 12.345678f;
			Debug.Log(value, "Value");
			const float scaleFactor = 0.01f;
			Debug.Log(StepSizes.Multiply(scaleFactor), "Nearest");

			float[] expected = { 12.35f, 12.34f, 12.35f, 12.333333f, 12.35f };
			float[] actual = StepSizes.Multiply(scaleFactor).Select(stepSize => value.RoundToNearest(stepSize)).ToArray();

			AreEqual(expected, actual, scaleFactor * Delta);
		}

		[Test]
		public void RoundToNearest_PositiveValue_PositiveStepSize_Magnitude0_1()
		{
			const float value = 123.45678f;
			Debug.Log(value, "Value");
			const float scaleFactor = 0.1f;
			Debug.Log(StepSizes.Multiply(scaleFactor), "Nearest");

			float[] expected = { 123.5f, 123.4f, 123.5f, 123.33333f, 123.5f };
			float[] actual = StepSizes.Multiply(scaleFactor).Select(stepSize => value.RoundToNearest(stepSize)).ToArray();

			AreEqual(expected, actual, scaleFactor * Delta);
		}

		[Test]
		public void RoundToNearest_PositiveValue_PositiveStepSize_Magnitude1()
		{
			const float value = 1234.5678f;
			Debug.Log(value, "Value");
			const float scaleFactor = 1f;
			Debug.Log(StepSizes.Multiply(scaleFactor), "Nearest");

			float[] expected = { 1235f, 1234f, 1235f, 1233.3333f, 1235f };
			float[] actual = StepSizes.Multiply(scaleFactor).Select(stepSize => value.RoundToNearest(stepSize)).ToArray();

			AreEqual(expected, actual, scaleFactor * Delta);
		}

		[Test]
		public void RoundToNearest_PositiveValue_PositiveStepSize_Magnitude10()
		{
			const float value = 12345.678f;
			Debug.Log(value, "Value");
			const float scaleFactor = 10f;
			Debug.Log(StepSizes.Multiply(scaleFactor), "Nearest");

			float[] expected = { 12350f, 12340f, 12350f, 12333.333f, 12350f };
			float[] actual = StepSizes.Multiply(scaleFactor).Select(stepSize => value.RoundToNearest(stepSize)).ToArray();

			AreEqual(expected, actual, scaleFactor * Delta);
		}

		[Test]
		public void RoundToNearest_PositiveValue_PositiveStepSize_Magnitude100()
		{
			const float value = 123456.78f;
			Debug.Log(value, "Value");
			const float scaleFactor = 100f;
			Debug.Log(StepSizes.Multiply(scaleFactor), "Nearest");

			float[] expected = { 123500f, 123400f, 123500f, 123333.33f, 123500f };
			float[] actual = StepSizes.Multiply(scaleFactor).Select(stepSize => value.RoundToNearest(stepSize)).ToArray();

			AreEqual(expected, actual, scaleFactor * Delta);
		}

		[Test]
		public void RoundToNearest_PositiveValue_PositiveStepSize_Magnitude1000()
		{
			const float value = 1234567.8f;
			Debug.Log(value, "Value");
			const float scaleFactor = 1000f;
			Debug.Log(StepSizes.Multiply(scaleFactor), "Nearest");

			float[] expected = { 1235000f, 1234000f, 1235000f, 1233333.3f, 1235000f };
			float[] actual = StepSizes.Multiply(scaleFactor).Select(stepSize => value.RoundToNearest(stepSize)).ToArray();

			AreEqual(expected, actual, scaleFactor * Delta);
		}
	}
}