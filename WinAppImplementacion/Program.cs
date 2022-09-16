namespace WinAppImplementacion
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
            //Application.Run(new TareaClase1());
            //Application.Run(new TareaClase2());
            //Application.Run(new TareaClase3());
            Application.Run(new Main());

        }
    }
}