namespace OnionCrafter.Feature.PipelineBehavoirs.Validation.Options
{
    /// <summary>
    /// Represents a default options for a cache pipeline behavior.
    /// </summary>
    public class ValidationPipelineBehavoirOptions : IValidationPipelineBehavoirOptions
    {
        public bool UseLogger { get; set; }
        public string? SetName { get; set; }
    }
}