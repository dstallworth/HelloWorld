using HelloWorld.Business.Implementation;
using HelloWorld.Data.Implementation;
using System;
using System.Configuration;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorldService service = new HelloWorldService(new HelloWorldRepository());
            string location = ConfigurationManager.AppSettings["WriteLocation"];
            Console.WriteLine(service.writeHelloWorld(location));
            Console.ReadLine();
        }
    }
}
