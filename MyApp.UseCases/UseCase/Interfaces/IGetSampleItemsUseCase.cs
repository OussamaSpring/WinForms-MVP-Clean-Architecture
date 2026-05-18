using System.Collections.Generic;
using MyApp.UseCases.Models;

namespace MyApp.UseCases.UseCase.Interfaces
{
    /// <summary>
    /// Defines a use case for retrieving sample items for presentation.
    /// </summary>
    public interface IGetSampleItemsUseCase
    {
        /// <summary>
        /// Executes the use case and returns sample item data for the UI.
        /// </summary>
        /// <returns>A collection of <see cref="SampleItemDto"/> instances.</returns>
        IEnumerable<SampleItemDto> Execute();
    }
}
