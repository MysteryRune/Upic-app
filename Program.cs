namespace Upic
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
            homepageForm mainPage = new homepageForm();
            Application.Run(mainPage);
            mainPage.Dispose();
            GC.Collect();
            GC.Collect();
            GC.Collect();
            DirectoryInfo di = new DirectoryInfo(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, @"temp/homepage"));
            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            //mainPage.releaseMemory();

        }


    }
}