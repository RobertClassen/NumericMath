namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ShortExtensions
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
		public static short Furthest(this short value, short a, short b)
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
		public static short Furthest(this short value, IList<short> values)
		{
			if(values == null)
			{
				throw new ArgumentNullException(nameof(values));
			}
			if(values.Count == Int.Zero)
			{
				throw new EmptySequenceException(nameof(values));
			}

			short furthest = values[Int.Zero];
			short maxDelta = value.RangeMagnitude(furthest);
			for(int i = Int.One; i < values.Count; i++)
			{
				short current = values[i];

				short delta = value.RangeMagnitude(current);
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
		public static short Furthest(this short value, params short[] values)
		{
			if(values == null)
			{
				throw new ArgumentNullException(nameof(values));
			}
			if(values.Length == Int.Zero)
			{
				throw new EmptySequenceException(nameof(values));
			}

			short furthest = values[Int.Zero];
			short maxDelta = value.RangeMagnitude(furthest);
			for(int i = Int.One; i < values.Length; i++)
			{
				short current = values[i];

				short delta = value.RangeMagnitude(current);
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
		public static short Furthest(this short value, IEnumerable<short> values)
		{
			if(values == null)
			{
				throw new ArgumentNullException(nameof(values));
			}

			using(IEnumerator<short> enumerator = values.GetEnumerator())
			{
				if(!enumerator.MoveNext())
				{
					throw new EmptySequenceException(nameof(values));
				}

				short furthest = enumerator.Current;
				short maxDelta = value.RangeMagnitude(furthest);
				while(enumerator.MoveNext())
				{
					short current = enumerator.Current;

					short delta = value.RangeMagnitude(current);
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