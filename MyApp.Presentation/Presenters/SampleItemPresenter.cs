using MyApp.Presentation.Views.Interfaces;
using MyApp.UseCases.UseCase.Interfaces;

namespace MyApp.Presentation.Presenters
{
    /// <summary>
    /// Coordinates the sample item view with the use case in the MVP flow.
    /// </summary>
    public class SampleItemPresenter
    {
        private readonly ISampleItemView _view;
        private readonly IGetSampleItemsUseCase _getSampleItemsUseCase;

        /// <summary>
        /// Initializes a new instance of the <see cref="SampleItemPresenter"/> class.
        /// </summary>
        /// <param name="view">The view to update.</param>
        /// <param name="getSampleItemsUseCase">The use case that loads the data.</param>
        public SampleItemPresenter(ISampleItemView view, IGetSampleItemsUseCase getSampleItemsUseCase)
        {
            _view = view;
            _getSampleItemsUseCase = getSampleItemsUseCase;

            // Subscribe to view lifecycle events.
            _view.ViewLoaded += OnViewLoaded;
        }

        private void OnViewLoaded(object sender, System.EventArgs e)
        {
            // Fetch data from the use case and push it to the view.
            var items = _getSampleItemsUseCase.Execute();
            _view.DisplayItems(items);
        }
    }
}
