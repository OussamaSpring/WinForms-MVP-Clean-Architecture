using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace MyApp.Presentation
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            var provider = ServiceConfigurator.Configure();
            var presenter = provider.GetRequiredService<Presenters.SampleItemPresenter>();
            var form = provider.GetRequiredService<Views.Forms.SampleItemForm>();

            // Run the main form after the presenter is initialized.
            Application.Run(form);
        }
    }
}
