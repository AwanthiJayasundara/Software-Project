using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeManagementSystem.Controllers
{
    [Route("api/[controller]")] //api/employee
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        List<Employee> Databse = new List<Employee>();//in html tab put api/Employee to get values from database
        
        public EmployeeController()
        {
            Databse.Add(new Employee { Id= 1,   Name = "Name1", Address = "add1" });//now in the database have these values.it will show in api/Employee tab
            Databse.Add(new Employee { Id= 2,   Name = "Name1", Address = "add1" });//since id is an int do not want to put "" like we do in using string,to have a better output install plugging jason formatter from chrome
        }

        // GET: api/<EmployeeController>
        [HttpGet]// a get method
                 //returning the all of the data
                 //public IEnumerable<string> Get()
        public IEnumerable<Employee> Get()
        {
            //return new string[] { "value1", "value2" };//in htmt tab put api/Employee ,then value1 and 2 appear
        return Databse;
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public Employee Get(int id) //when we type in html page api/Employee/1 (even if we  type 2)this will be give us the list of  id 1.in above case Get(nothing) so when Employee calling returning databse
        {
            return new Employee { Id = 1, Name = "Name1", Address = "add1" };
            //return "value";//if we put api/Employee/1 then this return value apear
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
