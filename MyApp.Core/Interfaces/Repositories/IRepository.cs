
using System.Collections.Generic;

namespace MyApp.Core.Interfaces.Repositories
{
    /// <summary>
    /// Defines write and read operations for a repository that manages entities.
    /// </summary>
    /// <typeparam name="T">The entity type managed by the repository.</typeparam>
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Adds a new entity to the repository.
        /// </summary>
        /// <param name="entity">The entity to add.</param>
        void Add(T entity);

        /// <summary>
        /// Updates an existing entity in the repository.
        /// </summary>
        /// <param name="entity">The entity to update.</param>
        void Update(T entity);

        /// <summary>
        /// Deletes an entity from the repository.
        /// </summary>
        /// <param name="entity">The entity to delete.</param>
        void Delete(T entity);

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
