using Owin;
using System;

namespace OwinConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            Console.ReadLine();
        }

        public class Startup {
            public void Configuration(IAppBuilder app) {
                //app.Run()
            }
        }
    }
}
