using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1App.Models;

namespace Task1App
{
    public class DataManager
    {
        List<Employee> employees = new List<Employee>();

        public void AddEmployee(int id, string name, string phone, double salary, int age)
        {
            Employee employee = new Employee { 
                                                Id = id,
                                                Name = name,
                                                Phone = phone,
                                                Salary = salary,
                                                Age = age 
                                              };
            employees.Add(employee);
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }
    }
}
