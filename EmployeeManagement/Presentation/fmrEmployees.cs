using EmployeeManagement.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement.Presentation
{
    public partial class fmrEmployees : Form
    {
        public fmrEmployees()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void fmrEmployees_Load(object sender, EventArgs e)
        {
            UploadEmployees("%");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        #region "Methods"

        private void UploadEmployees(string cSearch)
        {
            D_Employees Data = new D_Employees();
            dgvEmployeesList.DataSource = Data.List_Employyes(cSearch);
        }

        #endregion
    }
}
