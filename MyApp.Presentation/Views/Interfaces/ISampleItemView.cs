using System;
using System.Collections.Generic;
using MyApp.UseCases.Models;

namespace MyApp.Presentation.Views.Interfaces
{
    /// <summary>
    /// Defines the view contract for displaying sample items in MVP.
    /// </summary>
    public interface ISampleItemView
    {
        /// <summary>
        /// Raised when the view is ready to load data.
        /// </summary>
        event EventHandler ViewLoaded;

        /// <summary>
        /// Displays the provided items in the UI.
        /// </summary>
        /// <param name="items">The items to display.</param>
        void DisplayItems(IEnumerable<SampleItemDto> items);
    }
}
