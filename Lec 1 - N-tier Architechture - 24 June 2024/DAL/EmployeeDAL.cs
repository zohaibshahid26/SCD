using DTO;
namespace DAL
{
    public class EmployeeDAL
    {
        public void Save(EmployeeDTO employeeDTO) { 
        
            StreamWriter    sw = new StreamWriter("data.txt", append: true);
            sw.WriteLine(employeeDTO.Name+","+employeeDTO.Salary+","+employeeDTO.Tax);
            sw.Close();
        }
        public List<EmployeeDTO> GetEmployees() {
            List<EmployeeDTO> employees = new List<EmployeeDTO>();
            StreamReader sr = new StreamReader("data.txt");
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                EmployeeDTO employee = new EmployeeDTO();
                employee.Name = parts[0];
                employee.Salary = decimal.Parse(parts[1]);
                employee.Tax = decimal.Parse(parts[2]);
                employees.Add(employee);
            }
            sr.Close();
            return employees;
        }
    }
}
