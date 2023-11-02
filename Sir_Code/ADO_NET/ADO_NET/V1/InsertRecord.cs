using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_NET.V1 {
    public partial class InsertRecord : Form {
        public InsertRecord() {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            //save record
            string url = "datasource=localhost; Database=CollegeSys; port=3306; User=root; Password=Nepal@123";
            //string url = read from databaseinfo.txt
            //validation?
            string sql = "INSERT INTO persons(pid, full_name, contact_address) VALUES("+int.Parse(textBox1.Text)+", '"+textBox2.Text+"', '"+textBox3.Text+"')";
            MySqlConnection conn = null;
            MySqlCommand command = null;
            try {
                conn = new MySqlConnection(url);
                conn.Open();
                command = new MySqlCommand(sql, conn);                
                int result = command.ExecuteNonQuery();               
                conn.Close();
                if (result == 1) {
                    MessageBox.Show("Insert record successfully");
                }
                else {
                    MessageBox.Show("Error to insert record");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
