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
    public partial class DeleteRecord : Form {
        public DeleteRecord() {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e) {
            //Delete Record
            string url = "datasource=localhost; Database=SectionA; port=3306; User=root; Password=Nepal@123";
            string sql = "DELETE FROM persons WHERE pid=" + int.Parse(textBox1.Text);
            MySqlConnection conn = null;
            MySqlCommand command = null;
            try {
                conn = new MySqlConnection(url);
                conn.Open();
                command = new MySqlCommand(sql, conn);
                int result = command.ExecuteNonQuery();
                conn.Close();
                if (result == 1) {
                    MessageBox.Show("Delete record successfully");
                }
                else {
                    MessageBox.Show("Error to delete record");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            //Search Record
            string url = "datasource=localhost; Database=SectionA; port=3306; User=root; Password=Nepal@123";
            string sql = "SELECT * FROM persons WHERE pid=" + int.Parse(this.textBox1.Text);
            MySqlConnection conn = null;
            MySqlCommand command = null;
            MySqlDataReader reader = null;

            try {
                conn = new MySqlConnection(url);
                conn.Open();
                command = new MySqlCommand(sql, conn);
                reader = command.ExecuteReader();
                if (reader.Read()) {
                    this.textBox2.Text = reader.GetString("full_name");
                    this.textBox3.Text = reader.GetString("contact_address");
                }
                else {
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    MessageBox.Show("Error : Record not found!");
                }
                conn.Close();
            }
            catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
