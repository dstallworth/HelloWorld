using HelloWorld.Business;
using HelloWorld.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Business.Implementation
{
    public class HelloWorldService : IHelloWorldService
    {
        IHelloWorldRepository _repo;

        public HelloWorldService(IHelloWorldRepository repo)
        {
            _repo = repo;
        }

        public string writeHelloWorld(string location)
        {
            if (location.Equals("Screen"))
            {
                return _repo.getHelloWorld().text;
            }
            else
            {
                return _repo.writeHelloWorld();
            }
        }
    }
}
