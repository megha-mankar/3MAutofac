using System;
using System.Collections.Generic;
using System.Linq;


namespace AutfacDemo.BL
{
    public class EmployeeController : IEmployee
    {
        public Employee GetEmployee(int id)
        {
            var empList = CreateEmployee();
            return empList.FirstOrDefault(x => x.Id == id);
        }


        private static List<Employee> CreateEmployee()
        {
            return new List<Employee>()
        {
            new Employee() { Id =1, FirstName = "Vishal", LastName = "Deshpande"},
            new Employee() { Id = 2, FirstName =" Ravindra", LastName = "Ugale"},
            new Employee(){ Id = 3, FirstName = "Megha", LastName = "Mankar"}
         };
        }
    }
}
