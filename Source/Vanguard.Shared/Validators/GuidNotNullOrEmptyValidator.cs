using System;

namespace Vanguard
{
    /// <summary>
    /// The <see cref="System.Guid"/> not null or empty validator. 
    /// Validates if the value is not null or empty.
    /// </summary>
    internal class GuidNotNullOrEmptyValidator : GuardValidator<Guid?>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GuidNotNullOrEmptyValidator"/> class.
        /// </summary>
        /// <param name="value">The <see cref="System.Guid"/> that is going to be validated.</param>
        public GuidNotNullOrEmptyValidator(Guid? value) 
            : base(value)
        {
        }

        /// <summary>
        /// Validates the value property.
        /// </summary>
        /// <returns><c>true</c> when the value property is not null or empty, otherwise <c>false</c></returns>
        public override bool Validate()
        {
            return Value != null && Value != Guid.Empty;
        }
    }
}
