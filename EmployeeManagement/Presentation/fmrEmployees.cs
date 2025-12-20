using EmployeeManagement.Data;
using EmployeeManagement.Entities;
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

        #region "Vars"
        int iEmployeeCode = 0;
        bool isSelecEmploye;
        #endregion

        #region "PanelFuctions"
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
            UploadEmployees(txtSearch.Text);
        }

        private void fmrEmployees_Load(object sender, EventArgs e)
        {
            UploadEmployees("%");
            SelectDepartment();
            SelectPosition();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        #endregion

        #region "Methods"

        private void UploadEmployees(string cSearch)
        {
            D_Employees Data = new D_Employees();
            dgvEmployeesList.DataSource = Data.List_Employyes(cSearch);

            EmployeeFormtList();
        }

        private bool RequiredFields()
        {
            bool thereAreEmptyFields = false;

            if (string.IsNullOrEmpty(txtName.Text)) thereAreEmptyFields = true;
            if (string.IsNullOrEmpty(txtAddress.Text)) thereAreEmptyFields = true;
            if (string.IsNullOrEmpty(txtPhoneNumber.Text)) thereAreEmptyFields = true;
            if (string.IsNullOrEmpty(txtSalary.Text)) thereAreEmptyFields = true;

            if (!dtpBirthDate.Checked) thereAreEmptyFields = true;

            if (cbDeparrment.SelectedIndex == -1) thereAreEmptyFields = true;
            if (cbPosition.SelectedIndex == -1) thereAreEmptyFields = true;

            return thereAreEmptyFields;
        }



        private void Clear()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtPhoneNumber.Clear();
            txtSalary.Clear();

            cbDeparrment.SelectedIndex = -1;
            cbPosition.SelectedIndex = -1;

            dtpBirthDate.Value = DateTime.Now;

            isSelecEmploye = false;
        }

        private void SaveEmployees()
        {
            E_Employee Employee = new E_Employee();

            Employee.employee_name = txtName.Text;
            Employee.employee_address = txtAddress.Text;
            Employee.employee_phone_number = txtPhoneNumber.Text;
            Employee.employe_salary = Convert.ToDecimal(txtSalary.Text);
            Employee.employee_bithdate = dtpBirthDate.Value;
            Employee.id_department = Convert.ToInt32(cbDeparrment.SelectedValue);
            Employee.id_position = Convert.ToInt32(cbPosition.SelectedValue);

            D_Employees Data = new D_Employees();
            string answer = Data.Save_Employee(Employee);

            if (answer == "OK")
            {
                UploadEmployees("%");
                Clear();
                ActiveTextBox(false);
                ActiveButon(true);

                MessageBox.Show("Datos Guardados Correctamente!", "Sistema Gestión De Empleados", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(answer, "Sistema Gestión De Empleados", MessageBoxButtons.OK,
    MessageBoxIcon.Information);  
            }

        }
        private void SelectEmployee()
        {
            isSelecEmploye = true;
            iEmployeeCode = Convert.ToInt32(dgvEmployeesList.CurrentRow.Cells["ID"].Value);

            txtName.Text = Convert.ToString(dgvEmployeesList.CurrentRow.Cells["Nombre"].Value);
            txtAddress.Text = Convert.ToString(dgvEmployeesList.CurrentRow.Cells["Dirección"].Value);
            txtPhoneNumber.Text = Convert.ToString(dgvEmployeesList.CurrentRow.Cells["Telefono"].Value);
            txtSalary.Text = Convert.ToString(dgvEmployeesList.CurrentRow.Cells["Salario"].Value);

            cbDeparrment.Text = Convert.ToString(dgvEmployeesList.CurrentRow.Cells["Departamento"].Value);
            cbPosition.Text = Convert.ToString(dgvEmployeesList.CurrentRow.Cells["Cargo"].Value);

            dtpBirthDate.Value = Convert.ToDateTime(dgvEmployeesList.CurrentRow.Cells["Fecha Nacimiento"].Value);

        }
        private void SelectDepartment()
        {
            D_departments Data = new D_departments();
            cbDeparrment.DataSource = Data.List_Department();
            cbDeparrment.ValueMember = "id_department";
            cbDeparrment.DisplayMember = "department_name";
            cbDeparrment.SelectedIndex = -1;

        }

        private void SelectPosition()
        {
            D_Positions Data = new D_Positions();
            cbPosition.DataSource = Data.List_Positions();
            cbPosition.ValueMember = "id_position";
            cbPosition.DisplayMember = "position_name";
            cbPosition.SelectedIndex = -1;

        }

        private void ActiveTextBox(bool bState)
        {
            txtAddress.Enabled = bState;
            txtName.Enabled = bState;
            txtPhoneNumber.Enabled = bState;
            txtSalary.Enabled = bState;
            cbDeparrment.Enabled = bState;
            cbPosition.Enabled = bState;
            dtpBirthDate.Enabled = bState;

            txtSearch.Enabled = !bState;
            btSearch.Enabled = !bState;
        }

        private void ActiveButon(bool bState)
        {
            btSave.Visible = bState;
            btCancel.Visible = bState;

            btReport.Enabled = !bState;
            btEliminate.Enabled = !bState;
            btUpdate.Enabled = !bState;
        }

        private void EmployeeFormtList()
        {
            dgvEmployeesList.Columns[0].Width = 45;
            dgvEmployeesList.Columns[1].Width = 160;
            dgvEmployeesList.Columns[2].Width = 160;
            dgvEmployeesList.Columns[5].Width = 250;
            dgvEmployeesList.Columns[7].Width = 160;
        }

        #endregion

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            UploadEmployees(txtSearch.Text);
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            ActiveTextBox(true);
            ActiveButon(true);
            Clear();


            txtName.Select();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            ActiveTextBox(false);
            ActiveButon(false);
            Clear();
        }

        private void dgvEmployeesList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectEmployee();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (isSelecEmploye == true)
            {
                ActiveTextBox(true);
                ActiveButon(true);

                txtName.Select();
            }
            else
            {
                MessageBox.Show("No hay ningun campo seleccionado, porfavor seleccione un campo.", "Sistema de Gestión de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (RequiredFields())
            {
                MessageBox.Show("Hay Campos Vacios, Debes Llenar Todos Los Campos.", "Sistema Gestion de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SaveEmployees();
            }
        }
    }
}
