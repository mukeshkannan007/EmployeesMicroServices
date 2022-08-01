using System.Data.SqlClient;

namespace EmployeesMicroServices.Models
{
    public class EmployeeDAL
    {
        static SqlConnection cn;
        static SqlConnection ConnectToSql()
        {
            cn = new SqlConnection("server=DESKTOP-DM30GHJ;user id=sa;password=welcome;database=EmpDB");
            cn.Open();
            return cn;
        }
        public static List<EmployeeModel> GetEmployeesBySql()
        {
            List<EmployeeModel> employees = new List<EmployeeModel>();
            SqlCommand cmd = new SqlCommand("Select * From tblEmployees", ConnectToSql());
            SqlDataReader dr = cmd.ExecuteReader();
            EmployeeModel emp;
            while (dr.Read())
            {
                emp = new EmployeeModel();
                emp.Id = Convert.ToInt32(dr[0]);
                emp.EName = dr[1].ToString();
                emp.Job = dr[2].ToString();
                emp.Salary = Convert.ToInt32(dr[3]);
                employees.Add(emp);
            }
            return employees;
        }
    }
}
