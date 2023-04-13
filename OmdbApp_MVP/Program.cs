using OmdbApp_MVP.View;

namespace OmdbApp_MVP
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var view = new OmdbViewForm();
            var presenter = new Presenter(view);
            Application.Run(view);
        }
    }
}