namespace Vanguard
{
    /// <summary>
    /// The string not null or empty validator. 
    /// Validates if the value is not null or empty.
    /// </summary>
    internal class StringNotNullOrEmptyValidator : GuardValidator<string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StringNotNullOrEmptyValidator"/> class.
        /// </summary>
        /// <param name="value">The string that is going to be validated.</param>
        public StringNotNullOrEmptyValidator(string value) 
            : base(value)
        {
        }

        /// <summary>
        /// Validates the value property.
        /// </summary>
        /// <returns><c>true</c> when the value property is not null or empty, otherwise <c>false</c></returns>
        public override bool Validate()
        {
            return !string.IsNullOrEmpty(Value);
        }
    }
}
