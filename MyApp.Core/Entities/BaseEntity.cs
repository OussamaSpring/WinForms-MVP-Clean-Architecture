using System;

namespace MyApp.Core.Entities
{
    /// <summary>
    /// Represents the base entity type for domain models.
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Gets or sets the unique identifier for the entity.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the entity was created.
        /// </summary>
        public DateTime CreatedOn { get; set; }
    }
}
