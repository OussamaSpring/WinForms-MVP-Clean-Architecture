using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MyApp.Presentation.Views.Interfaces;
using MyApp.UseCases.Models;

namespace MyApp.Presentation.Views.Forms
{
    /// <summary>
    /// Implements the sample item view using a WinForms list box.
    /// </summary>
    public class SampleItemForm : Form, ISampleItemView
    {
        private readonly ListBox _itemsList;

        /// <summary>
        /// Initializes a new instance of the <see cref="SampleItemForm"/> class.
        /// </summary>
        public SampleItemForm()
        {
            Text = "Sample Items";
            Width = 600;
            Height = 400;

            _itemsList = new ListBox
            {
                Dock = DockStyle.Fill
            };

            // Add the list box to the form's control collection.
            Controls.Add(_itemsList);

            Load += (sender, args) => ViewLoaded?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Raised when the view is ready to load data.
        /// </summary>
        public event EventHandler ViewLoaded;

        /// <summary>
        /// Displays the provided items in the list box.
        /// </summary>
        /// <param name="items">The items to display.</param>
        public void DisplayItems(IEnumerable<SampleItemDto> items)
        {
            // Convert the items to a display string for the list box.
            _itemsList.DataSource = items
                .Select(item => $"{item.Name} - {item.Description}")
                .ToList();
        }
    }
}
