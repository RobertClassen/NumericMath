namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Linq;
	using NUnit.Framework;

	public partial class NumericTest
	{
		public static void AreEqual<T>(IList<T> expected, IList<T> actual)
		{
			Debug.Log(expected);
			Debug.Log(actual);
			Assert.AreEqual(expected.Count, actual.Count, "Count");

			for(int i = Int.Zero; i < expected.Count; i++)
			{
				Assert.AreEqual(expected[i], actual[i], 
					string.Format("Index {0}: {1} != {2}", i, expected[i], actual[i]));
			}
		}

		public static void AreEqual<T>(IEnumerable<T> expected, IEnumerable<T> actual)
		{
			AreEqual(expected.ToArray(), actual.ToArray());
		}
	}
}