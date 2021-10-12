namespace PhanMemQuanLyKhachSan.UC
{
    partial class UC_Employee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListEmployees = new System.Windows.Forms.GroupBox();
            this.dataGridView_ListEmployee = new System.Windows.Forms.DataGridView();
            this.groupBox_Profile = new System.Windows.Forms.GroupBox();
            this.textBox_Cmnd = new System.Windows.Forms.TextBox();
            this.textBox_PhoneNumber = new System.Windows.Forms.TextBox();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_Id = new System.Windows.Forms.Label();
            this.label_Address = new System.Windows.Forms.Label();
            this.label_PhoneNumber = new System.Windows.Forms.Label();
            this.label_StdName = new System.Windows.Forms.Label();
            this.groupBox_AcountInfor = new System.Windows.Forms.GroupBox();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.label_Username = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_ResetPass = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ListEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListEmployee)).BeginInit();
            this.groupBox_Profile.SuspendLayout();
            this.groupBox_AcountInfor.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListEmployees
            // 
            this.ListEmployees.Controls.Add(this.dataGridView_ListEmployee);
            this.ListEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ListEmployees.Location = new System.Drawing.Point(3, 327);
            this.ListEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListEmployees.Name = "ListEmployees";
            this.ListEmployees.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListEmployees.Size = new System.Drawing.Size(1114, 363);
            this.ListEmployees.TabIndex = 5;
            this.ListEmployees.TabStop = false;
            this.ListEmployees.Text = "DANH SÁCH";
            // 
            // dataGridView_ListEmployee
            // 
            this.dataGridView_ListEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ListEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ListEmployee.Location = new System.Drawing.Point(5, 34);
            this.dataGridView_ListEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_ListEmployee.Name = "dataGridView_ListEmployee";
            this.dataGridView_ListEmployee.ReadOnly = true;
            this.dataGridView_ListEmployee.RowHeadersWidth = 51;
            this.dataGridView_ListEmployee.RowTemplate.Height = 24;
            this.dataGridView_ListEmployee.Size = new System.Drawing.Size(1103, 325);
            this.dataGridView_ListEmployee.TabIndex = 12;
            this.dataGridView_ListEmployee.SelectionChanged += new System.EventHandler(this.dataGridView_ListEmployee_SelectionChanged);
            // 
            // groupBox_Profile
            // 
            this.groupBox_Profile.Controls.Add(this.label1);
            this.groupBox_Profile.Controls.Add(this.textBox_Cmnd);
            this.groupBox_Profile.Controls.Add(this.textBox_PhoneNumber);
            this.groupBox_Profile.Controls.Add(this.textBox_Id);
            this.groupBox_Profile.Controls.Add(this.textBox_Address);
            this.groupBox_Profile.Controls.Add(this.textBox_Name);
            this.groupBox_Profile.Controls.Add(this.label_Id);
            this.groupBox_Profile.Controls.Add(this.label_Address);
            this.groupBox_Profile.Controls.Add(this.label_PhoneNumber);
            this.groupBox_Profile.Controls.Add(this.label_StdName);
            this.groupBox_Profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox_Profile.Location = new System.Drawing.Point(8, 10);
            this.groupBox_Profile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Profile.Name = "groupBox_Profile";
            this.groupBox_Profile.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Profile.Size = new System.Drawing.Size(530, 290);
            this.groupBox_Profile.TabIndex = 3;
            this.groupBox_Profile.TabStop = false;
            this.groupBox_Profile.Text = "NHÂN VIÊN";
            // 
            // textBox_Cmnd
            // 
            this.textBox_Cmnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_Cmnd.Location = new System.Drawing.Point(160, 137);
            this.textBox_Cmnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Cmnd.Name = "textBox_Cmnd";
            this.textBox_Cmnd.Size = new System.Drawing.Size(300, 28);
            this.textBox_Cmnd.TabIndex = 2;
            this.textBox_Cmnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Cmnd_KeyPress);
            // 
            // textBox_PhoneNumber
            // 
            this.textBox_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_PhoneNumber.Location = new System.Drawing.Point(160, 187);
            this.textBox_PhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_PhoneNumber.Name = "textBox_PhoneNumber";
            this.textBox_PhoneNumber.Size = new System.Drawing.Size(300, 28);
            this.textBox_PhoneNumber.TabIndex = 3;
            this.textBox_PhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_PhoneNumber_KeyPress);
            // 
            // textBox_Id
            // 
            this.textBox_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_Id.Location = new System.Drawing.Point(160, 87);
            this.textBox_Id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(300, 28);
            this.textBox_Id.TabIndex = 13;
            this.textBox_Id.TabStop = false;
            // 
            // textBox_Address
            // 
            this.textBox_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_Address.Location = new System.Drawing.Point(160, 237);
            this.textBox_Address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(300, 28);
            this.textBox_Address.TabIndex = 4;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_Name.Location = new System.Drawing.Point(160, 38);
            this.textBox_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(300, 28);
            this.textBox_Name.TabIndex = 1;
            this.textBox_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Name_KeyPress);
            this.textBox_Name.Leave += new System.EventHandler(this.TextBox_Name_Leave);
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_Id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.label_Id.Location = new System.Drawing.Point(5, 90);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(124, 24);
            this.label_Id.TabIndex = 6;
            this.label_Id.Text = "Mã nhân viên";
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_Address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.label_Address.Location = new System.Drawing.Point(7, 240);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(67, 24);
            this.label_Address.TabIndex = 5;
            this.label_Address.Text = "Địa chỉ";
            // 
            // label_PhoneNumber
            // 
            this.label_PhoneNumber.AutoSize = true;
            this.label_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_PhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.label_PhoneNumber.Location = new System.Drawing.Point(7, 190);
            this.label_PhoneNumber.Name = "label_PhoneNumber";
            this.label_PhoneNumber.Size = new System.Drawing.Size(94, 24);
            this.label_PhoneNumber.TabIndex = 2;
            this.label_PhoneNumber.Text = "Điện thoại";
            // 
            // label_StdName
            // 
            this.label_StdName.AutoSize = true;
            this.label_StdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_StdName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.label_StdName.Location = new System.Drawing.Point(8, 40);
            this.label_StdName.Name = "label_StdName";
            this.label_StdName.Size = new System.Drawing.Size(66, 24);
            this.label_StdName.TabIndex = 0;
            this.label_StdName.Text = "Họ tên";
            // 
            // groupBox_AcountInfor
            // 
            this.groupBox_AcountInfor.Controls.Add(this.textBox_Username);
            this.groupBox_AcountInfor.Controls.Add(this.label_Username);
            this.groupBox_AcountInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_AcountInfor.Location = new System.Drawing.Point(611, 10);
            this.groupBox_AcountInfor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_AcountInfor.Name = "groupBox_AcountInfor";
            this.groupBox_AcountInfor.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_AcountInfor.Size = new System.Drawing.Size(500, 100);
            this.groupBox_AcountInfor.TabIndex = 6;
            this.groupBox_AcountInfor.TabStop = false;
            this.groupBox_AcountInfor.Text = "TÀI KHOẢN";
            // 
            // textBox_Username
            // 
            this.textBox_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_Username.Location = new System.Drawing.Point(163, 37);
            this.textBox_Username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(300, 28);
            this.textBox_Username.TabIndex = 5;
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.label_Username.Location = new System.Drawing.Point(19, 39);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(124, 24);
            this.label_Username.TabIndex = 18;
            this.label_Username.Text = "Tên tài khoản";
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.button_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Add.FlatAppearance.BorderSize = 0;
            this.button_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(173)))), ((int)(((byte)(247)))));
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add.ForeColor = System.Drawing.Color.White;
            this.button_Add.Location = new System.Drawing.Point(611, 193);
            this.button_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(245, 50);
            this.button_Add.TabIndex = 8;
            this.button_Add.Text = "THÊM";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.button_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Delete.FlatAppearance.BorderSize = 0;
            this.button_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(173)))), ((int)(((byte)(247)))));
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.ForeColor = System.Drawing.Color.White;
            this.button_Delete.Location = new System.Drawing.Point(611, 250);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(245, 50);
            this.button_Delete.TabIndex = 9;
            this.button_Delete.Text = "XÓA";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.button_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Update.FlatAppearance.BorderSize = 0;
            this.button_Update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(173)))), ((int)(((byte)(247)))));
            this.button_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.ForeColor = System.Drawing.Color.White;
            this.button_Update.Location = new System.Drawing.Point(867, 193);
            this.button_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(245, 50);
            this.button_Update.TabIndex = 10;
            this.button_Update.Text = "SỬA";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_ResetPass
            // 
            this.button_ResetPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.button_ResetPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ResetPass.FlatAppearance.BorderSize = 0;
            this.button_ResetPass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(173)))), ((int)(((byte)(247)))));
            this.button_ResetPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ResetPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ResetPass.ForeColor = System.Drawing.Color.White;
            this.button_ResetPass.Location = new System.Drawing.Point(867, 250);
            this.button_ResetPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_ResetPass.Name = "button_ResetPass";
            this.button_ResetPass.Size = new System.Drawing.Size(244, 50);
            this.button_ResetPass.TabIndex = 11;
            this.button_ResetPass.Text = "RESET PASS";
            this.button_ResetPass.UseVisualStyleBackColor = false;
            this.button_ResetPass.Click += new System.EventHandler(this.button_ResetPass_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1123, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 705);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 695);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1123, 10);
            this.panel2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(8, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Số CMND";
            // 
            // UC_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_ResetPass);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.groupBox_AcountInfor);
            this.Controls.Add(this.ListEmployees);
            this.Controls.Add(this.groupBox_Profile);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_Employee";
            this.Size = new System.Drawing.Size(1133, 705);
            this.ListEmployees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListEmployee)).EndInit();
            this.groupBox_Profile.ResumeLayout(false);
            this.groupBox_Profile.PerformLayout();
            this.groupBox_AcountInfor.ResumeLayout(false);
            this.groupBox_AcountInfor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ListEmployees;
        private System.Windows.Forms.DataGridView dataGridView_ListEmployee;
        private System.Windows.Forms.GroupBox groupBox_Profile;
        private System.Windows.Forms.TextBox textBox_PhoneNumber;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.Label label_PhoneNumber;
        private System.Windows.Forms.Label label_StdName;
        private System.Windows.Forms.TextBox textBox_Cmnd;
        private System.Windows.Forms.GroupBox groupBox_AcountInfor;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_ResetPass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}
