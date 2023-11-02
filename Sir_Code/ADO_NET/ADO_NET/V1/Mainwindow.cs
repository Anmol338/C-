using ADO_NET.V1;

namespace ADO_NET {
    public partial class Mainwindow : Form {
        public Mainwindow() {
            InitializeComponent();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e) {
            ConnectDB connectDB = new ConnectDB();
            connectDB.MdiParent = this;
            connectDB.Show();
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e) {
            InsertRecord insertRecord = new InsertRecord();
            insertRecord.MdiParent = this;
            insertRecord.Show();
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e) {
            DisplayAll displayAll = new DisplayAll();
            displayAll.MdiParent = this;
            displayAll.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e) {
            SearchRecord searchRecord = new SearchRecord();
            searchRecord.MdiParent = this;
            searchRecord.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e) {
            UpdateRecord update = new UpdateRecord();
            update.MdiParent = this;
            update.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
            DeleteRecord delete = new DeleteRecord();
            delete.MdiParent = this;
            delete.Show();
        }
    }
}