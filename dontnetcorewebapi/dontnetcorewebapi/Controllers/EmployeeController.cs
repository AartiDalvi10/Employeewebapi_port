using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using dontnetcorewebapi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dontnetcorewebapi.Controllers
{

    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        EmployeeDataAccessLayer objemployee = new EmployeeDataAccessLayer();

        [HttpGet]
        public IEnumerable<Employee> Employee()
        {
            List<Employee> lstEmployee = new List<Employee>();
            lstEmployee = objemployee.GetAllEmployees().ToList();

            return lstEmployee;
        }      
       

       
        [HttpPost]
        public IActionResult Post([FromBody]Employee b)
        {
            objemployee.AddEmployee(b);
            return Ok();
        }

    }
}