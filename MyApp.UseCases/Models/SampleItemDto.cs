namespace MyApp.UseCases.Models
{
    /// <summary>
    /// Represents a data transfer object for presenting <c>SampleItem</c> data in the UI.
    /// </summary>
    public class SampleItemDto
    {
        /// <summary>
        /// Gets or sets the identifier of the sample item.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the display name of the sample item.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the sample item.
        /// </summary>
        public string Description { get; set; }
    }
}
