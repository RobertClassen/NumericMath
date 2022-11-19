namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DoubleExtensions
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
		/// 0.Nearest(new []{ 10, 5, 20, -5 }); // returns '5'
		/// 0.Nearest(new []{ 10, -5, 20, 5 }); // returns '-5'
		/// </code>
		/// </remarks>
		public static double Nearest(this double value, IList<double> values)
		{
			if(values == null)
			{
				throw new ArgumentNullException(nameof(values));
			}
			if(values.Count == Int.Zero)
			{
				throw new EmptySequenceException(nameof(values));
			}

			double nearest = values[Int.Zero];
			double minDelta = Math.Abs(nearest - value);
			for(int i = Int.Zero; i < values.Count; i++)
			{
				double current = values[i];

				double delta = Math.Abs(current - value);
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
		public static double Nearest(this double value, params double[] values)
		{
			if(values == null)
			{
				throw new ArgumentNullException(nameof(values));
			}
			if(values.Length == Int.Zero)
			{
				throw new EmptySequenceException(nameof(values));
			}

			double nearest = values[Int.Zero];
			double minDelta = Math.Abs(nearest - value);
			for(int i = Int.Zero; i < values.Length; i++)
			{
				double current = values[i];

				double delta = Math.Abs(current - value);
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
		public static double Nearest(this double value, IEnumerable<double> values)
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

				double nearest = enumerator.Current;
				double minDelta = Math.Abs(nearest - value);
				while(enumerator.MoveNext())
				{
					double current = enumerator.Current;

					double delta = Math.Abs(current - value);
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