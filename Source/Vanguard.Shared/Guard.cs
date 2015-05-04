using System;

namespace Vanguard
{
    /// <summary>
    /// A static helper class that includes various parameter checking routines.
    /// </summary>
    public static class Guard
    {
        /// <summary>
        /// Ensures that a parameter value is not null,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The parameter value.</param>
        /// <param name="name">Name of the parameter.</param>
        /// <exception cref="System.ArgumentNullException">Thrown when the value is null.</exception>
        public static void ArgumentNotNull(object value, string name)
        {
            ArgumentNotNull(value, name, null);
        }

        /// <summary>
        /// Ensures that a parameter value is not null,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The parameter value.</param>
        /// <param name="name">Name of the parameter.</param>
        /// <param name="message">The exception message.</param>
        /// <exception cref="System.ArgumentNullException">Thrown when the value is null.</exception>
        public static void ArgumentNotNull(object value, string name, string message)
        {
            var validator = new NotNullValidator(value);
            var exception = new ArgumentNullException(name, message);
            HandleGuard(validator, exception);
        }
        
        /// <summary>
        /// Ensures that a parameter value is not null or empty,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The parameter value.</param>
        /// <param name="name">Name of the parameter.</param>
        /// <exception cref="System.ArgumentNullException">Thrown when the value is null.</exception>
        /// <exception cref="System.ArgumentException">Thrown when the value contains an empty string.</exception>
        public static void ArgumentNotNullOrEmpty(string value, string name)
        {
            ArgumentNotNullOrEmpty(value, name, ExceptionResource.ArgumentNullOrEmptyExceptionMessage);
        }

        /// <summary>
        /// Ensures that a parameter value is not null or empty,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The parameter value.</param>
        /// <param name="name">Name of the parameter.</param>
        /// <param name="message">The exception message.</param>
        /// <exception cref="System.ArgumentNullException">Thrown when the value is null.</exception>
        /// <exception cref="System.ArgumentException">Thrown when the value contains an empty string.</exception>
        public static void ArgumentNotNullOrEmpty(string value, string name, string message)
        {
            ArgumentNotNull(value, name, message);

            var validator = new StringNotNullOrEmptyValidator(value);
            var exception = new ArgumentException(message, name);
            HandleGuard(validator, exception);
        }

        /// <summary>
        /// Ensures that a parameter value is not null or empty,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The parameter value.</param>
        /// <param name="name">Name of the parameter.</param>
        /// <exception cref="System.ArgumentNullException">Thrown when the value is null.</exception>
        /// /// <exception cref="System.ArgumentException">Thrown when the value contains an empty Guid.</exception>
        public static void ArgumentNotNullOrEmpty(Guid? value, string name)
        {
            ArgumentNotNullOrEmpty(value, name, ExceptionResource.ArgumentNullOrEmptyExceptionMessage);
        }

        /// <summary>
        /// Ensures that a parameter value is not null or empty,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The parameter value.</param>
        /// <param name="name">Name of the parameter.</param>
        /// <param name="message">The exception message.</param>
        /// <exception cref="System.ArgumentNullException">Thrown when the value is null.</exception>
        /// <exception cref="System.ArgumentException">Thrown when the value contains an empty Guid.</exception>
        public static void ArgumentNotNullOrEmpty(Guid? value, string name, string message)
        {
            ArgumentNotNull(value, name, message);

            var validator = new GuidNotNullOrEmptyValidator(value);
            var exception = new ArgumentException(message, name);
            HandleGuard(validator, exception);
        }

        /// <summary>
        /// Ensures that a parameter value is not out of range,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The parameter value.</param>
        /// <param name="minimum">The minimum value of an argument.</param>
        /// <param name="maximum">The maximum value of an argument.</param>
        /// <param name="name">Name of the parameter.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when the value is out of range.</exception>
        public static void ArgumentInRange(long value, long minimum, long maximum, string name)
        {
            ArgumentInRange(value, minimum, maximum, name, null);
        }

        /// <summary>
        /// Ensures that a parameter value is not out of range,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The parameter value.</param>
        /// <param name="minimum">The minimum value of an argument.</param>
        /// <param name="maximum">The maximum value of an argument.</param>
        /// <param name="name">Name of the parameter.</param>
        /// <param name="message">The exception message.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when the value is out of range.</exception>
        public static void ArgumentInRange(long value, long minimum, long maximum, string name, string message)
        {
            var validator = new InRangeValidator(value, minimum, maximum);
            var exception = new ArgumentOutOfRangeException(name, message);
            HandleGuard(validator, exception);
        }

