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
using System.Xml.Linq;

namespace CRUD
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Search Record
            // Connect
            // Connect with database server
            string url = "datasource=localhost;port=3306;username=root;password=root";
            string sql = "select * from sectiona.persond where pid = '" + int.Parse(txtId.Text) + "';";

            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(url);
                conn.Open();

                // Search
                cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtId.Text = reader[0].ToString();
                    txtName.Text = reader[1].ToString();
                    txtAddress.Text = reader[2].ToString();
                }
                else
                {
                    MessageBox.Show("No Data Found!!");
                    txtId.Text = "";
                    txtName.Text = "";
                    txtAddress.Text = "";
                }
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
            // Search
            // Close
        }
    }
}
