namespace Vanguard
{
    using System;

    /// <summary>
    /// The exception that is thrown when the <see cref="Vanguard.Guard"/> class detects
    /// a null reference (Nothing in Visual Basic).
    /// </summary>
    public class ValueNullException : GuardException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValueNullException"/> class.
        /// </summary>
        public ValueNullException()
            : base(ExceptionResource.ValueNullExceptionMessage)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValueNullException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public ValueNullException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValueNullException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="innerException">
        /// The exception that is the cause of the current exception, or a null reference
        /// (Nothing in Visual Basic) if no inner exception is specified.
        /// </param>
        public ValueNullException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
