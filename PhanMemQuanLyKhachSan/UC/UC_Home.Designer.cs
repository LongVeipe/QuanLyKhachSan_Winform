namespace PhanMemQuanLyKhachSan.UC
{
    partial class UC_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox_AdminFlag = new System.Windows.Forms.PictureBox();
            this.label_Greetings = new System.Windows.Forms.Label();
            this.label_Greetings2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AdminFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1123, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 705);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 695);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1123, 10);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(46, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(971, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "CHÀO MỪNG ĐẾN VỚI TRANG QUẢN LÝ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(115, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(826, 58);
            this.label2.TabIndex = 3;
            this.label2.Text = "PHẦN MỀM QUẢN LÝ KHÁCH SẠN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_AdminFlag
            // 
            this.pictureBox_AdminFlag.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_AdminFlag.BackgroundImage")));
            this.pictureBox_AdminFlag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_AdminFlag.Location = new System.Drawing.Point(75, 0);
            this.pictureBox_AdminFlag.Name = "pictureBox_AdminFlag";
            this.pictureBox_AdminFlag.Size = new System.Drawing.Size(160, 207);
            this.pictureBox_AdminFlag.TabIndex = 5;
            this.pictureBox_AdminFlag.TabStop = false;
            // 
            // label_Greetings
            // 
            this.label_Greetings.AutoSize = true;
            this.label_Greetings.BackColor = System.Drawing.Color.Transparent;
            this.label_Greetings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_Greetings.ForeColor = System.Drawing.Color.White;
            this.label_Greetings.Location = new System.Drawing.Point(29, 36);
            this.label_Greetings.Name = "label_Greetings";
            this.label_Greetings.Size = new System.Drawing.Size(95, 25);
            this.label_Greetings.TabIndex = 6;
            this.label_Greetings.Text = "Welcome";
            // 
            // label_Greetings2
            // 
            this.label_Greetings2.AutoSize = true;
            this.label_Greetings2.BackColor = System.Drawing.Color.Transparent;
            this.label_Greetings2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_Greetings2.ForeColor = System.Drawing.Color.White;
            this.label_Greetings2.Location = new System.Drawing.Point(39, 61);
            this.label_Greetings2.Name = "label_Greetings2";
            this.label_Greetings2.Size = new System.Drawing.Size(74, 25);
            this.label_Greetings2.TabIndex = 7;
            this.label_Greetings2.Text = "Admin:";
            // 
            // UC_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label_Greetings2);
            this.Controls.Add(this.label_Greetings);
            this.Controls.Add(this.pictureBox_AdminFlag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(1133, 705);
            this.Load += new System.EventHandler(this.UC_Home_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UC_Home_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AdminFlag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox_AdminFlag;
        private System.Windows.Forms.Label label_Greetings;
        private System.Windows.Forms.Label label_Greetings2;
    }
}
