namespace WinFormsApp1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello!");
            int num1, num2, num3;
            num1 = int.Parse(txtNum1.Text);
            num2 = int.Parse(txtNum2.Text);
            num3 = num1 + num2;
            txtResult.Text = num3.ToString();
            //txtResult.Text = txtNum1.Text + txtNum2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, num3;
            num1 = int.Parse(txtNum1.Text);
            num2 = int.Parse(txtNum2.Text);
            num3 = num1 - num2;
            txtResult.Text = num3.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1, num2, num3;
            num1 = int.Parse(txtNum1.Text);
            num2 = int.Parse(txtNum2.Text);
            num3 = num1 / num2;
            txtResult.Text = num3.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1, num2, num3;
            num1 = int.Parse(txtNum1.Text);
            num2 = int.Parse(txtNum2.Text);
            num3 = num1 * num2;
            txtResult.Text = num3.ToString();
        }
    }
}