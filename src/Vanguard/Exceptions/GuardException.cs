using System;
#if !PORTABLE && !NETSTANDARD1_0
using System.Runtime.Serialization;
#endif

namespace Vanguard
{
    /// <summary>
    /// The exception that is thrown when the <see cref="Vanguard.Guard"/> class detects 
    /// an error.
    /// </summary>
#if !PORTABLE && !NETSTANDARD1_0
    [Serializable]
#endif
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

#if !PORTABLE && !NETSTANDARD1_0
        /// <summary>
        /// Initializes a new instance of the <see cref="GuardException"/> class
        /// with serialized data.
        /// </summary>
        /// <param name="info">
        /// The <see cref="System.Runtime.Serialization.SerializationInfo"/> that holds the serialized
        /// object data about the exception being thrown.
        /// </param>
        /// <param name="context">
        /// The <see cref="System.Runtime.Serialization.StreamingContext"/> that contains contextual
        /// information about the source or destination.
        /// </param>
        protected GuardException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
#endif
    }
}
