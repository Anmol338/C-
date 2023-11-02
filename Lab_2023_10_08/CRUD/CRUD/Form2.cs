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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            // Connect with database server
            string url = "datasource=localhost;database=sectiona;port=3306;username=root;password=root";

            MySqlConnection conn=null;

            try
            {
                conn = new MySqlConnection(url);
                conn.Open();
                conn.Close();
                MessageBox.Show("Connect with DB Server Successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Dispose();
            }
        }
    }
}
