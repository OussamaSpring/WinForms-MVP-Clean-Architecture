using System;
using System.Collections.Generic;
using System.Linq;
using MyApp.Core.Entities;
using MyApp.Core.Interfaces.Repositories;

namespace MyApp.Data.Repositories
{
    /// <summary>
    /// Provides an in-memory implementation of <see cref="ISampleItemRepository"/> for demos and tests.
    /// </summary>
    public class InMemorySampleItemRepository : ISampleItemRepository
    {
        private readonly List<SampleItem> _items = new List<SampleItem>
        {
            new SampleItem
            {
                Id = 1,
                Name = "Welcome Item",
                Description = "A seeded record to illustrate the template.",
                CreatedOn = DateTime.UtcNow
            }
        };

        /// <summary>
        /// Adds a new sample item to the in-memory list.
        /// </summary>
        /// <param name="entity">The item to add.</param>
        public void Add(SampleItem entity)
        {
            // Assign a new identifier if one was not provided.
            if (entity.Id == 0)
            {
                entity.Id = _items.Any() ? _items.Max(item => item.Id) + 1 : 1;
            }

            _items.Add(entity);
        }

        /// <summary>
        /// Updates an existing item by replacing it in the list.
        /// </summary>
        /// <param name="entity">The updated entity.</param>
        public void Update(SampleItem entity)
        {
            var existing = GetById(entity.Id);
            if (existing == null)
            {
                return;
            }

            existing.Name = entity.Name;
            existing.Description = entity.Description;
        }

        /// <summary>
        /// Removes an item from the list.
        /// </summary>
        /// <param name="entity">The item to remove.</param>
        public void Delete(SampleItem entity)
        {
            _items.RemoveAll(item => item.Id == entity.Id);
        }

        /// <summary>
        /// Retrieves an item by identifier.
        /// </summary>
        /// <param name="id">The identifier to look up.</param>
        /// <returns>The matching item or <c>null</c> if not found.</returns>
        public SampleItem GetById(int id)
        {
            return _items.FirstOrDefault(item => item.Id == id);
        }

        /// <summary>
        /// Retrieves all items in the store.
        /// </summary>
        /// <returns>A collection of sample items.</returns>
        public IEnumerable<SampleItem> GetAll()
        {
            return _items.ToList();
        }
    }
}
