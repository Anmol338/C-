namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Text = "Hello form PCPS";
            button2.BackColor = System.Drawing.Color.Red;
            button2.ForeColor = System.Drawing.Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           if (button3.Text == "Yes")
            {
                button3.Text = "No";
            }
            else
            {
                button3.Text = "Yes";
            }
        }
    }
}