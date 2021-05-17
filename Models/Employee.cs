using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeModule.Models
{
    public class Employee
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
    }
}
