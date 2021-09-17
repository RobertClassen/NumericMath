namespace WellDefined
{
	using System;
	using System.Collections;
	using System.Runtime.Serialization;

	public class ArgumentLessThanZeroException : ArgumentOutOfRangeException
	{
		#region Constants
		public const string DefaultMessage = "Argument must be greater than or equal to zero";
		#endregion

		#region Fields
		
		#endregion

		#region Properties
		
		#endregion

		#region Constructors
		public ArgumentLessThanZeroException()
		{
		}

		public ArgumentLessThanZeroException(SerializationInfo info, StreamingContext context) :
			base(info, context)
		{
		}

		public ArgumentLessThanZeroException(string paramName) :
			base(paramName)
		{
		}

		public ArgumentLessThanZeroException(string message, Exception innerException) :
			base(message, innerException)
		{
		}

		public ArgumentLessThanZeroException(string paramName, object actualValue, string message = DefaultMessage) :
			base(paramName, actualValue, message)
		{
		}

		public ArgumentLessThanZeroException(string paramName, string message = DefaultMessage) :
			base(paramName, message)
		{
		}
		#endregion

		#region Methods
		
		#endregion
	}
}