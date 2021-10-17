namespace WellDefinedNumerics
{
	using System;
	using System.Collections;
	using System.Runtime.Serialization;

	public class ArgumentLessEqualsZeroException : ArgumentOutOfRangeException
	{
		#region Constants
		public const string DefaultMessage = "Argument must be greater than zero";
		#endregion

		#region Constructors
		public ArgumentLessEqualsZeroException()
		{
		}

		public ArgumentLessEqualsZeroException(SerializationInfo info, StreamingContext context) :
			base(info, context)
		{
		}

		public ArgumentLessEqualsZeroException(string paramName) :
			base(paramName)
		{
		}

		public ArgumentLessEqualsZeroException(string message, Exception innerException) :
			base(message, innerException)
		{
		}

		public ArgumentLessEqualsZeroException(string paramName, object actualValue, string message = DefaultMessage) :
			base(paramName, actualValue, message)
		{
		}

		public ArgumentLessEqualsZeroException(string paramName, string message = DefaultMessage) :
			base(paramName, message)
		{
		}
		#endregion
	}
}