using EmployeeModule.Interfaces;
using EmployeeModule.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeModule.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IMongoCollection<Employee> employee;

        public EmployeeService(IDbConfiguration settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            employee = database.GetCollection<Employee>("Employees");
        }
        public Employee Create(Employee submission)
        {
            employee.InsertOne(submission);
            return submission;
        }
        public IList<Employee> GetAll() =>
            employee.Find(sub => true).ToList();

        public void Update(Employee emp)
        {
            employee.ReplaceOne(sub => sub.Id == emp.Id, emp);
        }

        public void Delete(string id)
        {
            employee.DeleteOne(sub => sub.Id == id);
        }
    }
}
