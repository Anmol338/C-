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

namespace CRUD
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            // Insert Record
            // Connect
            // Connect with database server
            string url = "datasource=localhost;port=3306;username=root;password=root";
            string sql = "INSERT INTO sectiona.persond(pid, full_name, contact_address) values(" + int.Parse(txtId.Text) + ", '" + txtName.Text + "', '" + txtAddress.Text + "')";

            MySqlConnection conn = null;
            MySqlCommand cmd = null;

            try
            {
                conn = new MySqlConnection(url);
                conn.Open();

                // Insert
                cmd = new MySqlCommand(sql, conn);
                int result = cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Result : " + result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            // Insert
            // Close
        }
    }
}
