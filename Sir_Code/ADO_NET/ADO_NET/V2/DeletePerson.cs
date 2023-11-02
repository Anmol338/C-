using ADO_NET.V2.MyClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_NET.V2 {
    public partial class DeletePerson : Form {
        public DeletePerson() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            //Search
            Person person = new Person();
            person.PID = int.Parse(textBox1.Text);
            person = new CRUDV2().SearchPerson(person);
            if (person.FullName.Length > 0) {
                textBox2.Text = person.FullName;
                textBox3.Text = person.ContactAddress;
            }
            else {
                MessageBox.Show("Record not found!");
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            Person person = new Person();
            person.PID = int.Parse(textBox1.Text);
            person.FullName = textBox2.Text;
            person.ContactAddress = textBox3.Text;
            bool result = new CRUDV2().DeletePerson(person);
            if (result) {
                MessageBox.Show("Delete record successfully");
            }
            else {
                MessageBox.Show("Error to delet record");
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}