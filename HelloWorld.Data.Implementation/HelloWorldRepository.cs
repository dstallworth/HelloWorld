using HelloWorld.Data;
using HelloWorld.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Data.Implementation
{
    public class HelloWorldRepository : IHelloWorldRepository
    {
        public HelloWorldModel getHelloWorld()
        {
            return new HelloWorldModel { text = "Hello World" };
        }

        public string writeHelloWorld()
        {
            return "Hello World Written to Database";
        }
    }
}
