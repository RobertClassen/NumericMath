namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DoubleExtensions
	{
		/// <summary>
		/// Returns the number with the farthest value.
		/// </summary>
		/// <remarks>
		/// If both values are the same distance away but in opposite directions, 
		/// the first one is returned.
		/// 
		/// <code>
		/// 0.Furthest(20, -20); // returns '20'
		/// 0.Furthest(-20, 20); // returns '-20'
		/// </code>
		/// </remarks>
		public static double Furthest(this double value, double a, double b)
		{
			return value.RangeMagnitude(a) >= value.RangeMagnitude(b) ? a : b;
		}

		/// <summary>
		/// Returns the number with the farthest value.
		/// </summary>
		/// <remarks>
		/// If <c>values</c> contains another number 
		/// which is the same distance away but in the opposite direction, 
		/// the one which was found first is returned.
		/// 
		/// <code>
		/// 0.Furthest(new []{ 10, 20, 5, -20 }); // returns '20'
		/// 0.Furthest(new []{ 10, -20, 5, 20 }); // returns '-20'
		/// </code>
		/// </remarks>
		public static double Furthest(this double value, IList<double> values)
		{
			if(values == null)
			{
				throw new ArgumentNullException(nameof(values));
			}
			if(values.Count == Int.Zero)
			{
				throw new EmptySequenceException(nameof(values));
			}

			double furthest = values[Int.Zero];
			double maxDelta = value.RangeMagnitude(furthest);
			for(int i = Int.One; i < values.Count; i++)
			{
				double current = values[i];

				double delta = value.RangeMagnitude(current);
				if(delta > maxDelta)
				{
					maxDelta = delta;
					furthest = current;
				}
			}
			return furthest;
		}

		/// <summary>
		/// Returns the number with the farthest value.
		/// </summary>
		/// <remarks>
		/// If <c>values</c> contains another number 
		/// which is the same distance away but in the opposite direction, 
		/// the one which was found first is returned.
		/// 
		/// <code>
		/// 0.Furthest(new []{ 10, 20, 5, -20 }); // returns '20'
		/// 0.Furthest(new []{ 10, -20, 5, 20 }); // returns '-20'
		/// </code>
		/// </remarks>
		public static double Furthest(this double value, params double[] values)
		{
			if(values == null)
			{
				throw new ArgumentNullException(nameof(values));
			}
			if(values.Length == Int.Zero)
			{
				throw new EmptySequenceException(nameof(values));
			}

			double furthest = values[Int.Zero];
			double maxDelta = value.RangeMagnitude(furthest);
			for(int i = Int.One; i < values.Length; i++)
			{
				double current = values[i];

				double delta = value.RangeMagnitude(current);
				if(delta > maxDelta)
				{
					maxDelta = delta;
					furthest = current;
				}
			}
			return furthest;
		}

		/// <summary>
		/// Returns the number with the farthest value.
		/// </summary>
		/// <remarks>
		/// If <c>values</c> contains another number 
		/// which is the same distance away but in the opposite direction, 
		/// the one which was found first is returned.
		/// 
		/// <code>
		/// 0.Furthest(new []{ 10, 20, 5, -20 }); // returns '20'
		/// 0.Furthest(new []{ 10, -20, 5, 20 }); // returns '-20'
		/// </code>
		/// </remarks>
		public static double Furthest(this double value, IEnumerable<double> values)
		{
			if(values == null)
			{
				throw new ArgumentNullException(nameof(values));
			}

			using(IEnumerator<double> enumerator = values.GetEnumerator())
			{
				if(!enumerator.MoveNext())
				{
					throw new EmptySequenceException(nameof(values));
				}

				double furthest = enumerator.Current;
				double maxDelta = value.RangeMagnitude(furthest);
				while(enumerator.MoveNext())
				{
					double current = enumerator.Current;

					double delta = value.RangeMagnitude(current);
					if(delta > maxDelta)
					{
						maxDelta = delta;
						furthest = current;
					}
				}
				return furthest;
			}
		}
	}
}