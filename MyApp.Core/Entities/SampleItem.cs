namespace MyApp.Core.Entities
{
    /// <summary>
    /// Represents a sample domain entity used to demonstrate the template structure.
    /// </summary>
    public class SampleItem : BaseEntity
    {
        /// <summary>
        /// Gets or sets the display name for the sample item.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the sample item.
        /// </summary>
        public string Description { get; set; }
    }
}
