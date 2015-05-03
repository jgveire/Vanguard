namespace Vanguard
{
    /// <summary>
    /// The in range validator. 
    /// Validates if the value is in the supplied range.
    /// </summary>
    internal class InRangeValidator : GuardValidator<long>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InRangeValidator"/> class.
        /// </summary>
        /// <param name="value">The value that is going to be validated.</param>
        /// <param name="minimum">The minimum value.</param>
        /// <param name="maximum">The maximum value.</param>
        public InRangeValidator(long value, long minimum, long maximum) 
            : base(value)
        {
            Minimum = minimum;
            Maximum = maximum;
        }

        /// <summary>
        /// Gets or sets the minimum value.
        /// </summary>
        public long Minimum { get; set; }

        /// <summary>
        /// Gets or sets the maximum value.
        /// </summary>
        public long Maximum { get; set; }

        /// <summary>
        /// Validates the value property.
        /// </summary>
        /// <returns>
        /// <c>true</c> when the value property is greater or equal to the minimum
        /// value and smaller or equal to the maximum value, otherwise <c>false</c>
        /// </returns>
        public override bool Validate()
        {
            return Value >= Minimum && Value <= Maximum;
        }
    }
}
