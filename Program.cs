using System.IO;

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
            loginForm mainPage = new loginForm();
            Application.Run(mainPage);



            // Release memory
            DirectoryInfo di = new DirectoryInfo(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, @"temp/homepage"));
            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            di = new DirectoryInfo(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, @"temp/personal"));
            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
        }


    }
}