namespace OnionCrafter.Feature.PipelineBehavoirs.Validation.Options
{
    /// <summary>
    /// Represents the default options for a validation pipeline behavior.
    /// </summary>
    public class ValidationPipelineBehaviorOptions : IValidationPipelineBehavoirOptions
    {
        /// <summary>
        /// Gets or sets a value indicating whether to use a logger for the validation pipeline behavior.
        /// </summary>
        public bool UseLogger { get; set; }

        /// <summary>
        /// Gets or sets the name for the validation pipeline behavior.
        /// </summary>
        public string? SetName { get; set; }
    }
}