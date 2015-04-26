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
            ArgumentNotNull(value, name);
            if (string.IsNullOrEmpty(value))
            {
                string message = string.Format(ExceptionResource.ArgumentEmptyExceptionMessage, name);
                throw new ArgumentException(name, message);
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
            ArgumentNotNull(value, name, message);
            if (string.IsNullOrEmpty(value))
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
            ArgumentNotNull(value, name);
            if (value == Guid.Empty)
            {
                string message = string.Format(ExceptionResource.ArgumentEmptyExceptionMessage, name);
                throw new ArgumentException(name, message);
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
            ArgumentNotNull(value, name, message);
            if (value == Guid.Empty)
            {
                throw new ArgumentException(message, name);
            }
        }

        /// <summary>
        /// Ensures that a parameter value is not out of range,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The parameter value.</param>
        /// <param name="name">Name of the parameter.</param>
        /// <param name="range">The range in which the parameter value should be.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when the value is out of range.</exception>
        public static void ArgumentInRange(byte value, string name, ArgumentRange range)
        {
            if (!range.ValueInRange(value))
            {
                throw new ArgumentOutOfRangeException(name);
            }
        }

        /// <summary>
        /// Ensures that a parameter value is not out of range,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The parameter value.</param>
        /// <param name="name">Name of the parameter.</param>
        /// <param name="range">The range in which the parameter value should be.</param>
        /// <param name="message">The exception message.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when the value is out of range.</exception>
        public static void ArgumentInRange(byte value, string name, ArgumentRange range, string message)
        {
            if (!range.ValueInRange(value))
            {
                throw new ArgumentOutOfRangeException(name, message);
            }
        }

        /// <summary>
        /// Ensures that a parameter value is not out of range,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The parameter value.</param>
        /// <param name="name">Name of the parameter.</param>
        /// <param name="range">The range in which the parameter value should be.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when the value is out of range.</exception>
        public static void ArgumentInRange(int value, string name, ArgumentRange range)
        {
            if (!range.ValueInRange(value))
            {
                throw new ArgumentOutOfRangeException(name);
            }
        }

        /// <summary>
        /// Ensures that a parameter value is not out of range,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The parameter value.</param>
        /// <param name="name">Name of the parameter.</param>
        /// <param name="range">The range in which the parameter value should be.</param>
        /// <param name="message">The exception message.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when the value is out of range.</exception>
        public static void ArgumentInRange(int value, string name, ArgumentRange range, string message)
        {
            if (!range.ValueInRange(value))
            {
                throw new ArgumentOutOfRangeException(name, message);
            }
        }

        /// <summary>
        /// Ensures that a parameter value is not out of range,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The parameter value.</param>
        /// <param name="name">Name of the parameter.</param>
        /// <param name="range">The range in which the parameter value should be.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when the value is out of range.</exception>
        public static void ArgumentInRange(short value, string name, ArgumentRange range)
        {
            if (!range.ValueInRange(value))
            {
                throw new ArgumentOutOfRangeException(name);
            }
        }

        /// <summary>
        /// Ensures that a parameter value is not out of range,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The parameter value.</param>
        /// <param name="name">Name of the parameter.</param>
        /// <param name="range">The range in which the parameter value should be.</param>
        /// <param name="message">The exception message.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when the value is out of range.</exception>
        public static void ArgumentInRange(short value, string name, ArgumentRange range, string message)
        {
            if (!range.ValueInRange(value))
            {
                throw new ArgumentOutOfRangeException(name, message);
            }
        }

        /// <summary>
        /// Ensures that a parameter value is not out of range,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The parameter value.</param>
        /// <param name="name">Name of the parameter.</param>
        /// <param name="range">The range in which the parameter value should be.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when the value is out of range.</exception>
        public static void ArgumentInRange(long value, string name, ArgumentRange range)
        {
            if (!range.ValueInRange(value))
            {
                throw new ArgumentOutOfRangeException(name);
            }
        }

        /// <summary>
        /// Ensures that a parameter value is not out of range,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The parameter value.</param>
        /// <param name="name">Name of the parameter.</param>
        /// <param name="range">The range in which the parameter value should be.</param>
        /// <param name="message">The exception message.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when the value is out of range.</exception>
        public static void ArgumentInRange(long value, string name, ArgumentRange range, string message)
        {
            if (!range.ValueInRange(value))
            {
                throw new ArgumentOutOfRangeException(name, message);
            }
        }

        /// <summary>
        /// Ensures that a parameter value is not out of range,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The parameter value.</param>
        /// <param name="name">Name of the parameter.</param>
        /// <param name="range">The range in which the parameter value should be.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when the value is out of range.</exception>
        public static void ArgumentInRange(float value, string name, ArgumentRange range)
        {
            if (!range.ValueInRange(value))
            {
                throw new ArgumentOutOfRangeException(name);
            }
        }

        /// <summary>
        /// Ensures that a parameter value is not out of range,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The parameter value.</param>
        /// <param name="name">Name of the parameter.</param>
        /// <param name="range">The range in which the parameter value should be.</param>
        /// <param name="message">The exception message.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when the value is out of range.</exception>
        public static void ArgumentInRange(float value, string name, ArgumentRange range, string message)
        {
            if (!range.ValueInRange(value))
            {
                throw new ArgumentOutOfRangeException(name, message);
            }
        }

        /// <summary>
        /// Ensures that a parameter value is not out of range,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The parameter value.</param>
        /// <param name="name">Name of the parameter.</param>
        /// <param name="range">The range in which the parameter value should be.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when the value is out of range.</exception>
        public static void ArgumentInRange(double value, string name, ArgumentRange range)
        {
            if (!range.ValueInRange(value))
            {
                throw new ArgumentOutOfRangeException(name);
            }
        }

        /// <summary>
        /// Ensures that a parameter value is not out of range,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The parameter value.</param>
        /// <param name="name">Name of the parameter.</param>
        /// <param name="range">The range in which the parameter value should be.</param>
        /// <param name="message">The exception message.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when the value is out of range.</exception>
        public static void ArgumentInRange(double value, string name, ArgumentRange range, string message)
        {
            if (!range.ValueInRange(value))
            {
                throw new ArgumentOutOfRangeException(name, message);
            }
        }

        /// <summary>
        /// Ensures that a parameter value is not out of range,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The parameter value.</param>
        /// <param name="name">Name of the parameter.</param>
        /// <param name="range">The range in which the parameter value should be.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when the value is out of range.</exception>
        public static void ArgumentInRange(decimal value, string name, ArgumentRange range)
        {
            if (!range.ValueInRange(value))
            {
                throw new ArgumentOutOfRangeException(name);
            }
        }

        /// <summary>
        /// Ensures that a parameter value is not out of range,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The parameter value.</param>
        /// <param name="name">Name of the parameter.</param>
        /// <param name="range">The range in which the parameter value should be.</param>
        /// <param name="message">The exception message.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when the value is out of range.</exception>
        public static void ArgumentInRange(decimal value, string name, ArgumentRange range, string message)
        {
            if (!range.ValueInRange(value))
            {
                throw new ArgumentOutOfRangeException(name, message);
            }
        }
    }
}
