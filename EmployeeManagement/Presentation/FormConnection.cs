using EmployeeManagement.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement.Presentation
{
    public partial class FormConnection : Form
    {
        public FormConnection()
        {
            InitializeComponent();
        }

        private void FormConnection_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection SqlCon = new SqlConnection();

            SqlCon = Connection.createInstance().CreateConnection();

            try
            {
                SqlCon.Open();
                MessageBox.Show("Connection create");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Crashee");
                MessageBox.Show(ex.Message);
            }
        }
    }
}
