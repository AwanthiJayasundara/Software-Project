using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Models
{
    public class Employee
    {
        public int Id   { get; set; }   
        public string Name    { get; set; } //in OOP objects have two types attributes and methods.here also for create attributes we use propeties 
        public string Address { get; set; }//Name and Address are two attributes of the employee
    }
}
