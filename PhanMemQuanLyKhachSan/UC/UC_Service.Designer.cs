namespace PhanMemQuanLyKhachSan.UC
{
    partial class UC_Service
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
            this.button_UpdateService = new System.Windows.Forms.Button();
            this.button_AddService = new System.Windows.Forms.Button();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label_NameService = new System.Windows.Forms.Label();
            this.groupBox_Service = new System.Windows.Forms.GroupBox();
            this.dataGridView_ListService = new System.Windows.Forms.DataGridView();
            this.groupBox_InfoService = new System.Windows.Forms.GroupBox();
            this.label_PriceService = new System.Windows.Forms.Label();
            this.textBox_PriceService = new System.Windows.Forms.TextBox();
            this.textBox_NameService = new System.Windows.Forms.TextBox();
            this.label_ID = new System.Windows.Forms.Label();
            this.button_DeleteService = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox_Service.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListService)).BeginInit();
            this.groupBox_InfoService.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_UpdateService
            // 
            this.button_UpdateService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.button_UpdateService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_UpdateService.FlatAppearance.BorderSize = 0;
            this.button_UpdateService.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(173)))), ((int)(((byte)(247)))));
            this.button_UpdateService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_UpdateService.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_UpdateService.ForeColor = System.Drawing.Color.White;
            this.button_UpdateService.Location = new System.Drawing.Point(775, 261);
            this.button_UpdateService.Margin = new System.Windows.Forms.Padding(4);
            this.button_UpdateService.Name = "button_UpdateService";
            this.button_UpdateService.Size = new System.Drawing.Size(150, 50);
            this.button_UpdateService.TabIndex = 16;
            this.button_UpdateService.Text = "SỬA";
            this.button_UpdateService.UseVisualStyleBackColor = false;
            this.button_UpdateService.Click += new System.EventHandler(this.button_UpdateService_Click);
            // 
            // button_AddService
            // 
            this.button_AddService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.button_AddService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AddService.FlatAppearance.BorderSize = 0;
            this.button_AddService.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(173)))), ((int)(((byte)(247)))));
            this.button_AddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddService.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddService.ForeColor = System.Drawing.Color.White;
            this.button_AddService.Location = new System.Drawing.Point(611, 261);
            this.button_AddService.Margin = new System.Windows.Forms.Padding(4);
            this.button_AddService.Name = "button_AddService";
            this.button_AddService.Size = new System.Drawing.Size(150, 50);
            this.button_AddService.TabIndex = 15;
            this.button_AddService.Text = "THÊM";
            this.button_AddService.UseVisualStyleBackColor = false;
            this.button_AddService.Click += new System.EventHandler(this.button_AddService_Click);
            // 
            // textBox_ID
            // 
            this.textBox_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ID.Location = new System.Drawing.Point(196, 96);
            this.textBox_ID.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.ReadOnly = true;
            this.textBox_ID.Size = new System.Drawing.Size(320, 29);
            this.textBox_ID.TabIndex = 17;
            this.textBox_ID.TabStop = false;
            // 
            // label_NameService
            // 
            this.label_NameService.AutoSize = true;
            this.label_NameService.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NameService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.label_NameService.Location = new System.Drawing.Point(40, 46);
            this.label_NameService.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_NameService.Name = "label_NameService";
            this.label_NameService.Size = new System.Drawing.Size(115, 24);
            this.label_NameService.TabIndex = 14;
            this.label_NameService.Text = "Tên dịch vụ:";
            // 
            // groupBox_Service
            // 
            this.groupBox_Service.Controls.Add(this.dataGridView_ListService);
            this.groupBox_Service.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Service.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox_Service.Location = new System.Drawing.Point(4, 10);
            this.groupBox_Service.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_Service.Name = "groupBox_Service";
            this.groupBox_Service.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_Service.Size = new System.Drawing.Size(555, 678);
            this.groupBox_Service.TabIndex = 13;
            this.groupBox_Service.TabStop = false;
            this.groupBox_Service.Text = "DANH SÁCH DỊCH VỤ";
            // 
            // dataGridView_ListService
            // 
            this.dataGridView_ListService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ListService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ListService.Location = new System.Drawing.Point(8, 28);
            this.dataGridView_ListService.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_ListService.Name = "dataGridView_ListService";
            this.dataGridView_ListService.ReadOnly = true;
            this.dataGridView_ListService.Size = new System.Drawing.Size(539, 642);
            this.dataGridView_ListService.TabIndex = 0;
            this.dataGridView_ListService.SelectionChanged += new System.EventHandler(this.dataGridView_ListService_SelectionChanged);
            // 
            // groupBox_InfoService
            // 
            this.groupBox_InfoService.Controls.Add(this.label_NameService);
            this.groupBox_InfoService.Controls.Add(this.textBox_ID);
            this.groupBox_InfoService.Controls.Add(this.label_PriceService);
            this.groupBox_InfoService.Controls.Add(this.textBox_PriceService);
            this.groupBox_InfoService.Controls.Add(this.textBox_NameService);
            this.groupBox_InfoService.Controls.Add(this.label_ID);
            this.groupBox_InfoService.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_InfoService.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox_InfoService.Location = new System.Drawing.Point(567, 10);
            this.groupBox_InfoService.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_InfoService.Name = "groupBox_InfoService";
            this.groupBox_InfoService.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_InfoService.Size = new System.Drawing.Size(549, 223);
            this.groupBox_InfoService.TabIndex = 18;
            this.groupBox_InfoService.TabStop = false;
            this.groupBox_InfoService.Text = "THÔNG TIN DỊCH VỤ";
            // 
            // label_PriceService
            // 
            this.label_PriceService.AutoSize = true;
            this.label_PriceService.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PriceService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.label_PriceService.Location = new System.Drawing.Point(40, 159);
            this.label_PriceService.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_PriceService.Name = "label_PriceService";
            this.label_PriceService.Size = new System.Drawing.Size(109, 24);
            this.label_PriceService.TabIndex = 6;
            this.label_PriceService.Text = "Giá dịch vụ:";
            // 
            // textBox_PriceService
            // 
            this.textBox_PriceService.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PriceService.Location = new System.Drawing.Point(196, 156);
            this.textBox_PriceService.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_PriceService.Name = "textBox_PriceService";
            this.textBox_PriceService.Size = new System.Drawing.Size(320, 29);
            this.textBox_PriceService.TabIndex = 2;
            this.textBox_PriceService.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_PriceService_KeyPress);
            // 
            // textBox_NameService
            // 
            this.textBox_NameService.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NameService.Location = new System.Drawing.Point(196, 43);
            this.textBox_NameService.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_NameService.Name = "textBox_NameService";
            this.textBox_NameService.Size = new System.Drawing.Size(320, 29);
            this.textBox_NameService.TabIndex = 1;
            this.textBox_NameService.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_NameService_KeyPress);
            this.textBox_NameService.Leave += new System.EventHandler(this.textBox_NameService_Leave);
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.label_ID.Location = new System.Drawing.Point(40, 99);
            this.label_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(107, 24);
            this.label_ID.TabIndex = 4;
            this.label_ID.Text = "Mã dịch vụ:";
            // 
            // button_DeleteService
            // 
            this.button_DeleteService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.button_DeleteService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_DeleteService.FlatAppearance.BorderSize = 0;
            this.button_DeleteService.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(173)))), ((int)(((byte)(247)))));
            this.button_DeleteService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DeleteService.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DeleteService.ForeColor = System.Drawing.Color.White;
            this.button_DeleteService.Location = new System.Drawing.Point(933, 261);
            this.button_DeleteService.Margin = new System.Windows.Forms.Padding(4);
            this.button_DeleteService.Name = "button_DeleteService";
            this.button_DeleteService.Size = new System.Drawing.Size(150, 50);
            this.button_DeleteService.TabIndex = 19;
            this.button_DeleteService.Text = "XÓA";
            this.button_DeleteService.UseVisualStyleBackColor = false;
            this.button_DeleteService.Click += new System.EventHandler(this.button_DeleteService_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1123, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 705);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 695);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1123, 10);
            this.panel2.TabIndex = 21;
            // 
            // UC_Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_DeleteService);
            this.Controls.Add(this.button_UpdateService);
            this.Controls.Add(this.button_AddService);
            this.Controls.Add(this.groupBox_Service);
            this.Controls.Add(this.groupBox_InfoService);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_Service";
            this.Size = new System.Drawing.Size(1133, 705);
            this.groupBox_Service.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListService)).EndInit();
            this.groupBox_InfoService.ResumeLayout(false);
            this.groupBox_InfoService.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_UpdateService;
        private System.Windows.Forms.Button button_AddService;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label_NameService;
        private System.Windows.Forms.GroupBox groupBox_Service;
        private System.Windows.Forms.DataGridView dataGridView_ListService;
        private System.Windows.Forms.GroupBox groupBox_InfoService;
        private System.Windows.Forms.Label label_PriceService;
        private System.Windows.Forms.TextBox textBox_PriceService;
        private System.Windows.Forms.TextBox textBox_NameService;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Button button_DeleteService;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
