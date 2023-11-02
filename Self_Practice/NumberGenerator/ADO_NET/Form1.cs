using ADO_NET.File_Handling;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_NET
{
    public partial class Form1 : Form
    {
        private ArrayList nums = new ArrayList();
        private int result = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            nums.Clear();
            Random random = new Random();
            for (int i = 1; i <= 40; i++)
            {
                int num = random.Next(16, 24);
                nums.Add(num);
            }

            foreach (int age in nums)
            {
                richTextBox1.AppendText(age.ToString() + " ");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Write all ages in data.txt
            WriteNumbersToFile wf = new WriteNumbersToFile();
            wf.writeIntoFile(nums);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            nums.Clear();
            richTextBox1.Clear();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            nums.Clear();
            ReadNumbersFromFile readnums = new ReadNumbersFromFile();
            nums = readnums.readFile();

            foreach (int num in nums)
            {
                richTextBox1.AppendText(num.ToString() + " ");
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            MaxNum maxNum = new MaxNum();
            result = maxNum.CalculateMaxNumber(nums);
            richTextBox1.AppendText("\nThe max number in the above list is " + result.ToString() + ".");
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            MinNum minNum = new MinNum();
            result = minNum.CalculateMinNumber(nums);
            richTextBox1.AppendText("\nThe min number in the above list is " + result.ToString() + ".");
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            AvgNum avgNum = new AvgNum();
            result = avgNum.CalculateAvgNumber(nums);
            richTextBox1.AppendText("\nThe average of the above list is " + result.ToString() + ".");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
