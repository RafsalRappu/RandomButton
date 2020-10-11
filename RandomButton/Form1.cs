using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomButton
{
    public partial class Form1 : Form
    {
        int i = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Button btnOne = new Button();
            btnOne.Text = i.ToString();
            i++;
            btnOne.Location = new Point(e.X, e.Y);
            btnOne.BackColor = Color.Turquoise;
            btnOne.FlatAppearance.BorderSize = 0;
            btnOne.FlatStyle = FlatStyle.Flat;
            btnOne.Width = 40;
            btnOne.Height = 40;
            btnOne.Font = new Font("Microsoft YaHei", 10, FontStyle.Bold);
            btnOne.ForeColor = Color.Green;
            this.Controls.Add(btnOne);
        }
    }
}
