namespace OOP_Assignment1_2133112
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pbFloorOne = new PictureBox();
            pbInsideElevator = new PictureBox();
            pbDoorLeftFirst = new PictureBox();
            btnUp = new Button();
            pbDoorRightFirst = new PictureBox();
            groupBox1 = new GroupBox();
            floorStatus = new TextBox();
            btnGround = new Button();
            btnFirstFloor = new Button();
            btnClose = new Button();
            btnOpen = new Button();
            pbElevatorControl = new PictureBox();
            pbRightDoorGround = new PictureBox();
            pbLeftDoorGround = new PictureBox();
            btnDown = new Button();
            pbGroundFloor = new PictureBox();
            timerFirstDoorOpen = new System.Windows.Forms.Timer(components);
            timerFirstDoorClose = new System.Windows.Forms.Timer(components);
            timerGroundDoorOpen = new System.Windows.Forms.Timer(components);
            timerGroundDoorClose = new System.Windows.Forms.Timer(components);
            timerElevatorDown = new System.Windows.Forms.Timer(components);
            timerElevatorUp = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label3 = new Label();
            floorStatus1 = new TextBox();
            data_history = new DataGridView();
            btnDisplay = new Button();
            btnClear = new Button();
            floorStatus2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbFloorOne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbInsideElevator).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDoorLeftFirst).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDoorRightFirst).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbElevatorControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRightDoorGround).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLeftDoorGround).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGroundFloor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)data_history).BeginInit();
            SuspendLayout();
            // 
            // pbFloorOne
            // 
            pbFloorOne.Image = (Image)resources.GetObject("pbFloorOne.Image");
            pbFloorOne.Location = new Point(137, 29);
            pbFloorOne.Name = "pbFloorOne";
            pbFloorOne.Size = new Size(430, 420);
            pbFloorOne.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFloorOne.TabIndex = 0;
            pbFloorOne.TabStop = false;
            // 
            // pbInsideElevator
            // 
            pbInsideElevator.Image = (Image)resources.GetObject("pbInsideElevator.Image");
            pbInsideElevator.Location = new Point(255, 100);
            pbInsideElevator.Name = "pbInsideElevator";
            pbInsideElevator.Size = new Size(192, 326);
            pbInsideElevator.SizeMode = PictureBoxSizeMode.StretchImage;
            pbInsideElevator.TabIndex = 1;
            pbInsideElevator.TabStop = false;
            // 
            // pbDoorLeftFirst
            // 
            pbDoorLeftFirst.Image = (Image)resources.GetObject("pbDoorLeftFirst.Image");
            pbDoorLeftFirst.Location = new Point(255, 100);
            pbDoorLeftFirst.Name = "pbDoorLeftFirst";
            pbDoorLeftFirst.Size = new Size(97, 326);
            pbDoorLeftFirst.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDoorLeftFirst.TabIndex = 2;
            pbDoorLeftFirst.TabStop = false;
            // 
            // btnUp
            // 
            btnUp.Image = (Image)resources.GetObject("btnUp.Image");
            btnUp.Location = new Point(461, 250);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(35, 32);
            btnUp.TabIndex = 4;
            btnUp.UseVisualStyleBackColor = true;
            btnUp.Click += btnUp_Click;
            // 
            // pbDoorRightFirst
            // 
            pbDoorRightFirst.Image = (Image)resources.GetObject("pbDoorRightFirst.Image");
            pbDoorRightFirst.Location = new Point(351, 100);
            pbDoorRightFirst.Name = "pbDoorRightFirst";
            pbDoorRightFirst.Size = new Size(96, 326);
            pbDoorRightFirst.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDoorRightFirst.TabIndex = 11;
            pbDoorRightFirst.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(floorStatus);
            groupBox1.Controls.Add(btnGround);
            groupBox1.Controls.Add(btnFirstFloor);
            groupBox1.Controls.Add(btnClose);
            groupBox1.Controls.Add(btnOpen);
            groupBox1.Controls.Add(pbElevatorControl);
            groupBox1.Location = new Point(573, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(324, 636);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Elevator Control";
            // 
            // floorStatus
            // 
            floorStatus.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            floorStatus.Location = new Point(83, 58);
            floorStatus.Multiline = true;
            floorStatus.Name = "floorStatus";
            floorStatus.Size = new Size(157, 87);
            floorStatus.TabIndex = 20;
            floorStatus.TextAlign = HorizontalAlignment.Center;
            // 
            // btnGround
            // 
            btnGround.Image = (Image)resources.GetObject("btnGround.Image");
            btnGround.Location = new Point(171, 309);
            btnGround.Name = "btnGround";
            btnGround.Size = new Size(69, 68);
            btnGround.TabIndex = 20;
            btnGround.UseVisualStyleBackColor = true;
            btnGround.Click += btnGround_Click;
            // 
            // btnFirstFloor
            // 
            btnFirstFloor.Image = (Image)resources.GetObject("btnFirstFloor.Image");
            btnFirstFloor.Location = new Point(69, 309);
            btnFirstFloor.Name = "btnFirstFloor";
            btnFirstFloor.Size = new Size(69, 68);
            btnFirstFloor.TabIndex = 19;
            btnFirstFloor.UseVisualStyleBackColor = true;
            btnFirstFloor.Click += btnFirstFloor_Click;
            // 
            // btnClose
            // 
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(171, 398);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(69, 68);
            btnClose.TabIndex = 18;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnOpen
            // 
            btnOpen.Image = (Image)resources.GetObject("btnOpen.Image");
            btnOpen.Location = new Point(69, 398);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(69, 68);
            btnOpen.TabIndex = 17;
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // pbElevatorControl
            // 
            pbElevatorControl.Image = (Image)resources.GetObject("pbElevatorControl.Image");
            pbElevatorControl.Location = new Point(15, 39);
            pbElevatorControl.Name = "pbElevatorControl";
            pbElevatorControl.Size = new Size(285, 572);
            pbElevatorControl.TabIndex = 0;
            pbElevatorControl.TabStop = false;
            // 
            // pbRightDoorGround
            // 
            pbRightDoorGround.Image = (Image)resources.GetObject("pbRightDoorGround.Image");
            pbRightDoorGround.Location = new Point(351, 520);
            pbRightDoorGround.Name = "pbRightDoorGround";
            pbRightDoorGround.Size = new Size(96, 326);
            pbRightDoorGround.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRightDoorGround.TabIndex = 16;
            pbRightDoorGround.TabStop = false;
            // 
            // pbLeftDoorGround
            // 
            pbLeftDoorGround.Image = (Image)resources.GetObject("pbLeftDoorGround.Image");
            pbLeftDoorGround.Location = new Point(255, 520);
            pbLeftDoorGround.Name = "pbLeftDoorGround";
            pbLeftDoorGround.Size = new Size(97, 326);
            pbLeftDoorGround.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLeftDoorGround.TabIndex = 14;
            pbLeftDoorGround.TabStop = false;
            // 
            // btnDown
            // 
            btnDown.Image = (Image)resources.GetObject("btnDown.Image");
            btnDown.Location = new Point(461, 670);
            btnDown.Name = "btnDown";
            btnDown.Size = new Size(35, 32);
            btnDown.TabIndex = 15;
            btnDown.UseVisualStyleBackColor = true;
            btnDown.Click += btnDown_Click;
            // 
            // pbGroundFloor
            // 
            pbGroundFloor.Image = (Image)resources.GetObject("pbGroundFloor.Image");
            pbGroundFloor.Location = new Point(137, 449);
            pbGroundFloor.Name = "pbGroundFloor";
            pbGroundFloor.Size = new Size(430, 420);
            pbGroundFloor.SizeMode = PictureBoxSizeMode.StretchImage;
            pbGroundFloor.TabIndex = 12;
            pbGroundFloor.TabStop = false;
            // 
            // timerFirstDoorOpen
            // 
            timerFirstDoorOpen.Interval = 10;
            timerFirstDoorOpen.Tick += timerFirstDoorOpen_Tick;
            // 
            // timerFirstDoorClose
            // 
            timerFirstDoorClose.Interval = 10;
            timerFirstDoorClose.Tick += timerFirstDoorClose_Tick;
            // 
            // timerGroundDoorOpen
            // 
            timerGroundDoorOpen.Interval = 10;
            timerGroundDoorOpen.Tick += timerGroundDoorOpen_Tick;
            // 
            // timerGroundDoorClose
            // 
            timerGroundDoorClose.Interval = 10;
            timerGroundDoorClose.Tick += timerGroundDoorClose_Tick;
            // 
            // timerElevatorDown
            // 
            timerElevatorDown.Interval = 60;
            timerElevatorDown.Tick += timerElevatorDown_Tick;
            // 
            // timerElevatorUp
            // 
            timerElevatorUp.Interval = 60;
            timerElevatorUp.Tick += timerElevatorUp_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 62);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 17;
            label1.Text = "FIRST FLOOR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 473);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 19;
            label3.Text = "GROUND FLOOR";
            label3.Click += label3_Click;
            // 
            // floorStatus1
            // 
            floorStatus1.BackColor = SystemColors.WindowFrame;
            floorStatus1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            floorStatus1.ForeColor = SystemColors.InactiveBorder;
            floorStatus1.Location = new Point(314, 51);
            floorStatus1.Multiline = true;
            floorStatus1.Name = "floorStatus1";
            floorStatus1.Size = new Size(71, 31);
            floorStatus1.TabIndex = 21;
            floorStatus1.TextAlign = HorizontalAlignment.Center;
            // 
            // data_history
            // 
            data_history.BackgroundColor = SystemColors.ActiveCaptionText;
            data_history.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_history.Location = new Point(903, 90);
            data_history.Name = "data_history";
            data_history.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            data_history.RowTemplate.Height = 29;
            data_history.Size = new Size(737, 386);
            data_history.TabIndex = 22;
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(903, 53);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(94, 29);
            btnDisplay.TabIndex = 23;
            btnDisplay.Text = "Display ";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(1345, 55);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 24;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // floorStatus2
            // 
            floorStatus2.BackColor = SystemColors.WindowFrame;
            floorStatus2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            floorStatus2.ForeColor = SystemColors.InactiveBorder;
            floorStatus2.Location = new Point(314, 473);
            floorStatus2.Multiline = true;
            floorStatus2.Name = "floorStatus2";
            floorStatus2.Size = new Size(71, 31);
            floorStatus2.TabIndex = 25;
            floorStatus2.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1667, 872);
            Controls.Add(floorStatus2);
            Controls.Add(btnClear);
            Controls.Add(btnDisplay);
            Controls.Add(data_history);
            Controls.Add(floorStatus1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pbRightDoorGround);
            Controls.Add(pbLeftDoorGround);
            Controls.Add(btnDown);
            Controls.Add(pbDoorRightFirst);
            Controls.Add(pbDoorLeftFirst);
            Controls.Add(groupBox1);
            Controls.Add(btnUp);
            Controls.Add(pbInsideElevator);
            Controls.Add(pbFloorOne);
            Controls.Add(pbGroundFloor);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "s";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbFloorOne).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbInsideElevator).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDoorLeftFirst).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDoorRightFirst).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbElevatorControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRightDoorGround).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLeftDoorGround).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbGroundFloor).EndInit();
            ((System.ComponentModel.ISupportInitialize)data_history).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbFloorOne;
        private PictureBox pbInsideElevator;
        private PictureBox pbDoorLeftFirst;
        private Button btnUp;
        private PictureBox pbDoorRightFirst;
        private GroupBox groupBox1;
        private PictureBox pbElevatorControl;
        private Button btnGround;
        private Button btnFirstFloor;
        private Button btnClose;
        private Button btnOpen;
        private PictureBox pbRightDoorGround;
        private PictureBox pbLeftDoorGround;
        private Button btnDown;
        private PictureBox pictureBox3;
        private PictureBox pbGroundFloor;
        private System.Windows.Forms.Timer timerFirstDoorOpen;
        private System.Windows.Forms.Timer timerFirstDoorClose;
        private System.Windows.Forms.Timer timerGroundDoorOpen;
        private System.Windows.Forms.Timer timerGroundDoorClose;
        private System.Windows.Forms.Timer timerElevatorDown;
        private System.Windows.Forms.Timer timerElevatorUp;
        private Label label1;
        private Label label3;
        private TextBox floorStatus;
        private TextBox floorStatus1;
        private DataGridView dataGridView1;
        private Button btnDisplay;
        private DataGridView data_history;
        private Button btnClear;
        private TextBox floorStatus2;
    }
}