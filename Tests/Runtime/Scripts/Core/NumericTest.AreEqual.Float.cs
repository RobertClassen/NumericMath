namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Linq;
	using NUnit.Framework;

	public partial class NumericTest
	{
		public static void AreEqual(IList<float> expected, IList<float> actual, float delta)
		{
			Debug.Log(expected, "Expected");
			Debug.Log(actual, "Actual");
			Assert.AreEqual(expected.Count, actual.Count, "Count");

			for(int i = Int.Zero; i < expected.Count; i++)
			{
				Assert.AreEqual(expected[i], actual[i], delta, 
					string.Format("Index {0}: {1} != {2}", i, expected[i], actual[i]));
			}
		}

		public static void AreEqual(IEnumerable<float> expected, IEnumerable<float> actual, float delta)
		{
			AreEqual(expected.ToArray(), actual.ToArray(), delta);
		}
	}
}