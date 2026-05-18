using System.Collections.Generic;

namespace MyApp.Core.Interfaces.Repositories
{
    /// <summary>
    /// Defines read-only operations for a repository that manages entities.
    /// </summary>
    /// <typeparam name="T">The entity type managed by the repository.</typeparam>
    public interface IReadOnlyRepository<T> where T : class
    {
        /// <summary>
        /// Retrieves an entity by its identifier.
        /// </summary>
        /// <param name="id">The identifier of the entity.</param>
        /// <returns>The matching entity, or <c>null</c> if none is found.</returns>
        T GetById(int id);

        /// <summary>
        /// Retrieves all entities managed by the repository.
        /// </summary>
        /// <returns>An enumerable collection of entities.</returns>
        IEnumerable<T> GetAll();
    }
}
