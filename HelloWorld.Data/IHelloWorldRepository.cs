using HelloWorld.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Data
{
    public interface IHelloWorldRepository
    {
        HelloWorldModel getHelloWorld();
        string writeHelloWorld();
    }
}
