using HelloWorld.Business;
using System.Web.Http;

namespace HelloWorld.Api.Implementation.Controllers
{
    public class HelloWorldController : ApiController
    {
        IHelloWorldService _service;

        public HelloWorldController(IHelloWorldService service)
        {
            _service = service;
        }

        // GET: api/student
        public string Get()
        {
            return _service.writeHelloWorld("DB");
        }
    }
}
