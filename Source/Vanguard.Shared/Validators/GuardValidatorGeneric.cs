namespace Vanguard
{
    /// <summary>
    /// The base guard validator class.
    /// </summary>
    /// <typeparam name="TValue">The type of the value that is going to be validated.</typeparam>
    internal abstract class GuardValidator<TValue> : GuardValidator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GuardValidator{TValue}"/> class.
        /// </summary>
        /// <param name="value">The value that is going to be validated.</param>
        protected GuardValidator(TValue value)
        {
            Value = value;
        }

        /// <summary>
        /// Gets or sets the value that is going to be validated.
        /// </summary>
        public TValue Value { get; set; }
    }
}
