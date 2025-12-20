using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeManagement.Entities;

namespace EmployeeManagement.Data
{
    public class D_Employees
    {
        public DataTable List_Employyes(string cSearch)
        {
            SqlDataReader result;
            DataTable table = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Connection.createInstance().CreateConnection();
                SqlCommand command = new SqlCommand("SP_LIST_EMPLOYEES", SqlCon);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@cSearch", SqlDbType.VarChar).Value = cSearch;
                SqlCon.Open();

                result = command.ExecuteReader();
                table.Load(result);

                return table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
                {

                }
            }
        }

        public string Save_Employee(E_Employee Employee)
        {
            string answer = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Connection.createInstance().CreateConnection();
                SqlCommand command = new SqlCommand("SP_SAVE_EMPLOYEES", SqlCon);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@cName", SqlDbType.VarChar).Value = Employee.employee_name;
                command.Parameters.Add("@cAddress", SqlDbType.VarChar).Value = Employee.employee_address;
                command.Parameters.Add("@dBirthDate", SqlDbType.Date).Value = Employee.employee_bithdate;
                command.Parameters.Add("@cPhoneNumber", SqlDbType.VarChar).Value = Employee.employee_phone_number;
                command.Parameters.Add("@nSalary", SqlDbType.Money).Value = Employee.employe_salary;
                command.Parameters.Add("@nIdDepartment", SqlDbType.Int).Value = Employee.id_department;
                command.Parameters.Add("@nIdPosition", SqlDbType.Int).Value = Employee.id_position;

                SqlCon.Open();

                answer = command.ExecuteNonQuery() >= 1 ? "OK" : "Los Datos No Se Pudieron Registrar";


            }
            catch (Exception ex)
            {

                answer= ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return answer;
        }
    }
}