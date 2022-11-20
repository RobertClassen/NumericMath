namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class LongExtensions
	{
		/// <summary>
		/// Returns the number with the closest value.
		/// </summary>
		/// <remarks>
		/// If both values are the same distance away but in opposite directions, 
		/// the first one is returned.
		/// 
		/// <code>
		/// 0.Nearest(5, -5); // returns '5'
		/// 0.Nearest(-5, 5); // returns '-5'
		/// </code>
		/// </remarks>
		public static long Nearest(this long value, long a, long b)
		{
			return value.RangeMagnitude(a) <= value.RangeMagnitude(b) ? a : b;
		}

		/// <summary>
		/// Returns the number with the closest value.
		/// </summary>
		/// <remarks>
		/// If <c>values</c> contains another number 
		/// which is the same distance away but in the opposite direction, 
		/// the one which was found first is returned.
		/// 
		/// <code>
		/// 0.Nearest(new []{ 10, 5, 20, -5 }); // returns '5'
		/// 0.Nearest(new []{ 10, -5, 20, 5 }); // returns '-5'
		/// </code>
		/// </remarks>
		public static long Nearest(this long value, IList<long> values)
		{
			if(values == null)
			{
				throw new ArgumentNullException(nameof(values));
			}
			if(values.Count == Int.Zero)
			{
				throw new EmptySequenceException(nameof(values));
			}

			long nearest = values[Int.Zero];
			long minDelta = Math.Abs(nearest - value);
			for(int i = Int.Zero; i < values.Count; i++)
			{
				long current = values[i];

				long delta = Math.Abs(current - value);
				if(delta < minDelta)
				{
					minDelta = delta;
					nearest = current;
				}
			}
			return nearest;
		}

		/// <summary>
		/// Returns the number with the closest value.
		/// </summary>
		/// <remarks>
		/// If <c>values</c> contains another number 
		/// which is the same distance away but in the opposite direction, 
		/// the one which was found first is returned.
		/// 
		/// <code>
		/// 0.Nearest(new []{ 10, 5, 20, -5 }); // returns '5'
		/// 0.Nearest(new []{ 10, -5, 20, 5 }); // returns '-5'
		/// </code>
		/// </remarks>
		public static long Nearest(this long value, params long[] values)
		{
			if(values == null)
			{
				throw new ArgumentNullException(nameof(values));
			}
			if(values.Length == Int.Zero)
			{
				throw new EmptySequenceException(nameof(values));
			}

			long nearest = values[Int.Zero];
			long minDelta = Math.Abs(nearest - value);
			for(int i = Int.Zero; i < values.Length; i++)
			{
				long current = values[i];

				long delta = Math.Abs(current - value);
				if(delta < minDelta)
				{
					minDelta = delta;
					nearest = current;
				}
			}
			return nearest;
		}

		/// <summary>
		/// Returns the number with the closest value.
		/// </summary>
		/// <remarks>
		/// If <c>values</c> contains another number 
		/// which is the same distance away but in the opposite direction, 
		/// the one which was found first is returned.
		/// 
		/// <code>
		/// 0.Nearest(new []{ 10, 5, 20, -5 }); // returns '5'
		/// 0.Nearest(new []{ 10, -5, 20, 5 }); // returns '-5'
		/// </code>
		/// </remarks>
		public static long Nearest(this long value, IEnumerable<long> values)
		{
			if(values == null)
			{
				throw new ArgumentNullException(nameof(values));
			}

			using(IEnumerator<long> enumerator = values.GetEnumerator())
			{
				if(!enumerator.MoveNext())
				{
					throw new EmptySequenceException(nameof(values));
				}

				long nearest = enumerator.Current;
				long minDelta = Math.Abs(nearest - value);
				while(enumerator.MoveNext())
				{
					long current = enumerator.Current;

					long delta = Math.Abs(current - value);
					if(delta < minDelta)
					{
						minDelta = delta;
						nearest = current;
					}
				}
				return nearest;
			}
		}
	}
}