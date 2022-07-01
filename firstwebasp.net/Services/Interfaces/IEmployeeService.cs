using System.Collections.Generic;
using firstwebasp.net.Models;

namespace firstwebasp.net.Services.Interfaces
{
    public interface IEmployeeService
    {
        //Create
        void CreateEmployee(Employee employee);

        //Read
        Employee GetEmployee(int id);
        IEnumerable<Employee> GetEmployees();

        //Update
        void UpdateEmployee(Employee employee);

        // Delete
        bool DeleteEmployee(int id);

    }
}