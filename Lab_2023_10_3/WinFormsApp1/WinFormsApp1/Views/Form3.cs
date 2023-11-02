using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Models;


namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        string Gender;
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.PID = int.Parse(this.textBox1.Text);
            person.FullName = this.textBox2.Text;
            person.Address = this.textBox3.Text;
            person.Age = this.comboBox1.SelectedItem.ToString();
            person.Gender = Gender;
            MessageBox.Show(person.ToString());
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Others";
        }
    }
}
