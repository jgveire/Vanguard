namespace Vanguard
{
    /// <summary>
    /// The not null validator. 
    /// Validates if the value is not null.
    /// </summary>
    internal class NotNullValidator : GuardValidator<object>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotNullValidator"/> class.
        /// </summary>
        /// <param name="value">The value that is going to be validated.</param>
        public NotNullValidator(object value) 
            : base(value)
        {
        }

        /// <summary>
        /// Validates the value property.
        /// </summary>
        /// <returns><c>true</c> when the value property is not null, otherwise <c>false</c></returns>
        public override bool Validate()
        {
            return Value != null;
        }
    }
}
