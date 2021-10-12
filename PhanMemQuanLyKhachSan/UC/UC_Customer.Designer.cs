namespace PhanMemQuanLyKhachSan.UC
{
    partial class UC_Customer
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
            this.groupBox_CustomerList = new System.Windows.Forms.GroupBox();
            this.dataGridView_Top10CustomerList = new System.Windows.Forms.DataGridView();
            this.groupBox_CurrentCustomerList = new System.Windows.Forms.GroupBox();
            this.dataGridView_CurrentCustomerList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox_CustomerList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Top10CustomerList)).BeginInit();
            this.groupBox_CurrentCustomerList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CurrentCustomerList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_CustomerList
            // 
            this.groupBox_CustomerList.Controls.Add(this.dataGridView_Top10CustomerList);
            this.groupBox_CustomerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_CustomerList.Location = new System.Drawing.Point(3, 360);
            this.groupBox_CustomerList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_CustomerList.Name = "groupBox_CustomerList";
            this.groupBox_CustomerList.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_CustomerList.Size = new System.Drawing.Size(1114, 330);
            this.groupBox_CustomerList.TabIndex = 0;
            this.groupBox_CustomerList.TabStop = false;
            this.groupBox_CustomerList.Text = "TOP 10 KHÁCH HÀNG THÂN THIẾT";
            // 
            // dataGridView_Top10CustomerList
            // 
            this.dataGridView_Top10CustomerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Top10CustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Top10CustomerList.Location = new System.Drawing.Point(6, 26);
            this.dataGridView_Top10CustomerList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_Top10CustomerList.Name = "dataGridView_Top10CustomerList";
            this.dataGridView_Top10CustomerList.ReadOnly = true;
            this.dataGridView_Top10CustomerList.RowHeadersWidth = 51;
            this.dataGridView_Top10CustomerList.Size = new System.Drawing.Size(1102, 300);
            this.dataGridView_Top10CustomerList.TabIndex = 0;
            // 
            // groupBox_CurrentCustomerList
            // 
            this.groupBox_CurrentCustomerList.Controls.Add(this.dataGridView_CurrentCustomerList);
            this.groupBox_CurrentCustomerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_CurrentCustomerList.Location = new System.Drawing.Point(3, 10);
            this.groupBox_CurrentCustomerList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_CurrentCustomerList.Name = "groupBox_CurrentCustomerList";
            this.groupBox_CurrentCustomerList.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_CurrentCustomerList.Size = new System.Drawing.Size(1114, 330);
            this.groupBox_CurrentCustomerList.TabIndex = 1;
            this.groupBox_CurrentCustomerList.TabStop = false;
            this.groupBox_CurrentCustomerList.Text = "DANH SÁCH KHÁCH HÀNG ĐANG THUÊ";
            // 
            // dataGridView_CurrentCustomerList
            // 
            this.dataGridView_CurrentCustomerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_CurrentCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CurrentCustomerList.Location = new System.Drawing.Point(7, 27);
            this.dataGridView_CurrentCustomerList.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_CurrentCustomerList.Name = "dataGridView_CurrentCustomerList";
            this.dataGridView_CurrentCustomerList.ReadOnly = true;
            this.dataGridView_CurrentCustomerList.Size = new System.Drawing.Size(1100, 277);
            this.dataGridView_CurrentCustomerList.TabIndex = 0;
            this.dataGridView_CurrentCustomerList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CurrentCustomerList_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1123, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 705);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 695);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1123, 10);
            this.panel2.TabIndex = 3;
            // 
            // UC_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox_CurrentCustomerList);
            this.Controls.Add(this.groupBox_CustomerList);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_Customer";
            this.Size = new System.Drawing.Size(1133, 705);
            this.groupBox_CustomerList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Top10CustomerList)).EndInit();
            this.groupBox_CurrentCustomerList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CurrentCustomerList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_CustomerList;
        private System.Windows.Forms.DataGridView dataGridView_Top10CustomerList;
        private System.Windows.Forms.GroupBox groupBox_CurrentCustomerList;
        private System.Windows.Forms.DataGridView dataGridView_CurrentCustomerList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
