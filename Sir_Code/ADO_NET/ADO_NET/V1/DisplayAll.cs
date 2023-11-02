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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ADO_NET.V1 {
    public partial class DisplayAll : Form {
        public DisplayAll() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) {
            //Display all
            string url = "datasource=localhost; Database=SectionA; port=3306; User=root; Password=Nepal@123";
            string sql = "SELECT * FROM persons";
            MySqlConnection conn = null;
            MySqlCommand command = null;
            MySqlDataAdapter adapter = null;
            DataTable table = null;
            try {
                conn = new MySqlConnection(url);
                conn.Open();
                command = new MySqlCommand(sql, conn);
                adapter = new MySqlDataAdapter(command);
                table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                conn.Close();
            }
            catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
