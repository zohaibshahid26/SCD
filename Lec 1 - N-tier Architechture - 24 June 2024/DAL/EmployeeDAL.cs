using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.IO;
namespace DAL
{
    public class EmployeeDAL
    {
        public void Save(EmployeeDTO employeeDTO) { 
        
            StreamWriter    sw = new StreamWriter("data.txt", append: true);
            sw.WriteLine(employeeDTO.Name+","+employeeDTO.Salary+","+employeeDTO.Tax);
            sw.Close();
        }
    }
}
