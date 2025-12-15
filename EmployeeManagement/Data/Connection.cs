using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Data
{
    public class Connection
    {
        private string _base;
        private string _server;
        private string _user;
        private string _password;
        private static Connection _con = null;

        //class constructor
        private Connection() {
            this._server = "Fabian\\SQLEXPRESS";
            this._base = "db_company_management";
            this._user = "fabian_suarez";
            this._password = "sux0987";

        }

        public SqlConnection CreateConnection()
        {
            SqlConnection Chain = new SqlConnection();

            try
            {
                Chain.ConnectionString = "Server="+this._server+
                                         "; DataBase="+this._base+
                                         "; User id="+this._user+
                                         "; Password="+this._password;
            }
            catch(Exception ex) 
            {
                Chain = null;
                throw ex;
            }

            return Chain;

        }

        public static Connection createInstance()
        {
            if (_con == null )
            {
                _con = new Connection();
            }

            return _con;
        }
    }
}
