using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using BLL;

namespace PL
{
    public class EmployeePL
    {
        public void InputEmployee() {
            Console.WriteLine("Enter your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            string salary = Console.ReadLine();
        
            EmployeeDTO employee = new EmployeeDTO();
            employee.Name = name;
            employee.Salary = decimal.Parse( salary);
            EmployeeBLL employeeBLL = new EmployeeBLL();
            employeeBLL.Save(employee);
        }
        public void DisplayEmployees() {
            EmployeeBLL employeeBLL = new EmployeeBLL();
            List<EmployeeDTO> employees = employeeBLL.GetEmployees();
            foreach (EmployeeDTO employee in employees) {
                Console.WriteLine("Name: "+employee.Name);
                Console.WriteLine("Salary: "+employee.Salary);
                Console.WriteLine("Tax: "+employee.Tax);
            }
        }
    }
}
