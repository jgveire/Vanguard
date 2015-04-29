namespace Vanguard
{
    /// <summary>
    /// The argument range struct.
    /// </summary>
    public struct ArgumentRange
    {
        /// <summary>
        /// The minimum value of an argument.
        /// </summary>
        public readonly long Minimum;

        /// <summary>
        /// The maximum value of an argument.
        /// </summary>
        public readonly long Maximum;

        /// <summary>
        /// Initializes a new instance of the <see cref="ArgumentRange"/> struct.
        /// </summary>
        /// <param name="minimum">The minimum value of an argument.</param>
        /// <param name="maximum">The maximum value of an argument.</param>
        public ArgumentRange(byte minimum, byte maximum)
        {
            Minimum = minimum;
            Maximum = maximum;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArgumentRange"/> struct.
        /// </summary>
        /// <param name="minimum">The minimum value of an argument.</param>
        /// <param name="maximum">The maximum value of an argument.</param>
        public ArgumentRange(short minimum, short maximum)
        {
            Minimum = minimum;
            Maximum = maximum;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArgumentRange"/> struct.
        /// </summary>
        /// <param name="minimum">The minimum value of an argument.</param>
        /// <param name="maximum">The maximum value of an argument.</param>
        public ArgumentRange(int minimum, int maximum)
        {
            Minimum = minimum;
            Maximum = maximum;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArgumentRange"/> struct.
        /// </summary>
        /// <param name="minimum">The minimum value of an argument.</param>
        /// <param name="maximum">The maximum value of an argument.</param>
        public ArgumentRange(long minimum, long maximum)
        {
            Minimum = minimum;
            Maximum = maximum;
        }

        /// <summary>
        /// Returns an indication whether the values of two specified <see cref="ArgumentRange"/> structs
        /// are not equal.
        /// </summary>
        /// <param name="a">The first <see cref="ArgumentRange"/> to compare.</param>
        /// <param name="b">The second <see cref="ArgumentRange"/> to compare.</param>
        /// <returns>
        /// <c>true</c> if a and b are not equal; otherwise, <c>false</c>.
        /// </returns>
        public static bool operator !=(ArgumentRange a, ArgumentRange b)
        {
            return a.Minimum != b.Minimum || a.Maximum != b.Maximum;
        }
        
        /// <summary>
        /// Returns an indication whether the values of two specified <see cref="ArgumentRange"/> structs
        /// are equal.
        /// </summary>
        /// <param name="a">The first <see cref="ArgumentRange"/> to compare.</param>
        /// <param name="b">The second <see cref="ArgumentRange"/> to compare.</param>
        /// <returns>
        /// true if a and b are equal; otherwise, false.
        /// </returns>
        public static bool operator ==(ArgumentRange a, ArgumentRange b)
        {
            return a.Minimum == b.Minimum && a.Maximum == b.Maximum;
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            // If parameter is null return false.
            if (obj == null)
            {
                return false;
            }

            // If parameter cannot be cast to ArgumentRange return false.
            if (!(obj is ArgumentRange))
            {
                return false;
            }

            // Return true if the fields match:
            ArgumentRange range = (ArgumentRange)obj;
            return Minimum == range.Minimum && Maximum == range.Maximum;
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
            return Minimum.GetHashCode() ^ Maximum.GetHashCode();
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return string.Format("{0} - {1}", Minimum, Maximum);
        }

        /// <summary>
        /// Determines if the supplied value is in the range.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// <c>true</c> if the supplied value is in the range, otherwise <c>false</c>.
        /// </returns>
        public bool ValueInRange(byte value)
        {
            return InternalValueInRange(value);
        }

        /// <summary>
        /// Determines if the supplied value is in the range.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// <c>true</c> if the supplied value is in the range, otherwise <c>false</c>.
        /// </returns>
        public bool ValueInRange(short value)
        {
            return InternalValueInRange(value);
        }

        /// <summary>
        /// Determines if the supplied value is in the range.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// <c>true</c> if the supplied value is in the range, otherwise <c>false</c>.
        /// </returns>
        public bool ValueInRange(int value)
        {
            return InternalValueInRange(value);
        }

        /// <summary>
        /// Determines if the supplied value is in the range.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// <c>true</c> if the supplied value is in the range, otherwise <c>false</c>.
        /// </returns>
        public bool ValueInRange(long value)
        {
            return InternalValueInRange(value);
        }

        /// <summary>
        /// Determines if the supplied value is in the range.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// <c>true</c> if the supplied value is in the range, otherwise <c>false</c>.
        /// </returns>
        private bool InternalValueInRange(long value)
        {
            return value >= Minimum && value <= Maximum;
        }
    }
}
