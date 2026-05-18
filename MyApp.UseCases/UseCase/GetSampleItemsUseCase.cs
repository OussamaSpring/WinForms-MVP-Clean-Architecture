using System.Collections.Generic;
using System.Linq;
using MyApp.Core.Interfaces.Repositories;
using MyApp.UseCases.Models;
using MyApp.UseCases.UseCase.Interfaces;

namespace MyApp.UseCases.UseCase
{
    /// <summary>
    /// Retrieves sample items from the repository and maps them to DTOs.
    /// </summary>
    public class GetSampleItemsUseCase : IGetSampleItemsUseCase
    {
        private readonly ISampleItemRepository _repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSampleItemsUseCase"/> class.
        /// </summary>
        /// <param name="repository">The repository used to read sample items.</param>
        public GetSampleItemsUseCase(ISampleItemRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Executes the use case by projecting domain entities into DTOs.
        /// </summary>
        /// <returns>A collection of DTOs ready for presentation.</returns>
        public IEnumerable<SampleItemDto> Execute()
        {
            // Map the domain entities into a shape that the UI can display.
            return _repository.GetAll()
                .Select(item => new SampleItemDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    Description = item.Description
                })
                .ToList();
        }
    }
}
