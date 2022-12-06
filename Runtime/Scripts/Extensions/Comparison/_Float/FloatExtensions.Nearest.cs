namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
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
		public static float Nearest(this float value, float a, float b)
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
		public static float Nearest(this float value, IList<float> values)
		{
			if(values == null)
			{
				throw new ArgumentNullException(nameof(values));
			}
			if(values.Count == Int.Zero)
			{
				throw new EmptySequenceException(nameof(values));
			}

			float nearest = values[Int.Zero];
			float minDelta = value.RangeMagnitude(nearest);
			for(int i = Int.One; i < values.Count; i++)
			{
				float current = values[i];

				float delta = value.RangeMagnitude(current);
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
		public static float Nearest(this float value, params float[] values)
		{
			return value.Nearest((IList<float>)values);
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
		public static float Nearest(this float value, IEnumerable<float> values)
		{
			if(values == null)
			{
				throw new ArgumentNullException(nameof(values));
			}

			using(IEnumerator<float> enumerator = values.GetEnumerator())
			{
				if(!enumerator.MoveNext())
				{
					throw new EmptySequenceException(nameof(values));
				}

				float nearest = enumerator.Current;
				float minDelta = value.RangeMagnitude(nearest);
				while(enumerator.MoveNext())
				{
					float current = enumerator.Current;

					float delta = value.RangeMagnitude(current);
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