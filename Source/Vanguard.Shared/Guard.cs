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
            if (value == null)
            {
                throw new ArgumentNullException(name);
            }
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
            if (value == null)
            {
                throw new ArgumentNullException(name, message);
            }
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

            if (value == null)
            {
                throw new ArgumentNullException(name);
            }
            else if (value == string.Empty)
            {
                throw new ArgumentException(ExceptionResource.ValueEmptyExceptionMessage, name);
            }
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
            if (value == null)
            {
                throw new ArgumentNullException(name, message);
            }
            else if (value == string.Empty)
            {
                throw new ArgumentException(message, name);
            }
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
            if (value == null)
            {
                throw new ArgumentNullException(name);
            }
            else if (value == Guid.Empty)
            {
                throw new ArgumentException(ExceptionResource.ValueEmptyExceptionMessage, name);
            }
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
            if (value == null)
            {
                throw new ArgumentNullException(name, message);
            }
            else if (value == Guid.Empty)
            {
                throw new ArgumentException(message, name);
            }
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
            if (value < minimum || value > maximum)
            {
                throw new ArgumentOutOfRangeException(name);
            }
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
            if (value < minimum || value > maximum)
            {
                throw new ArgumentOutOfRangeException(name, message);
            }
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
        public static void ArgumentInRange(double value, double minimum, double maximum, string name)
        {
            if (value < minimum || value > maximum)
            {
                throw new ArgumentOutOfRangeException(name);
            }
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
        public static void ArgumentInRange(double value, double minimum, double maximum, string name, string message)
        {
            if (value < minimum || value > maximum)
            {
                throw new ArgumentOutOfRangeException(name, message);
            }
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
        public static void ArgumentInRange(decimal value, decimal minimum, decimal maximum, string name)
        {
            if (value < minimum || value > maximum)
            {
                throw new ArgumentOutOfRangeException(name);
            }
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
        public static void ArgumentInRange(decimal value, decimal minimum, decimal maximum, string name, string message)
        {
            if (value < minimum || value > maximum)
            {
                throw new ArgumentOutOfRangeException(name, message);
            }
        }
        /// <summary>
        /// Ensures that a value is not null,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <exception cref="ValueNullException">Thrown when the value is null.</exception>
        public static void ValueNotNull(object value)
        {
            if (value == null)
            {
                throw new ValueNullException();
            }
        }

        /// <summary>
        /// Ensures that a value is not null,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="message">The exception message.</param>
        /// <exception cref="ValueNullException">Thrown when the value is null.</exception>
        public static void ValueNotNull(object value, string message)
        {
            if (value == null)
            {
                throw new ValueNullException(message);
            }
        }

        /// <summary>
        /// Ensures that a value is not null or empty,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <exception cref="ValueNullException">Thrown when the value is null.</exception>
        /// <exception cref="ValueEmptyException">Thrown when the value contains an empty string.</exception>
        public static void ValueNotNullOrEmpty(string value)
        {
            if (value == null)
            {
                throw new ValueNullException();
            }
            else if (value == string.Empty)
            {
                throw new ValueEmptyException();
            }
        }

        /// <summary>
        /// Ensures that a value is not null or empty,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="message">The exception message.</param>
        /// <exception cref="ValueNullException">Thrown when the value is null.</exception>
        /// <exception cref="ValueEmptyException">Thrown when the value contains an empty string.</exception>
        public static void ValueNotNullOrEmpty(string value, string message)
        {
            if (value == null)
            {
                throw new ValueNullException(message);
            }
            else if (value == string.Empty)
            {
                throw new ValueEmptyException(message);
            }
        }

        /// <summary>
        /// Ensures that a value is not null or empty,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <exception cref="ValueNullException">Thrown when the value is null.</exception>
        /// <exception cref="ValueEmptyException">Thrown when the value contains an empty Guid.</exception>
        public static void ValueNotNullOrEmpty(Guid? value)
        {
            if (value == null)
            {
                throw new ValueNullException();
            }
            else if (value == Guid.Empty)
            {
                throw new ValueEmptyException();
            }
        }

        /// <summary>
        /// Ensures that a value is not null or empty,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="message">The exception message.</param>
        /// <exception cref="ValueNullException">Thrown when the value is null.</exception>
        /// <exception cref="ValueEmptyException">Thrown when the value contains an empty Guid.</exception>
        public static void ValueNotNullOrEmpty(Guid? value, string message)
        {
            if (value == null)
            {
                throw new ValueNullException(message);
            }
            else if (value == Guid.Empty)
            {
                throw new ValueEmptyException(message);
            }
        }
        
        /// <summary>
        /// Ensures that a value is not out of range,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="minimum">The minimum value.</param>
        /// <param name="maximum">The maximum value.</param>
        /// <exception cref="ValueOutOfRangeException">Thrown when the value is out of range.</exception>
        public static void ValueInRange(long value, long minimum, long maximum)
        {
            if (value < minimum || value > maximum)
            {
                throw new ValueOutOfRangeException();
            }
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
        public static void ValueInRange(long value, long minimum, long maximum, string message)
        {
            if (value < minimum || value > maximum)
            {
                throw new ValueOutOfRangeException(message);
            }
        }

        /// <summary>
        /// Ensures that a value is not out of range,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="minimum">The minimum value.</param>
        /// <param name="maximum">The maximum value.</param>
        /// <exception cref="ValueOutOfRangeException">Thrown when the value is out of range.</exception>
        public static void ValueInRange(double value, double minimum, double maximum)
        {
            if (value < minimum || value > maximum)
            {
                throw new ValueOutOfRangeException();
            }
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
        public static void ValueInRange(double value, double minimum, double maximum, string message)
        {
            if (value < minimum || value > maximum)
            {
                throw new ValueOutOfRangeException(message);
            }
        }

        /// <summary>
        /// Ensures that a value is not out of range,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="minimum">The minimum value.</param>
        /// <param name="maximum">The maximum value.</param>
        /// <exception cref="ValueOutOfRangeException">Thrown when the value is out of range.</exception>
        public static void ValueInRange(decimal value, decimal minimum, decimal maximum)
        {
            if (value < minimum || value > maximum)
            {
                throw new ValueOutOfRangeException();
            }
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
        public static void ValueInRange(decimal value, decimal minimum, decimal maximum, string message)
        {
            if (value < minimum || value > maximum)
            {
                throw new ValueOutOfRangeException(message);
            }
        }
    }
}
