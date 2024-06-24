using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class EmployeeBLL
    {
        public void Save(EmployeeDTO employee) { 
        
            employee.Tax= CalcuateTax(employee.Salary);
           EmployeeDAL employeeDAL = new EmployeeDAL();
            employeeDAL.Save(employee);
        
        }

        private decimal CalcuateTax(decimal salary)
        { 
        return salary*.20M;
        }
    }
}
