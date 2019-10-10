namespace Vanguard
{
    using System;

    /// <summary>
    /// The exception that is thrown when the <see cref="Vanguard.Guard"/> class detects.
    /// an error.
    /// </summary>
    public class GuardException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GuardException"/> class.
        /// </summary>
        public GuardException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public GuardException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="innerException">
        /// The exception that is the cause of the current exception, or a null reference
        /// (Nothing in Visual Basic) if no inner exception is specified.
        /// </param>
        public GuardException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
