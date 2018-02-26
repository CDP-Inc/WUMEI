using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace WUMEI
{
    /// <summary>
    /// Class handling main execution of the application.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point for the application which builds and runs the ASP.NET Core web host.
        /// </summary>
        /// <param name="args">Command line arguments.</param>
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        /// <summary>
        /// Help method for building the ASP.NET Core web host.
        /// </summary>
        /// <param name="args">Command line arguments.</param>
        /// <returns>Returns the initialized web host builder.</returns>
        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
