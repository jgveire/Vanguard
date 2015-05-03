namespace Vanguard
{
    /// <summary>
    /// The base guard validator class.
    /// </summary>
    internal abstract class GuardValidator
    {
        /// <summary>
        /// Validates this instance.
        /// </summary>
        /// <returns><c>true</c> when the class is in a valid state, otherwise <c>false</c></returns>
        public abstract bool Validate();
    }
}
