using Microsoft.AspNetCore.Mvc;
using career.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace career.Controllers  //namespace declaration.Defines a namespace career.Controllers where the studentController class resides.
{

    
    [Route("api/[controller]")]  //controller attribute //Specifies that the controller will handle requests with URLs starting with /api/student (where [controller] is replaced with the controller name, in this case, student).
    [ApiController]  //controller attribute // Indicates that the controller is an API controller and enables behavior such as automatic model validation and binding of request body data.

    public class studentController : ControllerBase  //controller class definition.Defines a class named studentController that inherits from ControllerBase, which is a base class provided by ASP.NET Core for creating Web API controllers.
    {

        StudentDB dbobj = new StudentDB();
        // GET: api/<studentController> //get() //handles HTTP GET requests to the /api/student route. It returns an IEnumerable<string> containing two sample values.

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<studentController>/5  //get(int id) //handles HTTP GET requests to the /api/student/{id} route. It takes an integer id parameter and returns a string value.

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<studentController> // It takes a string value from the request body.

        [HttpPost]  //to add a new record
        public void Post([FromBody] Student objcls)
        {
            dbobj.InsertDB(objcls);
            
        }

        // PUT api/<studentController>/5 //It takes an integer id parameter and a string value from the request body.

        [HttpPut("{id}")]  // to update a record
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<studentController>/5 //Represents an action method that handles HTTP DELETE requests to the /api/student/{id} route. It takes an integer id parameter.

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}







//http method attributes: httpget,httppost,httpput,httpdelete
//This controller provides basic CRUD (Create, Read, Update, Delete) operations for a resource named "student".
//Controllers handle incoming HTTP requests and provide appropriate responses.
//models folder typically contains the data models or classes that represent the structure of data used within the application.
//Program.cs: This file contains the entry point of the application. It configures the web host and sets up services required by the application.
//NuGet is a package manager for .NET that facilitates the process of finding, installing, and managing third-party libraries and tools in your .NET projects
//RESTful principles, which stand for Representational State Transfer, are a set of architectural guidelines for designing networked applications, particularly web services.