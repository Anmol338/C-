namespace WinFormsApp1
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fnum = new Label();
            label2 = new Label();
            label1 = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            txtResult = new TextBox();
            btnAdd = new Button();
            btnSub = new Button();
            btnPrd = new Button();
            btnDiv = new Button();
            SuspendLayout();
            // 
            // fnum
            // 
            fnum.AutoSize = true;
            fnum.BackColor = SystemColors.ActiveCaptionText;
            fnum.ForeColor = SystemColors.Control;
            fnum.ImageAlign = ContentAlignment.TopCenter;
            fnum.Location = new Point(46, 77);
            fnum.Name = "fnum";
            fnum.Size = new Size(70, 20);
            fnum.TabIndex = 0;
            fnum.Text = "First No. :";
            fnum.TextAlign = ContentAlignment.TopCenter;
            fnum.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 136);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 1;
            label2.Text = "Second No. :";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 256);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 2;
            label1.Text = "Result :";
            label1.Click += label1_Click_1;
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(139, 70);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(125, 27);
            txtNum1.TabIndex = 3;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(139, 129);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(125, 27);
            txtNum2.TabIndex = 4;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(139, 249);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(125, 27);
            txtResult.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(139, 172);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(55, 29);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(200, 172);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(64, 29);
            btnSub.TabIndex = 7;
            btnSub.Text = "Sub";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += button1_Click;
            // 
            // btnPrd
            // 
            btnPrd.Location = new Point(200, 207);
            btnPrd.Name = "btnPrd";
            btnPrd.Size = new Size(64, 29);
            btnPrd.TabIndex = 8;
            btnPrd.Text = "PRD";
            btnPrd.UseVisualStyleBackColor = true;
            btnPrd.Click += button2_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(139, 207);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(55, 29);
            btnDiv.TabIndex = 9;
            btnDiv.Text = "DIV";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += button3_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(367, 318);
            Controls.Add(btnDiv);
            Controls.Add(btnPrd);
            Controls.Add(btnSub);
            Controls.Add(btnAdd);
            Controls.Add(txtResult);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(fnum);
            Name = "Calculator";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        public Label fnum;
        private Label label1;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private TextBox txtResult;
        private Button btnAdd;
        private Button btnSub;
        private Button btnPrd;
        private Button btnDiv;
    }
}