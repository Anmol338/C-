namespace ADO_NET
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
            btnGenerate = new Button();
            btnWrite = new Button();
            btnDisplay = new Button();
            richTextBox1 = new RichTextBox();
            btnMax = new Button();
            btnMin = new Button();
            btnAverage = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(182, 60);
            btnGenerate.Margin = new Padding(3, 4, 3, 4);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(86, 31);
            btnGenerate.TabIndex = 0;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += button1_Click;
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(295, 60);
            btnWrite.Margin = new Padding(3, 4, 3, 4);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(86, 31);
            btnWrite.TabIndex = 1;
            btnWrite.Text = "Write";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += button2_Click;
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(402, 60);
            btnDisplay.Margin = new Padding(3, 4, 3, 4);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(86, 31);
            btnDisplay.TabIndex = 2;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(25, 115);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(588, 217);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // btnMax
            // 
            btnMax.Location = new Point(65, 359);
            btnMax.Margin = new Padding(3, 4, 3, 4);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(86, 31);
            btnMax.TabIndex = 4;
            btnMax.Text = "Max";
            btnMax.UseVisualStyleBackColor = true;
            btnMax.Click += btnMax_Click;
            // 
            // btnMin
            // 
            btnMin.Location = new Point(182, 359);
            btnMin.Margin = new Padding(3, 4, 3, 4);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(86, 31);
            btnMin.TabIndex = 5;
            btnMin.Text = "Min";
            btnMin.UseVisualStyleBackColor = true;
            btnMin.Click += btnMin_Click;
            // 
            // btnAverage
            // 
            btnAverage.Location = new Point(295, 359);
            btnAverage.Margin = new Padding(3, 4, 3, 4);
            btnAverage.Name = "btnAverage";
            btnAverage.Size = new Size(86, 31);
            btnAverage.TabIndex = 6;
            btnAverage.Text = "Average";
            btnAverage.UseVisualStyleBackColor = true;
            btnAverage.Click += btnAverage_Click;
            // 
            // button1
            // 
            button1.Location = new Point(402, 359);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 7;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(509, 359);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 8;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 439);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnAverage);
            Controls.Add(btnMin);
            Controls.Add(btnMax);
            Controls.Add(richTextBox1);
            Controls.Add(btnDisplay);
            Controls.Add(btnWrite);
            Controls.Add(btnGenerate);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Anmol";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGenerate;
        private Button btnWrite;
        private Button btnDisplay;
        private RichTextBox richTextBox1;
        private Button btnMax;
        private Button btnMin;
        private Button btnAverage;
        private Button button1;
        private Button button2;
    }
}