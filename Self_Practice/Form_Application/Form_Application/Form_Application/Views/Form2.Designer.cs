namespace Form_Application.Views
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
            lbl_id = new Label();
            lbl_name = new Label();
            lbl_Address = new Label();
            lbl_Contact = new Label();
            lbl_Email = new Label();
            lbl_Gender = new Label();
            gp_gender = new GroupBox();
            txt_id = new TextBox();
            txt_fullName = new TextBox();
            txt_address = new TextBox();
            txt_email = new TextBox();
            txt_contact = new TextBox();
            rb_male = new RadioButton();
            rb_female = new RadioButton();
            rb_others = new RadioButton();
            label1 = new Label();
            cmb_age = new ComboBox();
            gp_gender.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Location = new Point(47, 31);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(86, 20);
            lbl_id.TabIndex = 0;
            lbl_id.Text = "Student ID :";
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Location = new Point(47, 78);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(83, 20);
            lbl_name.TabIndex = 1;
            lbl_name.Text = "Full Name :";
            // 
            // lbl_Address
            // 
            lbl_Address.AutoSize = true;
            lbl_Address.Location = new Point(61, 125);
            lbl_Address.Name = "lbl_Address";
            lbl_Address.Size = new Size(69, 20);
            lbl_Address.TabIndex = 2;
            lbl_Address.Text = "Address :";
            // 
            // lbl_Contact
            // 
            lbl_Contact.AutoSize = true;
            lbl_Contact.Location = new Point(61, 165);
            lbl_Contact.Name = "lbl_Contact";
            lbl_Contact.Size = new Size(67, 20);
            lbl_Contact.TabIndex = 3;
            lbl_Contact.Text = "Contact :";
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Location = new Point(75, 207);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(53, 20);
            lbl_Email.TabIndex = 4;
            lbl_Email.Text = "Email :";
            // 
            // lbl_Gender
            // 
            lbl_Gender.AutoSize = true;
            lbl_Gender.Location = new Point(61, 259);
            lbl_Gender.Name = "lbl_Gender";
            lbl_Gender.Size = new Size(64, 20);
            lbl_Gender.TabIndex = 5;
            lbl_Gender.Text = "Gender :";
            // 
            // gp_gender
            // 
            gp_gender.Controls.Add(rb_others);
            gp_gender.Controls.Add(rb_female);
            gp_gender.Controls.Add(rb_male);
            gp_gender.Location = new Point(139, 237);
            gp_gender.Name = "gp_gender";
            gp_gender.Size = new Size(236, 52);
            gp_gender.TabIndex = 6;
            gp_gender.TabStop = false;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(139, 24);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(287, 27);
            txt_id.TabIndex = 7;
            // 
            // txt_fullName
            // 
            txt_fullName.Location = new Point(139, 75);
            txt_fullName.Name = "txt_fullName";
            txt_fullName.Size = new Size(287, 27);
            txt_fullName.TabIndex = 8;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(139, 122);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(287, 27);
            txt_address.TabIndex = 9;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(139, 204);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(287, 27);
            txt_email.TabIndex = 10;
            // 
            // txt_contact
            // 
            txt_contact.Location = new Point(139, 162);
            txt_contact.Name = "txt_contact";
            txt_contact.Size = new Size(287, 27);
            txt_contact.TabIndex = 11;
            // 
            // rb_male
            // 
            rb_male.AutoSize = true;
            rb_male.Location = new Point(6, 18);
            rb_male.Name = "rb_male";
            rb_male.Size = new Size(63, 24);
            rb_male.TabIndex = 0;
            rb_male.TabStop = true;
            rb_male.Text = "Male";
            rb_male.UseVisualStyleBackColor = true;
            // 
            // rb_female
            // 
            rb_female.AutoSize = true;
            rb_female.Location = new Point(75, 18);
            rb_female.Name = "rb_female";
            rb_female.Size = new Size(78, 24);
            rb_female.TabIndex = 1;
            rb_female.TabStop = true;
            rb_female.Text = "Female";
            rb_female.UseVisualStyleBackColor = true;
            // 
            // rb_others
            // 
            rb_others.AutoSize = true;
            rb_others.Location = new Point(159, 18);
            rb_others.Name = "rb_others";
            rb_others.Size = new Size(73, 24);
            rb_others.TabIndex = 2;
            rb_others.TabStop = true;
            rb_others.Text = "Others";
            rb_others.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 302);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 12;
            label1.Text = "Age :";
            // 
            // cmb_age
            // 
            cmb_age.FormattingEnabled = true;
            cmb_age.Items.AddRange(new object[] { "1-16", "16-25", "26-30", "30-45", "45-60", "60+" });
            cmb_age.Location = new Point(139, 299);
            cmb_age.Name = "cmb_age";
            cmb_age.Size = new Size(287, 28);
            cmb_age.TabIndex = 13;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmb_age);
            Controls.Add(label1);
            Controls.Add(txt_contact);
            Controls.Add(txt_email);
            Controls.Add(txt_address);
            Controls.Add(txt_fullName);
            Controls.Add(txt_id);
            Controls.Add(gp_gender);
            Controls.Add(lbl_Gender);
            Controls.Add(lbl_Email);
            Controls.Add(lbl_Contact);
            Controls.Add(lbl_Address);
            Controls.Add(lbl_name);
            Controls.Add(lbl_id);
            Name = "Form2";
            Text = "Form2";
            gp_gender.ResumeLayout(false);
            gp_gender.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_id;
        private Label lbl_name;
        private Label lbl_Address;
        private Label lbl_Contact;
        private Label lbl_Email;
        private Label lbl_Gender;
        private GroupBox gp_gender;
        private TextBox txt_id;
        private TextBox txt_fullName;
        private TextBox txt_address;
        private TextBox txt_email;
        private TextBox txt_contact;
        private RadioButton rb_others;
        private RadioButton rb_female;
        private RadioButton rb_male;
        private Label label1;
        private ComboBox cmb_age;
    }
}