        /// <summary>
        /// Ensures that a value is not null,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <exception cref="ValueNullException">Thrown when the value is null.</exception>
        public static void ValueIsNotNull(object value)
        {
            ValueIsNotNull(value, null);
        }

        /// <summary>
        /// Ensures that a value is not null,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="message">The exception message.</param>
        /// <exception cref="ValueNullException">Thrown when the value is null.</exception>
        public static void ValueIsNotNull(object value, string message)
        {
            var validator = new NotNullValidator(value);
            var exception = new ValueNullException(message);
            HandleGuard(validator, exception);
        }

        /// <summary>
        /// Ensures that a value is not null or empty,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <exception cref="ValueNullException">Thrown when the value is null.</exception>
        /// <exception cref="ValueEmptyException">Thrown when the value contains an empty string.</exception>
        public static void ValueIsNotNullOrEmpty(string value)
        {
            ValueIsNotNullOrEmpty(value, ExceptionResource.ArgumentNullOrEmptyExceptionMessage);
        }

        /// <summary>
        /// Ensures that a value is not null or empty,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="message">The exception message.</param>
        /// <exception cref="ValueNullException">Thrown when the value is null.</exception>
        /// <exception cref="ValueEmptyException">Thrown when the value contains an empty string.</exception>
        public static void ValueIsNotNullOrEmpty(string value, string message)
        {
            ValueIsNotNull(value, message);

            var validator = new StringNotNullOrEmptyValidator(value);
            var exception = new ValueEmptyException(message);
            HandleGuard(validator, exception);
        }

        /// <summary>
        /// Ensures that a value is not null or empty,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <exception cref="ValueNullException">Thrown when the value is null.</exception>
        /// <exception cref="ValueEmptyException">Thrown when the value contains an empty Guid.</exception>
        public static void ValueIsNotNullOrEmpty(Guid? value)
        {
            ValueIsNotNullOrEmpty(value, ExceptionResource.ArgumentNullOrEmptyExceptionMessage);
        }

        /// <summary>
        /// Ensures that a value is not null or empty,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="message">The exception message.</param>
        /// <exception cref="ValueNullException">Thrown when the value is null.</exception>
        /// <exception cref="ValueEmptyException">Thrown when the value contains an empty Guid.</exception>
        public static void ValueIsNotNullOrEmpty(Guid? value, string message)
        {
            ValueIsNotNull(value, message);

            var validator = new GuidNotNullOrEmptyValidator(value);
            var exception = new ValueEmptyException(message);
            HandleGuard(validator, exception);
        }

        /// <summary>
        /// Ensures that a value is not out of range,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="minimum">The minimum value.</param>
        /// <param name="maximum">The maximum value.</param>
        /// <exception cref="ValueOutOfRangeException">Thrown when the value is out of range.</exception>
        public static void ValueIsInRange(long value, long minimum, long maximum)
        {
            ValueIsInRange(value, minimum, maximum, null);
        }

        /// <summary>
        /// Ensures that a value is not out of range,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="minimum">The minimum value.</param>
        /// <param name="maximum">The maximum value.</param>
        /// <param name="message">The exception message.</param>
        /// <exception cref="ValueOutOfRangeException">Thrown when the value is out of range.</exception>
        public static void ValueIsInRange(long value, long minimum, long maximum, string message)
        {
            var validator = new InRangeValidator(value, minimum, maximum);
            var exception = new ValueOutOfRangeException(message);
            HandleGuard(validator, exception);
        }

        /// <summary>
        /// Handles the execution of a guard.
        /// </summary>
        /// <typeparam name="TValidator">The type of the validator.</typeparam>
        /// <typeparam name="TException">The type of the exception.</typeparam>
        /// <param name="validator">The validator to execute.</param>
        /// <param name="exception">The exception that is thrown when the validator returns <c>false</c>.</param>
        /// <exception cref="System.ArgumentNullException">Thrown when the argument validator or exception is null.</exception>
        /// <exception cref="System.Exception">Thrown when the validator.Validate() returs <c>false</c>.</exception>
        internal static void HandleGuard<TValidator, TException>(TValidator validator, TException exception)
            where TException : Exception
            where TValidator : GuardValidator
        {
            if (validator == null)
            {
                throw new ArgumentNullException("validator");
            }

            if (exception == null)
            {
                throw new ArgumentNullException("exception");
            }

            if (!validator.Validate())
            {
                throw exception;
            }
        }
    }
}
