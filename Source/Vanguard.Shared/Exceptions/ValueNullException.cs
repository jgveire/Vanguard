using System;
using System.Runtime.Serialization;

namespace Vanguard
{
    /// <summary>
    /// The exception that is thrown when the <see cref="Vanguard.Guard"/> class detects 
    /// a null reference (Nothing in Visual Basic).
    /// </summary>
#if !PORTABLE
    [Serializable]
#endif
    public class ValueNullException : GuardException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValueNullException"/> class.
        /// </summary>
        public ValueNullException()
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

#if !PORTABLE
        /// <summary>
        /// Initializes a new instance of the <see cref="ValueNullException"/> class
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
        protected ValueNullException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
#endif
    }
}
