namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
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
		public static float Furthest(this float value, float a, float b)
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
		public static float Furthest(this float value, IList<float> values)
		{
			if(values == null)
			{
				throw new ArgumentNullException(nameof(values));
			}
			if(values.Count == Int.Zero)
			{
				throw new EmptySequenceException(nameof(values));
			}

			float furthest = values[Int.Zero];
			float maxDelta = value.RangeMagnitude(furthest);
			for(int i = Int.One; i < values.Count; i++)
			{
				float current = values[i];

				float delta = value.RangeMagnitude(current);
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
		public static float Furthest(this float value, params float[] values)
		{
			if(values == null)
			{
				throw new ArgumentNullException(nameof(values));
			}
			if(values.Length == Int.Zero)
			{
				throw new EmptySequenceException(nameof(values));
			}

			float furthest = values[Int.Zero];
			float maxDelta = value.RangeMagnitude(furthest);
			for(int i = Int.One; i < values.Length; i++)
			{
				float current = values[i];

				float delta = value.RangeMagnitude(current);
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
		public static float Furthest(this float value, IEnumerable<float> values)
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

				float furthest = enumerator.Current;
				float maxDelta = value.RangeMagnitude(furthest);
				while(enumerator.MoveNext())
				{
					float current = enumerator.Current;

					float delta = value.RangeMagnitude(current);
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