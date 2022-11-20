namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ByteExtensions
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
		public static byte Nearest(this byte value, byte a, byte b)
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
		public static byte Nearest(this byte value, IList<byte> values)
		{
			if(values == null)
			{
				throw new ArgumentNullException(nameof(values));
			}
			if(values.Count == Int.Zero)
			{
				throw new EmptySequenceException(nameof(values));
			}

			byte nearest = values[Int.Zero];
			byte minDelta = value.RangeMagnitude(nearest);
			for(int i = Int.One; i < values.Count; i++)
			{
				byte current = values[i];

				byte delta = value.RangeMagnitude(current);
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
		public static byte Nearest(this byte value, params byte[] values)
		{
			if(values == null)
			{
				throw new ArgumentNullException(nameof(values));
			}
			if(values.Length == Int.Zero)
			{
				throw new EmptySequenceException(nameof(values));
			}

			byte nearest = values[Int.Zero];
			byte minDelta = value.RangeMagnitude(nearest);
			for(int i = Int.One; i < values.Length; i++)
			{
				byte current = values[i];

				byte delta = value.RangeMagnitude(current);
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
		public static byte Nearest(this byte value, IEnumerable<byte> values)
		{
			if(values == null)
			{
				throw new ArgumentNullException(nameof(values));
			}

			using(IEnumerator<byte> enumerator = values.GetEnumerator())
			{
				if(!enumerator.MoveNext())
				{
					throw new EmptySequenceException(nameof(values));
				}

				byte nearest = enumerator.Current;
				byte minDelta = value.RangeMagnitude(nearest);
				while(enumerator.MoveNext())
				{
					byte current = enumerator.Current;

					byte delta = value.RangeMagnitude(current);
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