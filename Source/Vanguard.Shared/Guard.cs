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
            ArgumentNotNullOrEmpty(value, name, null);
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
            ArgumentNotNullOrEmpty(value, name, null);
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
        public static void ArgumentInRange(long value, string name, ArgumentRange range)
        {
            ArgumentInRange(value, name, range, null);
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
        /// Ensures that a parameter value is not null,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The parameter value.</param>
        /// <exception cref="Vanguard.GuardNullException">Thrown when the value is null.</exception>
        public static void IsNotNull(object value)
        {
            IsNotNull(value, null);
        }

        /// <summary>
        /// Ensures that a parameter value is not null,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The parameter value.</param>
        /// <param name="message">The exception message.</param>
        /// <exception cref="Vanguard.GuardNullException">Thrown when the value is null.</exception>
        public static void IsNotNull(object value, string message)
        {
            if (value == null)
            {
                throw new GuardNullException(message);
            }
        }

        /// <summary>
        /// Ensures that a parameter value is not null or empty,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The parameter value.</param>
        /// <exception cref="Vanguard.GuardNullException">Thrown when the value is null.</exception>
        /// <exception cref="Vanguard.GuardEmptyException">Thrown when the value contains an empty string.</exception>
        public static void IsNotNullOrEmpty(string value)
        {
            IsNotNullOrEmpty(value, null);
        }

        /// <summary>
        /// Ensures that a parameter value is not null or empty,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The parameter value.</param>
        /// <param name="message">The exception message.</param>
        /// <exception cref="Vanguard.GuardNullException">Thrown when the value is null.</exception>
        /// <exception cref="Vanguard.GuardEmptyException">Thrown when the value contains an empty string.</exception>
        public static void IsNotNullOrEmpty(string value, string message)
        {
            IsNotNull(value, message);
            if (string.IsNullOrEmpty(value))
            {
                throw new GuardEmptyException(message);
            }
        }

        /// <summary>
        /// Ensures that a parameter value is not null or empty,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The parameter value.</param>
        /// <exception cref="Vanguard.GuardNullException">Thrown when the value is null.</exception>
        /// <exception cref="Vanguard.GuardEmptyException">Thrown when the value contains an empty Guid.</exception>
        public static void IsNotNullOrEmpty(Guid? value)
        {
            IsNotNullOrEmpty(value, null);
        }

        /// <summary>
        /// Ensures that a parameter value is not null or empty,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The parameter value.</param>
        /// <param name="message">The exception message.</param>
        /// <exception cref="Vanguard.GuardNullException">Thrown when the value is null.</exception>
        /// <exception cref="Vanguard.GuardEmptyException">Thrown when the value contains an empty Guid.</exception>
        public static void IsNotNullOrEmpty(Guid? value, string message)
        {
            IsNotNull(value, message);
            if (value == Guid.Empty)
            {
                throw new GuardEmptyException(message);
            }
        }

        /// <summary>
        /// Ensures that a parameter value is not out of range,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The parameter value.</param>
        /// <param name="range">The range in which the parameter value should be.</param>
        /// <exception cref="Vanguard.GuardOutOfRangeException">Thrown when the value is out of range.</exception>
        public static void IsInRange(long value, ArgumentRange range)
        {
            IsInRange(value, range, null);
        }

        /// <summary>
        /// Ensures that a parameter value is not out of range,
        /// otherwise an exception is thrown.
        /// </summary>
        /// <param name="value">The parameter value.</param>
        /// <param name="range">The range in which the parameter value should be.</param>
        /// <param name="message">The exception message.</param>
        /// <exception cref="Vanguard.GuardOutOfRangeException">Thrown when the value is out of range.</exception>
        public static void IsInRange(long value, ArgumentRange range, string message)
        {
            if (!range.ValueInRange(value))
            {
                throw new GuardOutOfRangeException(message);
            }
        }
    }
}
