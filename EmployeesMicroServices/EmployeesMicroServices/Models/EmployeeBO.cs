namespace EmployeesMicroServices.Models
{
    public class EmployeeBO
    {
        public List<EmployeeModel> Employees { get; set; }
        public EmployeeBO() => Employees = EmployeeDAL.GetEmployeesBySql();
        public List<EmployeeModel> GetAllEmployees() => Employees;
        public EmployeeModel GetEmployeeByid(int id) => Employees.Single(x => x.Id == id);
        public void AddEmployee(EmployeeModel emp) => Employees.Add(emp);
        public void EditEmployeeById(EmployeeModel emp, int id) => Employees[Employees.FindIndex(x => x.Id == id)] = emp;
        public void DeleteEmployeeById(int id) => Employees.RemoveAt(Employees.FindIndex(x => x.Id == id));
    }
}
