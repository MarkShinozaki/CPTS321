namespace Authentication
{
    /// <summary>
    /// The main entry point for the application.
    /// This class contains the Main method which initializes the application and starts the main form.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The Main method is the entry point of the application. 
        /// It sets up the application environment and runs the main form.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Initializes the application's configuration settings
            ApplicationConfiguration.Initialize();
            // Creates and runs the main form of the application
            Application.Run(new Form1());
        }
    }
}