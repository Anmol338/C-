using ADO_NET.V2.MyClasses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_NET.V2 {
    public partial class AllPersons : Form {
        public AllPersons() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            ArrayList persons = new CRUDV2().AllPersons();
            dataGridView1.DataSource = persons;
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}