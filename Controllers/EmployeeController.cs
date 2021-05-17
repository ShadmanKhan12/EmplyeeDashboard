using EmployeeModule.Interfaces;
using EmployeeModule.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeModule.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService empService;
        public EmployeeController(IEmployeeService employeeService)
        {
            empService = employeeService;
        }
        // GET: api/<EmployeeController>
        [HttpGet]
        public IList<Employee> Get()
        {
            var employees = empService.GetAll();
            return employees;
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] Employee employee)
        {
            empService.Create(employee);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut]
        public void Put([FromBody] Employee employee)
        {
            empService.Update(employee);
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete]
        public void Delete([FromBody] Employee employee)
        {
            empService.Delete(employee);
        }
    }
}
