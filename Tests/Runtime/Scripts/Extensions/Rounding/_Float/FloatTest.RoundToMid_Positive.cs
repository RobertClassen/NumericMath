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
		public void RoundToMid_PositiveValue_NegativeStepSize_Throws()
		{
			const float value = 1234.5678f;
			Assert.Throws<ArgumentLessEqualsZeroException>(() => value.RoundToMid(-1));
		}

		[Test]
		public void RoundToMid_PositiveValue_ZeroStepSize_Throws()
		{
			const float value = 1234.5678f;
			Assert.Throws<ArgumentLessEqualsZeroException>(() => value.RoundToMid(0));
		}

		[Test]
		public void RoundToMid_PositiveValue_PositiveStepSize_Magnitude0_001()
		{
			const float value = 1.2345678f;
			Debug.Log(value, "Value");
			const float scaleFactor = 0.001f;
			Debug.Log(StepSizes.Multiply(scaleFactor), "Mid");

			float[] expected = { 1.2345f, 1.235f, 1.23375f, 1.235f, 1.2325f };
			float[] actual = StepSizes.Multiply(scaleFactor).Select(stepSize => value.RoundToMid(stepSize)).ToArray();

			AreEqual(expected, actual, scaleFactor * Delta);
		}

		[Test]
		public void RoundToMid_PositiveValue_PositiveStepSize_Magnitude0_01()
		{
			const float value = 12.345678f;
			Debug.Log(value, "Value");
			const float scaleFactor = 0.01f;
			Debug.Log(StepSizes.Multiply(scaleFactor), "Mid");

			float[] expected = { 12.345f, 12.35f, 12.3375f, 12.35f, 12.325f };
			float[] actual = StepSizes.Multiply(scaleFactor).Select(stepSize => value.RoundToMid(stepSize)).ToArray();

			AreEqual(expected, actual, scaleFactor * Delta);
		}

		[Test]
		public void RoundToMid_PositiveValue_PositiveStepSize_Magnitude0_1()
		{
			const float value = 123.45678f;
			Debug.Log(value, "Value");
			const float scaleFactor = 0.1f;
			Debug.Log(StepSizes.Multiply(scaleFactor), "Mid");

			float[] expected = { 123.45f, 123.5f, 123.375f, 123.5f, 123.25f };
			float[] actual = StepSizes.Multiply(scaleFactor).Select(stepSize => value.RoundToMid(stepSize)).ToArray();

			AreEqual(expected, actual, scaleFactor * Delta);
		}

		[Test]
		public void RoundToMid_PositiveValue_PositiveStepSize_Magnitude1()
		{
			const float value = 1234.5678f;
			Debug.Log(value, "Value");
			const float scaleFactor = 1f;
			Debug.Log(StepSizes.Multiply(scaleFactor), "Mid");

			float[] expected = { 1234.5f, 1235f, 1233.75f, 1235f, 1232.5f };
			float[] actual = StepSizes.Multiply(scaleFactor).Select(stepSize => value.RoundToMid(stepSize)).ToArray();

			AreEqual(expected, actual, scaleFactor * Delta);
		}

		[Test]
		public void RoundToMid_PositiveValue_PositiveStepSize_Magnitude10()
		{
			const float value = 12345.678f;
			Debug.Log(value, "Value");
			const float scaleFactor = 10f;
			Debug.Log(StepSizes.Multiply(scaleFactor), "Mid");

			float[] expected = { 12345f, 12350f, 12337.5f, 12350f, 12325f };
			float[] actual = StepSizes.Multiply(scaleFactor).Select(stepSize => value.RoundToMid(stepSize)).ToArray();

			AreEqual(expected, actual, scaleFactor * Delta);
		}

		[Test]
		public void RoundToMid_PositiveValue_PositiveStepSize_Magnitude100()
		{
			const float value = 123456.78f;
			Debug.Log(value, "Value");
			const float scaleFactor = 100f;
			Debug.Log(StepSizes.Multiply(scaleFactor), "Mid");

			float[] expected = { 123450f, 123500f, 123375f, 123500f, 123250f };
			float[] actual = StepSizes.Multiply(scaleFactor).Select(stepSize => value.RoundToMid(stepSize)).ToArray();

			AreEqual(expected, actual, scaleFactor * Delta);
		}

		[Test]
		public void RoundToMid_PositiveValue_PositiveStepSize_Magnitude1000()
		{
			const float value = 1234567.8f;
			Debug.Log(value, "Value");
			const float scaleFactor = 1000f;
			Debug.Log(StepSizes.Multiply(scaleFactor), "Mid");

			float[] expected = { 1234500f, 1235000f, 1233750f, 1235000f, 1232500f };
			float[] actual = StepSizes.Multiply(scaleFactor).Select(stepSize => value.RoundToMid(stepSize)).ToArray();

			AreEqual(expected, actual, scaleFactor * Delta);
		}
	}
}