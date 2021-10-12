using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyKhachSan.UC
{
    public partial class UC_Home : UserControl
    {
        private Label label_AdminName;
        public UC_Home()
        {
            InitializeComponent();
        }


        private void UC_Home_Load(object sender, EventArgs e)
        {
            this.label_Greetings.Parent = this.pictureBox_AdminFlag;
            this.label_Greetings2.Parent = this.pictureBox_AdminFlag;

            label_AdminName = new Label();
            this.label_AdminName.AutoSize = true;
            this.label_AdminName.BackColor = System.Drawing.Color.Transparent;
            this.label_AdminName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_AdminName.ForeColor = System.Drawing.Color.White;
            this.label_AdminName.Location = new System.Drawing.Point(pictureBox_AdminFlag.Size.Width-label_AdminName.Size.Width, 93);
            this.label_AdminName.Name = "label_Greetings";
            //this.label_AdminName.Size = new System.Drawing.Size(95, 25);
            this.label_AdminName.TabIndex = 6;
            this.label_AdminName.Text = "Welcome";

            Controls.Add(label_AdminName);
            label_AdminName.Parent = this.pictureBox_AdminFlag;
        }

        private void UC_Home_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(this.label_AdminName.Size.Width.ToString() + "   " + this.pictureBox_AdminFlag.Size.Width.ToString());

        }
    }
}
