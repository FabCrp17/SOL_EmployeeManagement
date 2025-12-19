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
    public class D_departments
    {
        public DataTable List_Department()
        {
            SqlDataReader result;
            DataTable table = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Connection.createInstance().CreateConnection();
                SqlCommand command = new SqlCommand("SP_DEPARTMENT_LIST", SqlCon);
                command.CommandType = CommandType.StoredProcedure;

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
