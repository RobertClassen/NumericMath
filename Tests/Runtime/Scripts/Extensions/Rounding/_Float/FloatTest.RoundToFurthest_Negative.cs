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
		public void RoundToFurthest_NegativeValue_NegativeStepSize_Throws()
		{
			const float value = -1234.5678f;
			Assert.Throws<ArgumentLessEqualsZeroException>(() => value.RoundToFurthest(-1));
		}

		[Test]
		public void RoundToFurthest_NegativeValue_StepSize0_Throws()
		{
			const float value = -1234.5678f;
			Assert.Throws<ArgumentLessEqualsZeroException>(() => value.RoundToFurthest(0));
		}

		[Test]
		public void RoundToFurthest_NegativeValue_PositiveStepSize_Magnitude0_001()
		{
			const float value = -1.2345678f;
			Debug.Log(value, "Value");
			const float scaleFactor = 0.001f;
			Debug.Log(StepSizes.Multiply(scaleFactor), "Furthest");

			float[] expected = { -1.234f, -1.236f, -1.2325f, -1.2366666f, -1.23f };
			float[] actual = StepSizes.Multiply(scaleFactor).Select(stepSize => value.RoundToFurthest(stepSize)).ToArray();

			AreEqual(expected, actual, scaleFactor * Delta);
		}

		[Test]
		public void RoundToFurthest_NegativeValue_PositiveStepSize_Magnitude0_01()
		{
			const float value = -12.345678f;
			Debug.Log(value, "Value");
			const float scaleFactor = 0.01f;
			Debug.Log(StepSizes.Multiply(scaleFactor), "Furthest");

			float[] expected = { -12.34f, -12.36f, -12.325f, -12.366666f, -12.3f };
			float[] actual = StepSizes.Multiply(scaleFactor).Select(stepSize => value.RoundToFurthest(stepSize)).ToArray();

			AreEqual(expected, actual, scaleFactor * Delta);
		}

		[Test]
		public void RoundToFurthest_NegativeValue_PositiveStepSize_Magnitude0_1()
		{
			const float value = -123.45678f;
			Debug.Log(value, "Value");
			const float scaleFactor = 0.1f;
			Debug.Log(StepSizes.Multiply(scaleFactor), "Furthest");

			float[] expected = { -123.4f, -123.6f, -123.25f, -123.66666f, -123f };
			float[] actual = StepSizes.Multiply(scaleFactor).Select(stepSize => value.RoundToFurthest(stepSize)).ToArray();

			AreEqual(expected, actual, scaleFactor * Delta);
		}

		[Test]
		public void RoundToFurthest_NegativeValue_PositiveStepSize_Magnitude1()
		{
			const float value = -1234.5678f;
			Debug.Log(value, "Value");
			const float scaleFactor = 1f;
			Debug.Log(StepSizes.Multiply(scaleFactor), "Furthest");

			float[] expected = { -1234f, -1236f, -1232.5f, -1236.6666f, -1230f };
			float[] actual = StepSizes.Multiply(scaleFactor).Select(stepSize => value.RoundToFurthest(stepSize)).ToArray();

			AreEqual(expected, actual, scaleFactor * Delta);
		}

		[Test]
		public void RoundToFurthest_NegativeValue_PositiveStepSize_Magnitude10()
		{
			const float value = -12345.678f;
			Debug.Log(value, "Value");
			const float scaleFactor = 10f;
			Debug.Log(StepSizes.Multiply(scaleFactor), "Furthest");

			float[] expected = { -12340f, -12360f, -12325f, -12366.666f, -12300f };
			float[] actual = StepSizes.Multiply(scaleFactor).Select(stepSize => value.RoundToFurthest(stepSize)).ToArray();

			AreEqual(expected, actual, scaleFactor * Delta);
		}

		[Test]
		public void RoundToFurthest_NegativeValue_PositiveStepSize_Magnitude100()
		{
			const float value = -123456.78f;
			Debug.Log(value, "Value");
			const float scaleFactor = 100f;
			Debug.Log(StepSizes.Multiply(scaleFactor), "Furthest");

			float[] expected = { -123400f, -123600f, -123250f, -123666.66f, -123000f };
			float[] actual = StepSizes.Multiply(scaleFactor).Select(stepSize => value.RoundToFurthest(stepSize)).ToArray();

			AreEqual(expected, actual, scaleFactor * Delta);
		}

		[Test]
		public void RoundToFurthest_NegativeValue_PositiveStepSize_Magnitude1000()
		{
			const float value = -1234567.8f;
			Debug.Log(value, "Value");
			const float scaleFactor = 1000f;
			Debug.Log(StepSizes.Multiply(scaleFactor), "Furthest");

			float[] expected = { -1234000f, -1236000f, -1232500f, -1236666.6f, -1230000f };
			float[] actual = StepSizes.Multiply(scaleFactor).Select(stepSize => value.RoundToFurthest(stepSize)).ToArray();

			AreEqual(expected, actual, scaleFactor * Delta);
		}
	}
}