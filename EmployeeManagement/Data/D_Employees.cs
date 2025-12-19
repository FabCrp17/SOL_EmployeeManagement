using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}