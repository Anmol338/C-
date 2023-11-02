namespace CRUD
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataTable = new DataGridView();
            btnLoad = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)DataTable).BeginInit();
            SuspendLayout();
            // 
            // DataTable
            // 
            DataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataTable.Location = new Point(8, 9);
            DataTable.Name = "DataTable";
            DataTable.RowHeadersWidth = 51;
            DataTable.RowTemplate.Height = 29;
            DataTable.Size = new Size(788, 391);
            DataTable.TabIndex = 0;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(282, 406);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 37);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(404, 406);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 37);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(btnLoad);
            Controls.Add(DataTable);
            Name = "Form7";
            Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)DataTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataTable;
        private Button btnLoad;
        private Button btnClose;
    }
}