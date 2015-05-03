using System;
using System.Runtime.Serialization;

namespace Vanguard
{
    /// <summary>
    /// The exception that is thrown when the <see cref="Vanguard.Guard"/> class detects 
    /// an out of range reference.
    /// </summary>
#if !PORTABLE
    [Serializable]
#endif
    public class ValueOutOfRangeException : GuardException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValueOutOfRangeException"/> class.
        /// </summary>
        public ValueOutOfRangeException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValueOutOfRangeException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public ValueOutOfRangeException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValueOutOfRangeException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="innerException">
        /// The exception that is the cause of the current exception, or a null reference
        /// (Nothing in Visual Basic) if no inner exception is specified.
        /// </param>
        public ValueOutOfRangeException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

#if !PORTABLE
        /// <summary>
        /// Initializes a new instance of the <see cref="ValueOutOfRangeException"/> class
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
        protected ValueOutOfRangeException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
#endif
    }
}
