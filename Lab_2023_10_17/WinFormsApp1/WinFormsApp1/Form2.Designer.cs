namespace WinFormsApp1
{
    partial class Form2
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
            menuStrip1 = new MenuStrip();
            backgroundWorkerToolStripMenuItem = new ToolStripMenuItem();
            example1ToolStripMenuItem = new ToolStripMenuItem();
            example2ToolStripMenuItem = new ToolStripMenuItem();
            example3ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { backgroundWorkerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // backgroundWorkerToolStripMenuItem
            // 
            backgroundWorkerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { example1ToolStripMenuItem, example2ToolStripMenuItem, example3ToolStripMenuItem });
            backgroundWorkerToolStripMenuItem.Name = "backgroundWorkerToolStripMenuItem";
            backgroundWorkerToolStripMenuItem.Size = new Size(149, 24);
            backgroundWorkerToolStripMenuItem.Text = "BackgroundWorker";
            // 
            // example1ToolStripMenuItem
            // 
            example1ToolStripMenuItem.Name = "example1ToolStripMenuItem";
            example1ToolStripMenuItem.Size = new Size(224, 26);
            example1ToolStripMenuItem.Text = "Example1";
            example1ToolStripMenuItem.Click += example1ToolStripMenuItem_Click;
            // 
            // example2ToolStripMenuItem
            // 
            example2ToolStripMenuItem.Name = "example2ToolStripMenuItem";
            example2ToolStripMenuItem.Size = new Size(224, 26);
            example2ToolStripMenuItem.Text = "Example2";
            // 
            // example3ToolStripMenuItem
            // 
            example3ToolStripMenuItem.Name = "example3ToolStripMenuItem";
            example3ToolStripMenuItem.Size = new Size(224, 26);
            example3ToolStripMenuItem.Text = "Example3";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "Window";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem backgroundWorkerToolStripMenuItem;
        private ToolStripMenuItem example1ToolStripMenuItem;
        private ToolStripMenuItem example2ToolStripMenuItem;
        private ToolStripMenuItem example3ToolStripMenuItem;
    }
}