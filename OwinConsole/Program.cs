using Microsoft.Owin.Hosting;
using Owin;
using System;

namespace OwinConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string uri = "http://localhost:8089";
            using (WebApp.Start<Startup>(uri))
            {
                Console.WriteLine("Started");
                Console.ReadKey();
                Console.WriteLine("Stopping..");
            }
        }

        public class Startup {
            public void Configuration(IAppBuilder app) {

                app.UseWelcomePage();

                //app.Run(owincontext =>
                //{
                //    return owincontext.Response.WriteAsync("Hello World!");
                //});
            }
        }
    }
}
