namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Runtime.Serialization;

	public class EmptySequenceException : ArgumentException
	{
		#region Constants
		public const string DefaultMessage = "Sequence contains no elements";
		#endregion

		#region Constructors
		public EmptySequenceException()
			: base(DefaultMessage)
		{
		}

		public EmptySequenceException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		public EmptySequenceException(Exception innerException, string message = DefaultMessage)
			: base(message, innerException)
		{
		}

		public EmptySequenceException(string paramName, string message = DefaultMessage)
			: base(message, paramName)
		{
		}

		public EmptySequenceException(string paramName, Exception innerException, string message = DefaultMessage)
			: base(message, paramName, innerException)
		{
		}
		#endregion
	}
}