namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ShortExtensions
	{
		/// <summary>
		/// Returns the number with the closest value.
		/// </summary>
		/// <remarks>
		/// If <c>values</c> contains another number 
		/// which is the same distance away but in the opposite direction, 
		/// the one which was found first is returned.
		/// 
		/// <code>
		/// 0.Nearest(new []{ 10, 5, 20, -5 }; // returns '5'
		/// 0.Nearest(new []{ 10, -5, 20, 5 }; // returns '-5'
		/// </code>
		/// </remarks>
		public static short Nearest(this short value, IList<short> values)
		{
			if(values == null)
			{
				throw new ArgumentNullException(nameof(values));
			}
			if(values.Count == Int.Zero)
			{
				throw new EmptySequenceException(nameof(values));
			}

			short nearest = values[Int.Zero];
			short minDelta = Math.Abs((short)(nearest - value));
			for(int i = Int.Zero; i < values.Count; i++)
			{
				short current = values[i];

				short delta = Math.Abs((short)(current - value));
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
		/// 0.Nearest(new []{ 10, 5, 20, -5 }; // returns '5'
		/// 0.Nearest(new []{ 10, -5, 20, 5 }; // returns '-5'
		/// </code>
		/// </remarks>
		public static short Nearest(this short value, params short[] values)
		{
			if(values == null)
			{
				throw new ArgumentNullException(nameof(values));
			}
			if(values.Length == Int.Zero)
			{
				throw new EmptySequenceException(nameof(values));
			}

			short nearest = values[Int.Zero];
			short minDelta = Math.Abs((short)(nearest - value));
			for(int i = Int.Zero; i < values.Length; i++)
			{
				short current = values[i];

				short delta = Math.Abs((short)(current - value));
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
		/// 0.Nearest(new []{ 10, 5, 20, -5 }; // returns '5'
		/// 0.Nearest(new []{ 10, -5, 20, 5 }; // returns '-5'
		/// </code>
		/// </remarks>
		public static short Nearest(this short value, IEnumerable<short> values)
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

				short nearest = enumerator.Current;
				short minDelta = Math.Abs((short)(nearest - value));
				while(enumerator.MoveNext())
				{
					short current = enumerator.Current;

					short delta = Math.Abs((short)(current - value));
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