using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Text = "";
            button2.Image = Image.FromFile(@"C:\Users\Ashutosh\Pictures\Screenshots\Screenshot 2023-10-08 001923.png");
            button2.Size = new Size(300, 200);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
