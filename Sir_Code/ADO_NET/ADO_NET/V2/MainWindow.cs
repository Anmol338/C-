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
    public partial class MainWindow : Form {
        public MainWindow() {
            InitializeComponent();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e) {
            SavePerson form = new SavePerson();
            form.MdiParent = this;
            form.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e) {
            SearchPerson form = new SearchPerson();
            form.MdiParent = this;
            form.Show();

        }

        private void updatToolStripMenuItem_Click(object sender, EventArgs e) {
            UpdatePerson form = new UpdatePerson();
            form.MdiParent = this;
            form.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
            DeletePerson form = new DeletePerson();
            form.MdiParent = this;
            form.Show();
        }

        private void personsToolStripMenuItem_Click(object sender, EventArgs e) {
            AllPersons form = new AllPersons();
            form.MdiParent = this;
            form.Show();
        }
    }
}