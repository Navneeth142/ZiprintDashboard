using BlazorAssignment.Models;

namespace BlazorAssignment.Services
{
    // Employee serverice
    public class EmployeeService
    {
        private readonly List<EmployeeModel> employees = new()
        {
            new EmployeeModel
            {
                EmployeeId = "A861",
                EmployeeName = "Kare Gowda",
                EmployeeRole = "Manager",
                PhoneNumber = "9686552083",
                Email = "karegowda@chamundidiecast.com",
                PlantId = "UDC U-3",
                DateOfJoining = new DateTime(2026, 1, 21),
                Password = "abcd$1234",
                IsActive = true
            },
            new EmployeeModel
            {
                EmployeeId = "A862",
                EmployeeName = "Navneeth",
                EmployeeRole = "Software Engineer",
                PhoneNumber = "7989399489",
                Email = "navneeth3064@gmail.com",
                PlantId = "UDC U-3",
                DateOfJoining = new DateTime(2015, 1, 22),
                Password = "abcd$1234",
                IsActive = true
            }
        };

        /* ---------- READ ---------- */

        public List<string> GetEmployeeIds()
        {
            return employees
                .Select(e => e.EmployeeId)
                .OrderBy(id => id)
                .ToList();
        }

        public EmployeeModel? GetEmployeeById(string employeeId)
        {
            return employees.FirstOrDefault(e => e.EmployeeId == employeeId);
        }

        public List<EmployeeModel> GetAllEmployees()
        {
            return employees.ToList();
        }

        /* ---------- WRITE ---------- */

        public bool AddEmployee(EmployeeModel employee)
        {
            if (employees.Any(e => e.EmployeeId == employee.EmployeeId))
            {
                return false; // duplicate ID
            }

            employees.Add(employee);
            return true;
        }

        public void DeleteEmployee(string employeeId)
        {
            var employee = employees.FirstOrDefault(e => e.EmployeeId == employeeId);
            if (employee != null)
            {
                employees.Remove(employee);
            }
        }
    }
}
