namespace EmployeeManagement.Presentation
{
    partial class fmrEmployees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrEmployees));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btLeave = new System.Windows.Forms.Button();
            this.btReport = new System.Windows.Forms.Button();
            this.btEliminate = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btNew = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.cbDeparrment = new System.Windows.Forms.ComboBox();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvEmployeesList = new System.Windows.Forms.DataGridView();
            this.btCancel = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeesList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.panel1.Controls.Add(this.btLeave);
            this.panel1.Controls.Add(this.btReport);
            this.panel1.Controls.Add(this.btEliminate);
            this.panel1.Controls.Add(this.btUpdate);
            this.panel1.Controls.Add(this.btNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1139, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 699);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btLeave
            // 
            this.btLeave.BackColor = System.Drawing.Color.Red;
            this.btLeave.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btLeave.FlatAppearance.BorderSize = 6;
            this.btLeave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btLeave.Image = ((System.Drawing.Image)(resources.GetObject("btLeave.Image")));
            this.btLeave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLeave.Location = new System.Drawing.Point(20, 449);
            this.btLeave.Name = "btLeave";
            this.btLeave.Padding = new System.Windows.Forms.Padding(20, 0, 40, 0);
            this.btLeave.Size = new System.Drawing.Size(213, 70);
            this.btLeave.TabIndex = 4;
            this.btLeave.Text = "SALIR";
            this.btLeave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLeave.UseVisualStyleBackColor = false;
            // 
            // btReport
            // 
            this.btReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(212)))), ((int)(((byte)(2)))));
            this.btReport.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btReport.FlatAppearance.BorderSize = 6;
            this.btReport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btReport.Image = ((System.Drawing.Image)(resources.GetObject("btReport.Image")));
            this.btReport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btReport.Location = new System.Drawing.Point(20, 366);
            this.btReport.Name = "btReport";
            this.btReport.Padding = new System.Windows.Forms.Padding(20, 0, 40, 0);
            this.btReport.Size = new System.Drawing.Size(213, 70);
            this.btReport.TabIndex = 3;
            this.btReport.Text = "REPORTE";
            this.btReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btReport.UseVisualStyleBackColor = false;
            // 
            // btEliminate
            // 
            this.btEliminate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(212)))), ((int)(((byte)(2)))));
            this.btEliminate.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btEliminate.FlatAppearance.BorderSize = 6;
            this.btEliminate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btEliminate.Image = global::EmployeeManagement.Properties.Resources.eliminar_usuario;
            this.btEliminate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEliminate.Location = new System.Drawing.Point(20, 283);
            this.btEliminate.Name = "btEliminate";
            this.btEliminate.Padding = new System.Windows.Forms.Padding(20, 0, 40, 0);
            this.btEliminate.Size = new System.Drawing.Size(213, 70);
            this.btEliminate.TabIndex = 2;
            this.btEliminate.Text = "ELIMINAR";
            this.btEliminate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEliminate.UseVisualStyleBackColor = false;
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(212)))), ((int)(((byte)(2)))));
            this.btUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btUpdate.FlatAppearance.BorderSize = 6;
            this.btUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btUpdate.Image")));
            this.btUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btUpdate.Location = new System.Drawing.Point(20, 200);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Padding = new System.Windows.Forms.Padding(20, 0, 40, 0);
            this.btUpdate.Size = new System.Drawing.Size(213, 70);
            this.btUpdate.TabIndex = 1;
            this.btUpdate.Text = "ACTUALIZAR";
            this.btUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btNew
            // 
            this.btNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(212)))), ((int)(((byte)(2)))));
            this.btNew.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btNew.FlatAppearance.BorderSize = 6;
            this.btNew.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btNew.Image = ((System.Drawing.Image)(resources.GetObject("btNew.Image")));
            this.btNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btNew.Location = new System.Drawing.Point(20, 117);
            this.btNew.Name = "btNew";
            this.btNew.Padding = new System.Windows.Forms.Padding(20, 0, 40, 0);
            this.btNew.Size = new System.Drawing.Size(213, 70);
            this.btNew.TabIndex = 0;
            this.btNew.Text = "NUEVO";
            this.btNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNew.UseVisualStyleBackColor = false;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1139, 85);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(212)))), ((int)(((byte)(2)))));
            this.label1.Location = new System.Drawing.Point(302, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTIÓN DE EMPLEADOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(108, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(108, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dirección:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(108, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Teléfono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(108, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Departamento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(592, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nacimiento:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(592, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Salario:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(592, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Cargo:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(108, 471);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Buscar:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.txtName.Enabled = false;
            this.txtName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtName.Location = new System.Drawing.Point(245, 120);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(264, 32);
            this.txtName.TabIndex = 10;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.txtAddress.Enabled = false;
            this.txtAddress.ForeColor = System.Drawing.SystemColors.Window;
            this.txtAddress.Location = new System.Drawing.Point(245, 180);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(770, 32);
            this.txtAddress.TabIndex = 11;
            this.txtAddress.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.txtPhoneNumber.Enabled = false;
            this.txtPhoneNumber.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPhoneNumber.Location = new System.Drawing.Point(245, 263);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(264, 32);
            this.txtPhoneNumber.TabIndex = 12;
            // 
            // txtSalary
            // 
            this.txtSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.txtSalary.Enabled = false;
            this.txtSalary.ForeColor = System.Drawing.SystemColors.Window;
            this.txtSalary.Location = new System.Drawing.Point(738, 263);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(277, 32);
            this.txtSalary.TabIndex = 15;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.CalendarMonthBackground = System.Drawing.Color.Green;
            this.dtpBirthDate.Enabled = false;
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(738, 117);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(277, 32);
            this.dtpBirthDate.TabIndex = 17;
            // 
            // cbDeparrment
            // 
            this.cbDeparrment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.cbDeparrment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeparrment.Enabled = false;
            this.cbDeparrment.ForeColor = System.Drawing.SystemColors.Window;
            this.cbDeparrment.FormattingEnabled = true;
            this.cbDeparrment.Location = new System.Drawing.Point(245, 335);
            this.cbDeparrment.Name = "cbDeparrment";
            this.cbDeparrment.Size = new System.Drawing.Size(264, 33);
            this.cbDeparrment.TabIndex = 18;
            // 
            // cbPosition
            // 
            this.cbPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.cbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPosition.Enabled = false;
            this.cbPosition.ForeColor = System.Drawing.SystemColors.Window;
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Location = new System.Drawing.Point(738, 335);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(277, 33);
            this.cbPosition.TabIndex = 19;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.Window;
            this.txtSearch.Location = new System.Drawing.Point(245, 471);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(717, 32);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvEmployeesList
            // 
            this.dgvEmployeesList.AllowUserToAddRows = false;
            this.dgvEmployeesList.AllowUserToDeleteRows = false;
            this.dgvEmployeesList.AllowUserToOrderColumns = true;
            this.dgvEmployeesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeesList.Location = new System.Drawing.Point(113, 545);
            this.dgvEmployeesList.Name = "dgvEmployeesList";
            this.dgvEmployeesList.ReadOnly = true;
            this.dgvEmployeesList.RowHeadersWidth = 51;
            this.dgvEmployeesList.RowTemplate.Height = 24;
            this.dgvEmployeesList.Size = new System.Drawing.Size(902, 122);
            this.dgvEmployeesList.TabIndex = 21;
            this.dgvEmployeesList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeesList_CellClick);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.Red;
            this.btCancel.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btCancel.FlatAppearance.BorderSize = 6;
            this.btCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btCancel.Image = ((System.Drawing.Image)(resources.GetObject("btCancel.Image")));
            this.btCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCancel.Location = new System.Drawing.Point(446, 384);
            this.btCancel.Name = "btCancel";
            this.btCancel.Padding = new System.Windows.Forms.Padding(20, 0, 40, 0);
            this.btCancel.Size = new System.Drawing.Size(195, 52);
            this.btCancel.TabIndex = 6;
            this.btCancel.Text = "CANCELAR";
            this.btCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Visible = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(212)))), ((int)(((byte)(2)))));
            this.btSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSave.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btSave.FlatAppearance.BorderSize = 6;
            this.btSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btSave.Image = ((System.Drawing.Image)(resources.GetObject("btSave.Image")));
            this.btSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSave.Location = new System.Drawing.Point(245, 384);
            this.btSave.Name = "btSave";
            this.btSave.Padding = new System.Windows.Forms.Padding(20, 0, 40, 0);
            this.btSave.Size = new System.Drawing.Size(195, 52);
            this.btSave.TabIndex = 5;
            this.btSave.Text = "GUARDAR";
            this.btSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Visible = false;
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(212)))), ((int)(((byte)(2)))));
            this.btSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSearch.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btSearch.FlatAppearance.BorderSize = 6;
            this.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btSearch.Image = ((System.Drawing.Image)(resources.GetObject("btSearch.Image")));
            this.btSearch.Location = new System.Drawing.Point(975, 470);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(40, 32);
            this.btSearch.TabIndex = 22;
            this.btSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.button8_Click);
            // 
            // fmrEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1384, 699);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.dgvEmployeesList);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.cbDeparrment);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmrEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "X";
            this.Load += new System.EventHandler(this.fmrEmployees_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeesList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.ComboBox cbDeparrment;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvEmployeesList;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btLeave;
        private System.Windows.Forms.Button btReport;
        private System.Windows.Forms.Button btEliminate;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btSearch;
    }
}